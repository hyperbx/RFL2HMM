Library "FxCloudShadowParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct FxCloudShadowParameter
    {
        [FieldOffset(0x00)] public bool enableShadow;
        [FieldOffset(0x04)] public int shadowCoverage;
        [FieldOffset(0x08)] public float shadowValueMin;
    }

}