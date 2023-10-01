using System.Numerics;
using System.Runtime.InteropServices;

public class TimeServiceParamClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct TimeServiceParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float timeMagnification;
        [FieldOffset(0x08)] public int addMinuteReturnFromCyber;
    }

}