using System.Numerics;
using System.Runtime.InteropServices;

public class OptionDataClass
{
    public enum Status : sbyte
    {
        STATUS_ZERO_FILL = 0,
        STATUS_INITIALIZED = 1
    }

    public enum Sequence : sbyte
    {
        Island1 = 0,
        Island2 = 1,
        Island3 = 2,
        Island4 = 3,
        Island5 = 4,
        FinalBossBefore = 5,
        FinalBossAfter = 6
    }

    public enum SaveDataIcon : sbyte
    {
        IconNoData = 0,
        IconIsland1 = 1,
        IconIsland2 = 2,
        IconIsland3 = 3,
        IconIsland4 = 4,
        IconIsland5 = 5,
        IconLastBoss = 6,
        IconExtra = 7
    }

    public enum AppVersion : byte
    {
        AppVersion_1_10 = 0,
        AppVersion_1_20 = 1,
        AppVersion_1_30 = 2,
        AppVersion_1_40 = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct HeaderData
    {
        [FieldOffset(0x00)] public uint signature;
        [FieldOffset(0x04)] public byte version;
        [FieldOffset(0x05)] public Status status;
        [FieldOffset(0x06)] public byte config;
        [FieldOffset(0x07)] public Sequence sequence;
        [FieldOffset(0x08)] public uint playTime;
        [FieldOffset(0x0C)] public SaveDataIcon icon;
        [FieldOffset(0x0D)] public AppVersion appVersion;
        [FieldOffset(0x0E)] public byte config2;
        [FieldOffset(0x0F)] public byte reserved1;
        [FieldOffset(0x10)] public uint saveDate;
        [FieldOffset(0x14)] public byte index;
        [FieldOffset(0x18)] public uint reserved__arr0;
        [FieldOffset(0x1C)] public uint reserved__arr1;
        [FieldOffset(0x20)] public uint reserved__arr2;
        [FieldOffset(0x24)] public uint reserved__arr3;
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
        NUM_LANGUAGES = 12
    }

    public enum VibrationLevel : sbyte
    {
        None = 0,
        Low = 1,
        Medium = 2,
        High = 3
    }

