using System.Numerics;
using System.Runtime.InteropServices;

public class DecoConfigParamClass
{
    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct DecoConfigParam
    {
        [FieldOffset(0x00)] public Color8 clientColor;
        [FieldOffset(0x04)] public byte windowAlpha;
        [FieldOffset(0x08)] public Color8 startGradationGuideColor;
        [FieldOffset(0x0C)] public Color8 endGradationGuideColor;
    }

}