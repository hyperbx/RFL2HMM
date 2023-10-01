using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossChargerConfigClass
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

    public enum BarrageType : sbyte
    {
        TYPE_LASER = 0,
        TYPE_BALL = 1,
        TYPE_BALL_L = 2,
        TYPE_BALL_LL = 3,
        TYPE_AIR_DROP = 4
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

    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct MiniBossChagerBarrageParam
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
        [FieldOffset(0x48)] public UnmanagedString hitEffName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct MiniBossChagerSimpleRotateBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float startWaitTime;
        [FieldOffset(0x08)] public int muzzleNum;
        [FieldOffset(0x0C)] public float yOffset;
        [FieldOffset(0x10)] public float zOffset;
        [FieldOffset(0x14)] public float heightLength;
        [FieldOffset(0x18)] public float rotSpeed;
        [FieldOffset(0x1C)] public float shakeSpeed;
        [FieldOffset(0x20)] public float intervalTime;
        [FieldOffset(0x24)] public float activeTime;
        [FieldOffset(0x28)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct MiniBossChagerFollowLaser
    {
        [FieldOffset(0x00)] public float startWaitTime;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float zOffset;
        [FieldOffset(0x0C)] public float moveSpeed;
        [FieldOffset(0x10)] public float followDeg;
        [FieldOffset(0x14)] public int shotNum;
        [FieldOffset(0x18)] public float intervalTime;
        [FieldOffset(0x1C)] public float lifeTime;
        [FieldOffset(0x20)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct MiniBossChagerVortexLaser
    {
        [FieldOffset(0x00)] public float startWaitTime;
        [FieldOffset(0x04)] public int muzzleNum;
        [FieldOffset(0x08)] public float yOffset;
        [FieldOffset(0x0C)] public float zOffset;
        [FieldOffset(0x10)] public float rotSpeed;
        [FieldOffset(0x14)] public float moveSpeed;
        [FieldOffset(0x18)] public float activeTime;
        [FieldOffset(0x1C)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct MiniBossChagerCrossLaser
    {
        [FieldOffset(0x00)] public float startWaitTime;
        [FieldOffset(0x04)] public float moveSpeed;
        [FieldOffset(0x08)] public float setDeg;
        [FieldOffset(0x0C)] public float lifeTime;
        [FieldOffset(0x10)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossChagerCrossBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float zOffset;
        [FieldOffset(0x0C)] public bool isFollowPlayer;
        [FieldOffset(0x10)] public float startWaitTime;
        [FieldOffset(0x14)] public float shotIntarval;
        [FieldOffset(0x18)] public float maxAngle;
        [FieldOffset(0x1C)] public float rotateSpeed;
        [FieldOffset(0x20)] public float rotateAngle;
        [FieldOffset(0x24)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct MiniBossChagerMassLaser
    {
        [FieldOffset(0x00)] public float startWaitTime;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float scale;
        [FieldOffset(0x0C)] public float lifeTime;
        [FieldOffset(0x10)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct MiniBossChagerVerticalRoundBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float startWaitTime;
        [FieldOffset(0x08)] public int muzzleNum;
        [FieldOffset(0x0C)] public int verticalNum;
        [FieldOffset(0x10)] public float radius;
        [FieldOffset(0x14)] public float spaceRate;
        [FieldOffset(0x18)] public float verticalWaitTime;
        [FieldOffset(0x1C)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct MiniBossPyramidRoundBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float startWaitTime;
        [FieldOffset(0x08)] public int muzzleNum;
        [FieldOffset(0x0C)] public float radius;
        [FieldOffset(0x10)] public float height;
        [FieldOffset(0x14)] public float scale;
        [FieldOffset(0x18)] public int sideNum;
        [FieldOffset(0x1C)] public int attackNum;
        [FieldOffset(0x20)] public float intervalTime;
        [FieldOffset(0x24)] public float nextDeg;
        [FieldOffset(0x28)] public float shotWaitTime;
        [FieldOffset(0x2C)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct MiniBossPlaneUpDownBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float startWaitTime;
        [FieldOffset(0x08)] public float yOffset;
        [FieldOffset(0x0C)] public float scale;
        [FieldOffset(0x10)] public float step;
        [FieldOffset(0x14)] public int allNum;
        [FieldOffset(0x18)] public float upRate;
        [FieldOffset(0x1C)] public float downRate;
        [FieldOffset(0x20)] public float frontRate;
        [FieldOffset(0x24)] public float shotWaitTimeMin;
        [FieldOffset(0x28)] public float shotWaitTimeMax;
        [FieldOffset(0x2C)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct MiniBossTriangleBatteryBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float startWaitTime;
        [FieldOffset(0x08)] public float yOffset;
        [FieldOffset(0x0C)] public float edgeLength;
        [FieldOffset(0x10)] public float activeTime;
        [FieldOffset(0x14)] public float intervalTime;
        [FieldOffset(0x18)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossPlayerFallBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float startWaitTime;
        [FieldOffset(0x08)] public float yOffset;
        [FieldOffset(0x0C)] public float scale;
        [FieldOffset(0x10)] public float lengthMin;
        [FieldOffset(0x14)] public float lengthMax;
        [FieldOffset(0x18)] public float intervalTime;
        [FieldOffset(0x1C)] public float shotWaitTime;
        [FieldOffset(0x20)] public float activeTime;
        [FieldOffset(0x24)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct MiniBossGatlingRevolverBullet
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float startWaitTime;
        [FieldOffset(0x08)] public float yOffset;
        [FieldOffset(0x0C)] public float zOffset;
        [FieldOffset(0x10)] public float scale;
        [FieldOffset(0x14)] public int muzzleNum;
        [FieldOffset(0x18)] public float bulletRad;
        [FieldOffset(0x1C)] public float intervalTime;
        [FieldOffset(0x20)] public float activeTime;
        [FieldOffset(0x24)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct MiniBossWinderBullet
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

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct MiniBossShotgunBullet
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

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct MiniBossChagerAirDrop
    {
        [FieldOffset(0x00)] public int barrageIndex;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float zOffset;
        [FieldOffset(0x0C)] public float upRotOffset;
        [FieldOffset(0x10)] public float yAngleOffset;
        [FieldOffset(0x14)] public float maxAngle;
        [FieldOffset(0x18)] public float shotTime;
        [FieldOffset(0x1C)] public float addSpeedMax;
        [FieldOffset(0x20)] public float lineTime;
        [FieldOffset(0x24)] public float fallPower;
        [FieldOffset(0x28)] public float startWaitTime;
        [FieldOffset(0x2C)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct MiniBossChagerGroundObj
    {
        [FieldOffset(0x00)] public int bulletDamage;
        [FieldOffset(0x04)] public float bulletStaggerPoint;
        [FieldOffset(0x08)] public float bulletSpeed;
        [FieldOffset(0x0C)] public float bulletFallSpeed;
        [FieldOffset(0x10)] public float bulletCyloopSpeed;
        [FieldOffset(0x14)] public float bulletGroundTime;
        [FieldOffset(0x18)] public float bulletFallTime;
        [FieldOffset(0x1C)] public float yOffset;
        [FieldOffset(0x20)] public float zOffset;
        [FieldOffset(0x24)] public float upRotOffset;
        [FieldOffset(0x28)] public float yAngleOffset;
        [FieldOffset(0x2C)] public float maxAngle;
        [FieldOffset(0x30)] public float shotTime;
        [FieldOffset(0x34)] public float startWaitTime;
        [FieldOffset(0x38)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x150)]
    public struct MiniBossChagerDiffuseLaser
    {
        [FieldOffset(0x00)] public float startWaitTime;
        [FieldOffset(0x04)] public float yOffset;
        [FieldOffset(0x08)] public float scale;
        [FieldOffset(0x0C)] public int muzzleNum;
        [FieldOffset(0x10)] public Vector3 muzzlePosOffset__arr0;
        [FieldOffset(0x20)] public Vector3 muzzlePosOffset__arr1;
        [FieldOffset(0x30)] public Vector3 muzzlePosOffset__arr2;
        [FieldOffset(0x40)] public Vector3 muzzlePosOffset__arr3;
        [FieldOffset(0x50)] public Vector3 muzzlePosOffset__arr4;
        [FieldOffset(0x60)] public Vector3 muzzlePosOffset__arr5;
        [FieldOffset(0x70)] public Vector3 muzzlePosOffset__arr6;
        [FieldOffset(0x80)] public Vector3 muzzlePosOffset__arr7;
        [FieldOffset(0x90)] public Vector3 muzzlePosOffset__arr8;
        [FieldOffset(0xA0)] public Vector3 muzzlePosOffset__arr9;
        [FieldOffset(0xB0)] public float muzzleRotOffset__arr0;
        [FieldOffset(0xB4)] public float muzzleRotOffset__arr1;
        [FieldOffset(0xB8)] public float muzzleRotOffset__arr2;
        [FieldOffset(0xBC)] public float muzzleRotOffset__arr3;
        [FieldOffset(0xC0)] public float muzzleRotOffset__arr4;
        [FieldOffset(0xC4)] public float muzzleRotOffset__arr5;
        [FieldOffset(0xC8)] public float muzzleRotOffset__arr6;
        [FieldOffset(0xCC)] public float muzzleRotOffset__arr7;
        [FieldOffset(0xD0)] public float muzzleRotOffset__arr8;
        [FieldOffset(0xD4)] public float muzzleRotOffset__arr9;
        [FieldOffset(0xD8)] public float muzzleTimeOffset__arr0;
        [FieldOffset(0xDC)] public float muzzleTimeOffset__arr1;
        [FieldOffset(0xE0)] public float muzzleTimeOffset__arr2;
        [FieldOffset(0xE4)] public float muzzleTimeOffset__arr3;
        [FieldOffset(0xE8)] public float muzzleTimeOffset__arr4;
        [FieldOffset(0xEC)] public float muzzleTimeOffset__arr5;
        [FieldOffset(0xF0)] public float muzzleTimeOffset__arr6;
        [FieldOffset(0xF4)] public float muzzleTimeOffset__arr7;
        [FieldOffset(0xF8)] public float muzzleTimeOffset__arr8;
        [FieldOffset(0xFC)] public float muzzleTimeOffset__arr9;
        [FieldOffset(0x100)] public float muzzleLaserStartOffset__arr0;
        [FieldOffset(0x104)] public float muzzleLaserStartOffset__arr1;
        [FieldOffset(0x108)] public float muzzleLaserStartOffset__arr2;
        [FieldOffset(0x10C)] public float muzzleLaserStartOffset__arr3;
        [FieldOffset(0x110)] public float muzzleLaserStartOffset__arr4;
        [FieldOffset(0x114)] public float muzzleLaserStartOffset__arr5;
        [FieldOffset(0x118)] public float muzzleLaserStartOffset__arr6;
        [FieldOffset(0x11C)] public float muzzleLaserStartOffset__arr7;
        [FieldOffset(0x120)] public float muzzleLaserStartOffset__arr8;
        [FieldOffset(0x124)] public float muzzleLaserStartOffset__arr9;
        [FieldOffset(0x128)] public int laserNum;
        [FieldOffset(0x12C)] public int attackNum;
        [FieldOffset(0x130)] public float laserRandomRange;
        [FieldOffset(0x134)] public float laserTime;
        [FieldOffset(0x138)] public float laserEndTime;
        [FieldOffset(0x13C)] public float laserNextTime;
        [FieldOffset(0x140)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x180)]
    public struct MiniBossChagerChaseShot
    {
        [FieldOffset(0x00)] public float startWaitTime;
        [FieldOffset(0x04)] public int muzzleNum;
        [FieldOffset(0x10)] public Vector3 muzzlePosOffset__arr0;
        [FieldOffset(0x20)] public Vector3 muzzlePosOffset__arr1;
        [FieldOffset(0x30)] public Vector3 muzzlePosOffset__arr2;
        [FieldOffset(0x40)] public Vector3 muzzlePosOffset__arr3;
        [FieldOffset(0x50)] public Vector3 muzzlePosOffset__arr4;
        [FieldOffset(0x60)] public Vector3 muzzlePosOffset__arr5;
        [FieldOffset(0x70)] public Vector3 muzzlePosOffset__arr6;
        [FieldOffset(0x80)] public Vector3 muzzlePosOffset__arr7;
        [FieldOffset(0x90)] public Vector3 muzzlePosOffset__arr8;
        [FieldOffset(0xA0)] public Vector3 muzzlePosOffset__arr9;
        [FieldOffset(0xB0)] public float muzzleRotOffsetX__arr0;
        [FieldOffset(0xB4)] public float muzzleRotOffsetX__arr1;
        [FieldOffset(0xB8)] public float muzzleRotOffsetX__arr2;
        [FieldOffset(0xBC)] public float muzzleRotOffsetX__arr3;
        [FieldOffset(0xC0)] public float muzzleRotOffsetX__arr4;
        [FieldOffset(0xC4)] public float muzzleRotOffsetX__arr5;
        [FieldOffset(0xC8)] public float muzzleRotOffsetX__arr6;
        [FieldOffset(0xCC)] public float muzzleRotOffsetX__arr7;
        [FieldOffset(0xD0)] public float muzzleRotOffsetX__arr8;
        [FieldOffset(0xD4)] public float muzzleRotOffsetX__arr9;
        [FieldOffset(0xD8)] public float muzzleRotOffsetY__arr0;
        [FieldOffset(0xDC)] public float muzzleRotOffsetY__arr1;
        [FieldOffset(0xE0)] public float muzzleRotOffsetY__arr2;
        [FieldOffset(0xE4)] public float muzzleRotOffsetY__arr3;
        [FieldOffset(0xE8)] public float muzzleRotOffsetY__arr4;
        [FieldOffset(0xEC)] public float muzzleRotOffsetY__arr5;
        [FieldOffset(0xF0)] public float muzzleRotOffsetY__arr6;
        [FieldOffset(0xF4)] public float muzzleRotOffsetY__arr7;
        [FieldOffset(0xF8)] public float muzzleRotOffsetY__arr8;
        [FieldOffset(0xFC)] public float muzzleRotOffsetY__arr9;
        [FieldOffset(0x100)] public float muzzleTimeOffset__arr0;
        [FieldOffset(0x104)] public float muzzleTimeOffset__arr1;
        [FieldOffset(0x108)] public float muzzleTimeOffset__arr2;
        [FieldOffset(0x10C)] public float muzzleTimeOffset__arr3;
        [FieldOffset(0x110)] public float muzzleTimeOffset__arr4;
        [FieldOffset(0x114)] public float muzzleTimeOffset__arr5;
        [FieldOffset(0x118)] public float muzzleTimeOffset__arr6;
        [FieldOffset(0x11C)] public float muzzleTimeOffset__arr7;
        [FieldOffset(0x120)] public float muzzleTimeOffset__arr8;
        [FieldOffset(0x124)] public float muzzleTimeOffset__arr9;
        [FieldOffset(0x128)] public float muzzleLaserStartOffset__arr0;
        [FieldOffset(0x12C)] public float muzzleLaserStartOffset__arr1;
        [FieldOffset(0x130)] public float muzzleLaserStartOffset__arr2;
        [FieldOffset(0x134)] public float muzzleLaserStartOffset__arr3;
        [FieldOffset(0x138)] public float muzzleLaserStartOffset__arr4;
        [FieldOffset(0x13C)] public float muzzleLaserStartOffset__arr5;
        [FieldOffset(0x140)] public float muzzleLaserStartOffset__arr6;
        [FieldOffset(0x144)] public float muzzleLaserStartOffset__arr7;
        [FieldOffset(0x148)] public float muzzleLaserStartOffset__arr8;
        [FieldOffset(0x14C)] public float muzzleLaserStartOffset__arr9;
        [FieldOffset(0x150)] public float laserShotTimeMin;
        [FieldOffset(0x154)] public float laserShotTimeMax;
        [FieldOffset(0x158)] public int laserNum;
        [FieldOffset(0x15C)] public float laserRange;
        [FieldOffset(0x160)] public float laserEndTime;
        [FieldOffset(0x164)] public float laserSpeed;
        [FieldOffset(0x168)] public float laserRandomRangeMin;
        [FieldOffset(0x16C)] public float laserRandomRangeMax;
        [FieldOffset(0x170)] public float laserHomingTime;
        [FieldOffset(0x174)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossChargerCatchParam
    {
        [FieldOffset(0x00)] public float hitDistance;
        [FieldOffset(0x04)] public float durationBind;
        [FieldOffset(0x08)] public float distanceStartBlackOut;
        [FieldOffset(0x0C)] public float timeEaseBlackOut;
        [FieldOffset(0x10)] public float timeDelayEndtBlackOut;
        [FieldOffset(0x20)] public Vector3 tangentFrom;
        [FieldOffset(0x30)] public Vector3 tangentTo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x15C0)]
    public struct MiniBossChargerCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig commonConfig;
        [FieldOffset(0x40)] public MiniBossChagerBarrageParam barrage__arr0;
        [FieldOffset(0x98)] public MiniBossChagerBarrageParam barrage__arr1;
        [FieldOffset(0xF0)] public MiniBossChagerBarrageParam barrage__arr2;
        [FieldOffset(0x148)] public MiniBossChagerBarrageParam barrage__arr3;
        [FieldOffset(0x1A0)] public MiniBossChagerBarrageParam barrage__arr4;
        [FieldOffset(0x1F8)] public MiniBossChagerBarrageParam barrage__arr5;
        [FieldOffset(0x250)] public MiniBossChagerBarrageParam barrage__arr6;
        [FieldOffset(0x2A8)] public MiniBossChagerBarrageParam barrage__arr7;
        [FieldOffset(0x300)] public MiniBossChagerBarrageParam barrage__arr8;
        [FieldOffset(0x358)] public MiniBossChagerBarrageParam barrage__arr9;
        [FieldOffset(0x3B0)] public MiniBossChagerBarrageParam barrage__arr10;
        [FieldOffset(0x408)] public MiniBossChagerBarrageParam barrage__arr11;
        [FieldOffset(0x460)] public MiniBossChagerBarrageParam barrage__arr12;
        [FieldOffset(0x4B8)] public MiniBossChagerBarrageParam barrage__arr13;
        [FieldOffset(0x510)] public MiniBossChagerBarrageParam barrage__arr14;
        [FieldOffset(0x568)] public MiniBossChagerBarrageParam barrage__arr15;
        [FieldOffset(0x5C0)] public MiniBossChagerSimpleRotateBullet simpleRotateBullet__arr0;
        [FieldOffset(0x5EC)] public MiniBossChagerSimpleRotateBullet simpleRotateBullet__arr1;
        [FieldOffset(0x618)] public MiniBossChagerSimpleRotateBullet simpleRotateBullet__arr2;
        [FieldOffset(0x644)] public MiniBossChagerFollowLaser followLaser__arr0;
        [FieldOffset(0x668)] public MiniBossChagerFollowLaser followLaser__arr1;
        [FieldOffset(0x68C)] public MiniBossChagerFollowLaser followLaser__arr2;
        [FieldOffset(0x6B0)] public MiniBossChagerVortexLaser vortexLaser__arr0;
        [FieldOffset(0x6D0)] public MiniBossChagerVortexLaser vortexLaser__arr1;
        [FieldOffset(0x6F0)] public MiniBossChagerVortexLaser vortexLaser__arr2;
        [FieldOffset(0x710)] public MiniBossChagerCrossLaser crossLaser__arr0;
        [FieldOffset(0x724)] public MiniBossChagerCrossLaser crossLaser__arr1;
        [FieldOffset(0x738)] public MiniBossChagerCrossLaser crossLaser__arr2;
        [FieldOffset(0x74C)] public MiniBossChagerCrossBullet crossBullet__arr0;
        [FieldOffset(0x774)] public MiniBossChagerCrossBullet crossBullet__arr1;
        [FieldOffset(0x79C)] public MiniBossChagerCrossBullet crossBullet__arr2;
        [FieldOffset(0x7C4)] public MiniBossChagerMassLaser massLaser__arr0;
        [FieldOffset(0x7D8)] public MiniBossChagerMassLaser massLaser__arr1;
        [FieldOffset(0x7EC)] public MiniBossChagerMassLaser massLaser__arr2;
        [FieldOffset(0x800)] public MiniBossChagerVerticalRoundBullet verticalRoundBullet__arr0;
        [FieldOffset(0x820)] public MiniBossChagerVerticalRoundBullet verticalRoundBullet__arr1;
        [FieldOffset(0x840)] public MiniBossChagerVerticalRoundBullet verticalRoundBullet__arr2;
        [FieldOffset(0x860)] public MiniBossPyramidRoundBullet pyramidRoundBullet__arr0;
        [FieldOffset(0x890)] public MiniBossPyramidRoundBullet pyramidRoundBullet__arr1;
        [FieldOffset(0x8C0)] public MiniBossPyramidRoundBullet pyramidRoundBullet__arr2;
        [FieldOffset(0x8F0)] public MiniBossPlaneUpDownBullet planeUpDownBullet__arr0;
        [FieldOffset(0x920)] public MiniBossPlaneUpDownBullet planeUpDownBullet__arr1;
        [FieldOffset(0x950)] public MiniBossPlaneUpDownBullet planeUpDownBullet__arr2;
        [FieldOffset(0x980)] public MiniBossTriangleBatteryBullet triangleBatteryBullet__arr0;
        [FieldOffset(0x99C)] public MiniBossTriangleBatteryBullet triangleBatteryBullet__arr1;
        [FieldOffset(0x9B8)] public MiniBossTriangleBatteryBullet triangleBatteryBullet__arr2;
        [FieldOffset(0x9D4)] public MiniBossPlayerFallBullet playerFallBullet__arr0;
        [FieldOffset(0x9FC)] public MiniBossPlayerFallBullet playerFallBullet__arr1;
        [FieldOffset(0xA24)] public MiniBossPlayerFallBullet playerFallBullet__arr2;
        [FieldOffset(0xA4C)] public MiniBossGatlingRevolverBullet gatlingRevolverBullet__arr0;
        [FieldOffset(0xA74)] public MiniBossGatlingRevolverBullet gatlingRevolverBullet__arr1;
        [FieldOffset(0xA9C)] public MiniBossGatlingRevolverBullet gatlingRevolverBullet__arr2;
        [FieldOffset(0xAC4)] public MiniBossWinderBullet winderBullet__arr0;
        [FieldOffset(0xAF0)] public MiniBossWinderBullet winderBullet__arr1;
        [FieldOffset(0xB1C)] public MiniBossWinderBullet winderBullet__arr2;
        [FieldOffset(0xB48)] public MiniBossShotgunBullet shotgunBullet__arr0;
        [FieldOffset(0xB74)] public MiniBossShotgunBullet shotgunBullet__arr1;
        [FieldOffset(0xBA0)] public MiniBossShotgunBullet shotgunBullet__arr2;
        [FieldOffset(0xBCC)] public MiniBossChagerAirDrop airDrop__arr0;
        [FieldOffset(0xBFC)] public MiniBossChagerAirDrop airDrop__arr1;
        [FieldOffset(0xC2C)] public MiniBossChagerAirDrop airDrop__arr2;
        [FieldOffset(0xC5C)] public MiniBossChagerGroundObj groundObj__arr0;
        [FieldOffset(0xC98)] public MiniBossChagerGroundObj groundObj__arr1;
        [FieldOffset(0xCD4)] public MiniBossChagerGroundObj groundObj__arr2;
        [FieldOffset(0xD10)] public MiniBossChagerDiffuseLaser diffuseLaser__arr0;
        [FieldOffset(0xE60)] public MiniBossChagerDiffuseLaser diffuseLaser__arr1;
        [FieldOffset(0xFB0)] public MiniBossChagerDiffuseLaser diffuseLaser__arr2;
        [FieldOffset(0x1100)] public MiniBossChagerChaseShot chaseShot__arr0;
        [FieldOffset(0x1280)] public MiniBossChagerChaseShot chaseShot__arr1;
        [FieldOffset(0x1400)] public MiniBossChagerChaseShot chaseShot__arr2;
        [FieldOffset(0x1580)] public MiniBossChargerCatchParam atkCatch;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct MiniBossChargerLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
        [FieldOffset(0x38)] public float stunTime;
    }

    public enum AttackType : int
    {
        AttackTypeInvalid = 0,
        AttackSimpleRotateBullet = 1,
        AttackFollowLaser = 2,
        AttackVortexLaser = 3,
        AttackCrossLaser = 4,
        AttackCrossBullet = 5,
        AttackMassLaser = 6,
        AttackVerticalRoundBullet = 7,
        AttackPyramidRoundBullet = 8,
        AttackPlaneUpDownBullet = 9,
        AttackTriangleBatteryBullet = 10,
        AttackPlayerFallBullet = 11,
        AttackGatlingRevolverBullet = 12,
        AttackWinderBullet = 13,
        AttackShotgunBullet = 14,
        AttackAirDropBullet = 15,
        AttackChaseShotObject = 16,
        AttackDiffuseLaser = 17,
        AttackChaseShot = 18,
        AttackTypeNum = 19
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct MiniBossChargerHPRateParam
    {
        [FieldOffset(0x00)] public int rateHp;
        [FieldOffset(0x08)] public UnmanagedString grindSetName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xB8)]
    public struct MiniBossChargerLevelBand
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public float rate;
        [FieldOffset(0x08)] public float chanceTime;
        [FieldOffset(0x0C)] public float chanceTimeMoveSpeed;
        [FieldOffset(0x10)] public float chanceTimeDecSpeed;
        [FieldOffset(0x14)] public float chanceTimeSpeedMin;
        [FieldOffset(0x18)] public float damageTime;
        [FieldOffset(0x1C)] public float chanceTimeAddSpeed;
        [FieldOffset(0x20)] public AttackType attackTable__arr0;
        [FieldOffset(0x24)] public AttackType attackTable__arr1;
        [FieldOffset(0x28)] public AttackType attackTable__arr2;
        [FieldOffset(0x2C)] public AttackType attackTable__arr3;
        [FieldOffset(0x30)] public AttackType attackTable__arr4;
        [FieldOffset(0x34)] public AttackType attackTable__arr5;
        [FieldOffset(0x38)] public AttackType attackTable__arr6;
        [FieldOffset(0x3C)] public AttackType attackTable__arr7;
        [FieldOffset(0x40)] public AttackType attackTable__arr8;
        [FieldOffset(0x44)] public AttackType attackTable__arr9;
        [FieldOffset(0x48)] public int attackIndexTable__arr0;
        [FieldOffset(0x4C)] public int attackIndexTable__arr1;
        [FieldOffset(0x50)] public int attackIndexTable__arr2;
        [FieldOffset(0x54)] public int attackIndexTable__arr3;
        [FieldOffset(0x58)] public int attackIndexTable__arr4;
        [FieldOffset(0x5C)] public int attackIndexTable__arr5;
        [FieldOffset(0x60)] public int attackIndexTable__arr6;
        [FieldOffset(0x64)] public int attackIndexTable__arr7;
        [FieldOffset(0x68)] public int attackIndexTable__arr8;
        [FieldOffset(0x6C)] public int attackIndexTable__arr9;
        [FieldOffset(0x70)] public MiniBossChargerHPRateParam hpRateParams__arr0;
        [FieldOffset(0x88)] public MiniBossChargerHPRateParam hpRateParams__arr1;
        [FieldOffset(0xA0)] public MiniBossChargerHPRateParam hpRateParams__arr2;
    }

    public enum MiniBossChargerLevel1_AttackType : int
    {
        MiniBossChargerLevel1_AttackType_AttackTypeInvalid = 0,
        MiniBossChargerLevel1_AttackType_AttackSimpleRotateBullet = 1,
        MiniBossChargerLevel1_AttackType_AttackFollowLaser = 2,
        MiniBossChargerLevel1_AttackType_AttackVortexLaser = 3,
        MiniBossChargerLevel1_AttackType_AttackCrossLaser = 4,
        MiniBossChargerLevel1_AttackType_AttackCrossBullet = 5,
        MiniBossChargerLevel1_AttackType_AttackMassLaser = 6,
        MiniBossChargerLevel1_AttackType_AttackVerticalRoundBullet = 7,
        MiniBossChargerLevel1_AttackType_AttackPyramidRoundBullet = 8,
        MiniBossChargerLevel1_AttackType_AttackPlaneUpDownBullet = 9,
        MiniBossChargerLevel1_AttackType_AttackTriangleBatteryBullet = 10,
        MiniBossChargerLevel1_AttackType_AttackPlayerFallBullet = 11,
        MiniBossChargerLevel1_AttackType_AttackGatlingRevolverBullet = 12,
        MiniBossChargerLevel1_AttackType_AttackWinderBullet = 13,
        MiniBossChargerLevel1_AttackType_AttackShotgunBullet = 14,
        MiniBossChargerLevel1_AttackType_AttackAirDropBullet = 15,
        MiniBossChargerLevel1_AttackType_AttackChaseShotObject = 16,
        MiniBossChargerLevel1_AttackType_AttackDiffuseLaser = 17,
        MiniBossChargerLevel1_AttackType_AttackChaseShot = 18,
        MiniBossChargerLevel1_AttackType_AttackTypeNum = 19
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct MiniBossChargerLevel1
    {
        [FieldOffset(0x00)] public float range;
        [FieldOffset(0x04)] public MiniBossChargerLevel1_AttackType attackTable__arr0;
        [FieldOffset(0x08)] public MiniBossChargerLevel1_AttackType attackTable__arr1;
        [FieldOffset(0x0C)] public int attackIndexTable__arr0;
        [FieldOffset(0x10)] public int attackIndexTable__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1AB0)]
    public struct MiniBossChargerConfig
    {
        [FieldOffset(0x00)] public MiniBossChargerCommonParam commonParam;
        [FieldOffset(0x15C0)] public MiniBossChargerLevelParam levelParams__arr0;
        [FieldOffset(0x15FC)] public MiniBossChargerLevelParam levelParams__arr1;
        [FieldOffset(0x1638)] public MiniBossChargerLevelParam levelParams__arr2;
        [FieldOffset(0x1674)] public MiniBossChargerLevelParam levelParams__arr3;
        [FieldOffset(0x16B0)] public MiniBossChargerLevelParam levelParams__arr4;
        [FieldOffset(0x16F0)] public MiniBossChargerLevelBand levelBands__arr0;
        [FieldOffset(0x17A8)] public MiniBossChargerLevelBand levelBands__arr1;
        [FieldOffset(0x1860)] public MiniBossChargerLevelBand levelBands__arr2;
        [FieldOffset(0x1918)] public MiniBossChargerLevelBand levelBands__arr3;
        [FieldOffset(0x19D0)] public MiniBossChargerLevelBand levelBands__arr4;
        [FieldOffset(0x1A88)] public MiniBossChargerLevel1 level1Params__arr0;
        [FieldOffset(0x1A9C)] public MiniBossChargerLevel1 level1Params__arr1;
    }

}