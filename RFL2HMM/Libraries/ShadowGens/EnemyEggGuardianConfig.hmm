Library "EnemyEggGuardianConfig"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct EnemyBlockCollisionParam
    {
        [FieldOffset(0x00)] public float collisionRadius;
        [FieldOffset(0x04)] public float collisionHeight;
        [FieldOffset(0x10)] public Vector3 collisionPosOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct EnemyCollisionParam
    {
        [FieldOffset(0x00)] public EnemyBlockCollisionParam blockCollisionParam;
        [FieldOffset(0x20)] public float damageCollisionRadiusOffset;
        [FieldOffset(0x24)] public float damageCollisionHeightOffset;
        [FieldOffset(0x30)] public Vector3 damageCollisionPosOffset;
        [FieldOffset(0x40)] public float touchCollisionRadiusOffset;
        [FieldOffset(0x44)] public float touchCollisionHeightOffset;
        [FieldOffset(0x50)] public Vector3 touchCollisionPosOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct EnemyComboParam
    {
        [FieldOffset(0x00)] public float warpRadius;
        [FieldOffset(0x04)] public float warpHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC0)]
    public struct EnemyEggGuardianCommonParam
    {
        [FieldOffset(0x00)] public float killWaitTime;
        [FieldOffset(0x04)] public float rotateSpeed;
        [FieldOffset(0x08)] public float startShootRocketPunchWaitTime;
        [FieldOffset(0x0C)] public float rocketPunchSpeed;
        [FieldOffset(0x10)] public float rocketPunchHomingAngularSpeed;
        [FieldOffset(0x14)] public float rocketPunchHomingOnTime;
        [FieldOffset(0x18)] public float rocketPunchRicochetSpeed;
        [FieldOffset(0x1C)] public float rocketPunchLifeTime;
        [FieldOffset(0x20)] public float startShootVulcanWaitTime;
        [FieldOffset(0x24)] public float readyVulcanWaitTime;
        [FieldOffset(0x28)] public float vulcanSpeed;
        [FieldOffset(0x2C)] public float vulcanIntervalTime;
        [FieldOffset(0x30)] public float vulcanRadius;
        [FieldOffset(0x34)] public float vulcanRange;
        [FieldOffset(0x38)] public float vulcanRotateSpeedRate;
        [FieldOffset(0x3C)] public int vulcanRotateCount;
        [FieldOffset(0x40)] public float revivalArmsWaitTime;
        [FieldOffset(0x44)] public float stunTime;
        [FieldOffset(0x50)] public EnemyCollisionParam collisionParam;
        [FieldOffset(0xB0)] public EnemyComboParam comboParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC0)]
    public struct EnemyEggGuardianConfig
    {
        [FieldOffset(0x00)] public EnemyEggGuardianCommonParam commonParam;
    }

}