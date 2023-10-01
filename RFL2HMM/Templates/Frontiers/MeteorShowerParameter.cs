using System.Numerics;
using System.Runtime.InteropServices;

public class MeteorShowerParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct MeteorShowerEffectParameter
    {
        [FieldOffset(0x00)] public float spawnIntervalMax;
        [FieldOffset(0x04)] public float spawnIntervalMin;
        [FieldOffset(0x08)] public float spawnHeightMax;
        [FieldOffset(0x0C)] public float spawnHeightMin;
        [FieldOffset(0x10)] public float spawnHorizonMax;
        [FieldOffset(0x14)] public float spawnHorizonMin;
        [FieldOffset(0x18)] public float speedMax;
        [FieldOffset(0x1C)] public float speedMin;
        [FieldOffset(0x20)] public float lengthMax;
        [FieldOffset(0x24)] public float lengthMin;
        [FieldOffset(0x28)] public float width;
        [FieldOffset(0x2C)] public float angleMax;
        [FieldOffset(0x30)] public float angleMin;
        [FieldOffset(0x34)] public float moveTimeMax;
        [FieldOffset(0x38)] public float moveTimeMin;
        [FieldOffset(0x3C)] public float fadeTimeMax;
        [FieldOffset(0x40)] public float fadeTimeMin;
        [FieldOffset(0x44)] public float spawnAngle;
        [FieldOffset(0x50)] public Vector3 color;
    }

    public enum Symbol : sbyte
    {
        Invalid = -1,
        Seven = 0,
        Bar = 1,
        Fruit = 2,
        Bell = 3,
        NumSymbols = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct ReelParam
    {
        [FieldOffset(0x00)] public Symbol symbols__arr0;
        [FieldOffset(0x01)] public Symbol symbols__arr1;
        [FieldOffset(0x02)] public Symbol symbols__arr2;
        [FieldOffset(0x03)] public Symbol symbols__arr3;
        [FieldOffset(0x04)] public Symbol symbols__arr4;
        [FieldOffset(0x05)] public Symbol symbols__arr5;
        [FieldOffset(0x06)] public Symbol symbols__arr6;
        [FieldOffset(0x07)] public Symbol symbols__arr7;
        [FieldOffset(0x08)] public Symbol symbols__arr8;
        [FieldOffset(0x09)] public Symbol symbols__arr9;
        [FieldOffset(0x0A)] public Symbol symbols__arr10;
        [FieldOffset(0x0B)] public Symbol symbols__arr11;
        [FieldOffset(0x0C)] public Symbol symbols__arr12;
        [FieldOffset(0x0D)] public Symbol symbols__arr13;
        [FieldOffset(0x0E)] public Symbol symbols__arr14;
        [FieldOffset(0x0F)] public Symbol symbols__arr15;
        [FieldOffset(0x10)] public float spinSpeedMin;
        [FieldOffset(0x14)] public float spinSpeedMax;
        [FieldOffset(0x18)] public float autoStopTimeMin;
        [FieldOffset(0x1C)] public float autoStopTimeMax;
    }

    public enum RateInfo_Symbol : sbyte
    {
        RateInfo_Symbol_Invalid = -1,
        RateInfo_Symbol_Seven = 0,
        RateInfo_Symbol_Bar = 1,
        RateInfo_Symbol_Fruit = 2,
        RateInfo_Symbol_Bell = 3,
        RateInfo_Symbol_NumSymbols = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct RateInfo
    {
        [FieldOffset(0x00)] public RateInfo_Symbol symbols__arr0;
        [FieldOffset(0x01)] public RateInfo_Symbol symbols__arr1;
        [FieldOffset(0x02)] public RateInfo_Symbol symbols__arr2;
        [FieldOffset(0x04)] public float rate;
    }

    public enum CeilingInfo_Symbol : sbyte
    {
        CeilingInfo_Symbol_Invalid = -1,
        CeilingInfo_Symbol_Seven = 0,
        CeilingInfo_Symbol_Bar = 1,
        CeilingInfo_Symbol_Fruit = 2,
        CeilingInfo_Symbol_Bell = 3,
        CeilingInfo_Symbol_NumSymbols = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct CeilingInfo
    {
        [FieldOffset(0x00)] public CeilingInfo_Symbol symbols__arr0;
        [FieldOffset(0x01)] public CeilingInfo_Symbol symbols__arr1;
        [FieldOffset(0x02)] public CeilingInfo_Symbol symbols__arr2;
        [FieldOffset(0x04)] public uint rollCount;
    }

    public enum PayoutInfo_Symbol : sbyte
    {
        PayoutInfo_Symbol_Invalid = -1,
        PayoutInfo_Symbol_Seven = 0,
        PayoutInfo_Symbol_Bar = 1,
        PayoutInfo_Symbol_Fruit = 2,
        PayoutInfo_Symbol_Bell = 3,
        PayoutInfo_Symbol_NumSymbols = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct PayoutInfo
    {
        [FieldOffset(0x00)] public PayoutInfo_Symbol symbols__arr0;
        [FieldOffset(0x01)] public PayoutInfo_Symbol symbols__arr1;
        [FieldOffset(0x02)] public PayoutInfo_Symbol symbols__arr2;
        [FieldOffset(0x04)] public uint payout;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xD8)]
    public struct ObjBonusSlotConfig
    {
        [FieldOffset(0x00)] public ReelParam reelParams__arr0;
        [FieldOffset(0x20)] public ReelParam reelParams__arr1;
        [FieldOffset(0x40)] public ReelParam reelParams__arr2;
        [FieldOffset(0x60)] public float spinInterval;
        [FieldOffset(0x64)] public RateInfo rateInfos__arr0;
        [FieldOffset(0x6C)] public RateInfo rateInfos__arr1;
        [FieldOffset(0x74)] public RateInfo rateInfos__arr2;
        [FieldOffset(0x7C)] public RateInfo rateInfos__arr3;
        [FieldOffset(0x84)] public CeilingInfo ceilingInfos__arr0;
        [FieldOffset(0x8C)] public CeilingInfo ceilingInfos__arr1;
        [FieldOffset(0x94)] public CeilingInfo ceilingInfos__arr2;
        [FieldOffset(0x9C)] public CeilingInfo ceilingInfos__arr3;
        [FieldOffset(0xA4)] public PayoutInfo payoutInfos__arr0;
        [FieldOffset(0xAC)] public PayoutInfo payoutInfos__arr1;
        [FieldOffset(0xB4)] public PayoutInfo payoutInfos__arr2;
        [FieldOffset(0xBC)] public PayoutInfo payoutInfos__arr3;
        [FieldOffset(0xC4)] public uint payoutOnBlank;
        [FieldOffset(0xC8)] public bool WinEvenWithPush;
        [FieldOffset(0xCC)] public float retrySpeed;
        [FieldOffset(0xD0)] public float backSpeed;
        [FieldOffset(0xD4)] public float stepSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x170)]
    public struct MeteorShowerParameter
    {
        [FieldOffset(0x00)] public float rangeFromSonicObjectsDontRespawn;
        [FieldOffset(0x04)] public uint intervalDay;
        [FieldOffset(0x08)] public uint startHour;
        [FieldOffset(0x0C)] public uint startMinute;
        [FieldOffset(0x10)] public uint durationHour;
        [FieldOffset(0x14)] public uint durationMinute;
        [FieldOffset(0x18)] public uint extraIslandSeedRate;
        [FieldOffset(0x1C)] public uint extraIslandKodamaRate;
        [FieldOffset(0x20)] public uint extraIntervalDay;
        [FieldOffset(0x30)] public MeteorShowerEffectParameter effect;
        [FieldOffset(0x90)] public ObjBonusSlotConfig bonusSlotConfig;
    }

}