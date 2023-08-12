using System.Numerics;
using System.Runtime.InteropServices;

public class EnemySniperConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public struct RingParameter
    {
        [FieldOffset(0)]  public float suckedTime;
        [FieldOffset(4)]  public float launchAngle;
        [FieldOffset(8)]  public float launchMaxSpeed;
        [FieldOffset(12)] public float launchMinSpeed;
        [FieldOffset(16)] public float randomRangeMin;
        [FieldOffset(20)] public float randomRangeMax;
        [FieldOffset(24)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 88)]
    public struct EnemySniperCommonConfig
    {
        [FieldOffset(0)]  public RingParameter ringParam;
        [FieldOffset(28)] public int codeDropNumMin;
        [FieldOffset(32)] public int codeDropNumMax;
        [FieldOffset(36)] public int codeXDropNumMin;
        [FieldOffset(40)] public int codeXDropNumMax;
        [FieldOffset(44)] public float eyesightDistancePatrol;
        [FieldOffset(48)] public float eyesightDistanceBattle;
        [FieldOffset(52)] public float hideCoreDistance;
        [FieldOffset(56)] public float showCoreDistance;
        [FieldOffset(60)] public float guardShotWaitTime;
        [FieldOffset(64)] public float guardShotAngle;
        [FieldOffset(68)] public float aimBendSpeed;
        [FieldOffset(72)] public float muzzleShrinkStartDist;
        [FieldOffset(76)] public float muzzleShrinkEndDist;
        [FieldOffset(80)] public float snipeMaxAngle;
        [FieldOffset(84)] public float guardMaxAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public struct SniperCommonLevelConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public int maxGuardPoint;
        [FieldOffset(8)]  public float stunTime;
        [FieldOffset(12)] public float attackRate;
        [FieldOffset(16)] public ushort expItemNum;
        [FieldOffset(18)] public ushort exp;
        [FieldOffset(20)] public float snipeRotateSpeed;
        [FieldOffset(24)] public float chargeRotateSpeed;
        [FieldOffset(28)] public float predictRotateSpeed;
        [FieldOffset(32)] public float snipeWaitTime;
        [FieldOffset(36)] public float snipeShotSpeed;
        [FieldOffset(40)] public float snipeIntervalTime;
        [FieldOffset(44)] public float predictTime;
        [FieldOffset(48)] public float predictAngleRange;
        [FieldOffset(52)] public float guardShotSpeed;
        [FieldOffset(56)] public float guardShotRotateSpeed;
        [FieldOffset(60)] public float guardShotMotionSpeed;
        [FieldOffset(64)] public float guardShotLifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public struct EnemySniperLevelConfig
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public SniperCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct SniperCommonActionConfig
    {
        [FieldOffset(0)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct EnemySniperLevelBandConfig
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public SniperCommonActionConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 488)]
    public struct EnemySniperConfig
    {
        [FieldOffset(0)]   public EnemySniperCommonConfig commonParams;
        [FieldOffset(88)]  public EnemySniperLevelConfig levelParams__arr0;
        [FieldOffset(160)] public EnemySniperLevelConfig levelParams__arr1;
        [FieldOffset(232)] public EnemySniperLevelConfig levelParams__arr2;
        [FieldOffset(304)] public EnemySniperLevelConfig levelParams__arr3;
        [FieldOffset(376)] public EnemySniperLevelConfig levelParams__arr4;
        [FieldOffset(448)] public EnemySniperLevelBandConfig levelBands__arr0;
        [FieldOffset(456)] public EnemySniperLevelBandConfig levelBands__arr1;
        [FieldOffset(464)] public EnemySniperLevelBandConfig levelBands__arr2;
        [FieldOffset(472)] public EnemySniperLevelBandConfig levelBands__arr3;
        [FieldOffset(480)] public EnemySniperLevelBandConfig levelBands__arr4;
    }

}