using System.Numerics;
using System.Runtime.InteropServices;

public class GameSkillParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x03)]
    public struct SkillParam
    {
        [FieldOffset(0x00)] public byte unlockPoint;
        [FieldOffset(0x01)] public byte addUnlockPoint;
        [FieldOffset(0x02)] public bool present;
    }

    public enum Value : sbyte
    {
        BeginSonicSkill = 0,
        Cyloop = 0,
        Smash = 1,
        QuickCyloop = 2,
        AcceleLevel = 3,
        ChargeAttack = 4,
        RecoverySmash = 5,
        AirTrick = 6,
        SonicBoom = 7,
        Crasher = 8,
        LoopKick = 9,
        SpinSlash = 10,
        StompingAttack = 11,
        HomingShot = 12,
        CrossSlash = 13,
        AutoCombo = 14,
        NumUsed = 15,
        Dummy0 = 15,
        CrossSlash2 = 15,
        Dummy1 = 16,
        Dummy2 = 17,
        Dummy3 = 18,
        Dummy4 = 19,
        Num = 20,
        BeginAmySkill = 20,
        AmyJump = 20,
        AmyPropellerJump = 21,
        AmyHomingAtatck = 22,
        AmyBoost = 23,
        AmyPowerBoost = 24,
        AmyTarotAttack = 25,
        AmyTarotRolling = 26,
        AmyCharmAttack = 27,
        AmyStomp = 28,
        AmyHighJump = 29,
        AmyCyHammer = 30,
        AmyTarotRollingInfinity = 31,
        AmySpinDash = 32,
        AmyParry = 33,
        AmyParryDebuff = 34,
        AmyCyloop = 35,
        AmyDoubleJump = 36,
        AmyNumUsed = 37,
        AmyDummy0 = 37,
        AmyDummy1 = 38,
        AmyDummy2 = 39,
        AmyNum = 40,
        BeginKnucklesSkill = 40,
        KnucklesJump = 40,
        KnucklesGliding = 41,
        KnucklesHomingAtatck = 42,
        KnucklesBoost = 43,
        KnucklesWallRun = 44,
        KnucklesPowerBoost = 45,
        KnucklesComboAttack = 46,
        KnucklesMaximumHeatKnuckle = 47,
        KnucklesStomp = 48,
        KnucklesCyKnuckle = 49,
        KnucklesGlidingInfinity = 50,
        KnucklesSpinDash = 51,
        KnucklesParry = 52,
        KnucklesDoubleJump = 53,
        KnucklesParryDebuff = 54,
        KnucklesCyloop = 55,
        KnucklesNumUsed = 56,
        KnucklesDummy0 = 56,
        KnucklesDummy1 = 57,
        KnucklesDummy2 = 58,
        KnucklesDummy3 = 59,
        KnucklesNum = 60,
        BeginTailsSkill = 60,
        TailsJump = 60,
        TailsFly = 61,
        TailsHomingAtatck = 62,
        TailsBoost = 63,
        TailsPowerBoost = 64,
        TailsSpannerAttack = 65,
        TailsChargeSpanner = 66,
        TailsStomp = 67,
        TailsCyBlaster = 68,
        TailsCycloneCannon = 69,
        TailsSpinDash = 70,
        TailsParry = 71,
        TailsDoubleJump = 72,
        TailsParryDebuff = 73,
        TailsCyloop = 74,
        TailsNumUsed = 75,
        TailsDummy0 = 75,
        TailsDummy1 = 76,
        TailsDummy2 = 77,
        TailsDummy3 = 78,
        TailsDummy4 = 79,
        TailsNum = 80,
        AllNum = 80,
        Invalid = -1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x03)]
    public struct SkillLinkSetting
    {
        [FieldOffset(0x00)] public bool down;
        [FieldOffset(0x01)] public bool left;
        [FieldOffset(0x02)] public bool right;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x05)]
    public struct SkillNodeParam
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public Value skill;
        [FieldOffset(0x02)] public SkillLinkSetting link;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x97)]
    public struct SkillTreeParam
    {
        [FieldOffset(0x00)] public SkillNodeParam nodeParams__arr0;
        [FieldOffset(0x05)] public SkillNodeParam nodeParams__arr1;
        [FieldOffset(0x0A)] public SkillNodeParam nodeParams__arr2;
        [FieldOffset(0x0F)] public SkillNodeParam nodeParams__arr3;
        [FieldOffset(0x14)] public SkillNodeParam nodeParams__arr4;
        [FieldOffset(0x19)] public SkillNodeParam nodeParams__arr5;
        [FieldOffset(0x1E)] public SkillNodeParam nodeParams__arr6;
        [FieldOffset(0x23)] public SkillNodeParam nodeParams__arr7;
        [FieldOffset(0x28)] public SkillNodeParam nodeParams__arr8;
        [FieldOffset(0x2D)] public SkillNodeParam nodeParams__arr9;
        [FieldOffset(0x32)] public SkillNodeParam nodeParams__arr10;
        [FieldOffset(0x37)] public SkillNodeParam nodeParams__arr11;
        [FieldOffset(0x3C)] public SkillNodeParam nodeParams__arr12;
        [FieldOffset(0x41)] public SkillNodeParam nodeParams__arr13;
        [FieldOffset(0x46)] public SkillNodeParam nodeParams__arr14;
        [FieldOffset(0x4B)] public SkillNodeParam nodeParams__arr15;
        [FieldOffset(0x50)] public SkillNodeParam nodeParams__arr16;
        [FieldOffset(0x55)] public SkillNodeParam nodeParams__arr17;
        [FieldOffset(0x5A)] public SkillNodeParam nodeParams__arr18;
        [FieldOffset(0x5F)] public SkillNodeParam nodeParams__arr19;
        [FieldOffset(0x64)] public SkillNodeParam nodeParams__arr20;
        [FieldOffset(0x69)] public SkillNodeParam nodeParams__arr21;
        [FieldOffset(0x6E)] public SkillNodeParam nodeParams__arr22;
        [FieldOffset(0x73)] public SkillNodeParam nodeParams__arr23;
        [FieldOffset(0x78)] public SkillNodeParam nodeParams__arr24;
        [FieldOffset(0x7D)] public SkillNodeParam nodeParams__arr25;
        [FieldOffset(0x82)] public SkillNodeParam nodeParams__arr26;
        [FieldOffset(0x87)] public SkillNodeParam nodeParams__arr27;
        [FieldOffset(0x8C)] public SkillNodeParam nodeParams__arr28;
        [FieldOffset(0x91)] public SkillNodeParam nodeParams__arr29;
        [FieldOffset(0x96)] public sbyte startIndex;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34C)]
    public struct GameSkillParameter
    {
        [FieldOffset(0x00)] public SkillParam skillParams__arr0;
        [FieldOffset(0x03)] public SkillParam skillParams__arr1;
        [FieldOffset(0x06)] public SkillParam skillParams__arr2;
        [FieldOffset(0x09)] public SkillParam skillParams__arr3;
        [FieldOffset(0x0C)] public SkillParam skillParams__arr4;
        [FieldOffset(0x0F)] public SkillParam skillParams__arr5;
        [FieldOffset(0x12)] public SkillParam skillParams__arr6;
        [FieldOffset(0x15)] public SkillParam skillParams__arr7;
        [FieldOffset(0x18)] public SkillParam skillParams__arr8;
        [FieldOffset(0x1B)] public SkillParam skillParams__arr9;
        [FieldOffset(0x1E)] public SkillParam skillParams__arr10;
        [FieldOffset(0x21)] public SkillParam skillParams__arr11;
        [FieldOffset(0x24)] public SkillParam skillParams__arr12;
        [FieldOffset(0x27)] public SkillParam skillParams__arr13;
        [FieldOffset(0x2A)] public SkillParam skillParams__arr14;
        [FieldOffset(0x2D)] public SkillParam skillParams__arr15;
        [FieldOffset(0x30)] public SkillParam skillParams__arr16;
        [FieldOffset(0x33)] public SkillParam skillParams__arr17;
        [FieldOffset(0x36)] public SkillParam skillParams__arr18;
        [FieldOffset(0x39)] public SkillParam skillParams__arr19;
        [FieldOffset(0x3C)] public SkillParam skillParams__arr20;
        [FieldOffset(0x3F)] public SkillParam skillParams__arr21;
        [FieldOffset(0x42)] public SkillParam skillParams__arr22;
        [FieldOffset(0x45)] public SkillParam skillParams__arr23;
        [FieldOffset(0x48)] public SkillParam skillParams__arr24;
        [FieldOffset(0x4B)] public SkillParam skillParams__arr25;
        [FieldOffset(0x4E)] public SkillParam skillParams__arr26;
        [FieldOffset(0x51)] public SkillParam skillParams__arr27;
        [FieldOffset(0x54)] public SkillParam skillParams__arr28;
        [FieldOffset(0x57)] public SkillParam skillParams__arr29;
        [FieldOffset(0x5A)] public SkillParam skillParams__arr30;
        [FieldOffset(0x5D)] public SkillParam skillParams__arr31;
        [FieldOffset(0x60)] public SkillParam skillParams__arr32;
        [FieldOffset(0x63)] public SkillParam skillParams__arr33;
        [FieldOffset(0x66)] public SkillParam skillParams__arr34;
        [FieldOffset(0x69)] public SkillParam skillParams__arr35;
        [FieldOffset(0x6C)] public SkillParam skillParams__arr36;
        [FieldOffset(0x6F)] public SkillParam skillParams__arr37;
        [FieldOffset(0x72)] public SkillParam skillParams__arr38;
        [FieldOffset(0x75)] public SkillParam skillParams__arr39;
        [FieldOffset(0x78)] public SkillParam skillParams__arr40;
        [FieldOffset(0x7B)] public SkillParam skillParams__arr41;
        [FieldOffset(0x7E)] public SkillParam skillParams__arr42;
        [FieldOffset(0x81)] public SkillParam skillParams__arr43;
        [FieldOffset(0x84)] public SkillParam skillParams__arr44;
        [FieldOffset(0x87)] public SkillParam skillParams__arr45;
        [FieldOffset(0x8A)] public SkillParam skillParams__arr46;
        [FieldOffset(0x8D)] public SkillParam skillParams__arr47;
        [FieldOffset(0x90)] public SkillParam skillParams__arr48;
        [FieldOffset(0x93)] public SkillParam skillParams__arr49;
        [FieldOffset(0x96)] public SkillParam skillParams__arr50;
        [FieldOffset(0x99)] public SkillParam skillParams__arr51;
        [FieldOffset(0x9C)] public SkillParam skillParams__arr52;
        [FieldOffset(0x9F)] public SkillParam skillParams__arr53;
        [FieldOffset(0xA2)] public SkillParam skillParams__arr54;
        [FieldOffset(0xA5)] public SkillParam skillParams__arr55;
        [FieldOffset(0xA8)] public SkillParam skillParams__arr56;
        [FieldOffset(0xAB)] public SkillParam skillParams__arr57;
        [FieldOffset(0xAE)] public SkillParam skillParams__arr58;
        [FieldOffset(0xB1)] public SkillParam skillParams__arr59;
        [FieldOffset(0xB4)] public SkillParam skillParams__arr60;
        [FieldOffset(0xB7)] public SkillParam skillParams__arr61;
        [FieldOffset(0xBA)] public SkillParam skillParams__arr62;
        [FieldOffset(0xBD)] public SkillParam skillParams__arr63;
        [FieldOffset(0xC0)] public SkillParam skillParams__arr64;
        [FieldOffset(0xC3)] public SkillParam skillParams__arr65;
        [FieldOffset(0xC6)] public SkillParam skillParams__arr66;
        [FieldOffset(0xC9)] public SkillParam skillParams__arr67;
        [FieldOffset(0xCC)] public SkillParam skillParams__arr68;
        [FieldOffset(0xCF)] public SkillParam skillParams__arr69;
        [FieldOffset(0xD2)] public SkillParam skillParams__arr70;
        [FieldOffset(0xD5)] public SkillParam skillParams__arr71;
        [FieldOffset(0xD8)] public SkillParam skillParams__arr72;
        [FieldOffset(0xDB)] public SkillParam skillParams__arr73;
        [FieldOffset(0xDE)] public SkillParam skillParams__arr74;
        [FieldOffset(0xE1)] public SkillParam skillParams__arr75;
        [FieldOffset(0xE4)] public SkillParam skillParams__arr76;
        [FieldOffset(0xE7)] public SkillParam skillParams__arr77;
        [FieldOffset(0xEA)] public SkillParam skillParams__arr78;
        [FieldOffset(0xED)] public SkillParam skillParams__arr79;
        [FieldOffset(0xF0)] public SkillTreeParam treeParams;
        [FieldOffset(0x187)] public SkillTreeParam treeParamsAmy;
        [FieldOffset(0x21E)] public SkillTreeParam treeParamsKnuckles;
        [FieldOffset(0x2B5)] public SkillTreeParam treeParamsTails;
    }

}