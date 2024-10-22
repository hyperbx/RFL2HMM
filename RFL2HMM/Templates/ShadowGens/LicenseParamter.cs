Library "LicenseParamter"
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
    public struct LicenseItemInfo
    {
        [FieldOffset(0x00)] public sbyte pageIndex;
        [FieldOffset(0x08)] public UnmanagedString label;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C8)]
    public struct LicenseInfo
    {
        [FieldOffset(0x00)] public bool isEnable;
        [FieldOffset(0x04)] public float fontScale;
        [FieldOffset(0x08)] public LicenseItemInfo infos__arr0;
        [FieldOffset(0x20)] public LicenseItemInfo infos__arr1;
        [FieldOffset(0x38)] public LicenseItemInfo infos__arr2;
        [FieldOffset(0x50)] public LicenseItemInfo infos__arr3;
        [FieldOffset(0x68)] public LicenseItemInfo infos__arr4;
        [FieldOffset(0x80)] public LicenseItemInfo infos__arr5;
        [FieldOffset(0x98)] public LicenseItemInfo infos__arr6;
        [FieldOffset(0xB0)] public LicenseItemInfo infos__arr7;
        [FieldOffset(0xC8)] public LicenseItemInfo infos__arr8;
        [FieldOffset(0xE0)] public LicenseItemInfo infos__arr9;
        [FieldOffset(0xF8)] public LicenseItemInfo infos__arr10;
        [FieldOffset(0x110)] public LicenseItemInfo infos__arr11;
        [FieldOffset(0x128)] public LicenseItemInfo infos__arr12;
        [FieldOffset(0x140)] public LicenseItemInfo infos__arr13;
        [FieldOffset(0x158)] public LicenseItemInfo infos__arr14;
        [FieldOffset(0x170)] public LicenseItemInfo infos__arr15;
        [FieldOffset(0x188)] public LicenseItemInfo infos__arr16;
        [FieldOffset(0x1A0)] public LicenseItemInfo infos__arr17;
        [FieldOffset(0x1B8)] public LicenseItemInfo infos__arr18;
        [FieldOffset(0x1D0)] public LicenseItemInfo infos__arr19;
        [FieldOffset(0x1E8)] public LicenseItemInfo infos__arr20;
        [FieldOffset(0x200)] public LicenseItemInfo infos__arr21;
        [FieldOffset(0x218)] public LicenseItemInfo infos__arr22;
        [FieldOffset(0x230)] public LicenseItemInfo infos__arr23;
        [FieldOffset(0x248)] public LicenseItemInfo infos__arr24;
        [FieldOffset(0x260)] public LicenseItemInfo infos__arr25;
        [FieldOffset(0x278)] public LicenseItemInfo infos__arr26;
        [FieldOffset(0x290)] public LicenseItemInfo infos__arr27;
        [FieldOffset(0x2A8)] public LicenseItemInfo infos__arr28;
        [FieldOffset(0x2C0)] public LicenseItemInfo infos__arr29;
        [FieldOffset(0x2D8)] public LicenseItemInfo infos__arr30;
        [FieldOffset(0x2F0)] public LicenseItemInfo infos__arr31;
        [FieldOffset(0x308)] public LicenseItemInfo infos__arr32;
        [FieldOffset(0x320)] public LicenseItemInfo infos__arr33;
        [FieldOffset(0x338)] public LicenseItemInfo infos__arr34;
        [FieldOffset(0x350)] public LicenseItemInfo infos__arr35;
        [FieldOffset(0x368)] public LicenseItemInfo infos__arr36;
        [FieldOffset(0x380)] public LicenseItemInfo infos__arr37;
        [FieldOffset(0x398)] public LicenseItemInfo infos__arr38;
        [FieldOffset(0x3B0)] public LicenseItemInfo infos__arr39;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1A78)]
    public struct LicenseParamter
    {
        [FieldOffset(0x00)] public LicenseInfo ps4_Infos;
        [FieldOffset(0x3C8)] public LicenseInfo ps5_Infos;
        [FieldOffset(0x790)] public LicenseInfo xbox_Infos;
        [FieldOffset(0xB58)] public LicenseInfo scarlett_Infos;
        [FieldOffset(0xF20)] public LicenseInfo nx_Infos;
        [FieldOffset(0x12E8)] public LicenseInfo steam_Infos;
        [FieldOffset(0x16B0)] public LicenseInfo epic_Infos;
    }

}