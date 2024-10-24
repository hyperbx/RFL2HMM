Library "EnemySalvoConfig"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct EnemySalvoHomingLaserInfo
    {
        [FieldOffset(0x00)] public Vector3 launch_position_offset;
        [FieldOffset(0x10)] public Vector3 launch_direction;
        [FieldOffset(0x20)] public Vector3 target_position_offset;
        [FieldOffset(0x30)] public float speedAtStart;
        [FieldOffset(0x34)] public float speed;
        [FieldOffset(0x38)] public float speedMin;
        [FieldOffset(0x3C)] public float speedMax;
        [FieldOffset(0x40)] public float speedAcceleration;
        [FieldOffset(0x44)] public float relativeSpeedToDecelerate;
        [FieldOffset(0x48)] public float decelerateAtOverRelativeSpeed;
        [FieldOffset(0x4C)] public float radius;
        [FieldOffset(0x50)] public float length;
        [FieldOffset(0x54)] public float damage_collider_scale;
        [FieldOffset(0x58)] public float lifeTime;
        [FieldOffset(0x5C)] public float angularSpeed;
        [FieldOffset(0x60)] public float startDistance;
        [FieldOffset(0x64)] public float endDistance;
        [FieldOffset(0x68)] public float onTimeAtStart;
        [FieldOffset(0x6C)] public float onTime;
        [FieldOffset(0x70)] public float offTime;
        [FieldOffset(0x74)] public float directionError;
        [FieldOffset(0x78)] public float targetPositionEstimatedTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct TimeStopDamageVelocityParam
    {
        [FieldOffset(0x00)] public uint damage_num_threshold;
        [FieldOffset(0x04)] public float velocity_scale_base;
        [FieldOffset(0x08)] public float velocity_scale_linear;
        [FieldOffset(0x0C)] public float velocity_acceleration;
        [FieldOffset(0x10)] public float velocity_max;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C0)]
    public struct EnemySalvoCommonParam
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
        [FieldOffset(0x58)] public float moveSpeed;
        [FieldOffset(0x5C)] public float retreatDistance;
        [FieldOffset(0x60)] public float stunTime;
        [FieldOffset(0x64)] public float startHomingLaserRapidFireWaitTime;
        [FieldOffset(0x68)] public float readyHomingLaserRapidFireWaitTime;
        [FieldOffset(0x6C)] public float shootHomingLaserRapidFireInterval;
        [FieldOffset(0x70)] public EnemySalvoHomingLaserInfo homingLaserRapidFire;
        [FieldOffset(0xF0)] public float warpRadius;
        [FieldOffset(0xF4)] public float warpHeight;
        [FieldOffset(0x100)] public Vector3 warpOffsetForFV;
        [FieldOffset(0x110)] public Vector3 warpOffsetForSV;
        [FieldOffset(0x120)] public Vector3 warpOffsetForFVWhileBlownUp;
        [FieldOffset(0x130)] public Vector3 warpOffsetForSVWhileBlownUp;
        [FieldOffset(0x140)] public Vector3 warpOffsetForFVWhileBlownAway;
        [FieldOffset(0x150)] public Vector3 warpOffsetForSVWhileBlownAway;
        [FieldOffset(0x160)] public float warpAngleForFV;
        [FieldOffset(0x164)] public float warpAngleForSV;
        [FieldOffset(0x168)] public float warpAngleForFVWhileBlownUp;
        [FieldOffset(0x16C)] public float warpAngleForSVWhileBlownUp;
        [FieldOffset(0x170)] public float warpAngleForFVWhileBlownAway;
        [FieldOffset(0x174)] public float warpAngleForSVWhileBlownAway;
        [FieldOffset(0x178)] public bool warpOffsetCalcFromNowRot;
        [FieldOffset(0x17C)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr0;
        [FieldOffset(0x190)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr1;
        [FieldOffset(0x1A4)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C0)]
    public struct EnemySalvoConfig
    {
        [FieldOffset(0x00)] public EnemySalvoCommonParam commonParam;
    }

}