using System.Numerics;
using System.Runtime.InteropServices;

public class QuestCollectItemParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct QuestCollectitemTimerParameter
    {
        [FieldOffset(0x00)] public float timeLimitSeconds;
        [FieldOffset(0x04)] public float cautionTime;
        [FieldOffset(0x08)] public float warningTime;
        [FieldOffset(0x0C)] public bool useCautionAnimation;
        [FieldOffset(0x0D)] public bool useWarningAnimation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct QuestCameraParameter
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float azimuthSensitivity;
        [FieldOffset(0x08)] public float elevationUpSensitivity;
        [FieldOffset(0x0C)] public float elevationDownSensitivity;
        [FieldOffset(0x10)] public float elevationOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct QuestCollectItemParameterElement
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x04)] public int RequestItemNum;
        [FieldOffset(0x08)] public QuestCollectitemTimerParameter timerParam;
        [FieldOffset(0x18)] public QuestCameraParameter cameraParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x84)]
    public struct QuestCollectItemParameter
    {
        [FieldOffset(0x00)] public QuestCollectItemParameterElement element__arr0;
        [FieldOffset(0x2C)] public QuestCollectItemParameterElement element__arr1;
        [FieldOffset(0x58)] public QuestCollectItemParameterElement element__arr2;
    }

}