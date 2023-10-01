using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossFlyerConfigClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FlyerTrailParam
    {
        [FieldOffset(0x00)] public float interval;
        [FieldOffset(0x04)] public int recordNumWander;
        [FieldOffset(0x08)] public int recordNumWatch;
        [FieldOffset(0x0C)] public int recordNumBattle;
        [FieldOffset(0x10)] public float width;
        [FieldOffset(0x14)] public float wallHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct FlyerWanderParam
    {
        [FieldOffset(0x00)] public float speed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FlyerWatchShotParam
    {
        [FieldOffset(0x00)] public float interval;
        [FieldOffset(0x04)] public float readyDuration;
        [FieldOffset(0x08)] public float shotAnimSpeed;
        [FieldOffset(0x0C)] public uint shotAnimNum;
        [FieldOffset(0x10)] public float speed;
        [FieldOffset(0x14)] public float lifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct FlyerWatchParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float changeWanderTime;
        [FieldOffset(0x08)] public FlyerWatchShotParam shot;
    }

    public enum HorizontalType : sbyte
    {
        HorzCenter = 0,
        HorzLeft = 1,
        HorzRight = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x06)]
    public struct FlyerEscapeShotTableData
    {
        [FieldOffset(0x00)] public HorizontalType horz__arr0;
        [FieldOffset(0x01)] public HorizontalType horz__arr1;
        [FieldOffset(0x02)] public HorizontalType horz__arr2;
        [FieldOffset(0x03)] public HorizontalType horz__arr3;
        [FieldOffset(0x04)] public HorizontalType horz__arr4;
        [FieldOffset(0x05)] public HorizontalType horz__arr5;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x88)]
    public struct FlyerEscapeShotParam
    {
        [FieldOffset(0x00)] public FlyerEscapeShotTableData posTable__arr0;
        [FieldOffset(0x06)] public FlyerEscapeShotTableData posTable__arr1;
        [FieldOffset(0x0C)] public FlyerEscapeShotTableData posTable__arr2;
        [FieldOffset(0x12)] public FlyerEscapeShotTableData posTable__arr3;
        [FieldOffset(0x18)] public FlyerEscapeShotTableData posTable__arr4;
        [FieldOffset(0x1E)] public FlyerEscapeShotTableData posTable__arr5;
        [FieldOffset(0x24)] public FlyerEscapeShotTableData posTable__arr6;
        [FieldOffset(0x2A)] public FlyerEscapeShotTableData posTable__arr7;
        [FieldOffset(0x30)] public FlyerEscapeShotTableData posTable__arr8;
        [FieldOffset(0x36)] public FlyerEscapeShotTableData posTable__arr9;
        [FieldOffset(0x3C)] public FlyerEscapeShotTableData posTable__arr10;
        [FieldOffset(0x42)] public FlyerEscapeShotTableData posTable__arr11;
        [FieldOffset(0x48)] public FlyerEscapeShotTableData posTable__arr12;
        [FieldOffset(0x4E)] public FlyerEscapeShotTableData posTable__arr13;
        [FieldOffset(0x54)] public FlyerEscapeShotTableData posTable__arr14;
        [FieldOffset(0x5A)] public FlyerEscapeShotTableData posTable__arr15;
        [FieldOffset(0x60)] public float interval;
        [FieldOffset(0x64)] public float waitAfterLoop;
        [FieldOffset(0x68)] public float readyDuration;
        [FieldOffset(0x6C)] public float shotAnimSpeed;
        [FieldOffset(0x70)] public uint shotAnimNum;
        [FieldOffset(0x74)] public float initSpeed;
        [FieldOffset(0x78)] public float maxSpeed;
        [FieldOffset(0x7C)] public float acc;
        [FieldOffset(0x80)] public float lifeTime;
        [FieldOffset(0x84)] public float nearest;
    }

    public enum PlayerOffsetType : sbyte
    {
        PLAYER_OFFSET_NORMAL = 0,
        PLAYER_OFFSET_ABSOLUTE = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct FlyerEscapeCameraParam
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
        [FieldOffset(0x40)] public PlayerOffsetType playerOffsetType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FlyerEscapeQuickStepParam
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float boostSpeed;
        [FieldOffset(0x0C)] public float boostSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100)]
    public struct FlyerEscapeParam
    {
        [FieldOffset(0x00)] public float startSpeed;
        [FieldOffset(0x04)] public float decrease;
        [FieldOffset(0x08)] public float minSpeed;
        [FieldOffset(0x0C)] public float targetDisableTime;
        [FieldOffset(0x10)] public float resetByFallTime;
        [FieldOffset(0x14)] public float resetByDistance;
        [FieldOffset(0x18)] public FlyerEscapeShotParam shot;
        [FieldOffset(0xA0)] public FlyerEscapeCameraParam camera;
        [FieldOffset(0xF0)] public FlyerEscapeQuickStepParam quickStep;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct FlyerNearStartCamParam
    {
        [FieldOffset(0x00)] public float duration;
        [FieldOffset(0x10)] public Vector3 posOffset;
        [FieldOffset(0x20)] public float fovy;
        [FieldOffset(0x24)] public float interpolateTimePush;
        [FieldOffset(0x28)] public float interpolateTimePop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FlyerIdlingNearParam
    {
        [FieldOffset(0x00)] public float durationMin;
        [FieldOffset(0x04)] public float durationMax;
        [FieldOffset(0x08)] public uint selectRatio__arr0;
        [FieldOffset(0x0C)] public uint selectRatio__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct FlyerGuardParam
    {
        [FieldOffset(0x00)] public float duration;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct FlyerAutoLockonParam
    {
        [FieldOffset(0x00)] public float lockonDistance;
        [FieldOffset(0x04)] public float unlockDistance;
        [FieldOffset(0x08)] public float distance;
        [FieldOffset(0x0C)] public float minElevation;
        [FieldOffset(0x10)] public float maxElevation;
        [FieldOffset(0x14)] public float panningSuspensionK;
        [FieldOffset(0x18)] public float interiorPanningSuspensionK;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct FlyerNearEndLaunchParam
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

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct FlyerNearParam
    {
        [FieldOffset(0x00)] public float duration;
        [FieldOffset(0x04)] public float startHABounceUp;
        [FieldOffset(0x08)] public float startHABounceBack;
        [FieldOffset(0x0C)] public float preliminaryMotionSpeed;
        [FieldOffset(0x10)] public float resetByDistance;
        [FieldOffset(0x20)] public FlyerNearStartCamParam startCam;
        [FieldOffset(0x50)] public FlyerIdlingNearParam idling;
        [FieldOffset(0x60)] public FlyerGuardParam guard;
        [FieldOffset(0x64)] public FlyerAutoLockonParam lockon;
        [FieldOffset(0x80)] public FlyerNearEndLaunchParam launch;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x230)]
    public struct MiniBossFlyerCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig commonConfig;
        [FieldOffset(0x40)] public FlyerTrailParam trail;
        [FieldOffset(0x58)] public FlyerWanderParam wander;
        [FieldOffset(0x5C)] public FlyerWatchParam watch;
        [FieldOffset(0x80)] public FlyerEscapeParam escape;
        [FieldOffset(0x180)] public FlyerNearParam nearRange;
        [FieldOffset(0x220)] public float stunTime;
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
    public struct MiniBossFlyerLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FlayerEscapeShotSequenceTable
    {
        [FieldOffset(0x00)] public int id;
        [FieldOffset(0x04)] public float interval;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct FlayerEscapeShotSequenceTableData
    {
        [FieldOffset(0x00)] public bool isUse;
        [FieldOffset(0x04)] public FlayerEscapeShotSequenceTable table__arr0;
        [FieldOffset(0x0C)] public FlayerEscapeShotSequenceTable table__arr1;
        [FieldOffset(0x14)] public FlayerEscapeShotSequenceTable table__arr2;
        [FieldOffset(0x1C)] public FlayerEscapeShotSequenceTable table__arr3;
        [FieldOffset(0x24)] public FlayerEscapeShotSequenceTable table__arr4;
        [FieldOffset(0x2C)] public FlayerEscapeShotSequenceTable table__arr5;
        [FieldOffset(0x34)] public FlayerEscapeShotSequenceTable table__arr6;
        [FieldOffset(0x3C)] public FlayerEscapeShotSequenceTable table__arr7;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x444)]
    public struct MiniBossFlyerLevelBand
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public FlayerEscapeShotSequenceTableData sequence__arr0;
        [FieldOffset(0x48)] public FlayerEscapeShotSequenceTableData sequence__arr1;
        [FieldOffset(0x8C)] public FlayerEscapeShotSequenceTableData sequence__arr2;
        [FieldOffset(0xD0)] public FlayerEscapeShotSequenceTableData sequence__arr3;
        [FieldOffset(0x114)] public FlayerEscapeShotSequenceTableData sequence__arr4;
        [FieldOffset(0x158)] public FlayerEscapeShotSequenceTableData sequence__arr5;
        [FieldOffset(0x19C)] public FlayerEscapeShotSequenceTableData sequence__arr6;
        [FieldOffset(0x1E0)] public FlayerEscapeShotSequenceTableData sequence__arr7;
        [FieldOffset(0x224)] public FlayerEscapeShotSequenceTableData sequence__arr8;
        [FieldOffset(0x268)] public FlayerEscapeShotSequenceTableData sequence__arr9;
        [FieldOffset(0x2AC)] public FlayerEscapeShotSequenceTableData sequence__arr10;
        [FieldOffset(0x2F0)] public FlayerEscapeShotSequenceTableData sequence__arr11;
        [FieldOffset(0x334)] public FlayerEscapeShotSequenceTableData sequence__arr12;
        [FieldOffset(0x378)] public FlayerEscapeShotSequenceTableData sequence__arr13;
        [FieldOffset(0x3BC)] public FlayerEscapeShotSequenceTableData sequence__arr14;
        [FieldOffset(0x400)] public FlayerEscapeShotSequenceTableData sequence__arr15;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18A0)]
    public struct MiniBossFlyerConfig
    {
        [FieldOffset(0x00)] public MiniBossFlyerCommonParam commonParam;
        [FieldOffset(0x230)] public MiniBossFlyerLevelParam levelParams__arr0;
        [FieldOffset(0x268)] public MiniBossFlyerLevelParam levelParams__arr1;
        [FieldOffset(0x2A0)] public MiniBossFlyerLevelParam levelParams__arr2;
        [FieldOffset(0x2D8)] public MiniBossFlyerLevelParam levelParams__arr3;
        [FieldOffset(0x310)] public MiniBossFlyerLevelParam levelParams__arr4;
        [FieldOffset(0x348)] public MiniBossFlyerLevelBand levelBand__arr0;
        [FieldOffset(0x78C)] public MiniBossFlyerLevelBand levelBand__arr1;
        [FieldOffset(0xBD0)] public MiniBossFlyerLevelBand levelBand__arr2;
        [FieldOffset(0x1014)] public MiniBossFlyerLevelBand levelBand__arr3;
        [FieldOffset(0x1458)] public MiniBossFlyerLevelBand levelBand__arr4;
    }

}