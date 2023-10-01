using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyAquaballConfigClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct EnemyAquaballPatrolConfig
    {
        [FieldOffset(0x00)] public float rotateSpeedMin;
        [FieldOffset(0x04)] public float rotateSpeedMax;
        [FieldOffset(0x08)] public float speedMin;
        [FieldOffset(0x0C)] public float speedMax;
        [FieldOffset(0x10)] public float moveSpeed;
        [FieldOffset(0x14)] public float bounceHeight;
        [FieldOffset(0x18)] public float bounceInterval;
        [FieldOffset(0x1C)] public float movePointUpdateInterval;
        [FieldOffset(0x20)] public float addForceOfHA;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct EnemyAquaballActionConfig
    {
        [FieldOffset(0x00)] public int maxSuccessCount;
        [FieldOffset(0x04)] public Vector2 bounceSuccessTiming__arr0;
        [FieldOffset(0x14)] public Vector2 bounceSuccessTiming__arr1;
        [FieldOffset(0x24)] public Vector2 bounceSuccessTiming__arr2;
        [FieldOffset(0x1C)] public float captureLimitTime;
        [FieldOffset(0x20)] public float captureLimitHeight;
        [FieldOffset(0x24)] public float failLimitTime;
        [FieldOffset(0x28)] public float failNoticeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x88)]
    public struct EnemyAquaballCommonParam
    {
        [FieldOffset(0x00)] public float killWaitTime;
        [FieldOffset(0x04)] public float colliderRadius;
        [FieldOffset(0x08)] public float colliderHeight;
        [FieldOffset(0x0C)] public float damageColliderRadiusOffset;
        [FieldOffset(0x10)] public float hitPlayerColliderRadiusOffset;
        [FieldOffset(0x14)] public float checkBarrierDistance;
        [FieldOffset(0x18)] public float battleDistance;
        [FieldOffset(0x1C)] public RingParameter ringParam;
        [FieldOffset(0x38)] public EnemyAquaballPatrolConfig patrolConfig;
        [FieldOffset(0x5C)] public EnemyAquaballActionConfig actionConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct EnemyAquaballCommonLevelParam
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyAquaballLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public EnemyAquaballCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct EnemyAquaballLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xEC)]
    public struct EnemyAquaballConfig
    {
        [FieldOffset(0x00)] public EnemyAquaballCommonParam commonParam;
        [FieldOffset(0x88)] public EnemyAquaballLevelParam levelParams__arr0;
        [FieldOffset(0x98)] public EnemyAquaballLevelParam levelParams__arr1;
        [FieldOffset(0xA8)] public EnemyAquaballLevelParam levelParams__arr2;
        [FieldOffset(0xB8)] public EnemyAquaballLevelParam levelParams__arr3;
        [FieldOffset(0xC8)] public EnemyAquaballLevelParam levelParams__arr4;
        [FieldOffset(0xD8)] public EnemyAquaballLevelBand levelBand__arr0;
        [FieldOffset(0xDC)] public EnemyAquaballLevelBand levelBand__arr1;
        [FieldOffset(0xE0)] public EnemyAquaballLevelBand levelBand__arr2;
        [FieldOffset(0xE4)] public EnemyAquaballLevelBand levelBand__arr3;
        [FieldOffset(0xE8)] public EnemyAquaballLevelBand levelBand__arr4;
    }

}