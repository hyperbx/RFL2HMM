using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossTrackerConfigClass
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
    public struct MiniBossTrackerCommonParam
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
    public struct MiniBossTrackerLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct MiniBossTrackerLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct MiniBossTrackerCameraLockOn
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float distance;
        [FieldOffset(0x08)] public float minElevation;
        [FieldOffset(0x0C)] public float maxElevation;
        [FieldOffset(0x10)] public float panningSuspensionK;
        [FieldOffset(0x14)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct MiniBossTrackerMoveParam
    {
        [FieldOffset(0x00)] public float facingSpeed;
        [FieldOffset(0x04)] public float facingSpeed2;
        [FieldOffset(0x08)] public float steeringSpeed;
        [FieldOffset(0x0C)] public float chaseSpeed;
        [FieldOffset(0x10)] public float roundSpeed;
        [FieldOffset(0x14)] public float changeBaseSpeed;
        [FieldOffset(0x18)] public float returnSpeed;
        [FieldOffset(0x1C)] public float minSpeed;
        [FieldOffset(0x20)] public float turnSpeed;
        [FieldOffset(0x24)] public float accel;
        [FieldOffset(0x28)] public float brake;
        [FieldOffset(0x2C)] public float brakeDistance;
        [FieldOffset(0x30)] public float damper;
        [FieldOffset(0x34)] public float springFactor;
        [FieldOffset(0x38)] public float verticalWidth;
        [FieldOffset(0x3C)] public float verticalDamper;
        [FieldOffset(0x40)] public float verticalSpringFactor;
        [FieldOffset(0x44)] public float verticalRotateSpeed;
        [FieldOffset(0x48)] public float checkChaseRadius;
        [FieldOffset(0x4C)] public float checkRoundRadius;
        [FieldOffset(0x50)] public float checkReturnRadius;
        [FieldOffset(0x54)] public float chaseRadius;
        [FieldOffset(0x58)] public float chaseHeight;
        [FieldOffset(0x5C)] public float chaseWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct MiniBossTrackerBulletParam
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float interval;
        [FieldOffset(0x08)] public float speed;
        [FieldOffset(0x0C)] public float steeringSpeed;
        [FieldOffset(0x10)] public float startSteeringTime;
        [FieldOffset(0x14)] public float life;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct MiniBossTrackerMineParam
    {
        [FieldOffset(0x00)] public int num;
        [FieldOffset(0x04)] public int num2;
        [FieldOffset(0x08)] public float height;
        [FieldOffset(0x0C)] public float deviationTime;
        [FieldOffset(0x10)] public float searchRadius;
        [FieldOffset(0x14)] public float playerRadius;
        [FieldOffset(0x18)] public float playerHeight;
        [FieldOffset(0x1C)] public float setInterval;
        [FieldOffset(0x20)] public float life;
        [FieldOffset(0x24)] public float lifeEx;
        [FieldOffset(0x28)] public float timer;
        [FieldOffset(0x2C)] public float explosionLife;
        [FieldOffset(0x30)] public float targetEffectiveDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4C)]
    public struct MiniBossTrackerRingHoleParam
    {
        [FieldOffset(0x00)] public float minRadius;
        [FieldOffset(0x04)] public float maxRadius;
        [FieldOffset(0x08)] public float maxDistance;
        [FieldOffset(0x0C)] public float minHeight;
        [FieldOffset(0x10)] public float maxHeight;
        [FieldOffset(0x14)] public float deviationTime;
        [FieldOffset(0x18)] public float maxSpeed;
        [FieldOffset(0x1C)] public float minSpeed;
        [FieldOffset(0x20)] public float accel;
        [FieldOffset(0x24)] public float stopTime;
        [FieldOffset(0x28)] public float damperDistance;
        [FieldOffset(0x2C)] public float damper;
        [FieldOffset(0x30)] public float chaseRadius;
        [FieldOffset(0x34)] public float chaseSpeed;
        [FieldOffset(0x38)] public float disappearTime;
        [FieldOffset(0x3C)] public float life;
        [FieldOffset(0x40)] public float interval;
        [FieldOffset(0x44)] public float radius;
        [FieldOffset(0x48)] public float targetEffectiveDistance;
    }

    public enum ActionType : sbyte
    {
        BULLET = 0,
        MINE = 1,
        BASEMINE = 2,
        RINGHOLE = 3,
        LOOP = 4,
        END = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct MiniBossTrackerActionParam
    {
        [FieldOffset(0x00)] public float intervalTable__arr0;
        [FieldOffset(0x04)] public float intervalTable__arr1;
        [FieldOffset(0x08)] public float intervalTable__arr2;
        [FieldOffset(0x0C)] public float intervalTable__arr3;
        [FieldOffset(0x10)] public float intervalTable__arr4;
        [FieldOffset(0x14)] public float intervalTable__arr5;
        [FieldOffset(0x18)] public float intervalTable__arr6;
        [FieldOffset(0x1C)] public float intervalTable__arr7;
        [FieldOffset(0x20)] public float intervalTable__arr8;
        [FieldOffset(0x24)] public float intervalTable__arr9;
        [FieldOffset(0x28)] public float intervalTable__arr10;
        [FieldOffset(0x2C)] public float intervalTable__arr11;
        [FieldOffset(0x30)] public float intervalTable__arr12;
        [FieldOffset(0x34)] public float intervalTable__arr13;
        [FieldOffset(0x38)] public float intervalTable__arr14;
        [FieldOffset(0x3C)] public float intervalTable__arr15;
        [FieldOffset(0x40)] public float intervalTable__arr16;
        [FieldOffset(0x44)] public float intervalTable__arr17;
        [FieldOffset(0x48)] public float intervalTable__arr18;
        [FieldOffset(0x4C)] public float intervalTable__arr19;
        [FieldOffset(0x50)] public ActionType actionTable__arr0;
        [FieldOffset(0x51)] public ActionType actionTable__arr1;
        [FieldOffset(0x52)] public ActionType actionTable__arr2;
        [FieldOffset(0x53)] public ActionType actionTable__arr3;
        [FieldOffset(0x54)] public ActionType actionTable__arr4;
        [FieldOffset(0x55)] public ActionType actionTable__arr5;
        [FieldOffset(0x56)] public ActionType actionTable__arr6;
        [FieldOffset(0x57)] public ActionType actionTable__arr7;
        [FieldOffset(0x58)] public ActionType actionTable__arr8;
        [FieldOffset(0x59)] public ActionType actionTable__arr9;
        [FieldOffset(0x5A)] public ActionType actionTable__arr10;
        [FieldOffset(0x5B)] public ActionType actionTable__arr11;
        [FieldOffset(0x5C)] public ActionType actionTable__arr12;
        [FieldOffset(0x5D)] public ActionType actionTable__arr13;
        [FieldOffset(0x5E)] public ActionType actionTable__arr14;
        [FieldOffset(0x5F)] public ActionType actionTable__arr15;
        [FieldOffset(0x60)] public ActionType actionTable__arr16;
        [FieldOffset(0x61)] public ActionType actionTable__arr17;
        [FieldOffset(0x62)] public ActionType actionTable__arr18;
        [FieldOffset(0x63)] public ActionType actionTable__arr19;
        [FieldOffset(0x64)] public int nextPoint;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct MiniBossTrackerGameParam
    {
        [FieldOffset(0x00)] public int hp;
        [FieldOffset(0x04)] public float lossRingTime;
        [FieldOffset(0x08)] public float pursuitTime;
        [FieldOffset(0x0C)] public int baseDebuffCount;
        [FieldOffset(0x10)] public int addDebuffCount;
        [FieldOffset(0x14)] public float cameraDistance;
        [FieldOffset(0x18)] public float cameraDistance2;
        [FieldOffset(0x1C)] public float cameraMinElevation;
        [FieldOffset(0x20)] public float cameraMaxElevation;
        [FieldOffset(0x24)] public float cameraTargetUpOffset;
        [FieldOffset(0x28)] public float cameraTargetUpOffset2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4B0)]
    public struct MiniBossTrackerConfig
    {
        [FieldOffset(0x00)] public MiniBossTrackerCommonParam commonParam;
        [FieldOffset(0x40)] public MiniBossTrackerLevelParam levelParams__arr0;
        [FieldOffset(0x78)] public MiniBossTrackerLevelParam levelParams__arr1;
        [FieldOffset(0xB0)] public MiniBossTrackerLevelParam levelParams__arr2;
        [FieldOffset(0xE8)] public MiniBossTrackerLevelParam levelParams__arr3;
        [FieldOffset(0x120)] public MiniBossTrackerLevelParam levelParams__arr4;
        [FieldOffset(0x158)] public MiniBossTrackerLevelBand levelBand__arr0;
        [FieldOffset(0x15C)] public MiniBossTrackerLevelBand levelBand__arr1;
        [FieldOffset(0x160)] public MiniBossTrackerLevelBand levelBand__arr2;
        [FieldOffset(0x164)] public MiniBossTrackerLevelBand levelBand__arr3;
        [FieldOffset(0x168)] public MiniBossTrackerLevelBand levelBand__arr4;
        [FieldOffset(0x16C)] public MiniBossTrackerCameraLockOn cameraLockDamage;
        [FieldOffset(0x184)] public MiniBossTrackerMoveParam move;
        [FieldOffset(0x1E4)] public MiniBossTrackerBulletParam bullet;
        [FieldOffset(0x1FC)] public MiniBossTrackerMineParam mine;
        [FieldOffset(0x230)] public MiniBossTrackerRingHoleParam ringHole;
        [FieldOffset(0x27C)] public MiniBossTrackerActionParam action1;
        [FieldOffset(0x2E4)] public MiniBossTrackerActionParam action2;
        [FieldOffset(0x34C)] public MiniBossTrackerActionParam action3;
        [FieldOffset(0x3B4)] public MiniBossTrackerActionParam action4;
        [FieldOffset(0x41C)] public MiniBossTrackerActionParam action5;
        [FieldOffset(0x484)] public MiniBossTrackerGameParam game;
    }

}