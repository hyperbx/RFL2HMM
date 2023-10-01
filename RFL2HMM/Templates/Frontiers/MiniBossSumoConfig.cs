using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossSumoConfigClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossSumoBaseConfig
    {
        [FieldOffset(0x00)] public float mass;
        [FieldOffset(0x04)] public float slopeAngleMax;
        [FieldOffset(0x08)] public float timeStun;
        [FieldOffset(0x0C)] public float timeExpend;
        [FieldOffset(0x10)] public float timeGuardBreak;
        [FieldOffset(0x14)] public float visualOffset;
        [FieldOffset(0x20)] public Vector3 hpGaugeOffset;
        [FieldOffset(0x30)] public float guardEffectCoolTime;
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

    public enum ColliderProperty : uint
    {
        None = 0,
        Damaged = 1,
        DamageToPlayer = 2,
        Block = 4,
        DetectPuck = 8,
        Cyloop = 16,
        BlockBody = 32,
        SensorArm = 64,
        PressBlow = 128,
        PressBlowBody = 256,
        PressBlowArm = 512
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct MiniBossSumoColliderParam
    {
        [FieldOffset(0x00)] public bool enabled;
        [FieldOffset(0x04)] public float height;
        [FieldOffset(0x08)] public float radius;
        [FieldOffset(0x10)] public UnmanagedString attachNodeName;
        [FieldOffset(0x20)] public Vector3 offset;
        [FieldOffset(0x30)] public Vector3 rotation;
        [FieldOffset(0x40)] public UnmanagedString tag;
        [FieldOffset(0x50)] public ColliderProperty properties__arr0;
        [FieldOffset(0x54)] public ColliderProperty properties__arr1;
        [FieldOffset(0x58)] public bool debugDraw;
        [FieldOffset(0x5C)] public Color8 color;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x630)]
    public struct MiniBossSumoColliderConfig
    {
        [FieldOffset(0x00)] public MiniBossSumoColliderParam damaged__arr0;
        [FieldOffset(0x60)] public MiniBossSumoColliderParam damaged__arr1;
        [FieldOffset(0xC0)] public MiniBossSumoColliderParam damaged__arr2;
        [FieldOffset(0x120)] public MiniBossSumoColliderParam damaged__arr3;
        [FieldOffset(0x180)] public MiniBossSumoColliderParam damaged__arr4;
        [FieldOffset(0x1E0)] public MiniBossSumoColliderParam damaged__arr5;
        [FieldOffset(0x240)] public MiniBossSumoColliderParam damage__arr0;
        [FieldOffset(0x2A0)] public MiniBossSumoColliderParam damage__arr1;
        [FieldOffset(0x300)] public MiniBossSumoColliderParam detectPuck;
        [FieldOffset(0x360)] public MiniBossSumoColliderParam cyloop;
        [FieldOffset(0x3C0)] public MiniBossSumoColliderParam pressBlow__arr0;
        [FieldOffset(0x420)] public MiniBossSumoColliderParam pressBlow__arr1;
        [FieldOffset(0x480)] public MiniBossSumoColliderParam pressBlow__arr2;
        [FieldOffset(0x4E0)] public MiniBossSumoColliderParam sensorArm__arr0;
        [FieldOffset(0x540)] public MiniBossSumoColliderParam sensorArm__arr1;
        [FieldOffset(0x5A0)] public MiniBossSumoColliderParam simpleBody;
        [FieldOffset(0x600)] public float moveRadius;
        [FieldOffset(0x604)] public float moveHeight;
        [FieldOffset(0x610)] public Vector3 targetMarkerOffset;
        [FieldOffset(0x620)] public float comboRadiusMin;
        [FieldOffset(0x624)] public float comboRadiusMax;
        [FieldOffset(0x628)] public float comboHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossSumoRopeConfig
    {
        [FieldOffset(0x00)] public float coolDownTimeToChangeElectric;
        [FieldOffset(0x04)] public float timeToWaitChangeAfterDamage;
        [FieldOffset(0x08)] public float blowOffSpeedDamagedElectricRope;
        [FieldOffset(0x0C)] public float decelerationDamagedElectricRope;
        [FieldOffset(0x10)] public float timeElectricReaction;
        [FieldOffset(0x14)] public int damageByReflectCount__arr0;
        [FieldOffset(0x18)] public int damageByReflectCount__arr1;
        [FieldOffset(0x1C)] public int damageByReflectCount__arr2;
        [FieldOffset(0x20)] public int damageByReflectCount__arr3;
        [FieldOffset(0x24)] public int damageByReflectCount__arr4;
        [FieldOffset(0x28)] public float bendLengthOnHit;
        [FieldOffset(0x2C)] public int expansionBoundCount;
        [FieldOffset(0x30)] public float blowOffSpeedExpansionBoundRope;
        [FieldOffset(0x34)] public float decelerationExpansionBoundRope;
        [FieldOffset(0x38)] public float lockonPanningSuspensionKExpansionBoundRope;
        [FieldOffset(0x3C)] public float reflectAngleMaxExpansionBoundRope;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct MiniBossSumoSlingShotConfig
    {
        [FieldOffset(0x00)] public float backInitialSpeeds__arr0;
        [FieldOffset(0x04)] public float backInitialSpeeds__arr1;
        [FieldOffset(0x08)] public float backInitialSpeeds__arr2;
        [FieldOffset(0x0C)] public float backInitialSpeeds__arr3;
        [FieldOffset(0x10)] public float backInitialSpeeds__arr4;
        [FieldOffset(0x14)] public float backDeccelation;
        [FieldOffset(0x18)] public float frontAngle;
        [FieldOffset(0x1C)] public float timeTurn;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct MiniBossSumoMoveConfig
    {
        [FieldOffset(0x00)] public float moveHorzLimitAngle;
        [FieldOffset(0x04)] public float moveRotateDeceleration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct MiniBossSumoThrowPuckParam
    {
        [FieldOffset(0x00)] public float distanceThrow;
        [FieldOffset(0x04)] public float coolTime;
        [FieldOffset(0x10)] public Vector3 attachOffset;
        [FieldOffset(0x20)] public Vector3 attachRotateL;
        [FieldOffset(0x30)] public Vector3 attachRotateR;
        [FieldOffset(0x40)] public float throwAngleLimit;
        [FieldOffset(0x50)] public Vector3 throwOffsetMulti;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct MiniBossSumoSlingshotComboParam
    {
        [FieldOffset(0x00)] public int count;
        [FieldOffset(0x04)] public bool reflectBack;
        [FieldOffset(0x08)] public float reflectRagWidth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct MiniBossSumoIKFootParam
    {
        [FieldOffset(0x00)] public Vector3 kneeAxisLS;
        [FieldOffset(0x10)] public Vector3 footEndLS;
        [FieldOffset(0x20)] public float footPlantedAnkleHeightMS;
        [FieldOffset(0x24)] public float footRaisedAnkleHeightMS;
        [FieldOffset(0x28)] public float maxAnkleHeightMS;
        [FieldOffset(0x2C)] public float minAnkleHeightMS;
        [FieldOffset(0x30)] public float maxKneeAngleDegrees;
        [FieldOffset(0x34)] public float minKneeAngleDegrees;
        [FieldOffset(0x38)] public float onOffGain;
        [FieldOffset(0x3C)] public float groundAscendingGain;
        [FieldOffset(0x40)] public float groundDescendingGain;
        [FieldOffset(0x44)] public float footPlantedGain;
        [FieldOffset(0x48)] public float footRaisedGain;
        [FieldOffset(0x4C)] public float footLockingGain;
        [FieldOffset(0x50)] public float ankleRotationGain;
        [FieldOffset(0x58)] public UnmanagedString hipName;
        [FieldOffset(0x68)] public UnmanagedString kneeName;
        [FieldOffset(0x78)] public UnmanagedString ankleName;
        [FieldOffset(0x88)] public UnmanagedString toeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct MiniBossSumoIKHandParam
    {
        [FieldOffset(0x00)] public Vector3 elbowAxisLS;
        [FieldOffset(0x10)] public Vector3 handOffsetLS;
        [FieldOffset(0x20)] public Vector3 backHandNormalLS;
        [FieldOffset(0x30)] public float maxElbowAngleDegrees;
        [FieldOffset(0x34)] public float minElbowAngleDegrees;
        [FieldOffset(0x38)] public bool enforceWristRotation;
        [FieldOffset(0x40)] public UnmanagedString shoulderName;
        [FieldOffset(0x50)] public UnmanagedString elbowName;
        [FieldOffset(0x60)] public UnmanagedString wristName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x250)]
    public struct MiniBossSumoIKParam
    {
        [FieldOffset(0x00)] public float footRaycastDistanceUp;
        [FieldOffset(0x04)] public float footRaycastDistanceDown;
        [FieldOffset(0x10)] public MiniBossSumoIKFootParam feet__arr0;
        [FieldOffset(0xB0)] public MiniBossSumoIKFootParam feet__arr1;
        [FieldOffset(0x150)] public float handRaycastDistanceUp;
        [FieldOffset(0x154)] public float handRaycastDistanceDown;
        [FieldOffset(0x158)] public float handSweepRadius;
        [FieldOffset(0x15C)] public float handGain;
        [FieldOffset(0x160)] public float easeInTimeHandIk;
        [FieldOffset(0x164)] public float easeOutTimeHandIk;
        [FieldOffset(0x170)] public MiniBossSumoIKHandParam hands__arr0;
        [FieldOffset(0x1E0)] public MiniBossSumoIKHandParam hands__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossSumoCyloopConfig
    {
        [FieldOffset(0x00)] public float puckSpeed;
        [FieldOffset(0x04)] public float puckTimeStartDecelerate;
        [FieldOffset(0x08)] public float puckDeceleration;
        [FieldOffset(0x0C)] public float puckLifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossSumoLockonConfig
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float minElevation;
        [FieldOffset(0x08)] public float maxElevation;
        [FieldOffset(0x0C)] public float elevationOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA00)]
    public struct MiniBossSumoCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig common;
        [FieldOffset(0x40)] public MiniBossSumoBaseConfig _base;
        [FieldOffset(0x80)] public MiniBossSumoColliderConfig collider;
        [FieldOffset(0x6B0)] public MiniBossSumoRopeConfig rope;
        [FieldOffset(0x6F0)] public MiniBossSumoSlingShotConfig slingShot;
        [FieldOffset(0x710)] public MiniBossSumoMoveConfig move;
        [FieldOffset(0x720)] public MiniBossSumoThrowPuckParam throwPuck;
        [FieldOffset(0x780)] public MiniBossSumoSlingshotComboParam combo;
        [FieldOffset(0x790)] public MiniBossSumoIKParam ik;
        [FieldOffset(0x9E0)] public MiniBossSumoCyloopConfig cyloop;
        [FieldOffset(0x9F0)] public MiniBossSumoLockonConfig lockon;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct MiniBossSumoLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct MiniBossSumoPuckParam
    {
        [FieldOffset(0x00)] public int puckCount;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x09)]
    public struct MiniBossSumoElectricRopePattern
    {
        [FieldOffset(0x00)] public bool enabled;
        [FieldOffset(0x01)] public bool electriced__arr0;
        [FieldOffset(0x02)] public bool electriced__arr1;
        [FieldOffset(0x03)] public bool electriced__arr2;
        [FieldOffset(0x04)] public bool electriced__arr3;
        [FieldOffset(0x05)] public bool electriced__arr4;
        [FieldOffset(0x06)] public bool electriced__arr5;
        [FieldOffset(0x07)] public bool electriced__arr6;
        [FieldOffset(0x08)] public bool electriced__arr7;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x5A)]
    public struct MiniBossSumoRotationElectricRopeParam
    {
        [FieldOffset(0x00)] public MiniBossSumoElectricRopePattern patterns__arr0;
        [FieldOffset(0x09)] public MiniBossSumoElectricRopePattern patterns__arr1;
        [FieldOffset(0x12)] public MiniBossSumoElectricRopePattern patterns__arr2;
        [FieldOffset(0x1B)] public MiniBossSumoElectricRopePattern patterns__arr3;
        [FieldOffset(0x24)] public MiniBossSumoElectricRopePattern patterns__arr4;
        [FieldOffset(0x2D)] public MiniBossSumoElectricRopePattern patterns__arr5;
        [FieldOffset(0x36)] public MiniBossSumoElectricRopePattern patterns__arr6;
        [FieldOffset(0x3F)] public MiniBossSumoElectricRopePattern patterns__arr7;
        [FieldOffset(0x48)] public MiniBossSumoElectricRopePattern patterns__arr8;
        [FieldOffset(0x51)] public MiniBossSumoElectricRopePattern patterns__arr9;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1D4)]
    public struct MiniBossSumoBehaviorHPRateParam
    {
        [FieldOffset(0x00)] public int rateHp;
        [FieldOffset(0x04)] public MiniBossSumoPuckParam puck;
        [FieldOffset(0x10)] public MiniBossSumoRotationElectricRopeParam rotation8;
        [FieldOffset(0x6A)] public MiniBossSumoRotationElectricRopeParam rotation7;
        [FieldOffset(0xC4)] public MiniBossSumoRotationElectricRopeParam rotation6;
        [FieldOffset(0x11E)] public MiniBossSumoRotationElectricRopeParam rotation5;
        [FieldOffset(0x178)] public MiniBossSumoRotationElectricRopeParam rotation4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x580)]
    public struct MiniBossSumoLevelBand
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossSumoBehaviorHPRateParam hpRateParams__arr0;
        [FieldOffset(0x1D8)] public MiniBossSumoBehaviorHPRateParam hpRateParams__arr1;
        [FieldOffset(0x3AC)] public MiniBossSumoBehaviorHPRateParam hpRateParams__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x26A0)]
    public struct MiniBossSumoConfig
    {
        [FieldOffset(0x00)] public MiniBossSumoCommonParam commonParam;
        [FieldOffset(0xA00)] public MiniBossSumoLevelParam levelParams__arr0;
        [FieldOffset(0xA38)] public MiniBossSumoLevelParam levelParams__arr1;
        [FieldOffset(0xA70)] public MiniBossSumoLevelParam levelParams__arr2;
        [FieldOffset(0xAA8)] public MiniBossSumoLevelParam levelParams__arr3;
        [FieldOffset(0xAE0)] public MiniBossSumoLevelParam levelParams__arr4;
        [FieldOffset(0xB18)] public MiniBossSumoLevelBand levelBand__arr0;
        [FieldOffset(0x1098)] public MiniBossSumoLevelBand levelBand__arr1;
        [FieldOffset(0x1618)] public MiniBossSumoLevelBand levelBand__arr2;
        [FieldOffset(0x1B98)] public MiniBossSumoLevelBand levelBand__arr3;
        [FieldOffset(0x2118)] public MiniBossSumoLevelBand levelBand__arr4;
    }

}