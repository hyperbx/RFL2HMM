using System.Numerics;
using System.Runtime.InteropServices;

public class EffectRecordTableClass
{
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

    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct EffectRecord
    {
        [FieldOffset(0)] public Record record;
        [FieldOffset(0x08)] public UnmanagedString emitterSetName__arr0;
        [FieldOffset(0x107)] public UnmanagedString emitterSetName__arr1;
        [FieldOffset(0x206)] public UnmanagedString emitterSetName__arr2;
        [FieldOffset(0x305)] public UnmanagedString emitterSetName__arr3;
        [FieldOffset(0x404)] public UnmanagedString emitterSetName__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x57A8)]
    public struct EffectRecordTable
    {
        [FieldOffset(0x00)] public EffectRecord data__arr0;
        [FieldOffset(0x58)] public EffectRecord data__arr1;
        [FieldOffset(0xB0)] public EffectRecord data__arr2;
        [FieldOffset(0x108)] public EffectRecord data__arr3;
        [FieldOffset(0x160)] public EffectRecord data__arr4;
        [FieldOffset(0x1B8)] public EffectRecord data__arr5;
        [FieldOffset(0x210)] public EffectRecord data__arr6;
        [FieldOffset(0x268)] public EffectRecord data__arr7;
        [FieldOffset(0x2C0)] public EffectRecord data__arr8;
        [FieldOffset(0x318)] public EffectRecord data__arr9;
        [FieldOffset(0x370)] public EffectRecord data__arr10;
        [FieldOffset(0x3C8)] public EffectRecord data__arr11;
        [FieldOffset(0x420)] public EffectRecord data__arr12;
        [FieldOffset(0x478)] public EffectRecord data__arr13;
        [FieldOffset(0x4D0)] public EffectRecord data__arr14;
        [FieldOffset(0x528)] public EffectRecord data__arr15;
        [FieldOffset(0x580)] public EffectRecord data__arr16;
        [FieldOffset(0x5D8)] public EffectRecord data__arr17;
        [FieldOffset(0x630)] public EffectRecord data__arr18;
        [FieldOffset(0x688)] public EffectRecord data__arr19;
        [FieldOffset(0x6E0)] public EffectRecord data__arr20;
        [FieldOffset(0x738)] public EffectRecord data__arr21;
        [FieldOffset(0x790)] public EffectRecord data__arr22;
        [FieldOffset(0x7E8)] public EffectRecord data__arr23;
        [FieldOffset(0x840)] public EffectRecord data__arr24;
        [FieldOffset(0x898)] public EffectRecord data__arr25;
        [FieldOffset(0x8F0)] public EffectRecord data__arr26;
        [FieldOffset(0x948)] public EffectRecord data__arr27;
        [FieldOffset(0x9A0)] public EffectRecord data__arr28;
        [FieldOffset(0x9F8)] public EffectRecord data__arr29;
        [FieldOffset(0xA50)] public EffectRecord data__arr30;
        [FieldOffset(0xAA8)] public EffectRecord data__arr31;
        [FieldOffset(0xB00)] public EffectRecord data__arr32;
        [FieldOffset(0xB58)] public EffectRecord data__arr33;
        [FieldOffset(0xBB0)] public EffectRecord data__arr34;
        [FieldOffset(0xC08)] public EffectRecord data__arr35;
        [FieldOffset(0xC60)] public EffectRecord data__arr36;
        [FieldOffset(0xCB8)] public EffectRecord data__arr37;
        [FieldOffset(0xD10)] public EffectRecord data__arr38;
        [FieldOffset(0xD68)] public EffectRecord data__arr39;
        [FieldOffset(0xDC0)] public EffectRecord data__arr40;
        [FieldOffset(0xE18)] public EffectRecord data__arr41;
        [FieldOffset(0xE70)] public EffectRecord data__arr42;
        [FieldOffset(0xEC8)] public EffectRecord data__arr43;
        [FieldOffset(0xF20)] public EffectRecord data__arr44;
        [FieldOffset(0xF78)] public EffectRecord data__arr45;
        [FieldOffset(0xFD0)] public EffectRecord data__arr46;
        [FieldOffset(0x1028)] public EffectRecord data__arr47;
        [FieldOffset(0x1080)] public EffectRecord data__arr48;
        [FieldOffset(0x10D8)] public EffectRecord data__arr49;
        [FieldOffset(0x1130)] public EffectRecord data__arr50;
        [FieldOffset(0x1188)] public EffectRecord data__arr51;
        [FieldOffset(0x11E0)] public EffectRecord data__arr52;
        [FieldOffset(0x1238)] public EffectRecord data__arr53;
        [FieldOffset(0x1290)] public EffectRecord data__arr54;
        [FieldOffset(0x12E8)] public EffectRecord data__arr55;
        [FieldOffset(0x1340)] public EffectRecord data__arr56;
        [FieldOffset(0x1398)] public EffectRecord data__arr57;
        [FieldOffset(0x13F0)] public EffectRecord data__arr58;
        [FieldOffset(0x1448)] public EffectRecord data__arr59;
        [FieldOffset(0x14A0)] public EffectRecord data__arr60;
        [FieldOffset(0x14F8)] public EffectRecord data__arr61;
        [FieldOffset(0x1550)] public EffectRecord data__arr62;
        [FieldOffset(0x15A8)] public EffectRecord data__arr63;
        [FieldOffset(0x1600)] public EffectRecord data__arr64;
        [FieldOffset(0x1658)] public EffectRecord data__arr65;
        [FieldOffset(0x16B0)] public EffectRecord data__arr66;
        [FieldOffset(0x1708)] public EffectRecord data__arr67;
        [FieldOffset(0x1760)] public EffectRecord data__arr68;
        [FieldOffset(0x17B8)] public EffectRecord data__arr69;
        [FieldOffset(0x1810)] public EffectRecord data__arr70;
        [FieldOffset(0x1868)] public EffectRecord data__arr71;
        [FieldOffset(0x18C0)] public EffectRecord data__arr72;
        [FieldOffset(0x1918)] public EffectRecord data__arr73;
        [FieldOffset(0x1970)] public EffectRecord data__arr74;
        [FieldOffset(0x19C8)] public EffectRecord data__arr75;
        [FieldOffset(0x1A20)] public EffectRecord data__arr76;
        [FieldOffset(0x1A78)] public EffectRecord data__arr77;
        [FieldOffset(0x1AD0)] public EffectRecord data__arr78;
        [FieldOffset(0x1B28)] public EffectRecord data__arr79;
        [FieldOffset(0x1B80)] public EffectRecord data__arr80;
        [FieldOffset(0x1BD8)] public EffectRecord data__arr81;
        [FieldOffset(0x1C30)] public EffectRecord data__arr82;
        [FieldOffset(0x1C88)] public EffectRecord data__arr83;
        [FieldOffset(0x1CE0)] public EffectRecord data__arr84;
        [FieldOffset(0x1D38)] public EffectRecord data__arr85;
        [FieldOffset(0x1D90)] public EffectRecord data__arr86;
        [FieldOffset(0x1DE8)] public EffectRecord data__arr87;
        [FieldOffset(0x1E40)] public EffectRecord data__arr88;
        [FieldOffset(0x1E98)] public EffectRecord data__arr89;
        [FieldOffset(0x1EF0)] public EffectRecord data__arr90;
        [FieldOffset(0x1F48)] public EffectRecord data__arr91;
        [FieldOffset(0x1FA0)] public EffectRecord data__arr92;
        [FieldOffset(0x1FF8)] public EffectRecord data__arr93;
        [FieldOffset(0x2050)] public EffectRecord data__arr94;
        [FieldOffset(0x20A8)] public EffectRecord data__arr95;
        [FieldOffset(0x2100)] public EffectRecord data__arr96;
        [FieldOffset(0x2158)] public EffectRecord data__arr97;
        [FieldOffset(0x21B0)] public EffectRecord data__arr98;
        [FieldOffset(0x2208)] public EffectRecord data__arr99;
        [FieldOffset(0x2260)] public EffectRecord data__arr100;
        [FieldOffset(0x22B8)] public EffectRecord data__arr101;
        [FieldOffset(0x2310)] public EffectRecord data__arr102;
        [FieldOffset(0x2368)] public EffectRecord data__arr103;
        [FieldOffset(0x23C0)] public EffectRecord data__arr104;
        [FieldOffset(0x2418)] public EffectRecord data__arr105;
        [FieldOffset(0x2470)] public EffectRecord data__arr106;
        [FieldOffset(0x24C8)] public EffectRecord data__arr107;
        [FieldOffset(0x2520)] public EffectRecord data__arr108;
        [FieldOffset(0x2578)] public EffectRecord data__arr109;
        [FieldOffset(0x25D0)] public EffectRecord data__arr110;
        [FieldOffset(0x2628)] public EffectRecord data__arr111;
        [FieldOffset(0x2680)] public EffectRecord data__arr112;
        [FieldOffset(0x26D8)] public EffectRecord data__arr113;
        [FieldOffset(0x2730)] public EffectRecord data__arr114;
        [FieldOffset(0x2788)] public EffectRecord data__arr115;
        [FieldOffset(0x27E0)] public EffectRecord data__arr116;
        [FieldOffset(0x2838)] public EffectRecord data__arr117;
        [FieldOffset(0x2890)] public EffectRecord data__arr118;
        [FieldOffset(0x28E8)] public EffectRecord data__arr119;
        [FieldOffset(0x2940)] public EffectRecord data__arr120;
        [FieldOffset(0x2998)] public EffectRecord data__arr121;
        [FieldOffset(0x29F0)] public EffectRecord data__arr122;
        [FieldOffset(0x2A48)] public EffectRecord data__arr123;
        [FieldOffset(0x2AA0)] public EffectRecord data__arr124;
        [FieldOffset(0x2AF8)] public EffectRecord data__arr125;
        [FieldOffset(0x2B50)] public EffectRecord data__arr126;
        [FieldOffset(0x2BA8)] public EffectRecord data__arr127;
        [FieldOffset(0x2C00)] public EffectRecord data__arr128;
        [FieldOffset(0x2C58)] public EffectRecord data__arr129;
        [FieldOffset(0x2CB0)] public EffectRecord data__arr130;
        [FieldOffset(0x2D08)] public EffectRecord data__arr131;
        [FieldOffset(0x2D60)] public EffectRecord data__arr132;
        [FieldOffset(0x2DB8)] public EffectRecord data__arr133;
        [FieldOffset(0x2E10)] public EffectRecord data__arr134;
        [FieldOffset(0x2E68)] public EffectRecord data__arr135;
        [FieldOffset(0x2EC0)] public EffectRecord data__arr136;
        [FieldOffset(0x2F18)] public EffectRecord data__arr137;
        [FieldOffset(0x2F70)] public EffectRecord data__arr138;
        [FieldOffset(0x2FC8)] public EffectRecord data__arr139;
        [FieldOffset(0x3020)] public EffectRecord data__arr140;
        [FieldOffset(0x3078)] public EffectRecord data__arr141;
        [FieldOffset(0x30D0)] public EffectRecord data__arr142;
        [FieldOffset(0x3128)] public EffectRecord data__arr143;
        [FieldOffset(0x3180)] public EffectRecord data__arr144;
        [FieldOffset(0x31D8)] public EffectRecord data__arr145;
        [FieldOffset(0x3230)] public EffectRecord data__arr146;
        [FieldOffset(0x3288)] public EffectRecord data__arr147;
        [FieldOffset(0x32E0)] public EffectRecord data__arr148;
        [FieldOffset(0x3338)] public EffectRecord data__arr149;
        [FieldOffset(0x3390)] public EffectRecord data__arr150;
        [FieldOffset(0x33E8)] public EffectRecord data__arr151;
        [FieldOffset(0x3440)] public EffectRecord data__arr152;
        [FieldOffset(0x3498)] public EffectRecord data__arr153;
        [FieldOffset(0x34F0)] public EffectRecord data__arr154;
        [FieldOffset(0x3548)] public EffectRecord data__arr155;
        [FieldOffset(0x35A0)] public EffectRecord data__arr156;
        [FieldOffset(0x35F8)] public EffectRecord data__arr157;
        [FieldOffset(0x3650)] public EffectRecord data__arr158;
        [FieldOffset(0x36A8)] public EffectRecord data__arr159;
        [FieldOffset(0x3700)] public EffectRecord data__arr160;
        [FieldOffset(0x3758)] public EffectRecord data__arr161;
        [FieldOffset(0x37B0)] public EffectRecord data__arr162;
        [FieldOffset(0x3808)] public EffectRecord data__arr163;
        [FieldOffset(0x3860)] public EffectRecord data__arr164;
        [FieldOffset(0x38B8)] public EffectRecord data__arr165;
        [FieldOffset(0x3910)] public EffectRecord data__arr166;
        [FieldOffset(0x3968)] public EffectRecord data__arr167;
        [FieldOffset(0x39C0)] public EffectRecord data__arr168;
        [FieldOffset(0x3A18)] public EffectRecord data__arr169;
        [FieldOffset(0x3A70)] public EffectRecord data__arr170;
        [FieldOffset(0x3AC8)] public EffectRecord data__arr171;
        [FieldOffset(0x3B20)] public EffectRecord data__arr172;
        [FieldOffset(0x3B78)] public EffectRecord data__arr173;
        [FieldOffset(0x3BD0)] public EffectRecord data__arr174;
        [FieldOffset(0x3C28)] public EffectRecord data__arr175;
        [FieldOffset(0x3C80)] public EffectRecord data__arr176;
        [FieldOffset(0x3CD8)] public EffectRecord data__arr177;
        [FieldOffset(0x3D30)] public EffectRecord data__arr178;
        [FieldOffset(0x3D88)] public EffectRecord data__arr179;
        [FieldOffset(0x3DE0)] public EffectRecord data__arr180;
        [FieldOffset(0x3E38)] public EffectRecord data__arr181;
        [FieldOffset(0x3E90)] public EffectRecord data__arr182;
        [FieldOffset(0x3EE8)] public EffectRecord data__arr183;
        [FieldOffset(0x3F40)] public EffectRecord data__arr184;
        [FieldOffset(0x3F98)] public EffectRecord data__arr185;
        [FieldOffset(0x3FF0)] public EffectRecord data__arr186;
        [FieldOffset(0x4048)] public EffectRecord data__arr187;
        [FieldOffset(0x40A0)] public EffectRecord data__arr188;
        [FieldOffset(0x40F8)] public EffectRecord data__arr189;
        [FieldOffset(0x4150)] public EffectRecord data__arr190;
        [FieldOffset(0x41A8)] public EffectRecord data__arr191;
        [FieldOffset(0x4200)] public EffectRecord data__arr192;
        [FieldOffset(0x4258)] public EffectRecord data__arr193;
        [FieldOffset(0x42B0)] public EffectRecord data__arr194;
        [FieldOffset(0x4308)] public EffectRecord data__arr195;
        [FieldOffset(0x4360)] public EffectRecord data__arr196;
        [FieldOffset(0x43B8)] public EffectRecord data__arr197;
        [FieldOffset(0x4410)] public EffectRecord data__arr198;
        [FieldOffset(0x4468)] public EffectRecord data__arr199;
        [FieldOffset(0x44C0)] public EffectRecord data__arr200;
        [FieldOffset(0x4518)] public EffectRecord data__arr201;
        [FieldOffset(0x4570)] public EffectRecord data__arr202;
        [FieldOffset(0x45C8)] public EffectRecord data__arr203;
        [FieldOffset(0x4620)] public EffectRecord data__arr204;
        [FieldOffset(0x4678)] public EffectRecord data__arr205;
        [FieldOffset(0x46D0)] public EffectRecord data__arr206;
        [FieldOffset(0x4728)] public EffectRecord data__arr207;
        [FieldOffset(0x4780)] public EffectRecord data__arr208;
        [FieldOffset(0x47D8)] public EffectRecord data__arr209;
        [FieldOffset(0x4830)] public EffectRecord data__arr210;
        [FieldOffset(0x4888)] public EffectRecord data__arr211;
        [FieldOffset(0x48E0)] public EffectRecord data__arr212;
        [FieldOffset(0x4938)] public EffectRecord data__arr213;
        [FieldOffset(0x4990)] public EffectRecord data__arr214;
        [FieldOffset(0x49E8)] public EffectRecord data__arr215;
        [FieldOffset(0x4A40)] public EffectRecord data__arr216;
        [FieldOffset(0x4A98)] public EffectRecord data__arr217;
        [FieldOffset(0x4AF0)] public EffectRecord data__arr218;
        [FieldOffset(0x4B48)] public EffectRecord data__arr219;
        [FieldOffset(0x4BA0)] public EffectRecord data__arr220;
        [FieldOffset(0x4BF8)] public EffectRecord data__arr221;
        [FieldOffset(0x4C50)] public EffectRecord data__arr222;
        [FieldOffset(0x4CA8)] public EffectRecord data__arr223;
        [FieldOffset(0x4D00)] public EffectRecord data__arr224;
        [FieldOffset(0x4D58)] public EffectRecord data__arr225;
        [FieldOffset(0x4DB0)] public EffectRecord data__arr226;
        [FieldOffset(0x4E08)] public EffectRecord data__arr227;
        [FieldOffset(0x4E60)] public EffectRecord data__arr228;
        [FieldOffset(0x4EB8)] public EffectRecord data__arr229;
        [FieldOffset(0x4F10)] public EffectRecord data__arr230;
        [FieldOffset(0x4F68)] public EffectRecord data__arr231;
        [FieldOffset(0x4FC0)] public EffectRecord data__arr232;
        [FieldOffset(0x5018)] public EffectRecord data__arr233;
        [FieldOffset(0x5070)] public EffectRecord data__arr234;
        [FieldOffset(0x50C8)] public EffectRecord data__arr235;
        [FieldOffset(0x5120)] public EffectRecord data__arr236;
        [FieldOffset(0x5178)] public EffectRecord data__arr237;
        [FieldOffset(0x51D0)] public EffectRecord data__arr238;
        [FieldOffset(0x5228)] public EffectRecord data__arr239;
        [FieldOffset(0x5280)] public EffectRecord data__arr240;
        [FieldOffset(0x52D8)] public EffectRecord data__arr241;
        [FieldOffset(0x5330)] public EffectRecord data__arr242;
        [FieldOffset(0x5388)] public EffectRecord data__arr243;
        [FieldOffset(0x53E0)] public EffectRecord data__arr244;
        [FieldOffset(0x5438)] public EffectRecord data__arr245;
        [FieldOffset(0x5490)] public EffectRecord data__arr246;
        [FieldOffset(0x54E8)] public EffectRecord data__arr247;
        [FieldOffset(0x5540)] public EffectRecord data__arr248;
        [FieldOffset(0x5598)] public EffectRecord data__arr249;
        [FieldOffset(0x55F0)] public EffectRecord data__arr250;
        [FieldOffset(0x5648)] public EffectRecord data__arr251;
        [FieldOffset(0x56A0)] public EffectRecord data__arr252;
        [FieldOffset(0x56F8)] public EffectRecord data__arr253;
        [FieldOffset(0x5750)] public EffectRecord data__arr254;
    }

}