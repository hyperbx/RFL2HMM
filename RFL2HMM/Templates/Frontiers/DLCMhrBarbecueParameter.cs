using System.Numerics;
using System.Runtime.InteropServices;

public class DLCMhrBarbecueParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct DLCMhrBarbecueTokenParam
    {
        [FieldOffset(0x00)] public uint rawToken;
        [FieldOffset(0x04)] public uint rawBurnToken;
        [FieldOffset(0x08)] public uint brownedToken;
        [FieldOffset(0x0C)] public uint charredToken;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x64)]
    public struct DLCMhrBarbecueParameter
    {
        [FieldOffset(0x00)] public float rawTime;
        [FieldOffset(0x04)] public float rawBurnTime;
        [FieldOffset(0x08)] public float brownedTime;
        [FieldOffset(0x0C)] public float charredTime;
        [FieldOffset(0x10)] public float startwaitTime;
        [FieldOffset(0x14)] public float successTime;
        [FieldOffset(0x18)] public float missTime;
        [FieldOffset(0x1C)] public float resultUIDelaySuccess;
        [FieldOffset(0x20)] public float resultUIDelayFaild;
        [FieldOffset(0x24)] public DLCMhrBarbecueTokenParam tokenParam__arr0;
        [FieldOffset(0x34)] public DLCMhrBarbecueTokenParam tokenParam__arr1;
        [FieldOffset(0x44)] public DLCMhrBarbecueTokenParam tokenParam__arr2;
        [FieldOffset(0x54)] public DLCMhrBarbecueTokenParam tokenParam__arr3;
    }

}