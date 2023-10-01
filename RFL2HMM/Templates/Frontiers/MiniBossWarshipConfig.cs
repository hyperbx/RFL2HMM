using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossWarshipConfigClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct MiniBossWarshipSpeedParam
    {
        [FieldOffset(0x00)] public float highSpeed;
        [FieldOffset(0x04)] public float lowSpeed;
        [FieldOffset(0x08)] public float changeLowSpeedDistance;
        [FieldOffset(0x0C)] public float disableDistanceMaxSpeed;
        [FieldOffset(0x10)] public float relativeSpeedDisableDistance;
        [FieldOffset(0x14)] public float speedOnJump;
        [FieldOffset(0x18)] public float speedDownOnJumpDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct MiniBossWarshipAccelSpeed
    {
        [FieldOffset(0x00)] public float min;
        [FieldOffset(0x04)] public float max;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossWarshipWarpCameraParam
    {
        [FieldOffset(0x00)] public float zoomDistance;
        [FieldOffset(0x10)] public Vector3 zoomOffset;
        [FieldOffset(0x20)] public Vector3 zoomAngle;
        [FieldOffset(0x30)] public float zoomFov;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossWarshipEscapeCameraParam
    {
        [FieldOffset(0x00)] public float fovy;
        [FieldOffset(0x04)] public float zRot;
        [FieldOffset(0x08)] public float distance;
        [FieldOffset(0x0C)] public float pathOffset;
        [FieldOffset(0x10)] public bool usePathVerticalComponent;
        [FieldOffset(0x11)] public bool usePathNormal;
        [FieldOffset(0x14)] public float angleSensitivity;
        [FieldOffset(0x18)] public float angleSensitivityBoost;
        [FieldOffset(0x1C)] public float azimuthOffsetDeg;
        [FieldOffset(0x20)] public float elevationOffsetDeg;
        [FieldOffset(0x24)] public float gravityOffset;
        [FieldOffset(0x30)] public Vector3 playerOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct MiniBossWarshipObjectParam
    {
        [FieldOffset(0x00)] public float dashRingAppearDistance;
        [FieldOffset(0x04)] public float dashRingDisappearDistance;
        [FieldOffset(0x08)] public float birdAppearDistance;
        [FieldOffset(0x0C)] public float birdDisappearDistance;
        [FieldOffset(0x10)] public float bulletAppearDistance;
        [FieldOffset(0x14)] public float bulletDisappearDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct WarshipNearLaunchParam
    {
        [FieldOffset(0x00)] public float outStrength;
        [FieldOffset(0x04)] public float inStrength;
        [FieldOffset(0x08)] public float outElev;
        [FieldOffset(0x0C)] public float inElev;
        [FieldOffset(0x10)] public float speedMin;
        [FieldOffset(0x14)] public float speedMax;
        [FieldOffset(0x18)] public float speedMinLength;
        [FieldOffset(0x1C)] public float speedMaxLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x130)]
    public struct MiniBossWarshipCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig commonConfig;
        [FieldOffset(0x40)] public MiniBossWarshipSpeedParam speedParam;
        [FieldOffset(0x5C)] public MiniBossWarshipAccelSpeed normalSpeedParam;
        [FieldOffset(0x64)] public MiniBossWarshipAccelSpeed boostSpeedParam;
        [FieldOffset(0x70)] public MiniBossWarshipWarpCameraParam warpCameraParam;
        [FieldOffset(0xB0)] public MiniBossWarshipEscapeCameraParam escapeCameraParam;
        [FieldOffset(0xF0)] public MiniBossWarshipObjectParam objectParam;
        [FieldOffset(0x108)] public WarshipNearLaunchParam launchParam;
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
    public struct MiniBossWarshipLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct MiniBossWarshipLevelBand
    {
        [FieldOffset(0x00)] public int level;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct MiniBossWarshipRecoverBoostGaugeParam
    {
        [FieldOffset(0x00)] public float normal;
        [FieldOffset(0x04)] public float boost;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct MiniBossWarshipAttackStateParam
    {
        [FieldOffset(0x00)] public float moveSpeed;
        [FieldOffset(0x04)] public float bombDropSpeed;
        [FieldOffset(0x08)] public float bombInterval;
        [FieldOffset(0x0C)] public float explosionRadius;
        [FieldOffset(0x10)] public float bombPreDistEffectRange;
        [FieldOffset(0x14)] public float lifeTime;
        [FieldOffset(0x18)] public float preBombTime;
        [FieldOffset(0x1C)] public float preBombStateSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct MiniBossWarshipBattleFlagParam
    {
        [FieldOffset(0x00)] public float firstFinishTimer;
        [FieldOffset(0x04)] public float finishTimer;
        [FieldOffset(0x08)] public float disableHomingTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct MiniBossWarshipNearBattleCameraParam
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float minElevation;
        [FieldOffset(0x08)] public float maxElevation;
        [FieldOffset(0x0C)] public float targetUpOffset;
        [FieldOffset(0x10)] public float targetMinUpOffsetLimit;
        [FieldOffset(0x14)] public float targetMaxUpOffsetLimit;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct WarshipPathSectionInfo
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float start;
        [FieldOffset(0x08)] public float end;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4C0)]
    public struct WarshipEscapePathInfo
    {
        [FieldOffset(0x00)] public UnmanagedString followPaths;
        [FieldOffset(0x10)] public WarshipPathSectionInfo usePathInfo__arr0;
        [FieldOffset(0x1C)] public WarshipPathSectionInfo usePathInfo__arr1;
        [FieldOffset(0x28)] public WarshipPathSectionInfo usePathInfo__arr2;
        [FieldOffset(0x34)] public WarshipPathSectionInfo usePathInfo__arr3;
        [FieldOffset(0x40)] public WarshipPathSectionInfo usePathInfo__arr4;
        [FieldOffset(0x4C)] public WarshipPathSectionInfo usePathInfo__arr5;
        [FieldOffset(0x58)] public WarshipPathSectionInfo usePathInfo__arr6;
        [FieldOffset(0x64)] public WarshipPathSectionInfo usePathInfo__arr7;
        [FieldOffset(0x70)] public WarshipPathSectionInfo usePathInfo__arr8;
        [FieldOffset(0x7C)] public WarshipPathSectionInfo usePathInfo__arr9;
        [FieldOffset(0x88)] public WarshipPathSectionInfo usePathInfo__arr10;
        [FieldOffset(0x94)] public WarshipPathSectionInfo usePathInfo__arr11;
        [FieldOffset(0xA0)] public WarshipPathSectionInfo usePathInfo__arr12;
        [FieldOffset(0xAC)] public WarshipPathSectionInfo usePathInfo__arr13;
        [FieldOffset(0xB8)] public WarshipPathSectionInfo usePathInfo__arr14;
        [FieldOffset(0xC4)] public WarshipPathSectionInfo usePathInfo__arr15;
        [FieldOffset(0xD0)] public WarshipPathSectionInfo usePathInfo__arr16;
        [FieldOffset(0xDC)] public WarshipPathSectionInfo usePathInfo__arr17;
        [FieldOffset(0xE8)] public WarshipPathSectionInfo usePathInfo__arr18;
        [FieldOffset(0xF4)] public WarshipPathSectionInfo usePathInfo__arr19;
        [FieldOffset(0x100)] public WarshipPathSectionInfo usePathInfo__arr20;
        [FieldOffset(0x10C)] public WarshipPathSectionInfo usePathInfo__arr21;
        [FieldOffset(0x118)] public WarshipPathSectionInfo usePathInfo__arr22;
        [FieldOffset(0x124)] public WarshipPathSectionInfo usePathInfo__arr23;
        [FieldOffset(0x130)] public WarshipPathSectionInfo usePathInfo__arr24;
        [FieldOffset(0x13C)] public WarshipPathSectionInfo usePathInfo__arr25;
        [FieldOffset(0x148)] public WarshipPathSectionInfo usePathInfo__arr26;
        [FieldOffset(0x154)] public WarshipPathSectionInfo usePathInfo__arr27;
        [FieldOffset(0x160)] public WarshipPathSectionInfo usePathInfo__arr28;
        [FieldOffset(0x16C)] public WarshipPathSectionInfo usePathInfo__arr29;
        [FieldOffset(0x178)] public WarshipPathSectionInfo usePathInfo__arr30;
        [FieldOffset(0x184)] public WarshipPathSectionInfo usePathInfo__arr31;
        [FieldOffset(0x190)] public WarshipPathSectionInfo usePathInfo__arr32;
        [FieldOffset(0x19C)] public WarshipPathSectionInfo usePathInfo__arr33;
        [FieldOffset(0x1A8)] public WarshipPathSectionInfo usePathInfo__arr34;
        [FieldOffset(0x1B4)] public WarshipPathSectionInfo usePathInfo__arr35;
        [FieldOffset(0x1C0)] public WarshipPathSectionInfo usePathInfo__arr36;
        [FieldOffset(0x1CC)] public WarshipPathSectionInfo usePathInfo__arr37;
        [FieldOffset(0x1D8)] public WarshipPathSectionInfo usePathInfo__arr38;
        [FieldOffset(0x1E4)] public WarshipPathSectionInfo usePathInfo__arr39;
        [FieldOffset(0x1F0)] public WarshipPathSectionInfo usePathInfo__arr40;
        [FieldOffset(0x1FC)] public WarshipPathSectionInfo usePathInfo__arr41;
        [FieldOffset(0x208)] public WarshipPathSectionInfo usePathInfo__arr42;
        [FieldOffset(0x214)] public WarshipPathSectionInfo usePathInfo__arr43;
        [FieldOffset(0x220)] public WarshipPathSectionInfo usePathInfo__arr44;
        [FieldOffset(0x22C)] public WarshipPathSectionInfo usePathInfo__arr45;
        [FieldOffset(0x238)] public WarshipPathSectionInfo usePathInfo__arr46;
        [FieldOffset(0x244)] public WarshipPathSectionInfo usePathInfo__arr47;
        [FieldOffset(0x250)] public WarshipPathSectionInfo usePathInfo__arr48;
        [FieldOffset(0x25C)] public WarshipPathSectionInfo usePathInfo__arr49;
        [FieldOffset(0x268)] public WarshipPathSectionInfo accelInfo__arr0;
        [FieldOffset(0x274)] public WarshipPathSectionInfo accelInfo__arr1;
        [FieldOffset(0x280)] public WarshipPathSectionInfo accelInfo__arr2;
        [FieldOffset(0x28C)] public WarshipPathSectionInfo accelInfo__arr3;
        [FieldOffset(0x298)] public WarshipPathSectionInfo accelInfo__arr4;
        [FieldOffset(0x2A4)] public WarshipPathSectionInfo accelInfo__arr5;
        [FieldOffset(0x2B0)] public WarshipPathSectionInfo accelInfo__arr6;
        [FieldOffset(0x2BC)] public WarshipPathSectionInfo accelInfo__arr7;
        [FieldOffset(0x2C8)] public WarshipPathSectionInfo accelInfo__arr8;
        [FieldOffset(0x2D4)] public WarshipPathSectionInfo accelInfo__arr9;
        [FieldOffset(0x2E0)] public WarshipPathSectionInfo accelInfo__arr10;
        [FieldOffset(0x2EC)] public WarshipPathSectionInfo accelInfo__arr11;
        [FieldOffset(0x2F8)] public WarshipPathSectionInfo accelInfo__arr12;
        [FieldOffset(0x304)] public WarshipPathSectionInfo accelInfo__arr13;
        [FieldOffset(0x310)] public WarshipPathSectionInfo accelInfo__arr14;
        [FieldOffset(0x31C)] public WarshipPathSectionInfo accelInfo__arr15;
        [FieldOffset(0x328)] public WarshipPathSectionInfo accelInfo__arr16;
        [FieldOffset(0x334)] public WarshipPathSectionInfo accelInfo__arr17;
        [FieldOffset(0x340)] public WarshipPathSectionInfo accelInfo__arr18;
        [FieldOffset(0x34C)] public WarshipPathSectionInfo accelInfo__arr19;
        [FieldOffset(0x358)] public WarshipPathSectionInfo accelInfo__arr20;
        [FieldOffset(0x364)] public WarshipPathSectionInfo accelInfo__arr21;
        [FieldOffset(0x370)] public WarshipPathSectionInfo accelInfo__arr22;
        [FieldOffset(0x37C)] public WarshipPathSectionInfo accelInfo__arr23;
        [FieldOffset(0x388)] public WarshipPathSectionInfo accelInfo__arr24;
        [FieldOffset(0x394)] public WarshipPathSectionInfo accelInfo__arr25;
        [FieldOffset(0x3A0)] public WarshipPathSectionInfo accelInfo__arr26;
        [FieldOffset(0x3AC)] public WarshipPathSectionInfo accelInfo__arr27;
        [FieldOffset(0x3B8)] public WarshipPathSectionInfo accelInfo__arr28;
        [FieldOffset(0x3C4)] public WarshipPathSectionInfo accelInfo__arr29;
        [FieldOffset(0x3D0)] public WarshipPathSectionInfo accelInfo__arr30;
        [FieldOffset(0x3DC)] public WarshipPathSectionInfo accelInfo__arr31;
        [FieldOffset(0x3E8)] public WarshipPathSectionInfo accelInfo__arr32;
        [FieldOffset(0x3F4)] public WarshipPathSectionInfo accelInfo__arr33;
        [FieldOffset(0x400)] public WarshipPathSectionInfo accelInfo__arr34;
        [FieldOffset(0x40C)] public WarshipPathSectionInfo accelInfo__arr35;
        [FieldOffset(0x418)] public WarshipPathSectionInfo accelInfo__arr36;
        [FieldOffset(0x424)] public WarshipPathSectionInfo accelInfo__arr37;
        [FieldOffset(0x430)] public WarshipPathSectionInfo accelInfo__arr38;
        [FieldOffset(0x43C)] public WarshipPathSectionInfo accelInfo__arr39;
        [FieldOffset(0x448)] public WarshipPathSectionInfo accelInfo__arr40;
        [FieldOffset(0x454)] public WarshipPathSectionInfo accelInfo__arr41;
        [FieldOffset(0x460)] public WarshipPathSectionInfo accelInfo__arr42;
        [FieldOffset(0x46C)] public WarshipPathSectionInfo accelInfo__arr43;
        [FieldOffset(0x478)] public WarshipPathSectionInfo accelInfo__arr44;
        [FieldOffset(0x484)] public WarshipPathSectionInfo accelInfo__arr45;
        [FieldOffset(0x490)] public WarshipPathSectionInfo accelInfo__arr46;
        [FieldOffset(0x49C)] public WarshipPathSectionInfo accelInfo__arr47;
        [FieldOffset(0x4A8)] public WarshipPathSectionInfo accelInfo__arr48;
        [FieldOffset(0x4B4)] public WarshipPathSectionInfo accelInfo__arr49;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x17C0)]
    public struct MiniBossWarshipEscapePathParam
    {
        [FieldOffset(0x00)] public WarshipEscapePathInfo escapePathInfo__arr0;
        [FieldOffset(0x4C0)] public WarshipEscapePathInfo escapePathInfo__arr1;
        [FieldOffset(0x980)] public WarshipEscapePathInfo escapePathInfo__arr2;
        [FieldOffset(0xE40)] public WarshipEscapePathInfo escapePathInfo__arr3;
        [FieldOffset(0x1300)] public WarshipEscapePathInfo escapePathInfo__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct MiniBossWarshipBombAttackCameraParam
    {
        [FieldOffset(0x00)] public float lockonDistance;
        [FieldOffset(0x04)] public float unlockDistance;
        [FieldOffset(0x08)] public float duration;
        [FieldOffset(0x0C)] public float distance;
        [FieldOffset(0x10)] public float minElevation;
        [FieldOffset(0x14)] public float maxElevation;
        [FieldOffset(0x18)] public float lockonFrameYOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct MiniBossWarshipAttackStateCameraParam
    {
        [FieldOffset(0x00)] public float midCameraPosOffset;
        [FieldOffset(0x04)] public MiniBossWarshipBombAttackCameraParam firstCamera;
        [FieldOffset(0x20)] public MiniBossWarshipBombAttackCameraParam secondCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x7AE0)]
    public struct MiniBossWarshipConfig
    {
        [FieldOffset(0x00)] public MiniBossWarshipCommonParam commonParam;
        [FieldOffset(0x130)] public MiniBossWarshipLevelParam levelParams__arr0;
        [FieldOffset(0x168)] public MiniBossWarshipLevelParam levelParams__arr1;
        [FieldOffset(0x1A0)] public MiniBossWarshipLevelParam levelParams__arr2;
        [FieldOffset(0x1D8)] public MiniBossWarshipLevelParam levelParams__arr3;
        [FieldOffset(0x210)] public MiniBossWarshipLevelParam levelParams__arr4;
        [FieldOffset(0x248)] public MiniBossWarshipLevelBand levelBand__arr0;
        [FieldOffset(0x24C)] public MiniBossWarshipLevelBand levelBand__arr1;
        [FieldOffset(0x250)] public MiniBossWarshipLevelBand levelBand__arr2;
        [FieldOffset(0x254)] public MiniBossWarshipLevelBand levelBand__arr3;
        [FieldOffset(0x258)] public MiniBossWarshipLevelBand levelBand__arr4;
        [FieldOffset(0x25C)] public float wanderMoveSpeed;
        [FieldOffset(0x260)] public float railMaxLength;
        [FieldOffset(0x264)] public MiniBossWarshipSpeedParam shiftStateMoveSpeedParam;
        [FieldOffset(0x280)] public float locatorDistance;
        [FieldOffset(0x284)] public float distanceEscapePathToStart;
        [FieldOffset(0x288)] public MiniBossWarshipRecoverBoostGaugeParam boostGaugeParam;
        [FieldOffset(0x290)] public MiniBossWarshipAttackStateParam attackStateParam;
        [FieldOffset(0x2B0)] public MiniBossWarshipBattleFlagParam battleFlagParam;
        [FieldOffset(0x2BC)] public MiniBossWarshipNearBattleCameraParam nearBattleCameraParam;
        [FieldOffset(0x2D4)] public float disableGimmickDistance;
        [FieldOffset(0x2D8)] public float warpTime;
        [FieldOffset(0x2DC)] public float cameraChangeTime;
        [FieldOffset(0x2E0)] public float cameraAppearTime;
        [FieldOffset(0x2E4)] public float spreadHomingDistance;
        [FieldOffset(0x2E8)] public MiniBossWarshipEscapePathParam escapePathID__arr0;
        [FieldOffset(0x1AA8)] public MiniBossWarshipEscapePathParam escapePathID__arr1;
        [FieldOffset(0x3268)] public MiniBossWarshipEscapePathParam escapePathID__arr2;
        [FieldOffset(0x4A28)] public MiniBossWarshipEscapePathParam escapePathID__arr3;
        [FieldOffset(0x61E8)] public MiniBossWarshipEscapePathParam escapePathID__arr4;
        [FieldOffset(0x79A8)] public MiniBossWarshipAttackStateCameraParam bombAttackCameraParam__arr0;
        [FieldOffset(0x79E4)] public MiniBossWarshipAttackStateCameraParam bombAttackCameraParam__arr1;
        [FieldOffset(0x7A20)] public MiniBossWarshipAttackStateCameraParam bombAttackCameraParam__arr2;
        [FieldOffset(0x7A5C)] public MiniBossWarshipAttackStateCameraParam bombAttackCameraParam__arr3;
        [FieldOffset(0x7A98)] public MiniBossWarshipAttackStateCameraParam bombAttackCameraParam__arr4;
    }

}