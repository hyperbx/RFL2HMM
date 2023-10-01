using System.Numerics;
using System.Runtime.InteropServices;

public class ObjWaveCannonConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct ObjWaveCannonConfig
    {
        [FieldOffset(0x00)] public uint waveCannonBreakNum;
    }

}