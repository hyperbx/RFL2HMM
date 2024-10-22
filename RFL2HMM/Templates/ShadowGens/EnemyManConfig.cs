Library "EnemyManConfig"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

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

            set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
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

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct EnemyBlockCollisionParam
    {
        [FieldOffset(0x00)] public float collisionRadius;
        [FieldOffset(0x04)] public float collisionHeight;
        [FieldOffset(0x10)] public Vector3 collisionPosOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct EnemyCollisionParam
    {
        [FieldOffset(0x00)] public EnemyBlockCollisionParam blockCollisionParam;
        [FieldOffset(0x20)] public float damageCollisionRadiusOffset;
        [FieldOffset(0x24)] public float damageCollisionHeightOffset;
        [FieldOffset(0x30)] public Vector3 damageCollisionPosOffset;
        [FieldOffset(0x40)] public float touchCollisionRadiusOffset;
        [FieldOffset(0x44)] public float touchCollisionHeightOffset;
        [FieldOffset(0x50)] public Vector3 touchCollisionPosOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct EnemyComboParam
    {
        [FieldOffset(0x00)] public float warpRadius;
        [FieldOffset(0x04)] public float warpHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1710)]
    public struct EnemyManCommonConfig
    {
        [FieldOffset(0x00)] public Movement movement;
        [FieldOffset(0x10)] public Eyesight eyesight;
        [FieldOffset(0x18)] public Fight fight;
        [FieldOffset(0x30)] public MappingPairInfo mappingPairInfo__arr0;
        [FieldOffset(0xE0)] public MappingPairInfo mappingPairInfo__arr1;
        [FieldOffset(0x190)] public MappingPairInfo mappingPairInfo__arr2;
        [FieldOffset(0x240)] public MappingPairInfo mappingPairInfo__arr3;
        [FieldOffset(0x2F0)] public MappingPairInfo mappingPairInfo__arr4;
        [FieldOffset(0x3A0)] public MappingPairInfo mappingPairInfo__arr5;
        [FieldOffset(0x450)] public MappingPairInfo mappingPairInfo__arr6;
        [FieldOffset(0x500)] public MappingPairInfo mappingPairInfo__arr7;
        [FieldOffset(0x5B0)] public MappingPairInfo mappingPairInfo__arr8;
        [FieldOffset(0x660)] public MappingPairInfo mappingPairInfo__arr9;
        [FieldOffset(0x710)] public MappingPairInfo mappingPairInfo__arr10;
        [FieldOffset(0x7C0)] public MappingPairInfo mappingPairInfo__arr11;
        [FieldOffset(0x870)] public MappingPairInfo mappingPairInfo__arr12;
        [FieldOffset(0x920)] public MappingPairInfo mappingPairInfo__arr13;
        [FieldOffset(0x9D0)] public MappingPairInfo mappingPairInfo__arr14;
        [FieldOffset(0xA80)] public MappingPairInfo mappingPairInfo__arr15;
        [FieldOffset(0xB30)] public MappingPairInfo mappingPairInfo__arr16;
        [FieldOffset(0xBE0)] public MappingPairInfo mappingPairInfo__arr17;
        [FieldOffset(0xC90)] public MappingPairInfo mappingPairInfo__arr18;
        [FieldOffset(0xD40)] public MappingPairInfo mappingPairInfo__arr19;
        [FieldOffset(0xDF0)] public MappingPairInfo mappingPairInfo__arr20;
        [FieldOffset(0xEA0)] public MappingPairInfo mappingPairInfo__arr21;
        [FieldOffset(0xF50)] public MappingPairInfo mappingPairInfo__arr22;
        [FieldOffset(0x1000)] public MappingPairInfo mappingPairInfo__arr23;
        [FieldOffset(0x10B0)] public MappingPairInfo mappingPairInfo__arr24;
        [FieldOffset(0x1160)] public MappingPairInfo mappingPairInfo__arr25;
        [FieldOffset(0x1210)] public MappingPairInfo mappingPairInfo__arr26;
        [FieldOffset(0x12C0)] public MappingPairInfo mappingPairInfo__arr27;
        [FieldOffset(0x1370)] public MappingPairInfo mappingPairInfo__arr28;
        [FieldOffset(0x1420)] public MappingPairInfo mappingPairInfo__arr29;
        [FieldOffset(0x14D0)] public MappingPairInfo mappingPairInfo__arr30;
        [FieldOffset(0x1580)] public MappingPairInfo mappingPairInfo__arr31;
        [FieldOffset(0x1630)] public EnemyCollisionParam humanCollisionParam;
        [FieldOffset(0x1690)] public EnemyComboParam humanComboParam;
        [FieldOffset(0x16A0)] public EnemyCollisionParam eggCollisionParam;
        [FieldOffset(0x1700)] public EnemyComboParam eggComboParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct ManHumanActionRate
    {
        [FieldOffset(0x00)] public float actionRate__arr0;
        [FieldOffset(0x04)] public float actionRate__arr1;
        [FieldOffset(0x08)] public float actionRate__arr2;
        [FieldOffset(0x0C)] public float actionRate__arr3;
        [FieldOffset(0x10)] public float actionRate__arr4;
        [FieldOffset(0x14)] public float actionRate__arr5;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x130)]
    public struct EnemyManSingleConfig
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
        [FieldOffset(0x38)] public float wallTime;
        [FieldOffset(0x3C)] public int wallLife;
        [FieldOffset(0x40)] public float guardTime;
        [FieldOffset(0x44)] public float guardCoolTime;
        [FieldOffset(0x48)] public ManHumanActionRate rateTable__arr0;
        [FieldOffset(0x60)] public ManHumanActionRate rateTable__arr1;
        [FieldOffset(0x78)] public ManHumanActionRate rateTable__arr2;
        [FieldOffset(0x90)] public ManHumanActionRate rateTable__arr3;
        [FieldOffset(0xA8)] public float coolTime__arr0;
        [FieldOffset(0xAC)] public float coolTime__arr1;
        [FieldOffset(0xB0)] public float coolTime__arr2;
        [FieldOffset(0xB4)] public float coolTime__arr3;
        [FieldOffset(0xB8)] public float coolTime__arr4;
        [FieldOffset(0xBC)] public float coolTime__arr5;
        [FieldOffset(0xC0)] public float attackCoolTime;
        [FieldOffset(0xC4)] public float actionDistance__arr0;
        [FieldOffset(0xC8)] public float actionDistance__arr1;
        [FieldOffset(0xCC)] public float actionDistance__arr2;
        [FieldOffset(0xD0)] public float actionDistance__arr3;
        [FieldOffset(0xD4)] public float actionDistance__arr4;
        [FieldOffset(0xD8)] public float actionDistance__arr5;
        [FieldOffset(0xDC)] public float nearRange;
        [FieldOffset(0xE0)] public int nearRateId;
        [FieldOffset(0xE4)] public int farRateId;
        [FieldOffset(0xE8)] public bool isCounterGuard;
        [FieldOffset(0xE9)] public bool isCounterWall;
        [FieldOffset(0xEA)] public bool isSpikeWall;
        [FieldOffset(0xEC)] public int waveNum;
        [FieldOffset(0xF0)] public float waveUpTime;
        [FieldOffset(0xF4)] public float waveLifeTime;
        [FieldOffset(0xF8)] public float waveDownTime;
        [FieldOffset(0xFC)] public float waveRadius;
        [FieldOffset(0x100)] public float waveAddRadius;
        [FieldOffset(0x104)] public float waveSpawnTime;
        [FieldOffset(0x108)] public float waveKeepRadius;
        [FieldOffset(0x10C)] public float waveHeight;
        [FieldOffset(0x110)] public float straightWaveUpTime;
        [FieldOffset(0x114)] public float straightWaveWaitTime;
        [FieldOffset(0x118)] public float straightWaveDownTime;
        [FieldOffset(0x11C)] public float straightWaveSpeed;
        [FieldOffset(0x120)] public float straightWaveWidth;
        [FieldOffset(0x124)] public float straightWaveHeight;
        [FieldOffset(0x128)] public int rushNum;
        [FieldOffset(0x12C)] public float downTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct EnemyManSquadConfig
    {
        [FieldOffset(0x00)] public int maxActionCount;
        [FieldOffset(0x04)] public float spAttackWaitTime;
        [FieldOffset(0x08)] public int humanMaxActionCount__arr0;
        [FieldOffset(0x0C)] public int humanMaxActionCount__arr1;
        [FieldOffset(0x10)] public int humanMaxActionCount__arr2;
        [FieldOffset(0x14)] public int humanMaxActionCount__arr3;
        [FieldOffset(0x18)] public int humanMaxActionCount__arr4;
        [FieldOffset(0x1C)] public int humanMaxActionCount__arr5;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x150)]
    public struct EnemyManTypeConfig
    {
        [FieldOffset(0x00)] public EnemyManSingleConfig single;
        [FieldOffset(0x130)] public EnemyManSquadConfig squad;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x19B0)]
    public struct EnemyManConfig
    {
        [FieldOffset(0x00)] public EnemyManCommonConfig commonParam;
        [FieldOffset(0x1710)] public EnemyManTypeConfig typeParams__arr0;
        [FieldOffset(0x1860)] public EnemyManTypeConfig typeParams__arr1;
    }

}