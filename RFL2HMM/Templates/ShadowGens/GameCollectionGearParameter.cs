Library "GameCollectionGearParameter"
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

    public enum Color : int
    {
        NotEarned = -1,
        Yellow = 0,
        Blue = 1,
        Green = 2,
        None = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct GameCollectionGearData
    {
        [FieldOffset(0x00)] public UnmanagedString stageID;
        [FieldOffset(0x10)] public Color color__arr0;
        [FieldOffset(0x14)] public Color color__arr1;
        [FieldOffset(0x18)] public Color color__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x800)]
    public struct GameCollectionGearParameter
    {
        [FieldOffset(0x00)] public GameCollectionGearData Datas__arr0;
        [FieldOffset(0x20)] public GameCollectionGearData Datas__arr1;
        [FieldOffset(0x40)] public GameCollectionGearData Datas__arr2;
        [FieldOffset(0x60)] public GameCollectionGearData Datas__arr3;
        [FieldOffset(0x80)] public GameCollectionGearData Datas__arr4;
        [FieldOffset(0xA0)] public GameCollectionGearData Datas__arr5;
        [FieldOffset(0xC0)] public GameCollectionGearData Datas__arr6;
        [FieldOffset(0xE0)] public GameCollectionGearData Datas__arr7;
        [FieldOffset(0x100)] public GameCollectionGearData Datas__arr8;
        [FieldOffset(0x120)] public GameCollectionGearData Datas__arr9;
        [FieldOffset(0x140)] public GameCollectionGearData Datas__arr10;
        [FieldOffset(0x160)] public GameCollectionGearData Datas__arr11;
        [FieldOffset(0x180)] public GameCollectionGearData Datas__arr12;
        [FieldOffset(0x1A0)] public GameCollectionGearData Datas__arr13;
        [FieldOffset(0x1C0)] public GameCollectionGearData Datas__arr14;
        [FieldOffset(0x1E0)] public GameCollectionGearData Datas__arr15;
        [FieldOffset(0x200)] public GameCollectionGearData Datas__arr16;
        [FieldOffset(0x220)] public GameCollectionGearData Datas__arr17;
        [FieldOffset(0x240)] public GameCollectionGearData Datas__arr18;
        [FieldOffset(0x260)] public GameCollectionGearData Datas__arr19;
        [FieldOffset(0x280)] public GameCollectionGearData Datas__arr20;
        [FieldOffset(0x2A0)] public GameCollectionGearData Datas__arr21;
        [FieldOffset(0x2C0)] public GameCollectionGearData Datas__arr22;
        [FieldOffset(0x2E0)] public GameCollectionGearData Datas__arr23;
        [FieldOffset(0x300)] public GameCollectionGearData Datas__arr24;
        [FieldOffset(0x320)] public GameCollectionGearData Datas__arr25;
        [FieldOffset(0x340)] public GameCollectionGearData Datas__arr26;
        [FieldOffset(0x360)] public GameCollectionGearData Datas__arr27;
        [FieldOffset(0x380)] public GameCollectionGearData Datas__arr28;
        [FieldOffset(0x3A0)] public GameCollectionGearData Datas__arr29;
        [FieldOffset(0x3C0)] public GameCollectionGearData Datas__arr30;
        [FieldOffset(0x3E0)] public GameCollectionGearData Datas__arr31;
        [FieldOffset(0x400)] public GameCollectionGearData Datas__arr32;
        [FieldOffset(0x420)] public GameCollectionGearData Datas__arr33;
        [FieldOffset(0x440)] public GameCollectionGearData Datas__arr34;
        [FieldOffset(0x460)] public GameCollectionGearData Datas__arr35;
        [FieldOffset(0x480)] public GameCollectionGearData Datas__arr36;
        [FieldOffset(0x4A0)] public GameCollectionGearData Datas__arr37;
        [FieldOffset(0x4C0)] public GameCollectionGearData Datas__arr38;
        [FieldOffset(0x4E0)] public GameCollectionGearData Datas__arr39;
        [FieldOffset(0x500)] public GameCollectionGearData Datas__arr40;
        [FieldOffset(0x520)] public GameCollectionGearData Datas__arr41;
        [FieldOffset(0x540)] public GameCollectionGearData Datas__arr42;
        [FieldOffset(0x560)] public GameCollectionGearData Datas__arr43;
        [FieldOffset(0x580)] public GameCollectionGearData Datas__arr44;
        [FieldOffset(0x5A0)] public GameCollectionGearData Datas__arr45;
        [FieldOffset(0x5C0)] public GameCollectionGearData Datas__arr46;
        [FieldOffset(0x5E0)] public GameCollectionGearData Datas__arr47;
        [FieldOffset(0x600)] public GameCollectionGearData Datas__arr48;
        [FieldOffset(0x620)] public GameCollectionGearData Datas__arr49;
        [FieldOffset(0x640)] public GameCollectionGearData Datas__arr50;
        [FieldOffset(0x660)] public GameCollectionGearData Datas__arr51;
        [FieldOffset(0x680)] public GameCollectionGearData Datas__arr52;
        [FieldOffset(0x6A0)] public GameCollectionGearData Datas__arr53;
        [FieldOffset(0x6C0)] public GameCollectionGearData Datas__arr54;
        [FieldOffset(0x6E0)] public GameCollectionGearData Datas__arr55;
        [FieldOffset(0x700)] public GameCollectionGearData Datas__arr56;
        [FieldOffset(0x720)] public GameCollectionGearData Datas__arr57;
        [FieldOffset(0x740)] public GameCollectionGearData Datas__arr58;
        [FieldOffset(0x760)] public GameCollectionGearData Datas__arr59;
        [FieldOffset(0x780)] public GameCollectionGearData Datas__arr60;
        [FieldOffset(0x7A0)] public GameCollectionGearData Datas__arr61;
        [FieldOffset(0x7C0)] public GameCollectionGearData Datas__arr62;
        [FieldOffset(0x7E0)] public GameCollectionGearData Datas__arr63;
    }

}