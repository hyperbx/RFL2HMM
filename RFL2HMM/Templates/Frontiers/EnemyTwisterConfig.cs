using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyTwisterConfigClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct DebrisParameter
    {
        [FieldOffset(0x00)] public int m_maxNumPieces;
        [FieldOffset(0x04)] public float gravity;
        [FieldOffset(0x08)] public float lifeTime;
        [FieldOffset(0x0C)] public float force;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct EnemyTwisterCommonConfig
    {
        [FieldOffset(0x00)] public RingParameter ringParam;
        [FieldOffset(0x1C)] public float rigidColliderRadius;
        [FieldOffset(0x20)] public float damageColliderRadius;
        [FieldOffset(0x24)] public float battleDistance;
        [FieldOffset(0x28)] public float cyloopHeight;
        [FieldOffset(0x2C)] public float rotateSpeed;
        [FieldOffset(0x30)] public bool useUniqueDebrisSetting;
        [FieldOffset(0x34)] public DebrisParameter debris;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct TwisterCommonLevelConfig
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyTwisterLevelConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public TwisterCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x94)]
    public struct EnemyTwisterConfig
    {
        [FieldOffset(0x00)] public EnemyTwisterCommonConfig commonParams;
        [FieldOffset(0x44)] public EnemyTwisterLevelConfig levelParams__arr0;
        [FieldOffset(0x54)] public EnemyTwisterLevelConfig levelParams__arr1;
        [FieldOffset(0x64)] public EnemyTwisterLevelConfig levelParams__arr2;
        [FieldOffset(0x74)] public EnemyTwisterLevelConfig levelParams__arr3;
        [FieldOffset(0x84)] public EnemyTwisterLevelConfig levelParams__arr4;
    }

}