using System.Numerics;
using System.Runtime.InteropServices;

public class ObjBossRingSupplyConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct RingParameter
    {
        [FieldOffset(0x00)] public float suckedTime;
        [FieldOffset(0x04)] public float launchAngle;
        [FieldOffset(0x08)] public float launchMaxSpeed;
        [FieldOffset(0x0C)] public float launchMinSpeed;
        [FieldOffset(0x10)] public float randomRangeMin;
        [FieldOffset(0x14)] public float randomRangeMax;
        [FieldOffset(0x18)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct ObjBossRingSupplyConfig
    {
        [FieldOffset(0x00)] public RingParameter ringParam;
        [FieldOffset(0x1C)] public float requestTime;
        [FieldOffset(0x20)] public float accessDistance;
        [FieldOffset(0x24)] public uint numRings__arr0;
        [FieldOffset(0x28)] public uint numRings__arr1;
        [FieldOffset(0x2C)] public uint numRings__arr2;
    }

}