Library "FxFXAAParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum QualityType : sbyte
    {
        QUALITY_LOW = 0,
        QUALITY_MEDIUM = 1,
        QUALITY_HIGH = 2,
        QUALITY_COUNT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct FxFXAAParameter
    {
        [FieldOffset(0x00)] public QualityType qualityType;
    }

}