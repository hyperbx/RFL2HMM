Library "RingParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

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

}