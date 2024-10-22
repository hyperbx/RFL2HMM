Library "BGMInfoParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

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

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct BGMSceneInfo
    {
        [FieldOffset(0x00)] public UnmanagedString sceneName;
        [FieldOffset(0x10)] public int bgmId;
        [FieldOffset(0x14)] public bool disableSameBgmId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE60)]
    public struct BGMInfoParameter
    {
        [FieldOffset(0x00)] public BGMInfo changeBgmInfo__arr0;
        [FieldOffset(0x40)] public BGMInfo changeBgmInfo__arr1;
        [FieldOffset(0x80)] public BGMInfo changeBgmInfo__arr2;
        [FieldOffset(0xC0)] public BGMInfo changeBgmInfo__arr3;
        [FieldOffset(0x100)] public BGMInfo changeBgmInfo__arr4;
        [FieldOffset(0x140)] public BGMInfo changeBgmInfo__arr5;
        [FieldOffset(0x180)] public BGMInfo changeBgmInfo__arr6;
        [FieldOffset(0x1C0)] public BGMInfo changeBgmInfo__arr7;
        [FieldOffset(0x200)] public BGMInfo changeBgmInfo__arr8;
        [FieldOffset(0x240)] public BGMInfo changeBgmInfo__arr9;
        [FieldOffset(0x280)] public BGMInfo changeBgmInfo__arr10;
        [FieldOffset(0x2C0)] public BGMInfo changeBgmInfo__arr11;
        [FieldOffset(0x300)] public BGMInfo changeBgmInfo__arr12;
        [FieldOffset(0x340)] public BGMInfo changeBgmInfo__arr13;
        [FieldOffset(0x380)] public BGMInfo changeBgmInfo__arr14;
        [FieldOffset(0x3C0)] public BGMInfo changeBgmInfo__arr15;
        [FieldOffset(0x400)] public BGMInfo changeBgmInfo__arr16;
        [FieldOffset(0x440)] public BGMInfo changeBgmInfo__arr17;
        [FieldOffset(0x480)] public BGMInfo changeBgmInfo__arr18;
        [FieldOffset(0x4C0)] public BGMInfo changeBgmInfo__arr19;
        [FieldOffset(0x500)] public BGMInfo changeBgmInfo__arr20;
        [FieldOffset(0x540)] public BGMInfo changeBgmInfo__arr21;
        [FieldOffset(0x580)] public BGMInfo changeBgmInfo__arr22;
        [FieldOffset(0x5C0)] public BGMInfo changeBgmInfo__arr23;
        [FieldOffset(0x600)] public BGMInfo changeBgmInfo__arr24;
        [FieldOffset(0x640)] public BGMInfo changeBgmInfo__arr25;
        [FieldOffset(0x680)] public BGMInfo changeBgmInfo__arr26;
        [FieldOffset(0x6C0)] public BGMInfo changeBgmInfo__arr27;
        [FieldOffset(0x700)] public BGMInfo changeBgmInfo__arr28;
        [FieldOffset(0x740)] public BGMInfo changeBgmInfo__arr29;
        [FieldOffset(0x780)] public BGMInfo changeBgmInfo__arr30;
        [FieldOffset(0x7C0)] public BGMInfo changeBgmInfo__arr31;
        [FieldOffset(0x800)] public BGMTransitInfo transitBgmInfo__arr0;
        [FieldOffset(0x830)] public BGMTransitInfo transitBgmInfo__arr1;
        [FieldOffset(0x860)] public BGMTransitInfo transitBgmInfo__arr2;
        [FieldOffset(0x890)] public BGMTransitInfo transitBgmInfo__arr3;
        [FieldOffset(0x8C0)] public BGMTransitInfo transitBgmInfo__arr4;
        [FieldOffset(0x8F0)] public BGMTransitInfo transitBgmInfo__arr5;
        [FieldOffset(0x920)] public BGMTransitInfo transitBgmInfo__arr6;
        [FieldOffset(0x950)] public BGMTransitInfo transitBgmInfo__arr7;
        [FieldOffset(0x980)] public BGMTransitInfo transitBgmInfo__arr8;
        [FieldOffset(0x9B0)] public BGMTransitInfo transitBgmInfo__arr9;
        [FieldOffset(0x9E0)] public BGMTransitInfo transitBgmInfo__arr10;
        [FieldOffset(0xA10)] public BGMTransitInfo transitBgmInfo__arr11;
        [FieldOffset(0xA40)] public BGMTransitInfo transitBgmInfo__arr12;
        [FieldOffset(0xA70)] public BGMTransitInfo transitBgmInfo__arr13;
        [FieldOffset(0xAA0)] public BGMTransitInfo transitBgmInfo__arr14;
        [FieldOffset(0xAD0)] public BGMTransitInfo transitBgmInfo__arr15;
        [FieldOffset(0xB00)] public BGMTransitInfo transitBgmInfo__arr16;
        [FieldOffset(0xB30)] public BGMTransitInfo transitBgmInfo__arr17;
        [FieldOffset(0xB60)] public BGMTransitInfo transitBgmInfo__arr18;
        [FieldOffset(0xB90)] public BGMTransitInfo transitBgmInfo__arr19;
        [FieldOffset(0xBC0)] public BGMTransitInfo transitBgmInfo__arr20;
        [FieldOffset(0xBF0)] public BGMTransitInfo transitBgmInfo__arr21;
        [FieldOffset(0xC20)] public BGMTransitInfo transitBgmInfo__arr22;
        [FieldOffset(0xC50)] public BGMTransitInfo transitBgmInfo__arr23;
        [FieldOffset(0xC80)] public BGMTransitInfo transitBgmInfo__arr24;
        [FieldOffset(0xCB0)] public BGMTransitInfo transitBgmInfo__arr25;
        [FieldOffset(0xCE0)] public BGMTransitInfo transitBgmInfo__arr26;
        [FieldOffset(0xD10)] public BGMTransitInfo transitBgmInfo__arr27;
        [FieldOffset(0xD40)] public BGMTransitInfo transitBgmInfo__arr28;
        [FieldOffset(0xD70)] public BGMTransitInfo transitBgmInfo__arr29;
        [FieldOffset(0xDA0)] public BGMTransitInfo transitBgmInfo__arr30;
        [FieldOffset(0xDD0)] public BGMTransitInfo transitBgmInfo__arr31;
        [FieldOffset(0xE00)] public BGMSceneInfo sceneBgmInfo__arr0;
        [FieldOffset(0xE18)] public BGMSceneInfo sceneBgmInfo__arr1;
        [FieldOffset(0xE30)] public BGMSceneInfo sceneBgmInfo__arr2;
        [FieldOffset(0xE48)] public BGMSceneInfo sceneBgmInfo__arr3;
    }

}