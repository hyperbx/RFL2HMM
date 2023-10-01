using System.Globalization;
using System.Text;

namespace RFL2HMM
{
    class Program
    {
        private const string _version = "1.2.2";
        private const string _arrayDelimiter = "__arr";

        private static StringBuilder _output = new();

        private static List<string> _builtInTypes = new()
        {
            "CustomMusicParameter",
            "SonicParameters",
            "AmyParameters",
            "KnucklesParameters",
            "TailsParameters",
            "UIRflParam"
        };

        static void Main(string[] args)
        {
            Console.WriteLine
            (
                $"RFL2HMM v{_version} - RFL to HMM Code Converter\n" +
                "Written by Hyper\n"
            );

            // Force culture info to English (United Kingdom) to prevent erroneous formatting from other regions.
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("en-GB");

            if (args.Length > 5 || args.Length < 4)
            {
                Console.Write
                (
                    "Usage;\n" +
                    "- RFL2HMM.exe gameName templateName \"original.rfl\" \"modified.rfl\"\n" +
                    "- RFL2HMM.exe gameName templateName \"original.rfl\" \"modified.rfl\" \"output.hmm\"\n\n" +
                    "" +
                    "Examples;\n" +
                    "- RFL2HMM.exe Frontiers SonicParameters \"player_common.rfl\" \"modified_player_common.rfl\"\n" +
                    "- RFL2HMM.exe Origins UIRflParam \"ui_rfl_param.rfl\" \"modified_ui_rfl_param.rfl\"\n\n" +
                    "" +
                    "Information;\n" +
                    "- For the template name, browse the \"Templates\" folder provided and use the file name.\n" +
                    "- The original RFL file must use the original file name from the game data, this is used to load it from the HMM code.\n\n" +
                    "" +
                    "Press any key to exit..."
                );

                Console.ReadKey();

                return;
            }

            string gameName = args[0];
            string templateName = args[1];
            string originalFilePath = args[2];
            string modifiedFilePath = args[3];

            if (!File.Exists(Path.Combine("Templates", gameName, $"{templateName}.cs")))
            {
                Console.WriteLine($"Failed to locate file: \"{templateName}.cs\"");
                return;
            }

            if (!File.Exists(originalFilePath))
            {
                Console.WriteLine($"Failed to locate file: \"{originalFilePath}\"");
                return;
            }

            if (!File.Exists(modifiedFilePath))
            {
                Console.WriteLine($"Failed to locate file: \"{modifiedFilePath}\"");
                return;
            }

            string outputFilePath = Path.Combine(Path.GetDirectoryName(modifiedFilePath), $"{Path.GetFileNameWithoutExtension(modifiedFilePath)}.hmm");

            if (args.Length > 4)
                outputFilePath = args[4];

            Console.Write("Comparing reflection data...");

            var diffResults = DiffVmProvider.Run(originalFilePath, modifiedFilePath, gameName, templateName);

            if (diffResults == null)
            {
                Console.Write(" Failed.\n\nError: null comparison result.");
                return;
            }

            Console.WriteLine(" Success.\n");

            if (diffResults.Count == 0)
            {
                Console.Write("No differences found.");
                return;
            }

            _output.AppendLine($"Code \"{templateName}-{DateTime.Now:hhmmssddMMyyyy}\"\n//");
            _output.AppendLine($"\t#include \"{(gameName == "Origins" ? "ReflectionHelpers" : "Reflection")}\" noemit\n");

            if (gameName == "Frontiers")
                _output.AppendLine("\t#lib \"Reflection\"");

            _output.AppendLine($"\t#lib \"{templateName}\"\n//\n{{");

            _output.AppendLine
            (
                $"\tvar {templateName}Info = Reflection.GetDataInfo<{templateName}.Root>(\"{Path.GetFileNameWithoutExtension(originalFilePath)}\");\n\n" +
                "" +
                $"\tif ({templateName}Info.pData == null)\n" +
                "\t\treturn;\n"
            );

            foreach (var diff in diffResults)
            {
                string hierarchy = diff.Key;
                object value = diff.Value;

                if (hierarchy.Contains(_arrayDelimiter))
                {
                    var arrIndices = GetSubstringIndices(hierarchy, _arrayDelimiter);

                    foreach (int i in arrIndices)
                    {
                        int nextHierarchyIndex = hierarchy.IndexOf(".", i);

                        if (nextHierarchyIndex == -1)
                            nextHierarchyIndex = hierarchy.Length;

                        hierarchy = hierarchy.Insert(nextHierarchyIndex, "]");
                    }

                    hierarchy = hierarchy.Replace(_arrayDelimiter, "[");
                }

                _output.Append($"\tRFL_SET_PARAM({templateName}Info, {hierarchy}, ");

                if (value is Enum enumValue)
                {
                    _output.Append($"{templateName}.{enumValue.GetType().Name}.{enumValue}");
                }
                else
                {
                    if (value.GetType() == typeof(bool))
                    {
                        _output.Append(value.ToString().ToLowerInvariant());
                    }
                    else if (value.GetType() == typeof(float))
                    {
                        string floatStr = ((float)value).ToString();

                        // Handle precise floats with E notation on string output.
                        if (floatStr.Contains('e', StringComparison.OrdinalIgnoreCase))
                            floatStr = ((float)value).ToString("F99").TrimEnd('0');

                        _output.Append(floatStr);

                        if (floatStr.ToString().Contains("."))
                        {
                            _output.Append("f");
                        }
                        else
                        {
                            _output.Append(".0f");
                        }
                    }
                    else
                    {
                        _output.Append(value);
                    }
                }

                _output.Append(");\n");
            }

            _output.AppendLine("}");

            try
            {
                if (!_builtInTypes.Contains(templateName))
                {
                    Console.WriteLine("Writing external template to code file...\n");

                    string libraryFilePath = Path.Combine("Libraries", gameName, $"{templateName}.hmm");

                    if (File.Exists(libraryFilePath))
                    {
                        string libraryCode = File.ReadAllText(libraryFilePath);

                        // Rename root struct since it'll share the name with the library class.
                        libraryCode = libraryCode.Replace($"public struct {templateName}", "public struct Root");

                        _output.AppendLine($"\n{libraryCode}");
                    }
                    else
                    {
                        Console.WriteLine($"Failed to locate file: \"{templateName}.hmm\"\n");
                        Console.WriteLine("WARNING: writing code file without external template!\n");
                    }
                }

                File.WriteAllText(outputFilePath, _output.ToString());

                Console.Write($"Code file written to: \"{outputFilePath}\"");
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        static List<int> GetSubstringIndices(string str, string substr)
        {
            var indices = new List<int>();

            int i = 0;
            while ((i = str.IndexOf(substr, i)) != -1)
            {
                indices.Add(i);
                i += substr.Length;
            }

            return indices;
        }
    }
}