using System.Numerics;
using System.Runtime.InteropServices;

public class ObjHoverStoneConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct ObjHoverStoneConfig
    {
        [FieldOffset(0x00)] public float hoverUpSpeed;
        [FieldOffset(0x04)] public float fallSpeed;
        [FieldOffset(0x08)] public float homingAttackBounce;
    }

}