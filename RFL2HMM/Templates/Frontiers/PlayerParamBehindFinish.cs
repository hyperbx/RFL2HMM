using System.Numerics;
using System.Runtime.InteropServices;

public class PlayerParamBehindFinishClass
{
    public enum Condition : sbyte
    {
        Time = 0,
        Animation = 1
    }

    public enum Shape : sbyte
    {
        Sphere = 0,
        Cylinder = 1,
        Box = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct PlayerParamAttackCollider
    {
        [FieldOffset(0x00)] public Condition condition;
        [FieldOffset(0x01)] public sbyte count;
        [FieldOffset(0x04)] public float spanTime;
        [FieldOffset(0x08)] public Shape shape;
        [FieldOffset(0x10)] public Vector3 shapeSize;
        [FieldOffset(0x20)] public Vector3 shapeOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamBehindFinish
    {
        [FieldOffset(0x00)] public PlayerParamAttackCollider hit;
        [FieldOffset(0x30)] public float ignoreSwingingTime;
    }

}