Library "BossBiolizardConfig"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct BossBiolizardLockonCameraParam
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float fovy;
        [FieldOffset(0x08)] public float distance;
        [FieldOffset(0x0C)] public float offsetHeight;
        [FieldOffset(0x10)] public float offsetHeightAdded;
        [FieldOffset(0x14)] public float minElevation;
        [FieldOffset(0x18)] public float maxElevation;
        [FieldOffset(0x1C)] public float panningSuspensionK;
        [FieldOffset(0x20)] public float interiorPanningSuspensionK;
        [FieldOffset(0x24)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct BossBiolizardBodyPressParam
    {
        [FieldOffset(0x00)] public float pressBodyCollisionRadius;
        [FieldOffset(0x04)] public float pressBodyCollisionHeight;
        [FieldOffset(0x10)] public Vector3 pressNeckCollisionSize;
        [FieldOffset(0x20)] public float pressBodySensorRadius;
        [FieldOffset(0x24)] public float pressBodySensorHeight;
        [FieldOffset(0x30)] public Vector3 pressNeckSensorSize;
        [FieldOffset(0x40)] public Vector3 pressNeckSideSensorSize;
        [FieldOffset(0x50)] public Vector3 pressNeckSideSensorOffset;
        [FieldOffset(0x60)] public float pressStartTime;
        [FieldOffset(0x64)] public BossBiolizardLockonCameraParam lockonCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100)]
    public struct BossBiolizardCommonParam
    {
        [FieldOffset(0x00)] public float damageColliderRadius;
        [FieldOffset(0x04)] public float damageColliderHeight;
        [FieldOffset(0x10)] public Vector3 damageColliderOffset;
        [FieldOffset(0x20)] public float shockwaveColliderRadius;
        [FieldOffset(0x24)] public float shockwaveColliderHeight;
        [FieldOffset(0x30)] public Vector3 shockwaveColliderOffset;
        [FieldOffset(0x40)] public int coreDropRingNum;
        [FieldOffset(0x50)] public Vector3 coreDropRingOffset;
        [FieldOffset(0x60)] public float waterFlowRotateSpeed;
        [FieldOffset(0x64)] public float waterFlowIntakeSpeed;
        [FieldOffset(0x70)] public BossBiolizardBodyPressParam bodyPress;
    }

    public enum ActionType : int
    {
        INVALID_ACTION = 0,
        PHASE1_IDLE = 1,
        PHASE1_Y_ROT_HEAD = 2,
        PHASE1_Y_ROT_TAIL = 3,
        PHASE1_ENERGY_BALL = 4,
        PHASE1_DOWN = 5,
        PHASE2_IDLE = 6,
        PHASE2_HAND_NORMAL = 7,
        PHASE2_HAND_WAVE = 8,
        PHASE2_HAND_IKURA = 9,
        PHASE2_HAND_TRIPLE_0 = 10,
        PHASE2_HAND_TRIPLE_1 = 11,
        PHASE2_HAND_TRIPLE_2 = 12,
        PHASE2_HAND_TRIPLE_3 = 13,
        PHASE2_JUMP = 14,
        PHASE3_IDLE = 15,
        PHASE3_HOMING_IKURA_0 = 16,
        PHASE3_HOMING_IKURA_1 = 17,
        PHASE3_HOMING_IKURA_2 = 18,
        PHASE3_HOMING_IKURA_3 = 19,
        PHASE3_GIANT_IKURA = 20,
        ACTION_TYPE_NUM = 21
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct BossBiolizardActionData
    {
        [FieldOffset(0x00)] public ActionType actionType;
        [FieldOffset(0x04)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x310)]
    public struct BossBiolizardPhaseParam
    {
        [FieldOffset(0x00)] public int lifeCount;
        [FieldOffset(0x04)] public int healthPoint;
        [FieldOffset(0x08)] public BossBiolizardActionData actionTable__arr0;
        [FieldOffset(0x10)] public BossBiolizardActionData actionTable__arr1;
        [FieldOffset(0x18)] public BossBiolizardActionData actionTable__arr2;
        [FieldOffset(0x20)] public BossBiolizardActionData actionTable__arr3;
        [FieldOffset(0x28)] public BossBiolizardActionData actionTable__arr4;
        [FieldOffset(0x30)] public BossBiolizardActionData actionTable__arr5;
        [FieldOffset(0x38)] public BossBiolizardActionData actionTable__arr6;
        [FieldOffset(0x40)] public BossBiolizardActionData actionTable__arr7;
        [FieldOffset(0x48)] public BossBiolizardActionData actionTable__arr8;
        [FieldOffset(0x50)] public BossBiolizardActionData actionTable__arr9;
        [FieldOffset(0x58)] public BossBiolizardActionData actionTable__arr10;
        [FieldOffset(0x60)] public BossBiolizardActionData actionTable__arr11;
        [FieldOffset(0x68)] public BossBiolizardActionData actionTable__arr12;
        [FieldOffset(0x70)] public BossBiolizardActionData actionTable__arr13;
        [FieldOffset(0x78)] public BossBiolizardActionData actionTable__arr14;
        [FieldOffset(0x80)] public BossBiolizardActionData actionTable__arr15;
        [FieldOffset(0x88)] public BossBiolizardActionData actionTable2__arr0;
        [FieldOffset(0x90)] public BossBiolizardActionData actionTable2__arr1;
        [FieldOffset(0x98)] public BossBiolizardActionData actionTable2__arr2;
        [FieldOffset(0xA0)] public BossBiolizardActionData actionTable2__arr3;
        [FieldOffset(0xA8)] public BossBiolizardActionData actionTable2__arr4;
        [FieldOffset(0xB0)] public BossBiolizardActionData actionTable2__arr5;
        [FieldOffset(0xB8)] public BossBiolizardActionData actionTable2__arr6;
        [FieldOffset(0xC0)] public BossBiolizardActionData actionTable2__arr7;
        [FieldOffset(0xC8)] public BossBiolizardActionData actionTable2__arr8;
        [FieldOffset(0xD0)] public BossBiolizardActionData actionTable2__arr9;
        [FieldOffset(0xD8)] public BossBiolizardActionData actionTable2__arr10;
        [FieldOffset(0xE0)] public BossBiolizardActionData actionTable2__arr11;
        [FieldOffset(0xE8)] public BossBiolizardActionData actionTable2__arr12;
        [FieldOffset(0xF0)] public BossBiolizardActionData actionTable2__arr13;
        [FieldOffset(0xF8)] public BossBiolizardActionData actionTable2__arr14;
        [FieldOffset(0x100)] public BossBiolizardActionData actionTable2__arr15;
        [FieldOffset(0x108)] public BossBiolizardActionData actionTable3__arr0;
        [FieldOffset(0x110)] public BossBiolizardActionData actionTable3__arr1;
        [FieldOffset(0x118)] public BossBiolizardActionData actionTable3__arr2;
        [FieldOffset(0x120)] public BossBiolizardActionData actionTable3__arr3;
        [FieldOffset(0x128)] public BossBiolizardActionData actionTable3__arr4;
        [FieldOffset(0x130)] public BossBiolizardActionData actionTable3__arr5;
        [FieldOffset(0x138)] public BossBiolizardActionData actionTable3__arr6;
        [FieldOffset(0x140)] public BossBiolizardActionData actionTable3__arr7;
        [FieldOffset(0x148)] public BossBiolizardActionData actionTable3__arr8;
        [FieldOffset(0x150)] public BossBiolizardActionData actionTable3__arr9;
        [FieldOffset(0x158)] public BossBiolizardActionData actionTable3__arr10;
        [FieldOffset(0x160)] public BossBiolizardActionData actionTable3__arr11;
        [FieldOffset(0x168)] public BossBiolizardActionData actionTable3__arr12;
        [FieldOffset(0x170)] public BossBiolizardActionData actionTable3__arr13;
        [FieldOffset(0x178)] public BossBiolizardActionData actionTable3__arr14;
        [FieldOffset(0x180)] public BossBiolizardActionData actionTable3__arr15;
        [FieldOffset(0x188)] public BossBiolizardActionData actionTableByHard__arr0;
        [FieldOffset(0x190)] public BossBiolizardActionData actionTableByHard__arr1;
        [FieldOffset(0x198)] public BossBiolizardActionData actionTableByHard__arr2;
        [FieldOffset(0x1A0)] public BossBiolizardActionData actionTableByHard__arr3;
        [FieldOffset(0x1A8)] public BossBiolizardActionData actionTableByHard__arr4;
        [FieldOffset(0x1B0)] public BossBiolizardActionData actionTableByHard__arr5;
        [FieldOffset(0x1B8)] public BossBiolizardActionData actionTableByHard__arr6;
        [FieldOffset(0x1C0)] public BossBiolizardActionData actionTableByHard__arr7;
        [FieldOffset(0x1C8)] public BossBiolizardActionData actionTableByHard__arr8;
        [FieldOffset(0x1D0)] public BossBiolizardActionData actionTableByHard__arr9;
        [FieldOffset(0x1D8)] public BossBiolizardActionData actionTableByHard__arr10;
        [FieldOffset(0x1E0)] public BossBiolizardActionData actionTableByHard__arr11;
        [FieldOffset(0x1E8)] public BossBiolizardActionData actionTableByHard__arr12;
        [FieldOffset(0x1F0)] public BossBiolizardActionData actionTableByHard__arr13;
        [FieldOffset(0x1F8)] public BossBiolizardActionData actionTableByHard__arr14;
        [FieldOffset(0x200)] public BossBiolizardActionData actionTableByHard__arr15;
        [FieldOffset(0x208)] public BossBiolizardActionData actionTable2ByHard__arr0;
        [FieldOffset(0x210)] public BossBiolizardActionData actionTable2ByHard__arr1;
        [FieldOffset(0x218)] public BossBiolizardActionData actionTable2ByHard__arr2;
        [FieldOffset(0x220)] public BossBiolizardActionData actionTable2ByHard__arr3;
        [FieldOffset(0x228)] public BossBiolizardActionData actionTable2ByHard__arr4;
        [FieldOffset(0x230)] public BossBiolizardActionData actionTable2ByHard__arr5;
        [FieldOffset(0x238)] public BossBiolizardActionData actionTable2ByHard__arr6;
        [FieldOffset(0x240)] public BossBiolizardActionData actionTable2ByHard__arr7;
        [FieldOffset(0x248)] public BossBiolizardActionData actionTable2ByHard__arr8;
        [FieldOffset(0x250)] public BossBiolizardActionData actionTable2ByHard__arr9;
        [FieldOffset(0x258)] public BossBiolizardActionData actionTable2ByHard__arr10;
        [FieldOffset(0x260)] public BossBiolizardActionData actionTable2ByHard__arr11;
        [FieldOffset(0x268)] public BossBiolizardActionData actionTable2ByHard__arr12;
        [FieldOffset(0x270)] public BossBiolizardActionData actionTable2ByHard__arr13;
        [FieldOffset(0x278)] public BossBiolizardActionData actionTable2ByHard__arr14;
        [FieldOffset(0x280)] public BossBiolizardActionData actionTable2ByHard__arr15;
        [FieldOffset(0x288)] public BossBiolizardActionData actionTable3ByHard__arr0;
        [FieldOffset(0x290)] public BossBiolizardActionData actionTable3ByHard__arr1;
        [FieldOffset(0x298)] public BossBiolizardActionData actionTable3ByHard__arr2;
        [FieldOffset(0x2A0)] public BossBiolizardActionData actionTable3ByHard__arr3;
        [FieldOffset(0x2A8)] public BossBiolizardActionData actionTable3ByHard__arr4;
        [FieldOffset(0x2B0)] public BossBiolizardActionData actionTable3ByHard__arr5;
        [FieldOffset(0x2B8)] public BossBiolizardActionData actionTable3ByHard__arr6;
        [FieldOffset(0x2C0)] public BossBiolizardActionData actionTable3ByHard__arr7;
        [FieldOffset(0x2C8)] public BossBiolizardActionData actionTable3ByHard__arr8;
        [FieldOffset(0x2D0)] public BossBiolizardActionData actionTable3ByHard__arr9;
        [FieldOffset(0x2D8)] public BossBiolizardActionData actionTable3ByHard__arr10;
        [FieldOffset(0x2E0)] public BossBiolizardActionData actionTable3ByHard__arr11;
        [FieldOffset(0x2E8)] public BossBiolizardActionData actionTable3ByHard__arr12;
        [FieldOffset(0x2F0)] public BossBiolizardActionData actionTable3ByHard__arr13;
        [FieldOffset(0x2F8)] public BossBiolizardActionData actionTable3ByHard__arr14;
        [FieldOffset(0x300)] public BossBiolizardActionData actionTable3ByHard__arr15;
        [FieldOffset(0x308)] public int useActTblHealthPoint2;
        [FieldOffset(0x30C)] public int useActTblHealthPoint3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct BossBiolizardYRotParam
    {
        [FieldOffset(0x00)] public float motionSpeed;
        [FieldOffset(0x10)] public Vector3 headCollisionSize;
        [FieldOffset(0x20)] public Vector3 tailCollisionSize;
        [FieldOffset(0x30)] public Vector3 headBlockSize;
        [FieldOffset(0x40)] public Vector3 tailBlockSize;
        [FieldOffset(0x50)] public float footCollisionRadius;
        [FieldOffset(0x54)] public float footCollisionHeight;
        [FieldOffset(0x58)] public float blendMotionDistanceMin;
        [FieldOffset(0x5C)] public float blendMotionDistanceMax;
        [FieldOffset(0x60)] public BossBiolizardLockonCameraParam lockonCamera;
        [FieldOffset(0x88)] public float waitTime;
        [FieldOffset(0x8C)] public float changeDelayTime;
        [FieldOffset(0x90)] public float neckMoveDelayTime;
        [FieldOffset(0x94)] public float hitWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xD0)]
    public struct BossBiolizardEnergyBallParam
    {
        [FieldOffset(0x00)] public float chargeTime;
        [FieldOffset(0x04)] public float chargeTimeByHard;
        [FieldOffset(0x08)] public int shotNum;
        [FieldOffset(0x0C)] public int shotNumByHard;
        [FieldOffset(0x10)] public float shotDelayTime;
        [FieldOffset(0x14)] public float shotDelayTimeByHard;
        [FieldOffset(0x18)] public float frontSpeed;
        [FieldOffset(0x1C)] public float frontSpeedByHard;
        [FieldOffset(0x20)] public float sideSpeed;
        [FieldOffset(0x24)] public float sideSpeedByHard;
        [FieldOffset(0x28)] public float startSize;
        [FieldOffset(0x2C)] public float startSizeByHard;
        [FieldOffset(0x30)] public float maxSize;
        [FieldOffset(0x34)] public float maxSizeByHard;
        [FieldOffset(0x38)] public float endSize;
        [FieldOffset(0x3C)] public float endSizeByHard;
        [FieldOffset(0x40)] public float startHeight;
        [FieldOffset(0x44)] public float startHeightByHard;
        [FieldOffset(0x48)] public float maxHeight;
        [FieldOffset(0x4C)] public float maxHeightByHard;
        [FieldOffset(0x50)] public float endHeight;
        [FieldOffset(0x54)] public float endHeightByHard;
        [FieldOffset(0x58)] public float sizeUpDist;
        [FieldOffset(0x5C)] public float sizeUpDistByHard;
        [FieldOffset(0x60)] public float keepMaxDist;
        [FieldOffset(0x64)] public float keepMaxDistByHard;
        [FieldOffset(0x68)] public float sizeDownDist;
        [FieldOffset(0x6C)] public float sizeDownDistByHard;
        [FieldOffset(0x70)] public float endDist;
        [FieldOffset(0x74)] public float endDistByHard;
        [FieldOffset(0x78)] public float explodeSize;
        [FieldOffset(0x7C)] public float explodeSizeByHard;
        [FieldOffset(0x80)] public float explodeTime;
        [FieldOffset(0x84)] public float explodeTimeByHard;
        [FieldOffset(0x88)] public float hitWaitTime;
        [FieldOffset(0x8C)] public float hitWaitTimeByHard;
        [FieldOffset(0x90)] public BossBiolizardLockonCameraParam lockonCamera;
        [FieldOffset(0xC0)] public Vector3 spawnOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BossBiolizardPhase1CameraExtensionInfo
    {
        [FieldOffset(0x00)] public float addDistance;
        [FieldOffset(0x04)] public float addElevationOffset;
        [FieldOffset(0x08)] public float addTargetUpOffset;
        [FieldOffset(0x0C)] public float addLookatUpOffset;
        [FieldOffset(0x10)] public float addLookatWorldUpOffset;
        [FieldOffset(0x14)] public bool isDisableAvoidance;
        [FieldOffset(0x18)] public float easeIn;
        [FieldOffset(0x1C)] public float easeOut;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x54)]
    public struct BossBiolizardPhase1CameraExtensionParam
    {
        [FieldOffset(0x00)] public float nearCameraRange;
        [FieldOffset(0x04)] public float nearCameraMargin;
        [FieldOffset(0x08)] public BossBiolizardPhase1CameraExtensionInfo nearCameraInfo;
        [FieldOffset(0x28)] public float outrangeCameraAngle;
        [FieldOffset(0x2C)] public float outrangeCameraAngleOffset;
        [FieldOffset(0x30)] public float outrangeCameraAngleMargin;
        [FieldOffset(0x34)] public BossBiolizardPhase1CameraExtensionInfo outrangeCameraInfo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x360)]
    public struct BossBiolizardPhase1Param
    {
        [FieldOffset(0x00)] public BossBiolizardYRotParam yRotParam;
        [FieldOffset(0xA0)] public BossBiolizardEnergyBallParam energyBall;
        [FieldOffset(0x170)] public BossBiolizardLockonCameraParam waterLockonCamera;
        [FieldOffset(0x198)] public BossBiolizardLockonCameraParam downLockonCamera;
        [FieldOffset(0x1C0)] public BossBiolizardPhase1CameraExtensionParam extensionCamera;
        [FieldOffset(0x214)] public BossBiolizardPhase1CameraExtensionParam extensionCameraEB;
        [FieldOffset(0x268)] public float downPanCameraRatio;
        [FieldOffset(0x270)] public Vector3 downPanCameraOffset;
        [FieldOffset(0x280)] public Vector3 downPanCameraOffsetPlayer;
        [FieldOffset(0x290)] public float downPanCameraFadeTime;
        [FieldOffset(0x294)] public float downRailCameraDistance;
        [FieldOffset(0x2A0)] public Vector3 downRailCameraOffsetPlayer;
        [FieldOffset(0x2B0)] public float downRailCameraAzimuth;
        [FieldOffset(0x2B4)] public float downRailCameraElavation;
        [FieldOffset(0x2B8)] public float downRailCameraAnglePerSec;
        [FieldOffset(0x2BC)] public float downRailCameraFadeTime;
        [FieldOffset(0x2C0)] public float downRailGrindBoosterSpeed;
        [FieldOffset(0x2C4)] public BossBiolizardLockonCameraParam downSpringLockonCamera;
        [FieldOffset(0x2F0)] public Vector3 downSpringVelocity;
        [FieldOffset(0x300)] public BossBiolizardLockonCameraParam downEndHitCamera;
        [FieldOffset(0x328)] public BossBiolizardLockonCameraParam downEndMissCamera;
        [FieldOffset(0x350)] public float downEndHitMoveSpeed;
        [FieldOffset(0x354)] public float downEndMissMoveSpeed;
        [FieldOffset(0x358)] public float downEndHitSlideDistance;
        [FieldOffset(0x35C)] public float downEndMissSlideDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x06)]
    public struct BossBiolizardRoeArmTripleAttackInfo
    {
        [FieldOffset(0x00)] public bool isWave__arr0;
        [FieldOffset(0x01)] public bool isWave__arr1;
        [FieldOffset(0x02)] public bool isWave__arr2;
        [FieldOffset(0x03)] public bool isDebris__arr0;
        [FieldOffset(0x04)] public bool isDebris__arr1;
        [FieldOffset(0x05)] public bool isDebris__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct BossBiolizardRoeArm
    {
        [FieldOffset(0x00)] public int roeHandHp;
        [FieldOffset(0x04)] public int roeHandHpByHard__arr0;
        [FieldOffset(0x08)] public int roeHandHpByHard__arr1;
        [FieldOffset(0x0C)] public int roeHandHpByHard__arr2;
        [FieldOffset(0x10)] public int roeHandHpByHard__arr3;
        [FieldOffset(0x14)] public float roeHandSwingWaitTime;
        [FieldOffset(0x18)] public float roeHandBreakDamageTime;
        [FieldOffset(0x1C)] public float roeHandBreakDamageTimeByHard;
        [FieldOffset(0x20)] public float rangeDistanceMin;
        [FieldOffset(0x24)] public float rangeDistanceMax;
        [FieldOffset(0x28)] public float rangeAngel;
        [FieldOffset(0x2C)] public float rangeAngelOffset;
        [FieldOffset(0x30)] public float targetDelay;
        [FieldOffset(0x34)] public float breakPlayerHoldTime;
        [FieldOffset(0x38)] public BossBiolizardRoeArmTripleAttackInfo tripleAttacks__arr0;
        [FieldOffset(0x3E)] public BossBiolizardRoeArmTripleAttackInfo tripleAttacks__arr1;
        [FieldOffset(0x44)] public BossBiolizardRoeArmTripleAttackInfo tripleAttacks__arr2;
        [FieldOffset(0x4A)] public BossBiolizardRoeArmTripleAttackInfo tripleAttacks__arr3;
        [FieldOffset(0x50)] public BossBiolizardRoeArmTripleAttackInfo tripleAttacksByHard__arr0;
        [FieldOffset(0x56)] public BossBiolizardRoeArmTripleAttackInfo tripleAttacksByHard__arr1;
        [FieldOffset(0x5C)] public BossBiolizardRoeArmTripleAttackInfo tripleAttacksByHard__arr2;
        [FieldOffset(0x62)] public BossBiolizardRoeArmTripleAttackInfo tripleAttacksByHard__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossBiolizardAttackImpactWave
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float damageByHand;
        [FieldOffset(0x08)] public float damageByBody;
        [FieldOffset(0x0C)] public float delay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct BossBiolizardDropIkura
    {
        [FieldOffset(0x00)] public int roeHandAttackDropIkuraNum;
        [FieldOffset(0x04)] public int boundNum;
        [FieldOffset(0x08)] public float boundDecRatio;
        [FieldOffset(0x0C)] public float moveSpeed;
        [FieldOffset(0x10)] public float moveSpeedRandomRange;
        [FieldOffset(0x14)] public float shotAngleRandomRange;
        [FieldOffset(0x18)] public float downSpeed;
        [FieldOffset(0x1C)] public int chaosSpearBreakRingNum;
        [FieldOffset(0x20)] public int chaosSpearBreakRingNumByHard;
        [FieldOffset(0x24)] public float dBlownPowerRatioY;
        [FieldOffset(0x28)] public float dBlownPowerRatioXZ;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct BossBiolizardPointCamera
    {
        [FieldOffset(0x00)] public float fovy;
        [FieldOffset(0x04)] public float toPointDistanceMin;
        [FieldOffset(0x08)] public float toPointDistanceMax;
        [FieldOffset(0x0C)] public float distanceMin;
        [FieldOffset(0x10)] public float distanceMax;
        [FieldOffset(0x14)] public float gravityOffsetMin;
        [FieldOffset(0x18)] public float gravityOffsetMax;
        [FieldOffset(0x20)] public Vector3 playerOffsetMin;
        [FieldOffset(0x30)] public Vector3 playerOffsetMax;
        [FieldOffset(0x40)] public Vector3 worldOffsetMin;
        [FieldOffset(0x50)] public Vector3 worldOffsetMax;
        [FieldOffset(0x60)] public Vector3 pointLocalOffsetMin;
        [FieldOffset(0x70)] public Vector3 pointLocalOffsetMax;
        [FieldOffset(0x80)] public UnmanagedString nodeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BossBiolizardDamageCamera
    {
        [FieldOffset(0x00)] public float fovy;
        [FieldOffset(0x04)] public float distance;
        [FieldOffset(0x08)] public float elevation;
        [FieldOffset(0x0C)] public float gravityOffset;
        [FieldOffset(0x10)] public Vector3 worldOffset;
        [FieldOffset(0x20)] public float keepTime;
        [FieldOffset(0x24)] public float easeInTime;
        [FieldOffset(0x28)] public float easeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BossBiolizardArmBreakCamera
    {
        [FieldOffset(0x00)] public float fovy;
        [FieldOffset(0x04)] public float distance;
        [FieldOffset(0x08)] public float elevation;
        [FieldOffset(0x0C)] public float rotation;
        [FieldOffset(0x10)] public float gravityOffset;
        [FieldOffset(0x20)] public Vector3 worldOffset;
        [FieldOffset(0x30)] public float keepTime;
        [FieldOffset(0x34)] public float easeInTime;
        [FieldOffset(0x38)] public float easeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BossBiolizardStuckCollisionData
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float height;
        [FieldOffset(0x10)] public Vector3 position;
        [FieldOffset(0x20)] public Vector3 rotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3A0)]
    public struct BossBiolizardPhase2Param
    {
        [FieldOffset(0x00)] public float roeArmBreakIkuraTime;
        [FieldOffset(0x04)] public float battleAreaMoveDistance;
        [FieldOffset(0x08)] public float defaultCameraDistanceScale;
        [FieldOffset(0x0C)] public float ikuraCameraDistanceScale;
        [FieldOffset(0x10)] public float ikuraCameraDistanceKeepTime;
        [FieldOffset(0x14)] public float handAttackSuccessAddWaitTime;
        [FieldOffset(0x18)] public int breakRingNum;
        [FieldOffset(0x1C)] public int timeStopBreakRingNum;
        [FieldOffset(0x20)] public int breakRingNumByHard;
        [FieldOffset(0x24)] public int timeStopBreakRingNumByHard;
        [FieldOffset(0x28)] public BossBiolizardRoeArm roeArm;
        [FieldOffset(0x90)] public BossBiolizardAttackImpactWave wave;
        [FieldOffset(0xA0)] public BossBiolizardAttackImpactWave waveTriple;
        [FieldOffset(0xB0)] public BossBiolizardAttackImpactWave waveTripleByHard__arr0;
        [FieldOffset(0xC0)] public BossBiolizardAttackImpactWave waveTripleByHard__arr1;
        [FieldOffset(0xD0)] public BossBiolizardAttackImpactWave waveTripleByHard__arr2;
        [FieldOffset(0xE0)] public BossBiolizardAttackImpactWave waveTripleByHard__arr3;
        [FieldOffset(0xF0)] public BossBiolizardDropIkura dropIkura;
        [FieldOffset(0x120)] public BossBiolizardPointCamera camera;
        [FieldOffset(0x1B0)] public BossBiolizardDamageCamera damageCamera;
        [FieldOffset(0x1E0)] public BossBiolizardArmBreakCamera armBreakCamera;
        [FieldOffset(0x220)] public BossBiolizardArmBreakCamera armBreakCameraTS;
        [FieldOffset(0x260)] public BossBiolizardPhase1CameraExtensionInfo armBreakedDownCameraInfo;
        [FieldOffset(0x280)] public BossBiolizardStuckCollisionData stuckCollisions__arr0;
        [FieldOffset(0x2B0)] public BossBiolizardStuckCollisionData stuckCollisions__arr1;
        [FieldOffset(0x2E0)] public BossBiolizardStuckCollisionData stuckCollisions__arr2;
        [FieldOffset(0x310)] public BossBiolizardStuckCollisionData stuckCollisions__arr3;
        [FieldOffset(0x340)] public BossBiolizardStuckCollisionData stuckCollisions__arr4;
        [FieldOffset(0x370)] public BossBiolizardStuckCollisionData stuckCollisions__arr5;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct BossBiolizardPhase3Param
    {
        [FieldOffset(0x00)] public int roeHandAttackDropIkuraNum;
    }

    public enum ShotType : int
    {
        NONE = 0,
        ONE_SHOT = 1,
        ONE_SHOT_PLAYER = 2,
        ONE_SHOT_HOMING = 3,
        MULTI_SHOT = 4,
        MULTI_SHOT_HOMING = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct BossBiolizardHomingIkuraTableDataParam
    {
        [FieldOffset(0x00)] public ShotType type;
        [FieldOffset(0x04)] public int num;
        [FieldOffset(0x08)] public float waitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x120)]
    public struct BossBiolizardHomingIkuraTableParam
    {
        [FieldOffset(0x00)] public BossBiolizardHomingIkuraTableDataParam tableData__arr0;
        [FieldOffset(0x0C)] public BossBiolizardHomingIkuraTableDataParam tableData__arr1;
        [FieldOffset(0x18)] public BossBiolizardHomingIkuraTableDataParam tableData__arr2;
        [FieldOffset(0x24)] public BossBiolizardHomingIkuraTableDataParam tableData__arr3;
        [FieldOffset(0x30)] public BossBiolizardHomingIkuraTableDataParam tableData__arr4;
        [FieldOffset(0x3C)] public BossBiolizardHomingIkuraTableDataParam tableData__arr5;
        [FieldOffset(0x48)] public BossBiolizardHomingIkuraTableDataParam tableData__arr6;
        [FieldOffset(0x54)] public BossBiolizardHomingIkuraTableDataParam tableData__arr7;
        [FieldOffset(0x60)] public BossBiolizardHomingIkuraTableDataParam tableData__arr8;
        [FieldOffset(0x6C)] public BossBiolizardHomingIkuraTableDataParam tableData__arr9;
        [FieldOffset(0x78)] public BossBiolizardHomingIkuraTableDataParam tableData__arr10;
        [FieldOffset(0x84)] public BossBiolizardHomingIkuraTableDataParam tableData__arr11;
        [FieldOffset(0x90)] public BossBiolizardHomingIkuraTableDataParam tableData__arr12;
        [FieldOffset(0x9C)] public BossBiolizardHomingIkuraTableDataParam tableData__arr13;
        [FieldOffset(0xA8)] public BossBiolizardHomingIkuraTableDataParam tableData__arr14;
        [FieldOffset(0xB4)] public BossBiolizardHomingIkuraTableDataParam tableData__arr15;
        [FieldOffset(0xC0)] public BossBiolizardHomingIkuraTableDataParam tableData__arr16;
        [FieldOffset(0xCC)] public BossBiolizardHomingIkuraTableDataParam tableData__arr17;
        [FieldOffset(0xD8)] public BossBiolizardHomingIkuraTableDataParam tableData__arr18;
        [FieldOffset(0xE4)] public BossBiolizardHomingIkuraTableDataParam tableData__arr19;
        [FieldOffset(0xF0)] public BossBiolizardHomingIkuraTableDataParam tableData__arr20;
        [FieldOffset(0xFC)] public BossBiolizardHomingIkuraTableDataParam tableData__arr21;
        [FieldOffset(0x108)] public BossBiolizardHomingIkuraTableDataParam tableData__arr22;
        [FieldOffset(0x114)] public BossBiolizardHomingIkuraTableDataParam tableData__arr23;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x560)]
    public struct BossBiolizardHomingIkuraParam
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float hitRadius;
        [FieldOffset(0x08)] public float bodyRadius;
        [FieldOffset(0x0C)] public float speed;
        [FieldOffset(0x10)] public float minSpeed;
        [FieldOffset(0x14)] public float decelePower;
        [FieldOffset(0x18)] public float speedRandom;
        [FieldOffset(0x1C)] public float minSpeedRandom;
        [FieldOffset(0x20)] public float decelePowerRandom;
        [FieldOffset(0x24)] public bool enableChaosSpearRandom;
        [FieldOffset(0x28)] public float lifeTime;
        [FieldOffset(0x2C)] public float homingAngularSpeed;
        [FieldOffset(0x30)] public float homingEndDistance;
        [FieldOffset(0x34)] public float homingEndHeight;
        [FieldOffset(0x38)] public int firstSpawnNum;
        [FieldOffset(0x40)] public Vector3 spawnAreaSize;
        [FieldOffset(0x50)] public Vector3 spawnAreaOffset;
        [FieldOffset(0x60)] public Vector3 spawnNumMax;
        [FieldOffset(0x70)] public float appearWaitTime;
        [FieldOffset(0x74)] public float startWaitTime;
        [FieldOffset(0x78)] public float endWaitTime;
        [FieldOffset(0x7C)] public float endWaitTimeByGaugeMax;
        [FieldOffset(0x80)] public float floatSEDelay;
        [FieldOffset(0x84)] public int ringNum;
        [FieldOffset(0x90)] public Vector3 attackCenter;
        [FieldOffset(0xA0)] public float attackRadius;
        [FieldOffset(0xA4)] public BossBiolizardLockonCameraParam nearDistLockonCamera;
        [FieldOffset(0xD0)] public Vector3 nearDistCameraOffset;
        [FieldOffset(0xE0)] public BossBiolizardHomingIkuraTableParam numTable__arr0;
        [FieldOffset(0x200)] public BossBiolizardHomingIkuraTableParam numTable__arr1;
        [FieldOffset(0x320)] public BossBiolizardHomingIkuraTableParam numTable__arr2;
        [FieldOffset(0x440)] public BossBiolizardHomingIkuraTableParam numTable__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct BossBiolizardGiantIkuraStartCamera
    {
        [FieldOffset(0x00)] public float fovy;
        [FieldOffset(0x04)] public float roll;
        [FieldOffset(0x10)] public Vector3 target;
        [FieldOffset(0x20)] public Vector3 position;
        [FieldOffset(0x30)] public Vector3 up;
        [FieldOffset(0x40)] public float delay;
        [FieldOffset(0x44)] public float keepTime;
        [FieldOffset(0x48)] public float easeInTime;
        [FieldOffset(0x4C)] public float easeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BossBiolizardFixedCamera
    {
        [FieldOffset(0x00)] public Vector3 eyeLocalOffset;
        [FieldOffset(0x10)] public Vector3 lookAtLocalOffset;
        [FieldOffset(0x20)] public float fov;
        [FieldOffset(0x24)] public float roll;
        [FieldOffset(0x28)] public float easeInTime;
        [FieldOffset(0x2C)] public float easeOutTime;
        [FieldOffset(0x30)] public float keepTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xD0)]
    public struct BossBiolizardGiantIkuraParam
    {
        [FieldOffset(0x00)] public float radius;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public int health;
        [FieldOffset(0x0C)] public int childNum;
        [FieldOffset(0x10)] public float childSpawnTime;
        [FieldOffset(0x14)] public float childSpeedMin;
        [FieldOffset(0x18)] public float childSpeedMax;
        [FieldOffset(0x1C)] public float childLifeTime;
        [FieldOffset(0x20)] public float timeStopGaugeStopTime;
        [FieldOffset(0x30)] public BossBiolizardGiantIkuraStartCamera startCamera;
        [FieldOffset(0x80)] public BossBiolizardFixedCamera fixedCamera;
        [FieldOffset(0xC0)] public float fixedCameraStartDelay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC00)]
    public struct BossBiolizardPhase4Param
    {
        [FieldOffset(0x00)] public BossBiolizardHomingIkuraParam homingIkura;
        [FieldOffset(0x560)] public BossBiolizardHomingIkuraParam homingIkuraByHard;
        [FieldOffset(0xAC0)] public BossBiolizardGiantIkuraParam giantIkura;
        [FieldOffset(0xB90)] public float downTime;
        [FieldOffset(0xB94)] public float cameraDistanceScale;
        [FieldOffset(0xB98)] public BossBiolizardLockonCameraParam waterLockonCamera;
        [FieldOffset(0xBC0)] public Vector3 waterCameraOffset;
        [FieldOffset(0xBD0)] public BossBiolizardLockonCameraParam lockonCamera;
        [FieldOffset(0xBF8)] public float chaosSpearInputGuideDelayTime;
        [FieldOffset(0xBFC)] public sbyte chaosSpearGuideDispInputCount;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2050)]
    public struct BossBiolizardConfig
    {
        [FieldOffset(0x00)] public BossBiolizardCommonParam commonParam;
        [FieldOffset(0x100)] public BossBiolizardPhaseParam phaseParam__arr0;
        [FieldOffset(0x410)] public BossBiolizardPhaseParam phaseParam__arr1;
        [FieldOffset(0x720)] public BossBiolizardPhaseParam phaseParam__arr2;
        [FieldOffset(0xA30)] public BossBiolizardPhaseParam phaseParam__arr3;
        [FieldOffset(0xD40)] public BossBiolizardPhase1Param phase1;
        [FieldOffset(0x10A0)] public BossBiolizardPhase2Param phase2;
        [FieldOffset(0x1440)] public BossBiolizardPhase3Param phase3;
        [FieldOffset(0x1450)] public BossBiolizardPhase4Param phase4;
    }

}