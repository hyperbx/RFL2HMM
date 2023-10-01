using System.Reflection;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace RFL2HMM
{
    class DiffVmProvider
    {
        private static string _scriptTemplate(string originalFilePath, string modifiedFilePath, string gameName, string templateName) =>
        $$"""
            using System;
            using System.Collections.Generic;
            using System.IO;
            using System.Reflection;

            {{File.ReadAllText($@"Templates\{gameName}\{templateName}.cs")}}

            namespace RFL2HMM
            {
                public unsafe class DiffVm
                {
                    private static Dictionary<string, object> _diffResults = new();
                    
                    private static List<string> _keywords = new()
                    {
        	            "abstract",
        	            "as",
        	            "base",
        	            "bool",
        	            "break",
        	            "byte",
        	            "case",
        	            "catch",
        	            "char",
        	            "checked",
        	            "class",
        	            "const",
        	            "continue",
        	            "decimal",
        	            "default",
        	            "delegate",
        	            "do",
        	            "double",
        	            "else",
        	            "enum",
        	            "event",
        	            "explicit",
        	            "extern",
        	            "false",
        	            "finally",
        	            "fixed",
        	            "float",
        	            "for",
        	            "foreach",
        	            "goto",
        	            "if",
        	            "implicit",
        	            "in",
        	            "int",
        	            "interface",
        	            "internal",
        	            "is",
        	            "lock",
        	            "long",
        	            "namespace",
        	            "new",
        	            "null",
        	            "object",
        	            "operator",
        	            "out",
        	            "override",
        	            "params",
        	            "private",
        	            "protected",
        	            "public",
        	            "readonly",
        	            "ref",
        	            "return",
        	            "sbyte",
        	            "sealed",
        	            "short",
        	            "sizeof",
        	            "stackalloc",
        	            "static",
        	            "string",
        	            "struct",
        	            "switch",
        	            "this",
        	            "throw",
        	            "true",
        	            "try",
        	            "typeof",
        	            "uint",
        	            "ulong",
        	            "unchecked",
        	            "unsafe",
        	            "ushort",
        	            "using",
        	            "virtual",
        	            "void",
        	            "volatile",
        	            "while"
                    };
        
                    private static {{templateName}}Class.{{templateName}}* _pOriginal{{templateName}};
                    private static {{templateName}}Class.{{templateName}}* _pModified{{templateName}};

                    public static unsafe Dictionary<string, object> Main()
                    {
                        byte[] originalFileData = File.ReadAllBytes(@"{{originalFilePath}}");
                        byte[] modifiedFileData = File.ReadAllBytes(@"{{modifiedFilePath}}");

                        fixed (byte* pOriginalFileData = originalFileData)
                            _pOriginal{{templateName}} = ({{templateName}}Class.{{templateName}}*)(pOriginalFileData + 0x40);

                        fixed (byte* pModifiedFileData = modifiedFileData)
                            _pModified{{templateName}} = ({{templateName}}Class.{{templateName}}*)(pModifiedFileData + 0x40);

                        DiffStructs(*_pOriginal{{templateName}}, *_pModified{{templateName}}, string.Empty, "{{templateName}}");

                        return _diffResults;
                    }

                    static unsafe void DiffStructs(object instance1, object instance2, string currentStructName, string hierarchy)
                    {
                        Type type1 = instance1.GetType();
                        Type type2 = instance2.GetType();

                        foreach (FieldInfo field in type1.GetFields(BindingFlags.Instance | BindingFlags.Public))
                        {
                            object value1 = field.GetValue(instance1);
                            object value2 = field.GetValue(instance2);
                            string fieldName = field.Name;

                            // Remove first underscore to redirect to original name.
                            if (fieldName.StartsWith("_") && !_keywords.Contains(fieldName.Substring(1)))
                                fieldName = fieldName.Substring(1);

                            // Field is a struct.
                            if (field.FieldType.IsValueType && !field.FieldType.IsPrimitive && !field.FieldType.IsEnum)
                            {
                                string newHierarchy = string.Empty;

                                if (fieldName != currentStructName)
                                    newHierarchy = hierarchy + $".{fieldName}";

                                DiffStructs(value1, value2, fieldName, newHierarchy);
                            }
                            else
                            {
                                if (!Equals(value1, value2))
                                {
                                    int firstHierarchyIndex = hierarchy.IndexOf(".") + 1;
                                    string hierarchyWithoutRoot = hierarchy.Substring(firstHierarchyIndex, hierarchy.Length - firstHierarchyIndex);

                                    if (field.ReflectedType == typeof(UnmanagedString))
                                    {
                                        if ((long)value2 == 0)
                                        {
                                            _diffResults.Add($"{hierarchyWithoutRoot}.{fieldName}", value2);
                                        }
                                        else
                                        {
                                            string actualValue = Marshal.PtrToStringAnsi((IntPtr)(((long)_pModified{{templateName}}) + ((long)value2)));
        
                                            _diffResults.Add(hierarchyWithoutRoot, value2 == null ? "(null)" : $"\"{actualValue}\"");
                                        }
                                    }
                                    else
                                    {
                                        _diffResults.Add($"{hierarchyWithoutRoot}.{fieldName}", value2);
                                    }
                                }
                            }
                        }
                    }
                }

                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public unsafe struct UnmanagedString
                {
                    [FieldOffset(0)] public long pValue;

                    public string Value
                    {
                        get
                        {
                            if (pValue == 0)
                                return string.Empty;

                            return Marshal.PtrToStringAnsi((nint)pValue);
                        }

                        set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
                    }

                    public UnmanagedString(string in_value)
                    {
                        Value = in_value;
                    }

                    public static implicit operator UnmanagedString(string in_value)
                    {
                        return new UnmanagedString(in_value);
                    }

                    public static bool operator ==(UnmanagedString in_left, string in_right)
                    {
                        return in_left.Value == in_right;
                    }

                    public static bool operator !=(UnmanagedString in_left, string in_right)
                    {
                        return !(in_left == in_right);
                    }

                    public override bool Equals(object in_obj)
                    {
                        if (in_obj is string str)
                            return Value == str;

                        return base.Equals(in_obj);
                    }

                    public override int GetHashCode()
                    {
                        return Value.GetHashCode();
                    }

                    public override string ToString()
                    {
                        return Value;
                    }
                }
            }
        """;

        public static Dictionary<string, object> Run(string originalFilePath, string modifiedFilePath, string gameName, string templateName)
        {
            var options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, allowUnsafe: true);
            var syntaxTree = CSharpSyntaxTree.ParseText(_scriptTemplate(originalFilePath, modifiedFilePath, gameName, templateName));
            var references = new MetadataReference[] { MetadataReference.CreateFromFile(typeof(object).Assembly.Location) };
            var compilation = CSharpCompilation.Create("DynamicScript", new[] { syntaxTree }, references, options);

#if DEBUG
            Console.WriteLine();

            int i = 0;
            foreach (var line in _scriptTemplate(originalFilePath, modifiedFilePath, gameName, templateName).Split("\n"))
            {
                i++;
                Console.WriteLine($"{i:0000} | {line}");
            }
#endif

            using (var ms = new MemoryStream())
            {
                var result = compilation.Emit(ms);

                if (result.Success)
                {
                    ms.Seek(0, SeekOrigin.Begin);

                    var assembly = Assembly.Load(ms.ToArray());
                    var scriptType = assembly.GetType("RFL2HMM.DiffVm");
                    var method = scriptType.GetMethod("Main");
                    object instance = null;

                    if (!method.IsStatic)
                        instance = Activator.CreateInstance(scriptType);

                    return (Dictionary<string, object>)method.Invoke(instance, null);
                }
                else
                {
                    foreach (var diagnostic in result.Diagnostics)
                        Console.WriteLine(diagnostic.ToString());
                }
            }

            return null;
        }
    }
}
