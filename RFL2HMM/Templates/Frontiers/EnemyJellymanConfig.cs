using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyJellymanConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct Movement
    {
        [FieldOffset(0x00)] public float rotateSpeedMin;
        [FieldOffset(0x04)] public float rotateSpeedMax;
        [FieldOffset(0x08)] public float rotateSpeedMaxSpeedMin;
        [FieldOffset(0x0C)] public float rotateSpeedMinSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct Eyesight
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float angle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct Fight
    {
        [FieldOffset(0x00)] public float attackRange;
        [FieldOffset(0x04)] public float attackAngle;
        [FieldOffset(0x08)] public float attackSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct EnemyJellymanModeConfig
    {
        [FieldOffset(0x00)] public Movement movement;
        [FieldOffset(0x10)] public Eyesight eyesight;
        [FieldOffset(0x18)] public Fight fight;
        [FieldOffset(0x24)] public float transformRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct JellymanHumanCommonConfig
    {
        [FieldOffset(0x00)] public EnemyJellymanModeConfig common;
        [FieldOffset(0x28)] public float actionDistance__arr0;
        [FieldOffset(0x2C)] public float actionDistance__arr1;
        [FieldOffset(0x30)] public float actionDistance__arr2;
        [FieldOffset(0x34)] public float actionDistance__arr3;
        [FieldOffset(0x38)] public float actionDistance__arr4;
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

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct UnmanagedString
    {
        [FieldOffset(0)] public long pValue;

        public string Value
        {
            get
            {
                if (pValue == 0)
                    return string.Empty;

                return Marshal.PtrToStringAnsi((nint)pValue);
            }

            set => pValue = Marshal.StringToHGlobalAnsi(value);
        }

        public UnmanagedString(string in_value)
        {
            Value = in_value;
        }

        public static implicit operator UnmanagedString(string in_value)
        {
            return new UnmanagedString(in_value);
        }

        public static bool operator ==(UnmanagedString in_left, string in_right)
        {
            return in_left.Value == in_right;
        }

        public static bool operator !=(UnmanagedString in_left, string in_right)
        {
            return !(in_left == in_right);
        }

        public override bool Equals(object in_obj)
        {
            if (in_obj is string str)
                return Value == str;

            return base.Equals(in_obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }

    public enum VolumeShape : sbyte
    {
        SPHERE = 0,
        BOX = 1,
        CYLINDER = 2,
        CAPSULE = 3,
        NUM = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct VolumeInfo
    {
        [FieldOffset(0x00)] public Vector3 volumeSize;
        [FieldOffset(0x10)] public Vector3 volumeOffset;
        [FieldOffset(0x20)] public Vector3 volumeRotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xB0)]
    public struct MappingPairInfo
    {
        [FieldOffset(0x00)] public UnmanagedString tagName;
        [FieldOffset(0x10)] public sbyte pieceNum;
        [FieldOffset(0x14)] public float pieceFuncFactor;
        [FieldOffset(0x18)] public VolumeShape volumeShape;
        [FieldOffset(0x20)] public UnmanagedString humanNodeName;
        [FieldOffset(0x30)] public VolumeInfo humanVolume;
        [FieldOffset(0x60)] public UnmanagedString eggNodeName;
        [FieldOffset(0x70)] public VolumeInfo eggVolume;
        [FieldOffset(0xA0)] public bool effectActive;
        [FieldOffset(0xA1)] public bool debugDraw;
        [FieldOffset(0xA2)] public bool debugDrawVolumeAxis;
        [FieldOffset(0xA3)] public bool debugDrawAxis;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1670)]
    public struct EnemyCommonConfig
    {
        [FieldOffset(0x00)] public JellymanHumanCommonConfig human;
        [FieldOffset(0x3C)] public RingParameter ringParam;
        [FieldOffset(0x58)] public int codeDropNumMin;
        [FieldOffset(0x5C)] public int codeDropNumMax;
        [FieldOffset(0x60)] public int codeXDropNumMin;
        [FieldOffset(0x64)] public int codeXDropNumMax;
        [FieldOffset(0x70)] public MappingPairInfo mappingPairInfo__arr0;
        [FieldOffset(0x120)] public MappingPairInfo mappingPairInfo__arr1;
        [FieldOffset(0x1D0)] public MappingPairInfo mappingPairInfo__arr2;
        [FieldOffset(0x280)] public MappingPairInfo mappingPairInfo__arr3;
        [FieldOffset(0x330)] public MappingPairInfo mappingPairInfo__arr4;
        [FieldOffset(0x3E0)] public MappingPairInfo mappingPairInfo__arr5;
        [FieldOffset(0x490)] public MappingPairInfo mappingPairInfo__arr6;
        [FieldOffset(0x540)] public MappingPairInfo mappingPairInfo__arr7;
        [FieldOffset(0x5F0)] public MappingPairInfo mappingPairInfo__arr8;
        [FieldOffset(0x6A0)] public MappingPairInfo mappingPairInfo__arr9;
        [FieldOffset(0x750)] public MappingPairInfo mappingPairInfo__arr10;
        [FieldOffset(0x800)] public MappingPairInfo mappingPairInfo__arr11;
        [FieldOffset(0x8B0)] public MappingPairInfo mappingPairInfo__arr12;
        [FieldOffset(0x960)] public MappingPairInfo mappingPairInfo__arr13;
        [FieldOffset(0xA10)] public MappingPairInfo mappingPairInfo__arr14;
        [FieldOffset(0xAC0)] public MappingPairInfo mappingPairInfo__arr15;
        [FieldOffset(0xB70)] public MappingPairInfo mappingPairInfo__arr16;
        [FieldOffset(0xC20)] public MappingPairInfo mappingPairInfo__arr17;
        [FieldOffset(0xCD0)] public MappingPairInfo mappingPairInfo__arr18;
        [FieldOffset(0xD80)] public MappingPairInfo mappingPairInfo__arr19;
        [FieldOffset(0xE30)] public MappingPairInfo mappingPairInfo__arr20;
        [FieldOffset(0xEE0)] public MappingPairInfo mappingPairInfo__arr21;
        [FieldOffset(0xF90)] public MappingPairInfo mappingPairInfo__arr22;
        [FieldOffset(0x1040)] public MappingPairInfo mappingPairInfo__arr23;
        [FieldOffset(0x10F0)] public MappingPairInfo mappingPairInfo__arr24;
        [FieldOffset(0x11A0)] public MappingPairInfo mappingPairInfo__arr25;
        [FieldOffset(0x1250)] public MappingPairInfo mappingPairInfo__arr26;
        [FieldOffset(0x1300)] public MappingPairInfo mappingPairInfo__arr27;
        [FieldOffset(0x13B0)] public MappingPairInfo mappingPairInfo__arr28;
        [FieldOffset(0x1460)] public MappingPairInfo mappingPairInfo__arr29;
        [FieldOffset(0x1510)] public MappingPairInfo mappingPairInfo__arr30;
        [FieldOffset(0x15C0)] public MappingPairInfo mappingPairInfo__arr31;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct JellymanCommonLevelConfig
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
        [FieldOffset(0x2C)] public float stunTime;
        [FieldOffset(0x30)] public float attackRate;
        [FieldOffset(0x34)] public float attackMotionSpeed;
        [FieldOffset(0x38)] public ushort expItemNum;
        [FieldOffset(0x3A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct JellymanHumanLevelConfig
    {
        [FieldOffset(0x00)] public float wallTime;
        [FieldOffset(0x04)] public int wallLife;
        [FieldOffset(0x08)] public float guardTime;
        [FieldOffset(0x0C)] public float guardCoolTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct EnemyLevelConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public JellymanCommonLevelConfig common;
        [FieldOffset(0x40)] public JellymanHumanLevelConfig human;
    }

    public enum SuperArmorType : sbyte
    {
        None = 0,
        Attack = 1,
        Always = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct JellymanCommonActionConfig
    {
        [FieldOffset(0x00)] public SuperArmorType superArmor;
        [FieldOffset(0x01)] public bool isTransform;
        [FieldOffset(0x04)] public float downTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct JellymanHumanActionRate
    {
        [FieldOffset(0x00)] public float actionRate__arr0;
        [FieldOffset(0x04)] public float actionRate__arr1;
        [FieldOffset(0x08)] public float actionRate__arr2;
        [FieldOffset(0x0C)] public float actionRate__arr3;
        [FieldOffset(0x10)] public float actionRate__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct JellymanHumanActionConfig
    {
        [FieldOffset(0x00)] public JellymanHumanActionRate rateTable__arr0;
        [FieldOffset(0x14)] public JellymanHumanActionRate rateTable__arr1;
        [FieldOffset(0x28)] public JellymanHumanActionRate rateTable__arr2;
        [FieldOffset(0x3C)] public JellymanHumanActionRate rateTable__arr3;
        [FieldOffset(0x50)] public float coolTime__arr0;
        [FieldOffset(0x54)] public float coolTime__arr1;
        [FieldOffset(0x58)] public float coolTime__arr2;
        [FieldOffset(0x5C)] public float coolTime__arr3;
        [FieldOffset(0x60)] public float coolTime__arr4;
        [FieldOffset(0x64)] public float attackCoolTime;
        [FieldOffset(0x68)] public float nearRange;
        [FieldOffset(0x6C)] public int nearRateId;
        [FieldOffset(0x70)] public int farRateId;
        [FieldOffset(0x74)] public bool isCounterGuard;
        [FieldOffset(0x75)] public bool isCounterWall;
        [FieldOffset(0x76)] public bool isSpikeWall;
        [FieldOffset(0x78)] public int waveNum;
        [FieldOffset(0x7C)] public float waveUpTime;
        [FieldOffset(0x80)] public float waveLifeTime;
        [FieldOffset(0x84)] public float waveDownTime;
        [FieldOffset(0x88)] public float waveRadius;
        [FieldOffset(0x8C)] public float waveAddRadius;
        [FieldOffset(0x90)] public float waveSpawnTime;
        [FieldOffset(0x94)] public float waveKeepRadius;
        [FieldOffset(0x98)] public float waveHeight;
        [FieldOffset(0x9C)] public int rushNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xAC)]
    public struct EnemyLevelBandConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public JellymanCommonActionConfig common;
        [FieldOffset(0x0C)] public JellymanHumanActionConfig human;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct EnemySquadAvarageLevelConfig
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public int maxActionCount;
        [FieldOffset(0x08)] public float spAttackWaitTime;
        [FieldOffset(0x0C)] public int humanMaxActionCount__arr0;
        [FieldOffset(0x10)] public int humanMaxActionCount__arr1;
        [FieldOffset(0x14)] public int humanMaxActionCount__arr2;
        [FieldOffset(0x18)] public int humanMaxActionCount__arr3;
        [FieldOffset(0x1C)] public int humanMaxActionCount__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct EnemySquadConfig
    {
        [FieldOffset(0x00)] public EnemySquadAvarageLevelConfig averageLevelConfig__arr0;
        [FieldOffset(0x20)] public EnemySquadAvarageLevelConfig averageLevelConfig__arr1;
        [FieldOffset(0x40)] public EnemySquadAvarageLevelConfig averageLevelConfig__arr2;
        [FieldOffset(0x60)] public EnemySquadAvarageLevelConfig averageLevelConfig__arr3;
        [FieldOffset(0x80)] public EnemySquadAvarageLevelConfig averageLevelConfig__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1CF0)]
    public struct EnemyJellymanConfig
    {
        [FieldOffset(0x00)] public EnemyCommonConfig commonParams;
        [FieldOffset(0x1670)] public EnemyLevelConfig levelParams__arr0;
        [FieldOffset(0x16C0)] public EnemyLevelConfig levelParams__arr1;
        [FieldOffset(0x1710)] public EnemyLevelConfig levelParams__arr2;
        [FieldOffset(0x1760)] public EnemyLevelConfig levelParams__arr3;
        [FieldOffset(0x17B0)] public EnemyLevelConfig levelParams__arr4;
        [FieldOffset(0x1800)] public EnemyLevelConfig levelParams__arr5;
        [FieldOffset(0x1850)] public EnemyLevelConfig levelParams__arr6;
        [FieldOffset(0x18A0)] public EnemyLevelConfig levelParams__arr7;
        [FieldOffset(0x18F0)] public EnemyLevelBandConfig levelBands__arr0;
        [FieldOffset(0x199C)] public EnemyLevelBandConfig levelBands__arr1;
        [FieldOffset(0x1A48)] public EnemyLevelBandConfig levelBands__arr2;
        [FieldOffset(0x1AF4)] public EnemyLevelBandConfig levelBands__arr3;
        [FieldOffset(0x1BA0)] public EnemyLevelBandConfig levelBands__arr4;
        [FieldOffset(0x1C4C)] public EnemySquadConfig squadParams;
    }

}