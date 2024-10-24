Library "PlayerParameters"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamOffensive
    {
        [FieldOffset(0x00)] public ushort pointMin;
        [FieldOffset(0x02)] public ushort pointMax;
        [FieldOffset(0x04)] public float damageRandomRate;
        [FieldOffset(0x08)] public float damageRandomRateSS;
        [FieldOffset(0x0C)] public float shapeDamageRate;
        [FieldOffset(0x10)] public float shapeStunRate;
        [FieldOffset(0x14)] public float shapeStaggerRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamDefensive
    {
        [FieldOffset(0x00)] public byte rateMin;
        [FieldOffset(0x01)] public byte rateMax;
        [FieldOffset(0x02)] public ushort infimumDropRings;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct PlayerParamAttackCommon
    {
        [FieldOffset(0x00)] public PlayerParamOffensive offensive;
        [FieldOffset(0x18)] public PlayerParamDefensive defensive;
        [FieldOffset(0x1C)] public float criticalDamageRate;
        [FieldOffset(0x20)] public float criticalRate;
        [FieldOffset(0x24)] public float criticalRateSS;
        [FieldOffset(0x28)] public float downedDamageRate;
    }

    public enum HitSE : sbyte
    {
        SE_None = -1,
        Weak = 0,
        Strong = 1,
        VeryStrong = 2
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

    [StructLayout(LayoutKind.Explicit, Size = 0x100)]
    public struct PlayerParamAttackData
    {
        [FieldOffset(0x00)] public float damageRate;
        [FieldOffset(0x04)] public float damageRateAcceleMode;
        [FieldOffset(0x08)] public float damageRateManual;
        [FieldOffset(0x0C)] public float stunPoint;
        [FieldOffset(0x10)] public float staggerPoint;
        [FieldOffset(0x20)] public Vector3 velocity;
        [FieldOffset(0x30)] public float velocityKeepTime;
        [FieldOffset(0x34)] public float velocityKeepTimeBrake;
        [FieldOffset(0x38)] public float svSpeedScale;
        [FieldOffset(0x3C)] public float svBrakeScale;
        [FieldOffset(0x40)] public float bsSpeedScale;
        [FieldOffset(0x44)] public float bsBrakeScale;
        [FieldOffset(0x48)] public float wsSpeedScale;
        [FieldOffset(0x4C)] public float wsBrakeScale;
        [FieldOffset(0x50)] public float addComboValue;
        [FieldOffset(0x54)] public float addComboValueAccele;
        [FieldOffset(0x60)] public Vector3 gimmickVelocity;
        [FieldOffset(0x70)] public float ignoreTime;
        [FieldOffset(0x74)] public uint attributes;
        [FieldOffset(0x78)] public HitSE se;
        [FieldOffset(0x80)] public UnmanagedString hitEffectName;
        [FieldOffset(0x90)] public UnmanagedString hitStopName;
        [FieldOffset(0xA0)] public UnmanagedString hitStopNameDead;
        [FieldOffset(0xB0)] public UnmanagedString hitStopNameDeadBoss;
        [FieldOffset(0xC0)] public UnmanagedString hitCameraShakeName;
        [FieldOffset(0xD0)] public UnmanagedString hitCameraShakeNameDead;
        [FieldOffset(0xE0)] public UnmanagedString hitCameraShakeNameDeadBoss;
        [FieldOffset(0xF0)] public UnmanagedString hitVibrationName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1230)]
    public struct PlayerParamAttack
    {
        [FieldOffset(0x00)] public PlayerParamAttackCommon common;
        [FieldOffset(0x30)] public PlayerParamAttackData spinAttack;
        [FieldOffset(0x130)] public PlayerParamAttackData spinDash;
        [FieldOffset(0x230)] public PlayerParamAttackData homingAttack;
        [FieldOffset(0x330)] public PlayerParamAttackData homingAttackAir;
        [FieldOffset(0x430)] public PlayerParamAttackData stomping;
        [FieldOffset(0x530)] public PlayerParamAttackData stompingAttack;
        [FieldOffset(0x630)] public PlayerParamAttackData boundStompingLast;
        [FieldOffset(0x730)] public PlayerParamAttackData sliding;
        [FieldOffset(0x830)] public PlayerParamAttackData boostAttack;
        [FieldOffset(0x930)] public PlayerParamAttackData warpAttack;
        [FieldOffset(0xA30)] public PlayerParamAttackData dblowRush;
        [FieldOffset(0xB30)] public PlayerParamAttackData dblowRushFinish;
        [FieldOffset(0xC30)] public PlayerParamAttackData dblowOff;
        [FieldOffset(0xD30)] public PlayerParamAttackData dblowUp;
        [FieldOffset(0xE30)] public PlayerParamAttackData dblowDown;
        [FieldOffset(0xF30)] public PlayerParamAttackData chaosSpear;
        [FieldOffset(0x1030)] public PlayerParamAttackData dsurf;
        [FieldOffset(0x1130)] public PlayerParamAttackData dsurfSpin;
    }

    public enum Condition : sbyte
    {
        Time = 0,
        Animation = 1
    }

    public enum Shape : sbyte
    {
        Sphere = 0,
        Cylinder = 1,
        Box = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct PlayerParamAttackCollider
    {
        [FieldOffset(0x00)] public Condition condition;
        [FieldOffset(0x01)] public sbyte count;
        [FieldOffset(0x04)] public float spanTime;
        [FieldOffset(0x08)] public Shape shape;
        [FieldOffset(0x10)] public Vector3 shapeSize;
        [FieldOffset(0x20)] public Vector3 shapeOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC0)]
    public struct PlayerParamStompingAttack
    {
        [FieldOffset(0x00)] public PlayerParamAttackCollider hit;
        [FieldOffset(0x30)] public PlayerParamAttackCollider hitLast;
        [FieldOffset(0x60)] public float riseTime;
        [FieldOffset(0x64)] public float flipSpeed;
        [FieldOffset(0x68)] public float motionTime;
        [FieldOffset(0x6C)] public float lastHitTime;
        [FieldOffset(0x70)] public float slowRatio;
        [FieldOffset(0x74)] public float minPressTime;
        [FieldOffset(0x78)] public float minPressTimeHeight;
        [FieldOffset(0x7C)] public float maxPressTime;
        [FieldOffset(0x80)] public float maxPressTimeHeight;
        [FieldOffset(0x90)] public Vector3 offset;
        [FieldOffset(0xA0)] public UnmanagedString cameraName;
        [FieldOffset(0xB0)] public UnmanagedString cameraNameBarrage;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamBehind
    {
        [FieldOffset(0x00)] public float moveTime;
        [FieldOffset(0x04)] public float moveTimeSS;
        [FieldOffset(0x08)] public float tangentScale;
        [FieldOffset(0x0C)] public float waitTime;
        [FieldOffset(0x10)] public float cameraTurnRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamWaterAct
    {
        [FieldOffset(0x00)] public float resistRate;
        [FieldOffset(0x04)] public float breatheBrake;
        [FieldOffset(0x08)] public float breatheTime;
        [FieldOffset(0x0C)] public float breatheGravity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamBaseJump
    {
        [FieldOffset(0x00)] public float baseSpeed;
        [FieldOffset(0x04)] public float upSpeed;
        [FieldOffset(0x08)] public float upSpeedAir;
        [FieldOffset(0x0C)] public float edgeSpeed;
        [FieldOffset(0x10)] public float airActionTime;
        [FieldOffset(0x14)] public float wallMoveTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PlayerParamBallMove
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float slidePower;
        [FieldOffset(0x08)] public float brakeForce;
        [FieldOffset(0x0C)] public float slidePowerSlalom;
        [FieldOffset(0x10)] public float brakeForceSlalom;
        [FieldOffset(0x14)] public float releaseSpeed;
        [FieldOffset(0x18)] public bool useInput;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamLocusData
    {
        [FieldOffset(0x00)] public float width;
        [FieldOffset(0x04)] public float distance;
        [FieldOffset(0x08)] public float u0;
        [FieldOffset(0x0C)] public float u1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamLocus
    {
        [FieldOffset(0x00)] public PlayerParamLocusData data__arr0;
        [FieldOffset(0x10)] public PlayerParamLocusData data__arr1;
        [FieldOffset(0x20)] public PlayerParamLocusData data__arr2;
        [FieldOffset(0x30)] public PlayerParamLocusData data__arr3;
    }

    public enum CameraShakeTiming : sbyte
    {
        StartCameraInterpolation = 0,
        EndCameraInterpolation = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct PlayerParamSlingshot
    {
        [FieldOffset(0x00)] public float timeScaleInMove;
        [FieldOffset(0x04)] public float hitStartRestTime;
        [FieldOffset(0x10)] public Vector3 hitCameraOffset;
        [FieldOffset(0x20)] public float hitCameraTimeEaseIn;
        [FieldOffset(0x24)] public float hitCameraFovyAngle;
        [FieldOffset(0x28)] public float hitTimeScaleValue;
        [FieldOffset(0x2C)] public float hitTimeScaleTimeEaseIn;
        [FieldOffset(0x30)] public float resetCameraEaseOutTime;
        [FieldOffset(0x34)] public float resetTimeScaleEaseOutTime;
        [FieldOffset(0x38)] public float timeScaleKeepTime;
        [FieldOffset(0x3C)] public float shotEffOffset;
        [FieldOffset(0x40)] public float hitEffOffset;
        [FieldOffset(0x44)] public CameraShakeTiming cameraShakeTiming;
        [FieldOffset(0x48)] public UnmanagedString cameraShakeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamAuraTrain
    {
        [FieldOffset(0x00)] public float effectSpanTime;
        [FieldOffset(0x04)] public float effectLifeTime;
        [FieldOffset(0x08)] public float effectOffsetDistance;
        [FieldOffset(0x0C)] public float effectOverlapDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamLevel
    {
        [FieldOffset(0x00)] public byte ringsLevel;
        [FieldOffset(0x01)] public byte speedLevel;
        [FieldOffset(0x02)] public byte offensiveLevel;
        [FieldOffset(0x03)] public byte defensiveLevel;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamBarrierWall
    {
        [FieldOffset(0x00)] public float coolTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamWarpAttack
    {
        [FieldOffset(0x00)] public PlayerParamAttackCollider hit;
        [FieldOffset(0x30)] public float rushWaitTime;
        [FieldOffset(0x34)] public float invincibleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamDBlowRush
    {
        [FieldOffset(0x00)] public PlayerParamAttackCollider hit;
        [FieldOffset(0x30)] public float invincibleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamDBlowRushFinish
    {
        [FieldOffset(0x00)] public PlayerParamAttackCollider hit;
        [FieldOffset(0x30)] public float invincibleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct PlayerParamDBlowOff
    {
        [FieldOffset(0x00)] public PlayerParamAttackCollider hit;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct PlayerParamDBlowUp
    {
        [FieldOffset(0x00)] public PlayerParamAttackCollider hit;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct PlayerParamDBlowDown
    {
        [FieldOffset(0x00)] public PlayerParamAttackCollider hit;
        [FieldOffset(0x30)] public PlayerParamAttackCollider hit2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamChaosSpear
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float accel;
        [FieldOffset(0x0C)] public float timeStopDamper;
        [FieldOffset(0x10)] public float timeStopAccel;
        [FieldOffset(0x14)] public float maxAngle;
        [FieldOffset(0x18)] public float minAngleDist;
        [FieldOffset(0x1C)] public float maxAngleDist;
        [FieldOffset(0x20)] public float homingSpeed;
        [FieldOffset(0x24)] public float life;
        [FieldOffset(0x28)] public float interval;
        [FieldOffset(0x2C)] public byte maxLockon;
        [FieldOffset(0x30)] public float lockonInterval;
        [FieldOffset(0x34)] public float lockonRangeMin;
        [FieldOffset(0x38)] public float lockonRangeMax;
        [FieldOffset(0x3C)] public float lockonRangeMaxExpand;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100)]
    public struct PlayerParamChaosSpearData
    {
        [FieldOffset(0x00)] public PlayerParamChaosSpear normal;
        [FieldOffset(0x40)] public PlayerParamChaosSpear slider;
        [FieldOffset(0x80)] public PlayerParamChaosSpear diving;
        [FieldOffset(0xC0)] public PlayerParamChaosSpear dsurf;
    }

    public struct ColorF
    {
        public float A;
        public float R;
        public float G;
        public float B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct PlayerParamMirageEffect
    {
        [FieldOffset(0x00)] public byte maxNum;
        [FieldOffset(0x04)] public ColorF mirageColor1;
        [FieldOffset(0x14)] public ColorF mirageColor2;
        [FieldOffset(0x24)] public float mirageDistance;
        [FieldOffset(0x28)] public float mirageTime;
        [FieldOffset(0x2C)] public float mirageSpeed;
        [FieldOffset(0x30)] public ColorF warpMirageColor1;
        [FieldOffset(0x40)] public ColorF warpMirageColor2;
        [FieldOffset(0x50)] public float warpStartMirageTime;
        [FieldOffset(0x54)] public float warpEndMirageTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamFacingData
    {
        [FieldOffset(0x00)] public float twistLimitAngle;
        [FieldOffset(0x04)] public float faceLimitAngle;
        [FieldOffset(0x08)] public float neckLimitAngle;
        [FieldOffset(0x0C)] public float activeAngle;
        [FieldOffset(0x10)] public float deactiveAngle;
        [FieldOffset(0x14)] public float easeRate;
        [FieldOffset(0x18)] public float easeTime;
        [FieldOffset(0x1C)] public float twistWeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x210)]
    public struct PlayerParamFacing
    {
        [FieldOffset(0x00)] public uint normal;
        [FieldOffset(0x04)] public uint stand;
        [FieldOffset(0x08)] public uint run;
        [FieldOffset(0x0C)] public uint fall;
        [FieldOffset(0x10)] public PlayerParamFacingData data__arr0;
        [FieldOffset(0x30)] public PlayerParamFacingData data__arr1;
        [FieldOffset(0x50)] public PlayerParamFacingData data__arr2;
        [FieldOffset(0x70)] public PlayerParamFacingData data__arr3;
        [FieldOffset(0x90)] public PlayerParamFacingData data__arr4;
        [FieldOffset(0xB0)] public PlayerParamFacingData data__arr5;
        [FieldOffset(0xD0)] public PlayerParamFacingData data__arr6;
        [FieldOffset(0xF0)] public PlayerParamFacingData data__arr7;
        [FieldOffset(0x110)] public PlayerParamFacingData data__arr8;
        [FieldOffset(0x130)] public PlayerParamFacingData data__arr9;
        [FieldOffset(0x150)] public PlayerParamFacingData data__arr10;
        [FieldOffset(0x170)] public PlayerParamFacingData data__arr11;
        [FieldOffset(0x190)] public PlayerParamFacingData data__arr12;
        [FieldOffset(0x1B0)] public PlayerParamFacingData data__arr13;
        [FieldOffset(0x1D0)] public PlayerParamFacingData data__arr14;
        [FieldOffset(0x1F0)] public PlayerParamFacingData data__arr15;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamEtc
    {
        [FieldOffset(0x00)] public float limitMoveMaxSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1900)]
    public struct CommonPackage
    {
        [FieldOffset(0x00)] public PlayerParamAttack attack;
        [FieldOffset(0x1230)] public PlayerParamStompingAttack stompingAttack;
        [FieldOffset(0x12F0)] public PlayerParamBehind behind;
        [FieldOffset(0x1304)] public PlayerParamWaterAct wateract;
        [FieldOffset(0x1314)] public PlayerParamBaseJump basejump;
        [FieldOffset(0x132C)] public PlayerParamBallMove ballmove;
        [FieldOffset(0x1348)] public PlayerParamLocus locus;
        [FieldOffset(0x1390)] public PlayerParamSlingshot slingshot;
        [FieldOffset(0x13F0)] public PlayerParamAuraTrain auratrain;
        [FieldOffset(0x1400)] public PlayerParamLevel level;
        [FieldOffset(0x1404)] public PlayerParamBarrierWall barrierWall;
        [FieldOffset(0x1410)] public PlayerParamWarpAttack warpAttack;
        [FieldOffset(0x1450)] public PlayerParamDBlowRush dblowRush;
        [FieldOffset(0x1490)] public PlayerParamDBlowRushFinish dblowRushFinish;
        [FieldOffset(0x14D0)] public PlayerParamDBlowOff dblowOff;
        [FieldOffset(0x1500)] public PlayerParamDBlowUp dblowUp;
        [FieldOffset(0x1530)] public PlayerParamDBlowDown dblowDown;
        [FieldOffset(0x1590)] public PlayerParamChaosSpearData chaosspear;
        [FieldOffset(0x1690)] public PlayerParamMirageEffect mirageeffect;
        [FieldOffset(0x16E8)] public PlayerParamFacing facing;
        [FieldOffset(0x18F8)] public PlayerParamEtc etc;
    }

    public enum SupportedPlane : sbyte
    {
        Flat = 0,
        Slope = 1,
        Wall = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct PlayerParamCommon
    {
        [FieldOffset(0x00)] public float movableMaxSlope;
        [FieldOffset(0x04)] public float activeLandingSlope;
        [FieldOffset(0x08)] public float activeLandingSlopeInBoost;
        [FieldOffset(0x0C)] public float landingMaxSlope;
        [FieldOffset(0x10)] public float slidingMaxSlope;
        [FieldOffset(0x14)] public float wallAngleMaxSlope;
        [FieldOffset(0x18)] public SupportedPlane onStand;
        [FieldOffset(0x19)] public SupportedPlane onRunInAir;
        [FieldOffset(0x1A)] public SupportedPlane onRun;
        [FieldOffset(0x1B)] public bool moveHolding;
        [FieldOffset(0x1C)] public bool wallSlideSlowInBoost;
        [FieldOffset(0x1D)] public bool attrWallOnGround;
        [FieldOffset(0x20)] public float priorityInputTime;
        [FieldOffset(0x24)] public int capacityRings;
        [FieldOffset(0x28)] public int capacityRingsLvMax;
        [FieldOffset(0x2C)] public float collectRingRange;
        [FieldOffset(0x30)] public float gravityCylinderDamper;
        [FieldOffset(0x34)] public float gravityCylinderEscapeAreaWidth;
        [FieldOffset(0x38)] public float gravityCylinderEscapeHeight;
        [FieldOffset(0x3C)] public float gravityCylinderEscapeAngle;
        [FieldOffset(0x40)] public float gravityCylinderEscapeDistance;
        [FieldOffset(0x44)] public float gravityCylinderEscapeDistanceV;
        [FieldOffset(0x48)] public float ringConsumptionInterval;
        [FieldOffset(0x4C)] public int ringConsumptionNum;
        [FieldOffset(0x50)] public float ringConsumptionInterval2;
        [FieldOffset(0x54)] public int ringConsumptionNum2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamSpeedData
    {
        [FieldOffset(0x00)] public float initial;
        [FieldOffset(0x04)] public float min;
        [FieldOffset(0x08)] public float max;
        [FieldOffset(0x0C)] public float minTurn;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamSpeedAcceleData
    {
        [FieldOffset(0x00)] public float force;
        [FieldOffset(0x04)] public float damperRange;
        [FieldOffset(0x08)] public float jerkMin;
        [FieldOffset(0x0C)] public float jerkMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct PlayerParamSpeed
    {
        [FieldOffset(0x00)] public PlayerParamSpeedData normal;
        [FieldOffset(0x10)] public PlayerParamSpeedData boost;
        [FieldOffset(0x20)] public PlayerParamSpeedData boostLvMax;
        [FieldOffset(0x30)] public float maxAirSpeed;
        [FieldOffset(0x34)] public float maxSpeedOver;
        [FieldOffset(0x38)] public float opitonMaxSpeedLimit;
        [FieldOffset(0x3C)] public float thresholdStopSpeed;
        [FieldOffset(0x40)] public float maxFallSpeed;
        [FieldOffset(0x44)] public PlayerParamSpeedAcceleData accele;
        [FieldOffset(0x54)] public PlayerParamSpeedAcceleData decele;
        [FieldOffset(0x64)] public float acceleAuto;
        [FieldOffset(0x68)] public float deceleAuto;
        [FieldOffset(0x6C)] public float turnDeceleAngleMin;
        [FieldOffset(0x70)] public float turnDeceleAngleMax;
        [FieldOffset(0x74)] public float maxGravityAccele;
        [FieldOffset(0x78)] public float maxGravityDecele;
        [FieldOffset(0x7C)] public float deceleSquat;
        [FieldOffset(0x80)] public float acceleSensitive;
        [FieldOffset(0x84)] public float boostAnimSpeedInWater;
        [FieldOffset(0x88)] public float startLoopSpeed;
        [FieldOffset(0x8C)] public float endLoopSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct PlayerParamRotation
    {
        [FieldOffset(0x00)] public float baseRotateForce;
        [FieldOffset(0x04)] public float baseRotateForceSpeed;
        [FieldOffset(0x08)] public float minRotateForce;
        [FieldOffset(0x0C)] public float maxRotateForce;
        [FieldOffset(0x10)] public bool angleRotateForceDecayEnabled;
        [FieldOffset(0x14)] public float frontRotateRatio;
        [FieldOffset(0x18)] public float rotationForceDecaySpeed;
        [FieldOffset(0x1C)] public float rotationForceDecayRate;
        [FieldOffset(0x20)] public float rotationForceDecayMax;
        [FieldOffset(0x24)] public float autorunRotateForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct PlayerParamRunning
    {
        [FieldOffset(0x00)] public float walkSpeed;
        [FieldOffset(0x04)] public float sneakingSpeed;
        [FieldOffset(0x08)] public float animSpeedSneak;
        [FieldOffset(0x0C)] public float animSpeedWalk;
        [FieldOffset(0x10)] public float animSpeedRun;
        [FieldOffset(0x14)] public float animSpeedBoost;
        [FieldOffset(0x18)] public float animLRBlendSampleTime;
        [FieldOffset(0x1C)] public float animLRBlendAngleMin;
        [FieldOffset(0x20)] public float animLRBlendAngleMax;
        [FieldOffset(0x24)] public float animLRBlendSpeed;
        [FieldOffset(0x28)] public float animLRBlendSpeedToCenter;
        [FieldOffset(0x2C)] public float minChangeWalkTime;
        [FieldOffset(0x30)] public float fallAnimationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamBalanceData
    {
        [FieldOffset(0x00)] public float rotateSpeedMinFB;
        [FieldOffset(0x04)] public float rotateSpeedMaxFB;
        [FieldOffset(0x08)] public float rotateSpeedMinLR;
        [FieldOffset(0x0C)] public float rotateSpeedMaxLR;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamBalance
    {
        [FieldOffset(0x00)] public PlayerParamBalanceData standard;
        [FieldOffset(0x10)] public PlayerParamBalanceData loop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PlayerParamBrake
    {
        [FieldOffset(0x00)] public float initialSpeedRatio;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float forceLand;
        [FieldOffset(0x0C)] public float forceLandBoost;
        [FieldOffset(0x10)] public float forceAir;
        [FieldOffset(0x14)] public float endSpeed;
        [FieldOffset(0x18)] public float stopTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamTurn
    {
        [FieldOffset(0x00)] public float thresholdSpeed;
        [FieldOffset(0x04)] public float thresholdAngle;
        [FieldOffset(0x08)] public float turnAfterSpeed;
        [FieldOffset(0x0C)] public bool stopEdge;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamJump
    {
        [FieldOffset(0x00)] public float preActionTime;
        [FieldOffset(0x04)] public float addForceTime;
        [FieldOffset(0x08)] public float force;
        [FieldOffset(0x0C)] public float addForce;
        [FieldOffset(0x10)] public float gravitySize;
        [FieldOffset(0x14)] public float disableDoubleJumpTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamLocalJump
    {
        [FieldOffset(0x00)] public float addForceTime;
        [FieldOffset(0x04)] public float force;
        [FieldOffset(0x08)] public float addForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamDWingJump
    {
        [FieldOffset(0x00)] public float addForceTime;
        [FieldOffset(0x04)] public float force;
        [FieldOffset(0x08)] public float addForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamJumpSpeed
    {
        [FieldOffset(0x00)] public float limitMin;
        [FieldOffset(0x04)] public float limitUpSpeed;
        [FieldOffset(0x08)] public float steeringSpeed1;
        [FieldOffset(0x0C)] public float steeringSpeed2;
        [FieldOffset(0x10)] public float startSteeringSpeed;
        [FieldOffset(0x14)] public float endSteeringSpeed;
        [FieldOffset(0x18)] public float speed;
        [FieldOffset(0x1C)] public float minSpeed;
        [FieldOffset(0x20)] public float minStickSpeed;
        [FieldOffset(0x24)] public float accel;
        [FieldOffset(0x28)] public float brake;
        [FieldOffset(0x2C)] public float damper;
        [FieldOffset(0x30)] public float minStickBrake;
        [FieldOffset(0x34)] public float maxStickBrake;
        [FieldOffset(0x38)] public float minStickBrakeAngle;
        [FieldOffset(0x3C)] public float maxStickBrakeAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamDoubleJump
    {
        [FieldOffset(0x00)] public float initialSpeed;
        [FieldOffset(0x04)] public float bounceSpeed;
        [FieldOffset(0x08)] public float limitSpeedMin;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct PlayerParamDWingDoubleJump
    {
        [FieldOffset(0x00)] public float force;
        [FieldOffset(0x04)] public float addForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct PlayerParamFall
    {
        [FieldOffset(0x00)] public float thresholdVertSpeed;
        [FieldOffset(0x04)] public float tolerateJumpTime;
        [FieldOffset(0x08)] public float fallEndDelayTime;
        [FieldOffset(0x0C)] public float fallEndFadeTime;
        [FieldOffset(0x10)] public float acceleForce;
        [FieldOffset(0x14)] public float deceleForce;
        [FieldOffset(0x18)] public float overSpeedDeceleForce;
        [FieldOffset(0x1C)] public float rotationForce;
        [FieldOffset(0x20)] public float rotationForceDecaySpeed;
        [FieldOffset(0x24)] public float rotationForceDecayRate;
        [FieldOffset(0x28)] public float rotationForceDecayMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamSpringFall
    {
        [FieldOffset(0x00)] public float thresholdHorzSpeed;
        [FieldOffset(0x04)] public float maxParallelSpeed;
        [FieldOffset(0x08)] public float parallelAccel;
        [FieldOffset(0x0C)] public float parallelBrake;
        [FieldOffset(0x10)] public float horzDamper;
        [FieldOffset(0x14)] public float turnSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamHomingRebound
    {
        [FieldOffset(0x00)] public float maxParallelSpeed;
        [FieldOffset(0x04)] public float parallelAccel;
        [FieldOffset(0x08)] public float parallelBrake;
        [FieldOffset(0x0C)] public float horzDamper;
        [FieldOffset(0x10)] public float turnSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamDamageCommon
    {
        [FieldOffset(0x00)] public float invincibleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamDamageNormal
    {
        [FieldOffset(0x00)] public float initialHorzSpeed;
        [FieldOffset(0x04)] public float initialVertSpeed;
        [FieldOffset(0x08)] public float deceleForce;
        [FieldOffset(0x0C)] public float transitFallTime;
        [FieldOffset(0x10)] public float gravityScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamDamageTurnBack
    {
        [FieldOffset(0x00)] public float fixedTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PlayerParamDamageBlowOff
    {
        [FieldOffset(0x00)] public float initialHorzSpeed;
        [FieldOffset(0x04)] public float initialVertSpeed;
        [FieldOffset(0x08)] public float deceleForceInAir;
        [FieldOffset(0x0C)] public float deceleForceOnGround;
        [FieldOffset(0x10)] public float gravityScale;
        [FieldOffset(0x14)] public float downTime;
        [FieldOffset(0x18)] public float transitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamDamageGuarded
    {
        [FieldOffset(0x00)] public float vertSpeed;
        [FieldOffset(0x04)] public float horzSpeed;
        [FieldOffset(0x08)] public float deceleForce;
        [FieldOffset(0x0C)] public float transitTime;
        [FieldOffset(0x10)] public float horzDamper;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamDamageRunning
    {
        [FieldOffset(0x00)] public float actionTime;
        [FieldOffset(0x04)] public float minSpeed;
        [FieldOffset(0x08)] public float lossSpeed;
        [FieldOffset(0x0C)] public float lossTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamDamageQuake
    {
        [FieldOffset(0x00)] public float actionTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamDamageLava
    {
        [FieldOffset(0x00)] public Vector3 jumpVelocity;
        [FieldOffset(0x10)] public float gravitySize;
        [FieldOffset(0x14)] public float invincibleTime;
        [FieldOffset(0x18)] public float noActionTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct PlayerParamDamage
    {
        [FieldOffset(0x00)] public PlayerParamDamageCommon common;
        [FieldOffset(0x04)] public PlayerParamDamageNormal normal;
        [FieldOffset(0x18)] public PlayerParamDamageTurnBack turnBack;
        [FieldOffset(0x1C)] public PlayerParamDamageBlowOff blowOff;
        [FieldOffset(0x38)] public PlayerParamDamageGuarded guarded;
        [FieldOffset(0x4C)] public PlayerParamDamageRunning running;
        [FieldOffset(0x5C)] public PlayerParamDamageQuake quake;
        [FieldOffset(0x60)] public PlayerParamDamageLava lava;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamDeadNormal
    {
        [FieldOffset(0x00)] public float invincibleTime;
        [FieldOffset(0x04)] public float initialHorzSpeed;
        [FieldOffset(0x08)] public float initialVertSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamDead
    {
        [FieldOffset(0x00)] public PlayerParamDeadNormal normal;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct PlayerParamSliding
    {
        [FieldOffset(0x00)] public float minSpeed;
        [FieldOffset(0x04)] public float endSpeed;
        [FieldOffset(0x08)] public float deceleJerk;
        [FieldOffset(0x0C)] public float deceleJerkContinue;
        [FieldOffset(0x10)] public float deceleForceMax;
        [FieldOffset(0x14)] public float baseRotateForce;
        [FieldOffset(0x18)] public float baseRotateForceSpeed;
        [FieldOffset(0x1C)] public float maxRotateForce;
        [FieldOffset(0x20)] public float frontRotateRatio;
        [FieldOffset(0x24)] public float rotationForceAutoRun;
        [FieldOffset(0x28)] public float movableMaxSlope;
        [FieldOffset(0x2C)] public float gravitySize;
        [FieldOffset(0x30)] public float minContinueTime;
        [FieldOffset(0x34)] public float maxAutoRunTime;
        [FieldOffset(0x38)] public float endSpeedAutoRun;
        [FieldOffset(0x3C)] public float loopKickTransitTime;
        [FieldOffset(0x40)] public float attackScale;
        [FieldOffset(0x50)] public Vector3 attackOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamStomping
    {
        [FieldOffset(0x00)] public float initialSpeed;
        [FieldOffset(0x04)] public float initialAccele;
        [FieldOffset(0x08)] public float maxAccele;
        [FieldOffset(0x0C)] public float jerk;
        [FieldOffset(0x10)] public float maxFallSpeed;
        [FieldOffset(0x14)] public float angle;
        [FieldOffset(0x18)] public float landingCancelTime;
        [FieldOffset(0x1C)] public float boundStompingCollisionScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct PlayerParamGrind
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float boostSpeed;
        [FieldOffset(0x08)] public float maxSpeed;
        [FieldOffset(0x0C)] public float maxOverSpeed;
        [FieldOffset(0x10)] public float acceleForce;
        [FieldOffset(0x14)] public float gravityForce;
        [FieldOffset(0x18)] public float overSpeedBrake;
        [FieldOffset(0x1C)] public float brake;
        [FieldOffset(0x20)] public bool updatePathPosition;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamFallSlope
    {
        [FieldOffset(0x00)] public float initialSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float maxSpeedAmoeba;
        [FieldOffset(0x0C)] public float brakeAngle;
        [FieldOffset(0x10)] public float highBrakeAngle;
        [FieldOffset(0x14)] public float brakeForce;
        [FieldOffset(0x18)] public float brakeForceHigh;
        [FieldOffset(0x1C)] public float stickBrakeForce;
        [FieldOffset(0x20)] public float gravitySize;
        [FieldOffset(0x24)] public float gravitySizeAir;
        [FieldOffset(0x28)] public float endSpeedFront;
        [FieldOffset(0x2C)] public float endSpeedBack;
        [FieldOffset(0x30)] public float reverseFallTime;
        [FieldOffset(0x34)] public float fallToSlipTime;
        [FieldOffset(0x38)] public float slipIdlingTime;
        [FieldOffset(0x3C)] public float minSlipTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamFallFlip
    {
        [FieldOffset(0x00)] public float thresholdSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float flipAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct PlayerParamTumble
    {
        [FieldOffset(0x00)] public bool enabled;
        [FieldOffset(0x04)] public float sideSpinAngle;
        [FieldOffset(0x08)] public float initialVertSpeed;
        [FieldOffset(0x0C)] public float gravitySize;
        [FieldOffset(0x10)] public float gravitySize2;
        [FieldOffset(0x14)] public float deceleForceInAir;
        [FieldOffset(0x18)] public float minSpeedInAir;
        [FieldOffset(0x1C)] public float rotateEaseTimeLeftRight;
        [FieldOffset(0x20)] public float rotateEaseTimeFrontBack;
        [FieldOffset(0x24)] public float rotateSpeedMinLeftRight;
        [FieldOffset(0x28)] public float rotateSpeedMaxLeftRight;
        [FieldOffset(0x2C)] public float rotateSpeedMinFrontBack;
        [FieldOffset(0x30)] public float rotateSpeedMaxFrontBack;
        [FieldOffset(0x34)] public float angleLeftRightStagger;
        [FieldOffset(0x38)] public float angleLeftRightRoll;
        [FieldOffset(0x3C)] public float angleFrontBackRoll;
        [FieldOffset(0x40)] public float angleBigRoll;
        [FieldOffset(0x44)] public float inRunTime;
        [FieldOffset(0x48)] public float inAirTime;
        [FieldOffset(0x4C)] public float rollSpeedFront;
        [FieldOffset(0x50)] public float bigRollVelocityRatio;
        [FieldOffset(0x54)] public float dropDashHoldTime;
        [FieldOffset(0x58)] public float airBrakeVertSpeed;
        [FieldOffset(0x5C)] public float airBrakeForce;
        [FieldOffset(0x60)] public float airTrickHeight;
        [FieldOffset(0x64)] public float airTrickTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSpinAttack
    {
        [FieldOffset(0x00)] public float jumpForce;
        [FieldOffset(0x04)] public float jumpAddForce;
        [FieldOffset(0x08)] public float addTime;
        [FieldOffset(0x0C)] public float acceleForce;
        [FieldOffset(0x10)] public float deceleForce;
        [FieldOffset(0x14)] public float brakeForce;
        [FieldOffset(0x18)] public float limitSpeedMin;
        [FieldOffset(0x1C)] public float limitSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamHomingAttackData
    {
        [FieldOffset(0x00)] public float speed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamHomingBounceData
    {
        [FieldOffset(0x00)] public float bounceVertSpeed;
        [FieldOffset(0x04)] public float bounceHorzSpeed;
        [FieldOffset(0x08)] public float bounceAcceleForce;
        [FieldOffset(0x0C)] public float bounceDeceleForce;
        [FieldOffset(0x10)] public float bounceAngleWidth;
        [FieldOffset(0x14)] public float bounceTime;
        [FieldOffset(0x18)] public float attackDownTime;
        [FieldOffset(0x1C)] public float attackDownTimeForStomp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4C)]
    public struct PlayerParamHomingAttack
    {
        [FieldOffset(0x00)] public PlayerParamHomingAttackData sonic;
        [FieldOffset(0x04)] public PlayerParamHomingBounceData sonicBounce;
        [FieldOffset(0x24)] public PlayerParamHomingBounceData sonicBounceWeak;
        [FieldOffset(0x44)] public float cameraEaseInTime;
        [FieldOffset(0x48)] public float cameraEaseOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamHitEnemy
    {
        [FieldOffset(0x00)] public float bounceVertSpeed;
        [FieldOffset(0x04)] public float bounceHorzSpeed;
        [FieldOffset(0x08)] public float attackDownTime;
        [FieldOffset(0x0C)] public float enableHomingTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct SpeedParam
    {
        [FieldOffset(0x00)] public float maxVertSpeed;
        [FieldOffset(0x04)] public float acceleVertForce;
        [FieldOffset(0x08)] public float maxHorzSpeed;
        [FieldOffset(0x0C)] public float acceleHorzForce;
        [FieldOffset(0x10)] public float deceleVertForce;
        [FieldOffset(0x14)] public float deceleHorzForce;
        [FieldOffset(0x18)] public float deceleNeutralForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct PlayerParamDiving
    {
        [FieldOffset(0x00)] public SpeedParam normal;
        [FieldOffset(0x1C)] public SpeedParam fast;
        [FieldOffset(0x38)] public SpeedParam damaged;
        [FieldOffset(0x54)] public SpeedParam ringdash;
        [FieldOffset(0x70)] public float startHeight;
        [FieldOffset(0x74)] public float startSpeed;
        [FieldOffset(0x78)] public float damageTime;
        [FieldOffset(0x7C)] public float ringdashTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamFan
    {
        [FieldOffset(0x00)] public float damperV;
        [FieldOffset(0x04)] public float damperH;
        [FieldOffset(0x08)] public float accelRate;
        [FieldOffset(0x0C)] public float moveForceFV;
        [FieldOffset(0x10)] public float moveForceSV;
        [FieldOffset(0x14)] public float jumpCheckSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct PlayerParamStorm
    {
        [FieldOffset(0x00)] public float damperV;
        [FieldOffset(0x04)] public float damperH;
        [FieldOffset(0x08)] public float brake;
        [FieldOffset(0x0C)] public float accelRate;
        [FieldOffset(0x10)] public float moveForce;
        [FieldOffset(0x14)] public float maxSpeedH;
        [FieldOffset(0x18)] public float maxSpeedV;
        [FieldOffset(0x1C)] public float rotateSpeed;
        [FieldOffset(0x20)] public float rotateAngularSpeed;
        [FieldOffset(0x24)] public float minDrawSpeed;
        [FieldOffset(0x28)] public float maxDrawSpeed;
        [FieldOffset(0x2C)] public float minDrawSpeedDistance;
        [FieldOffset(0x30)] public float maxDrawSpeedDistance;
        [FieldOffset(0x34)] public float damageTime;
        [FieldOffset(0x38)] public float damageNoBrakeTime;
        [FieldOffset(0x3C)] public float forceHomingReaction;
        [FieldOffset(0x40)] public float forceHomingReaction2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PlayerParamCloudJump
    {
        [FieldOffset(0x00)] public float acceleForce;
        [FieldOffset(0x04)] public float deceleForce;
        [FieldOffset(0x08)] public float overSpeedDeceleForce;
        [FieldOffset(0x0C)] public float rotationForce;
        [FieldOffset(0x10)] public float rotationForceDecaySpeed;
        [FieldOffset(0x14)] public float rotationForceDecayRate;
        [FieldOffset(0x18)] public float rotationForceDecayMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PlayerParamAirTrick
    {
        [FieldOffset(0x00)] public uint amount;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct PlayerParamDrift
    {
        [FieldOffset(0x00)] public float startAngle;
        [FieldOffset(0x04)] public float endSpeed;
        [FieldOffset(0x08)] public float minSpeed;
        [FieldOffset(0x0C)] public float minSpeedMax;
        [FieldOffset(0x10)] public float maxSpeed;
        [FieldOffset(0x14)] public float maxSpeedMax;
        [FieldOffset(0x18)] public float minBoostSpeed;
        [FieldOffset(0x1C)] public float minBoostSpeedMax;
        [FieldOffset(0x20)] public float maxBoostSpeed;
        [FieldOffset(0x24)] public float maxBoostSpeedMax;
        [FieldOffset(0x28)] public float accel;
        [FieldOffset(0x2C)] public float brake;
        [FieldOffset(0x30)] public float maxSteerAngle;
        [FieldOffset(0x34)] public float steerAccel;
        [FieldOffset(0x38)] public float maxSteerSpeed;
        [FieldOffset(0x3C)] public float neutralSteerAccel;
        [FieldOffset(0x40)] public float maxNeutralSteerSpeed;
        [FieldOffset(0x44)] public float maxRotateSpeed;
        [FieldOffset(0x48)] public float recoverTime;
        [FieldOffset(0x4C)] public float maxChargeTime;
        [FieldOffset(0x50)] public float minDashSpeed;
        [FieldOffset(0x54)] public float maxDashSpeed;
        [FieldOffset(0x58)] public float minDashJumpSpeed;
        [FieldOffset(0x5C)] public float maxDashJumpSpeed;
        [FieldOffset(0x60)] public float jumpSpeed;
        [FieldOffset(0x64)] public float checkFallTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct PlayerParamDriftAir
    {
        [FieldOffset(0x00)] public float startAngle;
        [FieldOffset(0x04)] public float endSpeed;
        [FieldOffset(0x08)] public float minSpeed;
        [FieldOffset(0x0C)] public float maxSpeed;
        [FieldOffset(0x10)] public float accel;
        [FieldOffset(0x14)] public float brake;
        [FieldOffset(0x18)] public float maxSteerAngle;
        [FieldOffset(0x1C)] public float steerAccel;
        [FieldOffset(0x20)] public float maxSteerSpeed;
        [FieldOffset(0x24)] public float neutralSteerAccel;
        [FieldOffset(0x28)] public float maxNeutralSteerSpeed;
        [FieldOffset(0x2C)] public float maxRotateSpeed;
        [FieldOffset(0x30)] public float recoverTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct PlayerParamDriftDash
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float brake;
        [FieldOffset(0x08)] public float steeringSpeed1;
        [FieldOffset(0x0C)] public float steeringSpeed2;
        [FieldOffset(0x10)] public float startSteeringSpeed;
        [FieldOffset(0x14)] public float endSteeringSpeed;
        [FieldOffset(0x18)] public float outOfControlSpeed;
        [FieldOffset(0x1C)] public float checkDashSpeed;
        [FieldOffset(0x20)] public float checkDashTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct PlayerParamDropDash
    {
        [FieldOffset(0x00)] public float maxChargeTime;
        [FieldOffset(0x04)] public float minDashSpeed;
        [FieldOffset(0x08)] public float minDashSpeedMax;
        [FieldOffset(0x0C)] public float maxDashSpeed;
        [FieldOffset(0x10)] public float maxDashSpeedMax;
        [FieldOffset(0x14)] public float tumbleDashSpeed;
        [FieldOffset(0x18)] public float maxSpeed;
        [FieldOffset(0x1C)] public float brake;
        [FieldOffset(0x20)] public float steeringSpeed1;
        [FieldOffset(0x24)] public float steeringSpeed2;
        [FieldOffset(0x28)] public float startSteeringSpeed;
        [FieldOffset(0x2C)] public float endSteeringSpeed;
        [FieldOffset(0x30)] public float outOfControlSpeed;
        [FieldOffset(0x34)] public float checkDashSpeed;
        [FieldOffset(0x38)] public float checkDashTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamBounceJump
    {
        [FieldOffset(0x00)] public float startSpeed;
        [FieldOffset(0x04)] public float jumpRate1;
        [FieldOffset(0x08)] public float jumpRate2;
        [FieldOffset(0x0C)] public float jumpRate3;
        [FieldOffset(0x10)] public float inoperableTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamLightDash
    {
        [FieldOffset(0x00)] public float dashSpeed;
        [FieldOffset(0x04)] public float dashSpeedMax;
        [FieldOffset(0x08)] public float speed;
        [FieldOffset(0x0C)] public float speedMax;
        [FieldOffset(0x10)] public float accel;
        [FieldOffset(0x14)] public float brake;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamBackflip
    {
        [FieldOffset(0x00)] public float jumpSpeed;
        [FieldOffset(0x04)] public float backSpeed;
        [FieldOffset(0x08)] public float downAccel;
        [FieldOffset(0x0C)] public float damperV;
        [FieldOffset(0x10)] public float damperH;
        [FieldOffset(0x14)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSquatMove
    {
        [FieldOffset(0x00)] public float startSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float accel;
        [FieldOffset(0x0C)] public float brake;
        [FieldOffset(0x10)] public float steeringSpeed1;
        [FieldOffset(0x14)] public float steeringSpeed2;
        [FieldOffset(0x18)] public float startSteeringSpeed;
        [FieldOffset(0x1C)] public float endSteeringSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSlowMove
    {
        [FieldOffset(0x00)] public float startSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float accel;
        [FieldOffset(0x0C)] public float brake;
        [FieldOffset(0x10)] public float damageSpeed;
        [FieldOffset(0x14)] public float damageBrake;
        [FieldOffset(0x18)] public float steeringSpeed;
        [FieldOffset(0x1C)] public float endSteeringSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamSpinDash
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float minSpeed;
        [FieldOffset(0x08)] public float deceleForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSpin
    {
        [FieldOffset(0x00)] public float startSlopeAngle;
        [FieldOffset(0x04)] public float endSlopeAngle;
        [FieldOffset(0x08)] public float startSpeed;
        [FieldOffset(0x0C)] public float endSpeed;
        [FieldOffset(0x10)] public float stickAngle;
        [FieldOffset(0x14)] public float brake;
        [FieldOffset(0x18)] public float forceBrake;
        [FieldOffset(0x1C)] public float maxSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x6C)]
    public struct PlayerParamWallMove
    {
        [FieldOffset(0x00)] public float walkSpeed;
        [FieldOffset(0x04)] public float boostSpeed;
        [FieldOffset(0x08)] public float minAccessSpeed;
        [FieldOffset(0x0C)] public float stickSpeed;
        [FieldOffset(0x10)] public float gravity;
        [FieldOffset(0x14)] public float accel;
        [FieldOffset(0x18)] public float brake;
        [FieldOffset(0x1C)] public float stopBrake;
        [FieldOffset(0x20)] public float fallSpeed;
        [FieldOffset(0x24)] public float steeringSpeed1;
        [FieldOffset(0x28)] public float steeringSpeed2;
        [FieldOffset(0x2C)] public float startSteeringSpeed;
        [FieldOffset(0x30)] public float endSteeringSpeed;
        [FieldOffset(0x34)] public float startTime;
        [FieldOffset(0x38)] public float useEnergySpeedBase;
        [FieldOffset(0x3C)] public float useEnergySpeedBaseOnMesh;
        [FieldOffset(0x40)] public float useEnergySpeedVal;
        [FieldOffset(0x44)] public float useEnergySpeedValOnMesh;
        [FieldOffset(0x48)] public float useEnergyAngle;
        [FieldOffset(0x4C)] public float useEnergyAngleOnMesh;
        [FieldOffset(0x50)] public float brakeStartEnergy;
        [FieldOffset(0x54)] public float brakeStartEnergyOnMesh;
        [FieldOffset(0x58)] public float homingSearchDistanceNear;
        [FieldOffset(0x5C)] public float homingSearchDistanceFar;
        [FieldOffset(0x60)] public float wallBumpHeightUpper;
        [FieldOffset(0x64)] public float wallBumpHeightUnder;
        [FieldOffset(0x68)] public float recoveryCheckTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct PlayerParamWallJump
    {
        [FieldOffset(0x00)] public float gravitySize;
        [FieldOffset(0x04)] public float minTime;
        [FieldOffset(0x08)] public float maxTime;
        [FieldOffset(0x0C)] public float stopTime;
        [FieldOffset(0x10)] public float maxDownSpeed;
        [FieldOffset(0x14)] public float fallGroundDistance;
        [FieldOffset(0x18)] public float frontForce;
        [FieldOffset(0x1C)] public float upForce;
        [FieldOffset(0x20)] public float impulseTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x54)]
    public struct PlayerParamClimbing
    {
        [FieldOffset(0x00)] public float stepSpeedFront;
        [FieldOffset(0x04)] public float stepSpeedFrontDash;
        [FieldOffset(0x08)] public float stepSpeedSide;
        [FieldOffset(0x0C)] public float stepSpeedSideDash;
        [FieldOffset(0x10)] public float stepSpeedBack;
        [FieldOffset(0x14)] public float stepDashRate;
        [FieldOffset(0x18)] public float maxAnimSpeed;
        [FieldOffset(0x1C)] public float exhaustAngle;
        [FieldOffset(0x20)] public float exhaustAngleOnMesh;
        [FieldOffset(0x24)] public float exhaustBase;
        [FieldOffset(0x28)] public float exhaustBaseOnMesh;
        [FieldOffset(0x2C)] public float exhaustRate;
        [FieldOffset(0x30)] public float exhaustRateOnMesh;
        [FieldOffset(0x34)] public float useGrabGaugeSpeed;
        [FieldOffset(0x38)] public float useGrabGaugeSpeedOnMesh;
        [FieldOffset(0x3C)] public float useGrabGaugeTurbo;
        [FieldOffset(0x40)] public float useGrabGaugeTurboOnMesh;
        [FieldOffset(0x44)] public float homingSearchDistanceNear;
        [FieldOffset(0x48)] public float homingSearchDistanceFar;
        [FieldOffset(0x4C)] public float resetAngle;
        [FieldOffset(0x50)] public float recoveryCheckTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamSlideDown
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float speedOnMesh;
        [FieldOffset(0x0C)] public float accel;
        [FieldOffset(0x10)] public float brake;
        [FieldOffset(0x14)] public float brakeOnMesh;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct PlayerParamBoarding
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float minSpeed;
        [FieldOffset(0x08)] public float damageSpeed;
        [FieldOffset(0x0C)] public float accel;
        [FieldOffset(0x10)] public float damageBrake;
        [FieldOffset(0x14)] public float damageBrakeTime;
        [FieldOffset(0x18)] public float damageMotionTime;
        [FieldOffset(0x1C)] public float damageInvicibleTime;
        [FieldOffset(0x20)] public float damper;
        [FieldOffset(0x24)] public float airDamperV;
        [FieldOffset(0x28)] public float airDamperH;
        [FieldOffset(0x2C)] public float gravity;
        [FieldOffset(0x30)] public float airJumpSpeed;
        [FieldOffset(0x34)] public float groundJumpSpeed;
        [FieldOffset(0x38)] public float airAccel;
        [FieldOffset(0x3C)] public float maxAirAddSpeed;
        [FieldOffset(0x40)] public float downForceRate;
        [FieldOffset(0x44)] public float steeringSpeed1;
        [FieldOffset(0x48)] public float steeringSpeed2;
        [FieldOffset(0x4C)] public float steeringSpeed3;
        [FieldOffset(0x50)] public float startSteeringSpeed;
        [FieldOffset(0x54)] public float endSteeringSpeed;
        [FieldOffset(0x58)] public float startSpeed;
        [FieldOffset(0x5C)] public float startSlope;
        [FieldOffset(0x60)] public float staticStartSlope;
        [FieldOffset(0x64)] public float finishSlope;
        [FieldOffset(0x68)] public float finishTime;
        [FieldOffset(0x6C)] public float bigLandTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamSlowWalk
    {
        [FieldOffset(0x00)] public float minSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float accel;
        [FieldOffset(0x0C)] public float brake;
        [FieldOffset(0x10)] public float brakeSteeringAngle;
        [FieldOffset(0x14)] public float steeringSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct PlayerParamJog
    {
        [FieldOffset(0x00)] public float startSpeed;
        [FieldOffset(0x04)] public float minSpeed;
        [FieldOffset(0x08)] public float maxSpeed;
        [FieldOffset(0x0C)] public float accel;
        [FieldOffset(0x10)] public float brake;
        [FieldOffset(0x14)] public float maxBrake;
        [FieldOffset(0x18)] public float brakeSteeringAngle;
        [FieldOffset(0x1C)] public float stopSteeringSpeed;
        [FieldOffset(0x20)] public float steeringSpeed;
        [FieldOffset(0x24)] public float skatingStartInputLength;
        [FieldOffset(0x28)] public float skatingStartInputAngle;
        [FieldOffset(0x2C)] public float skatingStartInputTime;
        [FieldOffset(0x30)] public float skatingStartSpeed;
        [FieldOffset(0x34)] public float skatingStartAccel;
        [FieldOffset(0x38)] public float wallBreakawaySpeed;
        [FieldOffset(0x3C)] public float startAnimSpeed;
        [FieldOffset(0x40)] public float animSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct PlayerParamSkate
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float overSpeed;
        [FieldOffset(0x08)] public float accel;
        [FieldOffset(0x0C)] public float brake;
        [FieldOffset(0x10)] public float maxBrake;
        [FieldOffset(0x14)] public float steeringSpeed;
        [FieldOffset(0x18)] public float steeringSpeed2;
        [FieldOffset(0x1C)] public float steeringBrake;
        [FieldOffset(0x20)] public float minSteeringBrakeAngle;
        [FieldOffset(0x24)] public float maxSteeringBrakeAngle;
        [FieldOffset(0x28)] public float animSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PlayerParamShiftRun
    {
        [FieldOffset(0x00)] public float startSpeed;
        [FieldOffset(0x04)] public float shiftRate;
        [FieldOffset(0x08)] public float jumpSpeed;
        [FieldOffset(0x0C)] public float airJumpSpeedFront;
        [FieldOffset(0x10)] public float airJumpSpeedSide;
        [FieldOffset(0x14)] public float airJumpSpeedDown;
        [FieldOffset(0x18)] public float cameraAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct PlayerParamBoostCamera
    {
        [FieldOffset(0x00)] public float effectTime;
        [FieldOffset(0x04)] public float peakTime;
        [FieldOffset(0x08)] public float endTime;
        [FieldOffset(0x0C)] public float maxFovy;
        [FieldOffset(0x10)] public float minFovy;
    }

    public enum BlurType : sbyte
    {
        BLURTYPE_PREV_SURFACE = 0,
        BLURTYPE_RADIAL = 1,
        BLURTYPE_CAMERA = 2,
        BLURTYPE_COUNT = 3
    }

    public enum FocusType : sbyte
    {
        FOCUSTYPE_CENTER = 0,
        FOCUSTYPE_LOOKAT = 1,
        FOCUSTYPE_USER_SETTING = 2,
        FOCUSTYPE_COUNT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct PlayerParamBoostBlur
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public BlurType blurType;
        [FieldOffset(0x04)] public float blurPower;
        [FieldOffset(0x08)] public FocusType focusType;
        [FieldOffset(0x10)] public Vector3 focusPosition;
        [FieldOffset(0x20)] public float focusRange;
        [FieldOffset(0x24)] public float alphaSlope;
        [FieldOffset(0x28)] public int sampleNum;
        [FieldOffset(0x2C)] public float easeInTime;
        [FieldOffset(0x30)] public float easeOutTime;
        [FieldOffset(0x34)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xB0)]
    public struct PlayerParamBoost
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float startSpeed;
        [FieldOffset(0x08)] public float accel;
        [FieldOffset(0x0C)] public float landingAccel;
        [FieldOffset(0x10)] public float initialConsumptionValue;
        [FieldOffset(0x14)] public float initialConsumptionValueAir;
        [FieldOffset(0x18)] public float consumptionSpeed;
        [FieldOffset(0x1C)] public float consumptionSpeedAir;
        [FieldOffset(0x20)] public float consumptionSpeedEx;
        [FieldOffset(0x24)] public float recoverySpeed;
        [FieldOffset(0x28)] public float recoveryInterval;
        [FieldOffset(0x2C)] public float recoveryByRing;
        [FieldOffset(0x30)] public float recoveryByAttack;
        [FieldOffset(0x34)] public float endSpeed;
        [FieldOffset(0x38)] public float endSpeedTime;
        [FieldOffset(0x3C)] public float attackScale;
        [FieldOffset(0x40)] public Vector3 attackOffset;
        [FieldOffset(0x50)] public PlayerParamBoostCamera camera;
        [FieldOffset(0x70)] public PlayerParamBoostBlur blur;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct PlayerParamAirBoost
    {
        [FieldOffset(0x00)] public float startHSpeed;
        [FieldOffset(0x04)] public float startVSpeed;
        [FieldOffset(0x08)] public float minHSpeed;
        [FieldOffset(0x0C)] public float brakeTime;
        [FieldOffset(0x10)] public float minKeepTime;
        [FieldOffset(0x14)] public float maxKeepTime;
        [FieldOffset(0x18)] public float maxTime;
        [FieldOffset(0x1C)] public float gravityRate;
        [FieldOffset(0x20)] public float steeringSpeed;
        [FieldOffset(0x24)] public float additionalTransitTime;
        [FieldOffset(0x28)] public float finishTime;
        [FieldOffset(0x2C)] public float attackTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamAutorun
    {
        [FieldOffset(0x00)] public float initialSideSpeed;
        [FieldOffset(0x04)] public float acceleSideForce;
        [FieldOffset(0x08)] public float deceleSideForce;
        [FieldOffset(0x0C)] public float maxSideSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct PlayerParamSlider
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float accel;
        [FieldOffset(0x08)] public float damper;
        [FieldOffset(0x0C)] public float gravity;
        [FieldOffset(0x10)] public float jumpSpeed;
        [FieldOffset(0x14)] public float jumpCheckTime;
        [FieldOffset(0x18)] public float jumpRotateRate;
        [FieldOffset(0x1C)] public float jumpDownForceRate;
        [FieldOffset(0x20)] public float jumpHorzDamper;
        [FieldOffset(0x24)] public float downForceRate;
        [FieldOffset(0x28)] public float steeringSpeed1;
        [FieldOffset(0x2C)] public float steeringSpeed2;
        [FieldOffset(0x30)] public float steeringSpeed3;
        [FieldOffset(0x34)] public float startSteeringSpeed;
        [FieldOffset(0x38)] public float endSteeringSpeed;
        [FieldOffset(0x3C)] public float damageSpeed;
        [FieldOffset(0x40)] public float damageBrake;
        [FieldOffset(0x44)] public float damageTime;
        [FieldOffset(0x48)] public float damageInvincibleTime;
        [FieldOffset(0x4C)] public float pathForce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSideStep
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float brakeForce;
        [FieldOffset(0x08)] public float motionSpeedRatio;
        [FieldOffset(0x0C)] public float stepSpeed;
        [FieldOffset(0x10)] public float maxStepDistance;
        [FieldOffset(0x14)] public float minStepDistance;
        [FieldOffset(0x18)] public float maxStepSpeed;
        [FieldOffset(0x1C)] public float minStepSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PlayerParamSideStep2
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float brakeForce;
        [FieldOffset(0x08)] public float motionSpeedRatio;
        [FieldOffset(0x0C)] public float stepSpeed;
        [FieldOffset(0x10)] public float maxStepDistance;
        [FieldOffset(0x14)] public float minStepDistance;
        [FieldOffset(0x18)] public float maxStepSpeed;
        [FieldOffset(0x1C)] public float minStepSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct PlayerParamQuickStep
    {
        [FieldOffset(0x00)] public float needSpeed;
        [FieldOffset(0x04)] public float acceleForce;
        [FieldOffset(0x08)] public float acceleSideForce;
        [FieldOffset(0x0C)] public float stepInitialSpeed;
        [FieldOffset(0x10)] public float avoidForce;
        [FieldOffset(0x14)] public float justBoostForce;
        [FieldOffset(0x18)] public float justBoostMax;
        [FieldOffset(0x1C)] public float justBoostTime;
        [FieldOffset(0x20)] public float justBoostBrake;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct PlayerParamParry
    {
        [FieldOffset(0x00)] public float minRecieveTime;
        [FieldOffset(0x04)] public float maxRecieveTime;
        [FieldOffset(0x08)] public float frozenTime;
        [FieldOffset(0x0C)] public float justEffectEasein;
        [FieldOffset(0x10)] public float justEffectEaseout;
        [FieldOffset(0x14)] public float justEffectTime;
        [FieldOffset(0x18)] public float justEffectEasein2;
        [FieldOffset(0x1C)] public float justEffectEaseout2;
        [FieldOffset(0x20)] public float justEffectTime2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamAvoidData
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float damper;
        [FieldOffset(0x08)] public float parryTime;
        [FieldOffset(0x0C)] public float invincibleTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x94)]
    public struct PlayerParamAvoid
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float fixedTime;
        [FieldOffset(0x08)] public float reentryInputPriorityTime;
        [FieldOffset(0x0C)] public float reentryTime;
        [FieldOffset(0x10)] public float frontAngle;
        [FieldOffset(0x14)] public float backAngle;
        [FieldOffset(0x18)] public float addFallSpeed;
        [FieldOffset(0x1C)] public PlayerParamAvoidData data__arr0;
        [FieldOffset(0x2C)] public PlayerParamAvoidData data__arr1;
        [FieldOffset(0x3C)] public PlayerParamAvoidData data__arr2;
        [FieldOffset(0x4C)] public PlayerParamAvoidData data__arr3;
        [FieldOffset(0x5C)] public PlayerParamAvoidData data__arr4;
        [FieldOffset(0x6C)] public PlayerParamAvoidData data__arr5;
        [FieldOffset(0x7C)] public PlayerParamAvoidData data__arr6;
        [FieldOffset(0x8C)] public float baseDistance;
        [FieldOffset(0x90)] public float limitAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamTimeStop
    {
        [FieldOffset(0x00)] public float consumptionSpeed;
        [FieldOffset(0x04)] public float searchPathDistance;
        [FieldOffset(0x08)] public float startMargin;
        [FieldOffset(0x0C)] public int gaugeMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamPhotonDash
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float accel;
        [FieldOffset(0x08)] public float fixSpeed;
        [FieldOffset(0x0C)] public float finishTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamJumpDash
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float keepVelocityTime;
        [FieldOffset(0x08)] public float brakeTime;
        [FieldOffset(0x0C)] public float damper;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamRunOnWater
    {
        [FieldOffset(0x00)] public float startSpeed;
        [FieldOffset(0x04)] public float sinkSpeed;
        [FieldOffset(0x08)] public float fallSpeed;
        [FieldOffset(0x0C)] public float vSpeed;
        [FieldOffset(0x10)] public float brake;
        [FieldOffset(0x14)] public float sinkWidth;
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4C)]
    public struct PlayerParamDBlow
    {
        [FieldOffset(0x00)] public float maxAimTime;
        [FieldOffset(0x04)] public float minAimTime;
        [FieldOffset(0x08)] public float maxChaseTime;
        [FieldOffset(0x0C)] public float limitAimAngleH;
        [FieldOffset(0x10)] public float limitAimAngleV;
        [FieldOffset(0x14)] public float aimSpeed;
        [FieldOffset(0x18)] public float aimCameraDistanceScale;
        [FieldOffset(0x1C)] public float aimCameraUpOffset;
        [FieldOffset(0x20)] public float aimCameraLeftOffset;
        [FieldOffset(0x24)] public float aimCameraAngle;
        [FieldOffset(0x28)] public float blowOffCameraChaseRate;
        [FieldOffset(0x2C)] public bool aimByRightStick;
        [FieldOffset(0x2D)] public bool aimReverseH;
        [FieldOffset(0x2E)] public bool aimReverseV;
        [FieldOffset(0x30)] public float aimLineWidth;
        [FieldOffset(0x34)] public float aimLineLength;
        [FieldOffset(0x38)] public float aimLineScrollSpeed;
        [FieldOffset(0x3C)] public Color8 aimLineColor1;
        [FieldOffset(0x40)] public Color8 aimLineColor2;
        [FieldOffset(0x44)] public float aimTargetSearchDistance;
        [FieldOffset(0x48)] public float aimTargetSearchAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x160)]
    public struct PlayerParamDSurf
    {
        [FieldOffset(0x00)] public float maxSpeed;
        [FieldOffset(0x04)] public float minSpeed;
        [FieldOffset(0x08)] public float overSpeed;
        [FieldOffset(0x0C)] public float gravityAccel;
        [FieldOffset(0x10)] public float minTurnSpeed;
        [FieldOffset(0x14)] public float accel;
        [FieldOffset(0x18)] public float brake;
        [FieldOffset(0x1C)] public float steeringBrake;
        [FieldOffset(0x20)] public float brakeAngle;
        [FieldOffset(0x24)] public float maxSteeringBrakeAngle;
        [FieldOffset(0x28)] public bool cameraTurn;
        [FieldOffset(0x2C)] public float steeringSpeed1;
        [FieldOffset(0x30)] public float steeringSpeed2;
        [FieldOffset(0x34)] public float steeringSpeedAir;
        [FieldOffset(0x38)] public float startSteeringSpeed;
        [FieldOffset(0x3C)] public float endSteeringSpeed;
        [FieldOffset(0x40)] public float steeringAssistSpeed;
        [FieldOffset(0x44)] public float steeringAssistAngle;
        [FieldOffset(0x48)] public float spring;
        [FieldOffset(0x4C)] public float airSpringRate;
        [FieldOffset(0x50)] public float damper;
        [FieldOffset(0x54)] public float resetDepth;
        [FieldOffset(0x58)] public float jumpSpeed;
        [FieldOffset(0x5C)] public float virticalJumpSpeed;
        [FieldOffset(0x60)] public float virticalMoveSpeed;
        [FieldOffset(0x64)] public float virticalMoveAccel;
        [FieldOffset(0x68)] public float virticalMoveBrake;
        [FieldOffset(0x6C)] public float virticalRotateSpeed;
        [FieldOffset(0x70)] public float damageVSpeed;
        [FieldOffset(0x74)] public float damageHSpeed;
        [FieldOffset(0x78)] public float wallHitAngle;
        [FieldOffset(0x7C)] public float wallHitSpeed;
        [FieldOffset(0x80)] public float finishDamper;
        [FieldOffset(0x84)] public float waterFlowRate;
        [FieldOffset(0x88)] public float maxSideSpeedFV;
        [FieldOffset(0x8C)] public float sideAccelFV;
        [FieldOffset(0x90)] public float sideBrakeFV;
        [FieldOffset(0x94)] public float maxSideSpeedAirFV;
        [FieldOffset(0x98)] public float sideAccelAirFV;
        [FieldOffset(0x9C)] public float sideBrakeAirFV;
        [FieldOffset(0xA0)] public float frontStickAngleFV;
        [FieldOffset(0xA4)] public float maxSpeedSV;
        [FieldOffset(0xA8)] public float minSpeedSV;
        [FieldOffset(0xAC)] public float accelSV;
        [FieldOffset(0xB0)] public float brakeSV;
        [FieldOffset(0xB4)] public float sideAccelSV;
        [FieldOffset(0xB8)] public float maxSideSpeedSV;
        [FieldOffset(0xBC)] public float stompingFallSpeed;
        [FieldOffset(0xC0)] public float startDashSpeed;
        [FieldOffset(0xC4)] public float startDashTime;
        [FieldOffset(0xC8)] public float startDashStartTime;
        [FieldOffset(0xCC)] public float dashCheckStartTime;
        [FieldOffset(0xD0)] public float dashCheckEndTime;
        [FieldOffset(0xD4)] public float dashEffectTime;
        [FieldOffset(0xD8)] public float waterDepth;
        [FieldOffset(0xDC)] public float wallHitTime;
        [FieldOffset(0xE0)] public float turnSpeed;
        [FieldOffset(0xE4)] public float turnDamper;
        [FieldOffset(0xE8)] public float attackScale;
        [FieldOffset(0xF0)] public Vector3 attackOffset;
        [FieldOffset(0x100)] public PlayerParamBoostCamera camera;
        [FieldOffset(0x120)] public PlayerParamBoostBlur blur;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct PlayerParamDSurfSpinParam
    {
        [FieldOffset(0x00)] public float outOfControlTime;
        [FieldOffset(0x04)] public float cancelTime;
        [FieldOffset(0x08)] public float cancelJumpTime;
        [FieldOffset(0x0C)] public float cancelMoveTime;
        [FieldOffset(0x10)] public float cancelBrakeTime;
        [FieldOffset(0x14)] public float speed;
        [FieldOffset(0x18)] public float minSpeed;
        [FieldOffset(0x1C)] public float speedKeepTime;
        [FieldOffset(0x20)] public float brake;
        [FieldOffset(0x24)] public float brakeTime;
        [FieldOffset(0x28)] public float time;
        [FieldOffset(0x2C)] public float forceBrake;
        [FieldOffset(0x30)] public float attackTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct PlayerParamDSurfSpin
    {
        [FieldOffset(0x00)] public float checkTime;
        [FieldOffset(0x04)] public float flightTime;
        [FieldOffset(0x08)] public PlayerParamDSurfSpinParam front;
        [FieldOffset(0x3C)] public PlayerParamDSurfSpinParam side;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct PlayerParamDSurfSpinSV
    {
        [FieldOffset(0x00)] public float flightTime;
        [FieldOffset(0x04)] public PlayerParamDSurfSpinParam param;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct PlayerParamDAmoeba
    {
        [FieldOffset(0x00)] public float minSpeed;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float accel;
        [FieldOffset(0x0C)] public float moveAccel;
        [FieldOffset(0x10)] public float brake;
        [FieldOffset(0x14)] public float damper;
        [FieldOffset(0x18)] public float groundDamper;
        [FieldOffset(0x1C)] public float groundBrake;
        [FieldOffset(0x20)] public float cancelTime;
        [FieldOffset(0x24)] public float cancelDist;
        [FieldOffset(0x28)] public float cancelSpeed;
        [FieldOffset(0x2C)] public float steeringSpeed1;
        [FieldOffset(0x30)] public float steeringSpeed2;
        [FieldOffset(0x34)] public float startSteeringSpeed;
        [FieldOffset(0x38)] public float endSteeringSpeed;
        [FieldOffset(0x3C)] public float steeringBrake;
        [FieldOffset(0x40)] public float steeringBrakeSpeed;
        [FieldOffset(0x44)] public float minSteeringBrakeAngle;
        [FieldOffset(0x48)] public float maxSteeringBrakeAngle;
        [FieldOffset(0x4C)] public float turnSpeed;
        [FieldOffset(0x50)] public float jumpSpeed;
        [FieldOffset(0x54)] public float minJumpSpeedH;
        [FieldOffset(0x58)] public float maxLandingSpeed;
        [FieldOffset(0x5C)] public float minLandingSpeed;
        [FieldOffset(0x60)] public float landingSpeedRate;
        [FieldOffset(0x64)] public float minDashSpeed;
        [FieldOffset(0x68)] public float maxDashSpeed;
        [FieldOffset(0x6C)] public float dashKeepSpeedTime;
        [FieldOffset(0x70)] public float dashOutOfControlTime;
        [FieldOffset(0x74)] public float dashInterval;
        [FieldOffset(0x78)] public float damageInvincibleTime;
        [FieldOffset(0x7C)] public float attackScale;
        [FieldOffset(0x80)] public Vector3 attackOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct PlayerParamDAmoebaAir
    {
        [FieldOffset(0x00)] public float damperSpeed;
        [FieldOffset(0x04)] public float damper;
        [FieldOffset(0x08)] public float steeringSpeed1;
        [FieldOffset(0x0C)] public float steeringSpeed2;
        [FieldOffset(0x10)] public float startSteeringSpeed;
        [FieldOffset(0x14)] public float endSteeringSpeed;
        [FieldOffset(0x18)] public float minSpeed;
        [FieldOffset(0x1C)] public float accel;
        [FieldOffset(0x20)] public float rotateSpeed;
        [FieldOffset(0x24)] public float svBrake;
        [FieldOffset(0x28)] public float bossDamper;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct PlayerParamDAmoebaHoming
    {
        [FieldOffset(0x00)] public float damper;
        [FieldOffset(0x04)] public float catchTime;
        [FieldOffset(0x08)] public float shrinkTime;
        [FieldOffset(0x0C)] public float swingSpeed;
        [FieldOffset(0x10)] public float swingRadius;
        [FieldOffset(0x14)] public float limitSwingRadius;
        [FieldOffset(0x18)] public float swingDamper;
        [FieldOffset(0x1C)] public float shrinkSpring;
        [FieldOffset(0x20)] public float shrinkDamper;
        [FieldOffset(0x24)] public float maxShrinkSpeed;
        [FieldOffset(0x28)] public float gravity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamDWingGuardParam
    {
        [FieldOffset(0x00)] public float backSpeed;
        [FieldOffset(0x04)] public float damper;
        [FieldOffset(0x08)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamDWingGuard
    {
        [FieldOffset(0x00)] public PlayerParamDWingGuardParam normal;
        [FieldOffset(0x0C)] public PlayerParamDWingGuardParam tornado;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct PlayerParamDWingFlinch
    {
        [FieldOffset(0x00)] public float backSpeed;
        [FieldOffset(0x04)] public float damper;
        [FieldOffset(0x08)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PlayerParamWaterFlow
    {
        [FieldOffset(0x00)] public float brake;
        [FieldOffset(0x04)] public float flowBrake;
        [FieldOffset(0x08)] public float spring;
        [FieldOffset(0x0C)] public float damper;
        [FieldOffset(0x10)] public float outOfControlTime;
        [FieldOffset(0x14)] public float returnDistance;
        [FieldOffset(0x18)] public float returnTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct PlayerParamSlalomStep
    {
        [FieldOffset(0x00)] public float startSpeed;
        [FieldOffset(0x04)] public float startAngle;
        [FieldOffset(0x08)] public float searchTime1;
        [FieldOffset(0x0C)] public float searchTime2;
        [FieldOffset(0x10)] public float searchTime3;
        [FieldOffset(0x14)] public float wallOffset;
        [FieldOffset(0x18)] public float wallOffsetMin;
        [FieldOffset(0x1C)] public float wallOffsetMax;
        [FieldOffset(0x20)] public float justStepTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct PlayerParamGliding
    {
        [FieldOffset(0x00)] public float rollSpeed;
        [FieldOffset(0x04)] public float pitchSpeed;
        [FieldOffset(0x08)] public float neutralRollSpeed;
        [FieldOffset(0x0C)] public float neutralPitchSpeed;
        [FieldOffset(0x10)] public float maxRollAngle;
        [FieldOffset(0x14)] public float maxPitchUpAngle;
        [FieldOffset(0x18)] public float maxPitchDownAngle;
        [FieldOffset(0x1C)] public float rollingSpeed;
        [FieldOffset(0x20)] public float rollingDamper;
        [FieldOffset(0x24)] public float rollingTime;
        [FieldOffset(0x28)] public float initialSpeed;
        [FieldOffset(0x2C)] public float maxSideSpeed;
        [FieldOffset(0x30)] public float maxBoostSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE0)]
    public struct PlayerParamGliding2
    {
        [FieldOffset(0x00)] public float fallSpeed;
        [FieldOffset(0x04)] public float fallAccel;
        [FieldOffset(0x08)] public float maxSteerSpeed;
        [FieldOffset(0x0C)] public float gravity;
        [FieldOffset(0x10)] public float stickThreshold;
        [FieldOffset(0x14)] public float lostSpeedPitchSpeed;
        [FieldOffset(0x18)] public float recoverPitchSpeed;
        [FieldOffset(0x1C)] public float recoverAngle;
        [FieldOffset(0x20)] public float yawSpeed;
        [FieldOffset(0x24)] public float yawAssistSpeed;
        [FieldOffset(0x28)] public float yawAssistAngle;
        [FieldOffset(0x2C)] public float height;
        [FieldOffset(0x30)] public float startHeight;
        [FieldOffset(0x34)] public float startTime;
        [FieldOffset(0x38)] public float outOfControlTime;
        [FieldOffset(0x3C)] public float rollingAttackTime;
        [FieldOffset(0x40)] public float exAccel;
        [FieldOffset(0x44)] public float exBrake;
        [FieldOffset(0x48)] public float exDamper;
        [FieldOffset(0x4C)] public float initialAccel;
        [FieldOffset(0x50)] public float boostAccel;
        [FieldOffset(0x54)] public float pathFixSpeed;
        [FieldOffset(0x58)] public float debuffSpeedRate;
        [FieldOffset(0x5C)] public float debuffSideSpeedRate;
        [FieldOffset(0x60)] public float maxRollBrakeRate;
        [FieldOffset(0x64)] public float attackScale;
        [FieldOffset(0x70)] public Vector3 attackOffset;
        [FieldOffset(0x80)] public float boostRate;
        [FieldOffset(0x84)] public PlayerParamBoostCamera camera;
        [FieldOffset(0xA0)] public PlayerParamBoostBlur blur;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct PlayerParamChaosSpearAir
    {
        [FieldOffset(0x00)] public float damper;
        [FieldOffset(0x04)] public float maxSpeed;
        [FieldOffset(0x08)] public float accel;
        [FieldOffset(0x0C)] public float brake;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1100)]
    public struct ModePackage
    {
        [FieldOffset(0x00)] public PlayerParamCommon common;
        [FieldOffset(0x58)] public PlayerParamSpeed speed;
        [FieldOffset(0xE8)] public PlayerParamRotation rotation;
        [FieldOffset(0x110)] public PlayerParamRunning running;
        [FieldOffset(0x144)] public PlayerParamBalance balance;
        [FieldOffset(0x164)] public PlayerParamBrake brake;
        [FieldOffset(0x180)] public PlayerParamTurn turn;
        [FieldOffset(0x190)] public PlayerParamJump jump;
        [FieldOffset(0x1A8)] public PlayerParamLocalJump localjump;
        [FieldOffset(0x1B4)] public PlayerParamDWingJump dwingjump;
        [FieldOffset(0x1C0)] public PlayerParamJumpSpeed jumpSpeed;
        [FieldOffset(0x200)] public PlayerParamDoubleJump doubleJump;
        [FieldOffset(0x20C)] public PlayerParamDWingDoubleJump dwingdoublejump;
        [FieldOffset(0x214)] public PlayerParamFall fall;
        [FieldOffset(0x240)] public PlayerParamSpringFall springfall;
        [FieldOffset(0x258)] public PlayerParamHomingRebound homingrebound;
        [FieldOffset(0x270)] public PlayerParamDamage damage;
        [FieldOffset(0x2F0)] public PlayerParamDead dead;
        [FieldOffset(0x300)] public PlayerParamSliding sliding;
        [FieldOffset(0x360)] public PlayerParamStomping stomping;
        [FieldOffset(0x380)] public PlayerParamGrind grind;
        [FieldOffset(0x3A4)] public PlayerParamFallSlope fallSlope;
        [FieldOffset(0x3E4)] public PlayerParamFallFlip fallFlip;
        [FieldOffset(0x3F0)] public PlayerParamTumble tumble;
        [FieldOffset(0x458)] public PlayerParamSpinAttack spinAttack;
        [FieldOffset(0x478)] public PlayerParamHomingAttack homingAttack;
        [FieldOffset(0x4C4)] public PlayerParamHitEnemy hitEnemy;
        [FieldOffset(0x4D4)] public PlayerParamDiving diving;
        [FieldOffset(0x554)] public PlayerParamFan fan;
        [FieldOffset(0x56C)] public PlayerParamStorm storm;
        [FieldOffset(0x5B0)] public PlayerParamCloudJump cloudJump;
        [FieldOffset(0x5CC)] public PlayerParamAirTrick airtrick;
        [FieldOffset(0x5D0)] public PlayerParamDrift drift;
        [FieldOffset(0x638)] public PlayerParamDriftAir driftair;
        [FieldOffset(0x66C)] public PlayerParamDriftDash driftDash;
        [FieldOffset(0x690)] public PlayerParamDropDash dropDash;
        [FieldOffset(0x6CC)] public PlayerParamBounceJump bounceJump;
        [FieldOffset(0x6E0)] public PlayerParamLightDash lightDash;
        [FieldOffset(0x6F8)] public PlayerParamBackflip backflip;
        [FieldOffset(0x710)] public PlayerParamSquatMove squatmove;
        [FieldOffset(0x730)] public PlayerParamSlowMove slowmove;
        [FieldOffset(0x750)] public PlayerParamSpinDash spindash;
        [FieldOffset(0x75C)] public PlayerParamSpin spin;
        [FieldOffset(0x77C)] public PlayerParamWallMove wallmove;
        [FieldOffset(0x7E8)] public PlayerParamWallJump walljump;
        [FieldOffset(0x80C)] public PlayerParamClimbing climbing;
        [FieldOffset(0x860)] public PlayerParamSlideDown slidedown;
        [FieldOffset(0x878)] public PlayerParamBoarding boarding;
        [FieldOffset(0x8E8)] public PlayerParamSlowWalk slowwalk;
        [FieldOffset(0x900)] public PlayerParamJog jog;
        [FieldOffset(0x944)] public PlayerParamSkate skate;
        [FieldOffset(0x970)] public PlayerParamShiftRun shiftrun;
        [FieldOffset(0x990)] public PlayerParamBoost boost;
        [FieldOffset(0xA40)] public PlayerParamAirBoost airboost;
        [FieldOffset(0xA70)] public PlayerParamAutorun autorun;
        [FieldOffset(0xA80)] public PlayerParamSlider slider;
        [FieldOffset(0xAD0)] public PlayerParamSideStep sidestep;
        [FieldOffset(0xAF0)] public PlayerParamSideStep2 sidestep2;
        [FieldOffset(0xB10)] public PlayerParamQuickStep quickstep;
        [FieldOffset(0xB34)] public PlayerParamParry parry;
        [FieldOffset(0xB58)] public PlayerParamAvoid avoid;
        [FieldOffset(0xBEC)] public PlayerParamTimeStop timestop;
        [FieldOffset(0xBFC)] public PlayerParamPhotonDash photondash;
        [FieldOffset(0xC0C)] public PlayerParamJumpDash jumpdash;
        [FieldOffset(0xC1C)] public PlayerParamRunOnWater runonwater;
        [FieldOffset(0xC34)] public PlayerParamDBlow dblow;
        [FieldOffset(0xC80)] public PlayerParamDSurf dsurf;
        [FieldOffset(0xDE0)] public PlayerParamDSurfSpin dsurfspin;
        [FieldOffset(0xE50)] public PlayerParamDSurfSpinSV dsurfspinsv;
        [FieldOffset(0xE90)] public PlayerParamDAmoeba damoeba;
        [FieldOffset(0xF20)] public PlayerParamDAmoebaAir damoebaair;
        [FieldOffset(0xF4C)] public PlayerParamDAmoebaHoming damoebahoming;
        [FieldOffset(0xF78)] public PlayerParamDWingGuard dwingguard;
        [FieldOffset(0xF90)] public PlayerParamDWingFlinch dwingflinch;
        [FieldOffset(0xF9C)] public PlayerParamWaterFlow waterflow;
        [FieldOffset(0xFB8)] public PlayerParamSlalomStep slalomstep;
        [FieldOffset(0xFDC)] public PlayerParamGliding gliding;
        [FieldOffset(0x1010)] public PlayerParamGliding2 gliding2;
        [FieldOffset(0x10F0)] public PlayerParamChaosSpearAir chaosspearair;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x5D00)]
    public struct PlayerParameters
    {
        [FieldOffset(0x00)] public CommonPackage common;
        [FieldOffset(0x1900)] public ModePackage forwardView;
        [FieldOffset(0x2A00)] public ModePackage sideView;
        [FieldOffset(0x3B00)] public ModePackage boss;
        [FieldOffset(0x4C00)] public ModePackage whiteSpace;
    }

}