    public enum Value : sbyte
    {
        Easy = 0,
        Normal = 1,
        Hard = 2,
        Num = 3,
        VeryHard = 3,
        NumInVeryHard = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
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
        [FieldOffset(0x08)] public VoiceLanguageType speech;
        [FieldOffset(0x09)] public LanguageType text;
        [FieldOffset(0x0A)] public VibrationLevel vibrationLevel;
        [FieldOffset(0x0B)] public Value diffculty;
        [FieldOffset(0x0C)] public byte config;
        [FieldOffset(0x0D)] public byte padSensibilityRate;
        [FieldOffset(0x0E)] public byte mouseSensibilityRate;
        [FieldOffset(0x0F)] public byte neutralDecelerationRate;
        [FieldOffset(0x10)] public byte dlcSonicCostume;
        [FieldOffset(0x11)] public byte dlcKodamaModel;
        [FieldOffset(0x12)] public byte dlcRingSE;
        [FieldOffset(0x13)] public byte dlcConfig;
        [FieldOffset(0x14)] public byte config2;
        [FieldOffset(0x15)] public byte islandVisual;
        [FieldOffset(0x16)] public byte npcVisual;
        [FieldOffset(0x17)] public byte baseAirDragScaleRate;
        [FieldOffset(0x18)] public uint status;
        [FieldOffset(0x1C)] public uint reserved2;
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
        Keyboard_F1 = 86,
        Keyboard_F2 = 87,
        Keyboard_F3 = 88,
        Keyboard_F4 = 89,
        Keyboard_F5 = 90,
        Keyboard_F6 = 91,
        Keyboard_F7 = 92,
        Keyboard_F8 = 93,
        Keyboard_F9 = 94,
        Keyboard_F10 = 95,
        Keyboard_F11 = 96,
        Keyboard_F12 = 97,
        Keyboard_Insert = 98,
        Keyboard_Home = 99,
        Keyboard_PageUp = 100,
        Keyboard_Delete = 101,
        Keyboard_End = 102,
        Keyboard_PageDown = 103,
        Keyboard_LeftArrow = 104,
        Keyboard_RightArrow = 105,
        Keyboard_UpArrow = 106,
        Keyboard_DownArrow = 107,
        Keyboard_PadSlash = 108,
        Keyboard_PadAsterisk = 109,
        Keyboard_PadMinus = 110,
        Keyboard_PadPlus = 111,
        Keyboard_PadEnter = 112,
        Keyboard_PadNum1 = 113,
        Keyboard_PadNum2 = 114,
        Keyboard_PadNum3 = 115,
        Keyboard_PadNum4 = 116,
        Keyboard_PadNum5 = 117,
        Keyboard_PadNum6 = 118,
        Keyboard_PadNum7 = 119,
        Keyboard_PadNum8 = 120,
        Keyboard_PadNum9 = 121,
        Keyboard_PadNum0 = 122,
        Keyboard_PadPeriod = 123,
        Keyboard_LeftCtrl = 124,
        Keyboard_RightCtrl = 125,
        Keyboard_LeftShift = 126,
        Keyboard_RightShift = 127,
        Keyboard_LeftAlt = 128,
        Keyboard_RightAlt = 129,
        Keyboard_LeftGui = 130,
        Keyboard_RightGui = 131,
        Mouse_X = 132,
        Mouse_Y = 133,
        Mouse_ButtonLeft = 134,
        Mouse_ButtonRight = 135,
        Mouse_ButtonMiddle = 136,
        Mouse_ButtonX1 = 137,
        Mouse_ButtonX2 = 138,
        Mouse_Wheel = 139,
        Mouse_WheelUp = 140,
        Mouse_WheelDown = 141,
        Keyboard_Grave = 142,
        Keyboard_Equals = 143,
        Keyboard_Apostrophe = 144,
        Keyboard_OEM_102 = 145,
        Keyboard_ABNT_C1 = 146,
        Keyboard_ABNT_C2 = 147,
        Keyboard_Shift = 148,
        Keyboard_Ctrl = 149,
        NumAppKeys = 150
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2E8)]
    public struct OptionControlsData
    {
        [FieldOffset(0x00)] public InputKey padMappings__arr0;
        [FieldOffset(0x04)] public InputKey padMappings__arr1;
        [FieldOffset(0x08)] public InputKey padMappings__arr2;
        [FieldOffset(0x0C)] public InputKey padMappings__arr3;
        [FieldOffset(0x10)] public InputKey padMappings__arr4;
        [FieldOffset(0x14)] public InputKey padMappings__arr5;
        [FieldOffset(0x18)] public InputKey padMappings__arr6;
        [FieldOffset(0x1C)] public InputKey padMappings__arr7;
        [FieldOffset(0x20)] public InputKey padMappings__arr8;
        [FieldOffset(0x24)] public InputKey padMappings__arr9;
        [FieldOffset(0x28)] public InputKey padMappings__arr10;
        [FieldOffset(0x2C)] public InputKey padMappings__arr11;
        [FieldOffset(0x30)] public InputKey padMappings__arr12;
        [FieldOffset(0x34)] public InputKey padMappings__arr13;
        [FieldOffset(0x38)] public InputKey padMappings__arr14;
        [FieldOffset(0x3C)] public InputKey padMappings__arr15;
        [FieldOffset(0x40)] public InputKey padMappings__arr16;
        [FieldOffset(0x44)] public InputKey padMappings__arr17;
        [FieldOffset(0x48)] public InputKey padMappings__arr18;
        [FieldOffset(0x4C)] public InputKey padMappings__arr19;
        [FieldOffset(0x50)] public InputKey padMappings__arr20;
        [FieldOffset(0x54)] public InputKey padMappings__arr21;
        [FieldOffset(0x58)] public InputKey padMappings__arr22;
        [FieldOffset(0x5C)] public InputKey padMappings__arr23;
        [FieldOffset(0x60)] public InputKey padMappings__arr24;
        [FieldOffset(0x64)] public InputKey padMappings__arr25;
        [FieldOffset(0x68)] public InputKey padMappings__arr26;
        [FieldOffset(0x6C)] public InputKey padMappings__arr27;
        [FieldOffset(0x70)] public InputKey padMappings__arr28;
        [FieldOffset(0x74)] public InputKey padMappings__arr29;
        [FieldOffset(0x78)] public InputKey padMappings__arr30;
        [FieldOffset(0x7C)] public InputKey padMappings__arr31;
        [FieldOffset(0x80)] public InputKey padMappings__arr32;
        [FieldOffset(0x84)] public InputKey padMappings__arr33;
        [FieldOffset(0x88)] public InputKey padMappings__arr34;
        [FieldOffset(0x8C)] public InputKey padMappings__arr35;
        [FieldOffset(0x90)] public InputKey padMappings__arr36;
        [FieldOffset(0x94)] public InputKey padMappings__arr37;
        [FieldOffset(0x98)] public InputKey padMappings__arr38;
        [FieldOffset(0x9C)] public InputKey padMappings__arr39;
        [FieldOffset(0xA0)] public InputKey padMappings__arr40;
        [FieldOffset(0xA4)] public InputKey padMappings__arr41;
        [FieldOffset(0xA8)] public InputKey padMappings__arr42;
        [FieldOffset(0xAC)] public InputKey padMappings__arr43;
        [FieldOffset(0xB0)] public InputKey padMappings__arr44;
        [FieldOffset(0xB4)] public InputKey padMappings__arr45;
        [FieldOffset(0xB8)] public InputKey padMappings__arr46;
        [FieldOffset(0xBC)] public InputKey padMappings__arr47;
        [FieldOffset(0xC0)] public InputKey padMappings__arr48;
        [FieldOffset(0xC4)] public InputKey padMappings__arr49;
        [FieldOffset(0xC8)] public InputKey padMappings__arr50;
        [FieldOffset(0xCC)] public InputKey padMappings__arr51;
        [FieldOffset(0xD0)] public InputKey padMappings__arr52;
        [FieldOffset(0xD4)] public InputKey padMappings__arr53;
        [FieldOffset(0xD8)] public InputKey padMappings__arr54;
        [FieldOffset(0xDC)] public InputKey padMappings__arr55;
        [FieldOffset(0xE0)] public InputKey padMappings__arr56;
        [FieldOffset(0xE4)] public InputKey padMappings__arr57;
        [FieldOffset(0xE8)] public InputKey padMappings__arr58;
        [FieldOffset(0xEC)] public InputKey padMappings__arr59;
        [FieldOffset(0xF0)] public InputKey padMappings__arr60;
        [FieldOffset(0xF4)] public InputKey padMappings__arr61;
        [FieldOffset(0xF8)] public InputKey mainMappings__arr0;
        [FieldOffset(0xFC)] public InputKey mainMappings__arr1;
        [FieldOffset(0x100)] public InputKey mainMappings__arr2;
        [FieldOffset(0x104)] public InputKey mainMappings__arr3;
        [FieldOffset(0x108)] public InputKey mainMappings__arr4;
        [FieldOffset(0x10C)] public InputKey mainMappings__arr5;
        [FieldOffset(0x110)] public InputKey mainMappings__arr6;
        [FieldOffset(0x114)] public InputKey mainMappings__arr7;
        [FieldOffset(0x118)] public InputKey mainMappings__arr8;
        [FieldOffset(0x11C)] public InputKey mainMappings__arr9;
        [FieldOffset(0x120)] public InputKey mainMappings__arr10;
        [FieldOffset(0x124)] public InputKey mainMappings__arr11;
        [FieldOffset(0x128)] public InputKey mainMappings__arr12;
        [FieldOffset(0x12C)] public InputKey mainMappings__arr13;
        [FieldOffset(0x130)] public InputKey mainMappings__arr14;
        [FieldOffset(0x134)] public InputKey mainMappings__arr15;
        [FieldOffset(0x138)] public InputKey mainMappings__arr16;
        [FieldOffset(0x13C)] public InputKey mainMappings__arr17;
        [FieldOffset(0x140)] public InputKey mainMappings__arr18;
        [FieldOffset(0x144)] public InputKey mainMappings__arr19;
        [FieldOffset(0x148)] public InputKey mainMappings__arr20;
        [FieldOffset(0x14C)] public InputKey mainMappings__arr21;
        [FieldOffset(0x150)] public InputKey mainMappings__arr22;
        [FieldOffset(0x154)] public InputKey mainMappings__arr23;
        [FieldOffset(0x158)] public InputKey mainMappings__arr24;
        [FieldOffset(0x15C)] public InputKey mainMappings__arr25;
        [FieldOffset(0x160)] public InputKey mainMappings__arr26;
        [FieldOffset(0x164)] public InputKey mainMappings__arr27;
        [FieldOffset(0x168)] public InputKey mainMappings__arr28;
        [FieldOffset(0x16C)] public InputKey mainMappings__arr29;
        [FieldOffset(0x170)] public InputKey mainMappings__arr30;
        [FieldOffset(0x174)] public InputKey mainMappings__arr31;
        [FieldOffset(0x178)] public InputKey mainMappings__arr32;
        [FieldOffset(0x17C)] public InputKey mainMappings__arr33;
        [FieldOffset(0x180)] public InputKey mainMappings__arr34;
        [FieldOffset(0x184)] public InputKey mainMappings__arr35;
        [FieldOffset(0x188)] public InputKey mainMappings__arr36;
        [FieldOffset(0x18C)] public InputKey mainMappings__arr37;
        [FieldOffset(0x190)] public InputKey mainMappings__arr38;
        [FieldOffset(0x194)] public InputKey mainMappings__arr39;
        [FieldOffset(0x198)] public InputKey mainMappings__arr40;
        [FieldOffset(0x19C)] public InputKey mainMappings__arr41;
        [FieldOffset(0x1A0)] public InputKey mainMappings__arr42;
        [FieldOffset(0x1A4)] public InputKey mainMappings__arr43;
        [FieldOffset(0x1A8)] public InputKey mainMappings__arr44;
        [FieldOffset(0x1AC)] public InputKey mainMappings__arr45;
        [FieldOffset(0x1B0)] public InputKey mainMappings__arr46;
        [FieldOffset(0x1B4)] public InputKey mainMappings__arr47;
        [FieldOffset(0x1B8)] public InputKey mainMappings__arr48;
        [FieldOffset(0x1BC)] public InputKey mainMappings__arr49;
        [FieldOffset(0x1C0)] public InputKey mainMappings__arr50;
        [FieldOffset(0x1C4)] public InputKey mainMappings__arr51;
        [FieldOffset(0x1C8)] public InputKey mainMappings__arr52;
        [FieldOffset(0x1CC)] public InputKey mainMappings__arr53;
        [FieldOffset(0x1D0)] public InputKey mainMappings__arr54;
        [FieldOffset(0x1D4)] public InputKey mainMappings__arr55;
        [FieldOffset(0x1D8)] public InputKey mainMappings__arr56;
        [FieldOffset(0x1DC)] public InputKey mainMappings__arr57;
        [FieldOffset(0x1E0)] public InputKey mainMappings__arr58;
        [FieldOffset(0x1E4)] public InputKey mainMappings__arr59;
        [FieldOffset(0x1E8)] public InputKey mainMappings__arr60;
        [FieldOffset(0x1EC)] public InputKey mainMappings__arr61;
        [FieldOffset(0x1F0)] public InputKey subMappings__arr0;
        [FieldOffset(0x1F4)] public InputKey subMappings__arr1;
        [FieldOffset(0x1F8)] public InputKey subMappings__arr2;
        [FieldOffset(0x1FC)] public InputKey subMappings__arr3;
        [FieldOffset(0x200)] public InputKey subMappings__arr4;
        [FieldOffset(0x204)] public InputKey subMappings__arr5;
        [FieldOffset(0x208)] public InputKey subMappings__arr6;
        [FieldOffset(0x20C)] public InputKey subMappings__arr7;
        [FieldOffset(0x210)] public InputKey subMappings__arr8;
        [FieldOffset(0x214)] public InputKey subMappings__arr9;
        [FieldOffset(0x218)] public InputKey subMappings__arr10;
        [FieldOffset(0x21C)] public InputKey subMappings__arr11;
        [FieldOffset(0x220)] public InputKey subMappings__arr12;
        [FieldOffset(0x224)] public InputKey subMappings__arr13;
        [FieldOffset(0x228)] public InputKey subMappings__arr14;
        [FieldOffset(0x22C)] public InputKey subMappings__arr15;
        [FieldOffset(0x230)] public InputKey subMappings__arr16;
        [FieldOffset(0x234)] public InputKey subMappings__arr17;
        [FieldOffset(0x238)] public InputKey subMappings__arr18;
        [FieldOffset(0x23C)] public InputKey subMappings__arr19;
        [FieldOffset(0x240)] public InputKey subMappings__arr20;
        [FieldOffset(0x244)] public InputKey subMappings__arr21;
        [FieldOffset(0x248)] public InputKey subMappings__arr22;
        [FieldOffset(0x24C)] public InputKey subMappings__arr23;
        [FieldOffset(0x250)] public InputKey subMappings__arr24;
        [FieldOffset(0x254)] public InputKey subMappings__arr25;
        [FieldOffset(0x258)] public InputKey subMappings__arr26;
        [FieldOffset(0x25C)] public InputKey subMappings__arr27;
        [FieldOffset(0x260)] public InputKey subMappings__arr28;
        [FieldOffset(0x264)] public InputKey subMappings__arr29;
        [FieldOffset(0x268)] public InputKey subMappings__arr30;
        [FieldOffset(0x26C)] public InputKey subMappings__arr31;
        [FieldOffset(0x270)] public InputKey subMappings__arr32;
        [FieldOffset(0x274)] public InputKey subMappings__arr33;
        [FieldOffset(0x278)] public InputKey subMappings__arr34;
        [FieldOffset(0x27C)] public InputKey subMappings__arr35;
        [FieldOffset(0x280)] public InputKey subMappings__arr36;
        [FieldOffset(0x284)] public InputKey subMappings__arr37;
        [FieldOffset(0x288)] public InputKey subMappings__arr38;
        [FieldOffset(0x28C)] public InputKey subMappings__arr39;
        [FieldOffset(0x290)] public InputKey subMappings__arr40;
        [FieldOffset(0x294)] public InputKey subMappings__arr41;
        [FieldOffset(0x298)] public InputKey subMappings__arr42;
        [FieldOffset(0x29C)] public InputKey subMappings__arr43;
        [FieldOffset(0x2A0)] public InputKey subMappings__arr44;
        [FieldOffset(0x2A4)] public InputKey subMappings__arr45;
        [FieldOffset(0x2A8)] public InputKey subMappings__arr46;
        [FieldOffset(0x2AC)] public InputKey subMappings__arr47;
        [FieldOffset(0x2B0)] public InputKey subMappings__arr48;
        [FieldOffset(0x2B4)] public InputKey subMappings__arr49;
        [FieldOffset(0x2B8)] public InputKey subMappings__arr50;
        [FieldOffset(0x2BC)] public InputKey subMappings__arr51;
        [FieldOffset(0x2C0)] public InputKey subMappings__arr52;
        [FieldOffset(0x2C4)] public InputKey subMappings__arr53;
        [FieldOffset(0x2C8)] public InputKey subMappings__arr54;
        [FieldOffset(0x2CC)] public InputKey subMappings__arr55;
        [FieldOffset(0x2D0)] public InputKey subMappings__arr56;
        [FieldOffset(0x2D4)] public InputKey subMappings__arr57;
        [FieldOffset(0x2D8)] public InputKey subMappings__arr58;
        [FieldOffset(0x2DC)] public InputKey subMappings__arr59;
        [FieldOffset(0x2E0)] public InputKey subMappings__arr60;
        [FieldOffset(0x2E4)] public InputKey subMappings__arr61;
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

