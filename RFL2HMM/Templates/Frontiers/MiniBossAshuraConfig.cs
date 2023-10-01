using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossAshuraConfigClass
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
    public struct MiniBossAshuraCommonParam
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
    public struct MiniBossAshuraLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct MiniBossAshuraLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct MiniBossAshuraObjectCircleLaser
    {
        [FieldOffset(0x00)] public float rotationSpeed;
        [FieldOffset(0x04)] public float moveRadiusMin;
        [FieldOffset(0x08)] public float moveRadiusMax;
        [FieldOffset(0x0C)] public float initKeepTime;
        [FieldOffset(0x10)] public float scaleUpTime;
        [FieldOffset(0x14)] public float scaleUpKeepTime;
        [FieldOffset(0x18)] public float scaleDownTime;
        [FieldOffset(0x1C)] public float scaleDownKeepTime;
        [FieldOffset(0x20)] public int num;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossAshuraObjectCrawlSpark
    {
        [FieldOffset(0x00)] public int createNum;
        [FieldOffset(0x04)] public int createParkourNum;
        [FieldOffset(0x08)] public float createCycleTime;
        [FieldOffset(0x0C)] public float moveSpeed;
        [FieldOffset(0x10)] public float lifeTime;
        [FieldOffset(0x14)] public float homingMaxAngle;
        [FieldOffset(0x18)] public float homingStartTime;
        [FieldOffset(0x1C)] public float homingPowerMaxTime;
        [FieldOffset(0x20)] public float meanderingPower;
        [FieldOffset(0x24)] public float meanderingCycleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossAshuraObjectDashCircleBulletParamByType
    {
        [FieldOffset(0x00)] public float ocTime;
        [FieldOffset(0x04)] public float dashSpeed;
        [FieldOffset(0x08)] public float ocTimeOnGround;
        [FieldOffset(0x0C)] public float dashSpeedOnGround;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossAshuraObjectDashCircleBullet
    {
        [FieldOffset(0x00)] public float moveSpeed;
        [FieldOffset(0x04)] public float lifeTime;
        [FieldOffset(0x08)] public MiniBossAshuraObjectDashCircleBulletParamByType frontType;
        [FieldOffset(0x18)] public MiniBossAshuraObjectDashCircleBulletParamByType backType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct MiniBossAshuraObjectSlamWave
    {
        [FieldOffset(0x00)] public float blowOffRadius;
        [FieldOffset(0x04)] public float blowOffHeight;
        [FieldOffset(0x08)] public float killRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct MiniBossAshuraObjectParam
    {
        [FieldOffset(0x00)] public MiniBossAshuraObjectCircleLaser circleLaser;
        [FieldOffset(0x24)] public MiniBossAshuraObjectCrawlSpark crawlSpark;
        [FieldOffset(0x4C)] public MiniBossAshuraObjectDashCircleBullet dashCircleBullet;
        [FieldOffset(0x74)] public MiniBossAshuraObjectSlamWave slamWave;
    }

    public enum OnArmCircleBulletType : sbyte
    {
        CBT_NONE = 0,
        CBT_FRONT = 1,
        CBT_BACK = 2,
        NUM_CBT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossAshuraPhaseOnArmCircleBulletPos
    {
        [FieldOffset(0x00)] public OnArmCircleBulletType left;
        [FieldOffset(0x01)] public OnArmCircleBulletType center;
        [FieldOffset(0x02)] public OnArmCircleBulletType right;
        [FieldOffset(0x04)] public float leftOffsetAngle;
        [FieldOffset(0x08)] public float centerOffsetAngle;
        [FieldOffset(0x0C)] public float rightOffsetAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct MiniBossAshuraPhaseParam
    {
        [FieldOffset(0x00)] public bool isCircleLaser;
        [FieldOffset(0x01)] public bool isCrawlSpark;
        [FieldOffset(0x02)] public bool isAttackArmWave;
        [FieldOffset(0x03)] public bool isAttackArmCircleBulletOnArm;
        [FieldOffset(0x04)] public MiniBossAshuraPhaseOnArmCircleBulletPos onArmCircleBullets__arr0;
        [FieldOffset(0x14)] public MiniBossAshuraPhaseOnArmCircleBulletPos onArmCircleBullets__arr1;
        [FieldOffset(0x24)] public MiniBossAshuraPhaseOnArmCircleBulletPos onArmCircleBullets__arr2;
        [FieldOffset(0x34)] public MiniBossAshuraPhaseOnArmCircleBulletPos onArmCircleBullets__arr3;
        [FieldOffset(0x44)] public MiniBossAshuraPhaseOnArmCircleBulletPos onArmCircleBullets__arr4;
        [FieldOffset(0x54)] public MiniBossAshuraPhaseOnArmCircleBulletPos onArmCircleBullets__arr5;
        [FieldOffset(0x64)] public MiniBossAshuraPhaseOnArmCircleBulletPos onArmCircleBullets__arr6;
        [FieldOffset(0x74)] public MiniBossAshuraPhaseOnArmCircleBulletPos onArmCircleBullets__arr7;
        [FieldOffset(0x84)] public bool isAttackArmCircleBullet;
        [FieldOffset(0x88)] public int circleBulletBackTypeFreq;
        [FieldOffset(0x8C)] public int circleBulletCreateNum;
        [FieldOffset(0x90)] public float circleBulletCreateAngle;
        [FieldOffset(0x94)] public float circleJumpTargetDistace;
        [FieldOffset(0x98)] public float circleBulletCreateIntervalTime;
        [FieldOffset(0x9C)] public int armAttackConsecutiveNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3D0)]
    public struct MiniBossAshuraConfig
    {
        [FieldOffset(0x00)] public MiniBossAshuraCommonParam commonParam;
        [FieldOffset(0x40)] public MiniBossAshuraLevelParam levelParams__arr0;
        [FieldOffset(0x78)] public MiniBossAshuraLevelParam levelParams__arr1;
        [FieldOffset(0xB0)] public MiniBossAshuraLevelParam levelParams__arr2;
        [FieldOffset(0xE8)] public MiniBossAshuraLevelParam levelParams__arr3;
        [FieldOffset(0x120)] public MiniBossAshuraLevelParam levelParams__arr4;
        [FieldOffset(0x158)] public MiniBossAshuraLevelBand levelBand__arr0;
        [FieldOffset(0x15C)] public MiniBossAshuraLevelBand levelBand__arr1;
        [FieldOffset(0x160)] public MiniBossAshuraLevelBand levelBand__arr2;
        [FieldOffset(0x164)] public MiniBossAshuraLevelBand levelBand__arr3;
        [FieldOffset(0x168)] public MiniBossAshuraLevelBand levelBand__arr4;
        [FieldOffset(0x16C)] public MiniBossAshuraObjectParam objectParam;
        [FieldOffset(0x1EC)] public MiniBossAshuraPhaseParam phaseParam__arr0;
        [FieldOffset(0x28C)] public MiniBossAshuraPhaseParam phaseParam__arr1;
        [FieldOffset(0x32C)] public MiniBossAshuraPhaseParam phaseParam__arr2;
    }

}