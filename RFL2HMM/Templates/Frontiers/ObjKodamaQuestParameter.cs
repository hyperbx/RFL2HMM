using System.Numerics;
using System.Runtime.InteropServices;

public class ObjKodamaQuestParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct QuestKodamaCollectionBaseParameter
    {
        [FieldOffset(0x00)] public int clearKodamaNum;
        [FieldOffset(0x04)] public float modelScale;
        [FieldOffset(0x08)] public float capsuleRadius;
        [FieldOffset(0x0C)] public float capsuleHeight;
        [FieldOffset(0x10)] public Vector3 capsuleOffset;
        [FieldOffset(0x20)] public float searchRadius;
        [FieldOffset(0x24)] public float collectTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct QuestKodamaCollectionMoveParameter
    {
        [FieldOffset(0x00)] public float rotationAnglePerSec;
        [FieldOffset(0x04)] public float moveSpeed;
        [FieldOffset(0x08)] public float moveStopSpeed;
        [FieldOffset(0x0C)] public float moveStopeTime;
        [FieldOffset(0x10)] public float groupRadius;
        [FieldOffset(0x14)] public float groupMoveAdjustRangeOffset;
        [FieldOffset(0x18)] public float groupLeaderFixTime;
        [FieldOffset(0x1C)] public float returnToCenterDistance;
        [FieldOffset(0x20)] public float returnToCenterRotationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct QuestKodamaCollectionBombParameter
    {
        [FieldOffset(0x00)] public float bombSpawnTrialTime;
        [FieldOffset(0x04)] public ushort numKodamasNeededForBombSpawnRate2;
        [FieldOffset(0x06)] public ushort numKodamasNeededForBombSpawnRate3;
        [FieldOffset(0x08)] public float bombSpawnRate1;
        [FieldOffset(0x0C)] public float bombSpawnRate2;
        [FieldOffset(0x10)] public float bombSpawnRate3;
        [FieldOffset(0x14)] public byte maxAliveBombNum;
        [FieldOffset(0x18)] public float bombSpawnRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct QuestKodamaCollectionTimerParameter
    {
        [FieldOffset(0x00)] public bool isTimeUp;
        [FieldOffset(0x04)] public float timeLimitSeconds;
        [FieldOffset(0x08)] public float cautionTime;
        [FieldOffset(0x0C)] public float warningTime;
        [FieldOffset(0x10)] public bool useCautionAnimation;
        [FieldOffset(0x11)] public bool useWarningAnimation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct ObjKodamaQuestGrassIslandParameter
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x10)] public QuestKodamaCollectionBaseParameter baseParam;
        [FieldOffset(0x40)] public QuestKodamaCollectionMoveParameter moveParam;
        [FieldOffset(0x64)] public QuestKodamaCollectionBombParameter bombParam;
        [FieldOffset(0x80)] public QuestKodamaCollectionTimerParameter timerParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct QuestKodamaCollectionSandBombParameter
    {
        [FieldOffset(0)]  public QuestKodamaCollectionBombParameter questKodamaCollectionBombParameter;
        [FieldOffset(0x1C)] public float sandStormTime;
        [FieldOffset(0x20)] public float noBombsTime;
        [FieldOffset(0x24)] public float sandStormInLerpTime;
        [FieldOffset(0x28)] public float sandStormOutLerpTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xB0)]
    public struct ObjKodamaQuestDesertIslandParameter
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x10)] public QuestKodamaCollectionBaseParameter baseParam;
        [FieldOffset(0x40)] public QuestKodamaCollectionMoveParameter moveParam;
        [FieldOffset(0x64)] public QuestKodamaCollectionSandBombParameter bombParam;
        [FieldOffset(0x90)] public QuestKodamaCollectionTimerParameter timerParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3F0)]
    public struct ObjKodamaQuestParameter
    {
        [FieldOffset(0x00)] public ObjKodamaQuestGrassIslandParameter grassIslandParam__arr0;
        [FieldOffset(0xA0)] public ObjKodamaQuestGrassIslandParameter grassIslandParam__arr1;
        [FieldOffset(0x140)] public ObjKodamaQuestGrassIslandParameter grassIslandParam__arr2;
        [FieldOffset(0x1E0)] public ObjKodamaQuestDesertIslandParameter desertIslandParam__arr0;
        [FieldOffset(0x290)] public ObjKodamaQuestDesertIslandParameter desertIslandParam__arr1;
        [FieldOffset(0x340)] public ObjKodamaQuestDesertIslandParameter desertIslandParam__arr2;
    }

}