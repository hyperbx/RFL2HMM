using System.Numerics;
using System.Runtime.InteropServices;

public class ViewSpaceOffsetRflParamClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct ViewSpaceOffsetRflParam
    {
        [FieldOffset(0x00)] public Vector3 targetOffset;
        [FieldOffset(0x10)] public Vector3 eyeOffset;
    }

}