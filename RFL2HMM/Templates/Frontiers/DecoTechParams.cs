using System.Numerics;
using System.Runtime.InteropServices;

public class DecoTechParamsClass
{
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

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    public enum Orientation : sbyte
    {
        ORIENTATION_NONE = 0,
        ORIENTATION_HORIZONTAL = 1,
        ORIENTATION_VERTICAL = 2,
        ORIENTATION_DIAGONAL = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct DecoGradationParam
    {
        [FieldOffset(0x00)] public Orientation orientation;
        [FieldOffset(0x01)] public sbyte srcPosX;
        [FieldOffset(0x02)] public sbyte srcPosY;
        [FieldOffset(0x03)] public sbyte dstPosX;
        [FieldOffset(0x04)] public sbyte dstPosY;
        [FieldOffset(0x08)] public Color8 srcColor;
        [FieldOffset(0x0C)] public Color8 dstColor;
    }

    public enum DecoLayerBlendOp : sbyte
    {
        DECO_LAYER_BLEND_OP_BLEND = 0,
        DECO_LAYER_BLEND_OP_SUBTRACT_ALPHA = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct DecoDropShadowParam
    {
        [FieldOffset(0x00)] public Color8 color;
        [FieldOffset(0x04)] public byte size;
        [FieldOffset(0x05)] public byte spread;
        [FieldOffset(0x06)] public sbyte distanceX;
        [FieldOffset(0x07)] public sbyte distanceY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct DecoRimParam
    {
        [FieldOffset(0x00)] public Color8 color;
        [FieldOffset(0x04)] public int thickness;
        [FieldOffset(0x08)] public int offsetX;
        [FieldOffset(0x0C)] public int offsetY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct DecoBlurParam
    {
        [FieldOffset(0x00)] public int radius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct DecoPassParam
    {
        [FieldOffset(0x00)] public DecoDropShadowParam dropShadow;
        [FieldOffset(0x08)] public DecoRimParam rim;
        [FieldOffset(0x18)] public DecoGradationParam gradation;
        [FieldOffset(0x28)] public DecoBlurParam blur;
        [FieldOffset(0x2C)] public bool avoidEdgeArtifact;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x120)]
    public struct DecoTechParam
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public Color8 fontColor;
        [FieldOffset(0x14)] public DecoGradationParam fontGradParam;
        [FieldOffset(0x24)] public DecoLayerBlendOp layerBlendOp;
        [FieldOffset(0x28)] public int numPasses;
        [FieldOffset(0x2C)] public DecoPassParam passParams__arr0;
        [FieldOffset(0x5C)] public DecoPassParam passParams__arr1;
        [FieldOffset(0x8C)] public DecoPassParam passParams__arr2;
        [FieldOffset(0xBC)] public DecoPassParam passParams__arr3;
        [FieldOffset(0xEC)] public DecoPassParam passParams__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24000)]
    public struct DecoTechParams
    {
        [FieldOffset(0x00)] public DecoTechParam _params__arr0;
        [FieldOffset(0x120)] public DecoTechParam _params__arr1;
        [FieldOffset(0x240)] public DecoTechParam _params__arr2;
        [FieldOffset(0x360)] public DecoTechParam _params__arr3;
        [FieldOffset(0x480)] public DecoTechParam _params__arr4;
        [FieldOffset(0x5A0)] public DecoTechParam _params__arr5;
        [FieldOffset(0x6C0)] public DecoTechParam _params__arr6;
        [FieldOffset(0x7E0)] public DecoTechParam _params__arr7;
        [FieldOffset(0x900)] public DecoTechParam _params__arr8;
        [FieldOffset(0xA20)] public DecoTechParam _params__arr9;
        [FieldOffset(0xB40)] public DecoTechParam _params__arr10;
        [FieldOffset(0xC60)] public DecoTechParam _params__arr11;
        [FieldOffset(0xD80)] public DecoTechParam _params__arr12;
        [FieldOffset(0xEA0)] public DecoTechParam _params__arr13;
        [FieldOffset(0xFC0)] public DecoTechParam _params__arr14;
        [FieldOffset(0x10E0)] public DecoTechParam _params__arr15;
        [FieldOffset(0x1200)] public DecoTechParam _params__arr16;
        [FieldOffset(0x1320)] public DecoTechParam _params__arr17;
        [FieldOffset(0x1440)] public DecoTechParam _params__arr18;
        [FieldOffset(0x1560)] public DecoTechParam _params__arr19;
        [FieldOffset(0x1680)] public DecoTechParam _params__arr20;
        [FieldOffset(0x17A0)] public DecoTechParam _params__arr21;
        [FieldOffset(0x18C0)] public DecoTechParam _params__arr22;
        [FieldOffset(0x19E0)] public DecoTechParam _params__arr23;
        [FieldOffset(0x1B00)] public DecoTechParam _params__arr24;
        [FieldOffset(0x1C20)] public DecoTechParam _params__arr25;
        [FieldOffset(0x1D40)] public DecoTechParam _params__arr26;
        [FieldOffset(0x1E60)] public DecoTechParam _params__arr27;
        [FieldOffset(0x1F80)] public DecoTechParam _params__arr28;
        [FieldOffset(0x20A0)] public DecoTechParam _params__arr29;
        [FieldOffset(0x21C0)] public DecoTechParam _params__arr30;
        [FieldOffset(0x22E0)] public DecoTechParam _params__arr31;
        [FieldOffset(0x2400)] public DecoTechParam _params__arr32;
        [FieldOffset(0x2520)] public DecoTechParam _params__arr33;
        [FieldOffset(0x2640)] public DecoTechParam _params__arr34;
        [FieldOffset(0x2760)] public DecoTechParam _params__arr35;
        [FieldOffset(0x2880)] public DecoTechParam _params__arr36;
        [FieldOffset(0x29A0)] public DecoTechParam _params__arr37;
        [FieldOffset(0x2AC0)] public DecoTechParam _params__arr38;
        [FieldOffset(0x2BE0)] public DecoTechParam _params__arr39;
        [FieldOffset(0x2D00)] public DecoTechParam _params__arr40;
        [FieldOffset(0x2E20)] public DecoTechParam _params__arr41;
        [FieldOffset(0x2F40)] public DecoTechParam _params__arr42;
        [FieldOffset(0x3060)] public DecoTechParam _params__arr43;
        [FieldOffset(0x3180)] public DecoTechParam _params__arr44;
        [FieldOffset(0x32A0)] public DecoTechParam _params__arr45;
        [FieldOffset(0x33C0)] public DecoTechParam _params__arr46;
        [FieldOffset(0x34E0)] public DecoTechParam _params__arr47;
        [FieldOffset(0x3600)] public DecoTechParam _params__arr48;
        [FieldOffset(0x3720)] public DecoTechParam _params__arr49;
        [FieldOffset(0x3840)] public DecoTechParam _params__arr50;
        [FieldOffset(0x3960)] public DecoTechParam _params__arr51;
        [FieldOffset(0x3A80)] public DecoTechParam _params__arr52;
        [FieldOffset(0x3BA0)] public DecoTechParam _params__arr53;
        [FieldOffset(0x3CC0)] public DecoTechParam _params__arr54;
        [FieldOffset(0x3DE0)] public DecoTechParam _params__arr55;
        [FieldOffset(0x3F00)] public DecoTechParam _params__arr56;
        [FieldOffset(0x4020)] public DecoTechParam _params__arr57;
        [FieldOffset(0x4140)] public DecoTechParam _params__arr58;
        [FieldOffset(0x4260)] public DecoTechParam _params__arr59;
        [FieldOffset(0x4380)] public DecoTechParam _params__arr60;
        [FieldOffset(0x44A0)] public DecoTechParam _params__arr61;
        [FieldOffset(0x45C0)] public DecoTechParam _params__arr62;
        [FieldOffset(0x46E0)] public DecoTechParam _params__arr63;
        [FieldOffset(0x4800)] public DecoTechParam _params__arr64;
        [FieldOffset(0x4920)] public DecoTechParam _params__arr65;
        [FieldOffset(0x4A40)] public DecoTechParam _params__arr66;
        [FieldOffset(0x4B60)] public DecoTechParam _params__arr67;
        [FieldOffset(0x4C80)] public DecoTechParam _params__arr68;
        [FieldOffset(0x4DA0)] public DecoTechParam _params__arr69;
        [FieldOffset(0x4EC0)] public DecoTechParam _params__arr70;
        [FieldOffset(0x4FE0)] public DecoTechParam _params__arr71;
        [FieldOffset(0x5100)] public DecoTechParam _params__arr72;
        [FieldOffset(0x5220)] public DecoTechParam _params__arr73;
        [FieldOffset(0x5340)] public DecoTechParam _params__arr74;
        [FieldOffset(0x5460)] public DecoTechParam _params__arr75;
        [FieldOffset(0x5580)] public DecoTechParam _params__arr76;
        [FieldOffset(0x56A0)] public DecoTechParam _params__arr77;
        [FieldOffset(0x57C0)] public DecoTechParam _params__arr78;
        [FieldOffset(0x58E0)] public DecoTechParam _params__arr79;
        [FieldOffset(0x5A00)] public DecoTechParam _params__arr80;
        [FieldOffset(0x5B20)] public DecoTechParam _params__arr81;
        [FieldOffset(0x5C40)] public DecoTechParam _params__arr82;
        [FieldOffset(0x5D60)] public DecoTechParam _params__arr83;
        [FieldOffset(0x5E80)] public DecoTechParam _params__arr84;
        [FieldOffset(0x5FA0)] public DecoTechParam _params__arr85;
        [FieldOffset(0x60C0)] public DecoTechParam _params__arr86;
        [FieldOffset(0x61E0)] public DecoTechParam _params__arr87;
        [FieldOffset(0x6300)] public DecoTechParam _params__arr88;
        [FieldOffset(0x6420)] public DecoTechParam _params__arr89;
        [FieldOffset(0x6540)] public DecoTechParam _params__arr90;
        [FieldOffset(0x6660)] public DecoTechParam _params__arr91;
        [FieldOffset(0x6780)] public DecoTechParam _params__arr92;
        [FieldOffset(0x68A0)] public DecoTechParam _params__arr93;
        [FieldOffset(0x69C0)] public DecoTechParam _params__arr94;
        [FieldOffset(0x6AE0)] public DecoTechParam _params__arr95;
        [FieldOffset(0x6C00)] public DecoTechParam _params__arr96;
        [FieldOffset(0x6D20)] public DecoTechParam _params__arr97;
        [FieldOffset(0x6E40)] public DecoTechParam _params__arr98;
        [FieldOffset(0x6F60)] public DecoTechParam _params__arr99;
        [FieldOffset(0x7080)] public DecoTechParam _params__arr100;
        [FieldOffset(0x71A0)] public DecoTechParam _params__arr101;
        [FieldOffset(0x72C0)] public DecoTechParam _params__arr102;
        [FieldOffset(0x73E0)] public DecoTechParam _params__arr103;
        [FieldOffset(0x7500)] public DecoTechParam _params__arr104;
        [FieldOffset(0x7620)] public DecoTechParam _params__arr105;
        [FieldOffset(0x7740)] public DecoTechParam _params__arr106;
        [FieldOffset(0x7860)] public DecoTechParam _params__arr107;
        [FieldOffset(0x7980)] public DecoTechParam _params__arr108;
        [FieldOffset(0x7AA0)] public DecoTechParam _params__arr109;
        [FieldOffset(0x7BC0)] public DecoTechParam _params__arr110;
        [FieldOffset(0x7CE0)] public DecoTechParam _params__arr111;
        [FieldOffset(0x7E00)] public DecoTechParam _params__arr112;
        [FieldOffset(0x7F20)] public DecoTechParam _params__arr113;
        [FieldOffset(0x8040)] public DecoTechParam _params__arr114;
        [FieldOffset(0x8160)] public DecoTechParam _params__arr115;
        [FieldOffset(0x8280)] public DecoTechParam _params__arr116;
        [FieldOffset(0x83A0)] public DecoTechParam _params__arr117;
        [FieldOffset(0x84C0)] public DecoTechParam _params__arr118;
        [FieldOffset(0x85E0)] public DecoTechParam _params__arr119;
        [FieldOffset(0x8700)] public DecoTechParam _params__arr120;
        [FieldOffset(0x8820)] public DecoTechParam _params__arr121;
        [FieldOffset(0x8940)] public DecoTechParam _params__arr122;
        [FieldOffset(0x8A60)] public DecoTechParam _params__arr123;
        [FieldOffset(0x8B80)] public DecoTechParam _params__arr124;
        [FieldOffset(0x8CA0)] public DecoTechParam _params__arr125;
        [FieldOffset(0x8DC0)] public DecoTechParam _params__arr126;
        [FieldOffset(0x8EE0)] public DecoTechParam _params__arr127;
        [FieldOffset(0x9000)] public DecoTechParam _params__arr128;
        [FieldOffset(0x9120)] public DecoTechParam _params__arr129;
        [FieldOffset(0x9240)] public DecoTechParam _params__arr130;
        [FieldOffset(0x9360)] public DecoTechParam _params__arr131;
        [FieldOffset(0x9480)] public DecoTechParam _params__arr132;
        [FieldOffset(0x95A0)] public DecoTechParam _params__arr133;
        [FieldOffset(0x96C0)] public DecoTechParam _params__arr134;
        [FieldOffset(0x97E0)] public DecoTechParam _params__arr135;
        [FieldOffset(0x9900)] public DecoTechParam _params__arr136;
        [FieldOffset(0x9A20)] public DecoTechParam _params__arr137;
        [FieldOffset(0x9B40)] public DecoTechParam _params__arr138;
        [FieldOffset(0x9C60)] public DecoTechParam _params__arr139;
        [FieldOffset(0x9D80)] public DecoTechParam _params__arr140;
        [FieldOffset(0x9EA0)] public DecoTechParam _params__arr141;
        [FieldOffset(0x9FC0)] public DecoTechParam _params__arr142;
        [FieldOffset(0xA0E0)] public DecoTechParam _params__arr143;
        [FieldOffset(0xA200)] public DecoTechParam _params__arr144;
        [FieldOffset(0xA320)] public DecoTechParam _params__arr145;
        [FieldOffset(0xA440)] public DecoTechParam _params__arr146;
        [FieldOffset(0xA560)] public DecoTechParam _params__arr147;
        [FieldOffset(0xA680)] public DecoTechParam _params__arr148;
        [FieldOffset(0xA7A0)] public DecoTechParam _params__arr149;
        [FieldOffset(0xA8C0)] public DecoTechParam _params__arr150;
        [FieldOffset(0xA9E0)] public DecoTechParam _params__arr151;
        [FieldOffset(0xAB00)] public DecoTechParam _params__arr152;
        [FieldOffset(0xAC20)] public DecoTechParam _params__arr153;
        [FieldOffset(0xAD40)] public DecoTechParam _params__arr154;
        [FieldOffset(0xAE60)] public DecoTechParam _params__arr155;
        [FieldOffset(0xAF80)] public DecoTechParam _params__arr156;
        [FieldOffset(0xB0A0)] public DecoTechParam _params__arr157;
        [FieldOffset(0xB1C0)] public DecoTechParam _params__arr158;
        [FieldOffset(0xB2E0)] public DecoTechParam _params__arr159;
        [FieldOffset(0xB400)] public DecoTechParam _params__arr160;
        [FieldOffset(0xB520)] public DecoTechParam _params__arr161;
        [FieldOffset(0xB640)] public DecoTechParam _params__arr162;
        [FieldOffset(0xB760)] public DecoTechParam _params__arr163;
        [FieldOffset(0xB880)] public DecoTechParam _params__arr164;
        [FieldOffset(0xB9A0)] public DecoTechParam _params__arr165;
        [FieldOffset(0xBAC0)] public DecoTechParam _params__arr166;
        [FieldOffset(0xBBE0)] public DecoTechParam _params__arr167;
        [FieldOffset(0xBD00)] public DecoTechParam _params__arr168;
        [FieldOffset(0xBE20)] public DecoTechParam _params__arr169;
        [FieldOffset(0xBF40)] public DecoTechParam _params__arr170;
        [FieldOffset(0xC060)] public DecoTechParam _params__arr171;
        [FieldOffset(0xC180)] public DecoTechParam _params__arr172;
        [FieldOffset(0xC2A0)] public DecoTechParam _params__arr173;
        [FieldOffset(0xC3C0)] public DecoTechParam _params__arr174;
        [FieldOffset(0xC4E0)] public DecoTechParam _params__arr175;
        [FieldOffset(0xC600)] public DecoTechParam _params__arr176;
        [FieldOffset(0xC720)] public DecoTechParam _params__arr177;
        [FieldOffset(0xC840)] public DecoTechParam _params__arr178;
        [FieldOffset(0xC960)] public DecoTechParam _params__arr179;
        [FieldOffset(0xCA80)] public DecoTechParam _params__arr180;
        [FieldOffset(0xCBA0)] public DecoTechParam _params__arr181;
        [FieldOffset(0xCCC0)] public DecoTechParam _params__arr182;
        [FieldOffset(0xCDE0)] public DecoTechParam _params__arr183;
        [FieldOffset(0xCF00)] public DecoTechParam _params__arr184;
        [FieldOffset(0xD020)] public DecoTechParam _params__arr185;
        [FieldOffset(0xD140)] public DecoTechParam _params__arr186;
        [FieldOffset(0xD260)] public DecoTechParam _params__arr187;
        [FieldOffset(0xD380)] public DecoTechParam _params__arr188;
        [FieldOffset(0xD4A0)] public DecoTechParam _params__arr189;
        [FieldOffset(0xD5C0)] public DecoTechParam _params__arr190;
        [FieldOffset(0xD6E0)] public DecoTechParam _params__arr191;
        [FieldOffset(0xD800)] public DecoTechParam _params__arr192;
        [FieldOffset(0xD920)] public DecoTechParam _params__arr193;
        [FieldOffset(0xDA40)] public DecoTechParam _params__arr194;
        [FieldOffset(0xDB60)] public DecoTechParam _params__arr195;
        [FieldOffset(0xDC80)] public DecoTechParam _params__arr196;
        [FieldOffset(0xDDA0)] public DecoTechParam _params__arr197;
        [FieldOffset(0xDEC0)] public DecoTechParam _params__arr198;
        [FieldOffset(0xDFE0)] public DecoTechParam _params__arr199;
        [FieldOffset(0xE100)] public DecoTechParam _params__arr200;
        [FieldOffset(0xE220)] public DecoTechParam _params__arr201;
        [FieldOffset(0xE340)] public DecoTechParam _params__arr202;
        [FieldOffset(0xE460)] public DecoTechParam _params__arr203;
        [FieldOffset(0xE580)] public DecoTechParam _params__arr204;
        [FieldOffset(0xE6A0)] public DecoTechParam _params__arr205;
        [FieldOffset(0xE7C0)] public DecoTechParam _params__arr206;
        [FieldOffset(0xE8E0)] public DecoTechParam _params__arr207;
        [FieldOffset(0xEA00)] public DecoTechParam _params__arr208;
        [FieldOffset(0xEB20)] public DecoTechParam _params__arr209;
        [FieldOffset(0xEC40)] public DecoTechParam _params__arr210;
        [FieldOffset(0xED60)] public DecoTechParam _params__arr211;
        [FieldOffset(0xEE80)] public DecoTechParam _params__arr212;
        [FieldOffset(0xEFA0)] public DecoTechParam _params__arr213;
        [FieldOffset(0xF0C0)] public DecoTechParam _params__arr214;
        [FieldOffset(0xF1E0)] public DecoTechParam _params__arr215;
        [FieldOffset(0xF300)] public DecoTechParam _params__arr216;
        [FieldOffset(0xF420)] public DecoTechParam _params__arr217;
        [FieldOffset(0xF540)] public DecoTechParam _params__arr218;
        [FieldOffset(0xF660)] public DecoTechParam _params__arr219;
        [FieldOffset(0xF780)] public DecoTechParam _params__arr220;
        [FieldOffset(0xF8A0)] public DecoTechParam _params__arr221;
        [FieldOffset(0xF9C0)] public DecoTechParam _params__arr222;
        [FieldOffset(0xFAE0)] public DecoTechParam _params__arr223;
        [FieldOffset(0xFC00)] public DecoTechParam _params__arr224;
        [FieldOffset(0xFD20)] public DecoTechParam _params__arr225;
        [FieldOffset(0xFE40)] public DecoTechParam _params__arr226;
        [FieldOffset(0xFF60)] public DecoTechParam _params__arr227;
        [FieldOffset(0x10080)] public DecoTechParam _params__arr228;
        [FieldOffset(0x101A0)] public DecoTechParam _params__arr229;
        [FieldOffset(0x102C0)] public DecoTechParam _params__arr230;
        [FieldOffset(0x103E0)] public DecoTechParam _params__arr231;
        [FieldOffset(0x10500)] public DecoTechParam _params__arr232;
        [FieldOffset(0x10620)] public DecoTechParam _params__arr233;
        [FieldOffset(0x10740)] public DecoTechParam _params__arr234;
        [FieldOffset(0x10860)] public DecoTechParam _params__arr235;
        [FieldOffset(0x10980)] public DecoTechParam _params__arr236;
        [FieldOffset(0x10AA0)] public DecoTechParam _params__arr237;
        [FieldOffset(0x10BC0)] public DecoTechParam _params__arr238;
        [FieldOffset(0x10CE0)] public DecoTechParam _params__arr239;
        [FieldOffset(0x10E00)] public DecoTechParam _params__arr240;
        [FieldOffset(0x10F20)] public DecoTechParam _params__arr241;
        [FieldOffset(0x11040)] public DecoTechParam _params__arr242;
        [FieldOffset(0x11160)] public DecoTechParam _params__arr243;
        [FieldOffset(0x11280)] public DecoTechParam _params__arr244;
        [FieldOffset(0x113A0)] public DecoTechParam _params__arr245;
        [FieldOffset(0x114C0)] public DecoTechParam _params__arr246;
        [FieldOffset(0x115E0)] public DecoTechParam _params__arr247;
        [FieldOffset(0x11700)] public DecoTechParam _params__arr248;
        [FieldOffset(0x11820)] public DecoTechParam _params__arr249;
        [FieldOffset(0x11940)] public DecoTechParam _params__arr250;
        [FieldOffset(0x11A60)] public DecoTechParam _params__arr251;
        [FieldOffset(0x11B80)] public DecoTechParam _params__arr252;
        [FieldOffset(0x11CA0)] public DecoTechParam _params__arr253;
        [FieldOffset(0x11DC0)] public DecoTechParam _params__arr254;
        [FieldOffset(0x11EE0)] public DecoTechParam _params__arr255;
        [FieldOffset(0x12000)] public DecoTechParam _params__arr256;
        [FieldOffset(0x12120)] public DecoTechParam _params__arr257;
        [FieldOffset(0x12240)] public DecoTechParam _params__arr258;
        [FieldOffset(0x12360)] public DecoTechParam _params__arr259;
        [FieldOffset(0x12480)] public DecoTechParam _params__arr260;
        [FieldOffset(0x125A0)] public DecoTechParam _params__arr261;
        [FieldOffset(0x126C0)] public DecoTechParam _params__arr262;
        [FieldOffset(0x127E0)] public DecoTechParam _params__arr263;
        [FieldOffset(0x12900)] public DecoTechParam _params__arr264;
        [FieldOffset(0x12A20)] public DecoTechParam _params__arr265;
        [FieldOffset(0x12B40)] public DecoTechParam _params__arr266;
        [FieldOffset(0x12C60)] public DecoTechParam _params__arr267;
        [FieldOffset(0x12D80)] public DecoTechParam _params__arr268;
        [FieldOffset(0x12EA0)] public DecoTechParam _params__arr269;
        [FieldOffset(0x12FC0)] public DecoTechParam _params__arr270;
        [FieldOffset(0x130E0)] public DecoTechParam _params__arr271;
        [FieldOffset(0x13200)] public DecoTechParam _params__arr272;
        [FieldOffset(0x13320)] public DecoTechParam _params__arr273;
        [FieldOffset(0x13440)] public DecoTechParam _params__arr274;
        [FieldOffset(0x13560)] public DecoTechParam _params__arr275;
        [FieldOffset(0x13680)] public DecoTechParam _params__arr276;
        [FieldOffset(0x137A0)] public DecoTechParam _params__arr277;
        [FieldOffset(0x138C0)] public DecoTechParam _params__arr278;
        [FieldOffset(0x139E0)] public DecoTechParam _params__arr279;
        [FieldOffset(0x13B00)] public DecoTechParam _params__arr280;
        [FieldOffset(0x13C20)] public DecoTechParam _params__arr281;
        [FieldOffset(0x13D40)] public DecoTechParam _params__arr282;
        [FieldOffset(0x13E60)] public DecoTechParam _params__arr283;
        [FieldOffset(0x13F80)] public DecoTechParam _params__arr284;
        [FieldOffset(0x140A0)] public DecoTechParam _params__arr285;
        [FieldOffset(0x141C0)] public DecoTechParam _params__arr286;
        [FieldOffset(0x142E0)] public DecoTechParam _params__arr287;
        [FieldOffset(0x14400)] public DecoTechParam _params__arr288;
        [FieldOffset(0x14520)] public DecoTechParam _params__arr289;
        [FieldOffset(0x14640)] public DecoTechParam _params__arr290;
        [FieldOffset(0x14760)] public DecoTechParam _params__arr291;
        [FieldOffset(0x14880)] public DecoTechParam _params__arr292;
        [FieldOffset(0x149A0)] public DecoTechParam _params__arr293;
        [FieldOffset(0x14AC0)] public DecoTechParam _params__arr294;
        [FieldOffset(0x14BE0)] public DecoTechParam _params__arr295;
        [FieldOffset(0x14D00)] public DecoTechParam _params__arr296;
        [FieldOffset(0x14E20)] public DecoTechParam _params__arr297;
        [FieldOffset(0x14F40)] public DecoTechParam _params__arr298;
        [FieldOffset(0x15060)] public DecoTechParam _params__arr299;
        [FieldOffset(0x15180)] public DecoTechParam _params__arr300;
        [FieldOffset(0x152A0)] public DecoTechParam _params__arr301;
        [FieldOffset(0x153C0)] public DecoTechParam _params__arr302;
        [FieldOffset(0x154E0)] public DecoTechParam _params__arr303;
        [FieldOffset(0x15600)] public DecoTechParam _params__arr304;
        [FieldOffset(0x15720)] public DecoTechParam _params__arr305;
        [FieldOffset(0x15840)] public DecoTechParam _params__arr306;
        [FieldOffset(0x15960)] public DecoTechParam _params__arr307;
        [FieldOffset(0x15A80)] public DecoTechParam _params__arr308;
        [FieldOffset(0x15BA0)] public DecoTechParam _params__arr309;
        [FieldOffset(0x15CC0)] public DecoTechParam _params__arr310;
        [FieldOffset(0x15DE0)] public DecoTechParam _params__arr311;
        [FieldOffset(0x15F00)] public DecoTechParam _params__arr312;
        [FieldOffset(0x16020)] public DecoTechParam _params__arr313;
        [FieldOffset(0x16140)] public DecoTechParam _params__arr314;
        [FieldOffset(0x16260)] public DecoTechParam _params__arr315;
        [FieldOffset(0x16380)] public DecoTechParam _params__arr316;
        [FieldOffset(0x164A0)] public DecoTechParam _params__arr317;
        [FieldOffset(0x165C0)] public DecoTechParam _params__arr318;
        [FieldOffset(0x166E0)] public DecoTechParam _params__arr319;
        [FieldOffset(0x16800)] public DecoTechParam _params__arr320;
        [FieldOffset(0x16920)] public DecoTechParam _params__arr321;
        [FieldOffset(0x16A40)] public DecoTechParam _params__arr322;
        [FieldOffset(0x16B60)] public DecoTechParam _params__arr323;
        [FieldOffset(0x16C80)] public DecoTechParam _params__arr324;
        [FieldOffset(0x16DA0)] public DecoTechParam _params__arr325;
        [FieldOffset(0x16EC0)] public DecoTechParam _params__arr326;
        [FieldOffset(0x16FE0)] public DecoTechParam _params__arr327;
        [FieldOffset(0x17100)] public DecoTechParam _params__arr328;
        [FieldOffset(0x17220)] public DecoTechParam _params__arr329;
        [FieldOffset(0x17340)] public DecoTechParam _params__arr330;
        [FieldOffset(0x17460)] public DecoTechParam _params__arr331;
        [FieldOffset(0x17580)] public DecoTechParam _params__arr332;
        [FieldOffset(0x176A0)] public DecoTechParam _params__arr333;
        [FieldOffset(0x177C0)] public DecoTechParam _params__arr334;
        [FieldOffset(0x178E0)] public DecoTechParam _params__arr335;
        [FieldOffset(0x17A00)] public DecoTechParam _params__arr336;
        [FieldOffset(0x17B20)] public DecoTechParam _params__arr337;
        [FieldOffset(0x17C40)] public DecoTechParam _params__arr338;
        [FieldOffset(0x17D60)] public DecoTechParam _params__arr339;
        [FieldOffset(0x17E80)] public DecoTechParam _params__arr340;
        [FieldOffset(0x17FA0)] public DecoTechParam _params__arr341;
        [FieldOffset(0x180C0)] public DecoTechParam _params__arr342;
        [FieldOffset(0x181E0)] public DecoTechParam _params__arr343;
        [FieldOffset(0x18300)] public DecoTechParam _params__arr344;
        [FieldOffset(0x18420)] public DecoTechParam _params__arr345;
        [FieldOffset(0x18540)] public DecoTechParam _params__arr346;
        [FieldOffset(0x18660)] public DecoTechParam _params__arr347;
        [FieldOffset(0x18780)] public DecoTechParam _params__arr348;
        [FieldOffset(0x188A0)] public DecoTechParam _params__arr349;
        [FieldOffset(0x189C0)] public DecoTechParam _params__arr350;
        [FieldOffset(0x18AE0)] public DecoTechParam _params__arr351;
        [FieldOffset(0x18C00)] public DecoTechParam _params__arr352;
        [FieldOffset(0x18D20)] public DecoTechParam _params__arr353;
        [FieldOffset(0x18E40)] public DecoTechParam _params__arr354;
        [FieldOffset(0x18F60)] public DecoTechParam _params__arr355;
        [FieldOffset(0x19080)] public DecoTechParam _params__arr356;
        [FieldOffset(0x191A0)] public DecoTechParam _params__arr357;
        [FieldOffset(0x192C0)] public DecoTechParam _params__arr358;
        [FieldOffset(0x193E0)] public DecoTechParam _params__arr359;
        [FieldOffset(0x19500)] public DecoTechParam _params__arr360;
        [FieldOffset(0x19620)] public DecoTechParam _params__arr361;
        [FieldOffset(0x19740)] public DecoTechParam _params__arr362;
        [FieldOffset(0x19860)] public DecoTechParam _params__arr363;
        [FieldOffset(0x19980)] public DecoTechParam _params__arr364;
        [FieldOffset(0x19AA0)] public DecoTechParam _params__arr365;
        [FieldOffset(0x19BC0)] public DecoTechParam _params__arr366;
        [FieldOffset(0x19CE0)] public DecoTechParam _params__arr367;
        [FieldOffset(0x19E00)] public DecoTechParam _params__arr368;
        [FieldOffset(0x19F20)] public DecoTechParam _params__arr369;
        [FieldOffset(0x1A040)] public DecoTechParam _params__arr370;
        [FieldOffset(0x1A160)] public DecoTechParam _params__arr371;
        [FieldOffset(0x1A280)] public DecoTechParam _params__arr372;
        [FieldOffset(0x1A3A0)] public DecoTechParam _params__arr373;
        [FieldOffset(0x1A4C0)] public DecoTechParam _params__arr374;
        [FieldOffset(0x1A5E0)] public DecoTechParam _params__arr375;
        [FieldOffset(0x1A700)] public DecoTechParam _params__arr376;
        [FieldOffset(0x1A820)] public DecoTechParam _params__arr377;
        [FieldOffset(0x1A940)] public DecoTechParam _params__arr378;
        [FieldOffset(0x1AA60)] public DecoTechParam _params__arr379;
        [FieldOffset(0x1AB80)] public DecoTechParam _params__arr380;
        [FieldOffset(0x1ACA0)] public DecoTechParam _params__arr381;
        [FieldOffset(0x1ADC0)] public DecoTechParam _params__arr382;
        [FieldOffset(0x1AEE0)] public DecoTechParam _params__arr383;
        [FieldOffset(0x1B000)] public DecoTechParam _params__arr384;
        [FieldOffset(0x1B120)] public DecoTechParam _params__arr385;
        [FieldOffset(0x1B240)] public DecoTechParam _params__arr386;
        [FieldOffset(0x1B360)] public DecoTechParam _params__arr387;
        [FieldOffset(0x1B480)] public DecoTechParam _params__arr388;
        [FieldOffset(0x1B5A0)] public DecoTechParam _params__arr389;
        [FieldOffset(0x1B6C0)] public DecoTechParam _params__arr390;
        [FieldOffset(0x1B7E0)] public DecoTechParam _params__arr391;
        [FieldOffset(0x1B900)] public DecoTechParam _params__arr392;
        [FieldOffset(0x1BA20)] public DecoTechParam _params__arr393;
        [FieldOffset(0x1BB40)] public DecoTechParam _params__arr394;
        [FieldOffset(0x1BC60)] public DecoTechParam _params__arr395;
        [FieldOffset(0x1BD80)] public DecoTechParam _params__arr396;
        [FieldOffset(0x1BEA0)] public DecoTechParam _params__arr397;
        [FieldOffset(0x1BFC0)] public DecoTechParam _params__arr398;
        [FieldOffset(0x1C0E0)] public DecoTechParam _params__arr399;
        [FieldOffset(0x1C200)] public DecoTechParam _params__arr400;
        [FieldOffset(0x1C320)] public DecoTechParam _params__arr401;
        [FieldOffset(0x1C440)] public DecoTechParam _params__arr402;
        [FieldOffset(0x1C560)] public DecoTechParam _params__arr403;
        [FieldOffset(0x1C680)] public DecoTechParam _params__arr404;
        [FieldOffset(0x1C7A0)] public DecoTechParam _params__arr405;
        [FieldOffset(0x1C8C0)] public DecoTechParam _params__arr406;
        [FieldOffset(0x1C9E0)] public DecoTechParam _params__arr407;
        [FieldOffset(0x1CB00)] public DecoTechParam _params__arr408;
        [FieldOffset(0x1CC20)] public DecoTechParam _params__arr409;
        [FieldOffset(0x1CD40)] public DecoTechParam _params__arr410;
        [FieldOffset(0x1CE60)] public DecoTechParam _params__arr411;
        [FieldOffset(0x1CF80)] public DecoTechParam _params__arr412;
        [FieldOffset(0x1D0A0)] public DecoTechParam _params__arr413;
        [FieldOffset(0x1D1C0)] public DecoTechParam _params__arr414;
        [FieldOffset(0x1D2E0)] public DecoTechParam _params__arr415;
        [FieldOffset(0x1D400)] public DecoTechParam _params__arr416;
        [FieldOffset(0x1D520)] public DecoTechParam _params__arr417;
        [FieldOffset(0x1D640)] public DecoTechParam _params__arr418;
        [FieldOffset(0x1D760)] public DecoTechParam _params__arr419;
        [FieldOffset(0x1D880)] public DecoTechParam _params__arr420;
        [FieldOffset(0x1D9A0)] public DecoTechParam _params__arr421;
        [FieldOffset(0x1DAC0)] public DecoTechParam _params__arr422;
        [FieldOffset(0x1DBE0)] public DecoTechParam _params__arr423;
        [FieldOffset(0x1DD00)] public DecoTechParam _params__arr424;
        [FieldOffset(0x1DE20)] public DecoTechParam _params__arr425;
        [FieldOffset(0x1DF40)] public DecoTechParam _params__arr426;
        [FieldOffset(0x1E060)] public DecoTechParam _params__arr427;
        [FieldOffset(0x1E180)] public DecoTechParam _params__arr428;
        [FieldOffset(0x1E2A0)] public DecoTechParam _params__arr429;
        [FieldOffset(0x1E3C0)] public DecoTechParam _params__arr430;
        [FieldOffset(0x1E4E0)] public DecoTechParam _params__arr431;
        [FieldOffset(0x1E600)] public DecoTechParam _params__arr432;
        [FieldOffset(0x1E720)] public DecoTechParam _params__arr433;
        [FieldOffset(0x1E840)] public DecoTechParam _params__arr434;
        [FieldOffset(0x1E960)] public DecoTechParam _params__arr435;
        [FieldOffset(0x1EA80)] public DecoTechParam _params__arr436;
        [FieldOffset(0x1EBA0)] public DecoTechParam _params__arr437;
        [FieldOffset(0x1ECC0)] public DecoTechParam _params__arr438;
        [FieldOffset(0x1EDE0)] public DecoTechParam _params__arr439;
        [FieldOffset(0x1EF00)] public DecoTechParam _params__arr440;
        [FieldOffset(0x1F020)] public DecoTechParam _params__arr441;
        [FieldOffset(0x1F140)] public DecoTechParam _params__arr442;
        [FieldOffset(0x1F260)] public DecoTechParam _params__arr443;
        [FieldOffset(0x1F380)] public DecoTechParam _params__arr444;
        [FieldOffset(0x1F4A0)] public DecoTechParam _params__arr445;
        [FieldOffset(0x1F5C0)] public DecoTechParam _params__arr446;
        [FieldOffset(0x1F6E0)] public DecoTechParam _params__arr447;
        [FieldOffset(0x1F800)] public DecoTechParam _params__arr448;
        [FieldOffset(0x1F920)] public DecoTechParam _params__arr449;
        [FieldOffset(0x1FA40)] public DecoTechParam _params__arr450;
        [FieldOffset(0x1FB60)] public DecoTechParam _params__arr451;
        [FieldOffset(0x1FC80)] public DecoTechParam _params__arr452;
        [FieldOffset(0x1FDA0)] public DecoTechParam _params__arr453;
        [FieldOffset(0x1FEC0)] public DecoTechParam _params__arr454;
        [FieldOffset(0x1FFE0)] public DecoTechParam _params__arr455;
        [FieldOffset(0x20100)] public DecoTechParam _params__arr456;
        [FieldOffset(0x20220)] public DecoTechParam _params__arr457;
        [FieldOffset(0x20340)] public DecoTechParam _params__arr458;
        [FieldOffset(0x20460)] public DecoTechParam _params__arr459;
        [FieldOffset(0x20580)] public DecoTechParam _params__arr460;
        [FieldOffset(0x206A0)] public DecoTechParam _params__arr461;
        [FieldOffset(0x207C0)] public DecoTechParam _params__arr462;
        [FieldOffset(0x208E0)] public DecoTechParam _params__arr463;
        [FieldOffset(0x20A00)] public DecoTechParam _params__arr464;
        [FieldOffset(0x20B20)] public DecoTechParam _params__arr465;
        [FieldOffset(0x20C40)] public DecoTechParam _params__arr466;
        [FieldOffset(0x20D60)] public DecoTechParam _params__arr467;
        [FieldOffset(0x20E80)] public DecoTechParam _params__arr468;
        [FieldOffset(0x20FA0)] public DecoTechParam _params__arr469;
        [FieldOffset(0x210C0)] public DecoTechParam _params__arr470;
        [FieldOffset(0x211E0)] public DecoTechParam _params__arr471;
        [FieldOffset(0x21300)] public DecoTechParam _params__arr472;
        [FieldOffset(0x21420)] public DecoTechParam _params__arr473;
        [FieldOffset(0x21540)] public DecoTechParam _params__arr474;
        [FieldOffset(0x21660)] public DecoTechParam _params__arr475;
        [FieldOffset(0x21780)] public DecoTechParam _params__arr476;
        [FieldOffset(0x218A0)] public DecoTechParam _params__arr477;
        [FieldOffset(0x219C0)] public DecoTechParam _params__arr478;
        [FieldOffset(0x21AE0)] public DecoTechParam _params__arr479;
        [FieldOffset(0x21C00)] public DecoTechParam _params__arr480;
        [FieldOffset(0x21D20)] public DecoTechParam _params__arr481;
        [FieldOffset(0x21E40)] public DecoTechParam _params__arr482;
        [FieldOffset(0x21F60)] public DecoTechParam _params__arr483;
        [FieldOffset(0x22080)] public DecoTechParam _params__arr484;
        [FieldOffset(0x221A0)] public DecoTechParam _params__arr485;
        [FieldOffset(0x222C0)] public DecoTechParam _params__arr486;
        [FieldOffset(0x223E0)] public DecoTechParam _params__arr487;
        [FieldOffset(0x22500)] public DecoTechParam _params__arr488;
        [FieldOffset(0x22620)] public DecoTechParam _params__arr489;
        [FieldOffset(0x22740)] public DecoTechParam _params__arr490;
        [FieldOffset(0x22860)] public DecoTechParam _params__arr491;
        [FieldOffset(0x22980)] public DecoTechParam _params__arr492;
        [FieldOffset(0x22AA0)] public DecoTechParam _params__arr493;
        [FieldOffset(0x22BC0)] public DecoTechParam _params__arr494;
        [FieldOffset(0x22CE0)] public DecoTechParam _params__arr495;
        [FieldOffset(0x22E00)] public DecoTechParam _params__arr496;
        [FieldOffset(0x22F20)] public DecoTechParam _params__arr497;
        [FieldOffset(0x23040)] public DecoTechParam _params__arr498;
        [FieldOffset(0x23160)] public DecoTechParam _params__arr499;
        [FieldOffset(0x23280)] public DecoTechParam _params__arr500;
        [FieldOffset(0x233A0)] public DecoTechParam _params__arr501;
        [FieldOffset(0x234C0)] public DecoTechParam _params__arr502;
        [FieldOffset(0x235E0)] public DecoTechParam _params__arr503;
        [FieldOffset(0x23700)] public DecoTechParam _params__arr504;
        [FieldOffset(0x23820)] public DecoTechParam _params__arr505;
        [FieldOffset(0x23940)] public DecoTechParam _params__arr506;
        [FieldOffset(0x23A60)] public DecoTechParam _params__arr507;
        [FieldOffset(0x23B80)] public DecoTechParam _params__arr508;
        [FieldOffset(0x23CA0)] public DecoTechParam _params__arr509;
        [FieldOffset(0x23DC0)] public DecoTechParam _params__arr510;
        [FieldOffset(0x23EE0)] public DecoTechParam _params__arr511;
    }

}