using System.Numerics;
using System.Runtime.InteropServices;

public class CaptionParameterClass
{
    public enum DisplayType : sbyte
    {
        Caption = 0,
        Tutorial = 1
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

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct LabelData
    {
        [FieldOffset(0x00)] public DisplayType display;
        [FieldOffset(0x08)] public UnmanagedString label;
        [FieldOffset(0x18)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x288)]
    public struct Discussion
    {
        [FieldOffset(0x00)] public LabelData labels__arr0;
        [FieldOffset(0x20)] public LabelData labels__arr1;
        [FieldOffset(0x40)] public LabelData labels__arr2;
        [FieldOffset(0x60)] public LabelData labels__arr3;
        [FieldOffset(0x80)] public LabelData labels__arr4;
        [FieldOffset(0xA0)] public LabelData labels__arr5;
        [FieldOffset(0xC0)] public LabelData labels__arr6;
        [FieldOffset(0xE0)] public LabelData labels__arr7;
        [FieldOffset(0x100)] public LabelData labels__arr8;
        [FieldOffset(0x120)] public LabelData labels__arr9;
        [FieldOffset(0x140)] public LabelData labels__arr10;
        [FieldOffset(0x160)] public LabelData labels__arr11;
        [FieldOffset(0x180)] public LabelData labels__arr12;
        [FieldOffset(0x1A0)] public LabelData labels__arr13;
        [FieldOffset(0x1C0)] public LabelData labels__arr14;
        [FieldOffset(0x1E0)] public LabelData labels__arr15;
        [FieldOffset(0x200)] public LabelData labels__arr16;
        [FieldOffset(0x220)] public LabelData labels__arr17;
        [FieldOffset(0x240)] public LabelData labels__arr18;
        [FieldOffset(0x260)] public LabelData labels__arr19;
        [FieldOffset(0x280)] public bool isForcePlay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1950)]
    public struct CaptionParameter
    {
        [FieldOffset(0x00)] public Discussion discussions__arr0;
        [FieldOffset(0x288)] public Discussion discussions__arr1;
        [FieldOffset(0x510)] public Discussion discussions__arr2;
        [FieldOffset(0x798)] public Discussion discussions__arr3;
        [FieldOffset(0xA20)] public Discussion discussions__arr4;
        [FieldOffset(0xCA8)] public Discussion discussions__arr5;
        [FieldOffset(0xF30)] public Discussion discussions__arr6;
        [FieldOffset(0x11B8)] public Discussion discussions__arr7;
        [FieldOffset(0x1440)] public Discussion discussions__arr8;
        [FieldOffset(0x16C8)] public Discussion discussions__arr9;
    }

}