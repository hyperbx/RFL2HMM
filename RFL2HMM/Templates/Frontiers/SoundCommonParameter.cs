using System.Numerics;
using System.Runtime.InteropServices;

public class SoundCommonParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct BGMVolumeChangeInfo
    {
        [FieldOffset(0x00)] public float value;
        [FieldOffset(0x04)] public float delayTime;
        [FieldOffset(0x08)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x54)]
    public struct BGMVolumeChangeInfoList
    {
        [FieldOffset(0x00)] public BGMVolumeChangeInfo playerStop;
        [FieldOffset(0x0C)] public BGMVolumeChangeInfo playerWalk;
        [FieldOffset(0x18)] public BGMVolumeChangeInfo playerRun;
        [FieldOffset(0x24)] public BGMVolumeChangeInfo fishingHitIn;
        [FieldOffset(0x30)] public BGMVolumeChangeInfo fishingHitOut;
        [FieldOffset(0x3C)] public BGMVolumeChangeInfo musicBoxIn;
        [FieldOffset(0x48)] public BGMVolumeChangeInfo musicBoxOut;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct AisacChangeInfo
    {
        [FieldOffset(0x00)] public float value;
        [FieldOffset(0x04)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct AisacChangeInfoList
    {
        [FieldOffset(0x00)] public AisacChangeInfo sunny;
        [FieldOffset(0x08)] public AisacChangeInfo cloudy;
        [FieldOffset(0x10)] public AisacChangeInfo rainy;
        [FieldOffset(0x18)] public AisacChangeInfo beginUnderWater;
        [FieldOffset(0x20)] public AisacChangeInfo finishUnderWater;
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

            set => pValue = Marshal.StringToHGlobalAnsi(value);
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

    public enum Priority : sbyte
    {
        PRIORITY_LOW = 0,
        PRIORITY_DEFAULT = 1,
        PRIORITY_HIGH = 2,
        PRIORITY_SUPER_HIGH = 3,
        NUM_PRIORITY = 4,
        PRIORITY_INVALID = -1
    }

    public enum InterruptType : sbyte
    {
        INTERRUPT_TYPE_STOP = 0,
        INTERRUPT_TYPE_PAUSE = 1,
        INTERRUPT_TYPE_OVERLAP = 2,
        NUM_INTERRUPT_TYPE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BGMInfo
    {
        [FieldOffset(0x00)] public UnmanagedString cueName;
        [FieldOffset(0x10)] public int blockId;
        [FieldOffset(0x14)] public float fadeInTime;
        [FieldOffset(0x18)] public float fadeOutTime;
        [FieldOffset(0x1C)] public float delayTime;
        [FieldOffset(0x20)] public UnmanagedString aisacName;
        [FieldOffset(0x30)] public float aisacValue;
        [FieldOffset(0x34)] public float aisacFadeTime;
        [FieldOffset(0x38)] public bool isVolumeControl;
        [FieldOffset(0x39)] public bool isOverlapPlay;
        [FieldOffset(0x3A)] public Priority priority;
        [FieldOffset(0x3B)] public InterruptType interruptType;
    }

    public enum BGMTransitInfo_InterruptType : sbyte
    {
        BGMTransitInfo_InterruptType_INTERRUPT_TYPE_STOP = 0,
        BGMTransitInfo_InterruptType_INTERRUPT_TYPE_PAUSE = 1,
        BGMTransitInfo_InterruptType_INTERRUPT_TYPE_OVERLAP = 2,
        BGMTransitInfo_InterruptType_NUM_INTERRUPT_TYPE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BGMTransitInfo
    {
        [FieldOffset(0x00)] public UnmanagedString tagName;
        [FieldOffset(0x10)] public int beforeId;
        [FieldOffset(0x14)] public int beforeIdMax;
        [FieldOffset(0x18)] public int afterId;
        [FieldOffset(0x1C)] public BGMTransitInfo_InterruptType type;
        [FieldOffset(0x20)] public float fadeOutTime;
        [FieldOffset(0x24)] public float fadeInTime;
        [FieldOffset(0x28)] public float delayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3890)]
    public struct SoundCommonParameter
    {
        [FieldOffset(0x00)] public float pauseFadeOutTime;
        [FieldOffset(0x04)] public float pauseFadeInTime;
        [FieldOffset(0x08)] public float enterCyberFadeOutTime;
        [FieldOffset(0x0C)] public float leaveCyberResultFadeOutTime;
        [FieldOffset(0x10)] public BGMVolumeChangeInfoList bgmVolumeInfo;
        [FieldOffset(0x64)] public AisacChangeInfoList aisacInfo;
        [FieldOffset(0x90)] public BGMInfo changeBgmInfo__arr0;
        [FieldOffset(0xD0)] public BGMInfo changeBgmInfo__arr1;
        [FieldOffset(0x110)] public BGMInfo changeBgmInfo__arr2;
        [FieldOffset(0x150)] public BGMInfo changeBgmInfo__arr3;
        [FieldOffset(0x190)] public BGMInfo changeBgmInfo__arr4;
        [FieldOffset(0x1D0)] public BGMInfo changeBgmInfo__arr5;
        [FieldOffset(0x210)] public BGMInfo changeBgmInfo__arr6;
        [FieldOffset(0x250)] public BGMInfo changeBgmInfo__arr7;
        [FieldOffset(0x290)] public BGMInfo changeBgmInfo__arr8;
        [FieldOffset(0x2D0)] public BGMInfo changeBgmInfo__arr9;
        [FieldOffset(0x310)] public BGMInfo changeBgmInfo__arr10;
        [FieldOffset(0x350)] public BGMInfo changeBgmInfo__arr11;
        [FieldOffset(0x390)] public BGMInfo changeBgmInfo__arr12;
        [FieldOffset(0x3D0)] public BGMInfo changeBgmInfo__arr13;
        [FieldOffset(0x410)] public BGMInfo changeBgmInfo__arr14;
        [FieldOffset(0x450)] public BGMInfo changeBgmInfo__arr15;
        [FieldOffset(0x490)] public BGMInfo changeBgmInfo__arr16;
        [FieldOffset(0x4D0)] public BGMInfo changeBgmInfo__arr17;
        [FieldOffset(0x510)] public BGMInfo changeBgmInfo__arr18;
        [FieldOffset(0x550)] public BGMInfo changeBgmInfo__arr19;
        [FieldOffset(0x590)] public BGMInfo changeBgmInfo__arr20;
        [FieldOffset(0x5D0)] public BGMInfo changeBgmInfo__arr21;
        [FieldOffset(0x610)] public BGMInfo changeBgmInfo__arr22;
        [FieldOffset(0x650)] public BGMInfo changeBgmInfo__arr23;
        [FieldOffset(0x690)] public BGMInfo changeBgmInfo__arr24;
        [FieldOffset(0x6D0)] public BGMInfo changeBgmInfo__arr25;
        [FieldOffset(0x710)] public BGMInfo changeBgmInfo__arr26;
        [FieldOffset(0x750)] public BGMInfo changeBgmInfo__arr27;
        [FieldOffset(0x790)] public BGMInfo changeBgmInfo__arr28;
        [FieldOffset(0x7D0)] public BGMInfo changeBgmInfo__arr29;
        [FieldOffset(0x810)] public BGMInfo changeBgmInfo__arr30;
        [FieldOffset(0x850)] public BGMInfo changeBgmInfo__arr31;
        [FieldOffset(0x890)] public BGMInfo changeBgmInfo__arr32;
        [FieldOffset(0x8D0)] public BGMInfo changeBgmInfo__arr33;
        [FieldOffset(0x910)] public BGMInfo changeBgmInfo__arr34;
        [FieldOffset(0x950)] public BGMInfo changeBgmInfo__arr35;
        [FieldOffset(0x990)] public BGMInfo changeBgmInfo__arr36;
        [FieldOffset(0x9D0)] public BGMInfo changeBgmInfo__arr37;
        [FieldOffset(0xA10)] public BGMInfo changeBgmInfo__arr38;
        [FieldOffset(0xA50)] public BGMInfo changeBgmInfo__arr39;
        [FieldOffset(0xA90)] public BGMInfo changeBgmInfo__arr40;
        [FieldOffset(0xAD0)] public BGMInfo changeBgmInfo__arr41;
        [FieldOffset(0xB10)] public BGMInfo changeBgmInfo__arr42;
        [FieldOffset(0xB50)] public BGMInfo changeBgmInfo__arr43;
        [FieldOffset(0xB90)] public BGMInfo changeBgmInfo__arr44;
        [FieldOffset(0xBD0)] public BGMInfo changeBgmInfo__arr45;
        [FieldOffset(0xC10)] public BGMInfo changeBgmInfo__arr46;
        [FieldOffset(0xC50)] public BGMInfo changeBgmInfo__arr47;
        [FieldOffset(0xC90)] public BGMInfo changeBgmInfo__arr48;
        [FieldOffset(0xCD0)] public BGMInfo changeBgmInfo__arr49;
        [FieldOffset(0xD10)] public BGMInfo changeBgmInfo__arr50;
        [FieldOffset(0xD50)] public BGMInfo changeBgmInfo__arr51;
        [FieldOffset(0xD90)] public BGMInfo changeBgmInfo__arr52;
        [FieldOffset(0xDD0)] public BGMInfo changeBgmInfo__arr53;
        [FieldOffset(0xE10)] public BGMInfo changeBgmInfo__arr54;
        [FieldOffset(0xE50)] public BGMInfo changeBgmInfo__arr55;
        [FieldOffset(0xE90)] public BGMInfo changeBgmInfo__arr56;
        [FieldOffset(0xED0)] public BGMInfo changeBgmInfo__arr57;
        [FieldOffset(0xF10)] public BGMInfo changeBgmInfo__arr58;
        [FieldOffset(0xF50)] public BGMInfo changeBgmInfo__arr59;
        [FieldOffset(0xF90)] public BGMInfo changeBgmInfo__arr60;
        [FieldOffset(0xFD0)] public BGMInfo changeBgmInfo__arr61;
        [FieldOffset(0x1010)] public BGMInfo changeBgmInfo__arr62;
        [FieldOffset(0x1050)] public BGMInfo changeBgmInfo__arr63;
        [FieldOffset(0x1090)] public BGMInfo changeBgmInfo__arr64;
        [FieldOffset(0x10D0)] public BGMInfo changeBgmInfo__arr65;
        [FieldOffset(0x1110)] public BGMInfo changeBgmInfo__arr66;
        [FieldOffset(0x1150)] public BGMInfo changeBgmInfo__arr67;
        [FieldOffset(0x1190)] public BGMInfo changeBgmInfo__arr68;
        [FieldOffset(0x11D0)] public BGMInfo changeBgmInfo__arr69;
        [FieldOffset(0x1210)] public BGMInfo changeBgmInfo__arr70;
        [FieldOffset(0x1250)] public BGMInfo changeBgmInfo__arr71;
        [FieldOffset(0x1290)] public BGMInfo changeBgmInfo__arr72;
        [FieldOffset(0x12D0)] public BGMInfo changeBgmInfo__arr73;
        [FieldOffset(0x1310)] public BGMInfo changeBgmInfo__arr74;
        [FieldOffset(0x1350)] public BGMInfo changeBgmInfo__arr75;
        [FieldOffset(0x1390)] public BGMInfo changeBgmInfo__arr76;
        [FieldOffset(0x13D0)] public BGMInfo changeBgmInfo__arr77;
        [FieldOffset(0x1410)] public BGMInfo changeBgmInfo__arr78;
        [FieldOffset(0x1450)] public BGMInfo changeBgmInfo__arr79;
        [FieldOffset(0x1490)] public BGMInfo changeBgmInfo__arr80;
        [FieldOffset(0x14D0)] public BGMInfo changeBgmInfo__arr81;
        [FieldOffset(0x1510)] public BGMInfo changeBgmInfo__arr82;
        [FieldOffset(0x1550)] public BGMInfo changeBgmInfo__arr83;
        [FieldOffset(0x1590)] public BGMInfo changeBgmInfo__arr84;
        [FieldOffset(0x15D0)] public BGMInfo changeBgmInfo__arr85;
        [FieldOffset(0x1610)] public BGMInfo changeBgmInfo__arr86;
        [FieldOffset(0x1650)] public BGMInfo changeBgmInfo__arr87;
        [FieldOffset(0x1690)] public BGMInfo changeBgmInfo__arr88;
        [FieldOffset(0x16D0)] public BGMInfo changeBgmInfo__arr89;
        [FieldOffset(0x1710)] public BGMInfo changeBgmInfo__arr90;
        [FieldOffset(0x1750)] public BGMInfo changeBgmInfo__arr91;
        [FieldOffset(0x1790)] public BGMInfo changeBgmInfo__arr92;
        [FieldOffset(0x17D0)] public BGMInfo changeBgmInfo__arr93;
        [FieldOffset(0x1810)] public BGMInfo changeBgmInfo__arr94;
        [FieldOffset(0x1850)] public BGMInfo changeBgmInfo__arr95;
        [FieldOffset(0x1890)] public BGMInfo changeBgmInfo__arr96;
        [FieldOffset(0x18D0)] public BGMInfo changeBgmInfo__arr97;
        [FieldOffset(0x1910)] public BGMInfo changeBgmInfo__arr98;
        [FieldOffset(0x1950)] public BGMInfo changeBgmInfo__arr99;
        [FieldOffset(0x1990)] public BGMInfo changeBgmInfo__arr100;
        [FieldOffset(0x19D0)] public BGMInfo changeBgmInfo__arr101;
        [FieldOffset(0x1A10)] public BGMInfo changeBgmInfo__arr102;
        [FieldOffset(0x1A50)] public BGMInfo changeBgmInfo__arr103;
        [FieldOffset(0x1A90)] public BGMInfo changeBgmInfo__arr104;
        [FieldOffset(0x1AD0)] public BGMInfo changeBgmInfo__arr105;
        [FieldOffset(0x1B10)] public BGMInfo changeBgmInfo__arr106;
        [FieldOffset(0x1B50)] public BGMInfo changeBgmInfo__arr107;
        [FieldOffset(0x1B90)] public BGMInfo changeBgmInfo__arr108;
        [FieldOffset(0x1BD0)] public BGMInfo changeBgmInfo__arr109;
        [FieldOffset(0x1C10)] public BGMInfo changeBgmInfo__arr110;
        [FieldOffset(0x1C50)] public BGMInfo changeBgmInfo__arr111;
        [FieldOffset(0x1C90)] public BGMInfo changeBgmInfo__arr112;
        [FieldOffset(0x1CD0)] public BGMInfo changeBgmInfo__arr113;
        [FieldOffset(0x1D10)] public BGMInfo changeBgmInfo__arr114;
        [FieldOffset(0x1D50)] public BGMInfo changeBgmInfo__arr115;
        [FieldOffset(0x1D90)] public BGMInfo changeBgmInfo__arr116;
        [FieldOffset(0x1DD0)] public BGMInfo changeBgmInfo__arr117;
        [FieldOffset(0x1E10)] public BGMInfo changeBgmInfo__arr118;
        [FieldOffset(0x1E50)] public BGMInfo changeBgmInfo__arr119;
        [FieldOffset(0x1E90)] public BGMInfo changeBgmInfo__arr120;
        [FieldOffset(0x1ED0)] public BGMInfo changeBgmInfo__arr121;
        [FieldOffset(0x1F10)] public BGMInfo changeBgmInfo__arr122;
        [FieldOffset(0x1F50)] public BGMInfo changeBgmInfo__arr123;
        [FieldOffset(0x1F90)] public BGMInfo changeBgmInfo__arr124;
        [FieldOffset(0x1FD0)] public BGMInfo changeBgmInfo__arr125;
        [FieldOffset(0x2010)] public BGMInfo changeBgmInfo__arr126;
        [FieldOffset(0x2050)] public BGMInfo changeBgmInfo__arr127;
        [FieldOffset(0x2090)] public BGMTransitInfo transitBgmInfo__arr0;
        [FieldOffset(0x20C0)] public BGMTransitInfo transitBgmInfo__arr1;
        [FieldOffset(0x20F0)] public BGMTransitInfo transitBgmInfo__arr2;
        [FieldOffset(0x2120)] public BGMTransitInfo transitBgmInfo__arr3;
        [FieldOffset(0x2150)] public BGMTransitInfo transitBgmInfo__arr4;
        [FieldOffset(0x2180)] public BGMTransitInfo transitBgmInfo__arr5;
        [FieldOffset(0x21B0)] public BGMTransitInfo transitBgmInfo__arr6;
        [FieldOffset(0x21E0)] public BGMTransitInfo transitBgmInfo__arr7;
        [FieldOffset(0x2210)] public BGMTransitInfo transitBgmInfo__arr8;
        [FieldOffset(0x2240)] public BGMTransitInfo transitBgmInfo__arr9;
        [FieldOffset(0x2270)] public BGMTransitInfo transitBgmInfo__arr10;
        [FieldOffset(0x22A0)] public BGMTransitInfo transitBgmInfo__arr11;
        [FieldOffset(0x22D0)] public BGMTransitInfo transitBgmInfo__arr12;
        [FieldOffset(0x2300)] public BGMTransitInfo transitBgmInfo__arr13;
        [FieldOffset(0x2330)] public BGMTransitInfo transitBgmInfo__arr14;
        [FieldOffset(0x2360)] public BGMTransitInfo transitBgmInfo__arr15;
        [FieldOffset(0x2390)] public BGMTransitInfo transitBgmInfo__arr16;
        [FieldOffset(0x23C0)] public BGMTransitInfo transitBgmInfo__arr17;
        [FieldOffset(0x23F0)] public BGMTransitInfo transitBgmInfo__arr18;
        [FieldOffset(0x2420)] public BGMTransitInfo transitBgmInfo__arr19;
        [FieldOffset(0x2450)] public BGMTransitInfo transitBgmInfo__arr20;
        [FieldOffset(0x2480)] public BGMTransitInfo transitBgmInfo__arr21;
        [FieldOffset(0x24B0)] public BGMTransitInfo transitBgmInfo__arr22;
        [FieldOffset(0x24E0)] public BGMTransitInfo transitBgmInfo__arr23;
        [FieldOffset(0x2510)] public BGMTransitInfo transitBgmInfo__arr24;
        [FieldOffset(0x2540)] public BGMTransitInfo transitBgmInfo__arr25;
        [FieldOffset(0x2570)] public BGMTransitInfo transitBgmInfo__arr26;
        [FieldOffset(0x25A0)] public BGMTransitInfo transitBgmInfo__arr27;
        [FieldOffset(0x25D0)] public BGMTransitInfo transitBgmInfo__arr28;
        [FieldOffset(0x2600)] public BGMTransitInfo transitBgmInfo__arr29;
        [FieldOffset(0x2630)] public BGMTransitInfo transitBgmInfo__arr30;
        [FieldOffset(0x2660)] public BGMTransitInfo transitBgmInfo__arr31;
        [FieldOffset(0x2690)] public BGMTransitInfo transitBgmInfo__arr32;
        [FieldOffset(0x26C0)] public BGMTransitInfo transitBgmInfo__arr33;
        [FieldOffset(0x26F0)] public BGMTransitInfo transitBgmInfo__arr34;
        [FieldOffset(0x2720)] public BGMTransitInfo transitBgmInfo__arr35;
        [FieldOffset(0x2750)] public BGMTransitInfo transitBgmInfo__arr36;
        [FieldOffset(0x2780)] public BGMTransitInfo transitBgmInfo__arr37;
        [FieldOffset(0x27B0)] public BGMTransitInfo transitBgmInfo__arr38;
        [FieldOffset(0x27E0)] public BGMTransitInfo transitBgmInfo__arr39;
        [FieldOffset(0x2810)] public BGMTransitInfo transitBgmInfo__arr40;
        [FieldOffset(0x2840)] public BGMTransitInfo transitBgmInfo__arr41;
        [FieldOffset(0x2870)] public BGMTransitInfo transitBgmInfo__arr42;
        [FieldOffset(0x28A0)] public BGMTransitInfo transitBgmInfo__arr43;
        [FieldOffset(0x28D0)] public BGMTransitInfo transitBgmInfo__arr44;
        [FieldOffset(0x2900)] public BGMTransitInfo transitBgmInfo__arr45;
        [FieldOffset(0x2930)] public BGMTransitInfo transitBgmInfo__arr46;
        [FieldOffset(0x2960)] public BGMTransitInfo transitBgmInfo__arr47;
        [FieldOffset(0x2990)] public BGMTransitInfo transitBgmInfo__arr48;
        [FieldOffset(0x29C0)] public BGMTransitInfo transitBgmInfo__arr49;
        [FieldOffset(0x29F0)] public BGMTransitInfo transitBgmInfo__arr50;
        [FieldOffset(0x2A20)] public BGMTransitInfo transitBgmInfo__arr51;
        [FieldOffset(0x2A50)] public BGMTransitInfo transitBgmInfo__arr52;
        [FieldOffset(0x2A80)] public BGMTransitInfo transitBgmInfo__arr53;
        [FieldOffset(0x2AB0)] public BGMTransitInfo transitBgmInfo__arr54;
        [FieldOffset(0x2AE0)] public BGMTransitInfo transitBgmInfo__arr55;
        [FieldOffset(0x2B10)] public BGMTransitInfo transitBgmInfo__arr56;
        [FieldOffset(0x2B40)] public BGMTransitInfo transitBgmInfo__arr57;
        [FieldOffset(0x2B70)] public BGMTransitInfo transitBgmInfo__arr58;
        [FieldOffset(0x2BA0)] public BGMTransitInfo transitBgmInfo__arr59;
        [FieldOffset(0x2BD0)] public BGMTransitInfo transitBgmInfo__arr60;
        [FieldOffset(0x2C00)] public BGMTransitInfo transitBgmInfo__arr61;
        [FieldOffset(0x2C30)] public BGMTransitInfo transitBgmInfo__arr62;
        [FieldOffset(0x2C60)] public BGMTransitInfo transitBgmInfo__arr63;
        [FieldOffset(0x2C90)] public BGMTransitInfo transitBgmInfo__arr64;
        [FieldOffset(0x2CC0)] public BGMTransitInfo transitBgmInfo__arr65;
        [FieldOffset(0x2CF0)] public BGMTransitInfo transitBgmInfo__arr66;
        [FieldOffset(0x2D20)] public BGMTransitInfo transitBgmInfo__arr67;
        [FieldOffset(0x2D50)] public BGMTransitInfo transitBgmInfo__arr68;
        [FieldOffset(0x2D80)] public BGMTransitInfo transitBgmInfo__arr69;
        [FieldOffset(0x2DB0)] public BGMTransitInfo transitBgmInfo__arr70;
        [FieldOffset(0x2DE0)] public BGMTransitInfo transitBgmInfo__arr71;
        [FieldOffset(0x2E10)] public BGMTransitInfo transitBgmInfo__arr72;
        [FieldOffset(0x2E40)] public BGMTransitInfo transitBgmInfo__arr73;
        [FieldOffset(0x2E70)] public BGMTransitInfo transitBgmInfo__arr74;
        [FieldOffset(0x2EA0)] public BGMTransitInfo transitBgmInfo__arr75;
        [FieldOffset(0x2ED0)] public BGMTransitInfo transitBgmInfo__arr76;
        [FieldOffset(0x2F00)] public BGMTransitInfo transitBgmInfo__arr77;
        [FieldOffset(0x2F30)] public BGMTransitInfo transitBgmInfo__arr78;
        [FieldOffset(0x2F60)] public BGMTransitInfo transitBgmInfo__arr79;
        [FieldOffset(0x2F90)] public BGMTransitInfo transitBgmInfo__arr80;
        [FieldOffset(0x2FC0)] public BGMTransitInfo transitBgmInfo__arr81;
        [FieldOffset(0x2FF0)] public BGMTransitInfo transitBgmInfo__arr82;
        [FieldOffset(0x3020)] public BGMTransitInfo transitBgmInfo__arr83;
        [FieldOffset(0x3050)] public BGMTransitInfo transitBgmInfo__arr84;
        [FieldOffset(0x3080)] public BGMTransitInfo transitBgmInfo__arr85;
        [FieldOffset(0x30B0)] public BGMTransitInfo transitBgmInfo__arr86;
        [FieldOffset(0x30E0)] public BGMTransitInfo transitBgmInfo__arr87;
        [FieldOffset(0x3110)] public BGMTransitInfo transitBgmInfo__arr88;
        [FieldOffset(0x3140)] public BGMTransitInfo transitBgmInfo__arr89;
        [FieldOffset(0x3170)] public BGMTransitInfo transitBgmInfo__arr90;
        [FieldOffset(0x31A0)] public BGMTransitInfo transitBgmInfo__arr91;
        [FieldOffset(0x31D0)] public BGMTransitInfo transitBgmInfo__arr92;
        [FieldOffset(0x3200)] public BGMTransitInfo transitBgmInfo__arr93;
        [FieldOffset(0x3230)] public BGMTransitInfo transitBgmInfo__arr94;
        [FieldOffset(0x3260)] public BGMTransitInfo transitBgmInfo__arr95;
        [FieldOffset(0x3290)] public BGMTransitInfo transitBgmInfo__arr96;
        [FieldOffset(0x32C0)] public BGMTransitInfo transitBgmInfo__arr97;
        [FieldOffset(0x32F0)] public BGMTransitInfo transitBgmInfo__arr98;
        [FieldOffset(0x3320)] public BGMTransitInfo transitBgmInfo__arr99;
        [FieldOffset(0x3350)] public BGMTransitInfo transitBgmInfo__arr100;
        [FieldOffset(0x3380)] public BGMTransitInfo transitBgmInfo__arr101;
        [FieldOffset(0x33B0)] public BGMTransitInfo transitBgmInfo__arr102;
        [FieldOffset(0x33E0)] public BGMTransitInfo transitBgmInfo__arr103;
        [FieldOffset(0x3410)] public BGMTransitInfo transitBgmInfo__arr104;
        [FieldOffset(0x3440)] public BGMTransitInfo transitBgmInfo__arr105;
        [FieldOffset(0x3470)] public BGMTransitInfo transitBgmInfo__arr106;
        [FieldOffset(0x34A0)] public BGMTransitInfo transitBgmInfo__arr107;
        [FieldOffset(0x34D0)] public BGMTransitInfo transitBgmInfo__arr108;
        [FieldOffset(0x3500)] public BGMTransitInfo transitBgmInfo__arr109;
        [FieldOffset(0x3530)] public BGMTransitInfo transitBgmInfo__arr110;
        [FieldOffset(0x3560)] public BGMTransitInfo transitBgmInfo__arr111;
        [FieldOffset(0x3590)] public BGMTransitInfo transitBgmInfo__arr112;
        [FieldOffset(0x35C0)] public BGMTransitInfo transitBgmInfo__arr113;
        [FieldOffset(0x35F0)] public BGMTransitInfo transitBgmInfo__arr114;
        [FieldOffset(0x3620)] public BGMTransitInfo transitBgmInfo__arr115;
        [FieldOffset(0x3650)] public BGMTransitInfo transitBgmInfo__arr116;
        [FieldOffset(0x3680)] public BGMTransitInfo transitBgmInfo__arr117;
        [FieldOffset(0x36B0)] public BGMTransitInfo transitBgmInfo__arr118;
        [FieldOffset(0x36E0)] public BGMTransitInfo transitBgmInfo__arr119;
        [FieldOffset(0x3710)] public BGMTransitInfo transitBgmInfo__arr120;
        [FieldOffset(0x3740)] public BGMTransitInfo transitBgmInfo__arr121;
        [FieldOffset(0x3770)] public BGMTransitInfo transitBgmInfo__arr122;
        [FieldOffset(0x37A0)] public BGMTransitInfo transitBgmInfo__arr123;
        [FieldOffset(0x37D0)] public BGMTransitInfo transitBgmInfo__arr124;
        [FieldOffset(0x3800)] public BGMTransitInfo transitBgmInfo__arr125;
        [FieldOffset(0x3830)] public BGMTransitInfo transitBgmInfo__arr126;
        [FieldOffset(0x3860)] public BGMTransitInfo transitBgmInfo__arr127;
    }

}