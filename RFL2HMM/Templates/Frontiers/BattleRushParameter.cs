using System.Numerics;
using System.Runtime.InteropServices;

public class BattleRushParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BattleRushPhaseRankParameter
    {
        [FieldOffset(0x00)] public uint rankTime__arr0;
        [FieldOffset(0x04)] public uint rankTime__arr1;
        [FieldOffset(0x08)] public uint rankTime__arr2;
        [FieldOffset(0x0C)] public uint rankTime__arr3;
        [FieldOffset(0x10)] public uint rankTimeAll__arr0;
        [FieldOffset(0x14)] public uint rankTimeAll__arr1;
        [FieldOffset(0x18)] public uint rankTimeAll__arr2;
        [FieldOffset(0x1C)] public uint rankTimeAll__arr3;
    }

    public enum BgmType : sbyte
    {
        INVALID = -1,
        ENEMY_BATTLE = 0,
        FORCE_BATTLE_FIELD = 1,
        MINIBOSS_CHARGER_BATTLE = 2,
        MINIBOSS_DARUMA_BATTLE = 3,
        MINIBOSS_SPIDER_BATTLE = 4,
        MINIBOSS_BLADE_BATTLE = 5,
        MINIBOSS_FLYER_BATTLE = 6,
        MINIBOSS_TRACKER_BATTLE = 7,
        MINIBOSS_ASHURA_BATTLE = 8,
        MINIBOSS_SKIER_BATTLE = 9,
        MINIBOSS_SUMO_BATTLE = 10,
        MINIBOSS_TYRANT_BATTLE = 11,
        MINIBOSS_STRIDER_BATTLE = 12,
        MINIBOSS_WARSHIP_BATTLE = 13,
        ENEMY_AQUABALL = 14,
        TUTORIAL_BLADE_BATTLE = 15
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1FC)]
    public struct BattleRushStageParameter
    {
        [FieldOffset(0x00)] public uint numPhases;
        [FieldOffset(0x04)] public float phaseLimitTime__arr0;
        [FieldOffset(0x08)] public float phaseLimitTime__arr1;
        [FieldOffset(0x0C)] public float phaseLimitTime__arr2;
        [FieldOffset(0x10)] public float phaseLimitTime__arr3;
        [FieldOffset(0x14)] public float phaseLimitTime__arr4;
        [FieldOffset(0x18)] public float phaseLimitTime__arr5;
        [FieldOffset(0x1C)] public float phaseLimitTime__arr6;
        [FieldOffset(0x20)] public float phaseLimitTime__arr7;
        [FieldOffset(0x24)] public float phaseLimitTime__arr8;
        [FieldOffset(0x28)] public float phaseLimitTime__arr9;
        [FieldOffset(0x2C)] public float phaseLimitTime__arr10;
        [FieldOffset(0x30)] public float phaseClearedTime__arr0;
        [FieldOffset(0x34)] public float phaseClearedTime__arr1;
        [FieldOffset(0x38)] public float phaseClearedTime__arr2;
        [FieldOffset(0x3C)] public float phaseClearedTime__arr3;
        [FieldOffset(0x40)] public float phaseClearedTime__arr4;
        [FieldOffset(0x44)] public float phaseClearedTime__arr5;
        [FieldOffset(0x48)] public float phaseClearedTime__arr6;
        [FieldOffset(0x4C)] public float phaseClearedTime__arr7;
        [FieldOffset(0x50)] public float phaseClearedTime__arr8;
        [FieldOffset(0x54)] public float phaseClearedTime__arr9;
        [FieldOffset(0x58)] public float phaseClearedTime__arr10;
        [FieldOffset(0x5C)] public float phaseResultTime__arr0;
        [FieldOffset(0x60)] public float phaseResultTime__arr1;
        [FieldOffset(0x64)] public float phaseResultTime__arr2;
        [FieldOffset(0x68)] public float phaseResultTime__arr3;
        [FieldOffset(0x6C)] public float phaseResultTime__arr4;
        [FieldOffset(0x70)] public float phaseResultTime__arr5;
        [FieldOffset(0x74)] public float phaseResultTime__arr6;
        [FieldOffset(0x78)] public float phaseResultTime__arr7;
        [FieldOffset(0x7C)] public float phaseResultTime__arr8;
        [FieldOffset(0x80)] public float phaseResultTime__arr9;
        [FieldOffset(0x84)] public float phaseResultTime__arr10;
        [FieldOffset(0x88)] public BattleRushPhaseRankParameter phaseRank__arr0;
        [FieldOffset(0xA8)] public BattleRushPhaseRankParameter phaseRank__arr1;
        [FieldOffset(0xC8)] public BattleRushPhaseRankParameter phaseRank__arr2;
        [FieldOffset(0xE8)] public BattleRushPhaseRankParameter phaseRank__arr3;
        [FieldOffset(0x108)] public BattleRushPhaseRankParameter phaseRank__arr4;
        [FieldOffset(0x128)] public BattleRushPhaseRankParameter phaseRank__arr5;
        [FieldOffset(0x148)] public BattleRushPhaseRankParameter phaseRank__arr6;
        [FieldOffset(0x168)] public BattleRushPhaseRankParameter phaseRank__arr7;
        [FieldOffset(0x188)] public BattleRushPhaseRankParameter phaseRank__arr8;
        [FieldOffset(0x1A8)] public BattleRushPhaseRankParameter phaseRank__arr9;
        [FieldOffset(0x1C8)] public BattleRushPhaseRankParameter phaseRank__arr10;
        [FieldOffset(0x1E8)] public BgmType phaseBgmType__arr0;
        [FieldOffset(0x1E9)] public BgmType phaseBgmType__arr1;
        [FieldOffset(0x1EA)] public BgmType phaseBgmType__arr2;
        [FieldOffset(0x1EB)] public BgmType phaseBgmType__arr3;
        [FieldOffset(0x1EC)] public BgmType phaseBgmType__arr4;
        [FieldOffset(0x1ED)] public BgmType phaseBgmType__arr5;
        [FieldOffset(0x1EE)] public BgmType phaseBgmType__arr6;
        [FieldOffset(0x1EF)] public BgmType phaseBgmType__arr7;
        [FieldOffset(0x1F0)] public BgmType phaseBgmType__arr8;
        [FieldOffset(0x1F1)] public BgmType phaseBgmType__arr9;
        [FieldOffset(0x1F2)] public BgmType phaseBgmType__arr10;
        [FieldOffset(0x1F4)] public uint hour;
        [FieldOffset(0x1F8)] public uint minute;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x7F4)]
    public struct BattleRushParameter
    {
        [FieldOffset(0x00)] public BattleRushStageParameter stages__arr0;
        [FieldOffset(0x1FC)] public BattleRushStageParameter stages__arr1;
        [FieldOffset(0x3F8)] public BattleRushStageParameter stages__arr2;
        [FieldOffset(0x5F4)] public BattleRushStageParameter stages__arr3;
        [FieldOffset(0x7F0)] public float viewPaseResultTime;
    }

}