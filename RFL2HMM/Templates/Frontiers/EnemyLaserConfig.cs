using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyLaserConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyLaserConfig
    {
        [FieldOffset(0x00)] public float rotLaserVanishTime;
        [FieldOffset(0x04)] public float rotLaserOmenTime;
        [FieldOffset(0x08)] public float bigLaserVanishTime;
        [FieldOffset(0x0C)] public float bigLaserOmenTime;
    }

}