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

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct EffectRecord
    {
        [FieldOffset(0)] public Record record;
        [FieldOffset(0x08)] public UnmanagedString emitterSetName__arr0;
        [FieldOffset(0x18)] public UnmanagedString emitterSetName__arr1;
        [FieldOffset(0x28)] public UnmanagedString emitterSetName__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x37C8)]
    public struct EffectRecordTable
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
        [FieldOffset(0x15E0)] public EffectRecord data__arr100;
        [FieldOffset(0x1618)] public EffectRecord data__arr101;
        [FieldOffset(0x1650)] public EffectRecord data__arr102;
        [FieldOffset(0x1688)] public EffectRecord data__arr103;
        [FieldOffset(0x16C0)] public EffectRecord data__arr104;
        [FieldOffset(0x16F8)] public EffectRecord data__arr105;
        [FieldOffset(0x1730)] public EffectRecord data__arr106;
        [FieldOffset(0x1768)] public EffectRecord data__arr107;
        [FieldOffset(0x17A0)] public EffectRecord data__arr108;
        [FieldOffset(0x17D8)] public EffectRecord data__arr109;
        [FieldOffset(0x1810)] public EffectRecord data__arr110;
        [FieldOffset(0x1848)] public EffectRecord data__arr111;
        [FieldOffset(0x1880)] public EffectRecord data__arr112;
        [FieldOffset(0x18B8)] public EffectRecord data__arr113;
        [FieldOffset(0x18F0)] public EffectRecord data__arr114;
        [FieldOffset(0x1928)] public EffectRecord data__arr115;
        [FieldOffset(0x1960)] public EffectRecord data__arr116;
        [FieldOffset(0x1998)] public EffectRecord data__arr117;
        [FieldOffset(0x19D0)] public EffectRecord data__arr118;
        [FieldOffset(0x1A08)] public EffectRecord data__arr119;
        [FieldOffset(0x1A40)] public EffectRecord data__arr120;
        [FieldOffset(0x1A78)] public EffectRecord data__arr121;
        [FieldOffset(0x1AB0)] public EffectRecord data__arr122;
        [FieldOffset(0x1AE8)] public EffectRecord data__arr123;
        [FieldOffset(0x1B20)] public EffectRecord data__arr124;
        [FieldOffset(0x1B58)] public EffectRecord data__arr125;
        [FieldOffset(0x1B90)] public EffectRecord data__arr126;
        [FieldOffset(0x1BC8)] public EffectRecord data__arr127;
        [FieldOffset(0x1C00)] public EffectRecord data__arr128;
        [FieldOffset(0x1C38)] public EffectRecord data__arr129;
        [FieldOffset(0x1C70)] public EffectRecord data__arr130;
        [FieldOffset(0x1CA8)] public EffectRecord data__arr131;
        [FieldOffset(0x1CE0)] public EffectRecord data__arr132;
        [FieldOffset(0x1D18)] public EffectRecord data__arr133;
        [FieldOffset(0x1D50)] public EffectRecord data__arr134;
        [FieldOffset(0x1D88)] public EffectRecord data__arr135;
        [FieldOffset(0x1DC0)] public EffectRecord data__arr136;
        [FieldOffset(0x1DF8)] public EffectRecord data__arr137;
        [FieldOffset(0x1E30)] public EffectRecord data__arr138;
        [FieldOffset(0x1E68)] public EffectRecord data__arr139;
        [FieldOffset(0x1EA0)] public EffectRecord data__arr140;
        [FieldOffset(0x1ED8)] public EffectRecord data__arr141;
        [FieldOffset(0x1F10)] public EffectRecord data__arr142;
        [FieldOffset(0x1F48)] public EffectRecord data__arr143;
        [FieldOffset(0x1F80)] public EffectRecord data__arr144;
        [FieldOffset(0x1FB8)] public EffectRecord data__arr145;
        [FieldOffset(0x1FF0)] public EffectRecord data__arr146;
        [FieldOffset(0x2028)] public EffectRecord data__arr147;
        [FieldOffset(0x2060)] public EffectRecord data__arr148;
        [FieldOffset(0x2098)] public EffectRecord data__arr149;
        [FieldOffset(0x20D0)] public EffectRecord data__arr150;
        [FieldOffset(0x2108)] public EffectRecord data__arr151;
        [FieldOffset(0x2140)] public EffectRecord data__arr152;
        [FieldOffset(0x2178)] public EffectRecord data__arr153;
        [FieldOffset(0x21B0)] public EffectRecord data__arr154;
        [FieldOffset(0x21E8)] public EffectRecord data__arr155;
        [FieldOffset(0x2220)] public EffectRecord data__arr156;
        [FieldOffset(0x2258)] public EffectRecord data__arr157;
        [FieldOffset(0x2290)] public EffectRecord data__arr158;
        [FieldOffset(0x22C8)] public EffectRecord data__arr159;
        [FieldOffset(0x2300)] public EffectRecord data__arr160;
        [FieldOffset(0x2338)] public EffectRecord data__arr161;
        [FieldOffset(0x2370)] public EffectRecord data__arr162;
        [FieldOffset(0x23A8)] public EffectRecord data__arr163;
        [FieldOffset(0x23E0)] public EffectRecord data__arr164;
        [FieldOffset(0x2418)] public EffectRecord data__arr165;
        [FieldOffset(0x2450)] public EffectRecord data__arr166;
        [FieldOffset(0x2488)] public EffectRecord data__arr167;
        [FieldOffset(0x24C0)] public EffectRecord data__arr168;
        [FieldOffset(0x24F8)] public EffectRecord data__arr169;
        [FieldOffset(0x2530)] public EffectRecord data__arr170;
        [FieldOffset(0x2568)] public EffectRecord data__arr171;
        [FieldOffset(0x25A0)] public EffectRecord data__arr172;
        [FieldOffset(0x25D8)] public EffectRecord data__arr173;
        [FieldOffset(0x2610)] public EffectRecord data__arr174;
        [FieldOffset(0x2648)] public EffectRecord data__arr175;
        [FieldOffset(0x2680)] public EffectRecord data__arr176;
        [FieldOffset(0x26B8)] public EffectRecord data__arr177;
        [FieldOffset(0x26F0)] public EffectRecord data__arr178;
        [FieldOffset(0x2728)] public EffectRecord data__arr179;
        [FieldOffset(0x2760)] public EffectRecord data__arr180;
        [FieldOffset(0x2798)] public EffectRecord data__arr181;
        [FieldOffset(0x27D0)] public EffectRecord data__arr182;
        [FieldOffset(0x2808)] public EffectRecord data__arr183;
        [FieldOffset(0x2840)] public EffectRecord data__arr184;
        [FieldOffset(0x2878)] public EffectRecord data__arr185;
        [FieldOffset(0x28B0)] public EffectRecord data__arr186;
        [FieldOffset(0x28E8)] public EffectRecord data__arr187;
        [FieldOffset(0x2920)] public EffectRecord data__arr188;
        [FieldOffset(0x2958)] public EffectRecord data__arr189;
        [FieldOffset(0x2990)] public EffectRecord data__arr190;
        [FieldOffset(0x29C8)] public EffectRecord data__arr191;
        [FieldOffset(0x2A00)] public EffectRecord data__arr192;
        [FieldOffset(0x2A38)] public EffectRecord data__arr193;
        [FieldOffset(0x2A70)] public EffectRecord data__arr194;
        [FieldOffset(0x2AA8)] public EffectRecord data__arr195;
        [FieldOffset(0x2AE0)] public EffectRecord data__arr196;
        [FieldOffset(0x2B18)] public EffectRecord data__arr197;
        [FieldOffset(0x2B50)] public EffectRecord data__arr198;
        [FieldOffset(0x2B88)] public EffectRecord data__arr199;
        [FieldOffset(0x2BC0)] public EffectRecord data__arr200;
        [FieldOffset(0x2BF8)] public EffectRecord data__arr201;
        [FieldOffset(0x2C30)] public EffectRecord data__arr202;
        [FieldOffset(0x2C68)] public EffectRecord data__arr203;
        [FieldOffset(0x2CA0)] public EffectRecord data__arr204;
        [FieldOffset(0x2CD8)] public EffectRecord data__arr205;
        [FieldOffset(0x2D10)] public EffectRecord data__arr206;
        [FieldOffset(0x2D48)] public EffectRecord data__arr207;
        [FieldOffset(0x2D80)] public EffectRecord data__arr208;
        [FieldOffset(0x2DB8)] public EffectRecord data__arr209;
        [FieldOffset(0x2DF0)] public EffectRecord data__arr210;
        [FieldOffset(0x2E28)] public EffectRecord data__arr211;
        [FieldOffset(0x2E60)] public EffectRecord data__arr212;
        [FieldOffset(0x2E98)] public EffectRecord data__arr213;
        [FieldOffset(0x2ED0)] public EffectRecord data__arr214;
        [FieldOffset(0x2F08)] public EffectRecord data__arr215;
        [FieldOffset(0x2F40)] public EffectRecord data__arr216;
        [FieldOffset(0x2F78)] public EffectRecord data__arr217;
        [FieldOffset(0x2FB0)] public EffectRecord data__arr218;
        [FieldOffset(0x2FE8)] public EffectRecord data__arr219;
        [FieldOffset(0x3020)] public EffectRecord data__arr220;
        [FieldOffset(0x3058)] public EffectRecord data__arr221;
        [FieldOffset(0x3090)] public EffectRecord data__arr222;
        [FieldOffset(0x30C8)] public EffectRecord data__arr223;
        [FieldOffset(0x3100)] public EffectRecord data__arr224;
        [FieldOffset(0x3138)] public EffectRecord data__arr225;
        [FieldOffset(0x3170)] public EffectRecord data__arr226;
        [FieldOffset(0x31A8)] public EffectRecord data__arr227;
        [FieldOffset(0x31E0)] public EffectRecord data__arr228;
        [FieldOffset(0x3218)] public EffectRecord data__arr229;
        [FieldOffset(0x3250)] public EffectRecord data__arr230;
        [FieldOffset(0x3288)] public EffectRecord data__arr231;
        [FieldOffset(0x32C0)] public EffectRecord data__arr232;
        [FieldOffset(0x32F8)] public EffectRecord data__arr233;
        [FieldOffset(0x3330)] public EffectRecord data__arr234;
        [FieldOffset(0x3368)] public EffectRecord data__arr235;
        [FieldOffset(0x33A0)] public EffectRecord data__arr236;
        [FieldOffset(0x33D8)] public EffectRecord data__arr237;
        [FieldOffset(0x3410)] public EffectRecord data__arr238;
        [FieldOffset(0x3448)] public EffectRecord data__arr239;
        [FieldOffset(0x3480)] public EffectRecord data__arr240;
        [FieldOffset(0x34B8)] public EffectRecord data__arr241;
        [FieldOffset(0x34F0)] public EffectRecord data__arr242;
        [FieldOffset(0x3528)] public EffectRecord data__arr243;
        [FieldOffset(0x3560)] public EffectRecord data__arr244;
        [FieldOffset(0x3598)] public EffectRecord data__arr245;
        [FieldOffset(0x35D0)] public EffectRecord data__arr246;
        [FieldOffset(0x3608)] public EffectRecord data__arr247;
        [FieldOffset(0x3640)] public EffectRecord data__arr248;
        [FieldOffset(0x3678)] public EffectRecord data__arr249;
        [FieldOffset(0x36B0)] public EffectRecord data__arr250;
        [FieldOffset(0x36E8)] public EffectRecord data__arr251;
        [FieldOffset(0x3720)] public EffectRecord data__arr252;
        [FieldOffset(0x3758)] public EffectRecord data__arr253;
        [FieldOffset(0x3790)] public EffectRecord data__arr254;
    }

}