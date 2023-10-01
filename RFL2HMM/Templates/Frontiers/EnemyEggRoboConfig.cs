using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyEggRoboConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct EnemyEggRoboConfig
    {
        [FieldOffset(0x00)] public float scaleSv;
        [FieldOffset(0x04)] public float scaleFv;
        [FieldOffset(0x08)] public float appearEffTimer;
        [FieldOffset(0x0C)] public float colliderRadius;
        [FieldOffset(0x10)] public float colliderHeight;
        [FieldOffset(0x20)] public Vector3 colliderOffset;
        [FieldOffset(0x30)] public float laserColliderRadius;
        [FieldOffset(0x34)] public float laserColliderHeight;
        [FieldOffset(0x40)] public Vector3 laserColliderSizeSV;
        [FieldOffset(0x50)] public float missileColliderRadius;
        [FieldOffset(0x54)] public float missileColliderHeight;
        [FieldOffset(0x60)] public Vector3 missileColliderOffset;
    }

}