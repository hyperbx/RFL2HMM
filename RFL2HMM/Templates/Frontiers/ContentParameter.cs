using System.Numerics;
using System.Runtime.InteropServices;

public class ContentParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x02)]
    public struct AddDatabaseInfo
    {
        [FieldOffset(0x00)] public byte recordNo;
        [FieldOffset(0x01)] public byte numRecords;
    }

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

            set => pValue = Marshal.StringToHGlobalAnsi(value);
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
    public struct ContentParameter
    {
        [FieldOffset(0x00)] public AddDatabaseInfo databases__arr0;
        [FieldOffset(0x02)] public AddDatabaseInfo databases__arr1;
        [FieldOffset(0x08)] public UnmanagedString stagedata;
    }

}