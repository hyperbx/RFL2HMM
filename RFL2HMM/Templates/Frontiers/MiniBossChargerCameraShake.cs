using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossChargerCameraShakeClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct MiniBossChargerCameraShake
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float magnitude;
        [FieldOffset(0x08)] public int freq;
        [FieldOffset(0x0C)] public float attnRatio;
        [FieldOffset(0x10)] public float shakeRange;
    }

}