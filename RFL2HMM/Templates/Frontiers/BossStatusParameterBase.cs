using System.Numerics;
using System.Runtime.InteropServices;

public class BossStatusParameterBaseClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct BossStatusParameterBase
    {
        [FieldOffset(0x00)] public int maxHp;
    }

}