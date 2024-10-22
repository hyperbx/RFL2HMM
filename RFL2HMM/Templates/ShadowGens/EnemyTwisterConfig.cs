Library "EnemyTwisterConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct DebrisParameter
    {
        [FieldOffset(0x00)] public int m_maxNumPieces;
        [FieldOffset(0x04)] public float gravity;
        [FieldOffset(0x08)] public float lifeTime;
        [FieldOffset(0x0C)] public float force;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100)]
    public struct EnemyTwisterCommonConfig
    {
        [FieldOffset(0x00)] public EnemyCollisionParam collisionParam;
        [FieldOffset(0x60)] public float attackColliderRadius;
        [FieldOffset(0x64)] public EnemyComboParam comboParam;
        [FieldOffset(0x70)] public EnemyCollisionParam collisionParamSV;
        [FieldOffset(0xD0)] public float attackColliderRadiusSV;
        [FieldOffset(0xD4)] public EnemyComboParam comboParamSV;
        [FieldOffset(0xDC)] public float battleDistance;
        [FieldOffset(0xE0)] public float rotateSpeed;
        [FieldOffset(0xE4)] public float chaosSpearStunTime;
        [FieldOffset(0xE8)] public bool useUniqueDebrisSetting;
        [FieldOffset(0xEC)] public DebrisParameter debris;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100)]
    public struct EnemyTwisterConfig
    {
        [FieldOffset(0x00)] public EnemyTwisterCommonConfig commonParams;
    }

}