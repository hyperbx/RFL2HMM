using System.Numerics;
using System.Runtime.InteropServices;

public class FishingParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct FishingCommonParam
    {
        [FieldOffset(0x00)] public float baseWaveThickness;
        [FieldOffset(0x04)] public float baseWaveSuccessRatioNormal;
        [FieldOffset(0x08)] public float baseWaveSuccessRatioHold;
        [FieldOffset(0x0C)] public float singleWaveThickness;
        [FieldOffset(0x10)] public float baseWaveEdgeThickness;
        [FieldOffset(0x14)] public float timingEdgeThickness;
        [FieldOffset(0x18)] public uint fishShadowNum;
        [FieldOffset(0x1C)] public float fishApproachIntervalMin;
        [FieldOffset(0x20)] public float fishApproachIntervalMax;
        [FieldOffset(0x24)] public float fishEscapeDistance;
        [FieldOffset(0x28)] public uint buoyTwitchNumMin;
        [FieldOffset(0x2C)] public uint buoyTwitchNumMax;
        [FieldOffset(0x30)] public float buoyTwitchIntervalMin;
        [FieldOffset(0x34)] public float buoyTwitchIntervalMax;
        [FieldOffset(0x38)] public float inputValidTime;
        [FieldOffset(0x3C)] public float fishingCameraTransitDelay;
        [FieldOffset(0x40)] public float cutinDelay;
        [FieldOffset(0x44)] public float cutinDuration;
        [FieldOffset(0x48)] public float successPullUpDelay;
        [FieldOffset(0x4C)] public uint goldenChestLimitNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FishingSuccessPatternParam
    {
        [FieldOffset(0x00)] public uint successNum;
        [FieldOffset(0x04)] public uint failureNum;
    }

    public enum Type : sbyte
    {
        TYPE_INVALID = 0,
        TYPE_NORMAL = 1,
        TYPE_HOLD = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct FishingWaveParam
    {
        [FieldOffset(0x00)] public Type type;
        [FieldOffset(0x04)] public float radius;
        [FieldOffset(0x08)] public float thickness;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct FishingWaveGroupParam
    {
        [FieldOffset(0x00)] public FishingWaveParam waves__arr0;
        [FieldOffset(0x0C)] public FishingWaveParam waves__arr1;
        [FieldOffset(0x18)] public FishingWaveParam waves__arr2;
        [FieldOffset(0x24)] public FishingWaveParam waves__arr3;
        [FieldOffset(0x30)] public FishingWaveParam waves__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x278)]
    public struct FishingWavePatternParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float intervalMinFirst;
        [FieldOffset(0x08)] public float intervalMaxFirst;
        [FieldOffset(0x0C)] public float intervalMin;
        [FieldOffset(0x10)] public float intervalMax;
        [FieldOffset(0x14)] public float addRadiusMin;
        [FieldOffset(0x18)] public float addRadiusMax;
        [FieldOffset(0x1C)] public uint waveGroupNum;
        [FieldOffset(0x20)] public FishingWaveGroupParam waveGroups__arr0;
        [FieldOffset(0x5C)] public FishingWaveGroupParam waveGroups__arr1;
        [FieldOffset(0x98)] public FishingWaveGroupParam waveGroups__arr2;
        [FieldOffset(0xD4)] public FishingWaveGroupParam waveGroups__arr3;
        [FieldOffset(0x110)] public FishingWaveGroupParam waveGroups__arr4;
        [FieldOffset(0x14C)] public FishingWaveGroupParam waveGroups__arr5;
        [FieldOffset(0x188)] public FishingWaveGroupParam waveGroups__arr6;
        [FieldOffset(0x1C4)] public FishingWaveGroupParam waveGroups__arr7;
        [FieldOffset(0x200)] public FishingWaveGroupParam waveGroups__arr8;
        [FieldOffset(0x23C)] public FishingWaveGroupParam waveGroups__arr9;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct FishingFishGroupParam
    {
        [FieldOffset(0x00)] public float rate;
    }

    public enum FishShadowType : sbyte
    {
        SMALL = 0,
        MEDIUM = 1,
        LARGE = 2
    }

    public enum CatchUpMotionType : sbyte
    {
        SHADOW_SIZE = 0,
        LARGE_GOOD_FISH = 1,
        LARGE_GOOD_ITEM = 2,
        LARGE_BAD = 3,
        CatchUpMotionType_LARGE = 4,
        CatchUpMotionType_MEDIUM = 5,
        CatchUpMotionType_SMALL = 6,
        CHEST_GOOD = 7,
        CHEST_VERYGOOD = 8,
        SCROLL = 9
    }

    public enum ToastType : sbyte
    {
        MOTION = 0,
        PATTERN_1 = 1,
        PATTERN_2 = 2,
        PATTERN_3 = 3,
        PATTERN_4 = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FishingFishParam
    {
        [FieldOffset(0x00)] public int fishGroupId;
        [FieldOffset(0x04)] public FishShadowType shadowType;
        [FieldOffset(0x08)] public uint successPatternId;
        [FieldOffset(0x0C)] public uint wavePatternId;
        [FieldOffset(0x10)] public uint expPoint;
        [FieldOffset(0x14)] public uint tokenNum;
        [FieldOffset(0x18)] public bool isRare;
        [FieldOffset(0x19)] public CatchUpMotionType catchUpMotionType;
        [FieldOffset(0x1A)] public ToastType toastType;
        [FieldOffset(0x20)] public Vector3 catchUpOffsetPos;
        [FieldOffset(0x30)] public Vector3 catchUpOffsetRot;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct FishingSpotSpawnFishParam
    {
        [FieldOffset(0x00)] public int spawnFishId__arr0;
        [FieldOffset(0x04)] public int spawnFishId__arr1;
        [FieldOffset(0x08)] public int spawnFishId__arr2;
        [FieldOffset(0x0C)] public int spawnFishId__arr3;
        [FieldOffset(0x10)] public int spawnFishId__arr4;
        [FieldOffset(0x14)] public int spawnFishId__arr5;
        [FieldOffset(0x18)] public int spawnFishId__arr6;
        [FieldOffset(0x1C)] public int spawnFishId__arr7;
        [FieldOffset(0x20)] public int spawnFishId__arr8;
        [FieldOffset(0x24)] public int spawnFishId__arr9;
        [FieldOffset(0x28)] public int spawnFishId__arr10;
        [FieldOffset(0x2C)] public int spawnFishId__arr11;
        [FieldOffset(0x30)] public int spawnFishId__arr12;
        [FieldOffset(0x34)] public int spawnFishId__arr13;
        [FieldOffset(0x38)] public int spawnFishId__arr14;
        [FieldOffset(0x3C)] public int spawnFishId__arr15;
        [FieldOffset(0x40)] public int spawnFishId__arr16;
        [FieldOffset(0x44)] public int spawnFishId__arr17;
        [FieldOffset(0x48)] public int spawnFishId__arr18;
        [FieldOffset(0x4C)] public int spawnFishId__arr19;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FishingFixedResultParam
    {
        [FieldOffset(0x00)] public int count;
        [FieldOffset(0x04)] public int fishId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x198)]
    public struct FishingSpotFixedResultParam
    {
        [FieldOffset(0x00)] public uint tableSize;
        [FieldOffset(0x04)] public uint achievementUnlockCount;
        [FieldOffset(0x08)] public FishingFixedResultParam fixedResultList__arr0;
        [FieldOffset(0x10)] public FishingFixedResultParam fixedResultList__arr1;
        [FieldOffset(0x18)] public FishingFixedResultParam fixedResultList__arr2;
        [FieldOffset(0x20)] public FishingFixedResultParam fixedResultList__arr3;
        [FieldOffset(0x28)] public FishingFixedResultParam fixedResultList__arr4;
        [FieldOffset(0x30)] public FishingFixedResultParam fixedResultList__arr5;
        [FieldOffset(0x38)] public FishingFixedResultParam fixedResultList__arr6;
        [FieldOffset(0x40)] public FishingFixedResultParam fixedResultList__arr7;
        [FieldOffset(0x48)] public FishingFixedResultParam fixedResultList__arr8;
        [FieldOffset(0x50)] public FishingFixedResultParam fixedResultList__arr9;
        [FieldOffset(0x58)] public FishingFixedResultParam fixedResultList__arr10;
        [FieldOffset(0x60)] public FishingFixedResultParam fixedResultList__arr11;
        [FieldOffset(0x68)] public FishingFixedResultParam fixedResultList__arr12;
        [FieldOffset(0x70)] public FishingFixedResultParam fixedResultList__arr13;
        [FieldOffset(0x78)] public FishingFixedResultParam fixedResultList__arr14;
        [FieldOffset(0x80)] public FishingFixedResultParam fixedResultList__arr15;
        [FieldOffset(0x88)] public FishingFixedResultParam fixedResultList__arr16;
        [FieldOffset(0x90)] public FishingFixedResultParam fixedResultList__arr17;
        [FieldOffset(0x98)] public FishingFixedResultParam fixedResultList__arr18;
        [FieldOffset(0xA0)] public FishingFixedResultParam fixedResultList__arr19;
        [FieldOffset(0xA8)] public FishingFixedResultParam fixedResultList__arr20;
        [FieldOffset(0xB0)] public FishingFixedResultParam fixedResultList__arr21;
        [FieldOffset(0xB8)] public FishingFixedResultParam fixedResultList__arr22;
        [FieldOffset(0xC0)] public FishingFixedResultParam fixedResultList__arr23;
        [FieldOffset(0xC8)] public FishingFixedResultParam fixedResultList__arr24;
        [FieldOffset(0xD0)] public FishingFixedResultParam fixedResultList__arr25;
        [FieldOffset(0xD8)] public FishingFixedResultParam fixedResultList__arr26;
        [FieldOffset(0xE0)] public FishingFixedResultParam fixedResultList__arr27;
        [FieldOffset(0xE8)] public FishingFixedResultParam fixedResultList__arr28;
        [FieldOffset(0xF0)] public FishingFixedResultParam fixedResultList__arr29;
        [FieldOffset(0xF8)] public FishingFixedResultParam fixedResultList__arr30;
        [FieldOffset(0x100)] public FishingFixedResultParam fixedResultList__arr31;
        [FieldOffset(0x108)] public FishingFixedResultParam fixedResultList__arr32;
        [FieldOffset(0x110)] public FishingFixedResultParam fixedResultList__arr33;
        [FieldOffset(0x118)] public FishingFixedResultParam fixedResultList__arr34;
        [FieldOffset(0x120)] public FishingFixedResultParam fixedResultList__arr35;
        [FieldOffset(0x128)] public FishingFixedResultParam fixedResultList__arr36;
        [FieldOffset(0x130)] public FishingFixedResultParam fixedResultList__arr37;
        [FieldOffset(0x138)] public FishingFixedResultParam fixedResultList__arr38;
        [FieldOffset(0x140)] public FishingFixedResultParam fixedResultList__arr39;
        [FieldOffset(0x148)] public FishingFixedResultParam fixedResultList__arr40;
        [FieldOffset(0x150)] public FishingFixedResultParam fixedResultList__arr41;
        [FieldOffset(0x158)] public FishingFixedResultParam fixedResultList__arr42;
        [FieldOffset(0x160)] public FishingFixedResultParam fixedResultList__arr43;
        [FieldOffset(0x168)] public FishingFixedResultParam fixedResultList__arr44;
        [FieldOffset(0x170)] public FishingFixedResultParam fixedResultList__arr45;
        [FieldOffset(0x178)] public FishingFixedResultParam fixedResultList__arr46;
        [FieldOffset(0x180)] public FishingFixedResultParam fixedResultList__arr47;
        [FieldOffset(0x188)] public FishingFixedResultParam fixedResultList__arr48;
        [FieldOffset(0x190)] public FishingFixedResultParam fixedResultList__arr49;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x7C0)]
    public struct FishingSpotParam
    {
        [FieldOffset(0x00)] public FishingSpotSpawnFishParam spawnFish__arr0;
        [FieldOffset(0x50)] public FishingSpotSpawnFishParam spawnFish__arr1;
        [FieldOffset(0xA0)] public FishingSpotSpawnFishParam spawnFish__arr2;
        [FieldOffset(0xF0)] public FishingSpotSpawnFishParam spawnFish__arr3;
        [FieldOffset(0x140)] public FishingSpotFixedResultParam fixedResults__arr0;
        [FieldOffset(0x2D8)] public FishingSpotFixedResultParam fixedResults__arr1;
        [FieldOffset(0x470)] public FishingSpotFixedResultParam fixedResults__arr2;
        [FieldOffset(0x608)] public FishingSpotFixedResultParam fixedResults__arr3;
        [FieldOffset(0x7A0)] public uint useFishCoinNum__arr0;
        [FieldOffset(0x7A4)] public uint useFishCoinNum__arr1;
        [FieldOffset(0x7A8)] public uint useFishCoinNum__arr2;
        [FieldOffset(0x7AC)] public uint useFishCoinNum__arr3;
        [FieldOffset(0x7B0)] public uint tokenRate__arr0;
        [FieldOffset(0x7B4)] public uint tokenRate__arr1;
        [FieldOffset(0x7B8)] public uint tokenRate__arr2;
        [FieldOffset(0x7BC)] public uint tokenRate__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4F8)]
    public struct FishingTutorialParam
    {
        [FieldOffset(0x00)] public uint singleWaveSuccessCount;
        [FieldOffset(0x04)] public uint holdWaveSuccessCount;
        [FieldOffset(0x08)] public FishingWavePatternParam singleWave;
        [FieldOffset(0x280)] public FishingWavePatternParam holdWave;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x09)]
    public struct FishingTradeTableParma
    {
        [FieldOffset(0x00)] public byte sales__arr0;
        [FieldOffset(0x01)] public byte sales__arr1;
        [FieldOffset(0x02)] public byte sales__arr2;
        [FieldOffset(0x03)] public byte sales__arr3;
        [FieldOffset(0x04)] public byte sales__arr4;
        [FieldOffset(0x05)] public byte sales__arr5;
        [FieldOffset(0x06)] public byte sales__arr6;
        [FieldOffset(0x07)] public byte sales__arr7;
        [FieldOffset(0x08)] public byte sales__arr8;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3F)]
    public struct FishingTradeParam
    {
        [FieldOffset(0x00)] public FishingTradeTableParma spot__arr0;
        [FieldOffset(0x09)] public FishingTradeTableParma spot__arr1;
        [FieldOffset(0x12)] public FishingTradeTableParma spot__arr2;
        [FieldOffset(0x1B)] public FishingTradeTableParma spot__arr3;
        [FieldOffset(0x24)] public byte prices__arr0;
        [FieldOffset(0x25)] public byte prices__arr1;
        [FieldOffset(0x26)] public byte prices__arr2;
        [FieldOffset(0x27)] public byte prices__arr3;
        [FieldOffset(0x28)] public byte prices__arr4;
        [FieldOffset(0x29)] public byte prices__arr5;
        [FieldOffset(0x2A)] public byte prices__arr6;
        [FieldOffset(0x2B)] public byte prices__arr7;
        [FieldOffset(0x2C)] public byte prices__arr8;
        [FieldOffset(0x2D)] public byte pricesVeryHard__arr0;
        [FieldOffset(0x2E)] public byte pricesVeryHard__arr1;
        [FieldOffset(0x2F)] public byte pricesVeryHard__arr2;
        [FieldOffset(0x30)] public byte pricesVeryHard__arr3;
        [FieldOffset(0x31)] public byte pricesVeryHard__arr4;
        [FieldOffset(0x32)] public byte pricesVeryHard__arr5;
        [FieldOffset(0x33)] public byte pricesVeryHard__arr6;
        [FieldOffset(0x34)] public byte pricesVeryHard__arr7;
        [FieldOffset(0x35)] public byte pricesVeryHard__arr8;
        [FieldOffset(0x36)] public byte counts__arr0;
        [FieldOffset(0x37)] public byte counts__arr1;
        [FieldOffset(0x38)] public byte counts__arr2;
        [FieldOffset(0x39)] public byte counts__arr3;
        [FieldOffset(0x3A)] public byte counts__arr4;
        [FieldOffset(0x3B)] public byte counts__arr5;
        [FieldOffset(0x3C)] public byte counts__arr6;
        [FieldOffset(0x3D)] public byte counts__arr7;
        [FieldOffset(0x3E)] public byte counts__arr8;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4700)]
    public struct FishingParameter
    {
        [FieldOffset(0x00)] public FishingCommonParam common;
        [FieldOffset(0x50)] public FishingSuccessPatternParam successPattern__arr0;
        [FieldOffset(0x58)] public FishingSuccessPatternParam successPattern__arr1;
        [FieldOffset(0x60)] public FishingSuccessPatternParam successPattern__arr2;
        [FieldOffset(0x68)] public FishingSuccessPatternParam successPattern__arr3;
        [FieldOffset(0x70)] public FishingSuccessPatternParam successPattern__arr4;
        [FieldOffset(0x78)] public FishingSuccessPatternParam successPattern__arr5;
        [FieldOffset(0x80)] public FishingSuccessPatternParam successPattern__arr6;
        [FieldOffset(0x88)] public FishingSuccessPatternParam successPattern__arr7;
        [FieldOffset(0x90)] public FishingSuccessPatternParam successPattern__arr8;
        [FieldOffset(0x98)] public FishingSuccessPatternParam successPattern__arr9;
        [FieldOffset(0xA0)] public FishingWavePatternParam wavePattern__arr0;
        [FieldOffset(0x318)] public FishingWavePatternParam wavePattern__arr1;
        [FieldOffset(0x590)] public FishingWavePatternParam wavePattern__arr2;
        [FieldOffset(0x808)] public FishingWavePatternParam wavePattern__arr3;
        [FieldOffset(0xA80)] public FishingWavePatternParam wavePattern__arr4;
        [FieldOffset(0xCF8)] public FishingWavePatternParam wavePattern__arr5;
        [FieldOffset(0xF70)] public FishingWavePatternParam wavePattern__arr6;
        [FieldOffset(0x11E8)] public FishingWavePatternParam wavePattern__arr7;
        [FieldOffset(0x1460)] public FishingWavePatternParam wavePattern__arr8;
        [FieldOffset(0x16D8)] public FishingWavePatternParam wavePattern__arr9;
        [FieldOffset(0x1950)] public FishingFishGroupParam fishGroup__arr0;
        [FieldOffset(0x1954)] public FishingFishGroupParam fishGroup__arr1;
        [FieldOffset(0x1958)] public FishingFishGroupParam fishGroup__arr2;
        [FieldOffset(0x195C)] public FishingFishGroupParam fishGroup__arr3;
        [FieldOffset(0x1960)] public FishingFishGroupParam fishGroup__arr4;
        [FieldOffset(0x1964)] public FishingFishGroupParam fishGroup__arr5;
        [FieldOffset(0x1968)] public FishingFishGroupParam fishGroup__arr6;
        [FieldOffset(0x196C)] public FishingFishGroupParam fishGroup__arr7;
        [FieldOffset(0x1970)] public FishingFishGroupParam fishGroup__arr8;
        [FieldOffset(0x1974)] public FishingFishGroupParam fishGroup__arr9;
        [FieldOffset(0x1980)] public FishingFishParam fish__arr0;
        [FieldOffset(0x19C0)] public FishingFishParam fish__arr1;
        [FieldOffset(0x1A00)] public FishingFishParam fish__arr2;
        [FieldOffset(0x1A40)] public FishingFishParam fish__arr3;
        [FieldOffset(0x1A80)] public FishingFishParam fish__arr4;
        [FieldOffset(0x1AC0)] public FishingFishParam fish__arr5;
        [FieldOffset(0x1B00)] public FishingFishParam fish__arr6;
        [FieldOffset(0x1B40)] public FishingFishParam fish__arr7;
        [FieldOffset(0x1B80)] public FishingFishParam fish__arr8;
        [FieldOffset(0x1BC0)] public FishingFishParam fish__arr9;
        [FieldOffset(0x1C00)] public FishingFishParam fish__arr10;
        [FieldOffset(0x1C40)] public FishingFishParam fish__arr11;
        [FieldOffset(0x1C80)] public FishingFishParam fish__arr12;
        [FieldOffset(0x1CC0)] public FishingFishParam fish__arr13;
        [FieldOffset(0x1D00)] public FishingFishParam fish__arr14;
        [FieldOffset(0x1D40)] public FishingFishParam fish__arr15;
        [FieldOffset(0x1D80)] public FishingFishParam fish__arr16;
        [FieldOffset(0x1DC0)] public FishingFishParam fish__arr17;
        [FieldOffset(0x1E00)] public FishingFishParam fish__arr18;
        [FieldOffset(0x1E40)] public FishingFishParam fish__arr19;
        [FieldOffset(0x1E80)] public FishingFishParam fish__arr20;
        [FieldOffset(0x1EC0)] public FishingFishParam fish__arr21;
        [FieldOffset(0x1F00)] public FishingFishParam fish__arr22;
        [FieldOffset(0x1F40)] public FishingFishParam fish__arr23;
        [FieldOffset(0x1F80)] public FishingFishParam fish__arr24;
        [FieldOffset(0x1FC0)] public FishingFishParam fish__arr25;
        [FieldOffset(0x2000)] public FishingFishParam fish__arr26;
        [FieldOffset(0x2040)] public FishingFishParam fish__arr27;
        [FieldOffset(0x2080)] public FishingFishParam fish__arr28;
        [FieldOffset(0x20C0)] public FishingFishParam fish__arr29;
        [FieldOffset(0x2100)] public FishingFishParam fish__arr30;
        [FieldOffset(0x2140)] public FishingFishParam fish__arr31;
        [FieldOffset(0x2180)] public FishingFishParam fish__arr32;
        [FieldOffset(0x21C0)] public FishingFishParam fish__arr33;
        [FieldOffset(0x2200)] public FishingFishParam fish__arr34;
        [FieldOffset(0x2240)] public FishingFishParam fish__arr35;
        [FieldOffset(0x2280)] public FishingFishParam fish__arr36;
        [FieldOffset(0x22C0)] public FishingFishParam fish__arr37;
        [FieldOffset(0x2300)] public FishingFishParam fish__arr38;
        [FieldOffset(0x2340)] public FishingFishParam fish__arr39;
        [FieldOffset(0x2380)] public FishingFishParam fish__arr40;
        [FieldOffset(0x23C0)] public FishingFishParam fish__arr41;
        [FieldOffset(0x2400)] public FishingFishParam fish__arr42;
        [FieldOffset(0x2440)] public FishingFishParam fish__arr43;
        [FieldOffset(0x2480)] public FishingFishParam fish__arr44;
        [FieldOffset(0x24C0)] public FishingFishParam fish__arr45;
        [FieldOffset(0x2500)] public FishingFishParam fish__arr46;
        [FieldOffset(0x2540)] public FishingFishParam fish__arr47;
        [FieldOffset(0x2580)] public FishingFishParam fish__arr48;
        [FieldOffset(0x25C0)] public FishingFishParam fish__arr49;
        [FieldOffset(0x2600)] public FishingFishParam fish__arr50;
        [FieldOffset(0x2640)] public FishingFishParam fish__arr51;
        [FieldOffset(0x2680)] public FishingFishParam fish__arr52;
        [FieldOffset(0x26C0)] public FishingFishParam fish__arr53;
        [FieldOffset(0x2700)] public FishingFishParam fish__arr54;
        [FieldOffset(0x2740)] public FishingFishParam fish__arr55;
        [FieldOffset(0x2780)] public FishingFishParam fish__arr56;
        [FieldOffset(0x27C0)] public FishingFishParam fish__arr57;
        [FieldOffset(0x2800)] public FishingFishParam fish__arr58;
        [FieldOffset(0x2840)] public FishingFishParam fish__arr59;
        [FieldOffset(0x2880)] public FishingFishParam fish__arr60;
        [FieldOffset(0x28C0)] public FishingFishParam fish__arr61;
        [FieldOffset(0x2900)] public FishingFishParam fish__arr62;
        [FieldOffset(0x2940)] public FishingFishParam fish__arr63;
        [FieldOffset(0x2980)] public FishingFishParam fish__arr64;
        [FieldOffset(0x29C0)] public FishingFishParam fish__arr65;
        [FieldOffset(0x2A00)] public FishingFishParam fish__arr66;
        [FieldOffset(0x2A40)] public FishingFishParam fish__arr67;
        [FieldOffset(0x2A80)] public FishingFishParam fish__arr68;
        [FieldOffset(0x2AC0)] public FishingFishParam fish__arr69;
        [FieldOffset(0x2B00)] public FishingFishParam fish__arr70;
        [FieldOffset(0x2B40)] public FishingFishParam fish__arr71;
        [FieldOffset(0x2B80)] public FishingFishParam fish__arr72;
        [FieldOffset(0x2BC0)] public FishingFishParam fish__arr73;
        [FieldOffset(0x2C00)] public FishingFishParam fish__arr74;
        [FieldOffset(0x2C40)] public FishingFishParam fish__arr75;
        [FieldOffset(0x2C80)] public FishingFishParam fish__arr76;
        [FieldOffset(0x2CC0)] public FishingFishParam fish__arr77;
        [FieldOffset(0x2D00)] public FishingFishParam fish__arr78;
        [FieldOffset(0x2D40)] public FishingFishParam fish__arr79;
        [FieldOffset(0x2D80)] public FishingFishParam fish__arr80;
        [FieldOffset(0x2DC0)] public FishingFishParam fish__arr81;
        [FieldOffset(0x2E00)] public FishingFishParam fish__arr82;
        [FieldOffset(0x2E40)] public FishingFishParam fish__arr83;
        [FieldOffset(0x2E80)] public FishingFishParam fish__arr84;
        [FieldOffset(0x2EC0)] public FishingFishParam fish__arr85;
        [FieldOffset(0x2F00)] public FishingFishParam fish__arr86;
        [FieldOffset(0x2F40)] public FishingFishParam fish__arr87;
        [FieldOffset(0x2F80)] public FishingFishParam fish__arr88;
        [FieldOffset(0x2FC0)] public FishingFishParam fish__arr89;
        [FieldOffset(0x3000)] public FishingFishParam fish__arr90;
        [FieldOffset(0x3040)] public FishingFishParam fish__arr91;
        [FieldOffset(0x3080)] public FishingFishParam fish__arr92;
        [FieldOffset(0x30C0)] public FishingFishParam fish__arr93;
        [FieldOffset(0x3100)] public FishingFishParam fish__arr94;
        [FieldOffset(0x3140)] public FishingFishParam fish__arr95;
        [FieldOffset(0x3180)] public FishingFishParam fish__arr96;
        [FieldOffset(0x31C0)] public FishingFishParam fish__arr97;
        [FieldOffset(0x3200)] public FishingFishParam fish__arr98;
        [FieldOffset(0x3240)] public FishingFishParam fish__arr99;
        [FieldOffset(0x3280)] public FishingFishParam fish__arr100;
        [FieldOffset(0x32C0)] public FishingFishParam fish__arr101;
        [FieldOffset(0x3300)] public FishingFishParam fish__arr102;
        [FieldOffset(0x3340)] public FishingFishParam fish__arr103;
        [FieldOffset(0x3380)] public FishingFishParam fish__arr104;
        [FieldOffset(0x33C0)] public FishingFishParam fish__arr105;
        [FieldOffset(0x3400)] public FishingFishParam fish__arr106;
        [FieldOffset(0x3440)] public FishingFishParam fish__arr107;
        [FieldOffset(0x3480)] public FishingFishParam fish__arr108;
        [FieldOffset(0x34C0)] public FishingFishParam fish__arr109;
        [FieldOffset(0x3500)] public FishingFishParam fish__arr110;
        [FieldOffset(0x3540)] public FishingFishParam fish__arr111;
        [FieldOffset(0x3580)] public FishingFishParam fish__arr112;
        [FieldOffset(0x35C0)] public FishingFishParam fish__arr113;
        [FieldOffset(0x3600)] public FishingFishParam fish__arr114;
        [FieldOffset(0x3640)] public FishingFishParam fish__arr115;
        [FieldOffset(0x3680)] public FishingFishParam fish__arr116;
        [FieldOffset(0x36C0)] public FishingFishParam fish__arr117;
        [FieldOffset(0x3700)] public FishingFishParam fish__arr118;
        [FieldOffset(0x3740)] public FishingFishParam fish__arr119;
        [FieldOffset(0x3780)] public FishingFishParam fish__arr120;
        [FieldOffset(0x37C0)] public FishingFishParam fish__arr121;
        [FieldOffset(0x3800)] public FishingFishParam fish__arr122;
        [FieldOffset(0x3840)] public FishingFishParam fish__arr123;
        [FieldOffset(0x3880)] public FishingFishParam fish__arr124;
        [FieldOffset(0x38C0)] public FishingFishParam fish__arr125;
        [FieldOffset(0x3900)] public FishingFishParam fish__arr126;
        [FieldOffset(0x3940)] public FishingFishParam fish__arr127;
        [FieldOffset(0x3980)] public FishingFishParam fish__arr128;
        [FieldOffset(0x39C0)] public FishingFishParam fish__arr129;
        [FieldOffset(0x3A00)] public FishingSpotParam spot;
        [FieldOffset(0x41C0)] public FishingTutorialParam tutorial;
        [FieldOffset(0x46B8)] public FishingTradeParam trade;
    }

}