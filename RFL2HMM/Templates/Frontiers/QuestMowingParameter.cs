using System.Numerics;
using System.Runtime.InteropServices;

public class QuestMowingParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct QuestMowingPlayerParameter
    {
        [FieldOffset(0x00)] public float playerBoostRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct QuestMowingPointParameter
    {
        [FieldOffset(0x00)] public uint collisionNum;
        [FieldOffset(0x04)] public uint pointLine;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct QuestMowingTimerParameter
    {
        [FieldOffset(0x00)] public float timeLimitSeconds;
        [FieldOffset(0x04)] public float cautionTime;
        [FieldOffset(0x08)] public float warningTime;
        [FieldOffset(0x0C)] public bool useCautionAnimation;
        [FieldOffset(0x0D)] public bool useWarningAnimation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct QuestMowingEarnedScoreParameter
    {
        [FieldOffset(0x00)] public float visibleSize;
        [FieldOffset(0x04)] public float visibleTime;
        [FieldOffset(0x10)] public Vector3 viewOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct QuestMowingResultCameraParameter
    {
        [FieldOffset(0x00)] public float resultCameraEaseTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct QuestMowingParameterElement
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x04)] public uint questClearPoint;
        [FieldOffset(0x08)] public QuestMowingPlayerParameter playerParam;
        [FieldOffset(0x0C)] public uint pointParamNum;
        [FieldOffset(0x10)] public QuestMowingPointParameter pointParam__arr0;
        [FieldOffset(0x18)] public QuestMowingPointParameter pointParam__arr1;
        [FieldOffset(0x20)] public QuestMowingPointParameter pointParam__arr2;
        [FieldOffset(0x28)] public QuestMowingPointParameter pointParam__arr3;
        [FieldOffset(0x30)] public QuestMowingPointParameter pointParam__arr4;
        [FieldOffset(0x38)] public QuestMowingTimerParameter timerParam;
        [FieldOffset(0x50)] public QuestMowingEarnedScoreParameter scoreUIParam;
        [FieldOffset(0x70)] public QuestMowingResultCameraParameter resultCameraParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x180)]
    public struct QuestMowingParameter
    {
        [FieldOffset(0x00)] public QuestMowingParameterElement element__arr0;
        [FieldOffset(0x80)] public QuestMowingParameterElement element__arr1;
        [FieldOffset(0x100)] public QuestMowingParameterElement element__arr2;
    }

}