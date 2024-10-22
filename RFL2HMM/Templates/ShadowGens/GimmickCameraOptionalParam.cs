Library "GimmickCameraOptionalParam"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct GimmickCameraOptionalParam
    {
        [FieldOffset(0x00)] public bool useCameraParam;
        [FieldOffset(0x04)] public float interoplateTimeActivate;
        [FieldOffset(0x08)] public float interoplateTimeDeactivate;
        [FieldOffset(0x10)] public Vector3 targetOffset;
        [FieldOffset(0x20)] public Vector3 cameraPosOffset;
    }

}