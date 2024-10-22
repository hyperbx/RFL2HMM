Library "SystemData"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum Status : sbyte
    {
        STATUS_ZERO_FILL = 0,
        STATUS_INITIALIZED = 1
    }

    public enum Sequence : sbyte
    {
        NewGame = 0,
        DSpearTutorialAfter = 1,
        FinalBossBefore = 2,
        FinalBossAfter = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct HeaderData
    {
        [FieldOffset(0x00)] public uint signature;
        [FieldOffset(0x04)] public byte version;
        [FieldOffset(0x05)] public Status status;
        [FieldOffset(0x06)] public byte config;
        [FieldOffset(0x07)] public Sequence sequence;
        [FieldOffset(0x08)] public uint playTime;
        [FieldOffset(0x0C)] public byte reserved0;
        [FieldOffset(0x0E)] public ushort reserved1;
        [FieldOffset(0x10)] public long saveDate;
        [FieldOffset(0x18)] public byte index;
        [FieldOffset(0x1C)] public uint reserved__arr0;
        [FieldOffset(0x20)] public uint reserved__arr1;
        [FieldOffset(0x24)] public uint reserved__arr2;
        [FieldOffset(0x28)] public uint reserved__arr3;
    }

    public enum VoiceLanguageType : sbyte
    {
        VOICE_LANGUAGE_ENGLISH = 0,
        VOICE_LANGUAGE_FRENCH = 1,
        VOICE_LANGUAGE_ITALIAN = 2,
        VOICE_LANGUAGE_GERMAN = 3,
        VOICE_LANGUAGE_SPANISH = 4,
        VOICE_LANGUAGE_JAPANESE = 5,
        NUM_VOICE_LANGUAGES = 6
    }

    public enum LanguageType : sbyte
    {
        LANGUAGE_ENGLISH = 0,
        LANGUAGE_FRENCH = 1,
        LANGUAGE_ITALIAN = 2,
        LANGUAGE_GERMAN = 3,
        LANGUAGE_SPANISH = 4,
        LANGUAGE_POLISH = 5,
        LANGUAGE_PORTUGUESE = 6,
        LANGUAGE_RUSSIAN = 7,
        LANGUAGE_JAPANESE = 8,
        LANGUAGE_ZHONGWEN = 9,
        LANGUAGE_ZHONGWEN_S = 10,
        LANGUAGE_KOREAN = 11,
        LANGUAGE_THAI = 12,
        NUM_LANGUAGES = 13
    }

    public enum SkinType : sbyte
    {
        Original = 0,
        Type1 = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct OptionGamePlayData
    {
        [FieldOffset(0x00)] public byte initialSpeedRate;
        [FieldOffset(0x01)] public byte boostInitialSpeedRate;
        [FieldOffset(0x02)] public byte acceleRate;
        [FieldOffset(0x03)] public byte maxSpeedRate;
        [FieldOffset(0x04)] public byte minTurnSpeedRate;
        [FieldOffset(0x05)] public byte boostMinTurnSpeedRate;
        [FieldOffset(0x06)] public byte rotateForceRate;
        [FieldOffset(0x07)] public byte bumpJumpGravityRate;
        [FieldOffset(0x08)] public byte brakeRate;
        [FieldOffset(0x09)] public VoiceLanguageType speech;
        [FieldOffset(0x0A)] public LanguageType text;
        [FieldOffset(0x0C)] public ushort config;
        [FieldOffset(0x0E)] public byte padSensibilityRate;
        [FieldOffset(0x0F)] public byte mouseSensibilityRate;
        [FieldOffset(0x10)] public byte flags;
        [FieldOffset(0x11)] public SkinType dlcSkinGeneClassic;
        [FieldOffset(0x12)] public SkinType dlcSkinGeneModern;
        [FieldOffset(0x13)] public SkinType dlcSkinShadow;
        [FieldOffset(0x14)] public byte dlcConfig;
        [FieldOffset(0x15)] public byte reserved1__arr0;
        [FieldOffset(0x16)] public byte reserved1__arr1;
        [FieldOffset(0x17)] public byte reserved1__arr2;
        [FieldOffset(0x18)] public byte reserved1__arr3;
        [FieldOffset(0x19)] public byte reserved1__arr4;
        [FieldOffset(0x1C)] public uint reserved2__arr0;
        [FieldOffset(0x20)] public uint reserved2__arr1;
    }

    public enum InputButtonImageKind : sbyte
    {
        Default = 0,
        PS4 = 1,
        PS5 = 2,
        XBOX = 3,
        SCARLETT = 4,
        SWITCH = 5,
        STEAM = 6,
        Num = 7
    }

    public enum InputStyleKind : sbyte
    {
        InputStyleKind_Default = 0,
        Style2 = 1,
        Custom = 2,
        InputStyleKind_Num = 3
    }

    public enum InputKey : int
    {
        Invalid = -1,
        GamePad_DPadLeft = 0,
        GamePad_DPadRight = 1,
        GamePad_DPadUp = 2,
        GamePad_DPadDown = 3,
        GamePad_ButtonLeft = 4,
        GamePad_ButtonRight = 5,
        GamePad_ButtonTop = 6,
        GamePad_ButtonBottom = 7,
        GamePad_LeftX = 8,
        GamePad_LeftY = 9,
        GamePad_RightX = 10,
        GamePad_RightY = 11,
        GamePad_LeftShoulder = 12,
        GamePad_LeftTrigger = 13,
        GamePad_LeftClick = 14,
        GamePad_RightShoulder = 15,
        GamePad_RightTrigger = 16,
        GamePad_RightClick = 17,
        GamePad_LeftStickLeft = 18,
        GamePad_LeftStickRight = 19,
        GamePad_LeftStickUp = 20,
        GamePad_LeftStickDown = 21,
        GamePad_RightStickLeft = 22,
        GamePad_RightStickRight = 23,
        GamePad_RightStickUp = 24,
        GamePad_RightStickDown = 25,
        GamePad_Start = 26,
        GamePad_Select = 27,
        GamePad_LeftSideTriggerLeft = 28,
        GamePad_LeftSideTriggerRight = 29,
        GamePad_RightSideTriggerLeft = 30,
        GamePad_RightSideTriggerRight = 31,
        Keyboard_Nop = 32,
        Keyboard_A = 33,
        Keyboard_B = 34,
        Keyboard_C = 35,
        Keyboard_D = 36,
        Keyboard_E = 37,
        Keyboard_F = 38,
        Keyboard_G = 39,
        Keyboard_H = 40,
        Keyboard_I = 41,
        Keyboard_J = 42,
        Keyboard_K = 43,
        Keyboard_L = 44,
        Keyboard_M = 45,
        Keyboard_N = 46,
        Keyboard_O = 47,
        Keyboard_P = 48,
        Keyboard_Q = 49,
        Keyboard_R = 50,
        Keyboard_S = 51,
        Keyboard_T = 52,
        Keyboard_U = 53,
        Keyboard_V = 54,
        Keyboard_W = 55,
        Keyboard_X = 56,
        Keyboard_Y = 57,
        Keyboard_Z = 58,
        Keyboard_1 = 59,
        Keyboard_2 = 60,
        Keyboard_3 = 61,
        Keyboard_4 = 62,
        Keyboard_5 = 63,
        Keyboard_6 = 64,
        Keyboard_7 = 65,
        Keyboard_8 = 66,
        Keyboard_9 = 67,
        Keyboard_0 = 68,
        Keyboard_Enter = 69,
        Keyboard_Escape = 70,
        Keyboard_BackSpace = 71,
        Keyboard_Tab = 72,
        Keyboard_Spacebar = 73,
        Keyboard_Minus = 74,
        Keyboard_Accent = 75,
        Keyboard_Atmark = 76,
        Keyboard_LeftBracket = 77,
        Keyboard_BackSlash = 78,
        Keyboard_RightBracket = 79,
        Keyboard_SemiColon = 80,
        Keyboard_Colon = 81,
        Keyboard_Comma = 82,
        Keyboard_Period = 83,
        Keyboard_Slash = 84,
        Keyboard_CapsLock = 85,
        Keyboard_Grave = 86,
        Keyboard_Equals = 87,
        Keyboard_Apostrophe = 88,
        Keyboard_OEM_102 = 89,
        Keyboard_ABNT_C1 = 90,
        Keyboard_F1 = 91,
        Keyboard_F2 = 92,
        Keyboard_F3 = 93,
        Keyboard_F4 = 94,
        Keyboard_F5 = 95,
        Keyboard_F6 = 96,
        Keyboard_F7 = 97,
        Keyboard_F8 = 98,
        Keyboard_F9 = 99,
        Keyboard_F10 = 100,
        Keyboard_F11 = 101,
        Keyboard_F12 = 102,
        Keyboard_Insert = 103,
        Keyboard_Home = 104,
        Keyboard_PageUp = 105,
        Keyboard_Delete = 106,
        Keyboard_End = 107,
        Keyboard_PageDown = 108,
        Keyboard_LeftArrow = 109,
        Keyboard_RightArrow = 110,
        Keyboard_UpArrow = 111,
        Keyboard_DownArrow = 112,
        Keyboard_PadSlash = 113,
        Keyboard_PadAsterisk = 114,
        Keyboard_PadMinus = 115,
        Keyboard_PadPlus = 116,
        Keyboard_PadEnter = 117,
        Keyboard_PadNum1 = 118,
        Keyboard_PadNum2 = 119,
        Keyboard_PadNum3 = 120,
        Keyboard_PadNum4 = 121,
        Keyboard_PadNum5 = 122,
        Keyboard_PadNum6 = 123,
        Keyboard_PadNum7 = 124,
        Keyboard_PadNum8 = 125,
        Keyboard_PadNum9 = 126,
        Keyboard_PadNum0 = 127,
        Keyboard_PadPeriod = 128,
        Keyboard_LeftCtrl = 129,
        Keyboard_RightCtrl = 130,
        Keyboard_LeftShift = 131,
        Keyboard_RightShift = 132,
        Keyboard_LeftAlt = 133,
        Keyboard_RightAlt = 134,
        Keyboard_LeftGui = 135,
        Keyboard_RightGui = 136,
        Mouse_X = 137,
        Mouse_Y = 138,
        Mouse_ButtonLeft = 139,
        Mouse_ButtonRight = 140,
        Mouse_ButtonMiddle = 141,
        Mouse_ButtonX1 = 142,
        Mouse_ButtonX2 = 143,
        Mouse_ButtonX3 = 144,
        Mouse_ButtonX4 = 145,
        Mouse_ButtonX5 = 146,
        Mouse_Wheel = 147,
        Mouse_WheelUp = 148,
        Mouse_WheelDown = 149
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x224)]
    public struct OptionControlsData
    {
        [FieldOffset(0x00)] public InputButtonImageKind buttonImageKind;
        [FieldOffset(0x01)] public InputStyleKind gamepadStyleKind;
        [FieldOffset(0x04)] public InputKey padMappings__arr0;
        [FieldOffset(0x08)] public InputKey padMappings__arr1;
        [FieldOffset(0x0C)] public InputKey padMappings__arr2;
        [FieldOffset(0x10)] public InputKey padMappings__arr3;
        [FieldOffset(0x14)] public InputKey padMappings__arr4;
        [FieldOffset(0x18)] public InputKey padMappings__arr5;
        [FieldOffset(0x1C)] public InputKey padMappings__arr6;
        [FieldOffset(0x20)] public InputKey padMappings__arr7;
        [FieldOffset(0x24)] public InputKey padMappings__arr8;
        [FieldOffset(0x28)] public InputKey padMappings__arr9;
        [FieldOffset(0x2C)] public InputKey padMappings__arr10;
        [FieldOffset(0x30)] public InputKey padMappings__arr11;
        [FieldOffset(0x34)] public InputKey padMappings__arr12;
        [FieldOffset(0x38)] public InputKey padMappings__arr13;
        [FieldOffset(0x3C)] public InputKey padMappings__arr14;
        [FieldOffset(0x40)] public InputKey padMappings__arr15;
        [FieldOffset(0x44)] public InputKey padMappings__arr16;
        [FieldOffset(0x48)] public InputKey padMappings__arr17;
        [FieldOffset(0x4C)] public InputKey padMappings__arr18;
        [FieldOffset(0x50)] public InputKey padMappings__arr19;
        [FieldOffset(0x54)] public InputKey padMappings__arr20;
        [FieldOffset(0x58)] public InputKey padMappings__arr21;
        [FieldOffset(0x5C)] public InputKey padMappings__arr22;
        [FieldOffset(0x60)] public InputKey padMappings__arr23;
        [FieldOffset(0x64)] public InputKey padMappings__arr24;
        [FieldOffset(0x68)] public InputKey padMappings__arr25;
        [FieldOffset(0x6C)] public InputKey padMappings__arr26;
        [FieldOffset(0x70)] public InputKey padMappings__arr27;
        [FieldOffset(0x74)] public InputKey padMappings__arr28;
        [FieldOffset(0x78)] public InputKey padMappings__arr29;
        [FieldOffset(0x7C)] public InputKey padMappings__arr30;
        [FieldOffset(0x80)] public InputKey padMappings__arr31;
        [FieldOffset(0x84)] public InputKey padMappings__arr32;
        [FieldOffset(0x88)] public InputKey padMappings__arr33;
        [FieldOffset(0x8C)] public InputKey padMappings__arr34;
        [FieldOffset(0x90)] public InputKey padMappings__arr35;
        [FieldOffset(0x94)] public InputKey padMappings__arr36;
        [FieldOffset(0x98)] public InputKey padMappings__arr37;
        [FieldOffset(0x9C)] public InputKey padMappings__arr38;
        [FieldOffset(0xA0)] public InputKey padMappings__arr39;
        [FieldOffset(0xA4)] public InputKey padMappings__arr40;
        [FieldOffset(0xA8)] public InputKey padMappings__arr41;
        [FieldOffset(0xAC)] public InputKey padMappings__arr42;
        [FieldOffset(0xB0)] public InputKey padMappings__arr43;
        [FieldOffset(0xB4)] public InputKey padMappings__arr44;
        [FieldOffset(0xB8)] public InputKey mainMappings__arr0;
        [FieldOffset(0xBC)] public InputKey mainMappings__arr1;
        [FieldOffset(0xC0)] public InputKey mainMappings__arr2;
        [FieldOffset(0xC4)] public InputKey mainMappings__arr3;
        [FieldOffset(0xC8)] public InputKey mainMappings__arr4;
        [FieldOffset(0xCC)] public InputKey mainMappings__arr5;
        [FieldOffset(0xD0)] public InputKey mainMappings__arr6;
        [FieldOffset(0xD4)] public InputKey mainMappings__arr7;
        [FieldOffset(0xD8)] public InputKey mainMappings__arr8;
        [FieldOffset(0xDC)] public InputKey mainMappings__arr9;
        [FieldOffset(0xE0)] public InputKey mainMappings__arr10;
        [FieldOffset(0xE4)] public InputKey mainMappings__arr11;
        [FieldOffset(0xE8)] public InputKey mainMappings__arr12;
        [FieldOffset(0xEC)] public InputKey mainMappings__arr13;
        [FieldOffset(0xF0)] public InputKey mainMappings__arr14;
        [FieldOffset(0xF4)] public InputKey mainMappings__arr15;
        [FieldOffset(0xF8)] public InputKey mainMappings__arr16;
        [FieldOffset(0xFC)] public InputKey mainMappings__arr17;
        [FieldOffset(0x100)] public InputKey mainMappings__arr18;
        [FieldOffset(0x104)] public InputKey mainMappings__arr19;
        [FieldOffset(0x108)] public InputKey mainMappings__arr20;
        [FieldOffset(0x10C)] public InputKey mainMappings__arr21;
        [FieldOffset(0x110)] public InputKey mainMappings__arr22;
        [FieldOffset(0x114)] public InputKey mainMappings__arr23;
        [FieldOffset(0x118)] public InputKey mainMappings__arr24;
        [FieldOffset(0x11C)] public InputKey mainMappings__arr25;
        [FieldOffset(0x120)] public InputKey mainMappings__arr26;
        [FieldOffset(0x124)] public InputKey mainMappings__arr27;
        [FieldOffset(0x128)] public InputKey mainMappings__arr28;
        [FieldOffset(0x12C)] public InputKey mainMappings__arr29;
        [FieldOffset(0x130)] public InputKey mainMappings__arr30;
        [FieldOffset(0x134)] public InputKey mainMappings__arr31;
        [FieldOffset(0x138)] public InputKey mainMappings__arr32;
        [FieldOffset(0x13C)] public InputKey mainMappings__arr33;
        [FieldOffset(0x140)] public InputKey mainMappings__arr34;
        [FieldOffset(0x144)] public InputKey mainMappings__arr35;
        [FieldOffset(0x148)] public InputKey mainMappings__arr36;
        [FieldOffset(0x14C)] public InputKey mainMappings__arr37;
        [FieldOffset(0x150)] public InputKey mainMappings__arr38;
        [FieldOffset(0x154)] public InputKey mainMappings__arr39;
        [FieldOffset(0x158)] public InputKey mainMappings__arr40;
        [FieldOffset(0x15C)] public InputKey mainMappings__arr41;
        [FieldOffset(0x160)] public InputKey mainMappings__arr42;
        [FieldOffset(0x164)] public InputKey mainMappings__arr43;
        [FieldOffset(0x168)] public InputKey mainMappings__arr44;
        [FieldOffset(0x16C)] public InputKey subMappings__arr0;
        [FieldOffset(0x170)] public InputKey subMappings__arr1;
        [FieldOffset(0x174)] public InputKey subMappings__arr2;
        [FieldOffset(0x178)] public InputKey subMappings__arr3;
        [FieldOffset(0x17C)] public InputKey subMappings__arr4;
        [FieldOffset(0x180)] public InputKey subMappings__arr5;
        [FieldOffset(0x184)] public InputKey subMappings__arr6;
        [FieldOffset(0x188)] public InputKey subMappings__arr7;
        [FieldOffset(0x18C)] public InputKey subMappings__arr8;
        [FieldOffset(0x190)] public InputKey subMappings__arr9;
        [FieldOffset(0x194)] public InputKey subMappings__arr10;
        [FieldOffset(0x198)] public InputKey subMappings__arr11;
        [FieldOffset(0x19C)] public InputKey subMappings__arr12;
        [FieldOffset(0x1A0)] public InputKey subMappings__arr13;
        [FieldOffset(0x1A4)] public InputKey subMappings__arr14;
        [FieldOffset(0x1A8)] public InputKey subMappings__arr15;
        [FieldOffset(0x1AC)] public InputKey subMappings__arr16;
        [FieldOffset(0x1B0)] public InputKey subMappings__arr17;
        [FieldOffset(0x1B4)] public InputKey subMappings__arr18;
        [FieldOffset(0x1B8)] public InputKey subMappings__arr19;
        [FieldOffset(0x1BC)] public InputKey subMappings__arr20;
        [FieldOffset(0x1C0)] public InputKey subMappings__arr21;
        [FieldOffset(0x1C4)] public InputKey subMappings__arr22;
        [FieldOffset(0x1C8)] public InputKey subMappings__arr23;
        [FieldOffset(0x1CC)] public InputKey subMappings__arr24;
        [FieldOffset(0x1D0)] public InputKey subMappings__arr25;
        [FieldOffset(0x1D4)] public InputKey subMappings__arr26;
        [FieldOffset(0x1D8)] public InputKey subMappings__arr27;
        [FieldOffset(0x1DC)] public InputKey subMappings__arr28;
        [FieldOffset(0x1E0)] public InputKey subMappings__arr29;
        [FieldOffset(0x1E4)] public InputKey subMappings__arr30;
        [FieldOffset(0x1E8)] public InputKey subMappings__arr31;
        [FieldOffset(0x1EC)] public InputKey subMappings__arr32;
        [FieldOffset(0x1F0)] public InputKey subMappings__arr33;
        [FieldOffset(0x1F4)] public InputKey subMappings__arr34;
        [FieldOffset(0x1F8)] public InputKey subMappings__arr35;
        [FieldOffset(0x1FC)] public InputKey subMappings__arr36;
        [FieldOffset(0x200)] public InputKey subMappings__arr37;
        [FieldOffset(0x204)] public InputKey subMappings__arr38;
        [FieldOffset(0x208)] public InputKey subMappings__arr39;
        [FieldOffset(0x20C)] public InputKey subMappings__arr40;
        [FieldOffset(0x210)] public InputKey subMappings__arr41;
        [FieldOffset(0x214)] public InputKey subMappings__arr42;
        [FieldOffset(0x218)] public InputKey subMappings__arr43;
        [FieldOffset(0x21C)] public InputKey subMappings__arr44;
        [FieldOffset(0x220)] public byte reserved;
    }

    public enum MovementStyle : sbyte
    {
        PadSimulate = 0,
        Aiming = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct OptionCameraData
    {
        [FieldOffset(0x00)] public float rotateSpeedPad;
        [FieldOffset(0x04)] public float rotateSpeedVertMouse;
        [FieldOffset(0x08)] public float rotateSpeedHorzMouse;
        [FieldOffset(0x0C)] public float reticleSpeedPad;
        [FieldOffset(0x10)] public float reticleSpeedVertMouse;
        [FieldOffset(0x14)] public float reticleSpeedHorzMouse;
        [FieldOffset(0x18)] public byte rotateSpeedRate;
        [FieldOffset(0x19)] public byte distanceRate;
        [FieldOffset(0x1A)] public byte fovyRate;
        [FieldOffset(0x1B)] public MovementStyle movementStyle;
        [FieldOffset(0x1C)] public byte config;
        [FieldOffset(0x20)] public uint reserved__arr0;
        [FieldOffset(0x24)] public uint reserved__arr1;
        [FieldOffset(0x28)] public uint reserved__arr2;
        [FieldOffset(0x2C)] public uint reserved__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct OptionAudioData
    {
        [FieldOffset(0x00)] public byte masterVolume;
        [FieldOffset(0x01)] public byte sfxVolume;
        [FieldOffset(0x02)] public byte musicVolume;
        [FieldOffset(0x03)] public byte voiceVolume;
        [FieldOffset(0x04)] public uint reserved__arr0;
        [FieldOffset(0x08)] public uint reserved__arr1;
        [FieldOffset(0x0C)] public uint reserved__arr2;
        [FieldOffset(0x10)] public uint reserved__arr3;
    }

    public enum FrameRate : sbyte
    {
        FPS60 = 0,
        FPS30 = 1,
        FPS120 = 2,
        FPSNoLimit = 3
    }

    public enum Shadow : sbyte
    {
        High = 0,
        Low = 1
    }

    public enum Bloom : sbyte
    {
        Bloom_High = 0,
        Bloom_Low = 1
    }

    public enum VolumetricLight : sbyte
    {
        VolumetricLight_High = 0,
        VolumetricLight_Low = 1
    }

    public enum AntiAliasing : sbyte
    {
        TAA = 0,
        FXAA = 1,
        None = 2
    }

    public enum AnisotropicFiltering : sbyte
    {
        AnisotropicFiltering_None = 0,
        AnisotropicFiltering_Low = 1,
        Medium = 2,
        AnisotropicFiltering_High = 3
    }

    public enum DOF : sbyte
    {
        Disabled = 0,
        DOF_Low = 1,
        DOF_Medium = 2,
        DOF_High = 3
    }

    public enum RederingScale : sbyte
    {
        RederingScale_High = 0,
        RederingScale_Medium = 1,
        RederingScale_Low = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct OptionGraphicsData
    {
        [FieldOffset(0x00)] public FrameRate frameRate;
        [FieldOffset(0x01)] public Shadow shadow;
        [FieldOffset(0x02)] public Bloom bloom;
        [FieldOffset(0x03)] public VolumetricLight volumetricLight;
        [FieldOffset(0x04)] public byte brightness;
        [FieldOffset(0x05)] public AntiAliasing antiAliasing;
        [FieldOffset(0x06)] public AnisotropicFiltering anisotropicFiltering;
        [FieldOffset(0x07)] public DOF depthOfField;
        [FieldOffset(0x08)] public byte config;
        [FieldOffset(0x09)] public RederingScale renderingScale;
        [FieldOffset(0x0A)] public ushort width;
        [FieldOffset(0x0C)] public ushort height;
        [FieldOffset(0x0E)] public byte reserved1;
        [FieldOffset(0x10)] public uint reserved__arr0;
        [FieldOffset(0x14)] public uint reserved__arr1;
    }

    public enum RankType : byte
    {
        RANK_S = 0,
        RANK_A = 1,
        RANK_B = 2,
        RANK_C = 3,
        RANK_D = 4,
        RANK_NUM = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct RankingData
    {
        [FieldOffset(0x00)] public byte flags;
        [FieldOffset(0x04)] public uint bestScore;
        [FieldOffset(0x08)] public uint bestScoreDwing;
        [FieldOffset(0x0C)] public uint bestRing;
        [FieldOffset(0x10)] public uint bestRingDwing;
        [FieldOffset(0x14)] public uint bestTime__arr0;
        [FieldOffset(0x18)] public uint bestTime__arr1;
        [FieldOffset(0x1C)] public uint bestTime__arr2;
        [FieldOffset(0x20)] public uint bestTimeDwing__arr0;
        [FieldOffset(0x24)] public uint bestTimeDwing__arr1;
        [FieldOffset(0x28)] public uint bestTimeDwing__arr2;
        [FieldOffset(0x2C)] public RankType bestRank;
        [FieldOffset(0x2D)] public RankType bestRankDwing;
        [FieldOffset(0x30)] public uint clearCount;
        [FieldOffset(0x34)] public bool uploaded;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x57C)]
    public struct RankingContainerData
    {
        [FieldOffset(0x00)] public RankingData ranking__arr0;
        [FieldOffset(0x38)] public RankingData ranking__arr1;
        [FieldOffset(0x70)] public RankingData ranking__arr2;
        [FieldOffset(0xA8)] public RankingData ranking__arr3;
        [FieldOffset(0xE0)] public RankingData ranking__arr4;
        [FieldOffset(0x118)] public RankingData ranking__arr5;
        [FieldOffset(0x150)] public RankingData ranking__arr6;
        [FieldOffset(0x188)] public RankingData ranking__arr7;
        [FieldOffset(0x1C0)] public RankingData ranking__arr8;
        [FieldOffset(0x1F8)] public RankingData ranking__arr9;
        [FieldOffset(0x230)] public RankingData ranking__arr10;
        [FieldOffset(0x268)] public RankingData ranking__arr11;
        [FieldOffset(0x2A0)] public RankingData ranking__arr12;
        [FieldOffset(0x2D8)] public RankingData ranking__arr13;
        [FieldOffset(0x310)] public RankingData ranking__arr14;
        [FieldOffset(0x348)] public RankingData ranking__arr15;
        [FieldOffset(0x380)] public RankingData ranking__arr16;
        [FieldOffset(0x3B8)] public RankingData ranking__arr17;
        [FieldOffset(0x3F0)] public RankingData ranking__arr18;
        [FieldOffset(0x428)] public RankingData ranking__arr19;
        [FieldOffset(0x460)] public RankingData ranking__arr20;
        [FieldOffset(0x498)] public RankingData ranking__arr21;
        [FieldOffset(0x4D0)] public RankingData ranking__arr22;
        [FieldOffset(0x508)] public RankingData ranking__arr23;
        [FieldOffset(0x540)] public RankingData ranking__arr24;
        [FieldOffset(0x578)] public bool enableDWing;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct CRMContainerData
    {
        [FieldOffset(0x00)] public sbyte uuid__arr0;
        [FieldOffset(0x01)] public sbyte uuid__arr1;
        [FieldOffset(0x02)] public sbyte uuid__arr2;
        [FieldOffset(0x03)] public sbyte uuid__arr3;
        [FieldOffset(0x04)] public sbyte uuid__arr4;
        [FieldOffset(0x05)] public sbyte uuid__arr5;
        [FieldOffset(0x06)] public sbyte uuid__arr6;
        [FieldOffset(0x07)] public sbyte uuid__arr7;
        [FieldOffset(0x08)] public sbyte uuid__arr8;
        [FieldOffset(0x09)] public sbyte uuid__arr9;
        [FieldOffset(0x0A)] public sbyte uuid__arr10;
        [FieldOffset(0x0B)] public sbyte uuid__arr11;
        [FieldOffset(0x0C)] public sbyte uuid__arr12;
        [FieldOffset(0x0D)] public sbyte uuid__arr13;
        [FieldOffset(0x0E)] public sbyte uuid__arr14;
        [FieldOffset(0x0F)] public sbyte uuid__arr15;
        [FieldOffset(0x10)] public sbyte uuid__arr16;
        [FieldOffset(0x11)] public sbyte uuid__arr17;
        [FieldOffset(0x12)] public sbyte uuid__arr18;
        [FieldOffset(0x13)] public sbyte uuid__arr19;
        [FieldOffset(0x14)] public sbyte uuid__arr20;
        [FieldOffset(0x15)] public sbyte uuid__arr21;
        [FieldOffset(0x16)] public sbyte uuid__arr22;
        [FieldOffset(0x17)] public sbyte uuid__arr23;
        [FieldOffset(0x18)] public sbyte uuid__arr24;
        [FieldOffset(0x19)] public sbyte uuid__arr25;
        [FieldOffset(0x1A)] public sbyte uuid__arr26;
        [FieldOffset(0x1B)] public sbyte uuid__arr27;
        [FieldOffset(0x1C)] public sbyte uuid__arr28;
        [FieldOffset(0x1D)] public sbyte uuid__arr29;
        [FieldOffset(0x1E)] public sbyte uuid__arr30;
        [FieldOffset(0x1F)] public sbyte uuid__arr31;
        [FieldOffset(0x20)] public sbyte uuid__arr32;
        [FieldOffset(0x21)] public sbyte uuid__arr33;
        [FieldOffset(0x22)] public sbyte uuid__arr34;
        [FieldOffset(0x23)] public sbyte uuid__arr35;
        [FieldOffset(0x24)] public sbyte uuid__arr36;
        [FieldOffset(0x25)] public sbyte uuid__arr37;
        [FieldOffset(0x26)] public sbyte uuid__arr38;
        [FieldOffset(0x27)] public sbyte uuid__arr39;
        [FieldOffset(0x28)] public uint reserved__arr0;
        [FieldOffset(0x2C)] public uint reserved__arr1;
        [FieldOffset(0x30)] public uint reserved__arr2;
        [FieldOffset(0x34)] public uint reserved__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2B0)]
    public struct AddContentDataSystem
    {
        [FieldOffset(0x00)] public RankingData addRanking__arr0;
        [FieldOffset(0x38)] public RankingData addRanking__arr1;
        [FieldOffset(0x70)] public RankingData addRanking__arr2;
        [FieldOffset(0xA8)] public RankingData addRanking__arr3;
        [FieldOffset(0xE0)] public RankingData addRanking__arr4;
        [FieldOffset(0x118)] public RankingData addRanking__arr5;
        [FieldOffset(0x150)] public RankingData addRanking__arr6;
        [FieldOffset(0x188)] public RankingData addRanking__arr7;
        [FieldOffset(0x1C0)] public RankingData addRanking__arr8;
        [FieldOffset(0x1F8)] public RankingData addRanking__arr9;
        [FieldOffset(0x230)] public uint reserved__arr0;
        [FieldOffset(0x234)] public uint reserved__arr1;
        [FieldOffset(0x238)] public uint reserved__arr2;
        [FieldOffset(0x23C)] public uint reserved__arr3;
        [FieldOffset(0x240)] public uint reserved__arr4;
        [FieldOffset(0x244)] public uint reserved__arr5;
        [FieldOffset(0x248)] public uint reserved__arr6;
        [FieldOffset(0x24C)] public uint reserved__arr7;
        [FieldOffset(0x250)] public uint reserved__arr8;
        [FieldOffset(0x254)] public uint reserved__arr9;
        [FieldOffset(0x258)] public uint reserved__arr10;
        [FieldOffset(0x25C)] public uint reserved__arr11;
        [FieldOffset(0x260)] public uint reserved__arr12;
        [FieldOffset(0x264)] public uint reserved__arr13;
        [FieldOffset(0x268)] public uint reserved__arr14;
        [FieldOffset(0x26C)] public uint reserved__arr15;
        [FieldOffset(0x270)] public uint reserved__arr16;
        [FieldOffset(0x274)] public uint reserved__arr17;
        [FieldOffset(0x278)] public uint reserved__arr18;
        [FieldOffset(0x27C)] public uint reserved__arr19;
        [FieldOffset(0x280)] public uint reserved__arr20;
        [FieldOffset(0x284)] public uint reserved__arr21;
        [FieldOffset(0x288)] public uint reserved__arr22;
        [FieldOffset(0x28C)] public uint reserved__arr23;
        [FieldOffset(0x290)] public uint reserved__arr24;
        [FieldOffset(0x294)] public uint reserved__arr25;
        [FieldOffset(0x298)] public uint reserved__arr26;
        [FieldOffset(0x29C)] public uint reserved__arr27;
        [FieldOffset(0x2A0)] public uint reserved__arr28;
        [FieldOffset(0x2A4)] public uint reserved__arr29;
        [FieldOffset(0x2A8)] public uint reserved__arr30;
        [FieldOffset(0x2AC)] public uint reserved__arr31;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xB38)]
    public struct SystemData
    {
        [FieldOffset(0x00)] public HeaderData header;
        [FieldOffset(0x30)] public OptionGamePlayData gameplay;
        [FieldOffset(0x54)] public OptionControlsData controls;
        [FieldOffset(0x278)] public OptionCameraData camera;
        [FieldOffset(0x2A8)] public OptionAudioData audio;
        [FieldOffset(0x2BC)] public OptionGraphicsData graphics;
        [FieldOffset(0x2D4)] public RankingContainerData rankings;
        [FieldOffset(0x850)] public CRMContainerData crm;
        [FieldOffset(0x888)] public AddContentDataSystem addData;
    }

}