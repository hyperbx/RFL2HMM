using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyRobberConfigClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct EnemyRobberCommonConfig
    {
        [FieldOffset(0x00)] public RingParameter ringParam;
        [FieldOffset(0x1C)] public float eyesightDistance;
        [FieldOffset(0x20)] public float idlingSpeed;
        [FieldOffset(0x24)] public float chasingSpeed;
        [FieldOffset(0x28)] public float escapeSpeed;
        [FieldOffset(0x2C)] public float escapeSpeedPlayerOnPath;
        [FieldOffset(0x30)] public float onBoardSpeed;
        [FieldOffset(0x34)] public float restTime;
        [FieldOffset(0x38)] public float railMaxLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct RobbberCommonLevelConfig
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyRobberLevelConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public RobbberCommonLevelConfig common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x8C)]
    public struct EnemyRobberConfig
    {
        [FieldOffset(0x00)] public EnemyRobberCommonConfig commonParams;
        [FieldOffset(0x3C)] public EnemyRobberLevelConfig levelParams__arr0;
        [FieldOffset(0x4C)] public EnemyRobberLevelConfig levelParams__arr1;
        [FieldOffset(0x5C)] public EnemyRobberLevelConfig levelParams__arr2;
        [FieldOffset(0x6C)] public EnemyRobberLevelConfig levelParams__arr3;
        [FieldOffset(0x7C)] public EnemyRobberLevelConfig levelParams__arr4;
    }

}