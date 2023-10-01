using System.Numerics;
using System.Runtime.InteropServices;

public class ObjRotatableStatueConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct GimmickCameraParam
    {
        [FieldOffset(0x00)] public float interoplateTimeActivate;
        [FieldOffset(0x04)] public float interoplateTimeDeactivate;
        [FieldOffset(0x10)] public Vector3 targetOffset;
        [FieldOffset(0x20)] public Vector3 cameraPosOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct ObjRotatableStatueConfig
    {
        [FieldOffset(0x00)] public GimmickCameraParam cameraParam;
    }

}