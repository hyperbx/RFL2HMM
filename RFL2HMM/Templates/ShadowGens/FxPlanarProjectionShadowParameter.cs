Library "FxPlanarProjectionShadowParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct FxPlanarProjectionShadowParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector4 projectionPlane;
        [FieldOffset(0x20)] public Vector3 lightPosition__arr0;
        [FieldOffset(0x30)] public Vector3 lightPosition__arr1;
        [FieldOffset(0x40)] public Vector3 lightPosition__arr2;
        [FieldOffset(0x50)] public Vector3 lightPosition__arr3;
        [FieldOffset(0x60)] public sbyte lightCount;
        [FieldOffset(0x64)] public float vanishStart;
        [FieldOffset(0x68)] public float vanishDistance;
        [FieldOffset(0x6C)] public float projectionBias;
        [FieldOffset(0x70)] public Vector3 shadowMapBoxSize;
        [FieldOffset(0x80)] public Vector3 shadowMapBoxOffset;
    }

}