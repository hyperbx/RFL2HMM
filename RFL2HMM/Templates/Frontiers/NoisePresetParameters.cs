using System.Numerics;
using System.Runtime.InteropServices;

public class NoisePresetParametersClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct UVShift
    {
        [FieldOffset(0x00)] public float blockLNoiseSizeX;
        [FieldOffset(0x04)] public float blockLNoiseSizeY;
        [FieldOffset(0x08)] public float blockHNoiseSizeX;
        [FieldOffset(0x0C)] public float blockHNoiseSizeY;
        [FieldOffset(0x10)] public float bNoiseHighRate;
        [FieldOffset(0x14)] public float intensity;
        [FieldOffset(0x18)] public float pixelShiftIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct ColorShift
    {
        [FieldOffset(0x00)] public float blockLNoiseSize;
        [FieldOffset(0x04)] public float blockHNoiseSize;
        [FieldOffset(0x08)] public float bNoiseHighRate;
        [FieldOffset(0x0C)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct InterlaceNoise
    {
        [FieldOffset(0x00)] public float blockLNoiseSize;
        [FieldOffset(0x04)] public float blockHNoiseSize;
        [FieldOffset(0x08)] public float bNoiseHighRate;
        [FieldOffset(0x0C)] public float intensity;
        [FieldOffset(0x10)] public float dropout;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct ColorDropout
    {
        [FieldOffset(0x00)] public float blockLNoiseSizeX;
        [FieldOffset(0x04)] public float blockLNoiseSizeY;
        [FieldOffset(0x08)] public float blockHNoiseSizeX;
        [FieldOffset(0x0C)] public float blockHNoiseSizeY;
        [FieldOffset(0x10)] public float bNoiseHighRate;
        [FieldOffset(0x14)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct InvertColor
    {
        [FieldOffset(0x00)] public float blockLNoiseSizeX;
        [FieldOffset(0x04)] public float blockLNoiseSizeY;
        [FieldOffset(0x08)] public float blockHNoiseSizeX;
        [FieldOffset(0x0C)] public float blockHNoiseSizeY;
        [FieldOffset(0x10)] public float bNoiseHighRate;
        [FieldOffset(0x14)] public float intensity;
        [FieldOffset(0x18)] public float invertAllRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct GlayScaleColor
    {
        [FieldOffset(0x00)] public float blockLNoiseSizeX;
        [FieldOffset(0x04)] public float blockLNoiseSizeY;
        [FieldOffset(0x08)] public float blockHNoiseSizeX;
        [FieldOffset(0x0C)] public float blockHNoiseSizeY;
        [FieldOffset(0x10)] public float bNoiseHighRate;
        [FieldOffset(0x14)] public float intensity;
        [FieldOffset(0x18)] public float invertAllRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA4)]
    public struct FxCyberSpaceStartNoiseParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public UVShift uvShift;
        [FieldOffset(0x20)] public ColorShift colorShift;
        [FieldOffset(0x30)] public InterlaceNoise interlaceNoise;
        [FieldOffset(0x44)] public ColorDropout colorDrop;
        [FieldOffset(0x5C)] public InvertColor invertColor;
        [FieldOffset(0x78)] public GlayScaleColor glayscaleColor;
        [FieldOffset(0x94)] public float noiseSpeed;
        [FieldOffset(0x98)] public float noiseBias;
        [FieldOffset(0x9C)] public float noiseWaveAmplitude;
        [FieldOffset(0xA0)] public float noiseWaveCycle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x520)]
    public struct NoisePresetParameters
    {
        [FieldOffset(0x00)] public FxCyberSpaceStartNoiseParameter presets__arr0;
        [FieldOffset(0xA4)] public FxCyberSpaceStartNoiseParameter presets__arr1;
        [FieldOffset(0x148)] public FxCyberSpaceStartNoiseParameter presets__arr2;
        [FieldOffset(0x1EC)] public FxCyberSpaceStartNoiseParameter presets__arr3;
        [FieldOffset(0x290)] public FxCyberSpaceStartNoiseParameter presets__arr4;
        [FieldOffset(0x334)] public FxCyberSpaceStartNoiseParameter presets__arr5;
        [FieldOffset(0x3D8)] public FxCyberSpaceStartNoiseParameter presets__arr6;
        [FieldOffset(0x47C)] public FxCyberSpaceStartNoiseParameter presets__arr7;
    }

}