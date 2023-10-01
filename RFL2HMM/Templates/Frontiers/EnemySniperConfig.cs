using System.Numerics;
using System.Runtime.InteropServices;

public class EnemySniperConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct RingParameter
    {
        [FieldOffset(0x00)] public float suckedTime;
        [FieldOffset(0x04)] public float launchAngle;
        [FieldOffset(0x08)] public float launchMaxSpeed;
        [FieldOffset(0x0C)] public float launchMinSpeed;
        [FieldOffset(0x10)] public float randomRangeMin;
        [FieldOffset(0x14)] public float randomRangeMax;
        [FieldOffset(0x18)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct EnemySniperCommonConfig
    {
        [FieldOffset(0x00)] public RingParameter ringParam;
        [FieldOffset(0x1C)] public int codeDropNumMin;
        [FieldOffset(0x20)] public int codeDropNumMax;
        [FieldOffset(0x24)] public int codeXDropNumMin;
        [FieldOffset(0x28)] public int codeXDropNumMax;
        [FieldOffset(0x2C)] public float eyesightDistancePatrol;
        [FieldOffset(0x30)] public float eyesightDistanceBattle;
        [FieldOffset(0x34)] public float hideCoreDistance;
        [FieldOffset(0x38)] public float showCoreDistance;
        [FieldOffset(0x3C)] public float guardShotWaitTime;
        [FieldOffset(0x40)] public float guardShotAngle;
        [FieldOffset(0x44)] public float aimBendSpeed;
        [FieldOffset(0x48)] public float muzzleShrinkStartDist;
        [FieldOffset(0x4C)] public float muzzleShrinkEndDist;
        [FieldOffset(0x50)] public float snipeMaxAngle;
        [FieldOffset(0x54)] public float guardMaxAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct SniperCommonLevelConfig
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public int maxGuardPoint;
        [FieldOffset(0x08)] public float stunTime;
        [FieldOffset(0x0C)] public float attackRate;
        [FieldOffset(0x10)] public ushort expItemNum;
        [FieldOffset(0x12)] public ushort exp;
        [FieldOffset(0x14)] public float snipeRotateSpeed;
        [FieldOffset(0x18)] public float chargeRotateSpeed;
        [FieldOffset(0x1C)] public float predictRotateSpeed;
        [FieldOffset(0x20)] public float snipeWaitTime;
        [FieldOffset(0x24)] public float snipeShotSpeed;
        [FieldOffset(0x28)] public float snipeIntervalTime;
        [FieldOffset(0x2C)] public float predictTime;
        [FieldOffset(0x30)] public float predictAngleRange;
        [FieldOffset(0x34)] public float guardShotSpeed;
        [FieldOffset(0x38)] public float guardShotRotateSpeed;
        [FieldOffset(0x3C)] public float guardShotMotionSpeed;
        [FieldOffset(0x40)] public float guardShotLifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x48)]
    public struct EnemySniperLevelConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public SniperCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct SniperCommonActionConfig
    {
        [FieldOffset(0x00)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct EnemySniperLevelBandConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public SniperCommonActionConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1E8)]
    public struct EnemySniperConfig
    {
        [FieldOffset(0x00)] public EnemySniperCommonConfig commonParams;
        [FieldOffset(0x58)] public EnemySniperLevelConfig levelParams__arr0;
        [FieldOffset(0xA0)] public EnemySniperLevelConfig levelParams__arr1;
        [FieldOffset(0xE8)] public EnemySniperLevelConfig levelParams__arr2;
        [FieldOffset(0x130)] public EnemySniperLevelConfig levelParams__arr3;
        [FieldOffset(0x178)] public EnemySniperLevelConfig levelParams__arr4;
        [FieldOffset(0x1C0)] public EnemySniperLevelBandConfig levelBands__arr0;
        [FieldOffset(0x1C8)] public EnemySniperLevelBandConfig levelBands__arr1;
        [FieldOffset(0x1D0)] public EnemySniperLevelBandConfig levelBands__arr2;
        [FieldOffset(0x1D8)] public EnemySniperLevelBandConfig levelBands__arr3;
        [FieldOffset(0x1E0)] public EnemySniperLevelBandConfig levelBands__arr4;
    }

}