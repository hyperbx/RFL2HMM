Library "FxHDRParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum OutputType : sbyte
    {
        OUTPUT_TYPE_SDR = 0,
        OUTPUT_TYPE_HDR = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct FxHDRParameter
    {
        [FieldOffset(0x00)] public OutputType outputType;
        [FieldOffset(0x04)] public float baseNits;
        [FieldOffset(0x08)] public float maxNitsLevel;
        [FieldOffset(0x0C)] public float minNitsLevel;
        [FieldOffset(0x10)] public float extendHue;
        [FieldOffset(0x14)] public float extendSaturation;
        [FieldOffset(0x18)] public bool autoNitsSetting;
    }

}