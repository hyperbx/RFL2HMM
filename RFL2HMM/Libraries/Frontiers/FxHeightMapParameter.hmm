Library "FxHeightMapParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct FxHeightMapParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool enableMultiHeightmap;
        [FieldOffset(0x02)] public bool debugDrawFrustum;
        [FieldOffset(0x03)] public bool reprojection;
        [FieldOffset(0x04)] public uint renderTargetWidth;
        [FieldOffset(0x08)] public uint renderTargetHeight;
        [FieldOffset(0x0C)] public float referenceValue;
        [FieldOffset(0x10)] public float heightScale;
        [FieldOffset(0x14)] public float fadeTime;
        [FieldOffset(0x18)] public float colorMask;
        [FieldOffset(0x20)] public Matrix4x4 viewMatrix;
        [FieldOffset(0x60)] public Matrix4x4 projMatrix;
    }

}