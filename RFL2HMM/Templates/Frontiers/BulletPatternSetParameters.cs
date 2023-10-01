using System.Numerics;
using System.Runtime.InteropServices;

public class BulletPatternSetParametersClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct HackingBulletParameter
    {
        [FieldOffset(0x00)] public float bulletRadius;
        [FieldOffset(0x04)] public float bulletModelScale;
        [FieldOffset(0x08)] public float bulletRadiusLastBoss;
        [FieldOffset(0x0C)] public float bulletModelScaleLastBoss;
        [FieldOffset(0x10)] public float bulletModelOffsetRateLastBoss;
        [FieldOffset(0x14)] public float laserNormalRadius;
        [FieldOffset(0x18)] public float laserThickRadius;
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

    public enum Type : byte
    {
        BulletFixed = 0,
        BulletAimPlayer = 1,
        LaserNormal = 2,
        LaserThick = 3,
        LaserAimPlayer = 4
    }

    public enum ElementType : byte
    {
        Hacking1 = 0,
        Hacking2 = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct AnimationParameter
    {
        [FieldOffset(0x00)] public float angle;
        [FieldOffset(0x04)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct BulletPatternParameter
    {
        [FieldOffset(0x00)] public Type type;
        [FieldOffset(0x01)] public ElementType element;
        [FieldOffset(0x04)] public float startAngle;
        [FieldOffset(0x08)] public float endAngle;
        [FieldOffset(0x0C)] public byte shootNum;
        [FieldOffset(0x10)] public float shootSpeed;
        [FieldOffset(0x14)] public byte wayNum;
        [FieldOffset(0x18)] public float wayAngle;
        [FieldOffset(0x1C)] public float laserLength;
        [FieldOffset(0x20)] public float lifeTime;
        [FieldOffset(0x24)] public bool animation;
        [FieldOffset(0x28)] public AnimationParameter animParam__arr0;
        [FieldOffset(0x30)] public AnimationParameter animParam__arr1;
        [FieldOffset(0x38)] public AnimationParameter animParam__arr2;
        [FieldOffset(0x40)] public AnimationParameter animParam__arr3;
        [FieldOffset(0x48)] public AnimationParameter animParam__arr4;
        [FieldOffset(0x50)] public AnimationParameter animParam__arr5;
        [FieldOffset(0x58)] public AnimationParameter animParam__arr6;
        [FieldOffset(0x60)] public AnimationParameter animParam__arr7;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x78)]
    public struct BulletPatternSetParameter
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public BulletPatternParameter param;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x7820)]
    public struct BulletPatternSetParameters
    {
        [FieldOffset(0x00)] public HackingBulletParameter bulletParam;
        [FieldOffset(0x20)] public BulletPatternSetParameter data__arr0;
        [FieldOffset(0x98)] public BulletPatternSetParameter data__arr1;
        [FieldOffset(0x110)] public BulletPatternSetParameter data__arr2;
        [FieldOffset(0x188)] public BulletPatternSetParameter data__arr3;
        [FieldOffset(0x200)] public BulletPatternSetParameter data__arr4;
        [FieldOffset(0x278)] public BulletPatternSetParameter data__arr5;
        [FieldOffset(0x2F0)] public BulletPatternSetParameter data__arr6;
        [FieldOffset(0x368)] public BulletPatternSetParameter data__arr7;
        [FieldOffset(0x3E0)] public BulletPatternSetParameter data__arr8;
        [FieldOffset(0x458)] public BulletPatternSetParameter data__arr9;
        [FieldOffset(0x4D0)] public BulletPatternSetParameter data__arr10;
        [FieldOffset(0x548)] public BulletPatternSetParameter data__arr11;
        [FieldOffset(0x5C0)] public BulletPatternSetParameter data__arr12;
        [FieldOffset(0x638)] public BulletPatternSetParameter data__arr13;
        [FieldOffset(0x6B0)] public BulletPatternSetParameter data__arr14;
        [FieldOffset(0x728)] public BulletPatternSetParameter data__arr15;
        [FieldOffset(0x7A0)] public BulletPatternSetParameter data__arr16;
        [FieldOffset(0x818)] public BulletPatternSetParameter data__arr17;
        [FieldOffset(0x890)] public BulletPatternSetParameter data__arr18;
        [FieldOffset(0x908)] public BulletPatternSetParameter data__arr19;
        [FieldOffset(0x980)] public BulletPatternSetParameter data__arr20;
        [FieldOffset(0x9F8)] public BulletPatternSetParameter data__arr21;
        [FieldOffset(0xA70)] public BulletPatternSetParameter data__arr22;
        [FieldOffset(0xAE8)] public BulletPatternSetParameter data__arr23;
        [FieldOffset(0xB60)] public BulletPatternSetParameter data__arr24;
        [FieldOffset(0xBD8)] public BulletPatternSetParameter data__arr25;
        [FieldOffset(0xC50)] public BulletPatternSetParameter data__arr26;
        [FieldOffset(0xCC8)] public BulletPatternSetParameter data__arr27;
        [FieldOffset(0xD40)] public BulletPatternSetParameter data__arr28;
        [FieldOffset(0xDB8)] public BulletPatternSetParameter data__arr29;
        [FieldOffset(0xE30)] public BulletPatternSetParameter data__arr30;
        [FieldOffset(0xEA8)] public BulletPatternSetParameter data__arr31;
        [FieldOffset(0xF20)] public BulletPatternSetParameter data__arr32;
        [FieldOffset(0xF98)] public BulletPatternSetParameter data__arr33;
        [FieldOffset(0x1010)] public BulletPatternSetParameter data__arr34;
        [FieldOffset(0x1088)] public BulletPatternSetParameter data__arr35;
        [FieldOffset(0x1100)] public BulletPatternSetParameter data__arr36;
        [FieldOffset(0x1178)] public BulletPatternSetParameter data__arr37;
        [FieldOffset(0x11F0)] public BulletPatternSetParameter data__arr38;
        [FieldOffset(0x1268)] public BulletPatternSetParameter data__arr39;
        [FieldOffset(0x12E0)] public BulletPatternSetParameter data__arr40;
        [FieldOffset(0x1358)] public BulletPatternSetParameter data__arr41;
        [FieldOffset(0x13D0)] public BulletPatternSetParameter data__arr42;
        [FieldOffset(0x1448)] public BulletPatternSetParameter data__arr43;
        [FieldOffset(0x14C0)] public BulletPatternSetParameter data__arr44;
        [FieldOffset(0x1538)] public BulletPatternSetParameter data__arr45;
        [FieldOffset(0x15B0)] public BulletPatternSetParameter data__arr46;
        [FieldOffset(0x1628)] public BulletPatternSetParameter data__arr47;
        [FieldOffset(0x16A0)] public BulletPatternSetParameter data__arr48;
        [FieldOffset(0x1718)] public BulletPatternSetParameter data__arr49;
        [FieldOffset(0x1790)] public BulletPatternSetParameter data__arr50;
        [FieldOffset(0x1808)] public BulletPatternSetParameter data__arr51;
        [FieldOffset(0x1880)] public BulletPatternSetParameter data__arr52;
        [FieldOffset(0x18F8)] public BulletPatternSetParameter data__arr53;
        [FieldOffset(0x1970)] public BulletPatternSetParameter data__arr54;
        [FieldOffset(0x19E8)] public BulletPatternSetParameter data__arr55;
        [FieldOffset(0x1A60)] public BulletPatternSetParameter data__arr56;
        [FieldOffset(0x1AD8)] public BulletPatternSetParameter data__arr57;
        [FieldOffset(0x1B50)] public BulletPatternSetParameter data__arr58;
        [FieldOffset(0x1BC8)] public BulletPatternSetParameter data__arr59;
        [FieldOffset(0x1C40)] public BulletPatternSetParameter data__arr60;
        [FieldOffset(0x1CB8)] public BulletPatternSetParameter data__arr61;
        [FieldOffset(0x1D30)] public BulletPatternSetParameter data__arr62;
        [FieldOffset(0x1DA8)] public BulletPatternSetParameter data__arr63;
        [FieldOffset(0x1E20)] public BulletPatternSetParameter data__arr64;
        [FieldOffset(0x1E98)] public BulletPatternSetParameter data__arr65;
        [FieldOffset(0x1F10)] public BulletPatternSetParameter data__arr66;
        [FieldOffset(0x1F88)] public BulletPatternSetParameter data__arr67;
        [FieldOffset(0x2000)] public BulletPatternSetParameter data__arr68;
        [FieldOffset(0x2078)] public BulletPatternSetParameter data__arr69;
        [FieldOffset(0x20F0)] public BulletPatternSetParameter data__arr70;
        [FieldOffset(0x2168)] public BulletPatternSetParameter data__arr71;
        [FieldOffset(0x21E0)] public BulletPatternSetParameter data__arr72;
        [FieldOffset(0x2258)] public BulletPatternSetParameter data__arr73;
        [FieldOffset(0x22D0)] public BulletPatternSetParameter data__arr74;
        [FieldOffset(0x2348)] public BulletPatternSetParameter data__arr75;
        [FieldOffset(0x23C0)] public BulletPatternSetParameter data__arr76;
        [FieldOffset(0x2438)] public BulletPatternSetParameter data__arr77;
        [FieldOffset(0x24B0)] public BulletPatternSetParameter data__arr78;
        [FieldOffset(0x2528)] public BulletPatternSetParameter data__arr79;
        [FieldOffset(0x25A0)] public BulletPatternSetParameter data__arr80;
        [FieldOffset(0x2618)] public BulletPatternSetParameter data__arr81;
        [FieldOffset(0x2690)] public BulletPatternSetParameter data__arr82;
        [FieldOffset(0x2708)] public BulletPatternSetParameter data__arr83;
        [FieldOffset(0x2780)] public BulletPatternSetParameter data__arr84;
        [FieldOffset(0x27F8)] public BulletPatternSetParameter data__arr85;
        [FieldOffset(0x2870)] public BulletPatternSetParameter data__arr86;
        [FieldOffset(0x28E8)] public BulletPatternSetParameter data__arr87;
        [FieldOffset(0x2960)] public BulletPatternSetParameter data__arr88;
        [FieldOffset(0x29D8)] public BulletPatternSetParameter data__arr89;
        [FieldOffset(0x2A50)] public BulletPatternSetParameter data__arr90;
        [FieldOffset(0x2AC8)] public BulletPatternSetParameter data__arr91;
        [FieldOffset(0x2B40)] public BulletPatternSetParameter data__arr92;
        [FieldOffset(0x2BB8)] public BulletPatternSetParameter data__arr93;
        [FieldOffset(0x2C30)] public BulletPatternSetParameter data__arr94;
        [FieldOffset(0x2CA8)] public BulletPatternSetParameter data__arr95;
        [FieldOffset(0x2D20)] public BulletPatternSetParameter data__arr96;
        [FieldOffset(0x2D98)] public BulletPatternSetParameter data__arr97;
        [FieldOffset(0x2E10)] public BulletPatternSetParameter data__arr98;
        [FieldOffset(0x2E88)] public BulletPatternSetParameter data__arr99;
        [FieldOffset(0x2F00)] public BulletPatternSetParameter data__arr100;
        [FieldOffset(0x2F78)] public BulletPatternSetParameter data__arr101;
        [FieldOffset(0x2FF0)] public BulletPatternSetParameter data__arr102;
        [FieldOffset(0x3068)] public BulletPatternSetParameter data__arr103;
        [FieldOffset(0x30E0)] public BulletPatternSetParameter data__arr104;
        [FieldOffset(0x3158)] public BulletPatternSetParameter data__arr105;
        [FieldOffset(0x31D0)] public BulletPatternSetParameter data__arr106;
        [FieldOffset(0x3248)] public BulletPatternSetParameter data__arr107;
        [FieldOffset(0x32C0)] public BulletPatternSetParameter data__arr108;
        [FieldOffset(0x3338)] public BulletPatternSetParameter data__arr109;
        [FieldOffset(0x33B0)] public BulletPatternSetParameter data__arr110;
        [FieldOffset(0x3428)] public BulletPatternSetParameter data__arr111;
        [FieldOffset(0x34A0)] public BulletPatternSetParameter data__arr112;
        [FieldOffset(0x3518)] public BulletPatternSetParameter data__arr113;
        [FieldOffset(0x3590)] public BulletPatternSetParameter data__arr114;
        [FieldOffset(0x3608)] public BulletPatternSetParameter data__arr115;
        [FieldOffset(0x3680)] public BulletPatternSetParameter data__arr116;
        [FieldOffset(0x36F8)] public BulletPatternSetParameter data__arr117;
        [FieldOffset(0x3770)] public BulletPatternSetParameter data__arr118;
        [FieldOffset(0x37E8)] public BulletPatternSetParameter data__arr119;
        [FieldOffset(0x3860)] public BulletPatternSetParameter data__arr120;
        [FieldOffset(0x38D8)] public BulletPatternSetParameter data__arr121;
        [FieldOffset(0x3950)] public BulletPatternSetParameter data__arr122;
        [FieldOffset(0x39C8)] public BulletPatternSetParameter data__arr123;
        [FieldOffset(0x3A40)] public BulletPatternSetParameter data__arr124;
        [FieldOffset(0x3AB8)] public BulletPatternSetParameter data__arr125;
        [FieldOffset(0x3B30)] public BulletPatternSetParameter data__arr126;
        [FieldOffset(0x3BA8)] public BulletPatternSetParameter data__arr127;
        [FieldOffset(0x3C20)] public BulletPatternSetParameter data__arr128;
        [FieldOffset(0x3C98)] public BulletPatternSetParameter data__arr129;
        [FieldOffset(0x3D10)] public BulletPatternSetParameter data__arr130;
        [FieldOffset(0x3D88)] public BulletPatternSetParameter data__arr131;
        [FieldOffset(0x3E00)] public BulletPatternSetParameter data__arr132;
        [FieldOffset(0x3E78)] public BulletPatternSetParameter data__arr133;
        [FieldOffset(0x3EF0)] public BulletPatternSetParameter data__arr134;
        [FieldOffset(0x3F68)] public BulletPatternSetParameter data__arr135;
        [FieldOffset(0x3FE0)] public BulletPatternSetParameter data__arr136;
        [FieldOffset(0x4058)] public BulletPatternSetParameter data__arr137;
        [FieldOffset(0x40D0)] public BulletPatternSetParameter data__arr138;
        [FieldOffset(0x4148)] public BulletPatternSetParameter data__arr139;
        [FieldOffset(0x41C0)] public BulletPatternSetParameter data__arr140;
        [FieldOffset(0x4238)] public BulletPatternSetParameter data__arr141;
        [FieldOffset(0x42B0)] public BulletPatternSetParameter data__arr142;
        [FieldOffset(0x4328)] public BulletPatternSetParameter data__arr143;
        [FieldOffset(0x43A0)] public BulletPatternSetParameter data__arr144;
        [FieldOffset(0x4418)] public BulletPatternSetParameter data__arr145;
        [FieldOffset(0x4490)] public BulletPatternSetParameter data__arr146;
        [FieldOffset(0x4508)] public BulletPatternSetParameter data__arr147;
        [FieldOffset(0x4580)] public BulletPatternSetParameter data__arr148;
        [FieldOffset(0x45F8)] public BulletPatternSetParameter data__arr149;
        [FieldOffset(0x4670)] public BulletPatternSetParameter data__arr150;
        [FieldOffset(0x46E8)] public BulletPatternSetParameter data__arr151;
        [FieldOffset(0x4760)] public BulletPatternSetParameter data__arr152;
        [FieldOffset(0x47D8)] public BulletPatternSetParameter data__arr153;
        [FieldOffset(0x4850)] public BulletPatternSetParameter data__arr154;
        [FieldOffset(0x48C8)] public BulletPatternSetParameter data__arr155;
        [FieldOffset(0x4940)] public BulletPatternSetParameter data__arr156;
        [FieldOffset(0x49B8)] public BulletPatternSetParameter data__arr157;
        [FieldOffset(0x4A30)] public BulletPatternSetParameter data__arr158;
        [FieldOffset(0x4AA8)] public BulletPatternSetParameter data__arr159;
        [FieldOffset(0x4B20)] public BulletPatternSetParameter data__arr160;
        [FieldOffset(0x4B98)] public BulletPatternSetParameter data__arr161;
        [FieldOffset(0x4C10)] public BulletPatternSetParameter data__arr162;
        [FieldOffset(0x4C88)] public BulletPatternSetParameter data__arr163;
        [FieldOffset(0x4D00)] public BulletPatternSetParameter data__arr164;
        [FieldOffset(0x4D78)] public BulletPatternSetParameter data__arr165;
        [FieldOffset(0x4DF0)] public BulletPatternSetParameter data__arr166;
        [FieldOffset(0x4E68)] public BulletPatternSetParameter data__arr167;
        [FieldOffset(0x4EE0)] public BulletPatternSetParameter data__arr168;
        [FieldOffset(0x4F58)] public BulletPatternSetParameter data__arr169;
        [FieldOffset(0x4FD0)] public BulletPatternSetParameter data__arr170;
        [FieldOffset(0x5048)] public BulletPatternSetParameter data__arr171;
        [FieldOffset(0x50C0)] public BulletPatternSetParameter data__arr172;
        [FieldOffset(0x5138)] public BulletPatternSetParameter data__arr173;
        [FieldOffset(0x51B0)] public BulletPatternSetParameter data__arr174;
        [FieldOffset(0x5228)] public BulletPatternSetParameter data__arr175;
        [FieldOffset(0x52A0)] public BulletPatternSetParameter data__arr176;
        [FieldOffset(0x5318)] public BulletPatternSetParameter data__arr177;
        [FieldOffset(0x5390)] public BulletPatternSetParameter data__arr178;
        [FieldOffset(0x5408)] public BulletPatternSetParameter data__arr179;
        [FieldOffset(0x5480)] public BulletPatternSetParameter data__arr180;
        [FieldOffset(0x54F8)] public BulletPatternSetParameter data__arr181;
        [FieldOffset(0x5570)] public BulletPatternSetParameter data__arr182;
        [FieldOffset(0x55E8)] public BulletPatternSetParameter data__arr183;
        [FieldOffset(0x5660)] public BulletPatternSetParameter data__arr184;
        [FieldOffset(0x56D8)] public BulletPatternSetParameter data__arr185;
        [FieldOffset(0x5750)] public BulletPatternSetParameter data__arr186;
        [FieldOffset(0x57C8)] public BulletPatternSetParameter data__arr187;
        [FieldOffset(0x5840)] public BulletPatternSetParameter data__arr188;
        [FieldOffset(0x58B8)] public BulletPatternSetParameter data__arr189;
        [FieldOffset(0x5930)] public BulletPatternSetParameter data__arr190;
        [FieldOffset(0x59A8)] public BulletPatternSetParameter data__arr191;
        [FieldOffset(0x5A20)] public BulletPatternSetParameter data__arr192;
        [FieldOffset(0x5A98)] public BulletPatternSetParameter data__arr193;
        [FieldOffset(0x5B10)] public BulletPatternSetParameter data__arr194;
        [FieldOffset(0x5B88)] public BulletPatternSetParameter data__arr195;
        [FieldOffset(0x5C00)] public BulletPatternSetParameter data__arr196;
        [FieldOffset(0x5C78)] public BulletPatternSetParameter data__arr197;
        [FieldOffset(0x5CF0)] public BulletPatternSetParameter data__arr198;
        [FieldOffset(0x5D68)] public BulletPatternSetParameter data__arr199;
        [FieldOffset(0x5DE0)] public BulletPatternSetParameter data__arr200;
        [FieldOffset(0x5E58)] public BulletPatternSetParameter data__arr201;
        [FieldOffset(0x5ED0)] public BulletPatternSetParameter data__arr202;
        [FieldOffset(0x5F48)] public BulletPatternSetParameter data__arr203;
        [FieldOffset(0x5FC0)] public BulletPatternSetParameter data__arr204;
        [FieldOffset(0x6038)] public BulletPatternSetParameter data__arr205;
        [FieldOffset(0x60B0)] public BulletPatternSetParameter data__arr206;
        [FieldOffset(0x6128)] public BulletPatternSetParameter data__arr207;
        [FieldOffset(0x61A0)] public BulletPatternSetParameter data__arr208;
        [FieldOffset(0x6218)] public BulletPatternSetParameter data__arr209;
        [FieldOffset(0x6290)] public BulletPatternSetParameter data__arr210;
        [FieldOffset(0x6308)] public BulletPatternSetParameter data__arr211;
        [FieldOffset(0x6380)] public BulletPatternSetParameter data__arr212;
        [FieldOffset(0x63F8)] public BulletPatternSetParameter data__arr213;
        [FieldOffset(0x6470)] public BulletPatternSetParameter data__arr214;
        [FieldOffset(0x64E8)] public BulletPatternSetParameter data__arr215;
        [FieldOffset(0x6560)] public BulletPatternSetParameter data__arr216;
        [FieldOffset(0x65D8)] public BulletPatternSetParameter data__arr217;
        [FieldOffset(0x6650)] public BulletPatternSetParameter data__arr218;
        [FieldOffset(0x66C8)] public BulletPatternSetParameter data__arr219;
        [FieldOffset(0x6740)] public BulletPatternSetParameter data__arr220;
        [FieldOffset(0x67B8)] public BulletPatternSetParameter data__arr221;
        [FieldOffset(0x6830)] public BulletPatternSetParameter data__arr222;
        [FieldOffset(0x68A8)] public BulletPatternSetParameter data__arr223;
        [FieldOffset(0x6920)] public BulletPatternSetParameter data__arr224;
        [FieldOffset(0x6998)] public BulletPatternSetParameter data__arr225;
        [FieldOffset(0x6A10)] public BulletPatternSetParameter data__arr226;
        [FieldOffset(0x6A88)] public BulletPatternSetParameter data__arr227;
        [FieldOffset(0x6B00)] public BulletPatternSetParameter data__arr228;
        [FieldOffset(0x6B78)] public BulletPatternSetParameter data__arr229;
        [FieldOffset(0x6BF0)] public BulletPatternSetParameter data__arr230;
        [FieldOffset(0x6C68)] public BulletPatternSetParameter data__arr231;
        [FieldOffset(0x6CE0)] public BulletPatternSetParameter data__arr232;
        [FieldOffset(0x6D58)] public BulletPatternSetParameter data__arr233;
        [FieldOffset(0x6DD0)] public BulletPatternSetParameter data__arr234;
        [FieldOffset(0x6E48)] public BulletPatternSetParameter data__arr235;
        [FieldOffset(0x6EC0)] public BulletPatternSetParameter data__arr236;
        [FieldOffset(0x6F38)] public BulletPatternSetParameter data__arr237;
        [FieldOffset(0x6FB0)] public BulletPatternSetParameter data__arr238;
        [FieldOffset(0x7028)] public BulletPatternSetParameter data__arr239;
        [FieldOffset(0x70A0)] public BulletPatternSetParameter data__arr240;
        [FieldOffset(0x7118)] public BulletPatternSetParameter data__arr241;
        [FieldOffset(0x7190)] public BulletPatternSetParameter data__arr242;
        [FieldOffset(0x7208)] public BulletPatternSetParameter data__arr243;
        [FieldOffset(0x7280)] public BulletPatternSetParameter data__arr244;
        [FieldOffset(0x72F8)] public BulletPatternSetParameter data__arr245;
        [FieldOffset(0x7370)] public BulletPatternSetParameter data__arr246;
        [FieldOffset(0x73E8)] public BulletPatternSetParameter data__arr247;
        [FieldOffset(0x7460)] public BulletPatternSetParameter data__arr248;
        [FieldOffset(0x74D8)] public BulletPatternSetParameter data__arr249;
        [FieldOffset(0x7550)] public BulletPatternSetParameter data__arr250;
        [FieldOffset(0x75C8)] public BulletPatternSetParameter data__arr251;
        [FieldOffset(0x7640)] public BulletPatternSetParameter data__arr252;
        [FieldOffset(0x76B8)] public BulletPatternSetParameter data__arr253;
        [FieldOffset(0x7730)] public BulletPatternSetParameter data__arr254;
        [FieldOffset(0x77A8)] public BulletPatternSetParameter data__arr255;
    }

}