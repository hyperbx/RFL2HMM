using System.Numerics;
using System.Runtime.InteropServices;

public class PracticeParametersClass
{
    public enum Checker : sbyte
    {
        InvalidChecker = -1,
        CountActions = 0,
        CountAirTrick = 1,
        CountControlCamera = 2,
        CountInfinityCombo = 3,
        CountFiveCombo = 4,
        CountDefeatEnemies = 5,
        NumCheckers = 6
    }

    public enum Type : ushort
    {
        None = 0,
        ControlCamera = 1,
        Cyloop = 2,
        QuickCyloop = 3,
        FocusCamera = 4,
        Parry = 5,
        Avoid = 6,
        AcceleCombo = 7,
        Crasher = 8,
        HomingShot = 9,
        StompingAttack = 10,
        SonicBoom = 11,
        SpinSlash = 12,
        LoopKick = 13,
        CrossSlash = 14,
        ChargeAttack = 15,
        Smash = 16,
        RecoverySmash = 17,
        Jump = 18,
        DoubleJump = 19,
        HomingAttack = 20,
        Boost = 21,
        Stomping = 22,
        BoundStomping = 23,
        AirBoost = 24,
        QuickStep = 25,
        LightDash = 26,
        DropDash = 27,
        Sliding = 28,
        WallRun = 29,
        Discontinued = 30,
        AirTrick = 31,
        AirTrickEnd = 32,
        CancelHomingAttackBounceStomping = 33,
        CancelAirBoostStomping = 34,
        Squat = 35,
        SpinBoostCharge = 36,
        SpinBoost = 37,
        RunToSpinBoost = 38,
        SpinBoostAny = 39,
        AmyPropellerJump = 40,
        AmyTarotBoost = 41,
        AmyTarotAttack = 42,
        AmyTarotAttack2 = 43,
        AmyTarotRolling = 44,
        AmyCharmAttack = 45,
        AmyStomp = 46,
        AmyHighJump = 47,
        AmyCyHammer = 48,
        AmyTarotRollingInfinity = 49,
        AmyParryDebuff = 50,
        KnucklesGliding = 51,
        KnucklesDrillBoost = 52,
        KnucklesComboAttack1 = 53,
        KnucklesComboAttack2 = 54,
        KnucklesComboAttack3 = 55,
        KnucklesMaximumHeatKnuckle = 56,
        KnucklesStomp = 57,
        KnucklesCyKnuckle = 58,
        KnucklesGlidingInfinity = 59,
        KnucklesParryDebuff = 60,
        TailsFly = 61,
        TailsCycloneBoost = 62,
        TailsSpannerAttack = 63,
        TailsChargeSpanner = 64,
        TailsChargeSpannerJump = 65,
        TailsStomp = 66,
        TailsCyBlaster = 67,
        TailsCycloneCannon = 68,
        TailsParryDebuff = 69,
        DefeatEnemy = 70,
        Num = 71
    }

