Library "EnemyEggGunnerConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct EnemyEggGunnerCommon
    {
        [FieldOffset(0x00)] public float stunHp;
        [FieldOffset(0x04)] public float chaosSpearStunTime;
        [FieldOffset(0x10)] public EnemyCollisionParam collisionParam;
        [FieldOffset(0x70)] public EnemyComboParam comboParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct EnemyEggGunnerGuidedRocketParam
    {
        [FieldOffset(0x00)] public float searchDistance;
        [FieldOffset(0x04)] public float horzLimitDegree;
        [FieldOffset(0x08)] public float vertLimitDegree;
        [FieldOffset(0x0C)] public float speed;
        [FieldOffset(0x10)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC0)]
    public struct EnemyEggGunnerConfig
    {
        [FieldOffset(0x00)] public EnemyEggGunnerCommon commonParams;
        [FieldOffset(0x80)] public EnemyEggGunnerGuidedRocketParam guidedRocketParams__arr0;
        [FieldOffset(0x94)] public EnemyEggGunnerGuidedRocketParam guidedRocketParams__arr1;
        [FieldOffset(0xA8)] public EnemyEggGunnerGuidedRocketParam guidedRocketParams__arr2;
    }

}