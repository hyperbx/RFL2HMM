Library "StatsDataContainer"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum StatsType : int
    {
        TYPE_INVALID = 0,
        TYPE_UINT64 = 1,
        TYPE_UINT32 = 2,
        TYPE_SINT32 = 3,
        TYPE_FLOAT = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct StatsDataValue
    {
        [FieldOffset(0x00)] public StatsType type;
        [FieldOffset(0x08)] public ulong value;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct StatsDataValueArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct StatsDataContainer
    {
        [FieldOffset(0x00)] public StatsDataValueArray data;
    }

}