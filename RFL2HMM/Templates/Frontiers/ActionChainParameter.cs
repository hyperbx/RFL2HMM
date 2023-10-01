using System.Numerics;
using System.Runtime.InteropServices;

public class ActionChainParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct ActionChainScoreParameter
    {
        [FieldOffset(0x00)] public uint score;
        [FieldOffset(0x04)] public uint level1Meter;
        [FieldOffset(0x08)] public uint level2Meter;
        [FieldOffset(0x0C)] public uint level3Meter;
        [FieldOffset(0x10)] public uint level4Meter;
        [FieldOffset(0x14)] public uint level5Meter;
        [FieldOffset(0x18)] public uint level6Meter;
        [FieldOffset(0x1C)] public uint level7Meter;
        [FieldOffset(0x20)] public uint level8Meter;
        [FieldOffset(0x24)] public uint level9Meter;
        [FieldOffset(0x28)] public float delay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct ActionChainAttackLevelParameter
    {
        [FieldOffset(0x00)] public uint level1Param;
        [FieldOffset(0x04)] public uint level99Param;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct ActionChainAttackScoreParameter
    {
        [FieldOffset(0x00)] public ActionChainAttackLevelParameter score;
        [FieldOffset(0x08)] public ActionChainAttackLevelParameter level1Meter;
        [FieldOffset(0x10)] public ActionChainAttackLevelParameter level2Meter;
        [FieldOffset(0x18)] public ActionChainAttackLevelParameter level3Meter;
        [FieldOffset(0x20)] public ActionChainAttackLevelParameter level4Meter;
        [FieldOffset(0x28)] public ActionChainAttackLevelParameter level5Meter;
        [FieldOffset(0x30)] public ActionChainAttackLevelParameter level6Meter;
        [FieldOffset(0x38)] public ActionChainAttackLevelParameter level7Meter;
        [FieldOffset(0x40)] public ActionChainAttackLevelParameter level8Meter;
        [FieldOffset(0x48)] public ActionChainAttackLevelParameter level9Meter;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct ActionChainIntervalScoreParameter
    {
        [FieldOffset(0x00)] public float intervalTime;
        [FieldOffset(0x04)] public uint score;
        [FieldOffset(0x08)] public uint level1Meter;
        [FieldOffset(0x0C)] public uint level2Meter;
        [FieldOffset(0x10)] public uint level3Meter;
        [FieldOffset(0x14)] public uint level4Meter;
        [FieldOffset(0x18)] public uint level5Meter;
        [FieldOffset(0x1C)] public uint level6Meter;
        [FieldOffset(0x20)] public uint level7Meter;
        [FieldOffset(0x24)] public uint level8Meter;
        [FieldOffset(0x28)] public uint level9Meter;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x5C)]
    public struct ActionChainBoostScoreParameter
    {
        [FieldOffset(0x00)] public float intervalTime;
        [FieldOffset(0x04)] public float minSpeed;
        [FieldOffset(0x08)] public float maxSpeed;
        [FieldOffset(0x0C)] public ActionChainAttackLevelParameter score;
        [FieldOffset(0x14)] public ActionChainAttackLevelParameter level1Meter;
        [FieldOffset(0x1C)] public ActionChainAttackLevelParameter level2Meter;
        [FieldOffset(0x24)] public ActionChainAttackLevelParameter level3Meter;
        [FieldOffset(0x2C)] public ActionChainAttackLevelParameter level4Meter;
        [FieldOffset(0x34)] public ActionChainAttackLevelParameter level5Meter;
        [FieldOffset(0x3C)] public ActionChainAttackLevelParameter level6Meter;
        [FieldOffset(0x44)] public ActionChainAttackLevelParameter level7Meter;
        [FieldOffset(0x4C)] public ActionChainAttackLevelParameter level8Meter;
        [FieldOffset(0x54)] public ActionChainAttackLevelParameter level9Meter;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct ActionChainSpinBoostScoreParameter
    {
        [FieldOffset(0x00)] public float intervalTime;
        [FieldOffset(0x04)] public float minSpeed;
        [FieldOffset(0x08)] public float maxSpeed;
        [FieldOffset(0x0C)] public ActionChainAttackLevelParameter score;
        [FieldOffset(0x14)] public ActionChainAttackLevelParameter level1Meter;
        [FieldOffset(0x1C)] public ActionChainAttackLevelParameter level2Meter;
        [FieldOffset(0x24)] public ActionChainAttackLevelParameter level3Meter;
        [FieldOffset(0x2C)] public ActionChainAttackLevelParameter level4Meter;
        [FieldOffset(0x34)] public ActionChainAttackLevelParameter level5Meter;
        [FieldOffset(0x3C)] public ActionChainAttackLevelParameter level6Meter;
        [FieldOffset(0x44)] public ActionChainAttackLevelParameter level7Meter;
        [FieldOffset(0x4C)] public ActionChainAttackLevelParameter level8Meter;
        [FieldOffset(0x54)] public ActionChainAttackLevelParameter level9Meter;
        [FieldOffset(0x5C)] public float minHeight;
        [FieldOffset(0x60)] public float maxHeight;
        [FieldOffset(0x64)] public float maxHeightMagnification;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC08)]
    public struct ActionChainActionParameter
    {
        [FieldOffset(0x00)] public ActionChainScoreParameter dashRollerScore;
        [FieldOffset(0x2C)] public ActionChainScoreParameter dashPanelScore;
        [FieldOffset(0x58)] public ActionChainScoreParameter jumpBoardScore;
        [FieldOffset(0x84)] public ActionChainScoreParameter jumpSelecterScore;
        [FieldOffset(0xB0)] public ActionChainScoreParameter poleScore;
        [FieldOffset(0xDC)] public ActionChainScoreParameter selectCannonScore;
        [FieldOffset(0x108)] public ActionChainScoreParameter springScore;
        [FieldOffset(0x134)] public ActionChainScoreParameter wideSpringScore;
        [FieldOffset(0x160)] public ActionChainScoreParameter springClassicScore;
        [FieldOffset(0x18C)] public ActionChainScoreParameter balloonScore;
        [FieldOffset(0x1B8)] public ActionChainScoreParameter upReelScore;
        [FieldOffset(0x1E4)] public ActionChainScoreParameter wallJumpScore;
        [FieldOffset(0x210)] public ActionChainScoreParameter propellerSpringScore;
        [FieldOffset(0x23C)] public ActionChainScoreParameter springPoleScore;
        [FieldOffset(0x268)] public ActionChainScoreParameter dashRingScore;
        [FieldOffset(0x294)] public ActionChainAttackScoreParameter acceleCombo1Score;
        [FieldOffset(0x2E4)] public ActionChainAttackScoreParameter acceleCombo2Score;
        [FieldOffset(0x334)] public ActionChainAttackScoreParameter comboFinishScore;
        [FieldOffset(0x384)] public ActionChainAttackScoreParameter acceleRushCombo1Score;
        [FieldOffset(0x3D4)] public ActionChainAttackScoreParameter acceleRushCombo2Score;
        [FieldOffset(0x424)] public ActionChainAttackScoreParameter acceleRushComboFinishScore;
        [FieldOffset(0x474)] public ActionChainAttackScoreParameter chargeAttackScore;
        [FieldOffset(0x4C4)] public ActionChainAttackScoreParameter smashScore;
        [FieldOffset(0x514)] public ActionChainAttackScoreParameter recoverySmashScore;
        [FieldOffset(0x564)] public ActionChainAttackScoreParameter sonicBoomScore;
        [FieldOffset(0x5B4)] public ActionChainAttackScoreParameter crasherScore;
        [FieldOffset(0x604)] public ActionChainAttackScoreParameter loopKickScore;
        [FieldOffset(0x654)] public ActionChainAttackScoreParameter spinSlashScore;
        [FieldOffset(0x6A4)] public ActionChainAttackScoreParameter stompingAttackScore;
        [FieldOffset(0x6F4)] public ActionChainAttackScoreParameter homingShotScore;
        [FieldOffset(0x744)] public ActionChainAttackScoreParameter crossSlashScore;
        [FieldOffset(0x794)] public ActionChainScoreParameter ringScore;
        [FieldOffset(0x7C0)] public ActionChainScoreParameter gismoScore;
        [FieldOffset(0x7EC)] public ActionChainScoreParameter homingScore;
        [FieldOffset(0x818)] public ActionChainAttackScoreParameter enemyHomingScore;
        [FieldOffset(0x868)] public ActionChainScoreParameter airTrickScore;
        [FieldOffset(0x894)] public ActionChainScoreParameter chainBoosterScore;
        [FieldOffset(0x8C0)] public ActionChainScoreParameter parryScore;
        [FieldOffset(0x8EC)] public ActionChainAttackScoreParameter quickCyloopScore;
        [FieldOffset(0x93C)] public ActionChainScoreParameter defeatEnemyScore;
        [FieldOffset(0x968)] public ActionChainScoreParameter defeatMiniBossScore;
        [FieldOffset(0x994)] public ActionChainAttackScoreParameter slingShotScore;
        [FieldOffset(0x9E4)] public ActionChainScoreParameter rippleLaserScore;
        [FieldOffset(0xA10)] public ActionChainIntervalScoreParameter grindRailScore;
        [FieldOffset(0xA3C)] public ActionChainIntervalScoreParameter pulleyScore;
        [FieldOffset(0xA68)] public ActionChainIntervalScoreParameter fanScore;
        [FieldOffset(0xA94)] public ActionChainIntervalScoreParameter wallRunScore;
        [FieldOffset(0xAC0)] public ActionChainBoostScoreParameter boostScore;
        [FieldOffset(0xB1C)] public ActionChainIntervalScoreParameter powerBoostScore;
        [FieldOffset(0xB48)] public ActionChainIntervalScoreParameter sandSkiScore;
        [FieldOffset(0xB74)] public ActionChainIntervalScoreParameter acceleRailScore;
        [FieldOffset(0xBA0)] public ActionChainSpinBoostScoreParameter spinBoostScore;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct ActionChainMeterParameter
    {
        [FieldOffset(0x00)] public uint meterMax;
        [FieldOffset(0x04)] public float meterDecreaseTime;
        [FieldOffset(0x08)] public uint meterDecrease;
        [FieldOffset(0x0C)] public float decreaseWaitTime;
        [FieldOffset(0x10)] public float decreasePercent;
        [FieldOffset(0x14)] public float decreaseWaitTimeAddMeter;
        [FieldOffset(0x18)] public float meterResetDelayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xD0C)]
    public struct ActionChainParameter
    {
        [FieldOffset(0x00)] public ActionChainActionParameter actionParam;
        [FieldOffset(0xC08)] public ActionChainMeterParameter level1MeterParam;
        [FieldOffset(0xC24)] public ActionChainMeterParameter level2MeterParam;
        [FieldOffset(0xC40)] public ActionChainMeterParameter level3MeterParam;
        [FieldOffset(0xC5C)] public ActionChainMeterParameter level4MeterParam;
        [FieldOffset(0xC78)] public ActionChainMeterParameter level5MeterParam;
        [FieldOffset(0xC94)] public ActionChainMeterParameter level6MeterParam;
        [FieldOffset(0xCB0)] public ActionChainMeterParameter level7MeterParam;
        [FieldOffset(0xCCC)] public ActionChainMeterParameter level8MeterParam;
        [FieldOffset(0xCE8)] public ActionChainMeterParameter level9MeterParam;
        [FieldOffset(0xD04)] public float gimmickReuseTime;
        [FieldOffset(0xD08)] public bool isChainBoosterLevelUp;
    }

}