    public enum MusicSelect : sbyte
    {
        MUSIC_SELECT_ON = 0,
        MUSIC_SELECT_OFF = 1
    }

    public enum MusicSelectType : sbyte
    {
        MUSIC_SELECT_NORMAL = 0,
        MUSIC_SELECT_SHUFFLE = 1,
        MUSIC_SELECT_LOOP = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct OptionAudioData
    {
        [FieldOffset(0x00)] public byte masterVolume;
        [FieldOffset(0x01)] public byte sfxVolume;
        [FieldOffset(0x02)] public byte musicVolume;
        [FieldOffset(0x03)] public byte voiceVolume;
        [FieldOffset(0x04)] public MusicSelect musicSelectEnable;
        [FieldOffset(0x05)] public MusicSelectType musicSelectType;
        [FieldOffset(0x06)] public byte flags;
        [FieldOffset(0x07)] public byte padding;
        [FieldOffset(0x08)] public uint reserved__arr0;
        [FieldOffset(0x0C)] public uint reserved__arr1;
        [FieldOffset(0x10)] public uint reserved__arr2;
    }

    public enum Resolution : sbyte
    {
        Reso3840x2160 = 0,
        Reso2560x1440 = 1,
        Reso1920x1080 = 2,
        Reso1280x720 = 3
    }

