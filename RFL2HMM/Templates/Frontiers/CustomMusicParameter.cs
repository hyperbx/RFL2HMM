using System.Numerics;
using System.Runtime.InteropServices;

public class CustomMusicParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct CustomMusicTransitInfo
    {
        [FieldOffset(0x00)] public float fadeOutTime;
        [FieldOffset(0x04)] public float delayTime;
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

    public enum MusicType : sbyte
    {
        THEME_SONG = 0,
        OTHER = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct CustomMusicInfo
    {
        [FieldOffset(0x00)] public UnmanagedString cueName;
        [FieldOffset(0x10)] public float fadeOutTiming;
        [FieldOffset(0x14)] public bool _lock;
        [FieldOffset(0x15)] public MusicType musicType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC10)]
    public struct CustomMusicParameter
    {
        [FieldOffset(0x00)] public CustomMusicTransitInfo transitInfo;
        [FieldOffset(0x08)] public CustomMusicInfo musicInfos__arr0;
        [FieldOffset(0x20)] public CustomMusicInfo musicInfos__arr1;
        [FieldOffset(0x38)] public CustomMusicInfo musicInfos__arr2;
        [FieldOffset(0x50)] public CustomMusicInfo musicInfos__arr3;
        [FieldOffset(0x68)] public CustomMusicInfo musicInfos__arr4;
        [FieldOffset(0x80)] public CustomMusicInfo musicInfos__arr5;
        [FieldOffset(0x98)] public CustomMusicInfo musicInfos__arr6;
        [FieldOffset(0xB0)] public CustomMusicInfo musicInfos__arr7;
        [FieldOffset(0xC8)] public CustomMusicInfo musicInfos__arr8;
        [FieldOffset(0xE0)] public CustomMusicInfo musicInfos__arr9;
        [FieldOffset(0xF8)] public CustomMusicInfo musicInfos__arr10;
        [FieldOffset(0x110)] public CustomMusicInfo musicInfos__arr11;
        [FieldOffset(0x128)] public CustomMusicInfo musicInfos__arr12;
        [FieldOffset(0x140)] public CustomMusicInfo musicInfos__arr13;
        [FieldOffset(0x158)] public CustomMusicInfo musicInfos__arr14;
        [FieldOffset(0x170)] public CustomMusicInfo musicInfos__arr15;
        [FieldOffset(0x188)] public CustomMusicInfo musicInfos__arr16;
        [FieldOffset(0x1A0)] public CustomMusicInfo musicInfos__arr17;
        [FieldOffset(0x1B8)] public CustomMusicInfo musicInfos__arr18;
        [FieldOffset(0x1D0)] public CustomMusicInfo musicInfos__arr19;
        [FieldOffset(0x1E8)] public CustomMusicInfo musicInfos__arr20;
        [FieldOffset(0x200)] public CustomMusicInfo musicInfos__arr21;
        [FieldOffset(0x218)] public CustomMusicInfo musicInfos__arr22;
        [FieldOffset(0x230)] public CustomMusicInfo musicInfos__arr23;
        [FieldOffset(0x248)] public CustomMusicInfo musicInfos__arr24;
        [FieldOffset(0x260)] public CustomMusicInfo musicInfos__arr25;
        [FieldOffset(0x278)] public CustomMusicInfo musicInfos__arr26;
        [FieldOffset(0x290)] public CustomMusicInfo musicInfos__arr27;
        [FieldOffset(0x2A8)] public CustomMusicInfo musicInfos__arr28;
        [FieldOffset(0x2C0)] public CustomMusicInfo musicInfos__arr29;
        [FieldOffset(0x2D8)] public CustomMusicInfo musicInfos__arr30;
        [FieldOffset(0x2F0)] public CustomMusicInfo musicInfos__arr31;
        [FieldOffset(0x308)] public CustomMusicInfo musicInfos__arr32;
        [FieldOffset(0x320)] public CustomMusicInfo musicInfos__arr33;
        [FieldOffset(0x338)] public CustomMusicInfo musicInfos__arr34;
        [FieldOffset(0x350)] public CustomMusicInfo musicInfos__arr35;
        [FieldOffset(0x368)] public CustomMusicInfo musicInfos__arr36;
        [FieldOffset(0x380)] public CustomMusicInfo musicInfos__arr37;
        [FieldOffset(0x398)] public CustomMusicInfo musicInfos__arr38;
        [FieldOffset(0x3B0)] public CustomMusicInfo musicInfos__arr39;
        [FieldOffset(0x3C8)] public CustomMusicInfo musicInfos__arr40;
        [FieldOffset(0x3E0)] public CustomMusicInfo musicInfos__arr41;
        [FieldOffset(0x3F8)] public CustomMusicInfo musicInfos__arr42;
        [FieldOffset(0x410)] public CustomMusicInfo musicInfos__arr43;
        [FieldOffset(0x428)] public CustomMusicInfo musicInfos__arr44;
        [FieldOffset(0x440)] public CustomMusicInfo musicInfos__arr45;
        [FieldOffset(0x458)] public CustomMusicInfo musicInfos__arr46;
        [FieldOffset(0x470)] public CustomMusicInfo musicInfos__arr47;
        [FieldOffset(0x488)] public CustomMusicInfo musicInfos__arr48;
        [FieldOffset(0x4A0)] public CustomMusicInfo musicInfos__arr49;
        [FieldOffset(0x4B8)] public CustomMusicInfo musicInfos__arr50;
        [FieldOffset(0x4D0)] public CustomMusicInfo musicInfos__arr51;
        [FieldOffset(0x4E8)] public CustomMusicInfo musicInfos__arr52;
        [FieldOffset(0x500)] public CustomMusicInfo musicInfos__arr53;
        [FieldOffset(0x518)] public CustomMusicInfo musicInfos__arr54;
        [FieldOffset(0x530)] public CustomMusicInfo musicInfos__arr55;
        [FieldOffset(0x548)] public CustomMusicInfo musicInfos__arr56;
        [FieldOffset(0x560)] public CustomMusicInfo musicInfos__arr57;
        [FieldOffset(0x578)] public CustomMusicInfo musicInfos__arr58;
        [FieldOffset(0x590)] public CustomMusicInfo musicInfos__arr59;
        [FieldOffset(0x5A8)] public CustomMusicInfo musicInfos__arr60;
        [FieldOffset(0x5C0)] public CustomMusicInfo musicInfos__arr61;
        [FieldOffset(0x5D8)] public CustomMusicInfo musicInfos__arr62;
        [FieldOffset(0x5F0)] public CustomMusicInfo musicInfos__arr63;
        [FieldOffset(0x608)] public CustomMusicInfo musicInfos__arr64;
        [FieldOffset(0x620)] public CustomMusicInfo musicInfos__arr65;
        [FieldOffset(0x638)] public CustomMusicInfo musicInfos__arr66;
        [FieldOffset(0x650)] public CustomMusicInfo musicInfos__arr67;
        [FieldOffset(0x668)] public CustomMusicInfo musicInfos__arr68;
        [FieldOffset(0x680)] public CustomMusicInfo musicInfos__arr69;
        [FieldOffset(0x698)] public CustomMusicInfo musicInfos__arr70;
        [FieldOffset(0x6B0)] public CustomMusicInfo musicInfos__arr71;
        [FieldOffset(0x6C8)] public CustomMusicInfo musicInfos__arr72;
        [FieldOffset(0x6E0)] public CustomMusicInfo musicInfos__arr73;
        [FieldOffset(0x6F8)] public CustomMusicInfo musicInfos__arr74;
        [FieldOffset(0x710)] public CustomMusicInfo musicInfos__arr75;
        [FieldOffset(0x728)] public CustomMusicInfo musicInfos__arr76;
        [FieldOffset(0x740)] public CustomMusicInfo musicInfos__arr77;
        [FieldOffset(0x758)] public CustomMusicInfo musicInfos__arr78;
        [FieldOffset(0x770)] public CustomMusicInfo musicInfos__arr79;
        [FieldOffset(0x788)] public CustomMusicInfo musicInfos__arr80;
        [FieldOffset(0x7A0)] public CustomMusicInfo musicInfos__arr81;
        [FieldOffset(0x7B8)] public CustomMusicInfo musicInfos__arr82;
        [FieldOffset(0x7D0)] public CustomMusicInfo musicInfos__arr83;
        [FieldOffset(0x7E8)] public CustomMusicInfo musicInfos__arr84;
        [FieldOffset(0x800)] public CustomMusicInfo musicInfos__arr85;
        [FieldOffset(0x818)] public CustomMusicInfo musicInfos__arr86;
        [FieldOffset(0x830)] public CustomMusicInfo musicInfos__arr87;
        [FieldOffset(0x848)] public CustomMusicInfo musicInfos__arr88;
        [FieldOffset(0x860)] public CustomMusicInfo musicInfos__arr89;
        [FieldOffset(0x878)] public CustomMusicInfo musicInfos__arr90;
        [FieldOffset(0x890)] public CustomMusicInfo musicInfos__arr91;
        [FieldOffset(0x8A8)] public CustomMusicInfo musicInfos__arr92;
        [FieldOffset(0x8C0)] public CustomMusicInfo musicInfos__arr93;
        [FieldOffset(0x8D8)] public CustomMusicInfo musicInfos__arr94;
        [FieldOffset(0x8F0)] public CustomMusicInfo musicInfos__arr95;
        [FieldOffset(0x908)] public CustomMusicInfo musicInfos__arr96;
        [FieldOffset(0x920)] public CustomMusicInfo musicInfos__arr97;
        [FieldOffset(0x938)] public CustomMusicInfo musicInfos__arr98;
        [FieldOffset(0x950)] public CustomMusicInfo musicInfos__arr99;
        [FieldOffset(0x968)] public CustomMusicInfo musicInfos__arr100;
        [FieldOffset(0x980)] public CustomMusicInfo musicInfos__arr101;
        [FieldOffset(0x998)] public CustomMusicInfo musicInfos__arr102;
        [FieldOffset(0x9B0)] public CustomMusicInfo musicInfos__arr103;
        [FieldOffset(0x9C8)] public CustomMusicInfo musicInfos__arr104;
        [FieldOffset(0x9E0)] public CustomMusicInfo musicInfos__arr105;
        [FieldOffset(0x9F8)] public CustomMusicInfo musicInfos__arr106;
        [FieldOffset(0xA10)] public CustomMusicInfo musicInfos__arr107;
        [FieldOffset(0xA28)] public CustomMusicInfo musicInfos__arr108;
        [FieldOffset(0xA40)] public CustomMusicInfo musicInfos__arr109;
        [FieldOffset(0xA58)] public CustomMusicInfo musicInfos__arr110;
        [FieldOffset(0xA70)] public CustomMusicInfo musicInfos__arr111;
        [FieldOffset(0xA88)] public CustomMusicInfo musicInfos__arr112;
        [FieldOffset(0xAA0)] public CustomMusicInfo musicInfos__arr113;
        [FieldOffset(0xAB8)] public CustomMusicInfo musicInfos__arr114;
        [FieldOffset(0xAD0)] public CustomMusicInfo musicInfos__arr115;
        [FieldOffset(0xAE8)] public CustomMusicInfo musicInfos__arr116;
        [FieldOffset(0xB00)] public CustomMusicInfo musicInfos__arr117;
        [FieldOffset(0xB18)] public CustomMusicInfo musicInfos__arr118;
        [FieldOffset(0xB30)] public CustomMusicInfo musicInfos__arr119;
        [FieldOffset(0xB48)] public CustomMusicInfo musicInfos__arr120;
        [FieldOffset(0xB60)] public CustomMusicInfo musicInfos__arr121;
        [FieldOffset(0xB78)] public CustomMusicInfo musicInfos__arr122;
        [FieldOffset(0xB90)] public CustomMusicInfo musicInfos__arr123;
        [FieldOffset(0xBA8)] public CustomMusicInfo musicInfos__arr124;
        [FieldOffset(0xBC0)] public CustomMusicInfo musicInfos__arr125;
        [FieldOffset(0xBD8)] public CustomMusicInfo musicInfos__arr126;
        [FieldOffset(0xBF0)] public CustomMusicInfo musicInfos__arr127;
        [FieldOffset(0xC08)] public float idlingViewTime;
    }

}