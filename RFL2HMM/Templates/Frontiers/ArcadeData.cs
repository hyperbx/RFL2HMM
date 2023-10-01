using System.Numerics;
using System.Runtime.InteropServices;

public class ArcadeDataClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x33C)]
    public struct ArcadeData
    {
        [FieldOffset(0x00)] public HeaderData header;
        [FieldOffset(0x28)] public bool unlocked;
        [FieldOffset(0x2C)] public CyberStageContainerData stages;
        [FieldOffset(0x32C)] public uint reserved__arr0;
        [FieldOffset(0x330)] public uint reserved__arr1;
        [FieldOffset(0x334)] public uint reserved__arr2;
        [FieldOffset(0x338)] public uint reserved__arr3;
    }

}