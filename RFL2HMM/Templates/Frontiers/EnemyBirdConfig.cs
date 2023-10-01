using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyBirdConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct EnemyBirdCommonParam
    {
        [FieldOffset(0x00)] public Vector3 backColliderExtents;
        [FieldOffset(0x10)] public Vector3 backColliderOffset;
        [FieldOffset(0x20)] public Vector3 backDamageColliderExtents;
        [FieldOffset(0x30)] public Vector3 backDamageColliderOffset;
        [FieldOffset(0x40)] public Vector3 chargeColliderExtents;
        [FieldOffset(0x50)] public Vector3 chargeColliderOffset;
        [FieldOffset(0x60)] public float eyesightAngle;
        [FieldOffset(0x64)] public float eyesightDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct EnemyBirdCommonLevelParam
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyBirdLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public EnemyBirdCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct EnemyBirdLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct BirdWanderParam
    {
        [FieldOffset(0x00)] public float speedOnPath;
        [FieldOffset(0x04)] public float speedToPath;
        [FieldOffset(0x08)] public float eyesightDelayAfterBarAction;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BirdApproachParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float acceleration;
        [FieldOffset(0x0C)] public float rotateDegreeToSonic;
        [FieldOffset(0x10)] public float stopDistanceFromSonic;
        [FieldOffset(0x20)] public Vector3 offsetFromSonic;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct BirdLaserStateParam
    {
        [FieldOffset(0x00)] public float laserInterval;
        [FieldOffset(0x04)] public float rotateDegreeToSonic;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BirdChargeParam
    {
        [FieldOffset(0x00)] public float waitTime;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float maxSpeed;
        [FieldOffset(0x0C)] public float acceleration;
        [FieldOffset(0x10)] public Vector3 offsetFromSonic;
        [FieldOffset(0x20)] public float duration;
        [FieldOffset(0x24)] public float distance;
        [FieldOffset(0x28)] public float minElevation;
        [FieldOffset(0x2C)] public float maxElevation;
        [FieldOffset(0x30)] public float panningSuspensionK;
        [FieldOffset(0x34)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BirdBackupParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float acceleration;
        [FieldOffset(0x0C)] public float backupTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BirdBarParam
    {
        [FieldOffset(0x00)] public float haWaitTime;
        [FieldOffset(0x04)] public float degreeOnPath;
        [FieldOffset(0x08)] public float speedOnPath;
        [FieldOffset(0x0C)] public float speedToPath;
        [FieldOffset(0x10)] public float splineTension;
        [FieldOffset(0x14)] public float splineSpeed;
        [FieldOffset(0x20)] public Vector3 velocityOnFail;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct BirdGlidingParam
    {
        [FieldOffset(0x00)] public float moveSpeed;
        [FieldOffset(0x04)] public float gidingVelocityY;
        [FieldOffset(0x08)] public float limitTime;
        [FieldOffset(0x0C)] public float rotateSpeed;
        [FieldOffset(0x10)] public float rotateSpeedMin;
        [FieldOffset(0x14)] public float rotateSpeedMax;
        [FieldOffset(0x18)] public float rotateSpeedMaxSpeedMin;
        [FieldOffset(0x1C)] public float rotateSpeedMinSpeedMax;
        [FieldOffset(0x20)] public float heightOfChangeShake;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct BirdDeadParam
    {
        [FieldOffset(0x00)] public float minWaitTime;
        [FieldOffset(0x04)] public float maxWaitTime;
        [FieldOffset(0x08)] public float raycastDistance;
        [FieldOffset(0x0C)] public float fallSpeedOnStomp;
        [FieldOffset(0x10)] public float maxFallSpeedOnStomp;
        [FieldOffset(0x14)] public float fallAccelerationOnStomp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct BirdRaycastParam
    {
        [FieldOffset(0x00)] public float distanceFront;
        [FieldOffset(0x04)] public float distanceBack;
        [FieldOffset(0x08)] public float distanceDown;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct BirdOnBackCameraParam
    {
        [FieldOffset(0x00)] public float distToConsiderSonicAsOnBird;
        [FieldOffset(0x04)] public float distance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BirdCameraParam
    {
        [FieldOffset(0x00)] public float azimuth;
        [FieldOffset(0x04)] public float elevation;
        [FieldOffset(0x08)] public float distance;
        [FieldOffset(0x0C)] public float zRoll;
        [FieldOffset(0x10)] public float fovy;
        [FieldOffset(0x20)] public Vector3 frameOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1A0)]
    public struct EnemyBirdParam
    {
        [FieldOffset(0x00)] public Vector3 haColliderExtents;
        [FieldOffset(0x10)] public Vector3 haColliderOffset;
        [FieldOffset(0x20)] public Vector3 haTargetOffset;
        [FieldOffset(0x30)] public float haTargetRadius;
        [FieldOffset(0x34)] public float haTargetHeight;
        [FieldOffset(0x38)] public BirdWanderParam wanderParam;
        [FieldOffset(0x50)] public BirdApproachParam approachParam;
        [FieldOffset(0x80)] public BirdLaserStateParam laserStateParam;
        [FieldOffset(0x90)] public BirdChargeParam chargeParam;
        [FieldOffset(0xD0)] public BirdBackupParam backupParam;
        [FieldOffset(0xE0)] public BirdBarParam barParam;
        [FieldOffset(0x110)] public BirdGlidingParam glidingParam;
        [FieldOffset(0x134)] public BirdDeadParam deadParam;
        [FieldOffset(0x14C)] public BirdRaycastParam raycastParam;
        [FieldOffset(0x158)] public bool useCamera;
        [FieldOffset(0x15C)] public BirdOnBackCameraParam onBackCameraParam;
        [FieldOffset(0x170)] public BirdCameraParam cameraParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x280)]
    public struct EnemyBirdConfig
    {
        [FieldOffset(0x00)] public EnemyBirdCommonParam commonParam;
        [FieldOffset(0x70)] public EnemyBirdLevelParam levelParams__arr0;
        [FieldOffset(0x80)] public EnemyBirdLevelParam levelParams__arr1;
        [FieldOffset(0x90)] public EnemyBirdLevelParam levelParams__arr2;
        [FieldOffset(0xA0)] public EnemyBirdLevelParam levelParams__arr3;
        [FieldOffset(0xB0)] public EnemyBirdLevelParam levelParams__arr4;
        [FieldOffset(0xC0)] public EnemyBirdLevelBand levelBand__arr0;
        [FieldOffset(0xC4)] public EnemyBirdLevelBand levelBand__arr1;
        [FieldOffset(0xC8)] public EnemyBirdLevelBand levelBand__arr2;
        [FieldOffset(0xCC)] public EnemyBirdLevelBand levelBand__arr3;
        [FieldOffset(0xD0)] public EnemyBirdLevelBand levelBand__arr4;
        [FieldOffset(0xE0)] public EnemyBirdParam birdParam;
    }

}