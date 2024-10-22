Library "BossPerfectblackdoomConfigPhase2"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct BossPerfectblackdoomConfigPhase2CommonParam
    {
        [FieldOffset(0x00)] public float defaultHormingDistanceOffset;
        [FieldOffset(0x04)] public float chanceHormingDistanceOffset;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct BossPerfectblackdoomPhase2ResetPlayerPosData
    {
        [FieldOffset(0x00)] public int lifeCount;
        [FieldOffset(0x04)] public float blowTime;
        [FieldOffset(0x08)] public UnmanagedString PositionOpjName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct BossPerfectblackdoomPhase2RushParam
    {
        [FieldOffset(0x00)] public float rushTime;
        [FieldOffset(0x04)] public float rushCameraDelayTime;
        [FieldOffset(0x08)] public float damageAfterTime;
        [FieldOffset(0x0C)] public float rushFinishDamageScale;
        [FieldOffset(0x10)] public float blowUpPower;
        [FieldOffset(0x14)] public float blowPlayerHoldTime;
        [FieldOffset(0x18)] public BossPerfectblackdoomPhase2ResetPlayerPosData resetPlayerPosTable__arr0;
        [FieldOffset(0x30)] public BossPerfectblackdoomPhase2ResetPlayerPosData resetPlayerPosTable__arr1;
        [FieldOffset(0x48)] public BossPerfectblackdoomPhase2ResetPlayerPosData resetPlayerPosTable__arr2;
        [FieldOffset(0x60)] public BossPerfectblackdoomPhase2ResetPlayerPosData resetPlayerPosTable__arr3;
        [FieldOffset(0x78)] public BossPerfectblackdoomPhase2ResetPlayerPosData resetPlayerPosTable__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct BossPerfectblackdoomFollowCamera
    {
        [FieldOffset(0x00)] public float Fovy;
        [FieldOffset(0x04)] public float ZRot;
        [FieldOffset(0x08)] public float Distance;
        [FieldOffset(0x0C)] public float Yaw;
        [FieldOffset(0x10)] public float Pitch;
        [FieldOffset(0x20)] public Vector3 targetOffset;
        [FieldOffset(0x30)] public float gravityOffset;
        [FieldOffset(0x40)] public Vector3 playerOffset;
        [FieldOffset(0x50)] public bool enableCollision;
        [FieldOffset(0x51)] public bool enableEyePositionLimit;
        [FieldOffset(0x54)] public float eyePositionLimitMinY;
        [FieldOffset(0x58)] public float easeInTime;
        [FieldOffset(0x5C)] public float easeOutTime;
        [FieldOffset(0x60)] public float time;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x1B0)]
    public struct BossPerfectblackdoomPhase2RushAfterParam
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool followCameraEnable;
        [FieldOffset(0x10)] public BossPerfectblackdoomFollowCamera shortBlowFollowCamera;
        [FieldOffset(0x80)] public BossPerfectblackdoomFixedCamera shortBlowFixedCamera;
        [FieldOffset(0xC0)] public float shortMotionPlayerShortBlowUpPower;
        [FieldOffset(0xD0)] public Vector3 shortMotionPlayerShortBlowOffsetPos;
        [FieldOffset(0xE0)] public BossPerfectblackdoomFollowCamera longBlowFollowCamera;
        [FieldOffset(0x150)] public BossPerfectblackdoomFixedCamera longBlowFixedCamera;
        [FieldOffset(0x190)] public float longMotionPlayerShortBlowUpPower;
        [FieldOffset(0x1A0)] public Vector3 longMotionPlayerShortBlowOffsetPos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct BossPerfectblackdoomPhase2FireBeamPerformanceParam
    {
        [FieldOffset(0x00)] public float blowPlayerHoldTime;
        [FieldOffset(0x04)] public float fireBeamStartTime;
        [FieldOffset(0x08)] public float fireBeamTime;
        [FieldOffset(0x10)] public Vector3 fireBeamOffsetPos;
        [FieldOffset(0x20)] public bool isFireBeamOmen;
        [FieldOffset(0x28)] public UnmanagedString cameraShakeName;
        [FieldOffset(0x38)] public float cameraShakeStartTime;
        [FieldOffset(0x40)] public UnmanagedString vibrationName;
        [FieldOffset(0x50)] public float vibrationStartTime;
        [FieldOffset(0x54)] public float layerOffTime;
    }

    public enum Phase2FireBeamPointKinds : sbyte
    {
        INVALID = 0,
        PLAYER_POINT = 1,
        RIGHT_UP_POINT = 2,
        RIGHT_DOWN_POINT = 3,
        LEFT_UP_POINT = 4,
        LEFT_DOWN_POINT = 5,
        POINTING_POINT = 6,
        FIRE_BIAM_KIND_NUM = 7
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BossPerfectblackdoomPhase2FireBeamInfo
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float moveTime;
        [FieldOffset(0x10)] public Vector3 targetPos;
        [FieldOffset(0x20)] public Phase2FireBeamPointKinds startPointKinds;
        [FieldOffset(0x21)] public Phase2FireBeamPointKinds endPointKinds;
        [FieldOffset(0x22)] public bool omenEffect;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1E0)]
    public struct BossPerfectblackdoomPhase2FireBeamPatternData
    {
        [FieldOffset(0x00)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr0;
        [FieldOffset(0x30)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr1;
        [FieldOffset(0x60)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr2;
        [FieldOffset(0x90)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr3;
        [FieldOffset(0xC0)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr4;
        [FieldOffset(0xF0)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr5;
        [FieldOffset(0x120)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr6;
        [FieldOffset(0x150)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr7;
        [FieldOffset(0x180)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr8;
        [FieldOffset(0x1B0)] public BossPerfectblackdoomPhase2FireBeamInfo fireBeamInfoTabel__arr9;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xF40)]
    public struct BossPerfectblackdoomPhase2FireBeamParam
    {
        [FieldOffset(0x00)] public float startMoveTime;
        [FieldOffset(0x04)] public float endReturnMoveTime;
        [FieldOffset(0x08)] public float lowerHeight;
        [FieldOffset(0x0C)] public float upperHieght;
        [FieldOffset(0x10)] public float moveWidth;
        [FieldOffset(0x14)] public float beamRadius;
        [FieldOffset(0x18)] public float beamLength;
        [FieldOffset(0x20)] public Vector3 beamDir;
        [FieldOffset(0x30)] public float beamStretchOutTime;
        [FieldOffset(0x34)] public float attackSignTime;
        [FieldOffset(0x38)] public float beamStopTime;
        [FieldOffset(0x3C)] public float beamMoveSpeed;
        [FieldOffset(0x40)] public BossPerfectblackdoomPhase2FireBeamPatternData fireBeamPatterns__arr0;
        [FieldOffset(0x220)] public BossPerfectblackdoomPhase2FireBeamPatternData fireBeamPatterns__arr1;
        [FieldOffset(0x400)] public BossPerfectblackdoomPhase2FireBeamPatternData fireBeamPatterns__arr2;
        [FieldOffset(0x5E0)] public BossPerfectblackdoomPhase2FireBeamPatternData fireBeamPatterns__arr3;
        [FieldOffset(0x7C0)] public BossPerfectblackdoomPhase2FireBeamPatternData fireBeamPatterns__arr4;
        [FieldOffset(0x9A0)] public BossPerfectblackdoomPhase2FireBeamPatternData fireBeamPatterns__arr5;
        [FieldOffset(0xB80)] public BossPerfectblackdoomPhase2FireBeamPatternData fireBeamPatterns__arr6;
        [FieldOffset(0xD60)] public BossPerfectblackdoomPhase2FireBeamPatternData fireBeamPatterns__arr7;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct BossPerfectblackdoomPhase2FireBombInfo
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public int targetId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct BossPerfectblackdoomPhase2FireBombPatternData
    {
        [FieldOffset(0x00)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr0;
        [FieldOffset(0x08)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr1;
        [FieldOffset(0x10)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr2;
        [FieldOffset(0x18)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr3;
        [FieldOffset(0x20)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr4;
        [FieldOffset(0x28)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr5;
        [FieldOffset(0x30)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr6;
        [FieldOffset(0x38)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr7;
        [FieldOffset(0x40)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr8;
        [FieldOffset(0x48)] public BossPerfectblackdoomPhase2FireBombInfo fireBombInfoTabel__arr9;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10C)]
    public struct BossPerfectblackdoomPhase2FireBombParam
    {
        [FieldOffset(0x00)] public float startWaitTime;
        [FieldOffset(0x04)] public float endWaitTime;
        [FieldOffset(0x08)] public float beforeAttackMotionSpeed;
        [FieldOffset(0x0C)] public float attackMotionSpeed;
        [FieldOffset(0x10)] public float bombRadius;
        [FieldOffset(0x14)] public float bombLifeTime;
        [FieldOffset(0x18)] public float bombSpeed;
        [FieldOffset(0x1C)] public BossPerfectblackdoomPhase2FireBombPatternData fireBombPatterns__arr0;
        [FieldOffset(0x6C)] public BossPerfectblackdoomPhase2FireBombPatternData fireBombPatterns__arr1;
        [FieldOffset(0xBC)] public BossPerfectblackdoomPhase2FireBombPatternData fireBombPatterns__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14E0)]
    public struct BossPerfectblackdoomConfigPhase2
    {
        [FieldOffset(0x00)] public BossPerfectblackdoomConfigPhase2CommonParam common;
        [FieldOffset(0x10)] public BossPerfectblackdoomPointCameraParam mainCamera;
        [FieldOffset(0xB0)] public BossPerfectblackdoomPointCameraParam attackChanceBeforeCamera;
        [FieldOffset(0x150)] public BossPerfectblackdoomPointCameraParam rushDamageCamera;
        [FieldOffset(0x1F0)] public BossPerfectblackdoomPhase2RushParam rushParam;
        [FieldOffset(0x280)] public BossPerfectblackdoomPhase2RushAfterParam rushAfterParam;
        [FieldOffset(0x430)] public BossPerfectblackdoomPhase2FireBeamPerformanceParam fireBeamPerformanceParam;
        [FieldOffset(0x490)] public BossPerfectblackdoomPhase2FireBeamParam fireBeamParam;
        [FieldOffset(0x13D0)] public BossPerfectblackdoomPhase2FireBombParam fireBombParam;
    }

}