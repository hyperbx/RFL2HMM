using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyJumperSubConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct EnemyJumperSubCommonParam
    {
        [FieldOffset(0x00)] public float killWaitTime;
        [FieldOffset(0x04)] public float colliderRadius;
        [FieldOffset(0x08)] public float colliderHeight;
        [FieldOffset(0x0C)] public float damageColliderRadiusOffset;
        [FieldOffset(0x10)] public float eyesightDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct EnemyJumperSubCommonLevelParam
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyJumperSubLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public EnemyJumperSubCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct EnemyJumperSubLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x78)]
    public struct EnemyJumperSubConfig
    {
        [FieldOffset(0x00)] public EnemyJumperSubCommonParam commonParam;
        [FieldOffset(0x14)] public EnemyJumperSubLevelParam levelParams__arr0;
        [FieldOffset(0x24)] public EnemyJumperSubLevelParam levelParams__arr1;
        [FieldOffset(0x34)] public EnemyJumperSubLevelParam levelParams__arr2;
        [FieldOffset(0x44)] public EnemyJumperSubLevelParam levelParams__arr3;
        [FieldOffset(0x54)] public EnemyJumperSubLevelParam levelParams__arr4;
        [FieldOffset(0x64)] public EnemyJumperSubLevelBand levelBand__arr0;
        [FieldOffset(0x68)] public EnemyJumperSubLevelBand levelBand__arr1;
        [FieldOffset(0x6C)] public EnemyJumperSubLevelBand levelBand__arr2;
        [FieldOffset(0x70)] public EnemyJumperSubLevelBand levelBand__arr3;
        [FieldOffset(0x74)] public EnemyJumperSubLevelBand levelBand__arr4;
    }

}