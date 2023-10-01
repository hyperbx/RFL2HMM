using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyBubbleConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct EnemyBubbleApproachConfig
    {
        [FieldOffset(0x00)] public float moveMinDistance;
        [FieldOffset(0x04)] public float moveSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyBubbleBlitzProtectionReadyConfig
    {
        [FieldOffset(0x00)] public float moveMinDistance;
        [FieldOffset(0x04)] public float moveSpeedMax;
        [FieldOffset(0x08)] public float blitzProtectionMaxDistance;
        [FieldOffset(0x0C)] public float blitzProtectionReadyTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyBubbleBlitzProtectionConfig
    {
        [FieldOffset(0x00)] public float moveMinDistance;
        [FieldOffset(0x04)] public float moveSpeedMax;
        [FieldOffset(0x08)] public float blitzProtectionAttackTime;
        [FieldOffset(0x0C)] public float blitzProtectionIntervalTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct EnemyBubbleShellConfig
    {
        [FieldOffset(0x00)] public float baseHeight;
        [FieldOffset(0x04)] public float innerDistance;
        [FieldOffset(0x08)] public float outerDistance;
        [FieldOffset(0x0C)] public float innerRadius;
        [FieldOffset(0x10)] public float outerRadius;
        [FieldOffset(0x14)] public float innerAccelMax;
        [FieldOffset(0x18)] public float outerAccelMax;
        [FieldOffset(0x1C)] public float innerSpeedMax;
        [FieldOffset(0x20)] public float outerSpeedMax;
        [FieldOffset(0x24)] public byte innerNum;
        [FieldOffset(0x25)] public byte outerNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x7C)]
    public struct EnemyBubbleCommonParam
    {
        [FieldOffset(0x00)] public float killWaitTime;
        [FieldOffset(0x04)] public float colliderRadius;
        [FieldOffset(0x08)] public float damageColliderRadiusOffset;
        [FieldOffset(0x0C)] public float attackColliderRadiusOffset;
        [FieldOffset(0x10)] public float eyesightDistance;
        [FieldOffset(0x14)] public float moveAccerleration;
        [FieldOffset(0x18)] public float moveDeceleration;
        [FieldOffset(0x1C)] public float rotationAngleMax;
        [FieldOffset(0x20)] public float mass;
        [FieldOffset(0x24)] public float slopeAngleMax;
        [FieldOffset(0x28)] public float knockBackTime;
        [FieldOffset(0x2C)] public EnemyBubbleApproachConfig approachConfig;
        [FieldOffset(0x34)] public EnemyBubbleBlitzProtectionReadyConfig blitzReadyConfig;
        [FieldOffset(0x44)] public EnemyBubbleBlitzProtectionConfig blitzConfig;
        [FieldOffset(0x54)] public EnemyBubbleShellConfig shellConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct EnemyBubbleCommonLevelParam
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyBubbleLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public EnemyBubbleCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct EnemyBubbleLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE0)]
    public struct EnemyBubbleConfig
    {
        [FieldOffset(0x00)] public EnemyBubbleCommonParam commonParam;
        [FieldOffset(0x7C)] public EnemyBubbleLevelParam levelParams__arr0;
        [FieldOffset(0x8C)] public EnemyBubbleLevelParam levelParams__arr1;
        [FieldOffset(0x9C)] public EnemyBubbleLevelParam levelParams__arr2;
        [FieldOffset(0xAC)] public EnemyBubbleLevelParam levelParams__arr3;
        [FieldOffset(0xBC)] public EnemyBubbleLevelParam levelParams__arr4;
        [FieldOffset(0xCC)] public EnemyBubbleLevelBand levelBand__arr0;
        [FieldOffset(0xD0)] public EnemyBubbleLevelBand levelBand__arr1;
        [FieldOffset(0xD4)] public EnemyBubbleLevelBand levelBand__arr2;
        [FieldOffset(0xD8)] public EnemyBubbleLevelBand levelBand__arr3;
        [FieldOffset(0xDC)] public EnemyBubbleLevelBand levelBand__arr4;
    }

}