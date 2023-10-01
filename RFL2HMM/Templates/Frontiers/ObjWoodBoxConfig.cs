using System.Numerics;
using System.Runtime.InteropServices;

public class ObjWoodBoxConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct ObjWoodBoxConfig
    {
        [FieldOffset(0x00)] public float fallStartSpeed;
        [FieldOffset(0x04)] public float gravity;
    }

}