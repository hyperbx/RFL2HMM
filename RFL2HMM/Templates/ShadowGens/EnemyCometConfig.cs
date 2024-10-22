Library "EnemyCometConfig"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct TimeStopDamageVelocityParam
    {
        [FieldOffset(0x00)] public uint damage_num_threshold;
        [FieldOffset(0x04)] public float velocity_scale_base;
        [FieldOffset(0x08)] public float velocity_scale_linear;
        [FieldOffset(0x0C)] public float velocity_acceleration;
        [FieldOffset(0x10)] public float velocity_max;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x190)]
    public struct EnemyCometCommonParam
    {
        [FieldOffset(0x00)] public float killWaitTime;
        [FieldOffset(0x04)] public int maxHealthPoint;
        [FieldOffset(0x10)] public Vector3 colliderPositionOffset;
        [FieldOffset(0x20)] public Vector3 damageColliderPositionOffset;
        [FieldOffset(0x30)] public float colliderRadius;
        [FieldOffset(0x34)] public float colliderHeight;
        [FieldOffset(0x38)] public float damageColliderRadiusOffset;
        [FieldOffset(0x3C)] public float damageColliderHeightOffset;
        [FieldOffset(0x40)] public Vector3 colliderPositionOffsetWhileBlownUp;
        [FieldOffset(0x50)] public float colliderRadiusOffsetWhileBlownUp;
        [FieldOffset(0x54)] public float colliderHeightOffsetWhileBlownUp;
        [FieldOffset(0x58)] public float attackShockWaveColliderRadiusOffset;
        [FieldOffset(0x5C)] public float attackShockWaveColliderHeightOffset;
        [FieldOffset(0x60)] public float guardToShockWaveWaitTime;
        [FieldOffset(0x64)] public float readyShockWaveWaitTime;
        [FieldOffset(0x68)] public float attackingShockWaveTime;
        [FieldOffset(0x6C)] public float attackShockWaveDamageVelocityScale;
        [FieldOffset(0x70)] public float closeContactDistance;
        [FieldOffset(0x74)] public float closeContactTime;
        [FieldOffset(0x78)] public float rotateLimitAngle;
        [FieldOffset(0x7C)] public float barrierPositionFOffset;
        [FieldOffset(0x80)] public float barrierPositionYOffset;
        [FieldOffset(0x84)] public float barrierRotateIntervalTime;
        [FieldOffset(0x88)] public float barrierRecoveryIntervalTime;
        [FieldOffset(0x8C)] public float barrierFlipGuardVelocityScaleV;
        [FieldOffset(0x90)] public float barrierFlipGuardVelocityScaleH;
        [FieldOffset(0x94)] public float barrierForciblyReleaseTimeForDamage;
        [FieldOffset(0x98)] public float stunTime;
        [FieldOffset(0x9C)] public float downTime;
        [FieldOffset(0xA0)] public float shootReflectorPositionYOffsetForFV;
        [FieldOffset(0xA4)] public float shootReflectorPositionYOffsetForSV;
        [FieldOffset(0xA8)] public float shootReflectorPositionZOffset;
        [FieldOffset(0xAC)] public float shootReflectorWidth;
        [FieldOffset(0xB0)] public float shootReflectorHeight;
        [FieldOffset(0xB4)] public float shootReflectorSpeed;
        [FieldOffset(0xB8)] public float shootReflectorLeanAngle;
        [FieldOffset(0xBC)] public float shootReflectorLeanTime;
        [FieldOffset(0xC0)] public float reflectorFlipGuardVelocityScaleV;
        [FieldOffset(0xC4)] public float reflectorFlipGuardVelocityScaleH;
        [FieldOffset(0xC8)] public float warpRadius;
        [FieldOffset(0xCC)] public float warpHeight;
        [FieldOffset(0xD0)] public Vector3 warpOffsetForFV;
        [FieldOffset(0xE0)] public Vector3 warpOffsetForSV;
        [FieldOffset(0xF0)] public Vector3 warpOffsetForFVWhileBlownUp;
        [FieldOffset(0x100)] public Vector3 warpOffsetForSVWhileBlownUp;
        [FieldOffset(0x110)] public Vector3 warpOffsetForFVWhileBlownAway;
        [FieldOffset(0x120)] public Vector3 warpOffsetForSVWhileBlownAway;
        [FieldOffset(0x130)] public float warpAngleForFV;
        [FieldOffset(0x134)] public float warpAngleForSV;
        [FieldOffset(0x138)] public float warpAngleForFVWhileBlownUp;
        [FieldOffset(0x13C)] public float warpAngleForSVWhileBlownUp;
        [FieldOffset(0x140)] public float warpAngleForFVWhileBlownAway;
        [FieldOffset(0x144)] public float warpAngleForSVWhileBlownAway;
        [FieldOffset(0x148)] public bool warpOffsetCalcFromNowRot;
        [FieldOffset(0x14C)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr0;
        [FieldOffset(0x160)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr1;
        [FieldOffset(0x174)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x190)]
    public struct EnemyCometConfig
    {
        [FieldOffset(0x00)] public EnemyCometCommonParam commonParam;
    }

}