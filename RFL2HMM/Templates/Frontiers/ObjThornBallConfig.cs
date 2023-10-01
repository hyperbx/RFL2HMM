using System.Numerics;
using System.Runtime.InteropServices;

public class ObjThornBallConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct ObjThornBallConfig
    {
        [FieldOffset(0x00)] public float fallStartSpeed;
        [FieldOffset(0x04)] public float gravity;
        [FieldOffset(0x08)] public float releaseAngle;
        [FieldOffset(0x0C)] public float releaseSpeed;
        [FieldOffset(0x10)] public float releasegravity;
    }

}