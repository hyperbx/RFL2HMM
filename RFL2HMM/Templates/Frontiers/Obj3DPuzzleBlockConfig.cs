using System.Numerics;
using System.Runtime.InteropServices;

public class Obj3DPuzzleBlockConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x05)]
    public struct FSRow
    {
        [FieldOffset(0x00)] public byte columns__arr0;
        [FieldOffset(0x01)] public byte columns__arr1;
        [FieldOffset(0x02)] public byte columns__arr2;
        [FieldOffset(0x03)] public byte columns__arr3;
        [FieldOffset(0x04)] public byte columns__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x19)]
    public struct FSLayer
    {
        [FieldOffset(0x00)] public FSRow rows__arr0;
        [FieldOffset(0x05)] public FSRow rows__arr1;
        [FieldOffset(0x0A)] public FSRow rows__arr2;
        [FieldOffset(0x0F)] public FSRow rows__arr3;
        [FieldOffset(0x14)] public FSRow rows__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct FreeShape
    {
        [FieldOffset(0x00)] public byte numLayers;
        [FieldOffset(0x01)] public byte numRows;
        [FieldOffset(0x02)] public byte numColumns;
        [FieldOffset(0x10)] public Vector3 offsetToTopLeft;
        [FieldOffset(0x20)] public FSLayer layers__arr0;
        [FieldOffset(0x39)] public FSLayer layers__arr1;
        [FieldOffset(0x52)] public FSLayer layers__arr2;
        [FieldOffset(0x6B)] public FSLayer layers__arr3;
        [FieldOffset(0x84)] public FSLayer layers__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1220)]
    public struct Obj3DPuzzleBlockConfig
    {
        [FieldOffset(0x00)] public FreeShape freeShapes__arr0;
        [FieldOffset(0xA0)] public FreeShape freeShapes__arr1;
        [FieldOffset(0x140)] public FreeShape freeShapes__arr2;
        [FieldOffset(0x1E0)] public FreeShape freeShapes__arr3;
        [FieldOffset(0x280)] public FreeShape freeShapes__arr4;
        [FieldOffset(0x320)] public FreeShape freeShapes__arr5;
        [FieldOffset(0x3C0)] public FreeShape freeShapes__arr6;
        [FieldOffset(0x460)] public FreeShape freeShapes__arr7;
        [FieldOffset(0x500)] public FreeShape freeShapes__arr8;
        [FieldOffset(0x5A0)] public FreeShape freeShapes__arr9;
        [FieldOffset(0x640)] public FreeShape freeShapes__arr10;
        [FieldOffset(0x6E0)] public FreeShape freeShapes__arr11;
        [FieldOffset(0x780)] public FreeShape freeShapes__arr12;
        [FieldOffset(0x820)] public FreeShape freeShapes__arr13;
        [FieldOffset(0x8C0)] public FreeShape freeShapes__arr14;
        [FieldOffset(0x960)] public FreeShape freeShapes__arr15;
        [FieldOffset(0xA00)] public FreeShape freeShapes__arr16;
        [FieldOffset(0xAA0)] public FreeShape freeShapes__arr17;
        [FieldOffset(0xB40)] public FreeShape freeShapes__arr18;
        [FieldOffset(0xBE0)] public FreeShape freeShapes__arr19;
        [FieldOffset(0xC80)] public FreeShape freeShapes__arr20;
        [FieldOffset(0xD20)] public FreeShape freeShapes__arr21;
        [FieldOffset(0xDC0)] public FreeShape freeShapes__arr22;
        [FieldOffset(0xE60)] public FreeShape freeShapes__arr23;
        [FieldOffset(0xF00)] public FreeShape freeShapes__arr24;
        [FieldOffset(0xFA0)] public FreeShape freeShapes__arr25;
        [FieldOffset(0x1040)] public FreeShape freeShapes__arr26;
        [FieldOffset(0x10E0)] public FreeShape freeShapes__arr27;
        [FieldOffset(0x1180)] public FreeShape freeShapes__arr28;
    }

}