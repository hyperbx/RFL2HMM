Library "GameGrindLodParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct GameGrindLodParameter
    {
        [FieldOffset(0x00)] public float distances__arr0;
        [FieldOffset(0x04)] public float distances__arr1;
        [FieldOffset(0x08)] public float distances__arr2;
        [FieldOffset(0x0C)] public float distances__arr3;
        [FieldOffset(0x10)] public float cullingDistances__arr0;
        [FieldOffset(0x14)] public float cullingDistances__arr1;
        [FieldOffset(0x18)] public float cullingDistances__arr2;
        [FieldOffset(0x1C)] public float cullingDistances__arr3;
    }

}