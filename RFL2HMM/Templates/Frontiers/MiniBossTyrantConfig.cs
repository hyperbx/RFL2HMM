using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossTyrantConfigClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct MiniBossTyrantCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig commonConfig;
        [FieldOffset(0x40)] public float nonBattleRange;
        [FieldOffset(0x44)] public float miniDamageRange;
        [FieldOffset(0x48)] public float miniComboRange;
        [FieldOffset(0x4C)] public float miniOffsetY;
        [FieldOffset(0x50)] public float bodyDamageRange;
        [FieldOffset(0x54)] public float bodyComboRange;
        [FieldOffset(0x58)] public float bodyOffsetY;
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
    public struct MiniBossTyrantLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct MiniBossTyrantLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossTyrantAttackSpinParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float time;
        [FieldOffset(0x08)] public float waitTime;
        [FieldOffset(0x0C)] public float rotSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct MiniBossTyrantAttackAirSpinParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public int attackNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct MiniBossTyrantAttackRouletteParam
    {
        [FieldOffset(0x00)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct MiniBossTyrantAttackLaserParam
    {
        [FieldOffset(0x00)] public Vector3 muzzlePosOffset;
        [FieldOffset(0x10)] public float time;
        [FieldOffset(0x14)] public float rotSpeed;
        [FieldOffset(0x18)] public float waitTime;
    }

    public enum BarrageType : sbyte
    {
        TYPE_AIM_PLAYER = 0,
        TYPE_NO_AIM = 1
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

    [StructLayout(LayoutKind.Explicit, Size = 0x48)]
    public struct MiniBossTyrantBarrageParam
    {
        [FieldOffset(0x00)] public BarrageType type;
        [FieldOffset(0x08)] public UnmanagedString damageTag;
        [FieldOffset(0x18)] public float startSpeed;
        [FieldOffset(0x1C)] public float decelePower;
        [FieldOffset(0x20)] public float minSpeed;
        [FieldOffset(0x24)] public float lifeTime;
        [FieldOffset(0x28)] public float waitTime;
        [FieldOffset(0x2C)] public float lineTime;
        [FieldOffset(0x30)] public float scale;
        [FieldOffset(0x34)] public float hitVelocity;
        [FieldOffset(0x38)] public float parriedSpeed;
        [FieldOffset(0x3C)] public int parriedDamage;
        [FieldOffset(0x40)] public float parriedStaggerValue;
        [FieldOffset(0x44)] public float parriedStunValue;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct MiniBossTyrantShotgunBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float zOffset;
        [FieldOffset(0x0C)] public bool isFollowPlayer;
        [FieldOffset(0x10)] public float shotIntarval;
        [FieldOffset(0x14)] public float maxAngle;
        [FieldOffset(0x18)] public float yAngleOffset;
        [FieldOffset(0x1C)] public float shotTime;
        [FieldOffset(0x20)] public float addSpeedMax;
        [FieldOffset(0x24)] public float startWaitTime;
        [FieldOffset(0x28)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct MiniBossTyrantWinderBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float zOffset;
        [FieldOffset(0x0C)] public bool isFollowPlayer;
        [FieldOffset(0x10)] public float shotIntarval;
        [FieldOffset(0x14)] public float maxAngle;
        [FieldOffset(0x18)] public float rotateSpeed;
        [FieldOffset(0x1C)] public float rotateAngle;
        [FieldOffset(0x20)] public float barrageAngleDiff;
        [FieldOffset(0x24)] public float startWaitTime;
        [FieldOffset(0x28)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct MiniBossTyrantLineBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float zOffset;
        [FieldOffset(0x0C)] public int num;
        [FieldOffset(0x10)] public float waitTime;
        [FieldOffset(0x14)] public bool isFollowPlayer;
        [FieldOffset(0x18)] public float startWaitTime;
        [FieldOffset(0x1C)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossTyrantWaveBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float zOffset;
        [FieldOffset(0x0C)] public bool isFollowPlayer;
        [FieldOffset(0x10)] public float waitTime;
        [FieldOffset(0x14)] public float sideAngle;
        [FieldOffset(0x18)] public int arrayNum;
        [FieldOffset(0x1C)] public float arrayTime;
        [FieldOffset(0x20)] public float startWaitTime;
        [FieldOffset(0x24)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossTyrantAttackCircleBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float zOffset;
        [FieldOffset(0x0C)] public int num;
        [FieldOffset(0x10)] public float speed;
        [FieldOffset(0x14)] public float rotSpeed;
        [FieldOffset(0x18)] public int arrayNum;
        [FieldOffset(0x1C)] public float arrayTime;
        [FieldOffset(0x20)] public float startWaitTime;
        [FieldOffset(0x24)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct MiniBossTyrantSequenceParameter
    {
        [FieldOffset(0x00)] public float airBattleRate;
        [FieldOffset(0x04)] public float nextRoundRate;
        [FieldOffset(0x08)] public float airBattleRateSecond;
        [FieldOffset(0x0C)] public float chanceTime;
        [FieldOffset(0x10)] public float chanceTimeSecond;
        [FieldOffset(0x14)] public bool isSpin;
        [FieldOffset(0x15)] public bool isSecondAttack;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossTyrantCyloopDamageParameter
    {
        [FieldOffset(0x00)] public float upPower;
        [FieldOffset(0x04)] public float upTime;
        [FieldOffset(0x08)] public float attackTime;
        [FieldOffset(0x0C)] public float downPower;
    }

    public enum ActionType : sbyte
    {
        ACTION_TYPE_NONE = 0,
        ACTION_TYPE_SPIN = 1,
        ACTION_TYPE_ROULETTE = 2,
        ACTION_TYPE_LASER = 3,
        ACTION_TYPE_SHOTGUN = 4,
        ACTION_TYPE_WINDER = 5,
        ACTION_TYPE_LINE = 6,
        ACTION_TYPE_WAVE = 7,
        ACTION_TYPE_CIRCLE = 8
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x5D0)]
    public struct MiniBossTyrantAttackParam
    {
        [FieldOffset(0x00)] public MiniBossTyrantAttackSpinParam spin;
        [FieldOffset(0x10)] public MiniBossTyrantAttackAirSpinParam airSpin;
        [FieldOffset(0x18)] public MiniBossTyrantAttackRouletteParam roulette;
        [FieldOffset(0x20)] public MiniBossTyrantAttackLaserParam laser;
        [FieldOffset(0x40)] public float rotSpeed;
        [FieldOffset(0x48)] public MiniBossTyrantBarrageParam barrage__arr0;
        [FieldOffset(0x90)] public MiniBossTyrantBarrageParam barrage__arr1;
        [FieldOffset(0xD8)] public MiniBossTyrantBarrageParam barrage__arr2;
        [FieldOffset(0x120)] public MiniBossTyrantBarrageParam barrage__arr3;
        [FieldOffset(0x168)] public MiniBossTyrantBarrageParam barrage__arr4;
        [FieldOffset(0x1B0)] public MiniBossTyrantBarrageParam barrage__arr5;
        [FieldOffset(0x1F8)] public MiniBossTyrantBarrageParam barrage__arr6;
        [FieldOffset(0x240)] public MiniBossTyrantBarrageParam barrage__arr7;
        [FieldOffset(0x288)] public MiniBossTyrantBarrageParam barrage__arr8;
        [FieldOffset(0x2D0)] public MiniBossTyrantBarrageParam barrage__arr9;
        [FieldOffset(0x318)] public MiniBossTyrantBarrageParam barrage__arr10;
        [FieldOffset(0x360)] public MiniBossTyrantBarrageParam barrage__arr11;
        [FieldOffset(0x3A8)] public MiniBossTyrantBarrageParam barrage__arr12;
        [FieldOffset(0x3F0)] public MiniBossTyrantBarrageParam barrage__arr13;
        [FieldOffset(0x438)] public MiniBossTyrantBarrageParam barrage__arr14;
        [FieldOffset(0x480)] public MiniBossTyrantBarrageParam barrage__arr15;
        [FieldOffset(0x4C8)] public MiniBossTyrantShotgunBullet shotgunBullet;
        [FieldOffset(0x4F4)] public MiniBossTyrantWinderBullet winderBullet;
        [FieldOffset(0x520)] public MiniBossTyrantLineBullet lineBullet;
        [FieldOffset(0x540)] public MiniBossTyrantWaveBullet waveBullet;
        [FieldOffset(0x568)] public MiniBossTyrantAttackCircleBullet circleBullet;
        [FieldOffset(0x590)] public MiniBossTyrantSequenceParameter sequenceParam;
        [FieldOffset(0x5A8)] public MiniBossTyrantCyloopDamageParameter cyloopParam;
        [FieldOffset(0x5B8)] public ActionType actionListGround__arr0;
        [FieldOffset(0x5B9)] public ActionType actionListGround__arr1;
        [FieldOffset(0x5BA)] public ActionType actionListGround__arr2;
        [FieldOffset(0x5BB)] public ActionType actionListGround__arr3;
        [FieldOffset(0x5BC)] public ActionType actionListGround__arr4;
        [FieldOffset(0x5BD)] public ActionType actionListGround__arr5;
        [FieldOffset(0x5BE)] public ActionType actionListGround__arr6;
        [FieldOffset(0x5BF)] public ActionType actionListGround__arr7;
        [FieldOffset(0x5C0)] public ActionType actionListGround__arr8;
        [FieldOffset(0x5C1)] public ActionType actionListGround__arr9;
        [FieldOffset(0x5C2)] public ActionType actionListAir__arr0;
        [FieldOffset(0x5C3)] public ActionType actionListAir__arr1;
        [FieldOffset(0x5C4)] public ActionType actionListAir__arr2;
        [FieldOffset(0x5C5)] public ActionType actionListAir__arr3;
        [FieldOffset(0x5C6)] public ActionType actionListAir__arr4;
        [FieldOffset(0x5C7)] public ActionType actionListAir__arr5;
        [FieldOffset(0x5C8)] public ActionType actionListAir__arr6;
        [FieldOffset(0x5C9)] public ActionType actionListAir__arr7;
        [FieldOffset(0x5CA)] public ActionType actionListAir__arr8;
        [FieldOffset(0x5CB)] public ActionType actionListAir__arr9;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossTyrantDebrisParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float accel;
        [FieldOffset(0x08)] public float rotate_speed_min;
        [FieldOffset(0x0C)] public float rotate_speed_max;
        [FieldOffset(0x10)] public float rotate_speed_fast;
        [FieldOffset(0x14)] public float rotate_accel;
        [FieldOffset(0x18)] public float life;
        [FieldOffset(0x1C)] public float spawn_offset;
        [FieldOffset(0x20)] public float spawn_interval;
        [FieldOffset(0x24)] public int spawn_num;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossTyrantStormEffectParam
    {
        [FieldOffset(0x00)] public MiniBossTyrantDebrisParam debris;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x790)]
    public struct MiniBossTyrantConfig
    {
        [FieldOffset(0x00)] public MiniBossTyrantCommonParam commonParam;
        [FieldOffset(0x60)] public MiniBossTyrantLevelParam levelParams__arr0;
        [FieldOffset(0x98)] public MiniBossTyrantLevelParam levelParams__arr1;
        [FieldOffset(0xD0)] public MiniBossTyrantLevelParam levelParams__arr2;
        [FieldOffset(0x108)] public MiniBossTyrantLevelParam levelParams__arr3;
        [FieldOffset(0x140)] public MiniBossTyrantLevelParam levelParams__arr4;
        [FieldOffset(0x178)] public MiniBossTyrantLevelBand levelBand__arr0;
        [FieldOffset(0x17C)] public MiniBossTyrantLevelBand levelBand__arr1;
        [FieldOffset(0x180)] public MiniBossTyrantLevelBand levelBand__arr2;
        [FieldOffset(0x184)] public MiniBossTyrantLevelBand levelBand__arr3;
        [FieldOffset(0x188)] public MiniBossTyrantLevelBand levelBand__arr4;
        [FieldOffset(0x190)] public MiniBossTyrantAttackParam attackParam;
        [FieldOffset(0x760)] public MiniBossTyrantStormEffectParam stormEffectParam;
    }

}