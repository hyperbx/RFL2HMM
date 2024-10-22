Library "GameLightGaugeParameter"
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
    public struct GameLightGaugeParameterData
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public int value;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x780)]
    public struct GameLightGaugeParameter
    {
        [FieldOffset(0x00)] public GameLightGaugeParameterData data__arr0;
        [FieldOffset(0x18)] public GameLightGaugeParameterData data__arr1;
        [FieldOffset(0x30)] public GameLightGaugeParameterData data__arr2;
        [FieldOffset(0x48)] public GameLightGaugeParameterData data__arr3;
        [FieldOffset(0x60)] public GameLightGaugeParameterData data__arr4;
        [FieldOffset(0x78)] public GameLightGaugeParameterData data__arr5;
        [FieldOffset(0x90)] public GameLightGaugeParameterData data__arr6;
        [FieldOffset(0xA8)] public GameLightGaugeParameterData data__arr7;
        [FieldOffset(0xC0)] public GameLightGaugeParameterData data__arr8;
        [FieldOffset(0xD8)] public GameLightGaugeParameterData data__arr9;
        [FieldOffset(0xF0)] public GameLightGaugeParameterData data__arr10;
        [FieldOffset(0x108)] public GameLightGaugeParameterData data__arr11;
        [FieldOffset(0x120)] public GameLightGaugeParameterData data__arr12;
        [FieldOffset(0x138)] public GameLightGaugeParameterData data__arr13;
        [FieldOffset(0x150)] public GameLightGaugeParameterData data__arr14;
        [FieldOffset(0x168)] public GameLightGaugeParameterData data__arr15;
        [FieldOffset(0x180)] public GameLightGaugeParameterData data__arr16;
        [FieldOffset(0x198)] public GameLightGaugeParameterData data__arr17;
        [FieldOffset(0x1B0)] public GameLightGaugeParameterData data__arr18;
        [FieldOffset(0x1C8)] public GameLightGaugeParameterData data__arr19;
        [FieldOffset(0x1E0)] public GameLightGaugeParameterData data__arr20;
        [FieldOffset(0x1F8)] public GameLightGaugeParameterData data__arr21;
        [FieldOffset(0x210)] public GameLightGaugeParameterData data__arr22;
        [FieldOffset(0x228)] public GameLightGaugeParameterData data__arr23;
        [FieldOffset(0x240)] public GameLightGaugeParameterData data__arr24;
        [FieldOffset(0x258)] public GameLightGaugeParameterData data__arr25;
        [FieldOffset(0x270)] public GameLightGaugeParameterData data__arr26;
        [FieldOffset(0x288)] public GameLightGaugeParameterData data__arr27;
        [FieldOffset(0x2A0)] public GameLightGaugeParameterData data__arr28;
        [FieldOffset(0x2B8)] public GameLightGaugeParameterData data__arr29;
        [FieldOffset(0x2D0)] public GameLightGaugeParameterData data__arr30;
        [FieldOffset(0x2E8)] public GameLightGaugeParameterData data__arr31;
        [FieldOffset(0x300)] public GameLightGaugeParameterData data__arr32;
        [FieldOffset(0x318)] public GameLightGaugeParameterData data__arr33;
        [FieldOffset(0x330)] public GameLightGaugeParameterData data__arr34;
        [FieldOffset(0x348)] public GameLightGaugeParameterData data__arr35;
        [FieldOffset(0x360)] public GameLightGaugeParameterData data__arr36;
        [FieldOffset(0x378)] public GameLightGaugeParameterData data__arr37;
        [FieldOffset(0x390)] public GameLightGaugeParameterData data__arr38;
        [FieldOffset(0x3A8)] public GameLightGaugeParameterData data__arr39;
        [FieldOffset(0x3C0)] public GameLightGaugeParameterData data__arr40;
        [FieldOffset(0x3D8)] public GameLightGaugeParameterData data__arr41;
        [FieldOffset(0x3F0)] public GameLightGaugeParameterData data__arr42;
        [FieldOffset(0x408)] public GameLightGaugeParameterData data__arr43;
        [FieldOffset(0x420)] public GameLightGaugeParameterData data__arr44;
        [FieldOffset(0x438)] public GameLightGaugeParameterData data__arr45;
        [FieldOffset(0x450)] public GameLightGaugeParameterData data__arr46;
        [FieldOffset(0x468)] public GameLightGaugeParameterData data__arr47;
        [FieldOffset(0x480)] public GameLightGaugeParameterData data__arr48;
        [FieldOffset(0x498)] public GameLightGaugeParameterData data__arr49;
        [FieldOffset(0x4B0)] public GameLightGaugeParameterData data__arr50;
        [FieldOffset(0x4C8)] public GameLightGaugeParameterData data__arr51;
        [FieldOffset(0x4E0)] public GameLightGaugeParameterData data__arr52;
        [FieldOffset(0x4F8)] public GameLightGaugeParameterData data__arr53;
        [FieldOffset(0x510)] public GameLightGaugeParameterData data__arr54;
        [FieldOffset(0x528)] public GameLightGaugeParameterData data__arr55;
        [FieldOffset(0x540)] public GameLightGaugeParameterData data__arr56;
        [FieldOffset(0x558)] public GameLightGaugeParameterData data__arr57;
        [FieldOffset(0x570)] public GameLightGaugeParameterData data__arr58;
        [FieldOffset(0x588)] public GameLightGaugeParameterData data__arr59;
        [FieldOffset(0x5A0)] public GameLightGaugeParameterData data__arr60;
        [FieldOffset(0x5B8)] public GameLightGaugeParameterData data__arr61;
        [FieldOffset(0x5D0)] public GameLightGaugeParameterData data__arr62;
        [FieldOffset(0x5E8)] public GameLightGaugeParameterData data__arr63;
        [FieldOffset(0x600)] public GameLightGaugeParameterData data__arr64;
        [FieldOffset(0x618)] public GameLightGaugeParameterData data__arr65;
        [FieldOffset(0x630)] public GameLightGaugeParameterData data__arr66;
        [FieldOffset(0x648)] public GameLightGaugeParameterData data__arr67;
        [FieldOffset(0x660)] public GameLightGaugeParameterData data__arr68;
        [FieldOffset(0x678)] public GameLightGaugeParameterData data__arr69;
        [FieldOffset(0x690)] public GameLightGaugeParameterData data__arr70;
        [FieldOffset(0x6A8)] public GameLightGaugeParameterData data__arr71;
        [FieldOffset(0x6C0)] public GameLightGaugeParameterData data__arr72;
        [FieldOffset(0x6D8)] public GameLightGaugeParameterData data__arr73;
        [FieldOffset(0x6F0)] public GameLightGaugeParameterData data__arr74;
        [FieldOffset(0x708)] public GameLightGaugeParameterData data__arr75;
        [FieldOffset(0x720)] public GameLightGaugeParameterData data__arr76;
        [FieldOffset(0x738)] public GameLightGaugeParameterData data__arr77;
        [FieldOffset(0x750)] public GameLightGaugeParameterData data__arr78;
        [FieldOffset(0x768)] public GameLightGaugeParameterData data__arr79;
    }

}