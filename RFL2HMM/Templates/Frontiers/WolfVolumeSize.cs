using System.Numerics;
using System.Runtime.InteropServices;

public class WolfVolumeSizeClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct WolfVolumeSize
    {
        [FieldOffset(0x00)] public float width;
        [FieldOffset(0x04)] public float height;
        [FieldOffset(0x08)] public float depth;
    }

}