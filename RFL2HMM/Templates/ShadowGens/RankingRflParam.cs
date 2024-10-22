Library "RankingRflParam"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum RankingId : int
    {
        ShadowRankingTest = 0,
        SSpaceColonyArkAct1 = 1,
        SSpaceColonyArkAct1DWing = 2,
        SSpaceColonyArkAct2 = 3,
        SSpaceColonyArkAct2DWing = 4,
        SRailCanyonAct1 = 5,
        SRailCanyonAct1DWing = 6,
        SRailCanyonAct2 = 7,
        SRailCanyonAct2DWing = 8,
        SKingdomValleyAct1 = 9,
        SKingdomValleyAct1DWing = 10,
        SKingdomValleyAct2 = 11,
        SKingdomValleyAct2DWing = 12,
        SCityAct1 = 13,
        SCityAct1DWing = 14,
        SCityAct2 = 15,
        SCityAct2DWing = 16,
        SChaosIslandAct1 = 17,
        SChaosIslandAct1DWing = 18,
        SChaosIslandAct2 = 19,
        SChaosIslandAct2DWing = 20,
        SRadicalHighwayAct1 = 21,
        SRadicalHighwayAct1DWing = 22,
        SRadicalHighwayAct2 = 23,
        SRadicalHighwayAct2DWing = 24,
        RANKINGID_END = 25,
        RANKINGID_START = 1,
        RANKINGID_ACT_NUM = 25
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct RankingKindParam
    {
        [FieldOffset(0x00)] public RankingId rankingId;
        [FieldOffset(0x04)] public bool valid;
        [FieldOffset(0x08)] public uint minTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x12C)]
    public struct RankingRflParam
    {
        [FieldOffset(0x00)] public RankingKindParam rankingKindInfos__arr0;
        [FieldOffset(0x0C)] public RankingKindParam rankingKindInfos__arr1;
        [FieldOffset(0x18)] public RankingKindParam rankingKindInfos__arr2;
        [FieldOffset(0x24)] public RankingKindParam rankingKindInfos__arr3;
        [FieldOffset(0x30)] public RankingKindParam rankingKindInfos__arr4;
        [FieldOffset(0x3C)] public RankingKindParam rankingKindInfos__arr5;
        [FieldOffset(0x48)] public RankingKindParam rankingKindInfos__arr6;
        [FieldOffset(0x54)] public RankingKindParam rankingKindInfos__arr7;
        [FieldOffset(0x60)] public RankingKindParam rankingKindInfos__arr8;
        [FieldOffset(0x6C)] public RankingKindParam rankingKindInfos__arr9;
        [FieldOffset(0x78)] public RankingKindParam rankingKindInfos__arr10;
        [FieldOffset(0x84)] public RankingKindParam rankingKindInfos__arr11;
        [FieldOffset(0x90)] public RankingKindParam rankingKindInfos__arr12;
        [FieldOffset(0x9C)] public RankingKindParam rankingKindInfos__arr13;
        [FieldOffset(0xA8)] public RankingKindParam rankingKindInfos__arr14;
        [FieldOffset(0xB4)] public RankingKindParam rankingKindInfos__arr15;
        [FieldOffset(0xC0)] public RankingKindParam rankingKindInfos__arr16;
        [FieldOffset(0xCC)] public RankingKindParam rankingKindInfos__arr17;
        [FieldOffset(0xD8)] public RankingKindParam rankingKindInfos__arr18;
        [FieldOffset(0xE4)] public RankingKindParam rankingKindInfos__arr19;
        [FieldOffset(0xF0)] public RankingKindParam rankingKindInfos__arr20;
        [FieldOffset(0xFC)] public RankingKindParam rankingKindInfos__arr21;
        [FieldOffset(0x108)] public RankingKindParam rankingKindInfos__arr22;
        [FieldOffset(0x114)] public RankingKindParam rankingKindInfos__arr23;
        [FieldOffset(0x120)] public RankingKindParam rankingKindInfos__arr24;
    }

}