Library "EnemyCoreMachoConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x1A0)]
    public struct EnemyCoreMachoCommonParam
    {
        [FieldOffset(0x00)] public float killWaitTime;
        [FieldOffset(0x04)] public int maxHealthPoint;
        [FieldOffset(0x08)] public int maxHealthPointVehicle;
        [FieldOffset(0x10)] public Vector3 colliderPositionOffset;
        [FieldOffset(0x20)] public Vector3 colliderPositionOffsetVehicle;
        [FieldOffset(0x30)] public Vector3 damageColliderPositionOffset;
        [FieldOffset(0x40)] public Vector3 damageColliderPositionOffsetVehicle;
        [FieldOffset(0x50)] public float colliderRadius;
        [FieldOffset(0x54)] public float colliderRadiusVehicle;
        [FieldOffset(0x58)] public float colliderHeight;
        [FieldOffset(0x5C)] public float colliderHeightVehicle;
        [FieldOffset(0x60)] public float damageColliderRadiusOffset;
        [FieldOffset(0x64)] public float damageColliderRadiusOffsetVehicle;
        [FieldOffset(0x68)] public float damageColliderHeightOffset;
        [FieldOffset(0x6C)] public float damageColliderHeightOffsetVehicle;
        [FieldOffset(0x70)] public float attackColliderRadiusOffsetVehicle;
        [FieldOffset(0x80)] public Vector3 colliderPositionOffsetWhileBlownUp;
        [FieldOffset(0x90)] public float colliderRadiusOffsetWhileBlownUp;
        [FieldOffset(0x94)] public float colliderHeightOffsetWhileBlownUp;
        [FieldOffset(0x98)] public float moveTime;
        [FieldOffset(0x9C)] public float attackShockWaveColliderRadiusOffset;
        [FieldOffset(0xA0)] public float attackShockWaveColliderHeightOffset;
        [FieldOffset(0xA4)] public uint changeShockWaveDamageValue;
        [FieldOffset(0xA8)] public float readyShockWaveWaitTime;
        [FieldOffset(0xAC)] public float attackingShockWaveTime;
        [FieldOffset(0xB0)] public float startMoveWaitTime;
        [FieldOffset(0xB4)] public float attackProjectileRadius;
        [FieldOffset(0xB8)] public float attackProjectileHeight;
        [FieldOffset(0xBC)] public float attackProjectileSpeed;
        [FieldOffset(0xC0)] public float attackProjectileHomingAngularSpeed;
        [FieldOffset(0xC4)] public float attackProjectileHomingOnTime;
        [FieldOffset(0xC8)] public float attackProjectileLifeTime;
        [FieldOffset(0xCC)] public float startProjectileWaitTime;
        [FieldOffset(0xD0)] public float readyProjectileWaitTime;
        [FieldOffset(0xD4)] public float readyTornadoWaitTime;
        [FieldOffset(0xD8)] public float rotateSpeed;
        [FieldOffset(0xDC)] public float rotateLimitAngle;
        [FieldOffset(0xE0)] public float damageFlipGuardVelocityScaleV;
        [FieldOffset(0xE4)] public float damageFlipGuardVelocityScaleH;
        [FieldOffset(0xE8)] public float damageFlipGuardOutOfControlTime;
        [FieldOffset(0xEC)] public float stunTime;
        [FieldOffset(0xF0)] public float warpRadius;
        [FieldOffset(0xF4)] public float warpRadiusVehicle;
        [FieldOffset(0xF8)] public float warpHeight;
        [FieldOffset(0xFC)] public float warpHeightVehicle;
        [FieldOffset(0x100)] public Vector3 warpOffsetForFV;
        [FieldOffset(0x110)] public Vector3 warpOffsetForFVVehicle;
        [FieldOffset(0x120)] public Vector3 warpOffsetForFVWhileBlownUp;
        [FieldOffset(0x130)] public Vector3 warpOffsetForFVWhileBlownAway;
        [FieldOffset(0x140)] public float warpAngleForFV;
        [FieldOffset(0x144)] public float warpAngleForFVVehicle;
        [FieldOffset(0x148)] public float warpAngleForSV;
        [FieldOffset(0x14C)] public float warpAngleForSVVehicle;
        [FieldOffset(0x150)] public float warpAngleForFVWhileBlownUp;
        [FieldOffset(0x154)] public float warpAngleForSVWhileBlownUp;
        [FieldOffset(0x158)] public float warpAngleForFVWhileBlownAway;
        [FieldOffset(0x15C)] public float warpAngleForSVWhileBlownAway;
        [FieldOffset(0x160)] public bool warpOffsetCalcFromNowRot;
        [FieldOffset(0x161)] public bool warpOffsetCalcFromNowRotVehicle;
        [FieldOffset(0x164)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr0;
        [FieldOffset(0x178)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr1;
        [FieldOffset(0x18C)] public TimeStopDamageVelocityParam timeStopDamageVelocityParams__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1A0)]
    public struct EnemyCoreMachoConfig
    {
        [FieldOffset(0x00)] public EnemyCoreMachoCommonParam commonParam;
    }

}