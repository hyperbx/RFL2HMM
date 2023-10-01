using System.Numerics;
using System.Runtime.InteropServices;

public class OffMeshLinkParameterClass
{
    public enum OffMeshLinkDirection : byte
    {
        OffMeshLinkUnidirectional = 0,
        OffMeshLinkBidirectional = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct OffMeshLinkElement
    {
        [FieldOffset(0x00)] public Vector3 source;
        [FieldOffset(0x10)] public Vector3 destination;
        [FieldOffset(0x20)] public float radius;
        [FieldOffset(0x24)] public ushort flags;
        [FieldOffset(0x26)] public byte area;
        [FieldOffset(0x27)] public OffMeshLinkDirection direction;
        [FieldOffset(0x28)] public uint userID;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct OffMeshLinkElementArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct OffMeshLinkParameter
    {
        [FieldOffset(0x00)] public OffMeshLinkElementArray elements;
    }

}