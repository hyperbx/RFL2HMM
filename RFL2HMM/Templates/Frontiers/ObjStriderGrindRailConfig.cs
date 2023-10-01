using System.Numerics;
using System.Runtime.InteropServices;

public class ObjStriderGrindRailConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct ObjStriderGrindRailConfig
    {
        [FieldOffset(0x00)] public float bulletSpeed;
        [FieldOffset(0x04)] public float bulletRotDegPerSec;
        [FieldOffset(0x08)] public float jumpToCenterTime;
        [FieldOffset(0x0C)] public float jumpTime;
        [FieldOffset(0x10)] public float jumpToCenterTangentY;
        [FieldOffset(0x14)] public float jumpTangentMultiplier;
        [FieldOffset(0x18)] public float jumpDestinationOffsetY;
        [FieldOffset(0x1C)] public float jumpDestinationOffsetXZ;
        [FieldOffset(0x20)] public float jumpToFloorHeight;
        [FieldOffset(0x24)] public float jumpToFloorOffset;
        [FieldOffset(0x28)] public float jumpToFloorTime;
        [FieldOffset(0x2C)] public float bulletWaitTime;
        [FieldOffset(0x30)] public float timeTilDisappear;
        [FieldOffset(0x34)] public float segmentLength;
        [FieldOffset(0x38)] public float collisionHeight;
        [FieldOffset(0x3C)] public float collisionRadiusAddend;
        [FieldOffset(0x40)] public float initialEffectScaleY;
        [FieldOffset(0x44)] public float initialEffectScaleXZ;
        [FieldOffset(0x48)] public float maxEffectScaleXZ;
        [FieldOffset(0x4C)] public float timeToMaxEffectScale;
    }

}