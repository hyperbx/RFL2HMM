using System.Numerics;
using System.Runtime.InteropServices;

public class ObjHackingPlayerMachineConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct PlayerMachineConfig
    {
        [FieldOffset(0x00)] public int baseHp;
        [FieldOffset(0x04)] public int lifeCount;
        [FieldOffset(0x08)] public int lifeUpFailedCount__arr0;
        [FieldOffset(0x0C)] public int lifeUpFailedCount__arr1;
        [FieldOffset(0x10)] public int lifeUpFailedCount__arr2;
        [FieldOffset(0x14)] public int lifeUpFailedCount__arr3;
        [FieldOffset(0x18)] public int lifeUpFailedCount__arr4;
        [FieldOffset(0x1C)] public int lifeUpFailedCount__arr5;
        [FieldOffset(0x20)] public int lifeMax;
        [FieldOffset(0x24)] public float gageUpVolume;
        [FieldOffset(0x28)] public float gageMax;
        [FieldOffset(0x2C)] public int laserNum;
        [FieldOffset(0x30)] public float laserInterval;
        [FieldOffset(0x34)] public float bulletInterval;
        [FieldOffset(0x38)] public float moveSpeed;
        [FieldOffset(0x3C)] public float nodamageTime;
        [FieldOffset(0x40)] public float specialmoveTime;
        [FieldOffset(0x44)] public float bodyCol;
        [FieldOffset(0x48)] public float barrierCol;
        [FieldOffset(0x4C)] public float attackRangeTime;
        [FieldOffset(0x50)] public float expandAttackCol;
        [FieldOffset(0x60)] public Vector3 hitPos;
        [FieldOffset(0x70)] public Vector3 barrierPos;
        [FieldOffset(0x80)] public Vector3 expandAttackPos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct HomingLaserTrailConfig
    {
        [FieldOffset(0x00)] public float length;
        [FieldOffset(0x04)] public float minLength;
        [FieldOffset(0x08)] public float texWidth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct HomingLaserConfig
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float maxAccel;
        [FieldOffset(0x0C)] public float arrivalTime;
        [FieldOffset(0x10)] public float lifeTime;
        [FieldOffset(0x14)] public float minYaw;
        [FieldOffset(0x18)] public float maxYaw;
        [FieldOffset(0x1C)] public float depthVelocity;
        [FieldOffset(0x20)] public uint power;
        [FieldOffset(0x24)] public HomingLaserTrailConfig trail;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct ElementBulletConfig
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float scale;
        [FieldOffset(0x0C)] public uint power;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct HackingConfig
    {
        [FieldOffset(0x00)] public uint dummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE0)]
    public struct ObjHackingPlayerMachineConfig
    {
        [FieldOffset(0x00)] public PlayerMachineConfig machine;
        [FieldOffset(0x90)] public HomingLaserConfig laser;
        [FieldOffset(0xC0)] public ElementBulletConfig bullet;
        [FieldOffset(0xD0)] public HackingConfig hacking;
    }

}