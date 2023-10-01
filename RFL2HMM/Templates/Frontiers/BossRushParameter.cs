using System.Numerics;
using System.Runtime.InteropServices;

public class BossRushParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct BossRushStageParameter
    {
        [FieldOffset(0x00)] public uint hour;
        [FieldOffset(0x04)] public uint minute;
        [FieldOffset(0x08)] public uint healthPoint;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct BossRushParameterElement
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x04)] public BossRushStageParameter stages__arr0;
        [FieldOffset(0x10)] public BossRushStageParameter stages__arr1;
        [FieldOffset(0x1C)] public BossRushStageParameter stages__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA4)]
    public struct BossRushParameter
    {
        [FieldOffset(0x00)] public BossRushParameterElement element__arr0;
        [FieldOffset(0x28)] public BossRushParameterElement element__arr1;
        [FieldOffset(0x50)] public BossRushParameterElement element__arr2;
        [FieldOffset(0x78)] public uint defaultRing;
        [FieldOffset(0x7C)] public float defaultCyloopGauge;
        [FieldOffset(0x80)] public float readyTime;
        [FieldOffset(0x84)] public float clearTime;
        [FieldOffset(0x88)] public float failedTime;
        [FieldOffset(0x8C)] public float clearWaitTime;
        [FieldOffset(0x90)] public float failedWaitTime;
        [FieldOffset(0x94)] public float kodamaOrdinaryTextTime;
        [FieldOffset(0x98)] public float kodamaFightDelayTime;
        [FieldOffset(0x9C)] public float kodamaFightTextTime;
        [FieldOffset(0xA0)] public float kodamaSplendidTextTime;
    }

}