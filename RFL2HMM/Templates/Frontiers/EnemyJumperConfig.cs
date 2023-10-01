using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyJumperConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct EnemyJumperPatrolConfig
    {
        [FieldOffset(0x00)] public float rotateSpeedMin;
        [FieldOffset(0x04)] public float rotateSpeedMax;
        [FieldOffset(0x08)] public float speedMin;
        [FieldOffset(0x0C)] public float speedMax;
        [FieldOffset(0x10)] public float changeTimeIdlePatrolMin;
        [FieldOffset(0x14)] public float changeTimeIdlePatrolMax;
        [FieldOffset(0x18)] public float lockonDistance;
        [FieldOffset(0x1C)] public float unlockDistance;
        [FieldOffset(0x20)] public float distance;
        [FieldOffset(0x24)] public float minElevation;
        [FieldOffset(0x28)] public float maxElevation;
        [FieldOffset(0x2C)] public float panningSuspensionK;
        [FieldOffset(0x30)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct EnemyJumperAutoLockonParam
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float lockOnMinDistance;
        [FieldOffset(0x10)] public Vector3 playerOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct EnemyJumperCommonParam
    {
        [FieldOffset(0x00)] public float killWaitTime;
        [FieldOffset(0x04)] public float colliderRadius;
        [FieldOffset(0x08)] public float colliderHeight;
        [FieldOffset(0x0C)] public float headRadius;
        [FieldOffset(0x10)] public float headHeight;
        [FieldOffset(0x14)] public float damageColliderRadiusOffset;
        [FieldOffset(0x18)] public float eyesightDistance;
        [FieldOffset(0x1C)] public float maxSpeed;
        [FieldOffset(0x20)] public float checkBarrierDistance;
        [FieldOffset(0x24)] public EnemyJumperPatrolConfig patrolConfig;
        [FieldOffset(0x60)] public EnemyJumperAutoLockonParam lockonCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct EnemyJumperCommonLevelParam
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyJumperLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public EnemyJumperCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct EnemyJumperLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct CharacterControllerCollision
    {
        [FieldOffset(0x00)] public float height;
        [FieldOffset(0x04)] public float radius;
        [FieldOffset(0x10)] public Vector3 offset;
        [FieldOffset(0x20)] public Vector3 scale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MovementParam
    {
        [FieldOffset(0x00)] public float rotateSpeedMin;
        [FieldOffset(0x04)] public float rotateSpeedMax;
        [FieldOffset(0x08)] public float speedMin;
        [FieldOffset(0x0C)] public float speedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct SpringPlayer
    {
        [FieldOffset(0x00)] public float velocity;
        [FieldOffset(0x04)] public float targetCursorMaxDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BattleParam
    {
        [FieldOffset(0x00)] public float stompingRange;
        [FieldOffset(0x04)] public float stompingTotalNum;
        [FieldOffset(0x08)] public float interpalTimeFinal;
        [FieldOffset(0x0C)] public float range;
        [FieldOffset(0x10)] public float riseDistance;
        [FieldOffset(0x14)] public float riseTime;
        [FieldOffset(0x18)] public float upLoopTime;
        [FieldOffset(0x1C)] public float chaseSpeed;
        [FieldOffset(0x20)] public float speed;
        [FieldOffset(0x24)] public float groundImpactRadius;
        [FieldOffset(0x28)] public SpringPlayer springPlayer;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x160)]
    public struct EnemyJumperConfig
    {
        [FieldOffset(0x00)] public EnemyJumperCommonParam commonParam;
        [FieldOffset(0x80)] public EnemyJumperLevelParam levelParams__arr0;
        [FieldOffset(0x90)] public EnemyJumperLevelParam levelParams__arr1;
        [FieldOffset(0xA0)] public EnemyJumperLevelParam levelParams__arr2;
        [FieldOffset(0xB0)] public EnemyJumperLevelParam levelParams__arr3;
        [FieldOffset(0xC0)] public EnemyJumperLevelParam levelParams__arr4;
        [FieldOffset(0xD0)] public EnemyJumperLevelBand levelBand__arr0;
        [FieldOffset(0xD4)] public EnemyJumperLevelBand levelBand__arr1;
        [FieldOffset(0xD8)] public EnemyJumperLevelBand levelBand__arr2;
        [FieldOffset(0xDC)] public EnemyJumperLevelBand levelBand__arr3;
        [FieldOffset(0xE0)] public EnemyJumperLevelBand levelBand__arr4;
        [FieldOffset(0xF0)] public CharacterControllerCollision characterControllerCollision;
        [FieldOffset(0x120)] public MovementParam movement;
        [FieldOffset(0x130)] public BattleParam battleParam;
    }

}