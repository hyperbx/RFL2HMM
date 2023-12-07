using System.Numerics;
using System.Runtime.InteropServices;

public class BossRushParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossRushStageParameter
    {
        [FieldOffset(0x00)] public uint hour;
        [FieldOffset(0x04)] public uint minute;
        [FieldOffset(0x08)] public uint healthPoint;
        [FieldOffset(0x0C)] public uint recoveryRing;
        [FieldOffset(0x10)] public byte powerLevel;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BossRushParameterElement
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x04)] public BossRushStageParameter stages__arr0;
        [FieldOffset(0x18)] public BossRushStageParameter stages__arr1;
        [FieldOffset(0x2C)] public BossRushStageParameter stages__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1B0)]
    public struct BossRushParameter
    {
        [FieldOffset(0x00)] public BossRushParameterElement element__arr0;
        [FieldOffset(0x40)] public BossRushParameterElement element__arr1;
        [FieldOffset(0x80)] public BossRushParameterElement element__arr2;
        [FieldOffset(0xC0)] public BossRushParameterElement elementEasy__arr0;
        [FieldOffset(0x100)] public BossRushParameterElement elementEasy__arr1;
        [FieldOffset(0x140)] public BossRushParameterElement elementEasy__arr2;
        [FieldOffset(0x180)] public uint defaultRing;
        [FieldOffset(0x184)] public uint defaultRingEasy;
        [FieldOffset(0x188)] public float defaultCyloopGauge;
        [FieldOffset(0x18C)] public float readyTime;
        [FieldOffset(0x190)] public float clearTime;
        [FieldOffset(0x194)] public float failedTime;
        [FieldOffset(0x198)] public float clearWaitTime;
        [FieldOffset(0x19C)] public float failedWaitTime;
        [FieldOffset(0x1A0)] public float kodamaOrdinaryTextTime;
        [FieldOffset(0x1A4)] public float kodamaFightDelayTime;
        [FieldOffset(0x1A8)] public float kodamaFightTextTime;
        [FieldOffset(0x1AC)] public float kodamaSplendidTextTime;
    }

}