Library "FxDirectionalRadialBlurParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct FxDirectionalRadialBlurParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector3 center;
        [FieldOffset(0x20)] public Vector3 direction;
        [FieldOffset(0x30)] public float blurPowerMax;
        [FieldOffset(0x34)] public float blurPowerMin;
        [FieldOffset(0x38)] public float focusRange;
        [FieldOffset(0x3C)] public float alphaSlope;
        [FieldOffset(0x40)] public int sampleNum;
    }

}