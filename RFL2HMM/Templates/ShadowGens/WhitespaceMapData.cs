Library "WhitespaceMapData"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x02)]
    public struct WhitespaceMapGridData
    {
        [FieldOffset(0x00)] public byte x;
        [FieldOffset(0x01)] public byte y;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x06)]
    public struct WhitespaceMapData
    {
        [FieldOffset(0x00)] public WhitespaceMapGridData grid__arr0;
        [FieldOffset(0x02)] public WhitespaceMapGridData grid__arr1;
        [FieldOffset(0x04)] public ushort numReleaseGrids;
    }

}