Library "BossPerfectblackdoomConfigPhase3"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct BossPerfectblackdoomFinalAutorunParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float radius;
        [FieldOffset(0x08)] public float areaAspectRatio;
        [FieldOffset(0x0C)] public float bossSpeedMax;
        [FieldOffset(0x10)] public float bossSpeedMin;
        [FieldOffset(0x14)] public float bossAccelSpeed;
        [FieldOffset(0x18)] public float bossDecelSpeed;
        [FieldOffset(0x1C)] public float bossKeepDistanceDefault;
        [FieldOffset(0x20)] public float bossKeepDistanceLimit;
        [FieldOffset(0x24)] public float bossDefalutDistanceReturnTime;
        [FieldOffset(0x28)] public float bossDefalutDistanceReturnSpeed;
        [FieldOffset(0x2C)] public float boostChangeDistanceSpeed;
        [FieldOffset(0x30)] public float boostChangeDistRatioReturnTime;
        [FieldOffset(0x34)] public float enableHormingDistance;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BossPerfectblackdoomBattleLockOnCameraParam
    {
        [FieldOffset(0x00)] public UnmanagedString nodeName;
        [FieldOffset(0x10)] public Vector3 offset;
        [FieldOffset(0x20)] public float playerHeightOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossPerfectblackdoomFinalPlayerBlowParam
    {
        [FieldOffset(0x00)] public float playerBlowPower;
        [FieldOffset(0x04)] public float playerBlowUpPower;
        [FieldOffset(0x08)] public float playerBlowDeceleration;
        [FieldOffset(0x0C)] public float playerBlowGravityPower;
        [FieldOffset(0x10)] public float playerBlowTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct BossPerfectblackdoomPointCameraParam
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float fovy;
        [FieldOffset(0x08)] public float toPointDistanceMin;
        [FieldOffset(0x0C)] public float toPointDistanceMax;
        [FieldOffset(0x10)] public float distanceMin;
        [FieldOffset(0x14)] public float distanceMax;
        [FieldOffset(0x18)] public float gravityOffsetMin;
        [FieldOffset(0x1C)] public float gravityOffsetMax;
        [FieldOffset(0x20)] public Vector3 playerOffsetMin;
        [FieldOffset(0x30)] public Vector3 playerOffsetMax;
        [FieldOffset(0x40)] public Vector3 worldOffsetMin;
        [FieldOffset(0x50)] public Vector3 worldOffsetMax;
        [FieldOffset(0x60)] public Vector3 pointLocalOffsetMin;
        [FieldOffset(0x70)] public Vector3 pointLocalOffsetMax;
        [FieldOffset(0x80)] public UnmanagedString nodeName;
        [FieldOffset(0x90)] public float roll;
        [FieldOffset(0x94)] public float easeInTime;
        [FieldOffset(0x98)] public float easeOutTime;
        [FieldOffset(0x9C)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x230)]
    public struct BossPerfectblackdoomFinalRushParam
    {
        [FieldOffset(0x00)] public float rushTime;
        [FieldOffset(0x10)] public Vector3 bossBlowPos;
        [FieldOffset(0x20)] public float bossBlowTime;
        [FieldOffset(0x24)] public float bossBlowResetTime;
        [FieldOffset(0x28)] public float endKeepDistance;
        [FieldOffset(0x2C)] public float endKeepDistanceTime;
        [FieldOffset(0x30)] public BossPerfectblackdoomFinalPlayerBlowParam blowParam;
        [FieldOffset(0x50)] public BossPerfectblackdoomPointCameraParam cameraBody;
        [FieldOffset(0xF0)] public BossPerfectblackdoomPointCameraParam cameraEyeF;
        [FieldOffset(0x190)] public BossPerfectblackdoomPointCameraParam cameraEyeB;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossPerfectblackdoomFinalStunParamPatternData
    {
        [FieldOffset(0x00)] public float stunTime;
        [FieldOffset(0x04)] public float keepDistane;
        [FieldOffset(0x08)] public float changeKeepDistanceSpeed;
        [FieldOffset(0x0C)] public float boostChangeKeepDistanceSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct BossPerfectblackdoomFinalStunParam
    {
        [FieldOffset(0x00)] public float hormingDistanceOffsetBody;
        [FieldOffset(0x04)] public float endKeepDistane;
        [FieldOffset(0x08)] public float endChangeKeepDistanceSpeed;
        [FieldOffset(0x0C)] public BossPerfectblackdoomFinalStunParamPatternData pattern__arr0;
        [FieldOffset(0x1C)] public BossPerfectblackdoomFinalStunParamPatternData pattern__arr1;
        [FieldOffset(0x2C)] public BossPerfectblackdoomFinalStunParamPatternData pattern__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BossPerfectblackdoomFinalDownParam
    {
        [FieldOffset(0x00)] public float downTime;
        [FieldOffset(0x04)] public float hormingDistanceOffset;
        [FieldOffset(0x08)] public float bossBlowTime;
        [FieldOffset(0x10)] public Vector3 bossBlowPos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BossPerfectblackdoomFinalAmoebaMultiRainLaser
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool actionGuide;
        [FieldOffset(0x02)] public bool playSE;
        [FieldOffset(0x03)] public bool playMuzzleEff;
        [FieldOffset(0x04)] public float shotDelayTime;
        [FieldOffset(0x10)] public Vector3 direction;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x190)]
    public struct BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo
    {
        [FieldOffset(0x00)] public bool disableCollider;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float maxSpeed;
        [FieldOffset(0x0C)] public float minSpeed;
        [FieldOffset(0x10)] public float accel;
        [FieldOffset(0x14)] public float hormingSpeed;
        [FieldOffset(0x18)] public float hormingMaxSpeed;
        [FieldOffset(0x1C)] public float hormingMinSpeed;
        [FieldOffset(0x20)] public float hormingAccel;
        [FieldOffset(0x24)] public float angularSpeedMaxDeg;
        [FieldOffset(0x28)] public float straightTime;
        [FieldOffset(0x2C)] public float deadWaitTime;
        [FieldOffset(0x30)] public float reflectDeadWaitTime;
        [FieldOffset(0x40)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr0;
        [FieldOffset(0x60)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr1;
        [FieldOffset(0x80)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr2;
        [FieldOffset(0xA0)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr3;
        [FieldOffset(0xC0)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr4;
        [FieldOffset(0xE0)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr5;
        [FieldOffset(0x100)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr6;
        [FieldOffset(0x120)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr7;
        [FieldOffset(0x140)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr8;
        [FieldOffset(0x160)] public BossPerfectblackdoomFinalAmoebaMultiRainLaser laser__arr9;
        [FieldOffset(0x180)] public bool debugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BossPerfectblackdoomFinalAmoebaMultiRainLocalMove
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public uint useNo;
        [FieldOffset(0x08)] public float delayTime;
        [FieldOffset(0x0C)] public float moveTime;
        [FieldOffset(0x10)] public Vector3 localPosition;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossPerfectblackdoomFinalAmoebaMultiRainLaserTable
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public uint laserInfoNo;
        [FieldOffset(0x08)] public float delayTime;
        [FieldOffset(0x0C)] public uint loopNum;
        [FieldOffset(0x10)] public float loopDelayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x160)]
    public struct BossPerfectblackdoomFinalAmoebaMultiRainPatternData
    {
        [FieldOffset(0x00)] public float actionTime;
        [FieldOffset(0x04)] public float finishDelayTime;
        [FieldOffset(0x10)] public BossPerfectblackdoomFinalAmoebaMultiRainLocalMove localMoveInfo__arr0;
        [FieldOffset(0x30)] public BossPerfectblackdoomFinalAmoebaMultiRainLocalMove localMoveInfo__arr1;
        [FieldOffset(0x50)] public BossPerfectblackdoomFinalAmoebaMultiRainLocalMove localMoveInfo__arr2;
        [FieldOffset(0x70)] public BossPerfectblackdoomFinalAmoebaMultiRainLocalMove localMoveInfo__arr3;
        [FieldOffset(0x90)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr0;
        [FieldOffset(0xA4)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr1;
        [FieldOffset(0xB8)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr2;
        [FieldOffset(0xCC)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr3;
        [FieldOffset(0xE0)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr4;
        [FieldOffset(0xF4)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr5;
        [FieldOffset(0x108)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr6;
        [FieldOffset(0x11C)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr7;
        [FieldOffset(0x130)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr8;
        [FieldOffset(0x144)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserTable laserInfoTable__arr9;
        [FieldOffset(0x158)] public int changeStunLaserReflectNum;
        [FieldOffset(0x15C)] public bool debugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct BossPerfectblackdoomFinalAutoRunGlindParam
    {
        [FieldOffset(0x00)] public float rollSpeed;
        [FieldOffset(0x04)] public float pitchSpeed;
        [FieldOffset(0x08)] public float neutralRollSpeed;
        [FieldOffset(0x0C)] public float neutralPitchSpeed;
        [FieldOffset(0x10)] public float maxRollAngle;
        [FieldOffset(0x14)] public float maxPitchUpAngle;
        [FieldOffset(0x18)] public float maxPitchDownAngle;
        [FieldOffset(0x1C)] public float initialSpeed;
        [FieldOffset(0x20)] public float maxBoostSpeed;
        [FieldOffset(0x24)] public float maxSideSpeed;
        [FieldOffset(0x28)] public float areaAspectRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1440)]
    public struct BossPerfectblackdoomFinalAmoebaMultiRainParam
    {
        [FieldOffset(0x00)] public float keepDistance;
        [FieldOffset(0x04)] public float changeDistanceTime;
        [FieldOffset(0x08)] public float keepDistanceMax;
        [FieldOffset(0x0C)] public float endChangeDistanceTime;
        [FieldOffset(0x10)] public float endKeepDistanceNormal;
        [FieldOffset(0x14)] public float boostChangeKeepDistanceSpeed;
        [FieldOffset(0x18)] public float localMoveResetMoveTime;
        [FieldOffset(0x1C)] public float rotBodySpeed;
        [FieldOffset(0x20)] public float rotResetTime;
        [FieldOffset(0x24)] public float attackStartDelay;
        [FieldOffset(0x28)] public float attackEndMinElevation;
        [FieldOffset(0x2C)] public float attackEndMaxElevation;
        [FieldOffset(0x30)] public Vector3 laserCreateOffset;
        [FieldOffset(0x40)] public int laserBlowDamagePoint;
        [FieldOffset(0x44)] public int laserKillRingNum;
        [FieldOffset(0x50)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr0;
        [FieldOffset(0x1E0)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr1;
        [FieldOffset(0x370)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr2;
        [FieldOffset(0x500)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr3;
        [FieldOffset(0x690)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr4;
        [FieldOffset(0x820)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr5;
        [FieldOffset(0x9B0)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr6;
        [FieldOffset(0xB40)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr7;
        [FieldOffset(0xCD0)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr8;
        [FieldOffset(0xE60)] public BossPerfectblackdoomFinalAmoebaMultiRainLaserInfo laserInfo__arr9;
        [FieldOffset(0xFF0)] public BossPerfectblackdoomFinalAmoebaMultiRainPatternData pattern__arr0;
        [FieldOffset(0x1150)] public BossPerfectblackdoomFinalAmoebaMultiRainPatternData pattern__arr1;
        [FieldOffset(0x12B0)] public BossPerfectblackdoomFinalAmoebaMultiRainPatternData pattern__arr2;
        [FieldOffset(0x1410)] public BossPerfectblackdoomFinalAutoRunGlindParam endAccelGlindParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BossPerfectblackdoomFinalTornadoAbsorbParam
    {
        [FieldOffset(0x00)] public float startAbsorbTime;
        [FieldOffset(0x04)] public float playerMoveTime;
        [FieldOffset(0x08)] public float maxRadiusMoveTime;
        [FieldOffset(0x0C)] public float minRadiusMoveTime;
        [FieldOffset(0x10)] public float maxAbsorbSpeedTime;
        [FieldOffset(0x14)] public float maxAbsorbSpeed;
        [FieldOffset(0x18)] public float minAbsorbSpeed;
        [FieldOffset(0x1C)] public float absorbRotateSpeed;
        [FieldOffset(0x20)] public float moveRadius;
        [FieldOffset(0x24)] public float startKeepActionTime;
        [FieldOffset(0x28)] public float pathPositionMoveTime;
        [FieldOffset(0x30)] public Vector3 playerMovePos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossPerfectblackdoomFinalTornadoHitPlayerParam
    {
        [FieldOffset(0x00)] public float blowTime;
        [FieldOffset(0x04)] public float angularSpeedDeg;
        [FieldOffset(0x08)] public float backMoveSpeed;
        [FieldOffset(0x0C)] public float radiusMinSpeed;
        [FieldOffset(0x10)] public float backMoveDistMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct BossPerfectblackdoomFinalTornadoFocusCameraParam
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float startDelay;
        [FieldOffset(0x08)] public float easeInTime;
        [FieldOffset(0x0C)] public float easeOutTime;
        [FieldOffset(0x10)] public float keepTime;
        [FieldOffset(0x14)] public float targetOffsetDistance;
        [FieldOffset(0x18)] public float distance;
        [FieldOffset(0x1C)] public float roll;
        [FieldOffset(0x20)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct BossPerfectblackdoomFinalWingTornadoRingCircleInfo
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float radius;
        [FieldOffset(0x08)] public uint num;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct BossPerfectblackdoomFinalWingTornadoRingCirclePatternData
    {
        [FieldOffset(0x00)] public BossPerfectblackdoomFinalWingTornadoRingCircleInfo circleInfo__arr0;
        [FieldOffset(0x0C)] public BossPerfectblackdoomFinalWingTornadoRingCircleInfo circleInfo__arr1;
        [FieldOffset(0x18)] public BossPerfectblackdoomFinalWingTornadoRingCircleInfo circleInfo__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct BossPerfectblackdoomFinalWingTornadoMoveInfo
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public uint useNumber;
        [FieldOffset(0x08)] public uint ringNum;
        [FieldOffset(0x0C)] public float verticalOffset;
        [FieldOffset(0x10)] public float horizontalOffset;
        [FieldOffset(0x14)] public float offsetMaxRingNo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossPerfectblackdoomFinalWingTornadoCreateRingInfo
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public uint nodeNo;
        [FieldOffset(0x08)] public float waitTime;
        [FieldOffset(0x0C)] public uint num;
        [FieldOffset(0x10)] public uint pattern;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xF0)]
    public struct BossPerfectblackdoomFinalWingTornadoPatternData
    {
        [FieldOffset(0x00)] public float attackAfterKeepDistance;
        [FieldOffset(0x04)] public float attackAfterDistanceChangeSpeed;
        [FieldOffset(0x08)] public float boostChangeKeepDistanceSpeed;
        [FieldOffset(0x0C)] public float tornadoRingCreateTime;
        [FieldOffset(0x10)] public int finishWarpLocatorNo;
        [FieldOffset(0x14)] public BossPerfectblackdoomFinalWingTornadoMoveInfo tornadoMoveInfo__arr0;
        [FieldOffset(0x2C)] public BossPerfectblackdoomFinalWingTornadoMoveInfo tornadoMoveInfo__arr1;
        [FieldOffset(0x44)] public BossPerfectblackdoomFinalWingTornadoMoveInfo tornadoMoveInfo__arr2;
        [FieldOffset(0x5C)] public BossPerfectblackdoomFinalWingTornadoMoveInfo tornadoMoveInfo__arr3;
        [FieldOffset(0x74)] public BossPerfectblackdoomFinalWingTornadoMoveInfo tornadoMoveInfo__arr4;
        [FieldOffset(0x8C)] public BossPerfectblackdoomFinalWingTornadoCreateRingInfo ringCreateInfo__arr0;
        [FieldOffset(0xA0)] public BossPerfectblackdoomFinalWingTornadoCreateRingInfo ringCreateInfo__arr1;
        [FieldOffset(0xB4)] public BossPerfectblackdoomFinalWingTornadoCreateRingInfo ringCreateInfo__arr2;
        [FieldOffset(0xC8)] public BossPerfectblackdoomFinalWingTornadoCreateRingInfo ringCreateInfo__arr3;
        [FieldOffset(0xDC)] public BossPerfectblackdoomFinalWingTornadoCreateRingInfo ringCreateInfo__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x470)]
    public struct BossPerfectblackdoomFinalWingTornadoParam
    {
        [FieldOffset(0x00)] public BossPerfectblackdoomFinalTornadoAbsorbParam absorbParam;
        [FieldOffset(0x40)] public BossPerfectblackdoomFinalTornadoHitPlayerParam hitPlayerParam;
        [FieldOffset(0x54)] public float keepDistance;
        [FieldOffset(0x58)] public float changeDistanceTime;
        [FieldOffset(0x5C)] public float endKeepDistanceNormal;
        [FieldOffset(0x60)] public float endChangeDistanceTime;
        [FieldOffset(0x64)] public float actionEndDelay;
        [FieldOffset(0x68)] public float endWarpDelay;
        [FieldOffset(0x6C)] public float attackWaitTime;
        [FieldOffset(0x70)] public float hormingDistanceOffset;
        [FieldOffset(0x80)] public Vector3 tornadoSpawnPosoffset;
        [FieldOffset(0x90)] public float tornadoMoveSpeed;
        [FieldOffset(0x94)] public float tornadoMoveSpeedMax;
        [FieldOffset(0x98)] public float tornadoMoveAccel;
        [FieldOffset(0x9C)] public BossPerfectblackdoomFinalTornadoFocusCameraParam camera;
        [FieldOffset(0xC0)] public BossPerfectblackdoomFinalWingTornadoRingCirclePatternData ringCirclePattern__arr0;
        [FieldOffset(0xE4)] public BossPerfectblackdoomFinalWingTornadoRingCirclePatternData ringCirclePattern__arr1;
        [FieldOffset(0x108)] public BossPerfectblackdoomFinalWingTornadoRingCirclePatternData ringCirclePattern__arr2;
        [FieldOffset(0x12C)] public BossPerfectblackdoomFinalWingTornadoRingCirclePatternData ringCirclePattern__arr3;
        [FieldOffset(0x150)] public BossPerfectblackdoomFinalWingTornadoRingCirclePatternData ringCirclePattern__arr4;
        [FieldOffset(0x174)] public BossPerfectblackdoomFinalWingTornadoPatternData tornadRingPattern__arr0;
        [FieldOffset(0x264)] public BossPerfectblackdoomFinalWingTornadoPatternData tornadRingPattern__arr1;
        [FieldOffset(0x354)] public BossPerfectblackdoomFinalWingTornadoPatternData tornadRingPattern__arr2;
        [FieldOffset(0x444)] public BossPerfectblackdoomFinalAutoRunGlindParam endAccelGlindParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct BossPerfectblackdoomFinalSplashBlowWarpInfo
    {
        [FieldOffset(0x00)] public int patternNo;
        [FieldOffset(0x04)] public int locatorNo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BossPerfectblackdoomFinalSplashBlowCameraInfo
    {
        [FieldOffset(0x00)] public int patternNo;
        [FieldOffset(0x04)] public float azimuthOffset;
        [FieldOffset(0x08)] public float elevationOffset;
        [FieldOffset(0x0C)] public float distanceOffset;
        [FieldOffset(0x10)] public Vector3 targetOffset;
        [FieldOffset(0x20)] public float startDelayTime;
        [FieldOffset(0x24)] public float offsetTime;
        [FieldOffset(0x28)] public float easeInTime;
        [FieldOffset(0x2C)] public float easeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct BossPerfectblackdoomFinalSplashBlowHitCamera
    {
        [FieldOffset(0x00)] public Vector3 firstEyeLocalOffset;
        [FieldOffset(0x10)] public Vector3 firstLookAtLocalOffset;
        [FieldOffset(0x20)] public Vector3 secondEyeLocalOffset;
        [FieldOffset(0x30)] public Vector3 secondLookAtLocalOffset;
        [FieldOffset(0x40)] public float offsetTransitionTime;
        [FieldOffset(0x44)] public float fov;
        [FieldOffset(0x48)] public float roll;
        [FieldOffset(0x4C)] public float easeInTime;
        [FieldOffset(0x50)] public float easeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BossPerfectblackdoomFixedCamera
    {
        [FieldOffset(0x00)] public Vector3 eyeLocalOffset;
        [FieldOffset(0x10)] public Vector3 lookAtLocalOffset;
        [FieldOffset(0x20)] public float fov;
        [FieldOffset(0x24)] public float roll;
        [FieldOffset(0x28)] public float easeInTime;
        [FieldOffset(0x2C)] public float easeOutTime;
        [FieldOffset(0x30)] public float keepTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct BossPerfectblackdoomFinalSplashBlowDBlowInfo
    {
        [FieldOffset(0x00)] public int hitDamage;
        [FieldOffset(0x10)] public BossPerfectblackdoomFixedCamera blowDownCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x290)]
    public struct BossPerfectblackdoomFinalSplashBlowParam
    {
        [FieldOffset(0x00)] public Vector3 warpOffset;
        [FieldOffset(0x10)] public float endKeepDistance;
        [FieldOffset(0x14)] public float hormingPlayerSpeed;
        [FieldOffset(0x20)] public Vector3 sweepBoxHalfExtents;
        [FieldOffset(0x30)] public float verticalBlowCollisionSizeEx;
        [FieldOffset(0x40)] public Vector3 verticalBlowCollisionOffsetPos;
        [FieldOffset(0x50)] public float verticalBlowCollisionAngle;
        [FieldOffset(0x54)] public float rightBlowCollisionSizeEx;
        [FieldOffset(0x60)] public Vector3 rightBlowCollisionOffsetPos;
        [FieldOffset(0x70)] public float rightBlowCollisionAngle;
        [FieldOffset(0x74)] public float leftBlowCollisionSizeEx;
        [FieldOffset(0x80)] public Vector3 leftBlowCollisionOffsetPos;
        [FieldOffset(0x90)] public float leftBlowCollisionAngle;
        [FieldOffset(0x94)] public float fourVerticalBlowCollisionSizeEx;
        [FieldOffset(0xA0)] public Vector3 fourVerticalBlowCollisionOffsetPos;
        [FieldOffset(0xB0)] public float fourVerticalBlowCollisionAngle;
        [FieldOffset(0xB4)] public float hitSplashBlowMotionSpeed;
        [FieldOffset(0xB8)] public float vertHitShadowBlowPower;
        [FieldOffset(0xBC)] public float vertHitShadowBlowAngle;
        [FieldOffset(0xC0)] public float horizontalHitShadowBlowPower;
        [FieldOffset(0xC4)] public BossPerfectblackdoomFinalSplashBlowWarpInfo waroInfo__arr0;
        [FieldOffset(0xCC)] public BossPerfectblackdoomFinalSplashBlowWarpInfo waroInfo__arr1;
        [FieldOffset(0xD4)] public BossPerfectblackdoomFinalSplashBlowWarpInfo waroInfo__arr2;
        [FieldOffset(0xDC)] public BossPerfectblackdoomFinalSplashBlowWarpInfo waroInfo__arr3;
        [FieldOffset(0xF0)] public BossPerfectblackdoomFinalSplashBlowCameraInfo cameraInfo__arr0;
        [FieldOffset(0x120)] public BossPerfectblackdoomFinalSplashBlowCameraInfo cameraInfo__arr1;
        [FieldOffset(0x150)] public BossPerfectblackdoomFinalSplashBlowCameraInfo cameraInfo__arr2;
        [FieldOffset(0x180)] public BossPerfectblackdoomFinalSplashBlowCameraInfo cameraInfo__arr3;
        [FieldOffset(0x1B0)] public BossPerfectblackdoomFinalSplashBlowHitCamera hitCamera;
        [FieldOffset(0x210)] public BossPerfectblackdoomFinalSplashBlowDBlowInfo dblowInfo;
        [FieldOffset(0x260)] public BossPerfectblackdoomFinalAutoRunGlindParam endAccelGlindParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BossPerfectblackdoomFinalGameOverCameraParam
    {
        [FieldOffset(0x00)] public float roll;
        [FieldOffset(0x04)] public float fovy;
        [FieldOffset(0x10)] public Vector3 targetOffset;
        [FieldOffset(0x20)] public Vector3 cameraOffset;
        [FieldOffset(0x30)] public float easeInTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct BossPerfectblackdoomFinalGameOverParam
    {
        [FieldOffset(0x00)] public float fadeDelayTime;
        [FieldOffset(0x04)] public float fadeOutTime;
        [FieldOffset(0x08)] public float voicePlayDelay;
        [FieldOffset(0x10)] public BossPerfectblackdoomFinalGameOverCameraParam camera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct BossPerfectblackdoomFinalDebugCommand
    {
        [FieldOffset(0x00)] public bool amoebaMultiRainShotDirDebugDraw;
        [FieldOffset(0x01)] public bool amoebaMultiRainMovePosDebugDraw;
        [FieldOffset(0x02)] public bool dblowCameraDebugDraw;
        [FieldOffset(0x03)] public bool splashBlowCameraDebugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1EB0)]
    public struct BossPerfectblackdoomConfigPhase3
    {
        [FieldOffset(0x00)] public float floatHeight;
        [FieldOffset(0x04)] public int raiseRingNum;
        [FieldOffset(0x08)] public uint requestLowHPCaptionRatio;
        [FieldOffset(0x0C)] public BossPerfectblackdoomFinalAutorunParam autorun;
        [FieldOffset(0x50)] public BossPerfectblackdoomBattleLockOnCameraParam mainCamera;
        [FieldOffset(0x80)] public BossPerfectblackdoomFinalRushParam rushParam;
        [FieldOffset(0x2B0)] public BossPerfectblackdoomFinalStunParam stunParam;
        [FieldOffset(0x2F0)] public BossPerfectblackdoomFinalDownParam downParam;
        [FieldOffset(0x310)] public BossPerfectblackdoomFinalAmoebaMultiRainParam amoebaMultiRainParam;
        [FieldOffset(0x1750)] public BossPerfectblackdoomFinalWingTornadoParam wingTornadoParam;
        [FieldOffset(0x1BC0)] public BossPerfectblackdoomFinalSplashBlowParam splashBlowParam;
        [FieldOffset(0x1E50)] public BossPerfectblackdoomFinalGameOverParam gameOverParam;
        [FieldOffset(0x1EA0)] public BossPerfectblackdoomFinalDebugCommand debug;
    }

}