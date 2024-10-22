Library "EnemyAttackRecordTable"
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
    public struct EnemyAttackRecord
    {
        [FieldOffset(0)]  public Record record;
        [FieldOffset(0x08)] public UnmanagedString name;
        [FieldOffset(0x18)] public int damage;
        [FieldOffset(0x1C)] public float velocityX;
        [FieldOffset(0x20)] public float velocityY;
        [FieldOffset(0x28)] public UnmanagedString hitStopName;
        [FieldOffset(0x38)] public UnmanagedString cameraShakeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3600)]
    public struct EnemyAttackRecordTable
    {
        [FieldOffset(0x00)] public EnemyAttackRecord data__arr0;
        [FieldOffset(0x48)] public EnemyAttackRecord data__arr1;
        [FieldOffset(0x90)] public EnemyAttackRecord data__arr2;
        [FieldOffset(0xD8)] public EnemyAttackRecord data__arr3;
        [FieldOffset(0x120)] public EnemyAttackRecord data__arr4;
        [FieldOffset(0x168)] public EnemyAttackRecord data__arr5;
        [FieldOffset(0x1B0)] public EnemyAttackRecord data__arr6;
        [FieldOffset(0x1F8)] public EnemyAttackRecord data__arr7;
        [FieldOffset(0x240)] public EnemyAttackRecord data__arr8;
        [FieldOffset(0x288)] public EnemyAttackRecord data__arr9;
        [FieldOffset(0x2D0)] public EnemyAttackRecord data__arr10;
        [FieldOffset(0x318)] public EnemyAttackRecord data__arr11;
        [FieldOffset(0x360)] public EnemyAttackRecord data__arr12;
        [FieldOffset(0x3A8)] public EnemyAttackRecord data__arr13;
        [FieldOffset(0x3F0)] public EnemyAttackRecord data__arr14;
        [FieldOffset(0x438)] public EnemyAttackRecord data__arr15;
        [FieldOffset(0x480)] public EnemyAttackRecord data__arr16;
        [FieldOffset(0x4C8)] public EnemyAttackRecord data__arr17;
        [FieldOffset(0x510)] public EnemyAttackRecord data__arr18;
        [FieldOffset(0x558)] public EnemyAttackRecord data__arr19;
        [FieldOffset(0x5A0)] public EnemyAttackRecord data__arr20;
        [FieldOffset(0x5E8)] public EnemyAttackRecord data__arr21;
        [FieldOffset(0x630)] public EnemyAttackRecord data__arr22;
        [FieldOffset(0x678)] public EnemyAttackRecord data__arr23;
        [FieldOffset(0x6C0)] public EnemyAttackRecord data__arr24;
        [FieldOffset(0x708)] public EnemyAttackRecord data__arr25;
        [FieldOffset(0x750)] public EnemyAttackRecord data__arr26;
        [FieldOffset(0x798)] public EnemyAttackRecord data__arr27;
        [FieldOffset(0x7E0)] public EnemyAttackRecord data__arr28;
        [FieldOffset(0x828)] public EnemyAttackRecord data__arr29;
        [FieldOffset(0x870)] public EnemyAttackRecord data__arr30;
        [FieldOffset(0x8B8)] public EnemyAttackRecord data__arr31;
        [FieldOffset(0x900)] public EnemyAttackRecord data__arr32;
        [FieldOffset(0x948)] public EnemyAttackRecord data__arr33;
        [FieldOffset(0x990)] public EnemyAttackRecord data__arr34;
        [FieldOffset(0x9D8)] public EnemyAttackRecord data__arr35;
        [FieldOffset(0xA20)] public EnemyAttackRecord data__arr36;
        [FieldOffset(0xA68)] public EnemyAttackRecord data__arr37;
        [FieldOffset(0xAB0)] public EnemyAttackRecord data__arr38;
        [FieldOffset(0xAF8)] public EnemyAttackRecord data__arr39;
        [FieldOffset(0xB40)] public EnemyAttackRecord data__arr40;
        [FieldOffset(0xB88)] public EnemyAttackRecord data__arr41;
        [FieldOffset(0xBD0)] public EnemyAttackRecord data__arr42;
        [FieldOffset(0xC18)] public EnemyAttackRecord data__arr43;
        [FieldOffset(0xC60)] public EnemyAttackRecord data__arr44;
        [FieldOffset(0xCA8)] public EnemyAttackRecord data__arr45;
        [FieldOffset(0xCF0)] public EnemyAttackRecord data__arr46;
        [FieldOffset(0xD38)] public EnemyAttackRecord data__arr47;
        [FieldOffset(0xD80)] public EnemyAttackRecord data__arr48;
        [FieldOffset(0xDC8)] public EnemyAttackRecord data__arr49;
        [FieldOffset(0xE10)] public EnemyAttackRecord data__arr50;
        [FieldOffset(0xE58)] public EnemyAttackRecord data__arr51;
        [FieldOffset(0xEA0)] public EnemyAttackRecord data__arr52;
        [FieldOffset(0xEE8)] public EnemyAttackRecord data__arr53;
        [FieldOffset(0xF30)] public EnemyAttackRecord data__arr54;
        [FieldOffset(0xF78)] public EnemyAttackRecord data__arr55;
        [FieldOffset(0xFC0)] public EnemyAttackRecord data__arr56;
        [FieldOffset(0x1008)] public EnemyAttackRecord data__arr57;
        [FieldOffset(0x1050)] public EnemyAttackRecord data__arr58;
        [FieldOffset(0x1098)] public EnemyAttackRecord data__arr59;
        [FieldOffset(0x10E0)] public EnemyAttackRecord data__arr60;
        [FieldOffset(0x1128)] public EnemyAttackRecord data__arr61;
        [FieldOffset(0x1170)] public EnemyAttackRecord data__arr62;
        [FieldOffset(0x11B8)] public EnemyAttackRecord data__arr63;
        [FieldOffset(0x1200)] public EnemyAttackRecord data__arr64;
        [FieldOffset(0x1248)] public EnemyAttackRecord data__arr65;
        [FieldOffset(0x1290)] public EnemyAttackRecord data__arr66;
        [FieldOffset(0x12D8)] public EnemyAttackRecord data__arr67;
        [FieldOffset(0x1320)] public EnemyAttackRecord data__arr68;
        [FieldOffset(0x1368)] public EnemyAttackRecord data__arr69;
        [FieldOffset(0x13B0)] public EnemyAttackRecord data__arr70;
        [FieldOffset(0x13F8)] public EnemyAttackRecord data__arr71;
        [FieldOffset(0x1440)] public EnemyAttackRecord data__arr72;
        [FieldOffset(0x1488)] public EnemyAttackRecord data__arr73;
        [FieldOffset(0x14D0)] public EnemyAttackRecord data__arr74;
        [FieldOffset(0x1518)] public EnemyAttackRecord data__arr75;
        [FieldOffset(0x1560)] public EnemyAttackRecord data__arr76;
        [FieldOffset(0x15A8)] public EnemyAttackRecord data__arr77;
        [FieldOffset(0x15F0)] public EnemyAttackRecord data__arr78;
        [FieldOffset(0x1638)] public EnemyAttackRecord data__arr79;
        [FieldOffset(0x1680)] public EnemyAttackRecord data__arr80;
        [FieldOffset(0x16C8)] public EnemyAttackRecord data__arr81;
        [FieldOffset(0x1710)] public EnemyAttackRecord data__arr82;
        [FieldOffset(0x1758)] public EnemyAttackRecord data__arr83;
        [FieldOffset(0x17A0)] public EnemyAttackRecord data__arr84;
        [FieldOffset(0x17E8)] public EnemyAttackRecord data__arr85;
        [FieldOffset(0x1830)] public EnemyAttackRecord data__arr86;
        [FieldOffset(0x1878)] public EnemyAttackRecord data__arr87;
        [FieldOffset(0x18C0)] public EnemyAttackRecord data__arr88;
        [FieldOffset(0x1908)] public EnemyAttackRecord data__arr89;
        [FieldOffset(0x1950)] public EnemyAttackRecord data__arr90;
        [FieldOffset(0x1998)] public EnemyAttackRecord data__arr91;
        [FieldOffset(0x19E0)] public EnemyAttackRecord data__arr92;
        [FieldOffset(0x1A28)] public EnemyAttackRecord data__arr93;
        [FieldOffset(0x1A70)] public EnemyAttackRecord data__arr94;
        [FieldOffset(0x1AB8)] public EnemyAttackRecord data__arr95;
        [FieldOffset(0x1B00)] public EnemyAttackRecord data__arr96;
        [FieldOffset(0x1B48)] public EnemyAttackRecord data__arr97;
        [FieldOffset(0x1B90)] public EnemyAttackRecord data__arr98;
        [FieldOffset(0x1BD8)] public EnemyAttackRecord data__arr99;
        [FieldOffset(0x1C20)] public EnemyAttackRecord data__arr100;
        [FieldOffset(0x1C68)] public EnemyAttackRecord data__arr101;
        [FieldOffset(0x1CB0)] public EnemyAttackRecord data__arr102;
        [FieldOffset(0x1CF8)] public EnemyAttackRecord data__arr103;
        [FieldOffset(0x1D40)] public EnemyAttackRecord data__arr104;
        [FieldOffset(0x1D88)] public EnemyAttackRecord data__arr105;
        [FieldOffset(0x1DD0)] public EnemyAttackRecord data__arr106;
        [FieldOffset(0x1E18)] public EnemyAttackRecord data__arr107;
        [FieldOffset(0x1E60)] public EnemyAttackRecord data__arr108;
        [FieldOffset(0x1EA8)] public EnemyAttackRecord data__arr109;
        [FieldOffset(0x1EF0)] public EnemyAttackRecord data__arr110;
        [FieldOffset(0x1F38)] public EnemyAttackRecord data__arr111;
        [FieldOffset(0x1F80)] public EnemyAttackRecord data__arr112;
        [FieldOffset(0x1FC8)] public EnemyAttackRecord data__arr113;
        [FieldOffset(0x2010)] public EnemyAttackRecord data__arr114;
        [FieldOffset(0x2058)] public EnemyAttackRecord data__arr115;
        [FieldOffset(0x20A0)] public EnemyAttackRecord data__arr116;
        [FieldOffset(0x20E8)] public EnemyAttackRecord data__arr117;
        [FieldOffset(0x2130)] public EnemyAttackRecord data__arr118;
        [FieldOffset(0x2178)] public EnemyAttackRecord data__arr119;
        [FieldOffset(0x21C0)] public EnemyAttackRecord data__arr120;
        [FieldOffset(0x2208)] public EnemyAttackRecord data__arr121;
        [FieldOffset(0x2250)] public EnemyAttackRecord data__arr122;
        [FieldOffset(0x2298)] public EnemyAttackRecord data__arr123;
        [FieldOffset(0x22E0)] public EnemyAttackRecord data__arr124;
        [FieldOffset(0x2328)] public EnemyAttackRecord data__arr125;
        [FieldOffset(0x2370)] public EnemyAttackRecord data__arr126;
        [FieldOffset(0x23B8)] public EnemyAttackRecord data__arr127;
        [FieldOffset(0x2400)] public EnemyAttackRecord data__arr128;
        [FieldOffset(0x2448)] public EnemyAttackRecord data__arr129;
        [FieldOffset(0x2490)] public EnemyAttackRecord data__arr130;
        [FieldOffset(0x24D8)] public EnemyAttackRecord data__arr131;
        [FieldOffset(0x2520)] public EnemyAttackRecord data__arr132;
        [FieldOffset(0x2568)] public EnemyAttackRecord data__arr133;
        [FieldOffset(0x25B0)] public EnemyAttackRecord data__arr134;
        [FieldOffset(0x25F8)] public EnemyAttackRecord data__arr135;
        [FieldOffset(0x2640)] public EnemyAttackRecord data__arr136;
        [FieldOffset(0x2688)] public EnemyAttackRecord data__arr137;
        [FieldOffset(0x26D0)] public EnemyAttackRecord data__arr138;
        [FieldOffset(0x2718)] public EnemyAttackRecord data__arr139;
        [FieldOffset(0x2760)] public EnemyAttackRecord data__arr140;
        [FieldOffset(0x27A8)] public EnemyAttackRecord data__arr141;
        [FieldOffset(0x27F0)] public EnemyAttackRecord data__arr142;
        [FieldOffset(0x2838)] public EnemyAttackRecord data__arr143;
        [FieldOffset(0x2880)] public EnemyAttackRecord data__arr144;
        [FieldOffset(0x28C8)] public EnemyAttackRecord data__arr145;
        [FieldOffset(0x2910)] public EnemyAttackRecord data__arr146;
        [FieldOffset(0x2958)] public EnemyAttackRecord data__arr147;
        [FieldOffset(0x29A0)] public EnemyAttackRecord data__arr148;
        [FieldOffset(0x29E8)] public EnemyAttackRecord data__arr149;
        [FieldOffset(0x2A30)] public EnemyAttackRecord data__arr150;
        [FieldOffset(0x2A78)] public EnemyAttackRecord data__arr151;
        [FieldOffset(0x2AC0)] public EnemyAttackRecord data__arr152;
        [FieldOffset(0x2B08)] public EnemyAttackRecord data__arr153;
        [FieldOffset(0x2B50)] public EnemyAttackRecord data__arr154;
        [FieldOffset(0x2B98)] public EnemyAttackRecord data__arr155;
        [FieldOffset(0x2BE0)] public EnemyAttackRecord data__arr156;
        [FieldOffset(0x2C28)] public EnemyAttackRecord data__arr157;
        [FieldOffset(0x2C70)] public EnemyAttackRecord data__arr158;
        [FieldOffset(0x2CB8)] public EnemyAttackRecord data__arr159;
        [FieldOffset(0x2D00)] public EnemyAttackRecord data__arr160;
        [FieldOffset(0x2D48)] public EnemyAttackRecord data__arr161;
        [FieldOffset(0x2D90)] public EnemyAttackRecord data__arr162;
        [FieldOffset(0x2DD8)] public EnemyAttackRecord data__arr163;
        [FieldOffset(0x2E20)] public EnemyAttackRecord data__arr164;
        [FieldOffset(0x2E68)] public EnemyAttackRecord data__arr165;
        [FieldOffset(0x2EB0)] public EnemyAttackRecord data__arr166;
        [FieldOffset(0x2EF8)] public EnemyAttackRecord data__arr167;
        [FieldOffset(0x2F40)] public EnemyAttackRecord data__arr168;
        [FieldOffset(0x2F88)] public EnemyAttackRecord data__arr169;
        [FieldOffset(0x2FD0)] public EnemyAttackRecord data__arr170;
        [FieldOffset(0x3018)] public EnemyAttackRecord data__arr171;
        [FieldOffset(0x3060)] public EnemyAttackRecord data__arr172;
        [FieldOffset(0x30A8)] public EnemyAttackRecord data__arr173;
        [FieldOffset(0x30F0)] public EnemyAttackRecord data__arr174;
        [FieldOffset(0x3138)] public EnemyAttackRecord data__arr175;
        [FieldOffset(0x3180)] public EnemyAttackRecord data__arr176;
        [FieldOffset(0x31C8)] public EnemyAttackRecord data__arr177;
        [FieldOffset(0x3210)] public EnemyAttackRecord data__arr178;
        [FieldOffset(0x3258)] public EnemyAttackRecord data__arr179;
        [FieldOffset(0x32A0)] public EnemyAttackRecord data__arr180;
        [FieldOffset(0x32E8)] public EnemyAttackRecord data__arr181;
        [FieldOffset(0x3330)] public EnemyAttackRecord data__arr182;
        [FieldOffset(0x3378)] public EnemyAttackRecord data__arr183;
        [FieldOffset(0x33C0)] public EnemyAttackRecord data__arr184;
        [FieldOffset(0x3408)] public EnemyAttackRecord data__arr185;
        [FieldOffset(0x3450)] public EnemyAttackRecord data__arr186;
        [FieldOffset(0x3498)] public EnemyAttackRecord data__arr187;
        [FieldOffset(0x34E0)] public EnemyAttackRecord data__arr188;
        [FieldOffset(0x3528)] public EnemyAttackRecord data__arr189;
        [FieldOffset(0x3570)] public EnemyAttackRecord data__arr190;
        [FieldOffset(0x35B8)] public EnemyAttackRecord data__arr191;
    }

}