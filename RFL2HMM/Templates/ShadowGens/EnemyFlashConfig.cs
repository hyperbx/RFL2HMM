Library "EnemyFlashConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 0xC0)]
    public struct EnemyFlashCommonParam
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
        [FieldOffset(0x58)] public float rotateSpeed;
        [FieldOffset(0x5C)] public float rotateLimitAngle;
        [FieldOffset(0x60)] public float shootCloneInterval;
        [FieldOffset(0x64)] public float cloneRadius;
        [FieldOffset(0x68)] public float cloneLength;
        [FieldOffset(0x6C)] public float cloneSpeed;
        [FieldOffset(0x70)] public float cloneAppearDelayTime;
        [FieldOffset(0x74)] public float cloneAppearTime;
        [FieldOffset(0x78)] public float stunTime;
        [FieldOffset(0x7C)] public float warpRadius;
        [FieldOffset(0x80)] public float warpHeight;
        [FieldOffset(0x84)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr0;
        [FieldOffset(0x98)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr1;
        [FieldOffset(0xAC)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC0)]
    public struct EnemyFlashConfig
    {
        [FieldOffset(0x00)] public EnemyFlashCommonParam commonParam;
    }

}