    public enum GraphicQuality : sbyte
    {
        GraphicQuality_High = 0,
        GraphicQuality_Low = 1,
        Custom = 2
    }

    public enum FrameRate : sbyte
    {
        FPS60 = 0,
        FPS30 = 1,
        FPSNoLimit = 2
    }

    public enum AntiAliasing : sbyte
    {
        TAA = 0,
        FXAA = 1,
        AntiAliasing_None = 2
    }

    public enum AnisotropicFiltering : sbyte
    {
        AnisotropicFiltering_None = 0,
        AnisotropicFiltering_Low = 1,
        AnisotropicFiltering_Medium = 2,
        AnisotropicFiltering_High = 3
    }

    public enum DOF : sbyte
    {
        Disabled = 0,
        DOF_Low = 1,
        DOF_Medium = 2,
        DOF_High = 3
    }

    public enum Bloom : sbyte
    {
        Bloom_High = 0,
        Bloom_Low = 1
    }

    public enum Shadow : sbyte
    {
        Shadow_High = 0,
        Shadow_Low = 1
    }

    public enum VolumetricLight : sbyte
    {
        VolumetricLight_High = 0,
        VolumetricLight_Low = 1
    }

    public enum RederingScale : sbyte
    {
        RederingScale_High = 0,
        RederingScale_Medium = 1,
        RederingScale_Low = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct OptionGraphicsData
    {
        [FieldOffset(0x00)] public Resolution resolution;
        [FieldOffset(0x01)] public GraphicQuality graphicQuality;
        [FieldOffset(0x02)] public FrameRate frameRate;
        [FieldOffset(0x03)] public byte brightness;
        [FieldOffset(0x04)] public AntiAliasing antiAliasing;
        [FieldOffset(0x05)] public AnisotropicFiltering anisotropicFiltering;
        [FieldOffset(0x06)] public DOF depthOfField;
        [FieldOffset(0x07)] public Bloom bloom;
        [FieldOffset(0x08)] public byte config;
        [FieldOffset(0x09)] public byte hudVisible;
        [FieldOffset(0x0A)] public Shadow shadow;
        [FieldOffset(0x0B)] public VolumetricLight volumetricLight;
        [FieldOffset(0x0C)] public RederingScale renderingScale;
        [FieldOffset(0x0D)] public byte reserved1;
        [FieldOffset(0x0E)] public ushort width;
        [FieldOffset(0x10)] public ushort height;
        [FieldOffset(0x12)] public ushort padding0;
        [FieldOffset(0x14)] public uint reserved__arr0;
        [FieldOffset(0x18)] public uint reserved__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x390)]
    public struct OptionData
    {
        [FieldOffset(0x00)] public HeaderData header;
        [FieldOffset(0x28)] public OptionGamePlayData gameplay;
        [FieldOffset(0x48)] public OptionControlsData controls;
        [FieldOffset(0x330)] public OptionCameraData camera;
        [FieldOffset(0x360)] public OptionAudioData audio;
        [FieldOffset(0x374)] public OptionGraphicsData graphics;
    }

}