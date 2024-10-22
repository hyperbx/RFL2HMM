Library "ViewSpaceOffsetRflParam"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct ViewSpaceOffsetRflParam
    {
        [FieldOffset(0x00)] public Vector3 targetOffset;
        [FieldOffset(0x10)] public Vector3 eyeOffset;
    }

}