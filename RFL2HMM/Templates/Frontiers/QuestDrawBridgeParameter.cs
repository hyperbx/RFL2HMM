using System.Numerics;
using System.Runtime.InteropServices;

public class QuestDrawBridgeParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct QuestDrawBridgeTimerParameter
    {
        [FieldOffset(0x00)] public float timeLimitSeconds;
        [FieldOffset(0x04)] public float cautionTime;
        [FieldOffset(0x08)] public float warningTime;
        [FieldOffset(0x0C)] public bool useCautionAnimation;
        [FieldOffset(0x0D)] public bool useWarningAnimation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct QuestDrawBridgeParameterElement
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x04)] public QuestDrawBridgeTimerParameter timerParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct QuestDrawBridgeParameter
    {
        [FieldOffset(0x00)] public QuestDrawBridgeParameterElement element__arr0;
        [FieldOffset(0x14)] public QuestDrawBridgeParameterElement element__arr1;
        [FieldOffset(0x28)] public QuestDrawBridgeParameterElement element__arr2;
    }

}