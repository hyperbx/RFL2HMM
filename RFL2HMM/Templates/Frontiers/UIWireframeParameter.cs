using System.Numerics;
using System.Runtime.InteropServices;

public class UIWireframeParameterClass
{
    public enum RenderTargetSize : int
    {
        RTSIZE_FULL_SCALE = 0,
        RTSIZE_HALF_SCALE = 1,
        RTSIZE_QUARTER_SCALE = 2,
        RTSIZE_COUNT = 3,
        RTSIZE_INVALID = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x54)]
    public struct FxDOFParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool useFocusLookAt;
        [FieldOffset(0x04)] public float foregroundBokehMaxDepth;
        [FieldOffset(0x08)] public float foregroundBokehStartDepth;
        [FieldOffset(0x0C)] public float backgroundBokehStartDepth;
        [FieldOffset(0x10)] public float backgroundBokehMaxDepth;
        [FieldOffset(0x14)] public bool enableCircleDOF;
        [FieldOffset(0x18)] public float cocMaxRadius;
        [FieldOffset(0x1C)] public float bokehRadiusScale;
        [FieldOffset(0x20)] public int bokehSampleCount;
        [FieldOffset(0x24)] public float skyFocusDistance;
        [FieldOffset(0x28)] public float bokehBias;
        [FieldOffset(0x2C)] public bool drawFocalPlane;
        [FieldOffset(0x30)] public RenderTargetSize rtScale;
        [FieldOffset(0x34)] public bool enableSWA;
        [FieldOffset(0x38)] public float swaFocus;
        [FieldOffset(0x3C)] public float swaFocusRange;
        [FieldOffset(0x40)] public float swaNear;
        [FieldOffset(0x44)] public float swaFar;
        [FieldOffset(0x48)] public bool enableEnhancedForeBokeh;
        [FieldOffset(0x4C)] public float foreBokehScale;
        [FieldOffset(0x50)] public float foreBokehMaxLuminance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct UIWireframeParameter
    {
        [FieldOffset(0x00)] public Vector3 camerapos;
        [FieldOffset(0x10)] public float lineAlpha;
        [FieldOffset(0x14)] public float noiseScale;
        [FieldOffset(0x18)] public float noiseSpeed;
        [FieldOffset(0x1C)] public float moveWidth;
        [FieldOffset(0x20)] public FxDOFParameter dofparam;
    }

}