Library "EnemyEggpawnFcConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x100)]
    public struct EnemyEggpawnFcConfig
    {
        [FieldOffset(0x00)] public float shotSpeedFV;
        [FieldOffset(0x04)] public float shotSpeedSV;
        [FieldOffset(0x08)] public float bulletScaleFV;
        [FieldOffset(0x0C)] public float bulletScaleSV;
        [FieldOffset(0x10)] public float bulletMaxDistanceFV;
        [FieldOffset(0x14)] public float bulletMaxDistanceSV;
        [FieldOffset(0x18)] public uint shotContinuousShotNum;
        [FieldOffset(0x1C)] public uint shotContinuousShotNumConst;
        [FieldOffset(0x20)] public float shotCoolDownTime;
        [FieldOffset(0x24)] public float shotCoolDownTimeConst;
        [FieldOffset(0x28)] public float damageCoolDownTime;
        [FieldOffset(0x2C)] public float shotInterval;
        [FieldOffset(0x30)] public float serachAngleY;
        [FieldOffset(0x34)] public float oneHandShotSpeedFV;
        [FieldOffset(0x38)] public float oneHandShotSpeedSV;
        [FieldOffset(0x3C)] public float oneHandBulletScaleFV;
        [FieldOffset(0x40)] public float oneHandBulletScaleSV;
        [FieldOffset(0x44)] public float oneHandBulletMaxDistanceFV;
        [FieldOffset(0x48)] public float oneHandBulletMaxDistanceSV;
        [FieldOffset(0x4C)] public uint oneHandShotContinuousShotNum;
        [FieldOffset(0x50)] public float oneHandShotCoolDownTime;
        [FieldOffset(0x54)] public float oneHandDamageCoolDownTime;
        [FieldOffset(0x58)] public float oneHandShotInterval;
        [FieldOffset(0x5C)] public float oneHandChargeTime;
        [FieldOffset(0x60)] public float oneHandSerachAngleY;
        [FieldOffset(0x64)] public float fallSpeed;
        [FieldOffset(0x68)] public float fallSpeedAppear;
        [FieldOffset(0x6C)] public float fallDeadTime;
        [FieldOffset(0x70)] public float threadGrassRadius;
        [FieldOffset(0x74)] public float threadGrassTime;
        [FieldOffset(0x78)] public float checkOnGroundUpOffset;
        [FieldOffset(0x7C)] public float chaosSpearStunTime;
        [FieldOffset(0x80)] public float respawnTime;
        [FieldOffset(0x90)] public EnemyCollisionParam collisionParam;
        [FieldOffset(0xF0)] public EnemyComboParam comboParam;
    }

}