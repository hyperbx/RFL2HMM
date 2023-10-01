using System.Numerics;
using System.Runtime.InteropServices;

public class GameExpParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct GameExpParameter
    {
        [FieldOffset(0x00)] public uint maxExpPointBase;
        [FieldOffset(0x04)] public uint maxExpPointAdd;
    }

}