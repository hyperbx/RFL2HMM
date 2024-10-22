Library "EnemyDefenceRecordTable"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct EnemyDefenceRecord
    {
        [FieldOffset(0)]  public Record record;
        [FieldOffset(0x08)] public UnmanagedString name;
        [FieldOffset(0x18)] public float baseRate;
        [FieldOffset(0x1C)] public float stunRate;
        [FieldOffset(0x20)] public float staggerRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1400)]
    public struct EnemyDefenceRecordTable
    {
        [FieldOffset(0x00)] public EnemyDefenceRecord data__arr0;
        [FieldOffset(0x28)] public EnemyDefenceRecord data__arr1;
        [FieldOffset(0x50)] public EnemyDefenceRecord data__arr2;
        [FieldOffset(0x78)] public EnemyDefenceRecord data__arr3;
        [FieldOffset(0xA0)] public EnemyDefenceRecord data__arr4;
        [FieldOffset(0xC8)] public EnemyDefenceRecord data__arr5;
        [FieldOffset(0xF0)] public EnemyDefenceRecord data__arr6;
        [FieldOffset(0x118)] public EnemyDefenceRecord data__arr7;
        [FieldOffset(0x140)] public EnemyDefenceRecord data__arr8;
        [FieldOffset(0x168)] public EnemyDefenceRecord data__arr9;
        [FieldOffset(0x190)] public EnemyDefenceRecord data__arr10;
        [FieldOffset(0x1B8)] public EnemyDefenceRecord data__arr11;
        [FieldOffset(0x1E0)] public EnemyDefenceRecord data__arr12;
        [FieldOffset(0x208)] public EnemyDefenceRecord data__arr13;
        [FieldOffset(0x230)] public EnemyDefenceRecord data__arr14;
        [FieldOffset(0x258)] public EnemyDefenceRecord data__arr15;
        [FieldOffset(0x280)] public EnemyDefenceRecord data__arr16;
        [FieldOffset(0x2A8)] public EnemyDefenceRecord data__arr17;
        [FieldOffset(0x2D0)] public EnemyDefenceRecord data__arr18;
        [FieldOffset(0x2F8)] public EnemyDefenceRecord data__arr19;
        [FieldOffset(0x320)] public EnemyDefenceRecord data__arr20;
        [FieldOffset(0x348)] public EnemyDefenceRecord data__arr21;
        [FieldOffset(0x370)] public EnemyDefenceRecord data__arr22;
        [FieldOffset(0x398)] public EnemyDefenceRecord data__arr23;
        [FieldOffset(0x3C0)] public EnemyDefenceRecord data__arr24;
        [FieldOffset(0x3E8)] public EnemyDefenceRecord data__arr25;
        [FieldOffset(0x410)] public EnemyDefenceRecord data__arr26;
        [FieldOffset(0x438)] public EnemyDefenceRecord data__arr27;
        [FieldOffset(0x460)] public EnemyDefenceRecord data__arr28;
        [FieldOffset(0x488)] public EnemyDefenceRecord data__arr29;
        [FieldOffset(0x4B0)] public EnemyDefenceRecord data__arr30;
        [FieldOffset(0x4D8)] public EnemyDefenceRecord data__arr31;
        [FieldOffset(0x500)] public EnemyDefenceRecord data__arr32;
        [FieldOffset(0x528)] public EnemyDefenceRecord data__arr33;
        [FieldOffset(0x550)] public EnemyDefenceRecord data__arr34;
        [FieldOffset(0x578)] public EnemyDefenceRecord data__arr35;
        [FieldOffset(0x5A0)] public EnemyDefenceRecord data__arr36;
        [FieldOffset(0x5C8)] public EnemyDefenceRecord data__arr37;
        [FieldOffset(0x5F0)] public EnemyDefenceRecord data__arr38;
        [FieldOffset(0x618)] public EnemyDefenceRecord data__arr39;
        [FieldOffset(0x640)] public EnemyDefenceRecord data__arr40;
        [FieldOffset(0x668)] public EnemyDefenceRecord data__arr41;
        [FieldOffset(0x690)] public EnemyDefenceRecord data__arr42;
        [FieldOffset(0x6B8)] public EnemyDefenceRecord data__arr43;
        [FieldOffset(0x6E0)] public EnemyDefenceRecord data__arr44;
        [FieldOffset(0x708)] public EnemyDefenceRecord data__arr45;
        [FieldOffset(0x730)] public EnemyDefenceRecord data__arr46;
        [FieldOffset(0x758)] public EnemyDefenceRecord data__arr47;
        [FieldOffset(0x780)] public EnemyDefenceRecord data__arr48;
        [FieldOffset(0x7A8)] public EnemyDefenceRecord data__arr49;
        [FieldOffset(0x7D0)] public EnemyDefenceRecord data__arr50;
        [FieldOffset(0x7F8)] public EnemyDefenceRecord data__arr51;
        [FieldOffset(0x820)] public EnemyDefenceRecord data__arr52;
        [FieldOffset(0x848)] public EnemyDefenceRecord data__arr53;
        [FieldOffset(0x870)] public EnemyDefenceRecord data__arr54;
        [FieldOffset(0x898)] public EnemyDefenceRecord data__arr55;
        [FieldOffset(0x8C0)] public EnemyDefenceRecord data__arr56;
        [FieldOffset(0x8E8)] public EnemyDefenceRecord data__arr57;
        [FieldOffset(0x910)] public EnemyDefenceRecord data__arr58;
        [FieldOffset(0x938)] public EnemyDefenceRecord data__arr59;
        [FieldOffset(0x960)] public EnemyDefenceRecord data__arr60;
        [FieldOffset(0x988)] public EnemyDefenceRecord data__arr61;
        [FieldOffset(0x9B0)] public EnemyDefenceRecord data__arr62;
        [FieldOffset(0x9D8)] public EnemyDefenceRecord data__arr63;
        [FieldOffset(0xA00)] public EnemyDefenceRecord data__arr64;
        [FieldOffset(0xA28)] public EnemyDefenceRecord data__arr65;
        [FieldOffset(0xA50)] public EnemyDefenceRecord data__arr66;
        [FieldOffset(0xA78)] public EnemyDefenceRecord data__arr67;
        [FieldOffset(0xAA0)] public EnemyDefenceRecord data__arr68;
        [FieldOffset(0xAC8)] public EnemyDefenceRecord data__arr69;
        [FieldOffset(0xAF0)] public EnemyDefenceRecord data__arr70;
        [FieldOffset(0xB18)] public EnemyDefenceRecord data__arr71;
        [FieldOffset(0xB40)] public EnemyDefenceRecord data__arr72;
        [FieldOffset(0xB68)] public EnemyDefenceRecord data__arr73;
        [FieldOffset(0xB90)] public EnemyDefenceRecord data__arr74;
        [FieldOffset(0xBB8)] public EnemyDefenceRecord data__arr75;
        [FieldOffset(0xBE0)] public EnemyDefenceRecord data__arr76;
        [FieldOffset(0xC08)] public EnemyDefenceRecord data__arr77;
        [FieldOffset(0xC30)] public EnemyDefenceRecord data__arr78;
        [FieldOffset(0xC58)] public EnemyDefenceRecord data__arr79;
        [FieldOffset(0xC80)] public EnemyDefenceRecord data__arr80;
        [FieldOffset(0xCA8)] public EnemyDefenceRecord data__arr81;
        [FieldOffset(0xCD0)] public EnemyDefenceRecord data__arr82;
        [FieldOffset(0xCF8)] public EnemyDefenceRecord data__arr83;
        [FieldOffset(0xD20)] public EnemyDefenceRecord data__arr84;
        [FieldOffset(0xD48)] public EnemyDefenceRecord data__arr85;
        [FieldOffset(0xD70)] public EnemyDefenceRecord data__arr86;
        [FieldOffset(0xD98)] public EnemyDefenceRecord data__arr87;
        [FieldOffset(0xDC0)] public EnemyDefenceRecord data__arr88;
        [FieldOffset(0xDE8)] public EnemyDefenceRecord data__arr89;
        [FieldOffset(0xE10)] public EnemyDefenceRecord data__arr90;
        [FieldOffset(0xE38)] public EnemyDefenceRecord data__arr91;
        [FieldOffset(0xE60)] public EnemyDefenceRecord data__arr92;
        [FieldOffset(0xE88)] public EnemyDefenceRecord data__arr93;
        [FieldOffset(0xEB0)] public EnemyDefenceRecord data__arr94;
        [FieldOffset(0xED8)] public EnemyDefenceRecord data__arr95;
        [FieldOffset(0xF00)] public EnemyDefenceRecord data__arr96;
        [FieldOffset(0xF28)] public EnemyDefenceRecord data__arr97;
        [FieldOffset(0xF50)] public EnemyDefenceRecord data__arr98;
        [FieldOffset(0xF78)] public EnemyDefenceRecord data__arr99;
        [FieldOffset(0xFA0)] public EnemyDefenceRecord data__arr100;
        [FieldOffset(0xFC8)] public EnemyDefenceRecord data__arr101;
        [FieldOffset(0xFF0)] public EnemyDefenceRecord data__arr102;
        [FieldOffset(0x1018)] public EnemyDefenceRecord data__arr103;
        [FieldOffset(0x1040)] public EnemyDefenceRecord data__arr104;
        [FieldOffset(0x1068)] public EnemyDefenceRecord data__arr105;
        [FieldOffset(0x1090)] public EnemyDefenceRecord data__arr106;
        [FieldOffset(0x10B8)] public EnemyDefenceRecord data__arr107;
        [FieldOffset(0x10E0)] public EnemyDefenceRecord data__arr108;
        [FieldOffset(0x1108)] public EnemyDefenceRecord data__arr109;
        [FieldOffset(0x1130)] public EnemyDefenceRecord data__arr110;
        [FieldOffset(0x1158)] public EnemyDefenceRecord data__arr111;
        [FieldOffset(0x1180)] public EnemyDefenceRecord data__arr112;
        [FieldOffset(0x11A8)] public EnemyDefenceRecord data__arr113;
        [FieldOffset(0x11D0)] public EnemyDefenceRecord data__arr114;
        [FieldOffset(0x11F8)] public EnemyDefenceRecord data__arr115;
        [FieldOffset(0x1220)] public EnemyDefenceRecord data__arr116;
        [FieldOffset(0x1248)] public EnemyDefenceRecord data__arr117;
        [FieldOffset(0x1270)] public EnemyDefenceRecord data__arr118;
        [FieldOffset(0x1298)] public EnemyDefenceRecord data__arr119;
        [FieldOffset(0x12C0)] public EnemyDefenceRecord data__arr120;
        [FieldOffset(0x12E8)] public EnemyDefenceRecord data__arr121;
        [FieldOffset(0x1310)] public EnemyDefenceRecord data__arr122;
        [FieldOffset(0x1338)] public EnemyDefenceRecord data__arr123;
        [FieldOffset(0x1360)] public EnemyDefenceRecord data__arr124;
        [FieldOffset(0x1388)] public EnemyDefenceRecord data__arr125;
        [FieldOffset(0x13B0)] public EnemyDefenceRecord data__arr126;
        [FieldOffset(0x13D8)] public EnemyDefenceRecord data__arr127;
    }

}