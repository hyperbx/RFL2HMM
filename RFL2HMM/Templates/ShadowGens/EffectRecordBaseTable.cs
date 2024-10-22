Library "EffectRecordBaseTable"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct Record
    {
        [FieldOffset(0x00)] public byte no;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct EffectRecord
    {
        [FieldOffset(0)] public Record record;
        [FieldOffset(0x08)] public UnmanagedString emitterSetName__arr0;
        [FieldOffset(0x18)] public UnmanagedString emitterSetName__arr1;
        [FieldOffset(0x28)] public UnmanagedString emitterSetName__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x15E0)]
    public struct EffectRecordBaseTable
    {
        [FieldOffset(0x00)] public EffectRecord data__arr0;
        [FieldOffset(0x38)] public EffectRecord data__arr1;
        [FieldOffset(0x70)] public EffectRecord data__arr2;
        [FieldOffset(0xA8)] public EffectRecord data__arr3;
        [FieldOffset(0xE0)] public EffectRecord data__arr4;
        [FieldOffset(0x118)] public EffectRecord data__arr5;
        [FieldOffset(0x150)] public EffectRecord data__arr6;
        [FieldOffset(0x188)] public EffectRecord data__arr7;
        [FieldOffset(0x1C0)] public EffectRecord data__arr8;
        [FieldOffset(0x1F8)] public EffectRecord data__arr9;
        [FieldOffset(0x230)] public EffectRecord data__arr10;
        [FieldOffset(0x268)] public EffectRecord data__arr11;
        [FieldOffset(0x2A0)] public EffectRecord data__arr12;
        [FieldOffset(0x2D8)] public EffectRecord data__arr13;
        [FieldOffset(0x310)] public EffectRecord data__arr14;
        [FieldOffset(0x348)] public EffectRecord data__arr15;
        [FieldOffset(0x380)] public EffectRecord data__arr16;
        [FieldOffset(0x3B8)] public EffectRecord data__arr17;
        [FieldOffset(0x3F0)] public EffectRecord data__arr18;
        [FieldOffset(0x428)] public EffectRecord data__arr19;
        [FieldOffset(0x460)] public EffectRecord data__arr20;
        [FieldOffset(0x498)] public EffectRecord data__arr21;
        [FieldOffset(0x4D0)] public EffectRecord data__arr22;
        [FieldOffset(0x508)] public EffectRecord data__arr23;
        [FieldOffset(0x540)] public EffectRecord data__arr24;
        [FieldOffset(0x578)] public EffectRecord data__arr25;
        [FieldOffset(0x5B0)] public EffectRecord data__arr26;
        [FieldOffset(0x5E8)] public EffectRecord data__arr27;
        [FieldOffset(0x620)] public EffectRecord data__arr28;
        [FieldOffset(0x658)] public EffectRecord data__arr29;
        [FieldOffset(0x690)] public EffectRecord data__arr30;
        [FieldOffset(0x6C8)] public EffectRecord data__arr31;
        [FieldOffset(0x700)] public EffectRecord data__arr32;
        [FieldOffset(0x738)] public EffectRecord data__arr33;
        [FieldOffset(0x770)] public EffectRecord data__arr34;
        [FieldOffset(0x7A8)] public EffectRecord data__arr35;
        [FieldOffset(0x7E0)] public EffectRecord data__arr36;
        [FieldOffset(0x818)] public EffectRecord data__arr37;
        [FieldOffset(0x850)] public EffectRecord data__arr38;
        [FieldOffset(0x888)] public EffectRecord data__arr39;
        [FieldOffset(0x8C0)] public EffectRecord data__arr40;
        [FieldOffset(0x8F8)] public EffectRecord data__arr41;
        [FieldOffset(0x930)] public EffectRecord data__arr42;
        [FieldOffset(0x968)] public EffectRecord data__arr43;
        [FieldOffset(0x9A0)] public EffectRecord data__arr44;
        [FieldOffset(0x9D8)] public EffectRecord data__arr45;
        [FieldOffset(0xA10)] public EffectRecord data__arr46;
        [FieldOffset(0xA48)] public EffectRecord data__arr47;
        [FieldOffset(0xA80)] public EffectRecord data__arr48;
        [FieldOffset(0xAB8)] public EffectRecord data__arr49;
        [FieldOffset(0xAF0)] public EffectRecord data__arr50;
        [FieldOffset(0xB28)] public EffectRecord data__arr51;
        [FieldOffset(0xB60)] public EffectRecord data__arr52;
        [FieldOffset(0xB98)] public EffectRecord data__arr53;
        [FieldOffset(0xBD0)] public EffectRecord data__arr54;
        [FieldOffset(0xC08)] public EffectRecord data__arr55;
        [FieldOffset(0xC40)] public EffectRecord data__arr56;
        [FieldOffset(0xC78)] public EffectRecord data__arr57;
        [FieldOffset(0xCB0)] public EffectRecord data__arr58;
        [FieldOffset(0xCE8)] public EffectRecord data__arr59;
        [FieldOffset(0xD20)] public EffectRecord data__arr60;
        [FieldOffset(0xD58)] public EffectRecord data__arr61;
        [FieldOffset(0xD90)] public EffectRecord data__arr62;
        [FieldOffset(0xDC8)] public EffectRecord data__arr63;
        [FieldOffset(0xE00)] public EffectRecord data__arr64;
        [FieldOffset(0xE38)] public EffectRecord data__arr65;
        [FieldOffset(0xE70)] public EffectRecord data__arr66;
        [FieldOffset(0xEA8)] public EffectRecord data__arr67;
        [FieldOffset(0xEE0)] public EffectRecord data__arr68;
        [FieldOffset(0xF18)] public EffectRecord data__arr69;
        [FieldOffset(0xF50)] public EffectRecord data__arr70;
        [FieldOffset(0xF88)] public EffectRecord data__arr71;
        [FieldOffset(0xFC0)] public EffectRecord data__arr72;
        [FieldOffset(0xFF8)] public EffectRecord data__arr73;
        [FieldOffset(0x1030)] public EffectRecord data__arr74;
        [FieldOffset(0x1068)] public EffectRecord data__arr75;
        [FieldOffset(0x10A0)] public EffectRecord data__arr76;
        [FieldOffset(0x10D8)] public EffectRecord data__arr77;
        [FieldOffset(0x1110)] public EffectRecord data__arr78;
        [FieldOffset(0x1148)] public EffectRecord data__arr79;
        [FieldOffset(0x1180)] public EffectRecord data__arr80;
        [FieldOffset(0x11B8)] public EffectRecord data__arr81;
        [FieldOffset(0x11F0)] public EffectRecord data__arr82;
        [FieldOffset(0x1228)] public EffectRecord data__arr83;
        [FieldOffset(0x1260)] public EffectRecord data__arr84;
        [FieldOffset(0x1298)] public EffectRecord data__arr85;
        [FieldOffset(0x12D0)] public EffectRecord data__arr86;
        [FieldOffset(0x1308)] public EffectRecord data__arr87;
        [FieldOffset(0x1340)] public EffectRecord data__arr88;
        [FieldOffset(0x1378)] public EffectRecord data__arr89;
        [FieldOffset(0x13B0)] public EffectRecord data__arr90;
        [FieldOffset(0x13E8)] public EffectRecord data__arr91;
        [FieldOffset(0x1420)] public EffectRecord data__arr92;
        [FieldOffset(0x1458)] public EffectRecord data__arr93;
        [FieldOffset(0x1490)] public EffectRecord data__arr94;
        [FieldOffset(0x14C8)] public EffectRecord data__arr95;
        [FieldOffset(0x1500)] public EffectRecord data__arr96;
        [FieldOffset(0x1538)] public EffectRecord data__arr97;
        [FieldOffset(0x1570)] public EffectRecord data__arr98;
        [FieldOffset(0x15A8)] public EffectRecord data__arr99;
    }

}