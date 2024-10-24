Library "StandardCameraConfig"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct StandardCameraCommonParameter
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float distanceSuspensionK;
        [FieldOffset(0x08)] public float minElevation;
        [FieldOffset(0x0C)] public float maxElevation;
        [FieldOffset(0x10)] public float azimuthSensitivity;
        [FieldOffset(0x14)] public float elevationUpSensitivity;
        [FieldOffset(0x18)] public float elevationDownSensitivity;
        [FieldOffset(0x1C)] public float elevationOffset;
        [FieldOffset(0x20)] public float targetUpOffset;
        [FieldOffset(0x24)] public float targetMinUpOffsetLimit;
        [FieldOffset(0x28)] public float targetMaxUpOffsetLimit;
        [FieldOffset(0x2C)] public float targetMinUpOffsetLimitDistance;
        [FieldOffset(0x30)] public float targetMaxUpOffsetLimitDistance;
        [FieldOffset(0x34)] public float targetOffsetSuspensionK;
        [FieldOffset(0x38)] public float delayAllowDistance;
        [FieldOffset(0x3C)] public float delayLimitDistance;
        [FieldOffset(0x40)] public float delaySuspensionK;
        [FieldOffset(0x44)] public float autocontrolDisabledTime;
        [FieldOffset(0x48)] public float chaseSegmentSuspensionK;
        [FieldOffset(0x4C)] public float chaseSegmentShortenSpeed;
        [FieldOffset(0x50)] public int chaseSegmentMaxCount;
        [FieldOffset(0x54)] public float inertiaMinDecel;
        [FieldOffset(0x58)] public float inertiaOvershootAngle;
        [FieldOffset(0x5C)] public float resetSuspensionK;
        [FieldOffset(0x60)] public float downDirectionDotThreshold;
        [FieldOffset(0x64)] public float baseUpLeanRate;
        [FieldOffset(0x68)] public bool disableRotationControl;
        [FieldOffset(0x6C)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct StandardCameraDashParameter
    {
        [FieldOffset(0x00)] public float minDistance;
        [FieldOffset(0x04)] public float maxDistance;
        [FieldOffset(0x08)] public float minDistanceAccel;
        [FieldOffset(0x0C)] public float maxDistanceAccel;
        [FieldOffset(0x10)] public float distanceSuspensionK;
        [FieldOffset(0x14)] public float elevationOffset;
        [FieldOffset(0x18)] public float azimuthSensitivity;
        [FieldOffset(0x1C)] public float targetOffsetSuspensionK;
        [FieldOffset(0x20)] public float targetUpOffset;
        [FieldOffset(0x24)] public float delayAllowDistance;
        [FieldOffset(0x28)] public float delayLimitDistance;
        [FieldOffset(0x2C)] public float delaySuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct StandardCameraCyloopParameter
    {
        [FieldOffset(0x00)] public float minDistance;
        [FieldOffset(0x04)] public float maxDistance;
        [FieldOffset(0x08)] public float elevationOffset;
        [FieldOffset(0x0C)] public float azimuthSensitivity;
        [FieldOffset(0x10)] public float elevationUpSensitivity;
        [FieldOffset(0x14)] public float elevationDownSensitivity;
        [FieldOffset(0x18)] public float targetUpOffset;
        [FieldOffset(0x1C)] public float minDelayLimitDistance;
        [FieldOffset(0x20)] public float maxDelayLimitDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct StandardCameraLockonParameter
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float minElevation;
        [FieldOffset(0x08)] public float maxElevation;
        [FieldOffset(0x0C)] public float elevationOffset;
        [FieldOffset(0x10)] public float minElevationCyloop;
        [FieldOffset(0x14)] public float maxElevationCyloop;
        [FieldOffset(0x18)] public float elevationOffsetCyloop;
        [FieldOffset(0x1C)] public float targetUpOffset;
        [FieldOffset(0x20)] public float delayAllowDistance;
        [FieldOffset(0x24)] public float delayLimitDistance;
        [FieldOffset(0x28)] public float delaySuspensionK;
        [FieldOffset(0x2C)] public float panningSuspensionK;
        [FieldOffset(0x30)] public float interiorPanningDistance;
        [FieldOffset(0x34)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct StandardCameraWallParameter
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float targetUpOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct StandardCameraLoopParameter
    {
        [FieldOffset(0x00)] public float azimuthSensitivity;
        [FieldOffset(0x04)] public float elevationUpSensitivity;
        [FieldOffset(0x08)] public float elevationDownSensitivity;
        [FieldOffset(0x0C)] public float targetUpOffset;
        [FieldOffset(0x10)] public float baseUpLeanRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct StandardCameraBattleParameter
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float distanceSuspensionK;
        [FieldOffset(0x08)] public float elevationOffset;
        [FieldOffset(0x0C)] public float azimuthMinOffset;
        [FieldOffset(0x10)] public float azimuthMaxOffset;
        [FieldOffset(0x14)] public float azimuthMinOffsetDistance;
        [FieldOffset(0x18)] public float azimuthMaxOffsetDistance;
        [FieldOffset(0x1C)] public float azimuthSensitivity;
        [FieldOffset(0x20)] public float targetOffsetSuspensionK;
        [FieldOffset(0x24)] public float targetMinUpOffset;
        [FieldOffset(0x28)] public float targetMaxUpOffset;
        [FieldOffset(0x2C)] public float targetFrontOffset;
        [FieldOffset(0x30)] public float delayAllowDistance;
        [FieldOffset(0x34)] public float delayLimitDistance;
        [FieldOffset(0x38)] public float delaySuspensionK;
        [FieldOffset(0x3C)] public float manualControlTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct StandardCameraSurfParameter
    {
        [FieldOffset(0x00)] public float azimuthSensitivity;
        [FieldOffset(0x04)] public float elevationUpSensitivity;
        [FieldOffset(0x08)] public float elevationDownSensitivity;
        [FieldOffset(0x0C)] public float targetUpOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct StandardCameraOptionParameter
    {
        [FieldOffset(0x00)] public float minManualRotationSpeed;
        [FieldOffset(0x04)] public float maxManualRotationSpeed;
        [FieldOffset(0x08)] public float minMouseRotationRate;
        [FieldOffset(0x0C)] public float maxMouseRotationRate;
        [FieldOffset(0x10)] public float minDistanceScale;
        [FieldOffset(0x14)] public float maxDistanceScale;
        [FieldOffset(0x18)] public float maxElevationAddOffset;
        [FieldOffset(0x1C)] public float minTargetUpOffsetScale;
        [FieldOffset(0x20)] public float maxTargetUpOffsetScale;
        [FieldOffset(0x24)] public float minFovyRate;
        [FieldOffset(0x28)] public float minLimitFovy;
        [FieldOffset(0x2C)] public float minFovyScale;
        [FieldOffset(0x30)] public float maxFovyScale;
        [FieldOffset(0x34)] public bool bIsActiveOption;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C4)]
    public struct StandardCameraConfig
    {
        [FieldOffset(0x00)] public StandardCameraCommonParameter common;
        [FieldOffset(0x70)] public StandardCameraDashParameter dash;
        [FieldOffset(0xA0)] public StandardCameraCyloopParameter cyloop;
        [FieldOffset(0xC4)] public StandardCameraCyloopParameter cyloopSnipe;
        [FieldOffset(0xE8)] public StandardCameraLockonParameter lockon;
        [FieldOffset(0x120)] public StandardCameraWallParameter wall;
        [FieldOffset(0x128)] public StandardCameraLoopParameter loop;
        [FieldOffset(0x13C)] public StandardCameraBattleParameter battle;
        [FieldOffset(0x17C)] public StandardCameraSurfParameter surf;
        [FieldOffset(0x18C)] public StandardCameraOptionParameter option;
    }

}