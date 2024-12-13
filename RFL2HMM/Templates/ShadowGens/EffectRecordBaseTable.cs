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

    [StructLayout(LayoutKind.Explicit, Size = 0x48)]
    public struct EffectRecord
    {
        [FieldOffset(0)] public Record record;
        [FieldOffset(0x08)] public UnmanagedString emitterSetName__arr0;
        [FieldOffset(0x18)] public UnmanagedString emitterSetName__arr1;
        [FieldOffset(0x28)] public UnmanagedString emitterSetName__arr2;
        [FieldOffset(0x38)] public UnmanagedString emitterSetName__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C20)]
    public struct EffectRecordBaseTable
    {
        [FieldOffset(0x00)] public EffectRecord data__arr0;
        [FieldOffset(0x48)] public EffectRecord data__arr1;
        [FieldOffset(0x90)] public EffectRecord data__arr2;
        [FieldOffset(0xD8)] public EffectRecord data__arr3;
        [FieldOffset(0x120)] public EffectRecord data__arr4;
        [FieldOffset(0x168)] public EffectRecord data__arr5;
        [FieldOffset(0x1B0)] public EffectRecord data__arr6;
        [FieldOffset(0x1F8)] public EffectRecord data__arr7;
        [FieldOffset(0x240)] public EffectRecord data__arr8;
        [FieldOffset(0x288)] public EffectRecord data__arr9;
        [FieldOffset(0x2D0)] public EffectRecord data__arr10;
        [FieldOffset(0x318)] public EffectRecord data__arr11;
        [FieldOffset(0x360)] public EffectRecord data__arr12;
        [FieldOffset(0x3A8)] public EffectRecord data__arr13;
        [FieldOffset(0x3F0)] public EffectRecord data__arr14;
        [FieldOffset(0x438)] public EffectRecord data__arr15;
        [FieldOffset(0x480)] public EffectRecord data__arr16;
        [FieldOffset(0x4C8)] public EffectRecord data__arr17;
        [FieldOffset(0x510)] public EffectRecord data__arr18;
        [FieldOffset(0x558)] public EffectRecord data__arr19;
        [FieldOffset(0x5A0)] public EffectRecord data__arr20;
        [FieldOffset(0x5E8)] public EffectRecord data__arr21;
        [FieldOffset(0x630)] public EffectRecord data__arr22;
        [FieldOffset(0x678)] public EffectRecord data__arr23;
        [FieldOffset(0x6C0)] public EffectRecord data__arr24;
        [FieldOffset(0x708)] public EffectRecord data__arr25;
        [FieldOffset(0x750)] public EffectRecord data__arr26;
        [FieldOffset(0x798)] public EffectRecord data__arr27;
        [FieldOffset(0x7E0)] public EffectRecord data__arr28;
        [FieldOffset(0x828)] public EffectRecord data__arr29;
        [FieldOffset(0x870)] public EffectRecord data__arr30;
        [FieldOffset(0x8B8)] public EffectRecord data__arr31;
        [FieldOffset(0x900)] public EffectRecord data__arr32;
        [FieldOffset(0x948)] public EffectRecord data__arr33;
        [FieldOffset(0x990)] public EffectRecord data__arr34;
        [FieldOffset(0x9D8)] public EffectRecord data__arr35;
        [FieldOffset(0xA20)] public EffectRecord data__arr36;
        [FieldOffset(0xA68)] public EffectRecord data__arr37;
        [FieldOffset(0xAB0)] public EffectRecord data__arr38;
        [FieldOffset(0xAF8)] public EffectRecord data__arr39;
        [FieldOffset(0xB40)] public EffectRecord data__arr40;
        [FieldOffset(0xB88)] public EffectRecord data__arr41;
        [FieldOffset(0xBD0)] public EffectRecord data__arr42;
        [FieldOffset(0xC18)] public EffectRecord data__arr43;
        [FieldOffset(0xC60)] public EffectRecord data__arr44;
        [FieldOffset(0xCA8)] public EffectRecord data__arr45;
        [FieldOffset(0xCF0)] public EffectRecord data__arr46;
        [FieldOffset(0xD38)] public EffectRecord data__arr47;
        [FieldOffset(0xD80)] public EffectRecord data__arr48;
        [FieldOffset(0xDC8)] public EffectRecord data__arr49;
        [FieldOffset(0xE10)] public EffectRecord data__arr50;
        [FieldOffset(0xE58)] public EffectRecord data__arr51;
        [FieldOffset(0xEA0)] public EffectRecord data__arr52;
        [FieldOffset(0xEE8)] public EffectRecord data__arr53;
        [FieldOffset(0xF30)] public EffectRecord data__arr54;
        [FieldOffset(0xF78)] public EffectRecord data__arr55;
        [FieldOffset(0xFC0)] public EffectRecord data__arr56;
        [FieldOffset(0x1008)] public EffectRecord data__arr57;
        [FieldOffset(0x1050)] public EffectRecord data__arr58;
        [FieldOffset(0x1098)] public EffectRecord data__arr59;
        [FieldOffset(0x10E0)] public EffectRecord data__arr60;
        [FieldOffset(0x1128)] public EffectRecord data__arr61;
        [FieldOffset(0x1170)] public EffectRecord data__arr62;
        [FieldOffset(0x11B8)] public EffectRecord data__arr63;
        [FieldOffset(0x1200)] public EffectRecord data__arr64;
        [FieldOffset(0x1248)] public EffectRecord data__arr65;
        [FieldOffset(0x1290)] public EffectRecord data__arr66;
        [FieldOffset(0x12D8)] public EffectRecord data__arr67;
        [FieldOffset(0x1320)] public EffectRecord data__arr68;
        [FieldOffset(0x1368)] public EffectRecord data__arr69;
        [FieldOffset(0x13B0)] public EffectRecord data__arr70;
        [FieldOffset(0x13F8)] public EffectRecord data__arr71;
        [FieldOffset(0x1440)] public EffectRecord data__arr72;
        [FieldOffset(0x1488)] public EffectRecord data__arr73;
        [FieldOffset(0x14D0)] public EffectRecord data__arr74;
        [FieldOffset(0x1518)] public EffectRecord data__arr75;
        [FieldOffset(0x1560)] public EffectRecord data__arr76;
        [FieldOffset(0x15A8)] public EffectRecord data__arr77;
        [FieldOffset(0x15F0)] public EffectRecord data__arr78;
        [FieldOffset(0x1638)] public EffectRecord data__arr79;
        [FieldOffset(0x1680)] public EffectRecord data__arr80;
        [FieldOffset(0x16C8)] public EffectRecord data__arr81;
        [FieldOffset(0x1710)] public EffectRecord data__arr82;
        [FieldOffset(0x1758)] public EffectRecord data__arr83;
        [FieldOffset(0x17A0)] public EffectRecord data__arr84;
        [FieldOffset(0x17E8)] public EffectRecord data__arr85;
        [FieldOffset(0x1830)] public EffectRecord data__arr86;
        [FieldOffset(0x1878)] public EffectRecord data__arr87;
        [FieldOffset(0x18C0)] public EffectRecord data__arr88;
        [FieldOffset(0x1908)] public EffectRecord data__arr89;
        [FieldOffset(0x1950)] public EffectRecord data__arr90;
        [FieldOffset(0x1998)] public EffectRecord data__arr91;
        [FieldOffset(0x19E0)] public EffectRecord data__arr92;
        [FieldOffset(0x1A28)] public EffectRecord data__arr93;
        [FieldOffset(0x1A70)] public EffectRecord data__arr94;
        [FieldOffset(0x1AB8)] public EffectRecord data__arr95;
        [FieldOffset(0x1B00)] public EffectRecord data__arr96;
        [FieldOffset(0x1B48)] public EffectRecord data__arr97;
        [FieldOffset(0x1B90)] public EffectRecord data__arr98;
        [FieldOffset(0x1BD8)] public EffectRecord data__arr99;
    }

}