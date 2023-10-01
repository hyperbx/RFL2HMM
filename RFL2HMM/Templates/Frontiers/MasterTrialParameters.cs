using System.Numerics;
using System.Runtime.InteropServices;

public class MasterTrialParametersClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct MasterTrialStageParameter
    {
        [FieldOffset(0x00)] public byte prerequisite;
        [FieldOffset(0x04)] public float limitTime;
        [FieldOffset(0x08)] public float defeatedWaitTime;
        [FieldOffset(0x0C)] public float speedUpScale;
        [FieldOffset(0x10)] public float attackRate;
        [FieldOffset(0x14)] public float recoveryHpTime;
        [FieldOffset(0x18)] public uint recoveryHpPoint;
        [FieldOffset(0x1C)] public uint limitMistake;
        [FieldOffset(0x20)] public int damagePoint;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x94)]
    public struct MasterTrialParameterElement
    {
        [FieldOffset(0x00)] public int applicableFailedCount;
        [FieldOffset(0x04)] public MasterTrialStageParameter stages__arr0;
        [FieldOffset(0x28)] public MasterTrialStageParameter stages__arr1;
        [FieldOffset(0x4C)] public MasterTrialStageParameter stages__arr2;
        [FieldOffset(0x70)] public MasterTrialStageParameter stages__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1E4)]
    public struct MasterTrialParameters
    {
        [FieldOffset(0x00)] public float subjectViewTime;
        [FieldOffset(0x04)] public float readyTime;
        [FieldOffset(0x08)] public float clearTime;
        [FieldOffset(0x0C)] public float failedTime;
        [FieldOffset(0x10)] public float clearWaitTime;
        [FieldOffset(0x14)] public float failedWaitTime;
        [FieldOffset(0x18)] public float kodamaOrdinaryTextTime;
        [FieldOffset(0x1C)] public float kodamaFightDelayTime;
        [FieldOffset(0x20)] public float kodamaFightTextTime;
        [FieldOffset(0x24)] public float kodamaSplendidTextTime;
        [FieldOffset(0x28)] public MasterTrialParameterElement element__arr0;
        [FieldOffset(0xBC)] public MasterTrialParameterElement element__arr1;
        [FieldOffset(0x150)] public MasterTrialParameterElement element__arr2;
    }

}