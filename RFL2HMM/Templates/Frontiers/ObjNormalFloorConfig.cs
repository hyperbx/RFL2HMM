using System.Numerics;
using System.Runtime.InteropServices;

public class ObjNormalFloorConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct NormalFloorSize
    {
        [FieldOffset(0x00)] public float length;
        [FieldOffset(0x04)] public float width;
        [FieldOffset(0x08)] public float height;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x78)]
    public struct ObjNormalFloorConfig
    {
        [FieldOffset(0x00)] public NormalFloorSize sizeInfo__arr0;
        [FieldOffset(0x0C)] public NormalFloorSize sizeInfo__arr1;
        [FieldOffset(0x18)] public NormalFloorSize sizeInfo__arr2;
        [FieldOffset(0x24)] public NormalFloorSize sizeInfo__arr3;
        [FieldOffset(0x30)] public NormalFloorSize sizeInfo__arr4;
        [FieldOffset(0x3C)] public NormalFloorSize sizeInfo__arr5;
        [FieldOffset(0x48)] public NormalFloorSize sizeInfo__arr6;
        [FieldOffset(0x54)] public NormalFloorSize sizeInfo__arr7;
        [FieldOffset(0x60)] public NormalFloorSize sizeInfo__arr8;
        [FieldOffset(0x6C)] public NormalFloorSize sizeInfo__arr9;
    }

}