using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossStriderConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossCommonConfig
    {
        [FieldOffset(0x00)] public float scoutDistance;
        [FieldOffset(0x04)] public float scoutDistanceOutside;
        [FieldOffset(0x08)] public float zoomDistance;
        [FieldOffset(0x10)] public Vector3 zoomOffset;
        [FieldOffset(0x20)] public Vector3 zoomAngle;
        [FieldOffset(0x30)] public float zoomFov;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossStriderCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct MiniBossLevelCommonConfig
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float maxStunPoint__arr0;
        [FieldOffset(0x08)] public float maxStunPoint__arr1;
        [FieldOffset(0x0C)] public float maxStunPoint__arr2;
        [FieldOffset(0x10)] public float stunDecreaseStartTime;
        [FieldOffset(0x14)] public float stunDecreaseSpeed;
        [FieldOffset(0x18)] public float maxStaggerPoint__arr0;
        [FieldOffset(0x1C)] public float maxStaggerPoint__arr1;
        [FieldOffset(0x20)] public float maxStaggerPoint__arr2;
        [FieldOffset(0x24)] public float staggerDecreaseStartTime;
        [FieldOffset(0x28)] public float staggerDecreaseSpeed;
        [FieldOffset(0x2C)] public float attackRate;
        [FieldOffset(0x30)] public ushort expItemNum;
        [FieldOffset(0x32)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct MiniBossStriderLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct MiniBossStriderLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    public enum MeansOfAttack : byte
    {
        Bullet = 0,
        Laser = 1,
        NumAttackTypes = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct AttackInfo
    {
        [FieldOffset(0x00)] public MeansOfAttack meansOfAttack;
        [FieldOffset(0x01)] public bool enabled;
        [FieldOffset(0x04)] public float attackInterval;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct AttackPhase
    {
        [FieldOffset(0x00)] public AttackInfo attackInfos__arr0;
        [FieldOffset(0x08)] public AttackInfo attackInfos__arr1;
        [FieldOffset(0x10)] public float triggeredHPRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x8C)]
    public struct MiniBossStriderParam
    {
        [FieldOffset(0x00)] public AttackPhase attackPhases__arr0;
        [FieldOffset(0x14)] public AttackPhase attackPhases__arr1;
        [FieldOffset(0x28)] public AttackPhase attackPhases__arr2;
        [FieldOffset(0x3C)] public float initialAttackWaitBullet;
        [FieldOffset(0x40)] public float initialAttackWaitLaser;
        [FieldOffset(0x44)] public float attackableTime;
        [FieldOffset(0x48)] public float railBulletAttackInterval;
        [FieldOffset(0x4C)] public float tentativePlatformTopYOffset;
        [FieldOffset(0x50)] public float tentativePlatformBottomYOffset;
        [FieldOffset(0x54)] public float tentativePlatformRadius;
        [FieldOffset(0x58)] public float cameraElevation;
        [FieldOffset(0x5C)] public float cameraFovy;
        [FieldOffset(0x60)] public float cameraDistance;
        [FieldOffset(0x64)] public float cameraDegreeForClockwiseMovement;
        [FieldOffset(0x68)] public float cameraDegreeForCounterClockwiseMovement;
        [FieldOffset(0x6C)] public float cameraLookAtPointOffsetY;
        [FieldOffset(0x70)] public float cameraMaxChangeableDegreeByStickInput;
        [FieldOffset(0x74)] public float cameraMaxDegreeChangedByStickInputPerSec;
        [FieldOffset(0x78)] public float attackableCameraElevation;
        [FieldOffset(0x7C)] public float attackableCameraDistance;
        [FieldOffset(0x80)] public float attackableCameraInterpolationTime;
        [FieldOffset(0x84)] public float attackableCameraDuration;
        [FieldOffset(0x88)] public bool enableAttackableCamera;
        [FieldOffset(0x89)] public bool enableStun;
        [FieldOffset(0x8A)] public bool enableStagger;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct ObjStriderGrindRailParam
    {
        [FieldOffset(0x00)] public float radius1;
        [FieldOffset(0x04)] public float radius2;
        [FieldOffset(0x08)] public float radius3;
        [FieldOffset(0x0C)] public float yOffset1;
        [FieldOffset(0x10)] public float yOffset2;
        [FieldOffset(0x14)] public float yOffset3;
        [FieldOffset(0x18)] public byte numRailBulletsFiredAtOnce;
        [FieldOffset(0x1C)] public float railBulletPreAttackEffectTime;
        [FieldOffset(0x20)] public float railBulletRadius;
        [FieldOffset(0x24)] public float railBulletSearchDistance;
        [FieldOffset(0x28)] public float maxJumpDistanceFromRailBullet;
        [FieldOffset(0x2C)] public float distToDestWithinWhichJumpIsDone;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct ObjStriderPlatformParam
    {
        [FieldOffset(0x00)] public float colliderRadius;
        [FieldOffset(0x04)] public float colliderHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x230)]
    public struct MiniBossStriderConfig
    {
        [FieldOffset(0x00)] public MiniBossStriderCommonParam commonParam;
        [FieldOffset(0x40)] public MiniBossStriderLevelParam levelParams__arr0;
        [FieldOffset(0x78)] public MiniBossStriderLevelParam levelParams__arr1;
        [FieldOffset(0xB0)] public MiniBossStriderLevelParam levelParams__arr2;
        [FieldOffset(0xE8)] public MiniBossStriderLevelParam levelParams__arr3;
        [FieldOffset(0x120)] public MiniBossStriderLevelParam levelParams__arr4;
        [FieldOffset(0x158)] public MiniBossStriderLevelBand levelBand__arr0;
        [FieldOffset(0x15C)] public MiniBossStriderLevelBand levelBand__arr1;
        [FieldOffset(0x160)] public MiniBossStriderLevelBand levelBand__arr2;
        [FieldOffset(0x164)] public MiniBossStriderLevelBand levelBand__arr3;
        [FieldOffset(0x168)] public MiniBossStriderLevelBand levelBand__arr4;
        [FieldOffset(0x16C)] public MiniBossStriderParam striderParam;
        [FieldOffset(0x1F8)] public ObjStriderGrindRailParam grindRailParam;
        [FieldOffset(0x228)] public ObjStriderPlatformParam platformParam;
    }

}