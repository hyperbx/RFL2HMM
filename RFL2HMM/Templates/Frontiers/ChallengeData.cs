using System.Numerics;
using System.Runtime.InteropServices;

public class ChallengeDataClass
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

    public enum Value : sbyte
    {
        S = 0,
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        Num = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct CyberStageData
    {
        [FieldOffset(0x00)] public ushort flags;
        [FieldOffset(0x04)] public uint bestTime;
        [FieldOffset(0x08)] public uint flags2;
        [FieldOffset(0x0C)] public uint reserved__arr0;
        [FieldOffset(0x10)] public uint reserved__arr1;
        [FieldOffset(0x14)] public uint reserved__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x300)]
    public struct CyberStageContainerData
    {
        [FieldOffset(0x00)] public CyberStageData actStages__arr0;
        [FieldOffset(0x18)] public CyberStageData actStages__arr1;
        [FieldOffset(0x30)] public CyberStageData actStages__arr2;
        [FieldOffset(0x48)] public CyberStageData actStages__arr3;
        [FieldOffset(0x60)] public CyberStageData actStages__arr4;
        [FieldOffset(0x78)] public CyberStageData actStages__arr5;
        [FieldOffset(0x90)] public CyberStageData actStages__arr6;
        [FieldOffset(0xA8)] public CyberStageData actStages__arr7;
        [FieldOffset(0xC0)] public CyberStageData actStages__arr8;
        [FieldOffset(0xD8)] public CyberStageData actStages__arr9;
        [FieldOffset(0xF0)] public CyberStageData actStages__arr10;
        [FieldOffset(0x108)] public CyberStageData actStages__arr11;
        [FieldOffset(0x120)] public CyberStageData actStages__arr12;
        [FieldOffset(0x138)] public CyberStageData actStages__arr13;
        [FieldOffset(0x150)] public CyberStageData actStages__arr14;
        [FieldOffset(0x168)] public CyberStageData actStages__arr15;
        [FieldOffset(0x180)] public CyberStageData actStages__arr16;
        [FieldOffset(0x198)] public CyberStageData actStages__arr17;
        [FieldOffset(0x1B0)] public CyberStageData actStages__arr18;
        [FieldOffset(0x1C8)] public CyberStageData actStages__arr19;
        [FieldOffset(0x1E0)] public CyberStageData actStages__arr20;
        [FieldOffset(0x1F8)] public CyberStageData actStages__arr21;
        [FieldOffset(0x210)] public CyberStageData actStages__arr22;
        [FieldOffset(0x228)] public CyberStageData actStages__arr23;
        [FieldOffset(0x240)] public CyberStageData actStages__arr24;
        [FieldOffset(0x258)] public CyberStageData actStages__arr25;
        [FieldOffset(0x270)] public CyberStageData actStages__arr26;
        [FieldOffset(0x288)] public CyberStageData actStages__arr27;
        [FieldOffset(0x2A0)] public CyberStageData actStages__arr28;
        [FieldOffset(0x2B8)] public CyberStageData actStages__arr29;
        [FieldOffset(0x2D0)] public CyberStageData actStages__arr30;
        [FieldOffset(0x2E8)] public CyberStageData actStages__arr31;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38C)]
    public struct ChallengeCyberStageData
    {
        [FieldOffset(0x00)] public uint status;
        [FieldOffset(0x04)] public uint totalBestTime;
        [FieldOffset(0x08)] public Value totalBestRank;
        [FieldOffset(0x0C)] public CyberStageContainerData stages;
        [FieldOffset(0x30C)] public int stageNos__arr0;
        [FieldOffset(0x310)] public int stageNos__arr1;
        [FieldOffset(0x314)] public int stageNos__arr2;
        [FieldOffset(0x318)] public int stageNos__arr3;
        [FieldOffset(0x31C)] public int stageNos__arr4;
        [FieldOffset(0x320)] public int stageNos__arr5;
        [FieldOffset(0x324)] public int stageNos__arr6;
        [FieldOffset(0x328)] public int stageNos__arr7;
        [FieldOffset(0x32C)] public int stageNos__arr8;
        [FieldOffset(0x330)] public int stageNos__arr9;
        [FieldOffset(0x334)] public int stageNos__arr10;
        [FieldOffset(0x338)] public int stageNos__arr11;
        [FieldOffset(0x33C)] public int stageNos__arr12;
        [FieldOffset(0x340)] public int stageNos__arr13;
        [FieldOffset(0x344)] public int stageNos__arr14;
        [FieldOffset(0x348)] public int stageNos__arr15;
        [FieldOffset(0x34C)] public int stageNos__arr16;
        [FieldOffset(0x350)] public int stageNos__arr17;
        [FieldOffset(0x354)] public int stageNos__arr18;
        [FieldOffset(0x358)] public int stageNos__arr19;
        [FieldOffset(0x35C)] public int stageNos__arr20;
        [FieldOffset(0x360)] public int stageNos__arr21;
        [FieldOffset(0x364)] public int stageNos__arr22;
        [FieldOffset(0x368)] public int stageNos__arr23;
        [FieldOffset(0x36C)] public int stageNos__arr24;
        [FieldOffset(0x370)] public int stageNos__arr25;
        [FieldOffset(0x374)] public int stageNos__arr26;
        [FieldOffset(0x378)] public int stageNos__arr27;
        [FieldOffset(0x37C)] public int stageNos__arr28;
        [FieldOffset(0x380)] public int stageNos__arr29;
        [FieldOffset(0x384)] public int stageNos__arr30;
        [FieldOffset(0x388)] public int stageNos__arr31;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x11BC)]
    public struct ChallengeCyberStageContainerData
    {
        [FieldOffset(0x00)] public ChallengeCyberStageData stages__arr0;
        [FieldOffset(0x38C)] public ChallengeCyberStageData stages__arr1;
        [FieldOffset(0x718)] public ChallengeCyberStageData stages__arr2;
        [FieldOffset(0xAA4)] public ChallengeCyberStageData stages__arr3;
        [FieldOffset(0xE30)] public ChallengeCyberStageData stages__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct ChallengeBattleRushScoreData
    {
        [FieldOffset(0x00)] public uint bestTime;
        [FieldOffset(0x04)] public uint reserved0;
        [FieldOffset(0x08)] public uint reserved1;
        [FieldOffset(0x0C)] public uint reserved2;
        [FieldOffset(0x10)] public uint reserved3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x144)]
    public struct ChallengeBattleRushData
    {
        [FieldOffset(0x00)] public uint status;
        [FieldOffset(0x04)] public ChallengeBattleRushScoreData scores__arr0;
        [FieldOffset(0x18)] public ChallengeBattleRushScoreData scores__arr1;
        [FieldOffset(0x2C)] public ChallengeBattleRushScoreData scores__arr2;
        [FieldOffset(0x40)] public ChallengeBattleRushScoreData scores__arr3;
        [FieldOffset(0x54)] public ChallengeBattleRushScoreData scores__arr4;
        [FieldOffset(0x68)] public ChallengeBattleRushScoreData scores__arr5;
        [FieldOffset(0x7C)] public ChallengeBattleRushScoreData scores__arr6;
        [FieldOffset(0x90)] public ChallengeBattleRushScoreData scores__arr7;
        [FieldOffset(0xA4)] public ChallengeBattleRushScoreData scores__arr8;
        [FieldOffset(0xB8)] public ChallengeBattleRushScoreData scores__arr9;
        [FieldOffset(0xCC)] public ChallengeBattleRushScoreData scores__arr10;
        [FieldOffset(0xE0)] public ChallengeBattleRushScoreData scores__arr11;
        [FieldOffset(0xF4)] public ChallengeBattleRushScoreData scores__arr12;
        [FieldOffset(0x108)] public ChallengeBattleRushScoreData scores__arr13;
        [FieldOffset(0x11C)] public ChallengeBattleRushScoreData scores__arr14;
        [FieldOffset(0x130)] public ChallengeBattleRushScoreData scores__arr15;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x510)]
    public struct ChallengeBattleRushContainerData
    {
        [FieldOffset(0x00)] public ChallengeBattleRushData stages__arr0;
        [FieldOffset(0x144)] public ChallengeBattleRushData stages__arr1;
        [FieldOffset(0x288)] public ChallengeBattleRushData stages__arr2;
        [FieldOffset(0x3CC)] public ChallengeBattleRushData stages__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C18)]
    public struct ChallengeData
    {
        [FieldOffset(0x00)] public HeaderData header;
        [FieldOffset(0x28)] public uint status;
        [FieldOffset(0x2C)] public ChallengeCyberStageContainerData cyberStage;
        [FieldOffset(0x11E8)] public ChallengeBattleRushContainerData battleRush;
        [FieldOffset(0x16F8)] public ChallengeBattleRushContainerData battleRushAll;
        [FieldOffset(0x1C08)] public uint reserved0;
        [FieldOffset(0x1C0C)] public uint reserved1;
        [FieldOffset(0x1C10)] public uint reserved2;
        [FieldOffset(0x1C14)] public uint reserved3;
    }

}