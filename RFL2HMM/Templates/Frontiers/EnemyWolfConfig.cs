using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyWolfConfigClass
{
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

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct WolfMovementParam
    {
        [FieldOffset(0x00)] public float rotateSpeedMin;
        [FieldOffset(0x04)] public float rotateSpeedMax;
        [FieldOffset(0x08)] public float rotateSpeedMaxSpeedMin;
        [FieldOffset(0x0C)] public float rotateSpeedMinSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct WolfEyesightParam
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float angle;
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

    public enum WolfVolumeShape : sbyte
    {
        SPHERE = 0,
        BOX = 1,
        CYLINDER = 2,
        CAPSULE = 3,
        NUM = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct WolfVolumeInfo
    {
        [FieldOffset(0x00)] public Vector3 volumeSize;
        [FieldOffset(0x10)] public Vector3 volumeOffset;
        [FieldOffset(0x20)] public Vector3 volumeRotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct WolfMappingPairInfo
    {
        [FieldOffset(0x00)] public UnmanagedString tagName;
        [FieldOffset(0x10)] public sbyte pieceNum;
        [FieldOffset(0x14)] public float pieceFuncFactor;
        [FieldOffset(0x18)] public WolfVolumeShape volumeShape;
        [FieldOffset(0x20)] public UnmanagedString wolfNodeName;
        [FieldOffset(0x30)] public WolfVolumeInfo wolfVolume;
        [FieldOffset(0x60)] public bool effectActive;
        [FieldOffset(0x61)] public bool debugDraw;
        [FieldOffset(0x62)] public bool debugDrawVolumeAxis;
        [FieldOffset(0x63)] public bool debugDrawAxis;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE60)]
    public struct EnemyWolfCommonParam
    {
        [FieldOffset(0x00)] public RingParameter ringParam;
        [FieldOffset(0x1C)] public WolfMovementParam movement;
        [FieldOffset(0x2C)] public WolfEyesightParam eyesight;
        [FieldOffset(0x34)] public float killWaitTime;
        [FieldOffset(0x38)] public float blockColliderRadius;
        [FieldOffset(0x3C)] public float blockColliderHeight;
        [FieldOffset(0x40)] public float damageColliderRadius;
        [FieldOffset(0x44)] public float damageColliderHeight;
        [FieldOffset(0x48)] public float eyesightDistance;
        [FieldOffset(0x50)] public Vector3 cursorOffset;
        [FieldOffset(0x60)] public WolfMappingPairInfo mappingPairInfo__arr0;
        [FieldOffset(0xD0)] public WolfMappingPairInfo mappingPairInfo__arr1;
        [FieldOffset(0x140)] public WolfMappingPairInfo mappingPairInfo__arr2;
        [FieldOffset(0x1B0)] public WolfMappingPairInfo mappingPairInfo__arr3;
        [FieldOffset(0x220)] public WolfMappingPairInfo mappingPairInfo__arr4;
        [FieldOffset(0x290)] public WolfMappingPairInfo mappingPairInfo__arr5;
        [FieldOffset(0x300)] public WolfMappingPairInfo mappingPairInfo__arr6;
        [FieldOffset(0x370)] public WolfMappingPairInfo mappingPairInfo__arr7;
        [FieldOffset(0x3E0)] public WolfMappingPairInfo mappingPairInfo__arr8;
        [FieldOffset(0x450)] public WolfMappingPairInfo mappingPairInfo__arr9;
        [FieldOffset(0x4C0)] public WolfMappingPairInfo mappingPairInfo__arr10;
        [FieldOffset(0x530)] public WolfMappingPairInfo mappingPairInfo__arr11;
        [FieldOffset(0x5A0)] public WolfMappingPairInfo mappingPairInfo__arr12;
        [FieldOffset(0x610)] public WolfMappingPairInfo mappingPairInfo__arr13;
        [FieldOffset(0x680)] public WolfMappingPairInfo mappingPairInfo__arr14;
        [FieldOffset(0x6F0)] public WolfMappingPairInfo mappingPairInfo__arr15;
        [FieldOffset(0x760)] public WolfMappingPairInfo mappingPairInfo__arr16;
        [FieldOffset(0x7D0)] public WolfMappingPairInfo mappingPairInfo__arr17;
        [FieldOffset(0x840)] public WolfMappingPairInfo mappingPairInfo__arr18;
        [FieldOffset(0x8B0)] public WolfMappingPairInfo mappingPairInfo__arr19;
        [FieldOffset(0x920)] public WolfMappingPairInfo mappingPairInfo__arr20;
        [FieldOffset(0x990)] public WolfMappingPairInfo mappingPairInfo__arr21;
        [FieldOffset(0xA00)] public WolfMappingPairInfo mappingPairInfo__arr22;
        [FieldOffset(0xA70)] public WolfMappingPairInfo mappingPairInfo__arr23;
        [FieldOffset(0xAE0)] public WolfMappingPairInfo mappingPairInfo__arr24;
        [FieldOffset(0xB50)] public WolfMappingPairInfo mappingPairInfo__arr25;
        [FieldOffset(0xBC0)] public WolfMappingPairInfo mappingPairInfo__arr26;
        [FieldOffset(0xC30)] public WolfMappingPairInfo mappingPairInfo__arr27;
        [FieldOffset(0xCA0)] public WolfMappingPairInfo mappingPairInfo__arr28;
        [FieldOffset(0xD10)] public WolfMappingPairInfo mappingPairInfo__arr29;
        [FieldOffset(0xD80)] public WolfMappingPairInfo mappingPairInfo__arr30;
        [FieldOffset(0xDF0)] public WolfMappingPairInfo mappingPairInfo__arr31;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct EnemyWolfCommonLevelParam
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float attackRate;
        [FieldOffset(0x08)] public ushort expItemNum;
        [FieldOffset(0x0A)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct EnemyWolfLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public EnemyWolfCommonLevelParam common;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct EnemyWolfLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xED0)]
    public struct EnemyWolfConfig
    {
        [FieldOffset(0x00)] public EnemyWolfCommonParam commonParam;
        [FieldOffset(0xE60)] public EnemyWolfLevelParam levelParams__arr0;
        [FieldOffset(0xE70)] public EnemyWolfLevelParam levelParams__arr1;
        [FieldOffset(0xE80)] public EnemyWolfLevelParam levelParams__arr2;
        [FieldOffset(0xE90)] public EnemyWolfLevelParam levelParams__arr3;
        [FieldOffset(0xEA0)] public EnemyWolfLevelParam levelParams__arr4;
        [FieldOffset(0xEB0)] public EnemyWolfLevelBand levelBand__arr0;
        [FieldOffset(0xEB4)] public EnemyWolfLevelBand levelBand__arr1;
        [FieldOffset(0xEB8)] public EnemyWolfLevelBand levelBand__arr2;
        [FieldOffset(0xEBC)] public EnemyWolfLevelBand levelBand__arr3;
        [FieldOffset(0xEC0)] public EnemyWolfLevelBand levelBand__arr4;
    }

}