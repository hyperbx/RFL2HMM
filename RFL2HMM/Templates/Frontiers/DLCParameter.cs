using System.Numerics;
using System.Runtime.InteropServices;

public class DLCParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct DLCParameter
    {
        [FieldOffset(0x00)] public byte dummy;
    }

}