using System.Numerics;
using System.Runtime.InteropServices;

public class ObjAnimalConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct ObjAnimalConfig
    {
        [FieldOffset(0x00)] public float powerGettingOn;
        [FieldOffset(0x04)] public float timeGettingOn;
        [FieldOffset(0x08)] public float powerGettingOff;
        [FieldOffset(0x0C)] public float timeGettingOff;
        [FieldOffset(0x10)] public int numberOfRotations;
        [FieldOffset(0x14)] public int numberOfRevolutions;
    }

}