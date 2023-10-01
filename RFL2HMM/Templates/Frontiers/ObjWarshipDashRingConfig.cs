using System.Numerics;
using System.Runtime.InteropServices;

public class ObjWarshipDashRingConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct ObjWarshipDashRingConfig
    {
        [FieldOffset(0x00)] public float baseHeight;
    }

}