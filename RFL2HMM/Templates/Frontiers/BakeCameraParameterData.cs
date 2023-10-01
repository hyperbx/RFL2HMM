using System.Numerics;
using System.Runtime.InteropServices;

public class BakeCameraParameterDataClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BakeCameraParameterData
    {
        [FieldOffset(0x00)] public Vector3 target;
        [FieldOffset(0x10)] public Vector3 eye;
    }

}