    public enum Judge : sbyte
    {
        Succeed = 0,
        Failed = 1,
        Skiped = 2,
        Waiting = 3,
        Unknown = 4,
        NumJudges = 5
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

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct PracticeAction
    {
        [FieldOffset(0x00)] public Type action;
        [FieldOffset(0x02)] public Judge dummy;
        [FieldOffset(0x08)] public ulong skipableActions;
        [FieldOffset(0x10)] public ulong skipableActions2;
        [FieldOffset(0x18)] public UnmanagedString label;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct PracticePrerequisite
    {
        [FieldOffset(0x00)] public ulong skill;
        [FieldOffset(0x08)] public ulong skill2;
        [FieldOffset(0x10)] public ulong clearedSubject;
        [FieldOffset(0x18)] public ulong clearedSubject2;
        [FieldOffset(0x20)] public ulong clearedSubject3;
        [FieldOffset(0x28)] public ulong clearedSubject4;
        [FieldOffset(0x30)] public bool unlockSpinBoost;
    }

    public enum Value : sbyte
    {
        Invalid = -1,
        Sonic = 0,
        Amy = 1,
        Knuckles = 2,
        Tails = 3,
        Value_Num = 4,
        Default = 0
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x140)]
    public struct PracticeSubject
    {
        [FieldOffset(0x00)] public Checker checker;
        [FieldOffset(0x08)] public PracticeAction actions__arr0;
        [FieldOffset(0x30)] public PracticeAction actions__arr1;
        [FieldOffset(0x58)] public PracticeAction actions__arr2;
        [FieldOffset(0x80)] public PracticeAction actions__arr3;
        [FieldOffset(0xA8)] public PracticeAction actions__arr4;
        [FieldOffset(0xD0)] public PracticeAction actions__arr5;
        [FieldOffset(0xF8)] public int count;
        [FieldOffset(0x100)] public PracticePrerequisite prerequisite;
        [FieldOffset(0x138)] public byte options;
        [FieldOffset(0x139)] public Value character;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct PracticeText
    {
        [FieldOffset(0x00)] public UnmanagedString labels__arr0;
        [FieldOffset(0xFF)] public UnmanagedString labels__arr1;
        [FieldOffset(0x1FE)] public UnmanagedString labels__arr2;
        [FieldOffset(0x2FD)] public UnmanagedString labels__arr3;
        [FieldOffset(0x3FC)] public UnmanagedString labels__arr4;
        [FieldOffset(0x4FB)] public UnmanagedString labels__arr5;
        [FieldOffset(0x5FA)] public UnmanagedString labels__arr6;
        [FieldOffset(0x6F9)] public UnmanagedString labels__arr7;
        [FieldOffset(0x7F8)] public UnmanagedString labels__arr8;
        [FieldOffset(0x8F7)] public UnmanagedString labels__arr9;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PracticeTime
    {
        [FieldOffset(0x00)] public float readyTime;
        [FieldOffset(0x04)] public float countTime;
        [FieldOffset(0x08)] public float subjectViewTime;
        [FieldOffset(0x0C)] public float clearedPostTime;
        [FieldOffset(0x10)] public float fadeoutWaitTime;
        [FieldOffset(0x14)] public float rebuildWaitTime1;
        [FieldOffset(0x18)] public float rebuildWaitTime2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PracticeTipsPrerequisite
    {
        [FieldOffset(0x00)] public ulong skill;
        [FieldOffset(0x08)] public ulong skill2;
        [FieldOffset(0x10)] public bool tutorialCleared;
        [FieldOffset(0x11)] public bool unlockArcadeMode;
        [FieldOffset(0x12)] public bool unlockCyberPowerBoost;
        [FieldOffset(0x13)] public bool unlockVeryHardMode;
        [FieldOffset(0x14)] public bool unlockStrongNewGame;
        [FieldOffset(0x15)] public bool unlockSpinBoost;
        [FieldOffset(0x16)] public bool masterKodamaCleared;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PracticeTips
    {
        [FieldOffset(0x00)] public PracticeTipsPrerequisite prerequisite;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xF0)]
    public struct PracticeSet
    {
        [FieldOffset(0x00)] public short subjects__arr0;
        [FieldOffset(0x02)] public short subjects__arr1;
        [FieldOffset(0x04)] public short subjects__arr2;
        [FieldOffset(0x06)] public short subjects__arr3;
        [FieldOffset(0x08)] public short subjects__arr4;
        [FieldOffset(0x0A)] public short subjects__arr5;
        [FieldOffset(0x0C)] public short subjects__arr6;
        [FieldOffset(0x0E)] public short subjects__arr7;
        [FieldOffset(0x10)] public short subjects__arr8;
        [FieldOffset(0x12)] public short subjects__arr9;
        [FieldOffset(0x14)] public short subjects__arr10;
        [FieldOffset(0x16)] public short subjects__arr11;
        [FieldOffset(0x18)] public short subjects__arr12;
        [FieldOffset(0x1A)] public short subjects__arr13;
        [FieldOffset(0x1C)] public short subjects__arr14;
        [FieldOffset(0x1E)] public short subjects__arr15;
        [FieldOffset(0x20)] public short subjects__arr16;
        [FieldOffset(0x22)] public short subjects__arr17;
        [FieldOffset(0x24)] public short subjects__arr18;
        [FieldOffset(0x26)] public short subjects__arr19;
        [FieldOffset(0x28)] public short tips__arr0;
        [FieldOffset(0x2A)] public short tips__arr1;
        [FieldOffset(0x2C)] public short tips__arr2;
        [FieldOffset(0x2E)] public short tips__arr3;
        [FieldOffset(0x30)] public short tips__arr4;
        [FieldOffset(0x32)] public short tips__arr5;
        [FieldOffset(0x34)] public short tips__arr6;
        [FieldOffset(0x36)] public short tips__arr7;
        [FieldOffset(0x38)] public short tips__arr8;
        [FieldOffset(0x3A)] public short tips__arr9;
        [FieldOffset(0x3C)] public short tips__arr10;
        [FieldOffset(0x3E)] public short tips__arr11;
        [FieldOffset(0x40)] public short tips__arr12;
        [FieldOffset(0x42)] public short tips__arr13;
        [FieldOffset(0x44)] public short tips__arr14;
        [FieldOffset(0x46)] public short tips__arr15;
        [FieldOffset(0x48)] public short tips__arr16;
        [FieldOffset(0x4A)] public short tips__arr17;
        [FieldOffset(0x4C)] public short tips__arr18;
        [FieldOffset(0x4E)] public short tips__arr19;
        [FieldOffset(0x50)] public short tips__arr20;
        [FieldOffset(0x52)] public short tips__arr21;
        [FieldOffset(0x54)] public short tips__arr22;
        [FieldOffset(0x56)] public short tips__arr23;
        [FieldOffset(0x58)] public short tips__arr24;
        [FieldOffset(0x5A)] public short tips__arr25;
        [FieldOffset(0x5C)] public short tips__arr26;
        [FieldOffset(0x5E)] public short tips__arr27;
        [FieldOffset(0x60)] public short tips__arr28;
        [FieldOffset(0x62)] public short tips__arr29;
        [FieldOffset(0x64)] public short tips__arr30;
        [FieldOffset(0x66)] public short tips__arr31;
        [FieldOffset(0x68)] public short tips__arr32;
        [FieldOffset(0x6A)] public short tips__arr33;
        [FieldOffset(0x6C)] public short tips__arr34;
        [FieldOffset(0x6E)] public short tips__arr35;
        [FieldOffset(0x70)] public short tips__arr36;
        [FieldOffset(0x72)] public short tips__arr37;
        [FieldOffset(0x74)] public short tips__arr38;
        [FieldOffset(0x76)] public short tips__arr39;
        [FieldOffset(0x78)] public short tips__arr40;
        [FieldOffset(0x7A)] public short tips__arr41;
        [FieldOffset(0x7C)] public short tips__arr42;
        [FieldOffset(0x7E)] public short tips__arr43;
        [FieldOffset(0x80)] public short tips__arr44;
        [FieldOffset(0x82)] public short tips__arr45;
        [FieldOffset(0x84)] public short tips__arr46;
        [FieldOffset(0x86)] public short tips__arr47;
        [FieldOffset(0x88)] public short tips__arr48;
        [FieldOffset(0x8A)] public short tips__arr49;
        [FieldOffset(0x8C)] public short tips__arr50;
        [FieldOffset(0x8E)] public short tips__arr51;
        [FieldOffset(0x90)] public short tips__arr52;
        [FieldOffset(0x92)] public short tips__arr53;
        [FieldOffset(0x94)] public short tips__arr54;
        [FieldOffset(0x96)] public short tips__arr55;
        [FieldOffset(0x98)] public short tips__arr56;
        [FieldOffset(0x9A)] public short tips__arr57;
        [FieldOffset(0x9C)] public short tips__arr58;
        [FieldOffset(0x9E)] public short tips__arr59;
        [FieldOffset(0xA0)] public short tips__arr60;
        [FieldOffset(0xA2)] public short tips__arr61;
        [FieldOffset(0xA4)] public short tips__arr62;
        [FieldOffset(0xA6)] public short tips__arr63;
        [FieldOffset(0xA8)] public short tips__arr64;
        [FieldOffset(0xAA)] public short tips__arr65;
        [FieldOffset(0xAC)] public short tips__arr66;
        [FieldOffset(0xAE)] public short tips__arr67;
        [FieldOffset(0xB0)] public short tips__arr68;
        [FieldOffset(0xB2)] public short tips__arr69;
        [FieldOffset(0xB4)] public short tips__arr70;
        [FieldOffset(0xB6)] public short tips__arr71;
        [FieldOffset(0xB8)] public short tips__arr72;
        [FieldOffset(0xBA)] public short tips__arr73;
        [FieldOffset(0xBC)] public short tips__arr74;
        [FieldOffset(0xBE)] public short tips__arr75;
        [FieldOffset(0xC0)] public short tips__arr76;
        [FieldOffset(0xC2)] public short tips__arr77;
        [FieldOffset(0xC4)] public short tips__arr78;
        [FieldOffset(0xC6)] public short tips__arr79;
        [FieldOffset(0xC8)] public short tips__arr80;
        [FieldOffset(0xCA)] public short tips__arr81;
        [FieldOffset(0xCC)] public short tips__arr82;
        [FieldOffset(0xCE)] public short tips__arr83;
        [FieldOffset(0xD0)] public short tips__arr84;
        [FieldOffset(0xD2)] public short tips__arr85;
        [FieldOffset(0xD4)] public short tips__arr86;
        [FieldOffset(0xD6)] public short tips__arr87;
        [FieldOffset(0xD8)] public short tips__arr88;
        [FieldOffset(0xDA)] public short tips__arr89;
        [FieldOffset(0xDC)] public short tips__arr90;
        [FieldOffset(0xDE)] public short tips__arr91;
        [FieldOffset(0xE0)] public short tips__arr92;
        [FieldOffset(0xE2)] public short tips__arr93;
        [FieldOffset(0xE4)] public short tips__arr94;
        [FieldOffset(0xE6)] public short tips__arr95;
        [FieldOffset(0xE8)] public short tips__arr96;
        [FieldOffset(0xEA)] public short tips__arr97;
        [FieldOffset(0xEC)] public short tips__arr98;
        [FieldOffset(0xEE)] public short tips__arr99;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1BC78)]
    public struct PracticeParameters
    {
        [FieldOffset(0x00)] public PracticeSubject subjects__arr0;
        [FieldOffset(0x140)] public PracticeSubject subjects__arr1;
        [FieldOffset(0x280)] public PracticeSubject subjects__arr2;
        [FieldOffset(0x3C0)] public PracticeSubject subjects__arr3;
        [FieldOffset(0x500)] public PracticeSubject subjects__arr4;
        [FieldOffset(0x640)] public PracticeSubject subjects__arr5;
        [FieldOffset(0x780)] public PracticeSubject subjects__arr6;
        [FieldOffset(0x8C0)] public PracticeSubject subjects__arr7;
        [FieldOffset(0xA00)] public PracticeSubject subjects__arr8;
        [FieldOffset(0xB40)] public PracticeSubject subjects__arr9;
        [FieldOffset(0xC80)] public PracticeSubject subjects__arr10;
        [FieldOffset(0xDC0)] public PracticeSubject subjects__arr11;
        [FieldOffset(0xF00)] public PracticeSubject subjects__arr12;
        [FieldOffset(0x1040)] public PracticeSubject subjects__arr13;
        [FieldOffset(0x1180)] public PracticeSubject subjects__arr14;
        [FieldOffset(0x12C0)] public PracticeSubject subjects__arr15;
        [FieldOffset(0x1400)] public PracticeSubject subjects__arr16;
        [FieldOffset(0x1540)] public PracticeSubject subjects__arr17;
        [FieldOffset(0x1680)] public PracticeSubject subjects__arr18;
        [FieldOffset(0x17C0)] public PracticeSubject subjects__arr19;
        [FieldOffset(0x1900)] public PracticeSubject subjects__arr20;
        [FieldOffset(0x1A40)] public PracticeSubject subjects__arr21;
        [FieldOffset(0x1B80)] public PracticeSubject subjects__arr22;
        [FieldOffset(0x1CC0)] public PracticeSubject subjects__arr23;
        [FieldOffset(0x1E00)] public PracticeSubject subjects__arr24;
        [FieldOffset(0x1F40)] public PracticeSubject subjects__arr25;
        [FieldOffset(0x2080)] public PracticeSubject subjects__arr26;
        [FieldOffset(0x21C0)] public PracticeSubject subjects__arr27;
        [FieldOffset(0x2300)] public PracticeSubject subjects__arr28;
        [FieldOffset(0x2440)] public PracticeSubject subjects__arr29;
        [FieldOffset(0x2580)] public PracticeSubject subjects__arr30;
        [FieldOffset(0x26C0)] public PracticeSubject subjects__arr31;
        [FieldOffset(0x2800)] public PracticeSubject subjects__arr32;
        [FieldOffset(0x2940)] public PracticeSubject subjects__arr33;
        [FieldOffset(0x2A80)] public PracticeSubject subjects__arr34;
        [FieldOffset(0x2BC0)] public PracticeSubject subjects__arr35;
        [FieldOffset(0x2D00)] public PracticeSubject subjects__arr36;
        [FieldOffset(0x2E40)] public PracticeSubject subjects__arr37;
        [FieldOffset(0x2F80)] public PracticeSubject subjects__arr38;
        [FieldOffset(0x30C0)] public PracticeSubject subjects__arr39;
        [FieldOffset(0x3200)] public PracticeSubject subjects__arr40;
        [FieldOffset(0x3340)] public PracticeSubject subjects__arr41;
        [FieldOffset(0x3480)] public PracticeSubject subjects__arr42;
        [FieldOffset(0x35C0)] public PracticeSubject subjects__arr43;
        [FieldOffset(0x3700)] public PracticeSubject subjects__arr44;
        [FieldOffset(0x3840)] public PracticeSubject subjects__arr45;
        [FieldOffset(0x3980)] public PracticeSubject subjects__arr46;
        [FieldOffset(0x3AC0)] public PracticeSubject subjects__arr47;
        [FieldOffset(0x3C00)] public PracticeSubject subjects__arr48;
        [FieldOffset(0x3D40)] public PracticeSubject subjects__arr49;
        [FieldOffset(0x3E80)] public PracticeSubject subjects__arr50;
        [FieldOffset(0x3FC0)] public PracticeSubject subjects__arr51;
        [FieldOffset(0x4100)] public PracticeSubject subjects__arr52;
        [FieldOffset(0x4240)] public PracticeSubject subjects__arr53;
        [FieldOffset(0x4380)] public PracticeSubject subjects__arr54;
        [FieldOffset(0x44C0)] public PracticeSubject subjects__arr55;
        [FieldOffset(0x4600)] public PracticeSubject subjects__arr56;
        [FieldOffset(0x4740)] public PracticeSubject subjects__arr57;
        [FieldOffset(0x4880)] public PracticeSubject subjects__arr58;
        [FieldOffset(0x49C0)] public PracticeSubject subjects__arr59;
        [FieldOffset(0x4B00)] public PracticeSubject subjects__arr60;
        [FieldOffset(0x4C40)] public PracticeSubject subjects__arr61;
        [FieldOffset(0x4D80)] public PracticeSubject subjects__arr62;
        [FieldOffset(0x4EC0)] public PracticeSubject subjects__arr63;
        [FieldOffset(0x5000)] public PracticeSubject subjects__arr64;
        [FieldOffset(0x5140)] public PracticeSubject subjects__arr65;
        [FieldOffset(0x5280)] public PracticeSubject subjects__arr66;
        [FieldOffset(0x53C0)] public PracticeSubject subjects__arr67;
        [FieldOffset(0x5500)] public PracticeSubject subjects__arr68;
        [FieldOffset(0x5640)] public PracticeSubject subjects__arr69;
        [FieldOffset(0x5780)] public PracticeSubject subjects__arr70;
        [FieldOffset(0x58C0)] public PracticeSubject subjects__arr71;
        [FieldOffset(0x5A00)] public PracticeSubject subjects__arr72;
        [FieldOffset(0x5B40)] public PracticeSubject subjects__arr73;
        [FieldOffset(0x5C80)] public PracticeSubject subjects__arr74;
        [FieldOffset(0x5DC0)] public PracticeSubject subjects__arr75;
        [FieldOffset(0x5F00)] public PracticeSubject subjects__arr76;
        [FieldOffset(0x6040)] public PracticeSubject subjects__arr77;
        [FieldOffset(0x6180)] public PracticeSubject subjects__arr78;
        [FieldOffset(0x62C0)] public PracticeSubject subjects__arr79;
        [FieldOffset(0x6400)] public PracticeSubject subjects__arr80;
        [FieldOffset(0x6540)] public PracticeSubject subjects__arr81;
        [FieldOffset(0x6680)] public PracticeSubject subjects__arr82;
        [FieldOffset(0x67C0)] public PracticeSubject subjects__arr83;
        [FieldOffset(0x6900)] public PracticeSubject subjects__arr84;
        [FieldOffset(0x6A40)] public PracticeSubject subjects__arr85;
        [FieldOffset(0x6B80)] public PracticeSubject subjects__arr86;
        [FieldOffset(0x6CC0)] public PracticeSubject subjects__arr87;
        [FieldOffset(0x6E00)] public PracticeSubject subjects__arr88;
        [FieldOffset(0x6F40)] public PracticeSubject subjects__arr89;
        [FieldOffset(0x7080)] public PracticeSubject subjects__arr90;
        [FieldOffset(0x71C0)] public PracticeSubject subjects__arr91;
        [FieldOffset(0x7300)] public PracticeSubject subjects__arr92;
        [FieldOffset(0x7440)] public PracticeSubject subjects__arr93;
        [FieldOffset(0x7580)] public PracticeSubject subjects__arr94;
        [FieldOffset(0x76C0)] public PracticeSubject subjects__arr95;
        [FieldOffset(0x7800)] public PracticeSubject subjects__arr96;
        [FieldOffset(0x7940)] public PracticeSubject subjects__arr97;
        [FieldOffset(0x7A80)] public PracticeSubject subjects__arr98;
        [FieldOffset(0x7BC0)] public PracticeSubject subjects__arr99;
        [FieldOffset(0x7D00)] public PracticeSubject subjects__arr100;
        [FieldOffset(0x7E40)] public PracticeSubject subjects__arr101;
        [FieldOffset(0x7F80)] public PracticeSubject subjects__arr102;
        [FieldOffset(0x80C0)] public PracticeSubject subjects__arr103;
        [FieldOffset(0x8200)] public PracticeSubject subjects__arr104;
        [FieldOffset(0x8340)] public PracticeSubject subjects__arr105;
        [FieldOffset(0x8480)] public PracticeSubject subjects__arr106;
        [FieldOffset(0x85C0)] public PracticeSubject subjects__arr107;
        [FieldOffset(0x8700)] public PracticeSubject subjects__arr108;
        [FieldOffset(0x8840)] public PracticeSubject subjects__arr109;
        [FieldOffset(0x8980)] public PracticeSubject subjects__arr110;
        [FieldOffset(0x8AC0)] public PracticeSubject subjects__arr111;
        [FieldOffset(0x8C00)] public PracticeSubject subjects__arr112;
        [FieldOffset(0x8D40)] public PracticeSubject subjects__arr113;
        [FieldOffset(0x8E80)] public PracticeSubject subjects__arr114;
        [FieldOffset(0x8FC0)] public PracticeSubject subjects__arr115;
        [FieldOffset(0x9100)] public PracticeSubject subjects__arr116;
        [FieldOffset(0x9240)] public PracticeSubject subjects__arr117;
        [FieldOffset(0x9380)] public PracticeSubject subjects__arr118;
        [FieldOffset(0x94C0)] public PracticeSubject subjects__arr119;
        [FieldOffset(0x9600)] public PracticeSubject subjects__arr120;
        [FieldOffset(0x9740)] public PracticeSubject subjects__arr121;
        [FieldOffset(0x9880)] public PracticeSubject subjects__arr122;
        [FieldOffset(0x99C0)] public PracticeSubject subjects__arr123;
        [FieldOffset(0x9B00)] public PracticeSubject subjects__arr124;
        [FieldOffset(0x9C40)] public PracticeSubject subjects__arr125;
        [FieldOffset(0x9D80)] public PracticeSubject subjects__arr126;
        [FieldOffset(0x9EC0)] public PracticeSubject subjects__arr127;
        [FieldOffset(0xA000)] public PracticeSubject subjects__arr128;
        [FieldOffset(0xA140)] public PracticeSubject subjects__arr129;
        [FieldOffset(0xA280)] public PracticeSubject subjects__arr130;
        [FieldOffset(0xA3C0)] public PracticeSubject subjects__arr131;
        [FieldOffset(0xA500)] public PracticeSubject subjects__arr132;
        [FieldOffset(0xA640)] public PracticeSubject subjects__arr133;
        [FieldOffset(0xA780)] public PracticeSubject subjects__arr134;
        [FieldOffset(0xA8C0)] public PracticeSubject subjects__arr135;
        [FieldOffset(0xAA00)] public PracticeSubject subjects__arr136;
        [FieldOffset(0xAB40)] public PracticeSubject subjects__arr137;
        [FieldOffset(0xAC80)] public PracticeSubject subjects__arr138;
        [FieldOffset(0xADC0)] public PracticeSubject subjects__arr139;
        [FieldOffset(0xAF00)] public PracticeSubject subjects__arr140;
        [FieldOffset(0xB040)] public PracticeSubject subjects__arr141;
        [FieldOffset(0xB180)] public PracticeSubject subjects__arr142;
        [FieldOffset(0xB2C0)] public PracticeSubject subjects__arr143;
        [FieldOffset(0xB400)] public PracticeSubject subjects__arr144;
        [FieldOffset(0xB540)] public PracticeSubject subjects__arr145;
        [FieldOffset(0xB680)] public PracticeSubject subjects__arr146;
        [FieldOffset(0xB7C0)] public PracticeSubject subjects__arr147;
        [FieldOffset(0xB900)] public PracticeSubject subjects__arr148;
        [FieldOffset(0xBA40)] public PracticeSubject subjects__arr149;
        [FieldOffset(0xBB80)] public PracticeSubject subjects__arr150;
        [FieldOffset(0xBCC0)] public PracticeSubject subjects__arr151;
        [FieldOffset(0xBE00)] public PracticeSubject subjects__arr152;
        [FieldOffset(0xBF40)] public PracticeSubject subjects__arr153;
        [FieldOffset(0xC080)] public PracticeSubject subjects__arr154;
        [FieldOffset(0xC1C0)] public PracticeSubject subjects__arr155;
        [FieldOffset(0xC300)] public PracticeSubject subjects__arr156;
        [FieldOffset(0xC440)] public PracticeSubject subjects__arr157;
        [FieldOffset(0xC580)] public PracticeSubject subjects__arr158;
        [FieldOffset(0xC6C0)] public PracticeSubject subjects__arr159;
        [FieldOffset(0xC800)] public PracticeSubject subjects__arr160;
        [FieldOffset(0xC940)] public PracticeSubject subjects__arr161;
        [FieldOffset(0xCA80)] public PracticeSubject subjects__arr162;
        [FieldOffset(0xCBC0)] public PracticeSubject subjects__arr163;
        [FieldOffset(0xCD00)] public PracticeSubject subjects__arr164;
        [FieldOffset(0xCE40)] public PracticeSubject subjects__arr165;
        [FieldOffset(0xCF80)] public PracticeSubject subjects__arr166;
        [FieldOffset(0xD0C0)] public PracticeSubject subjects__arr167;
        [FieldOffset(0xD200)] public PracticeSubject subjects__arr168;
        [FieldOffset(0xD340)] public PracticeSubject subjects__arr169;
        [FieldOffset(0xD480)] public PracticeSubject subjects__arr170;
        [FieldOffset(0xD5C0)] public PracticeSubject subjects__arr171;
        [FieldOffset(0xD700)] public PracticeSubject subjects__arr172;
        [FieldOffset(0xD840)] public PracticeSubject subjects__arr173;
        [FieldOffset(0xD980)] public PracticeSubject subjects__arr174;
        [FieldOffset(0xDAC0)] public PracticeSubject subjects__arr175;
        [FieldOffset(0xDC00)] public PracticeSubject subjects__arr176;
        [FieldOffset(0xDD40)] public PracticeSubject subjects__arr177;
        [FieldOffset(0xDE80)] public PracticeSubject subjects__arr178;
        [FieldOffset(0xDFC0)] public PracticeSubject subjects__arr179;
        [FieldOffset(0xE100)] public PracticeSubject subjects__arr180;
        [FieldOffset(0xE240)] public PracticeSubject subjects__arr181;
        [FieldOffset(0xE380)] public PracticeSubject subjects__arr182;
        [FieldOffset(0xE4C0)] public PracticeSubject subjects__arr183;
        [FieldOffset(0xE600)] public PracticeSubject subjects__arr184;
        [FieldOffset(0xE740)] public PracticeSubject subjects__arr185;
        [FieldOffset(0xE880)] public PracticeSubject subjects__arr186;
        [FieldOffset(0xE9C0)] public PracticeSubject subjects__arr187;
        [FieldOffset(0xEB00)] public PracticeSubject subjects__arr188;
        [FieldOffset(0xEC40)] public PracticeSubject subjects__arr189;
        [FieldOffset(0xED80)] public PracticeSubject subjects__arr190;
        [FieldOffset(0xEEC0)] public PracticeSubject subjects__arr191;
        [FieldOffset(0xF000)] public PracticeSubject subjects__arr192;
        [FieldOffset(0xF140)] public PracticeSubject subjects__arr193;
        [FieldOffset(0xF280)] public PracticeSubject subjects__arr194;
        [FieldOffset(0xF3C0)] public PracticeSubject subjects__arr195;
        [FieldOffset(0xF500)] public PracticeSubject subjects__arr196;
        [FieldOffset(0xF640)] public PracticeSubject subjects__arr197;
        [FieldOffset(0xF780)] public PracticeSubject subjects__arr198;
        [FieldOffset(0xF8C0)] public PracticeSubject subjects__arr199;
        [FieldOffset(0xFA00)] public PracticeText text;
        [FieldOffset(0xFAA0)] public PracticeTime time;
        [FieldOffset(0xFABC)] public float notifyTime;
        [FieldOffset(0xFAC0)] public PracticeTips tips__arr0;
        [FieldOffset(0xFAD8)] public PracticeTips tips__arr1;
        [FieldOffset(0xFAF0)] public PracticeTips tips__arr2;
        [FieldOffset(0xFB08)] public PracticeTips tips__arr3;
        [FieldOffset(0xFB20)] public PracticeTips tips__arr4;
        [FieldOffset(0xFB38)] public PracticeTips tips__arr5;
        [FieldOffset(0xFB50)] public PracticeTips tips__arr6;
        [FieldOffset(0xFB68)] public PracticeTips tips__arr7;
        [FieldOffset(0xFB80)] public PracticeTips tips__arr8;
        [FieldOffset(0xFB98)] public PracticeTips tips__arr9;
        [FieldOffset(0xFBB0)] public PracticeTips tips__arr10;
        [FieldOffset(0xFBC8)] public PracticeTips tips__arr11;
        [FieldOffset(0xFBE0)] public PracticeTips tips__arr12;
        [FieldOffset(0xFBF8)] public PracticeTips tips__arr13;
        [FieldOffset(0xFC10)] public PracticeTips tips__arr14;
        [FieldOffset(0xFC28)] public PracticeTips tips__arr15;
        [FieldOffset(0xFC40)] public PracticeTips tips__arr16;
        [FieldOffset(0xFC58)] public PracticeTips tips__arr17;
        [FieldOffset(0xFC70)] public PracticeTips tips__arr18;
        [FieldOffset(0xFC88)] public PracticeTips tips__arr19;
        [FieldOffset(0xFCA0)] public PracticeTips tips__arr20;
        [FieldOffset(0xFCB8)] public PracticeTips tips__arr21;
        [FieldOffset(0xFCD0)] public PracticeTips tips__arr22;
        [FieldOffset(0xFCE8)] public PracticeTips tips__arr23;
        [FieldOffset(0xFD00)] public PracticeTips tips__arr24;
        [FieldOffset(0xFD18)] public PracticeTips tips__arr25;
        [FieldOffset(0xFD30)] public PracticeTips tips__arr26;
        [FieldOffset(0xFD48)] public PracticeTips tips__arr27;
        [FieldOffset(0xFD60)] public PracticeTips tips__arr28;
        [FieldOffset(0xFD78)] public PracticeTips tips__arr29;
        [FieldOffset(0xFD90)] public PracticeTips tips__arr30;
        [FieldOffset(0xFDA8)] public PracticeTips tips__arr31;
        [FieldOffset(0xFDC0)] public PracticeTips tips__arr32;
        [FieldOffset(0xFDD8)] public PracticeTips tips__arr33;
        [FieldOffset(0xFDF0)] public PracticeTips tips__arr34;
        [FieldOffset(0xFE08)] public PracticeTips tips__arr35;
        [FieldOffset(0xFE20)] public PracticeTips tips__arr36;
        [FieldOffset(0xFE38)] public PracticeTips tips__arr37;
        [FieldOffset(0xFE50)] public PracticeTips tips__arr38;
        [FieldOffset(0xFE68)] public PracticeTips tips__arr39;
        [FieldOffset(0xFE80)] public PracticeTips tips__arr40;
        [FieldOffset(0xFE98)] public PracticeTips tips__arr41;
        [FieldOffset(0xFEB0)] public PracticeTips tips__arr42;
        [FieldOffset(0xFEC8)] public PracticeTips tips__arr43;
        [FieldOffset(0xFEE0)] public PracticeTips tips__arr44;
        [FieldOffset(0xFEF8)] public PracticeTips tips__arr45;
        [FieldOffset(0xFF10)] public PracticeTips tips__arr46;
        [FieldOffset(0xFF28)] public PracticeTips tips__arr47;
        [FieldOffset(0xFF40)] public PracticeTips tips__arr48;
        [FieldOffset(0xFF58)] public PracticeTips tips__arr49;
        [FieldOffset(0xFF70)] public PracticeTips tips__arr50;
        [FieldOffset(0xFF88)] public PracticeTips tips__arr51;
        [FieldOffset(0xFFA0)] public PracticeTips tips__arr52;
        [FieldOffset(0xFFB8)] public PracticeTips tips__arr53;
        [FieldOffset(0xFFD0)] public PracticeTips tips__arr54;
        [FieldOffset(0xFFE8)] public PracticeTips tips__arr55;
        [FieldOffset(0x10000)] public PracticeTips tips__arr56;
        [FieldOffset(0x10018)] public PracticeTips tips__arr57;
        [FieldOffset(0x10030)] public PracticeTips tips__arr58;
        [FieldOffset(0x10048)] public PracticeTips tips__arr59;
        [FieldOffset(0x10060)] public PracticeTips tips__arr60;
        [FieldOffset(0x10078)] public PracticeTips tips__arr61;
        [FieldOffset(0x10090)] public PracticeTips tips__arr62;
        [FieldOffset(0x100A8)] public PracticeTips tips__arr63;
        [FieldOffset(0x100C0)] public PracticeTips tips__arr64;
        [FieldOffset(0x100D8)] public PracticeTips tips__arr65;
        [FieldOffset(0x100F0)] public PracticeTips tips__arr66;
        [FieldOffset(0x10108)] public PracticeTips tips__arr67;
        [FieldOffset(0x10120)] public PracticeTips tips__arr68;
        [FieldOffset(0x10138)] public PracticeTips tips__arr69;
        [FieldOffset(0x10150)] public PracticeTips tips__arr70;
        [FieldOffset(0x10168)] public PracticeTips tips__arr71;
        [FieldOffset(0x10180)] public PracticeTips tips__arr72;
        [FieldOffset(0x10198)] public PracticeTips tips__arr73;
        [FieldOffset(0x101B0)] public PracticeTips tips__arr74;
        [FieldOffset(0x101C8)] public PracticeTips tips__arr75;
        [FieldOffset(0x101E0)] public PracticeTips tips__arr76;
        [FieldOffset(0x101F8)] public PracticeTips tips__arr77;
        [FieldOffset(0x10210)] public PracticeTips tips__arr78;
        [FieldOffset(0x10228)] public PracticeTips tips__arr79;
        [FieldOffset(0x10240)] public PracticeTips tips__arr80;
        [FieldOffset(0x10258)] public PracticeTips tips__arr81;
        [FieldOffset(0x10270)] public PracticeTips tips__arr82;
        [FieldOffset(0x10288)] public PracticeTips tips__arr83;
        [FieldOffset(0x102A0)] public PracticeTips tips__arr84;
        [FieldOffset(0x102B8)] public PracticeTips tips__arr85;
        [FieldOffset(0x102D0)] public PracticeTips tips__arr86;
        [FieldOffset(0x102E8)] public PracticeTips tips__arr87;
        [FieldOffset(0x10300)] public PracticeTips tips__arr88;
        [FieldOffset(0x10318)] public PracticeTips tips__arr89;
        [FieldOffset(0x10330)] public PracticeTips tips__arr90;
        [FieldOffset(0x10348)] public PracticeTips tips__arr91;
        [FieldOffset(0x10360)] public PracticeTips tips__arr92;
        [FieldOffset(0x10378)] public PracticeTips tips__arr93;
        [FieldOffset(0x10390)] public PracticeTips tips__arr94;
        [FieldOffset(0x103A8)] public PracticeTips tips__arr95;
        [FieldOffset(0x103C0)] public PracticeTips tips__arr96;
        [FieldOffset(0x103D8)] public PracticeTips tips__arr97;
        [FieldOffset(0x103F0)] public PracticeTips tips__arr98;
        [FieldOffset(0x10408)] public PracticeTips tips__arr99;
        [FieldOffset(0x10420)] public PracticeTips tips__arr100;
        [FieldOffset(0x10438)] public PracticeTips tips__arr101;
        [FieldOffset(0x10450)] public PracticeTips tips__arr102;
        [FieldOffset(0x10468)] public PracticeTips tips__arr103;
        [FieldOffset(0x10480)] public PracticeTips tips__arr104;
        [FieldOffset(0x10498)] public PracticeTips tips__arr105;
        [FieldOffset(0x104B0)] public PracticeTips tips__arr106;
        [FieldOffset(0x104C8)] public PracticeTips tips__arr107;
        [FieldOffset(0x104E0)] public PracticeTips tips__arr108;
        [FieldOffset(0x104F8)] public PracticeTips tips__arr109;
        [FieldOffset(0x10510)] public PracticeTips tips__arr110;
        [FieldOffset(0x10528)] public PracticeTips tips__arr111;
        [FieldOffset(0x10540)] public PracticeTips tips__arr112;
        [FieldOffset(0x10558)] public PracticeTips tips__arr113;
        [FieldOffset(0x10570)] public PracticeTips tips__arr114;
        [FieldOffset(0x10588)] public PracticeTips tips__arr115;
        [FieldOffset(0x105A0)] public PracticeTips tips__arr116;
        [FieldOffset(0x105B8)] public PracticeTips tips__arr117;
        [FieldOffset(0x105D0)] public PracticeTips tips__arr118;
        [FieldOffset(0x105E8)] public PracticeTips tips__arr119;
        [FieldOffset(0x10600)] public PracticeTips tips__arr120;
        [FieldOffset(0x10618)] public PracticeTips tips__arr121;
        [FieldOffset(0x10630)] public PracticeTips tips__arr122;
        [FieldOffset(0x10648)] public PracticeTips tips__arr123;
        [FieldOffset(0x10660)] public PracticeTips tips__arr124;
        [FieldOffset(0x10678)] public PracticeTips tips__arr125;
        [FieldOffset(0x10690)] public PracticeTips tips__arr126;
        [FieldOffset(0x106A8)] public PracticeTips tips__arr127;
        [FieldOffset(0x106C0)] public PracticeTips tips__arr128;
        [FieldOffset(0x106D8)] public PracticeTips tips__arr129;
        [FieldOffset(0x106F0)] public PracticeTips tips__arr130;
        [FieldOffset(0x10708)] public PracticeTips tips__arr131;
        [FieldOffset(0x10720)] public PracticeTips tips__arr132;
        [FieldOffset(0x10738)] public PracticeTips tips__arr133;
        [FieldOffset(0x10750)] public PracticeTips tips__arr134;
        [FieldOffset(0x10768)] public PracticeTips tips__arr135;
        [FieldOffset(0x10780)] public PracticeTips tips__arr136;
        [FieldOffset(0x10798)] public PracticeTips tips__arr137;
        [FieldOffset(0x107B0)] public PracticeTips tips__arr138;
        [FieldOffset(0x107C8)] public PracticeTips tips__arr139;
        [FieldOffset(0x107E0)] public PracticeTips tips__arr140;
        [FieldOffset(0x107F8)] public PracticeTips tips__arr141;
        [FieldOffset(0x10810)] public PracticeTips tips__arr142;
        [FieldOffset(0x10828)] public PracticeTips tips__arr143;
        [FieldOffset(0x10840)] public PracticeTips tips__arr144;
        [FieldOffset(0x10858)] public PracticeTips tips__arr145;
        [FieldOffset(0x10870)] public PracticeTips tips__arr146;
        [FieldOffset(0x10888)] public PracticeTips tips__arr147;
        [FieldOffset(0x108A0)] public PracticeTips tips__arr148;
        [FieldOffset(0x108B8)] public PracticeTips tips__arr149;
        [FieldOffset(0x108D0)] public PracticeTips tips__arr150;
        [FieldOffset(0x108E8)] public PracticeTips tips__arr151;
        [FieldOffset(0x10900)] public PracticeTips tips__arr152;
        [FieldOffset(0x10918)] public PracticeTips tips__arr153;
        [FieldOffset(0x10930)] public PracticeTips tips__arr154;
        [FieldOffset(0x10948)] public PracticeTips tips__arr155;
        [FieldOffset(0x10960)] public PracticeTips tips__arr156;
        [FieldOffset(0x10978)] public PracticeTips tips__arr157;
        [FieldOffset(0x10990)] public PracticeTips tips__arr158;
        [FieldOffset(0x109A8)] public PracticeTips tips__arr159;
        [FieldOffset(0x109C0)] public PracticeTips tips__arr160;
        [FieldOffset(0x109D8)] public PracticeTips tips__arr161;
        [FieldOffset(0x109F0)] public PracticeTips tips__arr162;
        [FieldOffset(0x10A08)] public PracticeTips tips__arr163;
        [FieldOffset(0x10A20)] public PracticeTips tips__arr164;
        [FieldOffset(0x10A38)] public PracticeTips tips__arr165;
        [FieldOffset(0x10A50)] public PracticeTips tips__arr166;
        [FieldOffset(0x10A68)] public PracticeTips tips__arr167;
        [FieldOffset(0x10A80)] public PracticeTips tips__arr168;
        [FieldOffset(0x10A98)] public PracticeTips tips__arr169;
        [FieldOffset(0x10AB0)] public PracticeTips tips__arr170;
        [FieldOffset(0x10AC8)] public PracticeTips tips__arr171;
        [FieldOffset(0x10AE0)] public PracticeTips tips__arr172;
        [FieldOffset(0x10AF8)] public PracticeTips tips__arr173;
        [FieldOffset(0x10B10)] public PracticeTips tips__arr174;
        [FieldOffset(0x10B28)] public PracticeTips tips__arr175;
        [FieldOffset(0x10B40)] public PracticeTips tips__arr176;
        [FieldOffset(0x10B58)] public PracticeTips tips__arr177;
        [FieldOffset(0x10B70)] public PracticeTips tips__arr178;
        [FieldOffset(0x10B88)] public PracticeTips tips__arr179;
        [FieldOffset(0x10BA0)] public PracticeTips tips__arr180;
        [FieldOffset(0x10BB8)] public PracticeTips tips__arr181;
        [FieldOffset(0x10BD0)] public PracticeTips tips__arr182;
        [FieldOffset(0x10BE8)] public PracticeTips tips__arr183;
        [FieldOffset(0x10C00)] public PracticeTips tips__arr184;
        [FieldOffset(0x10C18)] public PracticeTips tips__arr185;
        [FieldOffset(0x10C30)] public PracticeTips tips__arr186;
        [FieldOffset(0x10C48)] public PracticeTips tips__arr187;
        [FieldOffset(0x10C60)] public PracticeTips tips__arr188;
        [FieldOffset(0x10C78)] public PracticeTips tips__arr189;
        [FieldOffset(0x10C90)] public PracticeTips tips__arr190;
        [FieldOffset(0x10CA8)] public PracticeTips tips__arr191;
        [FieldOffset(0x10CC0)] public PracticeTips tips__arr192;
        [FieldOffset(0x10CD8)] public PracticeTips tips__arr193;
        [FieldOffset(0x10CF0)] public PracticeTips tips__arr194;
        [FieldOffset(0x10D08)] public PracticeTips tips__arr195;
        [FieldOffset(0x10D20)] public PracticeTips tips__arr196;
        [FieldOffset(0x10D38)] public PracticeTips tips__arr197;
        [FieldOffset(0x10D50)] public PracticeTips tips__arr198;
        [FieldOffset(0x10D68)] public PracticeTips tips__arr199;
        [FieldOffset(0x10D80)] public PracticeTips tips__arr200;
        [FieldOffset(0x10D98)] public PracticeTips tips__arr201;
        [FieldOffset(0x10DB0)] public PracticeTips tips__arr202;
        [FieldOffset(0x10DC8)] public PracticeTips tips__arr203;
        [FieldOffset(0x10DE0)] public PracticeTips tips__arr204;
        [FieldOffset(0x10DF8)] public PracticeTips tips__arr205;
        [FieldOffset(0x10E10)] public PracticeTips tips__arr206;
        [FieldOffset(0x10E28)] public PracticeTips tips__arr207;
        [FieldOffset(0x10E40)] public PracticeTips tips__arr208;
        [FieldOffset(0x10E58)] public PracticeTips tips__arr209;
        [FieldOffset(0x10E70)] public PracticeTips tips__arr210;
        [FieldOffset(0x10E88)] public PracticeTips tips__arr211;
        [FieldOffset(0x10EA0)] public PracticeTips tips__arr212;
        [FieldOffset(0x10EB8)] public PracticeTips tips__arr213;
        [FieldOffset(0x10ED0)] public PracticeTips tips__arr214;
        [FieldOffset(0x10EE8)] public PracticeTips tips__arr215;
        [FieldOffset(0x10F00)] public PracticeTips tips__arr216;
        [FieldOffset(0x10F18)] public PracticeTips tips__arr217;
        [FieldOffset(0x10F30)] public PracticeTips tips__arr218;
        [FieldOffset(0x10F48)] public PracticeTips tips__arr219;
        [FieldOffset(0x10F60)] public PracticeTips tips__arr220;
        [FieldOffset(0x10F78)] public PracticeTips tips__arr221;
        [FieldOffset(0x10F90)] public PracticeTips tips__arr222;
        [FieldOffset(0x10FA8)] public PracticeTips tips__arr223;
        [FieldOffset(0x10FC0)] public PracticeTips tips__arr224;
        [FieldOffset(0x10FD8)] public PracticeTips tips__arr225;
        [FieldOffset(0x10FF0)] public PracticeTips tips__arr226;
        [FieldOffset(0x11008)] public PracticeTips tips__arr227;
        [FieldOffset(0x11020)] public PracticeTips tips__arr228;
        [FieldOffset(0x11038)] public PracticeTips tips__arr229;
        [FieldOffset(0x11050)] public PracticeTips tips__arr230;
        [FieldOffset(0x11068)] public PracticeTips tips__arr231;
        [FieldOffset(0x11080)] public PracticeTips tips__arr232;
        [FieldOffset(0x11098)] public PracticeTips tips__arr233;
        [FieldOffset(0x110B0)] public PracticeTips tips__arr234;
        [FieldOffset(0x110C8)] public PracticeTips tips__arr235;
        [FieldOffset(0x110E0)] public PracticeTips tips__arr236;
        [FieldOffset(0x110F8)] public PracticeTips tips__arr237;
        [FieldOffset(0x11110)] public PracticeTips tips__arr238;
        [FieldOffset(0x11128)] public PracticeTips tips__arr239;
        [FieldOffset(0x11140)] public PracticeTips tips__arr240;
        [FieldOffset(0x11158)] public PracticeTips tips__arr241;
        [FieldOffset(0x11170)] public PracticeTips tips__arr242;
        [FieldOffset(0x11188)] public PracticeTips tips__arr243;
        [FieldOffset(0x111A0)] public PracticeTips tips__arr244;
        [FieldOffset(0x111B8)] public PracticeTips tips__arr245;
        [FieldOffset(0x111D0)] public PracticeTips tips__arr246;
        [FieldOffset(0x111E8)] public PracticeTips tips__arr247;
        [FieldOffset(0x11200)] public PracticeTips tips__arr248;
        [FieldOffset(0x11218)] public PracticeTips tips__arr249;
        [FieldOffset(0x11230)] public PracticeTips tips__arr250;
        [FieldOffset(0x11248)] public PracticeTips tips__arr251;
        [FieldOffset(0x11260)] public PracticeTips tips__arr252;
        [FieldOffset(0x11278)] public PracticeTips tips__arr253;
        [FieldOffset(0x11290)] public PracticeTips tips__arr254;
        [FieldOffset(0x112A8)] public PracticeTips tips__arr255;
        [FieldOffset(0x112C0)] public float tipsMinViewTime;
        [FieldOffset(0x112C4)] public PracticeSet sets__arr0;
        [FieldOffset(0x113B4)] public PracticeSet sets__arr1;
        [FieldOffset(0x114A4)] public PracticeSet sets__arr2;
        [FieldOffset(0x11594)] public PracticeSet sets__arr3;
        [FieldOffset(0x11684)] public PracticeSet sets__arr4;
        [FieldOffset(0x11774)] public PracticeSet sets__arr5;
        [FieldOffset(0x11864)] public PracticeSet sets__arr6;
        [FieldOffset(0x11954)] public PracticeSet sets__arr7;
        [FieldOffset(0x11A44)] public PracticeSet sets__arr8;
        [FieldOffset(0x11B34)] public PracticeSet sets__arr9;
        [FieldOffset(0x11C24)] public PracticeSet sets__arr10;
        [FieldOffset(0x11D14)] public PracticeSet sets__arr11;
        [FieldOffset(0x11E04)] public PracticeSet sets__arr12;
        [FieldOffset(0x11EF4)] public PracticeSet sets__arr13;
        [FieldOffset(0x11FE4)] public PracticeSet sets__arr14;
        [FieldOffset(0x120D4)] public PracticeSet sets__arr15;
        [FieldOffset(0x121C4)] public PracticeSet sets__arr16;
        [FieldOffset(0x122B4)] public PracticeSet sets__arr17;
        [FieldOffset(0x123A4)] public PracticeSet sets__arr18;
        [FieldOffset(0x12494)] public PracticeSet sets__arr19;
        [FieldOffset(0x12584)] public PracticeSet sets__arr20;
        [FieldOffset(0x12674)] public PracticeSet sets__arr21;
        [FieldOffset(0x12764)] public PracticeSet sets__arr22;
        [FieldOffset(0x12854)] public PracticeSet sets__arr23;
        [FieldOffset(0x12944)] public PracticeSet sets__arr24;
        [FieldOffset(0x12A34)] public PracticeSet sets__arr25;
        [FieldOffset(0x12B24)] public PracticeSet sets__arr26;
        [FieldOffset(0x12C14)] public PracticeSet sets__arr27;
        [FieldOffset(0x12D04)] public PracticeSet sets__arr28;
        [FieldOffset(0x12DF4)] public PracticeSet sets__arr29;
        [FieldOffset(0x12EE4)] public PracticeSet sets__arr30;
        [FieldOffset(0x12FD4)] public PracticeSet sets__arr31;
        [FieldOffset(0x130C4)] public PracticeSet sets__arr32;
        [FieldOffset(0x131B4)] public PracticeSet sets__arr33;
        [FieldOffset(0x132A4)] public PracticeSet sets__arr34;
        [FieldOffset(0x13394)] public PracticeSet sets__arr35;
        [FieldOffset(0x13484)] public PracticeSet sets__arr36;
        [FieldOffset(0x13574)] public PracticeSet sets__arr37;
        [FieldOffset(0x13664)] public PracticeSet sets__arr38;
        [FieldOffset(0x13754)] public PracticeSet sets__arr39;
        [FieldOffset(0x13844)] public PracticeSet sets__arr40;
        [FieldOffset(0x13934)] public PracticeSet sets__arr41;
        [FieldOffset(0x13A24)] public PracticeSet sets__arr42;
        [FieldOffset(0x13B14)] public PracticeSet sets__arr43;
        [FieldOffset(0x13C04)] public PracticeSet sets__arr44;
        [FieldOffset(0x13CF4)] public PracticeSet sets__arr45;
        [FieldOffset(0x13DE4)] public PracticeSet sets__arr46;
        [FieldOffset(0x13ED4)] public PracticeSet sets__arr47;
        [FieldOffset(0x13FC4)] public PracticeSet sets__arr48;
        [FieldOffset(0x140B4)] public PracticeSet sets__arr49;
        [FieldOffset(0x141A4)] public PracticeSet sets__arr50;
        [FieldOffset(0x14294)] public PracticeSet sets__arr51;
        [FieldOffset(0x14384)] public PracticeSet sets__arr52;
        [FieldOffset(0x14474)] public PracticeSet sets__arr53;
        [FieldOffset(0x14564)] public PracticeSet sets__arr54;
        [FieldOffset(0x14654)] public PracticeSet sets__arr55;
        [FieldOffset(0x14744)] public PracticeSet sets__arr56;
        [FieldOffset(0x14834)] public PracticeSet sets__arr57;
        [FieldOffset(0x14924)] public PracticeSet sets__arr58;
        [FieldOffset(0x14A14)] public PracticeSet sets__arr59;
        [FieldOffset(0x14B04)] public PracticeSet sets__arr60;
        [FieldOffset(0x14BF4)] public PracticeSet sets__arr61;
        [FieldOffset(0x14CE4)] public PracticeSet sets__arr62;
        [FieldOffset(0x14DD4)] public PracticeSet sets__arr63;
        [FieldOffset(0x14EC4)] public PracticeSet sets__arr64;
        [FieldOffset(0x14FB4)] public PracticeSet sets__arr65;
        [FieldOffset(0x150A4)] public PracticeSet sets__arr66;
        [FieldOffset(0x15194)] public PracticeSet sets__arr67;
        [FieldOffset(0x15284)] public PracticeSet sets__arr68;
        [FieldOffset(0x15374)] public PracticeSet sets__arr69;
        [FieldOffset(0x15464)] public PracticeSet sets__arr70;
        [FieldOffset(0x15554)] public PracticeSet sets__arr71;
        [FieldOffset(0x15644)] public PracticeSet sets__arr72;
        [FieldOffset(0x15734)] public PracticeSet sets__arr73;
        [FieldOffset(0x15824)] public PracticeSet sets__arr74;
        [FieldOffset(0x15914)] public PracticeSet sets__arr75;
        [FieldOffset(0x15A04)] public PracticeSet sets__arr76;
        [FieldOffset(0x15AF4)] public PracticeSet sets__arr77;
        [FieldOffset(0x15BE4)] public PracticeSet sets__arr78;
        [FieldOffset(0x15CD4)] public PracticeSet sets__arr79;
        [FieldOffset(0x15DC4)] public PracticeSet sets__arr80;
        [FieldOffset(0x15EB4)] public PracticeSet sets__arr81;
        [FieldOffset(0x15FA4)] public PracticeSet sets__arr82;
        [FieldOffset(0x16094)] public PracticeSet sets__arr83;
        [FieldOffset(0x16184)] public PracticeSet sets__arr84;
        [FieldOffset(0x16274)] public PracticeSet sets__arr85;
        [FieldOffset(0x16364)] public PracticeSet sets__arr86;
        [FieldOffset(0x16454)] public PracticeSet sets__arr87;
        [FieldOffset(0x16544)] public PracticeSet sets__arr88;
        [FieldOffset(0x16634)] public PracticeSet sets__arr89;
        [FieldOffset(0x16724)] public PracticeSet sets__arr90;
        [FieldOffset(0x16814)] public PracticeSet sets__arr91;
        [FieldOffset(0x16904)] public PracticeSet sets__arr92;
        [FieldOffset(0x169F4)] public PracticeSet sets__arr93;
        [FieldOffset(0x16AE4)] public PracticeSet sets__arr94;
        [FieldOffset(0x16BD4)] public PracticeSet sets__arr95;
        [FieldOffset(0x16CC4)] public PracticeSet sets__arr96;
        [FieldOffset(0x16DB4)] public PracticeSet sets__arr97;
        [FieldOffset(0x16EA4)] public PracticeSet sets__arr98;
        [FieldOffset(0x16F94)] public PracticeSet sets__arr99;
        [FieldOffset(0x17084)] public PracticeSet sets__arr100;
        [FieldOffset(0x17174)] public PracticeSet sets__arr101;
        [FieldOffset(0x17264)] public PracticeSet sets__arr102;
        [FieldOffset(0x17354)] public PracticeSet sets__arr103;
        [FieldOffset(0x17444)] public PracticeSet sets__arr104;
        [FieldOffset(0x17534)] public PracticeSet sets__arr105;
        [FieldOffset(0x17624)] public PracticeSet sets__arr106;
        [FieldOffset(0x17714)] public PracticeSet sets__arr107;
        [FieldOffset(0x17804)] public PracticeSet sets__arr108;
        [FieldOffset(0x178F4)] public PracticeSet sets__arr109;
        [FieldOffset(0x179E4)] public PracticeSet sets__arr110;
        [FieldOffset(0x17AD4)] public PracticeSet sets__arr111;
        [FieldOffset(0x17BC4)] public PracticeSet sets__arr112;
        [FieldOffset(0x17CB4)] public PracticeSet sets__arr113;
        [FieldOffset(0x17DA4)] public PracticeSet sets__arr114;
        [FieldOffset(0x17E94)] public PracticeSet sets__arr115;
        [FieldOffset(0x17F84)] public PracticeSet sets__arr116;
        [FieldOffset(0x18074)] public PracticeSet sets__arr117;
        [FieldOffset(0x18164)] public PracticeSet sets__arr118;
        [FieldOffset(0x18254)] public PracticeSet sets__arr119;
        [FieldOffset(0x18344)] public PracticeSet sets__arr120;
        [FieldOffset(0x18434)] public PracticeSet sets__arr121;
        [FieldOffset(0x18524)] public PracticeSet sets__arr122;
        [FieldOffset(0x18614)] public PracticeSet sets__arr123;
        [FieldOffset(0x18704)] public PracticeSet sets__arr124;
        [FieldOffset(0x187F4)] public PracticeSet sets__arr125;
        [FieldOffset(0x188E4)] public PracticeSet sets__arr126;
        [FieldOffset(0x189D4)] public PracticeSet sets__arr127;
        [FieldOffset(0x18AC4)] public PracticeSet sets__arr128;
        [FieldOffset(0x18BB4)] public PracticeSet sets__arr129;
        [FieldOffset(0x18CA4)] public PracticeSet sets__arr130;
        [FieldOffset(0x18D94)] public PracticeSet sets__arr131;
        [FieldOffset(0x18E84)] public PracticeSet sets__arr132;
        [FieldOffset(0x18F74)] public PracticeSet sets__arr133;
        [FieldOffset(0x19064)] public PracticeSet sets__arr134;
        [FieldOffset(0x19154)] public PracticeSet sets__arr135;
        [FieldOffset(0x19244)] public PracticeSet sets__arr136;
        [FieldOffset(0x19334)] public PracticeSet sets__arr137;
        [FieldOffset(0x19424)] public PracticeSet sets__arr138;
        [FieldOffset(0x19514)] public PracticeSet sets__arr139;
        [FieldOffset(0x19604)] public PracticeSet sets__arr140;
        [FieldOffset(0x196F4)] public PracticeSet sets__arr141;
        [FieldOffset(0x197E4)] public PracticeSet sets__arr142;
        [FieldOffset(0x198D4)] public PracticeSet sets__arr143;
        [FieldOffset(0x199C4)] public PracticeSet sets__arr144;
        [FieldOffset(0x19AB4)] public PracticeSet sets__arr145;
        [FieldOffset(0x19BA4)] public PracticeSet sets__arr146;
        [FieldOffset(0x19C94)] public PracticeSet sets__arr147;
        [FieldOffset(0x19D84)] public PracticeSet sets__arr148;
        [FieldOffset(0x19E74)] public PracticeSet sets__arr149;
        [FieldOffset(0x19F64)] public PracticeSet sets__arr150;
        [FieldOffset(0x1A054)] public PracticeSet sets__arr151;
        [FieldOffset(0x1A144)] public PracticeSet sets__arr152;
        [FieldOffset(0x1A234)] public PracticeSet sets__arr153;
        [FieldOffset(0x1A324)] public PracticeSet sets__arr154;
        [FieldOffset(0x1A414)] public PracticeSet sets__arr155;
        [FieldOffset(0x1A504)] public PracticeSet sets__arr156;
        [FieldOffset(0x1A5F4)] public PracticeSet sets__arr157;
        [FieldOffset(0x1A6E4)] public PracticeSet sets__arr158;
        [FieldOffset(0x1A7D4)] public PracticeSet sets__arr159;
        [FieldOffset(0x1A8C4)] public PracticeSet sets__arr160;
        [FieldOffset(0x1A9B4)] public PracticeSet sets__arr161;
        [FieldOffset(0x1AAA4)] public PracticeSet sets__arr162;
        [FieldOffset(0x1AB94)] public PracticeSet sets__arr163;
        [FieldOffset(0x1AC84)] public PracticeSet sets__arr164;
        [FieldOffset(0x1AD74)] public PracticeSet sets__arr165;
        [FieldOffset(0x1AE64)] public PracticeSet sets__arr166;
        [FieldOffset(0x1AF54)] public PracticeSet sets__arr167;
        [FieldOffset(0x1B044)] public PracticeSet sets__arr168;
        [FieldOffset(0x1B134)] public PracticeSet sets__arr169;
        [FieldOffset(0x1B224)] public PracticeSet sets__arr170;
        [FieldOffset(0x1B314)] public PracticeSet sets__arr171;
        [FieldOffset(0x1B404)] public PracticeSet sets__arr172;
        [FieldOffset(0x1B4F4)] public PracticeSet sets__arr173;
        [FieldOffset(0x1B5E4)] public PracticeSet sets__arr174;
        [FieldOffset(0x1B6D4)] public PracticeSet sets__arr175;
        [FieldOffset(0x1B7C4)] public PracticeSet sets__arr176;
        [FieldOffset(0x1B8B4)] public PracticeSet sets__arr177;
        [FieldOffset(0x1B9A4)] public PracticeSet sets__arr178;
        [FieldOffset(0x1BA94)] public PracticeSet sets__arr179;
        [FieldOffset(0x1BB84)] public PracticeSet sets__arr180;
    }

}