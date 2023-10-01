using System.Numerics;
using System.Runtime.InteropServices;

public class NavMeshParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct World
    {
        [FieldOffset(0x00)] public Vector3 aabbMin;
        [FieldOffset(0x10)] public Vector3 aabbMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct Rasterization
    {
        [FieldOffset(0x00)] public float voxelSize;
        [FieldOffset(0x04)] public float voxelHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct Agent
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float height;
        [FieldOffset(0x08)] public float maxClimb;
        [FieldOffset(0x0C)] public float maxSlope;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct Region
    {
        [FieldOffset(0x00)] public int minArea;
        [FieldOffset(0x04)] public int mergeArea;
    }

    public enum Partition : byte
    {
        Watershed = 0,
        Monotone = 1,
        Layers = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct Partitioning
    {
        [FieldOffset(0x00)] public Partition type;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x03)]
    public struct Filtering
    {
        [FieldOffset(0x00)] public bool lowHangingObstacles;
        [FieldOffset(0x01)] public bool ledgeSpans;
        [FieldOffset(0x02)] public bool walkableLowHeightSpans;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct Polygonization
    {
        [FieldOffset(0x00)] public float edgeMaxLength;
        [FieldOffset(0x04)] public float maxSimplificationError;
        [FieldOffset(0x08)] public int vertsPerPoly;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct DetailMesh
    {
        [FieldOffset(0x00)] public float sampleDistance;
        [FieldOffset(0x04)] public float sampleMaxError;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct Tiling
    {
        [FieldOffset(0x00)] public float size;
        [FieldOffset(0x04)] public int maxTiles;
        [FieldOffset(0x08)] public bool cache;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct NavMeshParameter
    {
        [FieldOffset(0x00)] public World world;
        [FieldOffset(0x20)] public Rasterization rasterization;
        [FieldOffset(0x28)] public Agent agent;
        [FieldOffset(0x38)] public Region region;
        [FieldOffset(0x40)] public Partitioning partitioning;
        [FieldOffset(0x41)] public Filtering filtering;
        [FieldOffset(0x44)] public Polygonization polygonization;
        [FieldOffset(0x50)] public DetailMesh detailMesh;
        [FieldOffset(0x58)] public Tiling tiling;
    }

}