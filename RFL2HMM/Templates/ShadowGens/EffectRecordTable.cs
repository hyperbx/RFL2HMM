Library "EffectRecordTable"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x47B8)]
    public struct EffectRecordTable
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
        [FieldOffset(0x1C20)] public EffectRecord data__arr100;
        [FieldOffset(0x1C68)] public EffectRecord data__arr101;
        [FieldOffset(0x1CB0)] public EffectRecord data__arr102;
        [FieldOffset(0x1CF8)] public EffectRecord data__arr103;
        [FieldOffset(0x1D40)] public EffectRecord data__arr104;
        [FieldOffset(0x1D88)] public EffectRecord data__arr105;
        [FieldOffset(0x1DD0)] public EffectRecord data__arr106;
        [FieldOffset(0x1E18)] public EffectRecord data__arr107;
        [FieldOffset(0x1E60)] public EffectRecord data__arr108;
        [FieldOffset(0x1EA8)] public EffectRecord data__arr109;
        [FieldOffset(0x1EF0)] public EffectRecord data__arr110;
        [FieldOffset(0x1F38)] public EffectRecord data__arr111;
        [FieldOffset(0x1F80)] public EffectRecord data__arr112;
        [FieldOffset(0x1FC8)] public EffectRecord data__arr113;
        [FieldOffset(0x2010)] public EffectRecord data__arr114;
        [FieldOffset(0x2058)] public EffectRecord data__arr115;
        [FieldOffset(0x20A0)] public EffectRecord data__arr116;
        [FieldOffset(0x20E8)] public EffectRecord data__arr117;
        [FieldOffset(0x2130)] public EffectRecord data__arr118;
        [FieldOffset(0x2178)] public EffectRecord data__arr119;
        [FieldOffset(0x21C0)] public EffectRecord data__arr120;
        [FieldOffset(0x2208)] public EffectRecord data__arr121;
        [FieldOffset(0x2250)] public EffectRecord data__arr122;
        [FieldOffset(0x2298)] public EffectRecord data__arr123;
        [FieldOffset(0x22E0)] public EffectRecord data__arr124;
        [FieldOffset(0x2328)] public EffectRecord data__arr125;
        [FieldOffset(0x2370)] public EffectRecord data__arr126;
        [FieldOffset(0x23B8)] public EffectRecord data__arr127;
        [FieldOffset(0x2400)] public EffectRecord data__arr128;
        [FieldOffset(0x2448)] public EffectRecord data__arr129;
        [FieldOffset(0x2490)] public EffectRecord data__arr130;
        [FieldOffset(0x24D8)] public EffectRecord data__arr131;
        [FieldOffset(0x2520)] public EffectRecord data__arr132;
        [FieldOffset(0x2568)] public EffectRecord data__arr133;
        [FieldOffset(0x25B0)] public EffectRecord data__arr134;
        [FieldOffset(0x25F8)] public EffectRecord data__arr135;
        [FieldOffset(0x2640)] public EffectRecord data__arr136;
        [FieldOffset(0x2688)] public EffectRecord data__arr137;
        [FieldOffset(0x26D0)] public EffectRecord data__arr138;
        [FieldOffset(0x2718)] public EffectRecord data__arr139;
        [FieldOffset(0x2760)] public EffectRecord data__arr140;
        [FieldOffset(0x27A8)] public EffectRecord data__arr141;
        [FieldOffset(0x27F0)] public EffectRecord data__arr142;
        [FieldOffset(0x2838)] public EffectRecord data__arr143;
        [FieldOffset(0x2880)] public EffectRecord data__arr144;
        [FieldOffset(0x28C8)] public EffectRecord data__arr145;
        [FieldOffset(0x2910)] public EffectRecord data__arr146;
        [FieldOffset(0x2958)] public EffectRecord data__arr147;
        [FieldOffset(0x29A0)] public EffectRecord data__arr148;
        [FieldOffset(0x29E8)] public EffectRecord data__arr149;
        [FieldOffset(0x2A30)] public EffectRecord data__arr150;
        [FieldOffset(0x2A78)] public EffectRecord data__arr151;
        [FieldOffset(0x2AC0)] public EffectRecord data__arr152;
        [FieldOffset(0x2B08)] public EffectRecord data__arr153;
        [FieldOffset(0x2B50)] public EffectRecord data__arr154;
        [FieldOffset(0x2B98)] public EffectRecord data__arr155;
        [FieldOffset(0x2BE0)] public EffectRecord data__arr156;
        [FieldOffset(0x2C28)] public EffectRecord data__arr157;
        [FieldOffset(0x2C70)] public EffectRecord data__arr158;
        [FieldOffset(0x2CB8)] public EffectRecord data__arr159;
        [FieldOffset(0x2D00)] public EffectRecord data__arr160;
        [FieldOffset(0x2D48)] public EffectRecord data__arr161;
        [FieldOffset(0x2D90)] public EffectRecord data__arr162;
        [FieldOffset(0x2DD8)] public EffectRecord data__arr163;
        [FieldOffset(0x2E20)] public EffectRecord data__arr164;
        [FieldOffset(0x2E68)] public EffectRecord data__arr165;
        [FieldOffset(0x2EB0)] public EffectRecord data__arr166;
        [FieldOffset(0x2EF8)] public EffectRecord data__arr167;
        [FieldOffset(0x2F40)] public EffectRecord data__arr168;
        [FieldOffset(0x2F88)] public EffectRecord data__arr169;
        [FieldOffset(0x2FD0)] public EffectRecord data__arr170;
        [FieldOffset(0x3018)] public EffectRecord data__arr171;
        [FieldOffset(0x3060)] public EffectRecord data__arr172;
        [FieldOffset(0x30A8)] public EffectRecord data__arr173;
        [FieldOffset(0x30F0)] public EffectRecord data__arr174;
        [FieldOffset(0x3138)] public EffectRecord data__arr175;
        [FieldOffset(0x3180)] public EffectRecord data__arr176;
        [FieldOffset(0x31C8)] public EffectRecord data__arr177;
        [FieldOffset(0x3210)] public EffectRecord data__arr178;
        [FieldOffset(0x3258)] public EffectRecord data__arr179;
        [FieldOffset(0x32A0)] public EffectRecord data__arr180;
        [FieldOffset(0x32E8)] public EffectRecord data__arr181;
        [FieldOffset(0x3330)] public EffectRecord data__arr182;
        [FieldOffset(0x3378)] public EffectRecord data__arr183;
        [FieldOffset(0x33C0)] public EffectRecord data__arr184;
        [FieldOffset(0x3408)] public EffectRecord data__arr185;
        [FieldOffset(0x3450)] public EffectRecord data__arr186;
        [FieldOffset(0x3498)] public EffectRecord data__arr187;
        [FieldOffset(0x34E0)] public EffectRecord data__arr188;
        [FieldOffset(0x3528)] public EffectRecord data__arr189;
        [FieldOffset(0x3570)] public EffectRecord data__arr190;
        [FieldOffset(0x35B8)] public EffectRecord data__arr191;
        [FieldOffset(0x3600)] public EffectRecord data__arr192;
        [FieldOffset(0x3648)] public EffectRecord data__arr193;
        [FieldOffset(0x3690)] public EffectRecord data__arr194;
        [FieldOffset(0x36D8)] public EffectRecord data__arr195;
        [FieldOffset(0x3720)] public EffectRecord data__arr196;
        [FieldOffset(0x3768)] public EffectRecord data__arr197;
        [FieldOffset(0x37B0)] public EffectRecord data__arr198;
        [FieldOffset(0x37F8)] public EffectRecord data__arr199;
        [FieldOffset(0x3840)] public EffectRecord data__arr200;
        [FieldOffset(0x3888)] public EffectRecord data__arr201;
        [FieldOffset(0x38D0)] public EffectRecord data__arr202;
        [FieldOffset(0x3918)] public EffectRecord data__arr203;
        [FieldOffset(0x3960)] public EffectRecord data__arr204;
        [FieldOffset(0x39A8)] public EffectRecord data__arr205;
        [FieldOffset(0x39F0)] public EffectRecord data__arr206;
        [FieldOffset(0x3A38)] public EffectRecord data__arr207;
        [FieldOffset(0x3A80)] public EffectRecord data__arr208;
        [FieldOffset(0x3AC8)] public EffectRecord data__arr209;
        [FieldOffset(0x3B10)] public EffectRecord data__arr210;
        [FieldOffset(0x3B58)] public EffectRecord data__arr211;
        [FieldOffset(0x3BA0)] public EffectRecord data__arr212;
        [FieldOffset(0x3BE8)] public EffectRecord data__arr213;
        [FieldOffset(0x3C30)] public EffectRecord data__arr214;
        [FieldOffset(0x3C78)] public EffectRecord data__arr215;
        [FieldOffset(0x3CC0)] public EffectRecord data__arr216;
        [FieldOffset(0x3D08)] public EffectRecord data__arr217;
        [FieldOffset(0x3D50)] public EffectRecord data__arr218;
        [FieldOffset(0x3D98)] public EffectRecord data__arr219;
        [FieldOffset(0x3DE0)] public EffectRecord data__arr220;
        [FieldOffset(0x3E28)] public EffectRecord data__arr221;
        [FieldOffset(0x3E70)] public EffectRecord data__arr222;
        [FieldOffset(0x3EB8)] public EffectRecord data__arr223;
        [FieldOffset(0x3F00)] public EffectRecord data__arr224;
        [FieldOffset(0x3F48)] public EffectRecord data__arr225;
        [FieldOffset(0x3F90)] public EffectRecord data__arr226;
        [FieldOffset(0x3FD8)] public EffectRecord data__arr227;
        [FieldOffset(0x4020)] public EffectRecord data__arr228;
        [FieldOffset(0x4068)] public EffectRecord data__arr229;
        [FieldOffset(0x40B0)] public EffectRecord data__arr230;
        [FieldOffset(0x40F8)] public EffectRecord data__arr231;
        [FieldOffset(0x4140)] public EffectRecord data__arr232;
        [FieldOffset(0x4188)] public EffectRecord data__arr233;
        [FieldOffset(0x41D0)] public EffectRecord data__arr234;
        [FieldOffset(0x4218)] public EffectRecord data__arr235;
        [FieldOffset(0x4260)] public EffectRecord data__arr236;
        [FieldOffset(0x42A8)] public EffectRecord data__arr237;
        [FieldOffset(0x42F0)] public EffectRecord data__arr238;
        [FieldOffset(0x4338)] public EffectRecord data__arr239;
        [FieldOffset(0x4380)] public EffectRecord data__arr240;
        [FieldOffset(0x43C8)] public EffectRecord data__arr241;
        [FieldOffset(0x4410)] public EffectRecord data__arr242;
        [FieldOffset(0x4458)] public EffectRecord data__arr243;
        [FieldOffset(0x44A0)] public EffectRecord data__arr244;
        [FieldOffset(0x44E8)] public EffectRecord data__arr245;
        [FieldOffset(0x4530)] public EffectRecord data__arr246;
        [FieldOffset(0x4578)] public EffectRecord data__arr247;
        [FieldOffset(0x45C0)] public EffectRecord data__arr248;
        [FieldOffset(0x4608)] public EffectRecord data__arr249;
        [FieldOffset(0x4650)] public EffectRecord data__arr250;
        [FieldOffset(0x4698)] public EffectRecord data__arr251;
        [FieldOffset(0x46E0)] public EffectRecord data__arr252;
        [FieldOffset(0x4728)] public EffectRecord data__arr253;
        [FieldOffset(0x4770)] public EffectRecord data__arr254;
    }

}