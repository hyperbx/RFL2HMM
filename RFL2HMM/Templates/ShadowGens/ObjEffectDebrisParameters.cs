Library "ObjEffectDebrisParameters"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct ExplosionParameter
    {
        [FieldOffset(0x00)] public Vector3 centerPosOffsetMin;
        [FieldOffset(0x10)] public Vector3 centerPosOffsetMax;
        [FieldOffset(0x20)] public float range;
        [FieldOffset(0x24)] public float powerMin;
        [FieldOffset(0x28)] public float powerMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct ImpulseParameter
    {
        [FieldOffset(0x00)] public Vector3 impulseDir;
        [FieldOffset(0x10)] public float powerMin;
        [FieldOffset(0x14)] public float powerMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct DebrisPhaseParameter
    {
        [FieldOffset(0x00)] public float marginTime;
        [FieldOffset(0x04)] public float nextTime;
        [FieldOffset(0x08)] public float gravity;
        [FieldOffset(0x0C)] public float moveStopTime;
        [FieldOffset(0x10)] public bool damping;
        [FieldOffset(0x20)] public ExplosionParameter explosionParam;
        [FieldOffset(0x50)] public ImpulseParameter impulseParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x150)]
    public struct EffectDebrisParameter
    {
        [FieldOffset(0x00)] public DebrisPhaseParameter debrisPhaseParameters__arr0;
        [FieldOffset(0x70)] public DebrisPhaseParameter debrisPhaseParameters__arr1;
        [FieldOffset(0xE0)] public DebrisPhaseParameter debrisPhaseParameters__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xD20)]
    public struct ObjEffectDebrisParameters
    {
        [FieldOffset(0x00)] public EffectDebrisParameter effectDebrisParameters__arr0;
        [FieldOffset(0x150)] public EffectDebrisParameter effectDebrisParameters__arr1;
        [FieldOffset(0x2A0)] public EffectDebrisParameter effectDebrisParameters__arr2;
        [FieldOffset(0x3F0)] public EffectDebrisParameter effectDebrisParameters__arr3;
        [FieldOffset(0x540)] public EffectDebrisParameter effectDebrisParameters__arr4;
        [FieldOffset(0x690)] public EffectDebrisParameter effectDebrisParameters__arr5;
        [FieldOffset(0x7E0)] public EffectDebrisParameter effectDebrisParameters__arr6;
        [FieldOffset(0x930)] public EffectDebrisParameter effectDebrisParameters__arr7;
        [FieldOffset(0xA80)] public EffectDebrisParameter effectDebrisParameters__arr8;
        [FieldOffset(0xBD0)] public EffectDebrisParameter effectDebrisParameters__arr9;
    }

}