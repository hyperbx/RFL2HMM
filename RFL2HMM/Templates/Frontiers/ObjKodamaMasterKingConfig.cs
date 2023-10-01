using System.Numerics;
using System.Runtime.InteropServices;

public class ObjKodamaMasterKingConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct KodamaMasterKingCamera
    {
        [FieldOffset(0x00)] public Vector3 camLookAtOffset;
        [FieldOffset(0x10)] public Vector3 camEyeOffset;
        [FieldOffset(0x20)] public float camFovy;
        [FieldOffset(0x24)] public float camRoll;
        [FieldOffset(0x28)] public float camEaseInTime;
        [FieldOffset(0x2C)] public float camEaseOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC0)]
    public struct ObjKodamaMasterKingConfig
    {
        [FieldOffset(0x00)] public float playerChangeFadeOutTime;
        [FieldOffset(0x04)] public float followingDistance;
        [FieldOffset(0x08)] public float followingNormalSpeed;
        [FieldOffset(0x0C)] public float followingDecelerationSpeed;
        [FieldOffset(0x10)] public float followingDecelerationDistance;
        [FieldOffset(0x14)] public float followingHomingDistance;
        [FieldOffset(0x18)] public float followingHomingNormalSpeed;
        [FieldOffset(0x1C)] public float followingHomingDecelerationSpeed;
        [FieldOffset(0x20)] public float followingHomingDecelerationDistance;
        [FieldOffset(0x24)] public float followingHeightPosition;
        [FieldOffset(0x28)] public float SuperSonicfollowingNormalSpeed;
        [FieldOffset(0x2C)] public float SuperSonicfollowingDecelerationSpeed;
        [FieldOffset(0x30)] public float SuperSonicfollowingDecelerationDistance;
        [FieldOffset(0x34)] public float SuperSonicfollowingHomingNormalSpeed;
        [FieldOffset(0x38)] public float SuperSonicfollowingHomingDecelerationSpeed;
        [FieldOffset(0x3C)] public float SuperSonicfollowingHomingDecelerationDistance;
        [FieldOffset(0x40)] public Vector3 followingInitialLocalPosition;
        [FieldOffset(0x50)] public Vector3 superSonicInitialLocalPosition;
        [FieldOffset(0x60)] public KodamaMasterKingCamera beginCamera;
        [FieldOffset(0x90)] public KodamaMasterKingCamera endCamera;
    }

}