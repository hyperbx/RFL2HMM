using System.Numerics;
using System.Runtime.InteropServices;

public class ObjWolfManagerConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FocusCameraConfig
    {
        [FieldOffset(0x00)] public float duration;
        [FieldOffset(0x04)] public float distance;
        [FieldOffset(0x08)] public float minElevation;
        [FieldOffset(0x0C)] public float maxElevation;
        [FieldOffset(0x10)] public float panningSuspensionK;
        [FieldOffset(0x14)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x48)]
    public struct ObjWolfManagerConfig
    {
        [FieldOffset(0x00)] public FocusCameraConfig focusCamera;
        [FieldOffset(0x18)] public float shotInterval;
        [FieldOffset(0x1C)] public float shotInterval_Parried;
        [FieldOffset(0x20)] public float shotInterval_Reborn;
        [FieldOffset(0x24)] public float shotInterval_First;
        [FieldOffset(0x28)] public float shotInterval_NoReborn;
        [FieldOffset(0x2C)] public float stunTime;
        [FieldOffset(0x30)] public float approachWait;
        [FieldOffset(0x34)] public float dispWait;
        [FieldOffset(0x38)] public float rollWait;
        [FieldOffset(0x3C)] public float reactionTime;
        [FieldOffset(0x40)] public float controlDelay;
        [FieldOffset(0x44)] public float shotAngle;
    }

}