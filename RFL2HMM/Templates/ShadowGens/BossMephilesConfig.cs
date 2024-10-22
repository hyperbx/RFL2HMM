Library "BossMephilesConfig"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BossMephilesFixedCamera
    {
        [FieldOffset(0x00)] public Vector3 eyeLocalOffset;
        [FieldOffset(0x10)] public Vector3 lookAtLocalOffset;
        [FieldOffset(0x20)] public float fov;
        [FieldOffset(0x24)] public float roll;
        [FieldOffset(0x28)] public float easeInTime;
        [FieldOffset(0x2C)] public float easeOutTime;
        [FieldOffset(0x30)] public float keepTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xB0)]
    public struct BossMephilesDBlowHitParam
    {
        [FieldOffset(0x00)] public float VerticalPowerRatio;
        [FieldOffset(0x04)] public float VerticalSpeedKeepTime;
        [FieldOffset(0x08)] public float VerticalSpeedDecelTime;
        [FieldOffset(0x0C)] public float HorizontalPowerRatio;
        [FieldOffset(0x10)] public float HorizontalSpeedKeepTime;
        [FieldOffset(0x14)] public float HorizontalSpeedDecelTime;
        [FieldOffset(0x18)] public int wallHitDamage;
        [FieldOffset(0x1C)] public float waitTime;
        [FieldOffset(0x20)] public BossMephilesFixedCamera bombHitCamera;
        [FieldOffset(0x60)] public BossMephilesFixedCamera blowDownCamera;
        [FieldOffset(0xA0)] public float blowDownCameraDelay;
        [FieldOffset(0xA4)] public float blowDownWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossMephilesWarpStatusData
    {
        [FieldOffset(0x00)] public bool isEnable;
        [FieldOffset(0x04)] public float damageTime;
        [FieldOffset(0x08)] public float counterAtkWaitTime;
        [FieldOffset(0x0C)] public float warpedWaitTime;
        [FieldOffset(0x10)] public bool isDBlow;
        [FieldOffset(0x11)] public bool isCounter;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x190)]
    public struct BossMephilesWarpStatusTable
    {
        [FieldOffset(0x00)] public BossMephilesWarpStatusData warpDatas__arr0;
        [FieldOffset(0x14)] public BossMephilesWarpStatusData warpDatas__arr1;
        [FieldOffset(0x28)] public BossMephilesWarpStatusData warpDatas__arr2;
        [FieldOffset(0x3C)] public BossMephilesWarpStatusData warpDatas__arr3;
        [FieldOffset(0x50)] public BossMephilesWarpStatusData warpDatas__arr4;
        [FieldOffset(0x64)] public BossMephilesWarpStatusData warpDatas__arr5;
        [FieldOffset(0x78)] public BossMephilesWarpStatusData warpDatas__arr6;
        [FieldOffset(0x8C)] public BossMephilesWarpStatusData warpDatas__arr7;
        [FieldOffset(0xA0)] public BossMephilesWarpStatusData warpDatas__arr8;
        [FieldOffset(0xB4)] public BossMephilesWarpStatusData warpDatas__arr9;
        [FieldOffset(0xC8)] public BossMephilesWarpStatusData warpDatas__arr10;
        [FieldOffset(0xDC)] public BossMephilesWarpStatusData warpDatas__arr11;
        [FieldOffset(0xF0)] public BossMephilesWarpStatusData warpDatas__arr12;
        [FieldOffset(0x104)] public BossMephilesWarpStatusData warpDatas__arr13;
        [FieldOffset(0x118)] public BossMephilesWarpStatusData warpDatas__arr14;
        [FieldOffset(0x12C)] public BossMephilesWarpStatusData warpDatas__arr15;
        [FieldOffset(0x140)] public BossMephilesWarpStatusData warpDatas__arr16;
        [FieldOffset(0x154)] public BossMephilesWarpStatusData warpDatas__arr17;
        [FieldOffset(0x168)] public BossMephilesWarpStatusData warpDatas__arr18;
        [FieldOffset(0x17C)] public BossMephilesWarpStatusData warpDatas__arr19;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC0)]
    public struct BossMephilesWarpCameraAndPosition
    {
        [FieldOffset(0x00)] public BossMephilesFixedCamera warpCamera;
        [FieldOffset(0x40)] public Vector3 warpPositions__arr0;
        [FieldOffset(0x50)] public Vector3 warpPositions__arr1;
        [FieldOffset(0x60)] public Vector3 warpPositions__arr2;
        [FieldOffset(0x70)] public Vector3 warpPositions__arr3;
        [FieldOffset(0x80)] public Vector3 warpPositions__arr4;
        [FieldOffset(0x90)] public Vector3 warpPositions__arr5;
        [FieldOffset(0xA0)] public Vector3 warpPositions__arr6;
        [FieldOffset(0xB0)] public Vector3 warpPositions__arr7;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE50)]
    public struct BossMephilesWarpParam
    {
        [FieldOffset(0x00)] public BossMephilesWarpStatusTable warpTable__arr0;
        [FieldOffset(0x190)] public BossMephilesWarpStatusTable warpTable__arr1;
        [FieldOffset(0x320)] public BossMephilesWarpStatusTable warpTable__arr2;
        [FieldOffset(0x4B0)] public BossMephilesWarpStatusTable warpTable__arr3;
        [FieldOffset(0x640)] public BossMephilesWarpStatusTable warpTableByHard__arr0;
        [FieldOffset(0x7D0)] public BossMephilesWarpStatusTable warpTableByHard__arr1;
        [FieldOffset(0x960)] public BossMephilesWarpStatusTable warpTableByHard__arr2;
        [FieldOffset(0xAF0)] public BossMephilesWarpStatusTable warpTableByHard__arr3;
        [FieldOffset(0xC80)] public float warpDistanceByNormal;
        [FieldOffset(0xC84)] public float warpDistanceByCounter;
        [FieldOffset(0xC88)] public int useTableIndexMax;
        [FieldOffset(0xC90)] public BossMephilesFixedCamera counterCamera;
        [FieldOffset(0xCD0)] public BossMephilesWarpCameraAndPosition warpPattern__arr0;
        [FieldOffset(0xD90)] public BossMephilesWarpCameraAndPosition warpPattern__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct BossMephilesCameraExtensionParam
    {
        [FieldOffset(0x00)] public float addDistance;
        [FieldOffset(0x04)] public float addElevationOffset;
        [FieldOffset(0x08)] public float addTargetUpOffset;
        [FieldOffset(0x0C)] public float addTargetFrontOffset;
        [FieldOffset(0x10)] public float addLookatUpOffset;
        [FieldOffset(0x14)] public float addLookatWorldUpOffset;
        [FieldOffset(0x18)] public float addAzimuthOffset;
        [FieldOffset(0x1C)] public bool isDisableAvoidance;
        [FieldOffset(0x20)] public float time;
        [FieldOffset(0x24)] public float easeIn;
        [FieldOffset(0x28)] public float easeOut;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xFC0)]
    public struct BossMephilesCommonParam
    {
        [FieldOffset(0x00)] public BossMephilesDBlowHitParam dBlow;
        [FieldOffset(0xB0)] public BossMephilesWarpParam warp;
        [FieldOffset(0xF00)] public float battleAwayTime;
        [FieldOffset(0xF04)] public int cumulativeDamageLimits__arr0;
        [FieldOffset(0xF08)] public int cumulativeDamageLimits__arr1;
        [FieldOffset(0xF0C)] public int cumulativeDamageLimits__arr2;
        [FieldOffset(0xF10)] public int cumulativeDamageLimits__arr3;
        [FieldOffset(0xF14)] public int cumulativeDamageLimitsByHard__arr0;
        [FieldOffset(0xF18)] public int cumulativeDamageLimitsByHard__arr1;
        [FieldOffset(0xF1C)] public int cumulativeDamageLimitsByHard__arr2;
        [FieldOffset(0xF20)] public int cumulativeDamageLimitsByHard__arr3;
        [FieldOffset(0xF24)] public float spearDamageWaitTimes__arr0;
        [FieldOffset(0xF28)] public float spearDamageWaitTimes__arr1;
        [FieldOffset(0xF2C)] public float spearDamageWaitTimes__arr2;
        [FieldOffset(0xF30)] public float spearDamageWaitTimes__arr3;
        [FieldOffset(0xF40)] public BossMephilesFixedCamera spearDamageCamera;
        [FieldOffset(0xF80)] public BossMephilesCameraExtensionParam exStageOutSideCamera;
        [FieldOffset(0xFAC)] public float stageOutSideDistance;
        [FieldOffset(0xFB0)] public float stageOutSideMargin;
    }

    public enum ActionType : sbyte
    {
        INVALID_ACTION = 0,
        PHASE1_IDLE = 1,
        PHASE1_MINION = 2,
        PHASE1_BLADE = 3,
        PHASE1_DEMON = 4,
        PHASE2_IDLE = 5,
        ACTION_TYPE_NUM = 6
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct BossMephilesActionData
    {
        [FieldOffset(0x00)] public ActionType actionType;
        [FieldOffset(0x04)] public float time;
        [FieldOffset(0x08)] public int attackIndex;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x490)]
    public struct BossMephilesPhaseParam
    {
        [FieldOffset(0x00)] public int lifeCount;
        [FieldOffset(0x04)] public int healthPoint;
        [FieldOffset(0x08)] public int healthPointByHard;
        [FieldOffset(0x0C)] public int useTableIndexMax;
        [FieldOffset(0x10)] public BossMephilesActionData actionTable1__arr0;
        [FieldOffset(0x1C)] public BossMephilesActionData actionTable1__arr1;
        [FieldOffset(0x28)] public BossMephilesActionData actionTable1__arr2;
        [FieldOffset(0x34)] public BossMephilesActionData actionTable1__arr3;
        [FieldOffset(0x40)] public BossMephilesActionData actionTable1__arr4;
        [FieldOffset(0x4C)] public BossMephilesActionData actionTable1__arr5;
        [FieldOffset(0x58)] public BossMephilesActionData actionTable1__arr6;
        [FieldOffset(0x64)] public BossMephilesActionData actionTable1__arr7;
        [FieldOffset(0x70)] public BossMephilesActionData actionTable1__arr8;
        [FieldOffset(0x7C)] public BossMephilesActionData actionTable1__arr9;
        [FieldOffset(0x88)] public BossMephilesActionData actionTable1__arr10;
        [FieldOffset(0x94)] public BossMephilesActionData actionTable1__arr11;
        [FieldOffset(0xA0)] public BossMephilesActionData actionTable1__arr12;
        [FieldOffset(0xAC)] public BossMephilesActionData actionTable1__arr13;
        [FieldOffset(0xB8)] public BossMephilesActionData actionTable1__arr14;
        [FieldOffset(0xC4)] public BossMephilesActionData actionTable1__arr15;
        [FieldOffset(0xD0)] public BossMephilesActionData actionTable1__arr16;
        [FieldOffset(0xDC)] public BossMephilesActionData actionTable1__arr17;
        [FieldOffset(0xE8)] public BossMephilesActionData actionTable1__arr18;
        [FieldOffset(0xF4)] public BossMephilesActionData actionTable1__arr19;
        [FieldOffset(0x100)] public BossMephilesActionData actionTable1__arr20;
        [FieldOffset(0x10C)] public BossMephilesActionData actionTable1__arr21;
        [FieldOffset(0x118)] public BossMephilesActionData actionTable1__arr22;
        [FieldOffset(0x124)] public BossMephilesActionData actionTable1__arr23;
        [FieldOffset(0x130)] public BossMephilesActionData actionTable2__arr0;
        [FieldOffset(0x13C)] public BossMephilesActionData actionTable2__arr1;
        [FieldOffset(0x148)] public BossMephilesActionData actionTable2__arr2;
        [FieldOffset(0x154)] public BossMephilesActionData actionTable2__arr3;
        [FieldOffset(0x160)] public BossMephilesActionData actionTable2__arr4;
        [FieldOffset(0x16C)] public BossMephilesActionData actionTable2__arr5;
        [FieldOffset(0x178)] public BossMephilesActionData actionTable2__arr6;
        [FieldOffset(0x184)] public BossMephilesActionData actionTable2__arr7;
        [FieldOffset(0x190)] public BossMephilesActionData actionTable2__arr8;
        [FieldOffset(0x19C)] public BossMephilesActionData actionTable2__arr9;
        [FieldOffset(0x1A8)] public BossMephilesActionData actionTable2__arr10;
        [FieldOffset(0x1B4)] public BossMephilesActionData actionTable2__arr11;
        [FieldOffset(0x1C0)] public BossMephilesActionData actionTable2__arr12;
        [FieldOffset(0x1CC)] public BossMephilesActionData actionTable2__arr13;
        [FieldOffset(0x1D8)] public BossMephilesActionData actionTable2__arr14;
        [FieldOffset(0x1E4)] public BossMephilesActionData actionTable2__arr15;
        [FieldOffset(0x1F0)] public BossMephilesActionData actionTable2__arr16;
        [FieldOffset(0x1FC)] public BossMephilesActionData actionTable2__arr17;
        [FieldOffset(0x208)] public BossMephilesActionData actionTable2__arr18;
        [FieldOffset(0x214)] public BossMephilesActionData actionTable2__arr19;
        [FieldOffset(0x220)] public BossMephilesActionData actionTable2__arr20;
        [FieldOffset(0x22C)] public BossMephilesActionData actionTable2__arr21;
        [FieldOffset(0x238)] public BossMephilesActionData actionTable2__arr22;
        [FieldOffset(0x244)] public BossMephilesActionData actionTable2__arr23;
        [FieldOffset(0x250)] public BossMephilesActionData actionTable3__arr0;
        [FieldOffset(0x25C)] public BossMephilesActionData actionTable3__arr1;
        [FieldOffset(0x268)] public BossMephilesActionData actionTable3__arr2;
        [FieldOffset(0x274)] public BossMephilesActionData actionTable3__arr3;
        [FieldOffset(0x280)] public BossMephilesActionData actionTable3__arr4;
        [FieldOffset(0x28C)] public BossMephilesActionData actionTable3__arr5;
        [FieldOffset(0x298)] public BossMephilesActionData actionTable3__arr6;
        [FieldOffset(0x2A4)] public BossMephilesActionData actionTable3__arr7;
        [FieldOffset(0x2B0)] public BossMephilesActionData actionTable3__arr8;
        [FieldOffset(0x2BC)] public BossMephilesActionData actionTable3__arr9;
        [FieldOffset(0x2C8)] public BossMephilesActionData actionTable3__arr10;
        [FieldOffset(0x2D4)] public BossMephilesActionData actionTable3__arr11;
        [FieldOffset(0x2E0)] public BossMephilesActionData actionTable3__arr12;
        [FieldOffset(0x2EC)] public BossMephilesActionData actionTable3__arr13;
        [FieldOffset(0x2F8)] public BossMephilesActionData actionTable3__arr14;
        [FieldOffset(0x304)] public BossMephilesActionData actionTable3__arr15;
        [FieldOffset(0x310)] public BossMephilesActionData actionTable3__arr16;
        [FieldOffset(0x31C)] public BossMephilesActionData actionTable3__arr17;
        [FieldOffset(0x328)] public BossMephilesActionData actionTable3__arr18;
        [FieldOffset(0x334)] public BossMephilesActionData actionTable3__arr19;
        [FieldOffset(0x340)] public BossMephilesActionData actionTable3__arr20;
        [FieldOffset(0x34C)] public BossMephilesActionData actionTable3__arr21;
        [FieldOffset(0x358)] public BossMephilesActionData actionTable3__arr22;
        [FieldOffset(0x364)] public BossMephilesActionData actionTable3__arr23;
        [FieldOffset(0x370)] public BossMephilesActionData actionTable4__arr0;
        [FieldOffset(0x37C)] public BossMephilesActionData actionTable4__arr1;
        [FieldOffset(0x388)] public BossMephilesActionData actionTable4__arr2;
        [FieldOffset(0x394)] public BossMephilesActionData actionTable4__arr3;
        [FieldOffset(0x3A0)] public BossMephilesActionData actionTable4__arr4;
        [FieldOffset(0x3AC)] public BossMephilesActionData actionTable4__arr5;
        [FieldOffset(0x3B8)] public BossMephilesActionData actionTable4__arr6;
        [FieldOffset(0x3C4)] public BossMephilesActionData actionTable4__arr7;
        [FieldOffset(0x3D0)] public BossMephilesActionData actionTable4__arr8;
        [FieldOffset(0x3DC)] public BossMephilesActionData actionTable4__arr9;
        [FieldOffset(0x3E8)] public BossMephilesActionData actionTable4__arr10;
        [FieldOffset(0x3F4)] public BossMephilesActionData actionTable4__arr11;
        [FieldOffset(0x400)] public BossMephilesActionData actionTable4__arr12;
        [FieldOffset(0x40C)] public BossMephilesActionData actionTable4__arr13;
        [FieldOffset(0x418)] public BossMephilesActionData actionTable4__arr14;
        [FieldOffset(0x424)] public BossMephilesActionData actionTable4__arr15;
        [FieldOffset(0x430)] public BossMephilesActionData actionTable4__arr16;
        [FieldOffset(0x43C)] public BossMephilesActionData actionTable4__arr17;
        [FieldOffset(0x448)] public BossMephilesActionData actionTable4__arr18;
        [FieldOffset(0x454)] public BossMephilesActionData actionTable4__arr19;
        [FieldOffset(0x460)] public BossMephilesActionData actionTable4__arr20;
        [FieldOffset(0x46C)] public BossMephilesActionData actionTable4__arr21;
        [FieldOffset(0x478)] public BossMephilesActionData actionTable4__arr22;
        [FieldOffset(0x484)] public BossMephilesActionData actionTable4__arr23;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct BossMephilesPhase1StatusTable
    {
        [FieldOffset(0x00)] public float amoebaMoveSpeed;
        [FieldOffset(0x04)] public float amoebaMoveAccel;
        [FieldOffset(0x08)] public float amoebaMoveAngle;
        [FieldOffset(0x0C)] public float amoebaEscapeDistance;
        [FieldOffset(0x10)] public float amoebaPatrolSpeed;
        [FieldOffset(0x14)] public float amoebaPatrolDistance;
        [FieldOffset(0x18)] public float hideEndWait;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x130)]
    public struct BossMephilesPhase1Status
    {
        [FieldOffset(0x00)] public float floatingHeight;
        [FieldOffset(0x04)] public float initIdleTime;
        [FieldOffset(0x08)] public float idleTime;
        [FieldOffset(0x0C)] public float amoebaHitRadius;
        [FieldOffset(0x10)] public BossMephilesPhase1StatusTable statusTable__arr0;
        [FieldOffset(0x2C)] public BossMephilesPhase1StatusTable statusTable__arr1;
        [FieldOffset(0x48)] public BossMephilesPhase1StatusTable statusTable__arr2;
        [FieldOffset(0x64)] public BossMephilesPhase1StatusTable statusTable__arr3;
        [FieldOffset(0x80)] public BossMephilesPhase1StatusTable statusTableByHard__arr0;
        [FieldOffset(0x9C)] public BossMephilesPhase1StatusTable statusTableByHard__arr1;
        [FieldOffset(0xB8)] public BossMephilesPhase1StatusTable statusTableByHard__arr2;
        [FieldOffset(0xD4)] public BossMephilesPhase1StatusTable statusTableByHard__arr3;
        [FieldOffset(0xF0)] public BossMephilesFixedCamera hideEndCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BossMephilesMinionTable
    {
        [FieldOffset(0x00)] public int num;
        [FieldOffset(0x04)] public int amoebaMinionNum;
        [FieldOffset(0x08)] public int attackNum;
        [FieldOffset(0x0C)] public int attackCycle;
        [FieldOffset(0x10)] public float attackInitDelayNormal;
        [FieldOffset(0x14)] public float attackInitDelayAmoeba;
        [FieldOffset(0x18)] public float attackDelayNormal;
        [FieldOffset(0x1C)] public float attackDelayAmoeba;
        [FieldOffset(0x20)] public float time;
        [FieldOffset(0x24)] public int amoebaLotCycle;
        [FieldOffset(0x28)] public int amoebaLotValue;
        [FieldOffset(0x2C)] public int ringNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1E0)]
    public struct BossMephilesAttackMinion
    {
        [FieldOffset(0x00)] public float spawnRadiusMin;
        [FieldOffset(0x04)] public float spawnRadiusMax;
        [FieldOffset(0x08)] public float moveRadiusMin;
        [FieldOffset(0x0C)] public float moveRadiusMax;
        [FieldOffset(0x10)] public float moveDegree;
        [FieldOffset(0x14)] public float shakeDegree;
        [FieldOffset(0x18)] public float shakeSpeed;
        [FieldOffset(0x1C)] public float heightRatio;
        [FieldOffset(0x20)] public float attackSpeedNormal;
        [FieldOffset(0x24)] public float attackSpeedAmoeba;
        [FieldOffset(0x28)] public float attackSpeedNormalByHard;
        [FieldOffset(0x2C)] public float attackSpeedAmoebaByHard;
        [FieldOffset(0x30)] public float amoebaTargetActiveTime;
        [FieldOffset(0x34)] public BossMephilesMinionTable minionTable__arr0;
        [FieldOffset(0x64)] public BossMephilesMinionTable minionTable__arr1;
        [FieldOffset(0x94)] public BossMephilesMinionTable minionTable__arr2;
        [FieldOffset(0xC4)] public BossMephilesMinionTable minionTable__arr3;
        [FieldOffset(0xF4)] public BossMephilesMinionTable minionTableByHard__arr0;
        [FieldOffset(0x124)] public BossMephilesMinionTable minionTableByHard__arr1;
        [FieldOffset(0x154)] public BossMephilesMinionTable minionTableByHard__arr2;
        [FieldOffset(0x184)] public BossMephilesMinionTable minionTableByHard__arr3;
        [FieldOffset(0x1B4)] public BossMephilesCameraExtensionParam exCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct BossMephilesBladeTable
    {
        [FieldOffset(0x00)] public int num;
        [FieldOffset(0x04)] public int attackNum;
        [FieldOffset(0x08)] public int amoebaSpawnIdx1;
        [FieldOffset(0x0C)] public int amoebaSpawnIdx2;
        [FieldOffset(0x10)] public int amoebaSpawnIdx3;
        [FieldOffset(0x14)] public float aimSpeed;
        [FieldOffset(0x18)] public float aimTime;
        [FieldOffset(0x1C)] public float assaultSpeed;
        [FieldOffset(0x20)] public float time;
        [FieldOffset(0x24)] public float amoebaTargetActiveTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x16C)]
    public struct BossMephilesAttackBlade
    {
        [FieldOffset(0x00)] public BossMephilesBladeTable bladeTable__arr0;
        [FieldOffset(0x28)] public BossMephilesBladeTable bladeTable__arr1;
        [FieldOffset(0x50)] public BossMephilesBladeTable bladeTable__arr2;
        [FieldOffset(0x78)] public BossMephilesBladeTable bladeTable__arr3;
        [FieldOffset(0xA0)] public BossMephilesBladeTable bladeTableByHard__arr0;
        [FieldOffset(0xC8)] public BossMephilesBladeTable bladeTableByHard__arr1;
        [FieldOffset(0xF0)] public BossMephilesBladeTable bladeTableByHard__arr2;
        [FieldOffset(0x118)] public BossMephilesBladeTable bladeTableByHard__arr3;
        [FieldOffset(0x140)] public BossMephilesCameraExtensionParam exCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct BossMephilesLockonCameraParam
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float distance;
        [FieldOffset(0x08)] public float minElevation;
        [FieldOffset(0x0C)] public float maxElevation;
        [FieldOffset(0x10)] public float panningSuspensionK;
        [FieldOffset(0x14)] public float interiorPanningSuspensionK;
        [FieldOffset(0x18)] public float time;
        [FieldOffset(0x1C)] public float easeInTime;
        [FieldOffset(0x20)] public float easeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x530)]
    public struct BossMephilesPhase1Param
    {
        [FieldOffset(0x00)] public BossMephilesPhase1Status status;
        [FieldOffset(0x130)] public BossMephilesAttackMinion minion;
        [FieldOffset(0x310)] public BossMephilesAttackBlade blade;
        [FieldOffset(0x47C)] public BossMephilesCameraExtensionParam exCameraInit;
        [FieldOffset(0x4A8)] public BossMephilesCameraExtensionParam exCameraDamage;
        [FieldOffset(0x4D4)] public BossMephilesCameraExtensionParam exCameraHideChase;
        [FieldOffset(0x500)] public BossMephilesLockonCameraParam lockonCamera;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossMephilesPhase2StageLayerParam
    {
        [FieldOffset(0x00)] public UnmanagedString layerName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct BossMephilesDemonHandAttack
    {
        [FieldOffset(0x00)] public float reactionTime;
        [FieldOffset(0x04)] public float range;
        [FieldOffset(0x08)] public float rangeOffset;
        [FieldOffset(0x0C)] public float wavePointOffset;
        [FieldOffset(0x10)] public float waveRadus;
        [FieldOffset(0x14)] public float waveDelay;
        [FieldOffset(0x18)] public float waveTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1DC)]
    public struct BossMephilesAttackDemon
    {
        [FieldOffset(0x00)] public int lifeCountMax;
        [FieldOffset(0x04)] public int lifeCountMaxByHard;
        [FieldOffset(0x08)] public int hp;
        [FieldOffset(0x0C)] public int hpByHard;
        [FieldOffset(0x10)] public int shieldHp__arr0;
        [FieldOffset(0x14)] public int shieldHp__arr1;
        [FieldOffset(0x18)] public int shieldHp__arr2;
        [FieldOffset(0x1C)] public int shieldHp__arr3;
        [FieldOffset(0x20)] public float rotAnimSpeedRatios__arr0;
        [FieldOffset(0x24)] public float rotAnimSpeedRatios__arr1;
        [FieldOffset(0x28)] public float rotAnimSpeedRatios__arr2;
        [FieldOffset(0x2C)] public float rotAnimSpeedRatios__arr3;
        [FieldOffset(0x30)] public float hideMoveSpeed;
        [FieldOffset(0x34)] public float rotSpeedNormal;
        [FieldOffset(0x38)] public float rotSpeedAttack;
        [FieldOffset(0x3C)] public float rotSpeedHide;
        [FieldOffset(0x40)] public float waitTimeInit;
        [FieldOffset(0x44)] public float waitTimes__arr0;
        [FieldOffset(0x48)] public float waitTimes__arr1;
        [FieldOffset(0x4C)] public float waitTimes__arr2;
        [FieldOffset(0x50)] public float waitTimes__arr3;
        [FieldOffset(0x54)] public float waitTimesByHard__arr0;
        [FieldOffset(0x58)] public float waitTimesByHard__arr1;
        [FieldOffset(0x5C)] public float waitTimesByHard__arr2;
        [FieldOffset(0x60)] public float waitTimesByHard__arr3;
        [FieldOffset(0x64)] public float hideTime;
        [FieldOffset(0x68)] public float hideAttackRangeMin;
        [FieldOffset(0x6C)] public float hideAttackRange;
        [FieldOffset(0x70)] public float hideAttackColRadius;
        [FieldOffset(0x74)] public float hideAttackDelay;
        [FieldOffset(0x78)] public float hideMoveMarginDistance;
        [FieldOffset(0x7C)] public float hideEndDistance;
        [FieldOffset(0x80)] public float laserTimes__arr0;
        [FieldOffset(0x84)] public float laserTimes__arr1;
        [FieldOffset(0x88)] public float laserTimes__arr2;
        [FieldOffset(0x8C)] public float laserTimes__arr3;
        [FieldOffset(0x90)] public float laserAimSpeeds__arr0;
        [FieldOffset(0x94)] public float laserAimSpeeds__arr1;
        [FieldOffset(0x98)] public float laserAimSpeeds__arr2;
        [FieldOffset(0x9C)] public float laserAimSpeeds__arr3;
        [FieldOffset(0xA0)] public int amoebaTargetNum;
        [FieldOffset(0xA4)] public float amoebaTargetActiveTime;
        [FieldOffset(0xA8)] public float amoebaTargetSpawnDistanceCycle;
        [FieldOffset(0xAC)] public int dropRingNum;
        [FieldOffset(0xB0)] public int dropRingNumByHard;
        [FieldOffset(0xB4)] public float dropRingTime;
        [FieldOffset(0xB8)] public float finishLaunchPower;
        [FieldOffset(0xBC)] public float finishCameraLookAtHeight;
        [FieldOffset(0xC0)] public float finishBreakFakerCreateTime;
        [FieldOffset(0xC4)] public float finishBreakedMessageDelayTime;
        [FieldOffset(0xC8)] public float fakerAppearMoveTime;
        [FieldOffset(0xCC)] public float fakerAppearMoveUpRatio;
        [FieldOffset(0xD0)] public BossMephilesDemonHandAttack handAttack;
        [FieldOffset(0xEC)] public BossMephilesDemonHandAttack handAttackByHard;
        [FieldOffset(0x108)] public BossMephilesLockonCameraParam lockonCamera;
        [FieldOffset(0x12C)] public BossMephilesCameraExtensionParam exHideAttack;
        [FieldOffset(0x158)] public BossMephilesCameraExtensionParam exHideMove;
        [FieldOffset(0x184)] public BossMephilesCameraExtensionParam exLaser;
        [FieldOffset(0x1B0)] public BossMephilesCameraExtensionParam exDamage;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xF0)]
    public struct BossMephilesAttackPillar
    {
        [FieldOffset(0x00)] public float initStartDelay;
        [FieldOffset(0x04)] public float startDelay;
        [FieldOffset(0x08)] public float startDelayByHard;
        [FieldOffset(0x0C)] public float addStartDelay;
        [FieldOffset(0x10)] public float readyTime;
        [FieldOffset(0x14)] public float fallTime;
        [FieldOffset(0x18)] public float waitTime;
        [FieldOffset(0x1C)] public float waitTimeByHard;
        [FieldOffset(0x20)] public float riseTime;
        [FieldOffset(0x24)] public float launchSpeed;
        [FieldOffset(0x28)] public float launchSpeedByHard;
        [FieldOffset(0x2C)] public float launchSpeedKeepTime;
        [FieldOffset(0x30)] public float launchOutOfControlTime;
        [FieldOffset(0x34)] public float leanAngle;
        [FieldOffset(0x38)] public float leanTime;
        [FieldOffset(0x3C)] public int amoebaTargetNum;
        [FieldOffset(0x40)] public float amoebaTargetDelay;
        [FieldOffset(0x44)] public float amoebaTargetDistance;
        [FieldOffset(0x48)] public float waveRadius;
        [FieldOffset(0x4C)] public float waveDelay;
        [FieldOffset(0x50)] public float waveTime;
        [FieldOffset(0x54)] public float waveTimeByHard;
        [FieldOffset(0x58)] public float cameraHeightMin;
        [FieldOffset(0x5C)] public float cameraHeightMax;
        [FieldOffset(0x60)] public float cameraLookUpDelay;
        [FieldOffset(0x64)] public float cameraLookUpEaseTime;
        [FieldOffset(0x68)] public float cameraLookUpKeepTime;
        [FieldOffset(0x6C)] public float cameraReturnTime;
        [FieldOffset(0x70)] public UnmanagedString layerName;
        [FieldOffset(0x80)] public UnmanagedString endOffLayerName;
        [FieldOffset(0x90)] public BossMephilesFixedCamera fixedCamera;
        [FieldOffset(0xD0)] public float fixedCameraStartDelay;
        [FieldOffset(0xD4)] public float firstReactionStartDelay;
        [FieldOffset(0xD8)] public float firstReactionEndDelay;
        [FieldOffset(0xDC)] public float firstMoveTime;
        [FieldOffset(0xE0)] public float firstUpRatio;
        [FieldOffset(0xE4)] public float pillarCreateDelay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct BossMephilesAttackFaker
    {
        [FieldOffset(0x00)] public int num;
        [FieldOffset(0x04)] public int numByHard;
        [FieldOffset(0x08)] public int spBreakNum;
        [FieldOffset(0x0C)] public int spBreakActiveNum;
        [FieldOffset(0x10)] public int spBreakNumByHard;
        [FieldOffset(0x14)] public int spBreakActiveNumByHard;
        [FieldOffset(0x18)] public float floatingHeight;
        [FieldOffset(0x1C)] public float initSpawnRaidus;
        [FieldOffset(0x20)] public float initDelay;
        [FieldOffset(0x24)] public float delay;
        [FieldOffset(0x28)] public int breakCountrNum;
        [FieldOffset(0x2C)] public float attackPosRaidus;
        [FieldOffset(0x30)] public float straightAttackHitColRaidus;
        [FieldOffset(0x34)] public float straightAttackSpeed;
        [FieldOffset(0x38)] public float straightDelay;
        [FieldOffset(0x3C)] public float straightAddDelay;
        [FieldOffset(0x40)] public int straightNum;
        [FieldOffset(0x44)] public float straightDelayByHard;
        [FieldOffset(0x48)] public float straightAddDelayByHard;
        [FieldOffset(0x4C)] public int straightNumByHard;
        [FieldOffset(0x50)] public BossMephilesFixedCamera attackCamera;
        [FieldOffset(0x90)] public float soulSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3B0)]
    public struct BossMephilesPhase2Param
    {
        [FieldOffset(0x00)] public BossMephilesPhase2StageLayerParam startActiveLayers__arr0;
        [FieldOffset(0x10)] public BossMephilesPhase2StageLayerParam startActiveLayers__arr1;
        [FieldOffset(0x20)] public BossMephilesPhase2StageLayerParam startActiveLayers__arr2;
        [FieldOffset(0x30)] public BossMephilesPhase2StageLayerParam startActiveLayers__arr3;
        [FieldOffset(0x40)] public BossMephilesAttackDemon demon;
        [FieldOffset(0x220)] public BossMephilesAttackPillar pillar;
        [FieldOffset(0x310)] public BossMephilesAttackFaker faker;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x21C0)]
    public struct BossMephilesConfig
    {
        [FieldOffset(0x00)] public BossMephilesCommonParam commonParam;
        [FieldOffset(0xFC0)] public BossMephilesPhaseParam phaseParam__arr0;
        [FieldOffset(0x1450)] public BossMephilesPhaseParam phaseParam__arr1;
        [FieldOffset(0x18E0)] public BossMephilesPhase1Param phase1;
        [FieldOffset(0x1E10)] public BossMephilesPhase2Param phase2;
    }

}