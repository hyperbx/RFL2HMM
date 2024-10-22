Library "GameTimeStopParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum GradationMode : sbyte
    {
        GRADATION_MODE_CIRCLE = 0,
        GRADATION_MODE_LINE = 1
    }

    public enum BlendMode : sbyte
    {
        BLEND_MODE_ALPHA_BLEND = 0,
        BLEND_MODE_ADD = 1,
        BLEND_MODE_MUL = 2,
        BLEND_MODE_SCREEN = 3,
        BLEND_MODE_OVERLAY = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct GameVignetteCircleParameter
    {
        [FieldOffset(0x00)] public float centerX;
        [FieldOffset(0x04)] public float centerY;
        [FieldOffset(0x08)] public float scaleX;
        [FieldOffset(0x0C)] public float scaleY;
        [FieldOffset(0x10)] public float scale;
        [FieldOffset(0x14)] public float rotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct GameVignetteLineParameter
    {
        [FieldOffset(0x00)] public float centerX;
        [FieldOffset(0x04)] public float centerY;
        [FieldOffset(0x08)] public float directionX;
        [FieldOffset(0x0C)] public float directionY;
        [FieldOffset(0x10)] public float rotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct GameVignetteParameter
    {
        [FieldOffset(0x00)] public GradationMode gradationType;
        [FieldOffset(0x01)] public BlendMode blendMode;
        [FieldOffset(0x10)] public Vector3 color;
        [FieldOffset(0x20)] public float opacity;
        [FieldOffset(0x24)] public GameVignetteCircleParameter imageCircle;
        [FieldOffset(0x3C)] public GameVignetteLineParameter line;
        [FieldOffset(0x50)] public float penumbraScale;
        [FieldOffset(0x54)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x150)]
    public struct GameTimeStopParameter
    {
        [FieldOffset(0x00)] public float scale;
        [FieldOffset(0x04)] public float physicsTimeScale;
        [FieldOffset(0x08)] public float shaderTimeScale;
        [FieldOffset(0x0C)] public float grayColorScale;
        [FieldOffset(0x10)] public float easeOutTime;
        [FieldOffset(0x20)] public GameVignetteParameter vignette;
        [FieldOffset(0x80)] public float vignetteTime;
        [FieldOffset(0x84)] public float vignetteEaseTimeMin;
        [FieldOffset(0x88)] public float vignetteEaseTimeMax;
        [FieldOffset(0x90)] public GameVignetteParameter vignetteEnd1;
        [FieldOffset(0xF0)] public GameVignetteParameter vignetteEnd2;
    }

}