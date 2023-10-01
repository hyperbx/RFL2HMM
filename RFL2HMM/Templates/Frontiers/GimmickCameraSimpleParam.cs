using System.Numerics;
using System.Runtime.InteropServices;

public class GimmickCameraSimpleParamClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct GimmickCameraSimpleParam
    {
        [FieldOffset(0x00)] public Vector3 targetOffset;
        [FieldOffset(0x10)] public Vector3 cameraPosOffset;
    }

}