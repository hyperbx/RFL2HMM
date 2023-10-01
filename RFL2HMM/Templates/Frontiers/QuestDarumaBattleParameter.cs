using System.Numerics;
using System.Runtime.InteropServices;

public class QuestDarumaBattleParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct QuestDarumaTimerParameter
    {
        [FieldOffset(0x00)] public float timeLimitSeconds;
        [FieldOffset(0x04)] public float cautionTime;
        [FieldOffset(0x08)] public float warningTime;
        [FieldOffset(0x0C)] public bool useCautionAnimation;
        [FieldOffset(0x0D)] public bool useWarningAnimation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct QuestDarumaBattleParameterElement
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x04)] public float collectionColliderRadius;
        [FieldOffset(0x08)] public float collectionColliderHeight;
        [FieldOffset(0x0C)] public QuestDarumaTimerParameter timerParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x54)]
    public struct QuestDarumaBattleParameter
    {
        [FieldOffset(0x00)] public QuestDarumaBattleParameterElement element__arr0;
        [FieldOffset(0x1C)] public QuestDarumaBattleParameterElement element__arr1;
        [FieldOffset(0x38)] public QuestDarumaBattleParameterElement element__arr2;
    }

}