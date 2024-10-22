Library "EnemyMotoraConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct EnemyMotoraConfig
    {
        [FieldOffset(0x00)] public float respawnTime;
        [FieldOffset(0x04)] public float fallSpeed;
        [FieldOffset(0x08)] public float threadGrassRadius;
        [FieldOffset(0x0C)] public float threadGrassTime;
        [FieldOffset(0x10)] public float rigidbodyMaxSpeed;
        [FieldOffset(0x14)] public float chaosSpearStunTime;
        [FieldOffset(0x20)] public EnemyCollisionParam collisionParam;
        [FieldOffset(0x80)] public EnemyComboParam comboParam;
    }

}