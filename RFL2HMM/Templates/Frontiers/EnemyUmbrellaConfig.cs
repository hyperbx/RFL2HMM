using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyUmbrellaConfigClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct EnemyUmbrellaCommonConfig
    {
        [FieldOffset(0x00)] public RingParameter ringParam;
        [FieldOffset(0x1C)] public int codeDropNumMin;
        [FieldOffset(0x20)] public int codeDropNumMax;
        [FieldOffset(0x24)] public int codeXDropNumMin;
        [FieldOffset(0x28)] public int codeXDropNumMax;
        [FieldOffset(0x2C)] public float closeDistance;
        [FieldOffset(0x30)] public float cameraDistance;
        [FieldOffset(0x34)] public float cameraElevation;
        [FieldOffset(0x38)] public float pullStartHeight;
        [FieldOffset(0x3C)] public float pullEndHeight;
    }

    public enum BarrageType : byte
    {
        BOX = 0,
        CONE = 1,
        FAN = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct UmbrellaCommonLevelConfig
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
        [FieldOffset(0x0C)] public float backJumpHeight;
        [FieldOffset(0x10)] public float backJumpDistance;
        [FieldOffset(0x14)] public float flyingDuration;
        [FieldOffset(0x18)] public BarrageType barrageType;
        [FieldOffset(0x1C)] public float barrageHeight;
        [FieldOffset(0x20)] public float barrageWidth;
        [FieldOffset(0x24)] public float barrageDistance;
        [FieldOffset(0x28)] public float bombRatio;
        [FieldOffset(0x2C)] public float barrageFallSpeed;
        [FieldOffset(0x30)] public float barrageLifeTime;
        [FieldOffset(0x34)] public float barrageLifePassPower;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct EnemyUmbrellaLevelConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public UmbrellaCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct UmbrellaCommonActionConfig
    {
        [FieldOffset(0x00)] public int dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct EnemyUmbrellaLevelBandConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public UmbrellaCommonActionConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x194)]
    public struct EnemyUmbrellaConfig
    {
        [FieldOffset(0x00)] public EnemyUmbrellaCommonConfig commonParams;
        [FieldOffset(0x40)] public EnemyUmbrellaLevelConfig levelParams__arr0;
        [FieldOffset(0x7C)] public EnemyUmbrellaLevelConfig levelParams__arr1;
        [FieldOffset(0xB8)] public EnemyUmbrellaLevelConfig levelParams__arr2;
        [FieldOffset(0xF4)] public EnemyUmbrellaLevelConfig levelParams__arr3;
        [FieldOffset(0x130)] public EnemyUmbrellaLevelConfig levelParams__arr4;
        [FieldOffset(0x16C)] public EnemyUmbrellaLevelBandConfig levelBands__arr0;
        [FieldOffset(0x174)] public EnemyUmbrellaLevelBandConfig levelBands__arr1;
        [FieldOffset(0x17C)] public EnemyUmbrellaLevelBandConfig levelBands__arr2;
        [FieldOffset(0x184)] public EnemyUmbrellaLevelBandConfig levelBands__arr3;
        [FieldOffset(0x18C)] public EnemyUmbrellaLevelBandConfig levelBands__arr4;
    }

}