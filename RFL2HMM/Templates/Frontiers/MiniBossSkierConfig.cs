using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossSkierConfigClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct MiniBossSkierColliderParam
    {
        [FieldOffset(0x00)] public float blockRadius;
        [FieldOffset(0x04)] public float blockHeight;
        [FieldOffset(0x08)] public float damageRadius;
        [FieldOffset(0x0C)] public float damagedBlockRadius;
        [FieldOffset(0x10)] public float damagedBlockHeight;
        [FieldOffset(0x14)] public float returnRadius;
        [FieldOffset(0x18)] public float returnBlockRadius;
        [FieldOffset(0x1C)] public float returnHeight;
        [FieldOffset(0x20)] public float weakPointRadius;
        [FieldOffset(0x24)] public float grabRadius;
        [FieldOffset(0x28)] public float attackRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct MiniBossSkeirTailMoveParam
    {
        [FieldOffset(0x00)] public float tailRotateMinSpeed;
        [FieldOffset(0x04)] public float tailRotateMaxSpeed;
        [FieldOffset(0x08)] public float tailRotateAddSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct MiniBossSkierTailParam
    {
        [FieldOffset(0x00)] public float tailExtendTime;
        [FieldOffset(0x04)] public float tailNodeLenthMin;
        [FieldOffset(0x08)] public float tailNodeLenthMax;
        [FieldOffset(0x0C)] public float checkGroundStartDistanceOnSkiing;
        [FieldOffset(0x10)] public float checkGroundEndDistanceOnSkiing;
        [FieldOffset(0x14)] public float checkGroundEndDistanceOnSkiingJump;
        [FieldOffset(0x18)] public float checkGroundEndDistanceOnSkiingCamera;
        [FieldOffset(0x1C)] public MiniBossSkeirTailMoveParam rotateParamNormal;
        [FieldOffset(0x28)] public MiniBossSkeirTailMoveParam rotateParamAttack;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct MiniBossSkeirPlayerControlLR
    {
        [FieldOffset(0x00)] public float LRFBNormalRatioSpeed;
        [FieldOffset(0x04)] public float LRDangerAngle;
        [FieldOffset(0x08)] public float LRDangerTime;
        [FieldOffset(0x0C)] public float LRInputInterfere;
        [FieldOffset(0x10)] public float LRRecoverSpeed;
        [FieldOffset(0x14)] public float LRDragSpeed;
        [FieldOffset(0x18)] public float LRRecoverEndRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct MiniBossSkeirPlayerControlUD
    {
        [FieldOffset(0x00)] public float UDSafeRatio;
        [FieldOffset(0x04)] public float UDRecoverSpeed;
        [FieldOffset(0x08)] public float UDDragSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossSkeirPlayerControlTail
    {
        [FieldOffset(0x00)] public float tailRatioChangeSpeed;
        [FieldOffset(0x04)] public float tailRatioRecoverSpeed;
        [FieldOffset(0x08)] public float tailAddSpeedMax;
        [FieldOffset(0x0C)] public float tailAddSpeedAttenuation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct MiniBossSkierMissileParam
    {
        [FieldOffset(0x00)] public float timeExplodePassed;
        [FieldOffset(0x04)] public float timeExplodeAuto;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct MiniBossSkierCustomCameraParam
    {
        [FieldOffset(0x00)] public float interoplateTimeActivate;
        [FieldOffset(0x04)] public float interoplateTimeDeactivate;
        [FieldOffset(0x10)] public Vector3 targetOffset;
        [FieldOffset(0x20)] public Vector3 cameraPosOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x140)]
    public struct MiniBossSkierCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig commonConfig;
        [FieldOffset(0x40)] public MiniBossSkierColliderParam colliderParam;
        [FieldOffset(0x6C)] public MiniBossSkierTailParam tailParam;
        [FieldOffset(0xA0)] public MiniBossSkeirPlayerControlLR LRControlParam;
        [FieldOffset(0xBC)] public MiniBossSkeirPlayerControlUD UDControlParam;
        [FieldOffset(0xC8)] public MiniBossSkeirPlayerControlTail tailControlParam;
        [FieldOffset(0xD8)] public MiniBossSkierMissileParam missileParam;
        [FieldOffset(0xE0)] public MiniBossSkierCustomCameraParam customCameraParam;
        [FieldOffset(0x110)] public MiniBossSkierCustomCameraParam skiCameraParam;
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
    public struct MiniBossSkierLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct MiniBossSkierSkiAcitionRate
    {
        [FieldOffset(0x00)] public float NoActionRate;
        [FieldOffset(0x04)] public float SnakeMoveRate;
        [FieldOffset(0x08)] public float JumpHighRate;
        [FieldOffset(0x0C)] public float JumpLowRate;
        [FieldOffset(0x10)] public float PylonRate;
        [FieldOffset(0x14)] public float MissileRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct MiniBossSkierBattlePhaseParam
    {
        [FieldOffset(0x00)] public float HPRate;
        [FieldOffset(0x04)] public MiniBossSkierSkiAcitionRate actionRate;
        [FieldOffset(0x1C)] public float showWeaknessTimeReTry;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossSkierJumpOutParam
    {
        [FieldOffset(0x00)] public float attackInterval;
        [FieldOffset(0x04)] public float attackSensorRange;
        [FieldOffset(0x08)] public float returnToWanderTime;
        [FieldOffset(0x0C)] public float pathPosAngleLimit;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct MiniBossSkierSkiParam
    {
        [FieldOffset(0x00)] public float showWeaknessTime;
        [FieldOffset(0x04)] public float skiMoveSpeed;
        [FieldOffset(0x08)] public float skiWeakMoveSpeed;
        [FieldOffset(0x0C)] public float skiReturnSpeed;
        [FieldOffset(0x10)] public float homingSpeed;
        [FieldOffset(0x14)] public float jumpHighSpeed;
        [FieldOffset(0x18)] public float jumpLowSpeed;
        [FieldOffset(0x1C)] public float struggleTime;
        [FieldOffset(0x20)] public float returnUndergroundTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct MiniBossSkierSnakeMoveParam
    {
        [FieldOffset(0x00)] public float snakeMoveAmplitude;
        [FieldOffset(0x04)] public float snakeMovePeriod;
        [FieldOffset(0x08)] public float snakeMovePrepareTime;
        [FieldOffset(0x0C)] public float snakeMoveReturnTime;
        [FieldOffset(0x10)] public float snakeMoveDangerAngleOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossSkierTailAttackParam
    {
        [FieldOffset(0x00)] public float signSpeed;
        [FieldOffset(0x04)] public float attackMinSpeed;
        [FieldOffset(0x08)] public float attackMaxSpeed;
        [FieldOffset(0x0C)] public float maxWaitTime;
        [FieldOffset(0x10)] public float driftLenth;
        [FieldOffset(0x14)] public float driftLenthUIOffset;
        [FieldOffset(0x18)] public float rotStartAngularSpeed;
        [FieldOffset(0x1C)] public float rotEndAngularSpeed;
        [FieldOffset(0x20)] public float avoidObjCalMargePylon;
        [FieldOffset(0x24)] public float avoidObjCalMargeMissile;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossSkierTailAttackPylonParam
    {
        [FieldOffset(0x00)] public float signSpeed;
        [FieldOffset(0x04)] public float signTime;
        [FieldOffset(0x08)] public float pylonAppearTime;
        [FieldOffset(0x0C)] public float pylonDisappearTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE4)]
    public struct MiniBossSkierLevelBand
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossSkierBattlePhaseParam phaseParam__arr0;
        [FieldOffset(0x24)] public MiniBossSkierBattlePhaseParam phaseParam__arr1;
        [FieldOffset(0x44)] public MiniBossSkierBattlePhaseParam phaseParam__arr2;
        [FieldOffset(0x64)] public MiniBossSkierJumpOutParam jumpOutParam;
        [FieldOffset(0x74)] public MiniBossSkierSkiParam skiParam;
        [FieldOffset(0x98)] public MiniBossSkierSnakeMoveParam snakeMoveParam;
        [FieldOffset(0xAC)] public MiniBossSkierTailAttackParam tailAttackParam;
        [FieldOffset(0xD4)] public MiniBossSkierTailAttackPylonParam pylonParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x6D0)]
    public struct MiniBossSkierConfig
    {
        [FieldOffset(0x00)] public MiniBossSkierCommonParam commonParam;
        [FieldOffset(0x140)] public MiniBossSkierLevelParam levelParams__arr0;
        [FieldOffset(0x178)] public MiniBossSkierLevelParam levelParams__arr1;
        [FieldOffset(0x1B0)] public MiniBossSkierLevelParam levelParams__arr2;
        [FieldOffset(0x1E8)] public MiniBossSkierLevelParam levelParams__arr3;
        [FieldOffset(0x220)] public MiniBossSkierLevelParam levelParams__arr4;
        [FieldOffset(0x258)] public MiniBossSkierLevelBand levelBand__arr0;
        [FieldOffset(0x33C)] public MiniBossSkierLevelBand levelBand__arr1;
        [FieldOffset(0x420)] public MiniBossSkierLevelBand levelBand__arr2;
        [FieldOffset(0x504)] public MiniBossSkierLevelBand levelBand__arr3;
        [FieldOffset(0x5E8)] public MiniBossSkierLevelBand levelBand__arr4;
    }

}