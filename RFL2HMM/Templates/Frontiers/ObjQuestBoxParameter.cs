using System.Numerics;
using System.Runtime.InteropServices;

public class ObjQuestBoxParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct ObjQuestBoxParameter
    {
        [FieldOffset(0x00)] public float dropBoxProbabilly;
        [FieldOffset(0x04)] public float boxHpSmall;
        [FieldOffset(0x08)] public float boxHpMiddle;
        [FieldOffset(0x0C)] public float boxHpLarge;
        [FieldOffset(0x10)] public float friction;
        [FieldOffset(0x14)] public float mass;
        [FieldOffset(0x18)] public float gravity;
        [FieldOffset(0x1C)] public float linearDamping;
        [FieldOffset(0x20)] public float angularDamping;
        [FieldOffset(0x30)] public Vector3 maxSpeed;
    }

}