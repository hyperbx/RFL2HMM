Library "GeraldNoteRflParam"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct UnmanagedString
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

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PathData
    {
        [FieldOffset(0x00)] public UnmanagedString pathName;
        [FieldOffset(0x10)] public float moveSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct FixedNoteData
    {
        [FieldOffset(0x00)] public UnmanagedString pathName;
        [FieldOffset(0x10)] public int id;
        [FieldOffset(0x14)] public float moveSpeed;
        [FieldOffset(0x18)] public float respawnTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x110)]
    public struct GeraldNoteRflParam
    {
        [FieldOffset(0x00)] public PathData pathList__arr0;
        [FieldOffset(0x18)] public PathData pathList__arr1;
        [FieldOffset(0x30)] public PathData pathList__arr2;
        [FieldOffset(0x48)] public int idlist__arr0;
        [FieldOffset(0x4C)] public int idlist__arr1;
        [FieldOffset(0x50)] public int idlist__arr2;
        [FieldOffset(0x54)] public int idlist__arr3;
        [FieldOffset(0x58)] public int idlist__arr4;
        [FieldOffset(0x5C)] public int idlist__arr5;
        [FieldOffset(0x60)] public int idlist__arr6;
        [FieldOffset(0x64)] public int idlist__arr7;
        [FieldOffset(0x68)] public float respawnTime;
        [FieldOffset(0x70)] public FixedNoteData fixedData__arr0;
        [FieldOffset(0x90)] public FixedNoteData fixedData__arr1;
        [FieldOffset(0xB0)] public FixedNoteData fixedData__arr2;
        [FieldOffset(0xD0)] public FixedNoteData eclipsFixedData__arr0;
        [FieldOffset(0xF0)] public FixedNoteData eclipsFixedData__arr1;
    }

}