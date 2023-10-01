using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossBladeConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossCommonConfig
    {
        [FieldOffset(0x00)] public float scoutDistance;
        [FieldOffset(0x04)] public float scoutDistanceOutside;
        [FieldOffset(0x08)] public float zoomDistance;
        [FieldOffset(0x10)] public Vector3 zoomOffset;
        [FieldOffset(0x20)] public Vector3 zoomAngle;
        [FieldOffset(0x30)] public float zoomFov;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct MiniBossBladeCommonAIParam
    {
        [FieldOffset(0x00)] public float backRange;
        [FieldOffset(0x04)] public float standRange;
        [FieldOffset(0x08)] public float shortRange;
        [FieldOffset(0x0C)] public float middleRange;
        [FieldOffset(0x10)] public float runEndDistance;
        [FieldOffset(0x14)] public float dashEndDistance;
        [FieldOffset(0x18)] public float parryRange;
        [FieldOffset(0x1C)] public float specialBeginDisappearTime;
        [FieldOffset(0x20)] public float specialEndDisappearTime;
        [FieldOffset(0x24)] public float endWarpWaitTime;
        [FieldOffset(0x28)] public float shiftTimeMin;
        [FieldOffset(0x2C)] public float shiftTimeMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct MiniBossBladeCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig commonConfig;
        [FieldOffset(0x40)] public MiniBossBladeCommonAIParam ai;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct MiniBossLevelCommonConfig
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float maxStunPoint__arr0;
        [FieldOffset(0x08)] public float maxStunPoint__arr1;
        [FieldOffset(0x0C)] public float maxStunPoint__arr2;
        [FieldOffset(0x10)] public float stunDecreaseStartTime;
        [FieldOffset(0x14)] public float stunDecreaseSpeed;
        [FieldOffset(0x18)] public float maxStaggerPoint__arr0;
        [FieldOffset(0x1C)] public float maxStaggerPoint__arr1;
        [FieldOffset(0x20)] public float maxStaggerPoint__arr2;
        [FieldOffset(0x24)] public float staggerDecreaseStartTime;
        [FieldOffset(0x28)] public float staggerDecreaseSpeed;
        [FieldOffset(0x2C)] public float attackRate;
        [FieldOffset(0x30)] public ushort expItemNum;
        [FieldOffset(0x32)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct MiniBossBladeLevelCommonParam
    {
        [FieldOffset(0x00)] public float angryHpRatio;
        [FieldOffset(0x04)] public float stunTime;
        [FieldOffset(0x08)] public float downTime;
        [FieldOffset(0x0C)] public float strikeComboTimer;
        [FieldOffset(0x10)] public float cyloopComboTimer;
        [FieldOffset(0x14)] public float blowupComboTimer;
        [FieldOffset(0x18)] public float attackMotionSpeed;
        [FieldOffset(0x1C)] public float preliminaryMotionSpeed;
        [FieldOffset(0x20)] public float ghostPreliminaryMotionSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct MiniBossBladeLevelAIParam
    {
        [FieldOffset(0x00)] public float firstContactWait;
        [FieldOffset(0x04)] public float specialAttackInterval;
        [FieldOffset(0x08)] public float shortRangeIntervalMin;
        [FieldOffset(0x0C)] public float shortRangeIntervalMax;
        [FieldOffset(0x10)] public float middleRangeIntervalMin;
        [FieldOffset(0x14)] public float middleRangeIntervalMax;
        [FieldOffset(0x18)] public float counterIntervalMin;
        [FieldOffset(0x1C)] public float counterIntervalMax;
        [FieldOffset(0x20)] public float afterDashIntervalMin;
        [FieldOffset(0x24)] public float afterDashIntervalMax;
        [FieldOffset(0x28)] public float parryIntervalMin;
        [FieldOffset(0x2C)] public float parryIntervalMax;
        [FieldOffset(0x30)] public float parryDuration;
        [FieldOffset(0x34)] public float slashComboCoolTime;
        [FieldOffset(0x38)] public float ghostDashSlashCoolTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct MiniBossBladeSpecialAttackParam
    {
        [FieldOffset(0x00)] public byte spawnNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x9C)]
    public struct MiniBossBladeLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig common;
        [FieldOffset(0x38)] public MiniBossBladeLevelCommonParam general;
        [FieldOffset(0x5C)] public MiniBossBladeLevelAIParam ai;
        [FieldOffset(0x98)] public MiniBossBladeSpecialAttackParam special;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct MiniBossBladeLevelPhaseAction
    {
        [FieldOffset(0x00)] public float verticalSlashRate;
        [FieldOffset(0x04)] public float horizontalSlashRate;
        [FieldOffset(0x08)] public float slashComboRate;
        [FieldOffset(0x0C)] public float backSlashRate;
        [FieldOffset(0x10)] public float dashRate;
        [FieldOffset(0x14)] public float dashSlashRate;
        [FieldOffset(0x18)] public float ghostDashSlashRate;
        [FieldOffset(0x1C)] public float specialAttackRate;
        [FieldOffset(0x20)] public bool useTimeStopAttack;
        [FieldOffset(0x24)] public float guardBeginTime;
        [FieldOffset(0x28)] public float guardJumpLaserRate;
        [FieldOffset(0x2C)] public float parryJumpLaserRate;
        [FieldOffset(0x30)] public float cyloopJumpLaserRate;
        [FieldOffset(0x34)] public float doubleJumpLaserRate;
        [FieldOffset(0x38)] public bool useParry;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x7C)]
    public struct MiniBossBladeLevelBand
    {
        [FieldOffset(0x00)] public uint level;
        [FieldOffset(0x04)] public MiniBossBladeLevelPhaseAction phases__arr0;
        [FieldOffset(0x40)] public MiniBossBladeLevelPhaseAction phases__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct RingParameter
    {
        [FieldOffset(0x00)] public float suckedTime;
        [FieldOffset(0x04)] public float launchAngle;
        [FieldOffset(0x08)] public float launchMaxSpeed;
        [FieldOffset(0x0C)] public float launchMinSpeed;
        [FieldOffset(0x10)] public float randomRangeMin;
        [FieldOffset(0x14)] public float randomRangeMax;
        [FieldOffset(0x18)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x610)]
    public struct MiniBossBladeConfig
    {
        [FieldOffset(0x00)] public MiniBossBladeCommonParam commonParam;
        [FieldOffset(0x70)] public MiniBossBladeLevelParam levelParams__arr0;
        [FieldOffset(0x10C)] public MiniBossBladeLevelParam levelParams__arr1;
        [FieldOffset(0x1A8)] public MiniBossBladeLevelParam levelParams__arr2;
        [FieldOffset(0x244)] public MiniBossBladeLevelParam levelParams__arr3;
        [FieldOffset(0x2E0)] public MiniBossBladeLevelParam levelParams__arr4;
        [FieldOffset(0x37C)] public MiniBossBladeLevelBand levelBands__arr0;
        [FieldOffset(0x3F8)] public MiniBossBladeLevelBand levelBands__arr1;
        [FieldOffset(0x474)] public MiniBossBladeLevelBand levelBands__arr2;
        [FieldOffset(0x4F0)] public MiniBossBladeLevelBand levelBands__arr3;
        [FieldOffset(0x56C)] public MiniBossBladeLevelBand levelBands__arr4;
        [FieldOffset(0x5E8)] public RingParameter ringParam;
    }

}