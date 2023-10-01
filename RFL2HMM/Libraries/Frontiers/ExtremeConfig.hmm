Library "ExtremeConfig"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum LineType : sbyte
    {
        LINE3 = 0,
        LINE5 = 1,
        LINE_INF = 2
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct ExtremeConfig
    {
        [FieldOffset(0x00)] public LineType lineType;
        [FieldOffset(0x04)] public float lineWidth;
        [FieldOffset(0x08)] public float roadLength;
        [FieldOffset(0x0C)] public float speed;
        [FieldOffset(0x10)] public float barricadeInterval;
        [FieldOffset(0x14)] public float emergencyDistance;
        [FieldOffset(0x20)] public Vector3 barricadeSize;
        [FieldOffset(0x30)] public Color8 roadColor;
        [FieldOffset(0x34)] public Color8 barricadeColor;
        [FieldOffset(0x38)] public float cameraFovy;
        [FieldOffset(0x3C)] public float cameraDistance;
        [FieldOffset(0x40)] public float cameraUpOffset;
        [FieldOffset(0x44)] public float cameraShakeOffset;
    }

}