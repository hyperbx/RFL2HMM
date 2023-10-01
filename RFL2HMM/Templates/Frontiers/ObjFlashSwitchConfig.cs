using System.Numerics;
using System.Runtime.InteropServices;

public class ObjFlashSwitchConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct ObjFlashSwitchConfig
    {
        [FieldOffset(0x00)] public float recoveryQuickCyloopValue;
    }

}