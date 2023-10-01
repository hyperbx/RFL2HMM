using System.Numerics;
using System.Runtime.InteropServices;

public class ObjWeightConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct ObjWeightConfig
    {
        [FieldOffset(0x00)] public float fallStartSpeed;
        [FieldOffset(0x04)] public float gravity;
    }

}