using System.Numerics;
using System.Runtime.InteropServices;

public class BossRifleConfigClass
{
    public struct CSetObjectID
    {
        public unsafe fixed byte GUID[16];
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct CSetObjectIDArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct PlayerMoveableRangeParam
    {
        [FieldOffset(0x00)] public CSetObjectIDArray initPositions;
        [FieldOffset(0x20)] public UnmanagedString heightTargetNodeName;
        [FieldOffset(0x30)] public float heightMoveSpeed;
        [FieldOffset(0x34)] public float bossToPlayerDistanceMin;
        [FieldOffset(0x38)] public float bossToPlayerDistanceMax;
        [FieldOffset(0x3C)] public float offsetHeightMin;
        [FieldOffset(0x40)] public float offsetHeightMax;
        [FieldOffset(0x44)] public float areaDistanceMin;
        [FieldOffset(0x48)] public float areaDistanceMax;
        [FieldOffset(0x4C)] public float playerSpawnDistance;
        [FieldOffset(0x50)] public float playerRespawnDistance;
        [FieldOffset(0x54)] public float playerRespawnDistance2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct BossPhaseParam
    {
        [FieldOffset(0x00)] public bool isUse;
        [FieldOffset(0x01)] public bool isUsePillar;
        [FieldOffset(0x04)] public float phaseChangeHpRatio;
    }

    public enum EaseType : sbyte
    {
        ET_Sin = 0,
        ET_Cubic = 1,
        ET_Quadratic = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct BossLockOnCameraParam
    {
        [FieldOffset(0x00)] public float easeTime;
        [FieldOffset(0x04)] public EaseType easeType;
        [FieldOffset(0x08)] public UnmanagedString mainLookAtNodeName;
        [FieldOffset(0x20)] public Vector3 mainLookOffsetPos;
        [FieldOffset(0x30)] public UnmanagedString subLookAtNodeName;
        [FieldOffset(0x40)] public Vector3 subLookOffsetPos;
        [FieldOffset(0x50)] public float distance;
        [FieldOffset(0x60)] public Vector3 playerOffsetPos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1A0)]
    public struct BossStatusConfig
    {
        [FieldOffset(0x00)] public uint healthPoint;
        [FieldOffset(0x04)] public float stunTime;
        [FieldOffset(0x08)] public float maxStunPoint__arr0;
        [FieldOffset(0x0C)] public float maxStunPoint__arr1;
        [FieldOffset(0x10)] public float maxStunPoint__arr2;
        [FieldOffset(0x14)] public float maxStaggerPoint__arr0;
        [FieldOffset(0x18)] public float maxStaggerPoint__arr1;
        [FieldOffset(0x1C)] public float maxStaggerPoint__arr2;
        [FieldOffset(0x20)] public float maxStaggerPoint__arr3;
        [FieldOffset(0x24)] public float maxStaggerPoint__arr4;
        [FieldOffset(0x28)] public ushort exp;
        [FieldOffset(0x30)] public PlayerMoveableRangeParam moveRangeParam;
        [FieldOffset(0x88)] public PlayerMoveableRangeParam cyloopDamageMoveRangeParam;
        [FieldOffset(0xE0)] public BossPhaseParam phaseParams__arr0;
        [FieldOffset(0xE8)] public BossPhaseParam phaseParams__arr1;
        [FieldOffset(0xF0)] public BossPhaseParam phaseParams__arr2;
        [FieldOffset(0xF8)] public BossPhaseParam phaseParams__arr3;
        [FieldOffset(0x100)] public BossPhaseParam phaseParams__arr4;
        [FieldOffset(0x108)] public BossPhaseParam phaseParams__arr5;
        [FieldOffset(0x110)] public BossPhaseParam phaseParams__arr6;
        [FieldOffset(0x118)] public BossPhaseParam phaseParams__arr7;
        [FieldOffset(0x120)] public BossLockOnCameraParam cameraParam;
        [FieldOffset(0x190)] public bool isDebugDraw;
        [FieldOffset(0x194)] public uint debugDrawPhaseIndex;
    }

    public enum GimmickType : sbyte
    {
        GT_A = 0,
        GT_B = 1,
        GT_C = 2,
        GT_D = 3,
        GT_E = 4,
        NUM_GIMMICK_TYPE = 5
    }

    public enum AttackType : sbyte
    {
        AT_A = 0,
        AT_B = 1,
        AT_C = 2,
        AT_D = 3,
        AT_E = 4,
        NUM_ATTACK_TYPE = 5
    }

    public enum BossPillarParam_GimmickType : sbyte
    {
        BossPillarParam_GimmickType_GT_A = 0,
        BossPillarParam_GimmickType_GT_B = 1,
        BossPillarParam_GimmickType_GT_C = 2,
        BossPillarParam_GimmickType_GT_D = 3,
        BossPillarParam_GimmickType_GT_E = 4,
        BossPillarParam_GimmickType_NUM_GIMMICK_TYPE = 5
    }

    public enum BossPillarParam_AttackType : sbyte
    {
        BossPillarParam_AttackType_AT_A = 0,
        BossPillarParam_AttackType_AT_B = 1,
        BossPillarParam_AttackType_AT_C = 2,
        BossPillarParam_AttackType_AT_D = 3,
        BossPillarParam_AttackType_AT_E = 4,
        BossPillarParam_AttackType_NUM_ATTACK_TYPE = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct BossPillarParam
    {
        [FieldOffset(0x00)] public bool isUse;
        [FieldOffset(0x04)] public float gimmickPhaseTime;
        [FieldOffset(0x08)] public float attackPhaseTime;
        [FieldOffset(0x0C)] public bool isUnique;
        [FieldOffset(0x0D)] public BossPillarParam_GimmickType gimmickType;
        [FieldOffset(0x10)] public float gimmickIntervalTime;
        [FieldOffset(0x14)] public BossPillarParam_AttackType attackType;
        [FieldOffset(0x18)] public float attackIntervalTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3B8)]
    public struct BossPillarConfig
    {
        [FieldOffset(0x00)] public GimmickType gimmickTypeAll;
        [FieldOffset(0x04)] public float gimmickIntervalTimeAll;
        [FieldOffset(0x08)] public AttackType attackTypeAll;
        [FieldOffset(0x0C)] public float attackIntervalTimeAll;
        [FieldOffset(0x10)] public BossPillarParam pillars__arr0;
        [FieldOffset(0x2C)] public BossPillarParam pillars__arr1;
        [FieldOffset(0x48)] public BossPillarParam pillars__arr2;
        [FieldOffset(0x64)] public BossPillarParam pillars__arr3;
        [FieldOffset(0x80)] public BossPillarParam pillars__arr4;
        [FieldOffset(0x9C)] public BossPillarParam pillars__arr5;
        [FieldOffset(0xB8)] public BossPillarParam pillars__arr6;
        [FieldOffset(0xD4)] public BossPillarParam pillars__arr7;
        [FieldOffset(0xF0)] public BossPillarParam pillars__arr8;
        [FieldOffset(0x10C)] public BossPillarParam pillars__arr9;
        [FieldOffset(0x128)] public BossPillarParam pillars__arr10;
        [FieldOffset(0x144)] public BossPillarParam pillars__arr11;
        [FieldOffset(0x160)] public BossPillarParam pillars__arr12;
        [FieldOffset(0x17C)] public BossPillarParam pillars__arr13;
        [FieldOffset(0x198)] public BossPillarParam pillars__arr14;
        [FieldOffset(0x1B4)] public BossPillarParam pillars__arr15;
        [FieldOffset(0x1D0)] public BossPillarParam pillars__arr16;
        [FieldOffset(0x1EC)] public BossPillarParam pillars__arr17;
        [FieldOffset(0x208)] public BossPillarParam pillars__arr18;
        [FieldOffset(0x224)] public BossPillarParam pillars__arr19;
        [FieldOffset(0x240)] public BossPillarParam pillars__arr20;
        [FieldOffset(0x25C)] public BossPillarParam pillars__arr21;
        [FieldOffset(0x278)] public BossPillarParam pillars__arr22;
        [FieldOffset(0x294)] public BossPillarParam pillars__arr23;
        [FieldOffset(0x2B0)] public BossPillarParam pillars__arr24;
        [FieldOffset(0x2CC)] public BossPillarParam pillars__arr25;
        [FieldOffset(0x2E8)] public BossPillarParam pillars__arr26;
        [FieldOffset(0x304)] public BossPillarParam pillars__arr27;
        [FieldOffset(0x320)] public BossPillarParam pillars__arr28;
        [FieldOffset(0x33C)] public BossPillarParam pillars__arr29;
        [FieldOffset(0x358)] public BossPillarParam pillars__arr30;
        [FieldOffset(0x374)] public BossPillarParam pillars__arr31;
        [FieldOffset(0x390)] public UnmanagedString spawnPositionName;
        [FieldOffset(0x3A0)] public uint pillarHealthPoint;
        [FieldOffset(0x3A4)] public uint pillarBreakDamage;
        [FieldOffset(0x3A8)] public float pillarBreakStun;
        [FieldOffset(0x3AC)] public bool isDebugDraw;
        [FieldOffset(0x3B0)] public uint DebugDrawType;
    }

    public enum CollisionType : sbyte
    {
        CT_SPHERE = 0,
        CT_CAPSULE = 1,
        CT_CYLINDER = 2,
        CT_BOX = 3,
        NUM_COLLISION_TYPE = 4
    }

    public enum ColliderActiveType : sbyte
    {
        Always = 0,
        OnContactActive = 1,
        OnContactInactive = 2,
        OnMotionActive = 3,
        OnMotionInactive = 4,
        Manual = 5,
        NUM_COLLIDER_ACTIVE_TYPE = 6
    }

    public enum ColliderProperty : short
    {
        CpNone = 0,
        CpBattleUse = 1,
        CpBattleUnuse = 2,
        CpRestPoint = 3,
        CpHomingTarget = 4,
        CpPerceive = 5,
        CpDamage = 6,
        CpAttack = 7,
        CpContactActive = 8,
        CpContactInactive = 9,
        CpMotionActive = 10,
        CpMotionInactive = 11,
        CpManual = 12,
        CpUpperSide = 13,
        CpLowerSide = 14,
        CpFrontSide = 15,
        CpBackSide = 16,
        CpLeftSide = 17,
        CpRightSide = 18,
        CpPointA = 19,
        CpPointB = 20,
        CpPointC = 21,
        CpPointD = 22,
        CpCyloopDownUnuse = 23,
        CpDummyDamage = 24,
        CpCable = 25,
        CpTackleHand = 26,
        NUM_COLLIDER_PROPERTY = 27
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BossColliderStatus
    {
        [FieldOffset(0x00)] public ColliderActiveType type;
        [FieldOffset(0x02)] public ColliderProperty propertys__arr0;
        [FieldOffset(0x04)] public ColliderProperty propertys__arr1;
        [FieldOffset(0x06)] public ColliderProperty propertys__arr2;
        [FieldOffset(0x08)] public ColliderProperty propertys__arr3;
        [FieldOffset(0x10)] public UnmanagedString text;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct BossPerceiveCollisionParam
    {
        [FieldOffset(0x00)] public bool isUse;
        [FieldOffset(0x02)] public short priority;
        [FieldOffset(0x04)] public CollisionType type;
        [FieldOffset(0x08)] public UnmanagedString attachNodeName;
        [FieldOffset(0x18)] public UnmanagedString name;
        [FieldOffset(0x28)] public BossColliderStatus status;
        [FieldOffset(0x50)] public Vector3 size;
        [FieldOffset(0x60)] public Vector3 offset;
        [FieldOffset(0x70)] public Vector3 rotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2010)]
    public struct BossPerceivePartsWithCollisionConfig
    {
        [FieldOffset(0x00)] public BossPerceiveCollisionParam perceiveCollisions__arr0;
        [FieldOffset(0x80)] public BossPerceiveCollisionParam perceiveCollisions__arr1;
        [FieldOffset(0x100)] public BossPerceiveCollisionParam perceiveCollisions__arr2;
        [FieldOffset(0x180)] public BossPerceiveCollisionParam perceiveCollisions__arr3;
        [FieldOffset(0x200)] public BossPerceiveCollisionParam perceiveCollisions__arr4;
        [FieldOffset(0x280)] public BossPerceiveCollisionParam perceiveCollisions__arr5;
        [FieldOffset(0x300)] public BossPerceiveCollisionParam perceiveCollisions__arr6;
        [FieldOffset(0x380)] public BossPerceiveCollisionParam perceiveCollisions__arr7;
        [FieldOffset(0x400)] public BossPerceiveCollisionParam perceiveCollisions__arr8;
        [FieldOffset(0x480)] public BossPerceiveCollisionParam perceiveCollisions__arr9;
        [FieldOffset(0x500)] public BossPerceiveCollisionParam perceiveCollisions__arr10;
        [FieldOffset(0x580)] public BossPerceiveCollisionParam perceiveCollisions__arr11;
        [FieldOffset(0x600)] public BossPerceiveCollisionParam perceiveCollisions__arr12;
        [FieldOffset(0x680)] public BossPerceiveCollisionParam perceiveCollisions__arr13;
        [FieldOffset(0x700)] public BossPerceiveCollisionParam perceiveCollisions__arr14;
        [FieldOffset(0x780)] public BossPerceiveCollisionParam perceiveCollisions__arr15;
        [FieldOffset(0x800)] public BossPerceiveCollisionParam perceiveCollisions__arr16;
        [FieldOffset(0x880)] public BossPerceiveCollisionParam perceiveCollisions__arr17;
        [FieldOffset(0x900)] public BossPerceiveCollisionParam perceiveCollisions__arr18;
        [FieldOffset(0x980)] public BossPerceiveCollisionParam perceiveCollisions__arr19;
        [FieldOffset(0xA00)] public BossPerceiveCollisionParam perceiveCollisions__arr20;
        [FieldOffset(0xA80)] public BossPerceiveCollisionParam perceiveCollisions__arr21;
        [FieldOffset(0xB00)] public BossPerceiveCollisionParam perceiveCollisions__arr22;
        [FieldOffset(0xB80)] public BossPerceiveCollisionParam perceiveCollisions__arr23;
        [FieldOffset(0xC00)] public BossPerceiveCollisionParam perceiveCollisions__arr24;
        [FieldOffset(0xC80)] public BossPerceiveCollisionParam perceiveCollisions__arr25;
        [FieldOffset(0xD00)] public BossPerceiveCollisionParam perceiveCollisions__arr26;
        [FieldOffset(0xD80)] public BossPerceiveCollisionParam perceiveCollisions__arr27;
        [FieldOffset(0xE00)] public BossPerceiveCollisionParam perceiveCollisions__arr28;
        [FieldOffset(0xE80)] public BossPerceiveCollisionParam perceiveCollisions__arr29;
        [FieldOffset(0xF00)] public BossPerceiveCollisionParam perceiveCollisions__arr30;
        [FieldOffset(0xF80)] public BossPerceiveCollisionParam perceiveCollisions__arr31;
        [FieldOffset(0x1000)] public BossPerceiveCollisionParam perceiveCollisions__arr32;
        [FieldOffset(0x1080)] public BossPerceiveCollisionParam perceiveCollisions__arr33;
        [FieldOffset(0x1100)] public BossPerceiveCollisionParam perceiveCollisions__arr34;
        [FieldOffset(0x1180)] public BossPerceiveCollisionParam perceiveCollisions__arr35;
        [FieldOffset(0x1200)] public BossPerceiveCollisionParam perceiveCollisions__arr36;
        [FieldOffset(0x1280)] public BossPerceiveCollisionParam perceiveCollisions__arr37;
        [FieldOffset(0x1300)] public BossPerceiveCollisionParam perceiveCollisions__arr38;
        [FieldOffset(0x1380)] public BossPerceiveCollisionParam perceiveCollisions__arr39;
        [FieldOffset(0x1400)] public BossPerceiveCollisionParam perceiveCollisions__arr40;
        [FieldOffset(0x1480)] public BossPerceiveCollisionParam perceiveCollisions__arr41;
        [FieldOffset(0x1500)] public BossPerceiveCollisionParam perceiveCollisions__arr42;
        [FieldOffset(0x1580)] public BossPerceiveCollisionParam perceiveCollisions__arr43;
        [FieldOffset(0x1600)] public BossPerceiveCollisionParam perceiveCollisions__arr44;
        [FieldOffset(0x1680)] public BossPerceiveCollisionParam perceiveCollisions__arr45;
        [FieldOffset(0x1700)] public BossPerceiveCollisionParam perceiveCollisions__arr46;
        [FieldOffset(0x1780)] public BossPerceiveCollisionParam perceiveCollisions__arr47;
        [FieldOffset(0x1800)] public BossPerceiveCollisionParam perceiveCollisions__arr48;
        [FieldOffset(0x1880)] public BossPerceiveCollisionParam perceiveCollisions__arr49;
        [FieldOffset(0x1900)] public BossPerceiveCollisionParam perceiveCollisions__arr50;
        [FieldOffset(0x1980)] public BossPerceiveCollisionParam perceiveCollisions__arr51;
        [FieldOffset(0x1A00)] public BossPerceiveCollisionParam perceiveCollisions__arr52;
        [FieldOffset(0x1A80)] public BossPerceiveCollisionParam perceiveCollisions__arr53;
        [FieldOffset(0x1B00)] public BossPerceiveCollisionParam perceiveCollisions__arr54;
        [FieldOffset(0x1B80)] public BossPerceiveCollisionParam perceiveCollisions__arr55;
        [FieldOffset(0x1C00)] public BossPerceiveCollisionParam perceiveCollisions__arr56;
        [FieldOffset(0x1C80)] public BossPerceiveCollisionParam perceiveCollisions__arr57;
        [FieldOffset(0x1D00)] public BossPerceiveCollisionParam perceiveCollisions__arr58;
        [FieldOffset(0x1D80)] public BossPerceiveCollisionParam perceiveCollisions__arr59;
        [FieldOffset(0x1E00)] public BossPerceiveCollisionParam perceiveCollisions__arr60;
        [FieldOffset(0x1E80)] public BossPerceiveCollisionParam perceiveCollisions__arr61;
        [FieldOffset(0x1F00)] public BossPerceiveCollisionParam perceiveCollisions__arr62;
        [FieldOffset(0x1F80)] public BossPerceiveCollisionParam perceiveCollisions__arr63;
        [FieldOffset(0x2000)] public bool isDebugDraw;
    }

    public enum PointType : sbyte
    {
        PT_HOMINGPOINT = 0,
        PT_HEROSAGE = 1,
        PT_MINIONGENERATOR = 2,
        PT_TRIGGER = 3,
        PT_ANCHOR = 4,
        PT_DAMAGEPOINT = 5,
        PT_STICK = 6,
        PT_DAMAGEEFFECT = 7,
        PT_DASHCIRCLE = 8,
        NUM_POINT_TYPE = 9
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct BossHomingPointParam
    {
        [FieldOffset(0x00)] public BossColliderStatus status;
        [FieldOffset(0x20)] public float distance;
        [FieldOffset(0x24)] public float nextSearchDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossMinionParam
    {
        [FieldOffset(0x00)] public uint num;
        [FieldOffset(0x04)] public float interval;
        [FieldOffset(0x08)] public float liveTime;
        [FieldOffset(0x0C)] public float waitTime;
    }

    public enum Shape : sbyte
    {
        SHAPE_BOX = 0,
        SHAPE_SPHERE = 1,
        SHAPE_CYLINDER = 2,
        SHAPE_CAPSULE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossTrigerParam
    {
        [FieldOffset(0x00)] public Shape ShapeType;
        [FieldOffset(0x04)] public float CollisionWidth;
        [FieldOffset(0x08)] public float CollisionHeight;
        [FieldOffset(0x0C)] public float CollisionDepth;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct BossStickParam
    {
        [FieldOffset(0x00)] public float phaseTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct BossDamagePointParam
    {
        [FieldOffset(0x00)] public bool isCyloopDownUnuse;
        [FieldOffset(0x08)] public UnmanagedString text;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct BossDashCirclPointParam
    {
        [FieldOffset(0x00)] public int focusGeometryIndex;
        [FieldOffset(0x04)] public int focusTriangleIndex;
        [FieldOffset(0x08)] public float sizeScale;
        [FieldOffset(0x0C)] public float impulseSpeed;
        [FieldOffset(0x10)] public float ocTime;
        [FieldOffset(0x14)] public float slowRateBoss;
        [FieldOffset(0x18)] public float slowRatePlayer;
        [FieldOffset(0x1C)] public float slowTime;
        [FieldOffset(0x20)] public float slowEaseInTime;
        [FieldOffset(0x24)] public float slowEaseOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE0)]
    public struct BossMeshFrameParam
    {
        [FieldOffset(0x00)] public bool isUse;
        [FieldOffset(0x04)] public uint geometryIndex;
        [FieldOffset(0x08)] public uint triangleIndex;
        [FieldOffset(0x0C)] public PointType type;
        [FieldOffset(0x10)] public BossHomingPointParam homingPoint;
        [FieldOffset(0x38)] public BossMinionParam minionParam;
        [FieldOffset(0x48)] public BossTrigerParam trigger;
        [FieldOffset(0x58)] public BossStickParam stickParam;
        [FieldOffset(0x60)] public BossDamagePointParam damagePoint;
        [FieldOffset(0x78)] public BossDashCirclPointParam dashCirclPoint;
        [FieldOffset(0xA0)] public int linkNums__arr0;
        [FieldOffset(0xA4)] public int linkNums__arr1;
        [FieldOffset(0xA8)] public int linkNums__arr2;
        [FieldOffset(0xAC)] public int linkNums__arr3;
        [FieldOffset(0xB0)] public int linkNums__arr4;
        [FieldOffset(0xC0)] public Vector3 offsetPos;
        [FieldOffset(0xD0)] public Vector3 offsetRot;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE010)]
    public struct BossMeshFrameConfig
    {
        [FieldOffset(0x00)] public BossMeshFrameParam meshShapeKeyFrames__arr0;
        [FieldOffset(0xE0)] public BossMeshFrameParam meshShapeKeyFrames__arr1;
        [FieldOffset(0x1C0)] public BossMeshFrameParam meshShapeKeyFrames__arr2;
        [FieldOffset(0x2A0)] public BossMeshFrameParam meshShapeKeyFrames__arr3;
        [FieldOffset(0x380)] public BossMeshFrameParam meshShapeKeyFrames__arr4;
        [FieldOffset(0x460)] public BossMeshFrameParam meshShapeKeyFrames__arr5;
        [FieldOffset(0x540)] public BossMeshFrameParam meshShapeKeyFrames__arr6;
        [FieldOffset(0x620)] public BossMeshFrameParam meshShapeKeyFrames__arr7;
        [FieldOffset(0x700)] public BossMeshFrameParam meshShapeKeyFrames__arr8;
        [FieldOffset(0x7E0)] public BossMeshFrameParam meshShapeKeyFrames__arr9;
        [FieldOffset(0x8C0)] public BossMeshFrameParam meshShapeKeyFrames__arr10;
        [FieldOffset(0x9A0)] public BossMeshFrameParam meshShapeKeyFrames__arr11;
        [FieldOffset(0xA80)] public BossMeshFrameParam meshShapeKeyFrames__arr12;
        [FieldOffset(0xB60)] public BossMeshFrameParam meshShapeKeyFrames__arr13;
        [FieldOffset(0xC40)] public BossMeshFrameParam meshShapeKeyFrames__arr14;
        [FieldOffset(0xD20)] public BossMeshFrameParam meshShapeKeyFrames__arr15;
        [FieldOffset(0xE00)] public BossMeshFrameParam meshShapeKeyFrames__arr16;
        [FieldOffset(0xEE0)] public BossMeshFrameParam meshShapeKeyFrames__arr17;
        [FieldOffset(0xFC0)] public BossMeshFrameParam meshShapeKeyFrames__arr18;
        [FieldOffset(0x10A0)] public BossMeshFrameParam meshShapeKeyFrames__arr19;
        [FieldOffset(0x1180)] public BossMeshFrameParam meshShapeKeyFrames__arr20;
        [FieldOffset(0x1260)] public BossMeshFrameParam meshShapeKeyFrames__arr21;
        [FieldOffset(0x1340)] public BossMeshFrameParam meshShapeKeyFrames__arr22;
        [FieldOffset(0x1420)] public BossMeshFrameParam meshShapeKeyFrames__arr23;
        [FieldOffset(0x1500)] public BossMeshFrameParam meshShapeKeyFrames__arr24;
        [FieldOffset(0x15E0)] public BossMeshFrameParam meshShapeKeyFrames__arr25;
        [FieldOffset(0x16C0)] public BossMeshFrameParam meshShapeKeyFrames__arr26;
        [FieldOffset(0x17A0)] public BossMeshFrameParam meshShapeKeyFrames__arr27;
        [FieldOffset(0x1880)] public BossMeshFrameParam meshShapeKeyFrames__arr28;
        [FieldOffset(0x1960)] public BossMeshFrameParam meshShapeKeyFrames__arr29;
        [FieldOffset(0x1A40)] public BossMeshFrameParam meshShapeKeyFrames__arr30;
        [FieldOffset(0x1B20)] public BossMeshFrameParam meshShapeKeyFrames__arr31;
        [FieldOffset(0x1C00)] public BossMeshFrameParam meshShapeKeyFrames__arr32;
        [FieldOffset(0x1CE0)] public BossMeshFrameParam meshShapeKeyFrames__arr33;
        [FieldOffset(0x1DC0)] public BossMeshFrameParam meshShapeKeyFrames__arr34;
        [FieldOffset(0x1EA0)] public BossMeshFrameParam meshShapeKeyFrames__arr35;
        [FieldOffset(0x1F80)] public BossMeshFrameParam meshShapeKeyFrames__arr36;
        [FieldOffset(0x2060)] public BossMeshFrameParam meshShapeKeyFrames__arr37;
        [FieldOffset(0x2140)] public BossMeshFrameParam meshShapeKeyFrames__arr38;
        [FieldOffset(0x2220)] public BossMeshFrameParam meshShapeKeyFrames__arr39;
        [FieldOffset(0x2300)] public BossMeshFrameParam meshShapeKeyFrames__arr40;
        [FieldOffset(0x23E0)] public BossMeshFrameParam meshShapeKeyFrames__arr41;
        [FieldOffset(0x24C0)] public BossMeshFrameParam meshShapeKeyFrames__arr42;
        [FieldOffset(0x25A0)] public BossMeshFrameParam meshShapeKeyFrames__arr43;
        [FieldOffset(0x2680)] public BossMeshFrameParam meshShapeKeyFrames__arr44;
        [FieldOffset(0x2760)] public BossMeshFrameParam meshShapeKeyFrames__arr45;
        [FieldOffset(0x2840)] public BossMeshFrameParam meshShapeKeyFrames__arr46;
        [FieldOffset(0x2920)] public BossMeshFrameParam meshShapeKeyFrames__arr47;
        [FieldOffset(0x2A00)] public BossMeshFrameParam meshShapeKeyFrames__arr48;
        [FieldOffset(0x2AE0)] public BossMeshFrameParam meshShapeKeyFrames__arr49;
        [FieldOffset(0x2BC0)] public BossMeshFrameParam meshShapeKeyFrames__arr50;
        [FieldOffset(0x2CA0)] public BossMeshFrameParam meshShapeKeyFrames__arr51;
        [FieldOffset(0x2D80)] public BossMeshFrameParam meshShapeKeyFrames__arr52;
        [FieldOffset(0x2E60)] public BossMeshFrameParam meshShapeKeyFrames__arr53;
        [FieldOffset(0x2F40)] public BossMeshFrameParam meshShapeKeyFrames__arr54;
        [FieldOffset(0x3020)] public BossMeshFrameParam meshShapeKeyFrames__arr55;
        [FieldOffset(0x3100)] public BossMeshFrameParam meshShapeKeyFrames__arr56;
        [FieldOffset(0x31E0)] public BossMeshFrameParam meshShapeKeyFrames__arr57;
        [FieldOffset(0x32C0)] public BossMeshFrameParam meshShapeKeyFrames__arr58;
        [FieldOffset(0x33A0)] public BossMeshFrameParam meshShapeKeyFrames__arr59;
        [FieldOffset(0x3480)] public BossMeshFrameParam meshShapeKeyFrames__arr60;
        [FieldOffset(0x3560)] public BossMeshFrameParam meshShapeKeyFrames__arr61;
        [FieldOffset(0x3640)] public BossMeshFrameParam meshShapeKeyFrames__arr62;
        [FieldOffset(0x3720)] public BossMeshFrameParam meshShapeKeyFrames__arr63;
        [FieldOffset(0x3800)] public BossMeshFrameParam meshShapeKeyFrames__arr64;
        [FieldOffset(0x38E0)] public BossMeshFrameParam meshShapeKeyFrames__arr65;
        [FieldOffset(0x39C0)] public BossMeshFrameParam meshShapeKeyFrames__arr66;
        [FieldOffset(0x3AA0)] public BossMeshFrameParam meshShapeKeyFrames__arr67;
        [FieldOffset(0x3B80)] public BossMeshFrameParam meshShapeKeyFrames__arr68;
        [FieldOffset(0x3C60)] public BossMeshFrameParam meshShapeKeyFrames__arr69;
        [FieldOffset(0x3D40)] public BossMeshFrameParam meshShapeKeyFrames__arr70;
        [FieldOffset(0x3E20)] public BossMeshFrameParam meshShapeKeyFrames__arr71;
        [FieldOffset(0x3F00)] public BossMeshFrameParam meshShapeKeyFrames__arr72;
        [FieldOffset(0x3FE0)] public BossMeshFrameParam meshShapeKeyFrames__arr73;
        [FieldOffset(0x40C0)] public BossMeshFrameParam meshShapeKeyFrames__arr74;
        [FieldOffset(0x41A0)] public BossMeshFrameParam meshShapeKeyFrames__arr75;
        [FieldOffset(0x4280)] public BossMeshFrameParam meshShapeKeyFrames__arr76;
        [FieldOffset(0x4360)] public BossMeshFrameParam meshShapeKeyFrames__arr77;
        [FieldOffset(0x4440)] public BossMeshFrameParam meshShapeKeyFrames__arr78;
        [FieldOffset(0x4520)] public BossMeshFrameParam meshShapeKeyFrames__arr79;
        [FieldOffset(0x4600)] public BossMeshFrameParam meshShapeKeyFrames__arr80;
        [FieldOffset(0x46E0)] public BossMeshFrameParam meshShapeKeyFrames__arr81;
        [FieldOffset(0x47C0)] public BossMeshFrameParam meshShapeKeyFrames__arr82;
        [FieldOffset(0x48A0)] public BossMeshFrameParam meshShapeKeyFrames__arr83;
        [FieldOffset(0x4980)] public BossMeshFrameParam meshShapeKeyFrames__arr84;
        [FieldOffset(0x4A60)] public BossMeshFrameParam meshShapeKeyFrames__arr85;
        [FieldOffset(0x4B40)] public BossMeshFrameParam meshShapeKeyFrames__arr86;
        [FieldOffset(0x4C20)] public BossMeshFrameParam meshShapeKeyFrames__arr87;
        [FieldOffset(0x4D00)] public BossMeshFrameParam meshShapeKeyFrames__arr88;
        [FieldOffset(0x4DE0)] public BossMeshFrameParam meshShapeKeyFrames__arr89;
        [FieldOffset(0x4EC0)] public BossMeshFrameParam meshShapeKeyFrames__arr90;
        [FieldOffset(0x4FA0)] public BossMeshFrameParam meshShapeKeyFrames__arr91;
        [FieldOffset(0x5080)] public BossMeshFrameParam meshShapeKeyFrames__arr92;
        [FieldOffset(0x5160)] public BossMeshFrameParam meshShapeKeyFrames__arr93;
        [FieldOffset(0x5240)] public BossMeshFrameParam meshShapeKeyFrames__arr94;
        [FieldOffset(0x5320)] public BossMeshFrameParam meshShapeKeyFrames__arr95;
        [FieldOffset(0x5400)] public BossMeshFrameParam meshShapeKeyFrames__arr96;
        [FieldOffset(0x54E0)] public BossMeshFrameParam meshShapeKeyFrames__arr97;
        [FieldOffset(0x55C0)] public BossMeshFrameParam meshShapeKeyFrames__arr98;
        [FieldOffset(0x56A0)] public BossMeshFrameParam meshShapeKeyFrames__arr99;
        [FieldOffset(0x5780)] public BossMeshFrameParam meshShapeKeyFrames__arr100;
        [FieldOffset(0x5860)] public BossMeshFrameParam meshShapeKeyFrames__arr101;
        [FieldOffset(0x5940)] public BossMeshFrameParam meshShapeKeyFrames__arr102;
        [FieldOffset(0x5A20)] public BossMeshFrameParam meshShapeKeyFrames__arr103;
        [FieldOffset(0x5B00)] public BossMeshFrameParam meshShapeKeyFrames__arr104;
        [FieldOffset(0x5BE0)] public BossMeshFrameParam meshShapeKeyFrames__arr105;
        [FieldOffset(0x5CC0)] public BossMeshFrameParam meshShapeKeyFrames__arr106;
        [FieldOffset(0x5DA0)] public BossMeshFrameParam meshShapeKeyFrames__arr107;
        [FieldOffset(0x5E80)] public BossMeshFrameParam meshShapeKeyFrames__arr108;
        [FieldOffset(0x5F60)] public BossMeshFrameParam meshShapeKeyFrames__arr109;
        [FieldOffset(0x6040)] public BossMeshFrameParam meshShapeKeyFrames__arr110;
        [FieldOffset(0x6120)] public BossMeshFrameParam meshShapeKeyFrames__arr111;
        [FieldOffset(0x6200)] public BossMeshFrameParam meshShapeKeyFrames__arr112;
        [FieldOffset(0x62E0)] public BossMeshFrameParam meshShapeKeyFrames__arr113;
        [FieldOffset(0x63C0)] public BossMeshFrameParam meshShapeKeyFrames__arr114;
        [FieldOffset(0x64A0)] public BossMeshFrameParam meshShapeKeyFrames__arr115;
        [FieldOffset(0x6580)] public BossMeshFrameParam meshShapeKeyFrames__arr116;
        [FieldOffset(0x6660)] public BossMeshFrameParam meshShapeKeyFrames__arr117;
        [FieldOffset(0x6740)] public BossMeshFrameParam meshShapeKeyFrames__arr118;
        [FieldOffset(0x6820)] public BossMeshFrameParam meshShapeKeyFrames__arr119;
        [FieldOffset(0x6900)] public BossMeshFrameParam meshShapeKeyFrames__arr120;
        [FieldOffset(0x69E0)] public BossMeshFrameParam meshShapeKeyFrames__arr121;
        [FieldOffset(0x6AC0)] public BossMeshFrameParam meshShapeKeyFrames__arr122;
        [FieldOffset(0x6BA0)] public BossMeshFrameParam meshShapeKeyFrames__arr123;
        [FieldOffset(0x6C80)] public BossMeshFrameParam meshShapeKeyFrames__arr124;
        [FieldOffset(0x6D60)] public BossMeshFrameParam meshShapeKeyFrames__arr125;
        [FieldOffset(0x6E40)] public BossMeshFrameParam meshShapeKeyFrames__arr126;
        [FieldOffset(0x6F20)] public BossMeshFrameParam meshShapeKeyFrames__arr127;
        [FieldOffset(0x7000)] public BossMeshFrameParam meshShapeKeyFrames__arr128;
        [FieldOffset(0x70E0)] public BossMeshFrameParam meshShapeKeyFrames__arr129;
        [FieldOffset(0x71C0)] public BossMeshFrameParam meshShapeKeyFrames__arr130;
        [FieldOffset(0x72A0)] public BossMeshFrameParam meshShapeKeyFrames__arr131;
        [FieldOffset(0x7380)] public BossMeshFrameParam meshShapeKeyFrames__arr132;
        [FieldOffset(0x7460)] public BossMeshFrameParam meshShapeKeyFrames__arr133;
        [FieldOffset(0x7540)] public BossMeshFrameParam meshShapeKeyFrames__arr134;
        [FieldOffset(0x7620)] public BossMeshFrameParam meshShapeKeyFrames__arr135;
        [FieldOffset(0x7700)] public BossMeshFrameParam meshShapeKeyFrames__arr136;
        [FieldOffset(0x77E0)] public BossMeshFrameParam meshShapeKeyFrames__arr137;
        [FieldOffset(0x78C0)] public BossMeshFrameParam meshShapeKeyFrames__arr138;
        [FieldOffset(0x79A0)] public BossMeshFrameParam meshShapeKeyFrames__arr139;
        [FieldOffset(0x7A80)] public BossMeshFrameParam meshShapeKeyFrames__arr140;
        [FieldOffset(0x7B60)] public BossMeshFrameParam meshShapeKeyFrames__arr141;
        [FieldOffset(0x7C40)] public BossMeshFrameParam meshShapeKeyFrames__arr142;
        [FieldOffset(0x7D20)] public BossMeshFrameParam meshShapeKeyFrames__arr143;
        [FieldOffset(0x7E00)] public BossMeshFrameParam meshShapeKeyFrames__arr144;
        [FieldOffset(0x7EE0)] public BossMeshFrameParam meshShapeKeyFrames__arr145;
        [FieldOffset(0x7FC0)] public BossMeshFrameParam meshShapeKeyFrames__arr146;
        [FieldOffset(0x80A0)] public BossMeshFrameParam meshShapeKeyFrames__arr147;
        [FieldOffset(0x8180)] public BossMeshFrameParam meshShapeKeyFrames__arr148;
        [FieldOffset(0x8260)] public BossMeshFrameParam meshShapeKeyFrames__arr149;
        [FieldOffset(0x8340)] public BossMeshFrameParam meshShapeKeyFrames__arr150;
        [FieldOffset(0x8420)] public BossMeshFrameParam meshShapeKeyFrames__arr151;
        [FieldOffset(0x8500)] public BossMeshFrameParam meshShapeKeyFrames__arr152;
        [FieldOffset(0x85E0)] public BossMeshFrameParam meshShapeKeyFrames__arr153;
        [FieldOffset(0x86C0)] public BossMeshFrameParam meshShapeKeyFrames__arr154;
        [FieldOffset(0x87A0)] public BossMeshFrameParam meshShapeKeyFrames__arr155;
        [FieldOffset(0x8880)] public BossMeshFrameParam meshShapeKeyFrames__arr156;
        [FieldOffset(0x8960)] public BossMeshFrameParam meshShapeKeyFrames__arr157;
        [FieldOffset(0x8A40)] public BossMeshFrameParam meshShapeKeyFrames__arr158;
        [FieldOffset(0x8B20)] public BossMeshFrameParam meshShapeKeyFrames__arr159;
        [FieldOffset(0x8C00)] public BossMeshFrameParam meshShapeKeyFrames__arr160;
        [FieldOffset(0x8CE0)] public BossMeshFrameParam meshShapeKeyFrames__arr161;
        [FieldOffset(0x8DC0)] public BossMeshFrameParam meshShapeKeyFrames__arr162;
        [FieldOffset(0x8EA0)] public BossMeshFrameParam meshShapeKeyFrames__arr163;
        [FieldOffset(0x8F80)] public BossMeshFrameParam meshShapeKeyFrames__arr164;
        [FieldOffset(0x9060)] public BossMeshFrameParam meshShapeKeyFrames__arr165;
        [FieldOffset(0x9140)] public BossMeshFrameParam meshShapeKeyFrames__arr166;
        [FieldOffset(0x9220)] public BossMeshFrameParam meshShapeKeyFrames__arr167;
        [FieldOffset(0x9300)] public BossMeshFrameParam meshShapeKeyFrames__arr168;
        [FieldOffset(0x93E0)] public BossMeshFrameParam meshShapeKeyFrames__arr169;
        [FieldOffset(0x94C0)] public BossMeshFrameParam meshShapeKeyFrames__arr170;
        [FieldOffset(0x95A0)] public BossMeshFrameParam meshShapeKeyFrames__arr171;
        [FieldOffset(0x9680)] public BossMeshFrameParam meshShapeKeyFrames__arr172;
        [FieldOffset(0x9760)] public BossMeshFrameParam meshShapeKeyFrames__arr173;
        [FieldOffset(0x9840)] public BossMeshFrameParam meshShapeKeyFrames__arr174;
        [FieldOffset(0x9920)] public BossMeshFrameParam meshShapeKeyFrames__arr175;
        [FieldOffset(0x9A00)] public BossMeshFrameParam meshShapeKeyFrames__arr176;
        [FieldOffset(0x9AE0)] public BossMeshFrameParam meshShapeKeyFrames__arr177;
        [FieldOffset(0x9BC0)] public BossMeshFrameParam meshShapeKeyFrames__arr178;
        [FieldOffset(0x9CA0)] public BossMeshFrameParam meshShapeKeyFrames__arr179;
        [FieldOffset(0x9D80)] public BossMeshFrameParam meshShapeKeyFrames__arr180;
        [FieldOffset(0x9E60)] public BossMeshFrameParam meshShapeKeyFrames__arr181;
        [FieldOffset(0x9F40)] public BossMeshFrameParam meshShapeKeyFrames__arr182;
        [FieldOffset(0xA020)] public BossMeshFrameParam meshShapeKeyFrames__arr183;
        [FieldOffset(0xA100)] public BossMeshFrameParam meshShapeKeyFrames__arr184;
        [FieldOffset(0xA1E0)] public BossMeshFrameParam meshShapeKeyFrames__arr185;
        [FieldOffset(0xA2C0)] public BossMeshFrameParam meshShapeKeyFrames__arr186;
        [FieldOffset(0xA3A0)] public BossMeshFrameParam meshShapeKeyFrames__arr187;
        [FieldOffset(0xA480)] public BossMeshFrameParam meshShapeKeyFrames__arr188;
        [FieldOffset(0xA560)] public BossMeshFrameParam meshShapeKeyFrames__arr189;
        [FieldOffset(0xA640)] public BossMeshFrameParam meshShapeKeyFrames__arr190;
        [FieldOffset(0xA720)] public BossMeshFrameParam meshShapeKeyFrames__arr191;
        [FieldOffset(0xA800)] public BossMeshFrameParam meshShapeKeyFrames__arr192;
        [FieldOffset(0xA8E0)] public BossMeshFrameParam meshShapeKeyFrames__arr193;
        [FieldOffset(0xA9C0)] public BossMeshFrameParam meshShapeKeyFrames__arr194;
        [FieldOffset(0xAAA0)] public BossMeshFrameParam meshShapeKeyFrames__arr195;
        [FieldOffset(0xAB80)] public BossMeshFrameParam meshShapeKeyFrames__arr196;
        [FieldOffset(0xAC60)] public BossMeshFrameParam meshShapeKeyFrames__arr197;
        [FieldOffset(0xAD40)] public BossMeshFrameParam meshShapeKeyFrames__arr198;
        [FieldOffset(0xAE20)] public BossMeshFrameParam meshShapeKeyFrames__arr199;
        [FieldOffset(0xAF00)] public BossMeshFrameParam meshShapeKeyFrames__arr200;
        [FieldOffset(0xAFE0)] public BossMeshFrameParam meshShapeKeyFrames__arr201;
        [FieldOffset(0xB0C0)] public BossMeshFrameParam meshShapeKeyFrames__arr202;
        [FieldOffset(0xB1A0)] public BossMeshFrameParam meshShapeKeyFrames__arr203;
        [FieldOffset(0xB280)] public BossMeshFrameParam meshShapeKeyFrames__arr204;
        [FieldOffset(0xB360)] public BossMeshFrameParam meshShapeKeyFrames__arr205;
        [FieldOffset(0xB440)] public BossMeshFrameParam meshShapeKeyFrames__arr206;
        [FieldOffset(0xB520)] public BossMeshFrameParam meshShapeKeyFrames__arr207;
        [FieldOffset(0xB600)] public BossMeshFrameParam meshShapeKeyFrames__arr208;
        [FieldOffset(0xB6E0)] public BossMeshFrameParam meshShapeKeyFrames__arr209;
        [FieldOffset(0xB7C0)] public BossMeshFrameParam meshShapeKeyFrames__arr210;
        [FieldOffset(0xB8A0)] public BossMeshFrameParam meshShapeKeyFrames__arr211;
        [FieldOffset(0xB980)] public BossMeshFrameParam meshShapeKeyFrames__arr212;
        [FieldOffset(0xBA60)] public BossMeshFrameParam meshShapeKeyFrames__arr213;
        [FieldOffset(0xBB40)] public BossMeshFrameParam meshShapeKeyFrames__arr214;
        [FieldOffset(0xBC20)] public BossMeshFrameParam meshShapeKeyFrames__arr215;
        [FieldOffset(0xBD00)] public BossMeshFrameParam meshShapeKeyFrames__arr216;
        [FieldOffset(0xBDE0)] public BossMeshFrameParam meshShapeKeyFrames__arr217;
        [FieldOffset(0xBEC0)] public BossMeshFrameParam meshShapeKeyFrames__arr218;
        [FieldOffset(0xBFA0)] public BossMeshFrameParam meshShapeKeyFrames__arr219;
        [FieldOffset(0xC080)] public BossMeshFrameParam meshShapeKeyFrames__arr220;
        [FieldOffset(0xC160)] public BossMeshFrameParam meshShapeKeyFrames__arr221;
        [FieldOffset(0xC240)] public BossMeshFrameParam meshShapeKeyFrames__arr222;
        [FieldOffset(0xC320)] public BossMeshFrameParam meshShapeKeyFrames__arr223;
        [FieldOffset(0xC400)] public BossMeshFrameParam meshShapeKeyFrames__arr224;
        [FieldOffset(0xC4E0)] public BossMeshFrameParam meshShapeKeyFrames__arr225;
        [FieldOffset(0xC5C0)] public BossMeshFrameParam meshShapeKeyFrames__arr226;
        [FieldOffset(0xC6A0)] public BossMeshFrameParam meshShapeKeyFrames__arr227;
        [FieldOffset(0xC780)] public BossMeshFrameParam meshShapeKeyFrames__arr228;
        [FieldOffset(0xC860)] public BossMeshFrameParam meshShapeKeyFrames__arr229;
        [FieldOffset(0xC940)] public BossMeshFrameParam meshShapeKeyFrames__arr230;
        [FieldOffset(0xCA20)] public BossMeshFrameParam meshShapeKeyFrames__arr231;
        [FieldOffset(0xCB00)] public BossMeshFrameParam meshShapeKeyFrames__arr232;
        [FieldOffset(0xCBE0)] public BossMeshFrameParam meshShapeKeyFrames__arr233;
        [FieldOffset(0xCCC0)] public BossMeshFrameParam meshShapeKeyFrames__arr234;
        [FieldOffset(0xCDA0)] public BossMeshFrameParam meshShapeKeyFrames__arr235;
        [FieldOffset(0xCE80)] public BossMeshFrameParam meshShapeKeyFrames__arr236;
        [FieldOffset(0xCF60)] public BossMeshFrameParam meshShapeKeyFrames__arr237;
        [FieldOffset(0xD040)] public BossMeshFrameParam meshShapeKeyFrames__arr238;
        [FieldOffset(0xD120)] public BossMeshFrameParam meshShapeKeyFrames__arr239;
        [FieldOffset(0xD200)] public BossMeshFrameParam meshShapeKeyFrames__arr240;
        [FieldOffset(0xD2E0)] public BossMeshFrameParam meshShapeKeyFrames__arr241;
        [FieldOffset(0xD3C0)] public BossMeshFrameParam meshShapeKeyFrames__arr242;
        [FieldOffset(0xD4A0)] public BossMeshFrameParam meshShapeKeyFrames__arr243;
        [FieldOffset(0xD580)] public BossMeshFrameParam meshShapeKeyFrames__arr244;
        [FieldOffset(0xD660)] public BossMeshFrameParam meshShapeKeyFrames__arr245;
        [FieldOffset(0xD740)] public BossMeshFrameParam meshShapeKeyFrames__arr246;
        [FieldOffset(0xD820)] public BossMeshFrameParam meshShapeKeyFrames__arr247;
        [FieldOffset(0xD900)] public BossMeshFrameParam meshShapeKeyFrames__arr248;
        [FieldOffset(0xD9E0)] public BossMeshFrameParam meshShapeKeyFrames__arr249;
        [FieldOffset(0xDAC0)] public BossMeshFrameParam meshShapeKeyFrames__arr250;
        [FieldOffset(0xDBA0)] public BossMeshFrameParam meshShapeKeyFrames__arr251;
        [FieldOffset(0xDC80)] public BossMeshFrameParam meshShapeKeyFrames__arr252;
        [FieldOffset(0xDD60)] public BossMeshFrameParam meshShapeKeyFrames__arr253;
        [FieldOffset(0xDE40)] public BossMeshFrameParam meshShapeKeyFrames__arr254;
        [FieldOffset(0xDF20)] public BossMeshFrameParam meshShapeKeyFrames__arr255;
        [FieldOffset(0xE000)] public bool isDebugDraw;
        [FieldOffset(0xE001)] public bool isDebugDrawPoint;
        [FieldOffset(0xE002)] public bool isDebugDrawMesh;
        [FieldOffset(0xE003)] public bool isDebugDrawMeshIndivid;
        [FieldOffset(0xE004)] public float debugDrawMeshTriangleDistance;
        [FieldOffset(0xE008)] public uint debugDrawMeshTriangleNum;
    }

    public enum BossAttackCollisionParam_AttackType : sbyte
    {
        AT_NONE = 0,
        AT_BLOWOFF = 1,
        AT_SLAMDOWNWARD = 2,
        AT_KILLING = 3,
        AT_NOTPARRY = 4,
        AT_NOTDAMAGE = 5,
        AT_NOTDAMAGETRIGGER = 6,
        BossAttackCollisionParam_AttackType_NUM_ATTACK_TYPE = 7
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct BossAttackCollisionParam
    {
        [FieldOffset(0x00)] public bool isUse;
        [FieldOffset(0x08)] public UnmanagedString attachNodeName;
        [FieldOffset(0x18)] public float damageVelocityRaito;
        [FieldOffset(0x1C)] public BossAttackCollisionParam_AttackType types__arr0;
        [FieldOffset(0x1D)] public BossAttackCollisionParam_AttackType types__arr1;
        [FieldOffset(0x1E)] public BossAttackCollisionParam_AttackType types__arr2;
        [FieldOffset(0x1F)] public BossAttackCollisionParam_AttackType types__arr3;
        [FieldOffset(0x20)] public BossColliderStatus status;
        [FieldOffset(0x40)] public float size;
        [FieldOffset(0x50)] public Vector3 offset;
        [FieldOffset(0x60)] public UnmanagedString parryCounterTargetCollisionName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C10)]
    public struct BossAttackCollisionConfig
    {
        [FieldOffset(0x00)] public BossAttackCollisionParam attackCollisions__arr0;
        [FieldOffset(0x70)] public BossAttackCollisionParam attackCollisions__arr1;
        [FieldOffset(0xE0)] public BossAttackCollisionParam attackCollisions__arr2;
        [FieldOffset(0x150)] public BossAttackCollisionParam attackCollisions__arr3;
        [FieldOffset(0x1C0)] public BossAttackCollisionParam attackCollisions__arr4;
        [FieldOffset(0x230)] public BossAttackCollisionParam attackCollisions__arr5;
        [FieldOffset(0x2A0)] public BossAttackCollisionParam attackCollisions__arr6;
        [FieldOffset(0x310)] public BossAttackCollisionParam attackCollisions__arr7;
        [FieldOffset(0x380)] public BossAttackCollisionParam attackCollisions__arr8;
        [FieldOffset(0x3F0)] public BossAttackCollisionParam attackCollisions__arr9;
        [FieldOffset(0x460)] public BossAttackCollisionParam attackCollisions__arr10;
        [FieldOffset(0x4D0)] public BossAttackCollisionParam attackCollisions__arr11;
        [FieldOffset(0x540)] public BossAttackCollisionParam attackCollisions__arr12;
        [FieldOffset(0x5B0)] public BossAttackCollisionParam attackCollisions__arr13;
        [FieldOffset(0x620)] public BossAttackCollisionParam attackCollisions__arr14;
        [FieldOffset(0x690)] public BossAttackCollisionParam attackCollisions__arr15;
        [FieldOffset(0x700)] public BossAttackCollisionParam attackCollisions__arr16;
        [FieldOffset(0x770)] public BossAttackCollisionParam attackCollisions__arr17;
        [FieldOffset(0x7E0)] public BossAttackCollisionParam attackCollisions__arr18;
        [FieldOffset(0x850)] public BossAttackCollisionParam attackCollisions__arr19;
        [FieldOffset(0x8C0)] public BossAttackCollisionParam attackCollisions__arr20;
        [FieldOffset(0x930)] public BossAttackCollisionParam attackCollisions__arr21;
        [FieldOffset(0x9A0)] public BossAttackCollisionParam attackCollisions__arr22;
        [FieldOffset(0xA10)] public BossAttackCollisionParam attackCollisions__arr23;
        [FieldOffset(0xA80)] public BossAttackCollisionParam attackCollisions__arr24;
        [FieldOffset(0xAF0)] public BossAttackCollisionParam attackCollisions__arr25;
        [FieldOffset(0xB60)] public BossAttackCollisionParam attackCollisions__arr26;
        [FieldOffset(0xBD0)] public BossAttackCollisionParam attackCollisions__arr27;
        [FieldOffset(0xC40)] public BossAttackCollisionParam attackCollisions__arr28;
        [FieldOffset(0xCB0)] public BossAttackCollisionParam attackCollisions__arr29;
        [FieldOffset(0xD20)] public BossAttackCollisionParam attackCollisions__arr30;
        [FieldOffset(0xD90)] public BossAttackCollisionParam attackCollisions__arr31;
        [FieldOffset(0xE00)] public BossAttackCollisionParam attackCollisions__arr32;
        [FieldOffset(0xE70)] public BossAttackCollisionParam attackCollisions__arr33;
        [FieldOffset(0xEE0)] public BossAttackCollisionParam attackCollisions__arr34;
        [FieldOffset(0xF50)] public BossAttackCollisionParam attackCollisions__arr35;
        [FieldOffset(0xFC0)] public BossAttackCollisionParam attackCollisions__arr36;
        [FieldOffset(0x1030)] public BossAttackCollisionParam attackCollisions__arr37;
        [FieldOffset(0x10A0)] public BossAttackCollisionParam attackCollisions__arr38;
        [FieldOffset(0x1110)] public BossAttackCollisionParam attackCollisions__arr39;
        [FieldOffset(0x1180)] public BossAttackCollisionParam attackCollisions__arr40;
        [FieldOffset(0x11F0)] public BossAttackCollisionParam attackCollisions__arr41;
        [FieldOffset(0x1260)] public BossAttackCollisionParam attackCollisions__arr42;
        [FieldOffset(0x12D0)] public BossAttackCollisionParam attackCollisions__arr43;
        [FieldOffset(0x1340)] public BossAttackCollisionParam attackCollisions__arr44;
        [FieldOffset(0x13B0)] public BossAttackCollisionParam attackCollisions__arr45;
        [FieldOffset(0x1420)] public BossAttackCollisionParam attackCollisions__arr46;
        [FieldOffset(0x1490)] public BossAttackCollisionParam attackCollisions__arr47;
        [FieldOffset(0x1500)] public BossAttackCollisionParam attackCollisions__arr48;
        [FieldOffset(0x1570)] public BossAttackCollisionParam attackCollisions__arr49;
        [FieldOffset(0x15E0)] public BossAttackCollisionParam attackCollisions__arr50;
        [FieldOffset(0x1650)] public BossAttackCollisionParam attackCollisions__arr51;
        [FieldOffset(0x16C0)] public BossAttackCollisionParam attackCollisions__arr52;
        [FieldOffset(0x1730)] public BossAttackCollisionParam attackCollisions__arr53;
        [FieldOffset(0x17A0)] public BossAttackCollisionParam attackCollisions__arr54;
        [FieldOffset(0x1810)] public BossAttackCollisionParam attackCollisions__arr55;
        [FieldOffset(0x1880)] public BossAttackCollisionParam attackCollisions__arr56;
        [FieldOffset(0x18F0)] public BossAttackCollisionParam attackCollisions__arr57;
        [FieldOffset(0x1960)] public BossAttackCollisionParam attackCollisions__arr58;
        [FieldOffset(0x19D0)] public BossAttackCollisionParam attackCollisions__arr59;
        [FieldOffset(0x1A40)] public BossAttackCollisionParam attackCollisions__arr60;
        [FieldOffset(0x1AB0)] public BossAttackCollisionParam attackCollisions__arr61;
        [FieldOffset(0x1B20)] public BossAttackCollisionParam attackCollisions__arr62;
        [FieldOffset(0x1B90)] public BossAttackCollisionParam attackCollisions__arr63;
        [FieldOffset(0x1C00)] public bool isDebugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct BossBattlePhaseCollisionParam
    {
        [FieldOffset(0x00)] public bool isUse;
        [FieldOffset(0x08)] public UnmanagedString attachNodeName;
        [FieldOffset(0x18)] public UnmanagedString name;
        [FieldOffset(0x28)] public float size;
        [FieldOffset(0x30)] public Vector3 offset;
        [FieldOffset(0x40)] public Vector3 rotation;
        [FieldOffset(0x50)] public bool isParryActive;
        [FieldOffset(0x54)] public float cyloopRadius;
        [FieldOffset(0x58)] public bool onlyRigidBody;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x610)]
    public struct BossBattlePhaseCollisionConfig
    {
        [FieldOffset(0x00)] public BossBattlePhaseCollisionParam battleCollisions__arr0;
        [FieldOffset(0x60)] public BossBattlePhaseCollisionParam battleCollisions__arr1;
        [FieldOffset(0xC0)] public BossBattlePhaseCollisionParam battleCollisions__arr2;
        [FieldOffset(0x120)] public BossBattlePhaseCollisionParam battleCollisions__arr3;
        [FieldOffset(0x180)] public BossBattlePhaseCollisionParam battleCollisions__arr4;
        [FieldOffset(0x1E0)] public BossBattlePhaseCollisionParam battleCollisions__arr5;
        [FieldOffset(0x240)] public BossBattlePhaseCollisionParam battleCollisions__arr6;
        [FieldOffset(0x2A0)] public BossBattlePhaseCollisionParam battleCollisions__arr7;
        [FieldOffset(0x300)] public BossBattlePhaseCollisionParam battleCollisions__arr8;
        [FieldOffset(0x360)] public BossBattlePhaseCollisionParam battleCollisions__arr9;
        [FieldOffset(0x3C0)] public BossBattlePhaseCollisionParam battleCollisions__arr10;
        [FieldOffset(0x420)] public BossBattlePhaseCollisionParam battleCollisions__arr11;
        [FieldOffset(0x480)] public BossBattlePhaseCollisionParam battleCollisions__arr12;
        [FieldOffset(0x4E0)] public BossBattlePhaseCollisionParam battleCollisions__arr13;
        [FieldOffset(0x540)] public BossBattlePhaseCollisionParam battleCollisions__arr14;
        [FieldOffset(0x5A0)] public BossBattlePhaseCollisionParam battleCollisions__arr15;
        [FieldOffset(0x600)] public bool isDebugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossDropRingConfig
    {
        [FieldOffset(0x00)] public uint ringNumQuickCyloopUp;
        [FieldOffset(0x04)] public uint ringNumQuickCyloopDown;
        [FieldOffset(0x08)] public uint ringNumSonicSpecial;
        [FieldOffset(0x0C)] public float ringSpawnDistance;
        [FieldOffset(0x10)] public float ringSuckedVelocity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x127C0)]
    public struct BossBaseConfig
    {
        [FieldOffset(0x00)] public BossStatusConfig status;
        [FieldOffset(0x1A0)] public BossPillarConfig pillar;
        [FieldOffset(0x560)] public BossPerceivePartsWithCollisionConfig perceivPartsWithCollision;
        [FieldOffset(0x2570)] public BossMeshFrameConfig meshShapeKeyFrame;
        [FieldOffset(0x10580)] public BossAttackCollisionConfig attackCollision;
        [FieldOffset(0x12190)] public BossBattlePhaseCollisionConfig battleCollision;
        [FieldOffset(0x127A0)] public BossDropRingConfig dropRing;
    }

    public enum ActionType : sbyte
    {
        ActionType_AT_NONE = 0,
        AT_HAND_L = 1,
        AT_HAND_R = 2,
        AT_SHOT1 = 3,
        AT_SHOT2 = 4,
        AT_SHOT3 = 5,
        AT_SHOT4 = 6,
        AT_QTE_NONE = 7,
        AT_WAIT = 8,
        AT_LASER = 9,
        AT_HOMINGLASER_NORMAL = 10,
        AT_HOMINGLASER_FLY = 11,
        AT_BIT_WAVE = 12,
        AT_BIT_WAVE_END = 13,
        AT_COUNTER_BLOW = 14,
        AT_SP01 = 15,
        AT_SP02 = 16,
        NUM_ACTION_TYPE = 17
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct BossRifleAttackData
    {
        [FieldOffset(0x00)] public ActionType attackType;
        [FieldOffset(0x08)] public UnmanagedString waveName;
        [FieldOffset(0x18)] public UnmanagedString subWaveName;
        [FieldOffset(0x28)] public float actionTime;
        [FieldOffset(0x2C)] public short nextStep;
        [FieldOffset(0x2E)] public bool isBitActionReset;
        [FieldOffset(0x2F)] public bool isFlyMoveReverse;
        [FieldOffset(0x30)] public bool isFlyWait;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3F8)]
    public struct BossRifleAttackPatternParam
    {
        [FieldOffset(0x00)] public BossRifleAttackData attackDatas__arr0;
        [FieldOffset(0x38)] public BossRifleAttackData attackDatas__arr1;
        [FieldOffset(0x70)] public BossRifleAttackData attackDatas__arr2;
        [FieldOffset(0xA8)] public BossRifleAttackData attackDatas__arr3;
        [FieldOffset(0xE0)] public BossRifleAttackData attackDatas__arr4;
        [FieldOffset(0x118)] public BossRifleAttackData attackDatas__arr5;
        [FieldOffset(0x150)] public BossRifleAttackData attackDatas__arr6;
        [FieldOffset(0x188)] public BossRifleAttackData attackDatas__arr7;
        [FieldOffset(0x1C0)] public BossRifleAttackData attackDatas__arr8;
        [FieldOffset(0x1F8)] public BossRifleAttackData attackDatas__arr9;
        [FieldOffset(0x230)] public BossRifleAttackData attackDatas__arr10;
        [FieldOffset(0x268)] public BossRifleAttackData attackDatas__arr11;
        [FieldOffset(0x2A0)] public BossRifleAttackData attackDatas__arr12;
        [FieldOffset(0x2D8)] public BossRifleAttackData attackDatas__arr13;
        [FieldOffset(0x310)] public BossRifleAttackData attackDatas__arr14;
        [FieldOffset(0x348)] public BossRifleAttackData attackDatas__arr15;
        [FieldOffset(0x380)] public BossRifleAttackData bitBreakAttackDatas__arr0;
        [FieldOffset(0x3B8)] public BossRifleAttackData bitBreakAttackDatas__arr1;
        [FieldOffset(0x3F0)] public uint breakBitNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1000)]
    public struct BossRiflePhaseParam
    {
        [FieldOffset(0x00)] public float attackWaitTime;
        [FieldOffset(0x04)] public float attackSpeedRatio;
        [FieldOffset(0x08)] public uint knockbackCountMax;
        [FieldOffset(0x10)] public BossRifleAttackPatternParam patterns__arr0;
        [FieldOffset(0x408)] public BossRifleAttackPatternParam patterns__arr1;
        [FieldOffset(0x800)] public BossRifleAttackPatternParam patterns__arr2;
        [FieldOffset(0xBF8)] public BossRifleAttackPatternParam patterns__arr3;
        [FieldOffset(0xFF0)] public float patternChangeHpRatios__arr0;
        [FieldOffset(0xFF4)] public float patternChangeHpRatios__arr1;
        [FieldOffset(0xFF8)] public float patternChangeHpRatios__arr2;
        [FieldOffset(0xFFC)] public float patternChangeHpRatios__arr3;
    }

    public enum ActionAttribute : sbyte
    {
        AA_NONE = 0,
        AA_ALL = 1,
        AA_FRONT = 2,
        AA_BACK = 3,
        AA_LEFT = 4,
        AA_RIGHT = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x48)]
    public struct BossRiflePhaseAttackActionParam
    {
        [FieldOffset(0x00)] public ActionAttribute attribute1;
        [FieldOffset(0x01)] public ActionAttribute attribute2;
        [FieldOffset(0x04)] public float useDistanceMin;
        [FieldOffset(0x08)] public float useDistanceMax;
        [FieldOffset(0x0C)] public float useHeightMin;
        [FieldOffset(0x10)] public float useHeightMax;
        [FieldOffset(0x14)] public float useAngleMin;
        [FieldOffset(0x18)] public float useAngleMax;
        [FieldOffset(0x1C)] public float useAbsAngleOver;
        [FieldOffset(0x20)] public float useHpRatioMin;
        [FieldOffset(0x24)] public float useHpRatioMax;
        [FieldOffset(0x28)] public float useAreaOver;
        [FieldOffset(0x2C)] public uint priority;
        [FieldOffset(0x30)] public float coolTime;
        [FieldOffset(0x34)] public float initCoolTime;
        [FieldOffset(0x38)] public float readyTime;
        [FieldOffset(0x3C)] public uint consecutiveUsesLimit;
        [FieldOffset(0x40)] public float consecutiveUsesLimitCoolTime;
        [FieldOffset(0x44)] public bool isCounterUse;
        [FieldOffset(0x45)] public bool isCounterOnly;
    }

    public enum BossRifleBattleParam_ActionType : sbyte
    {
        BossRifleBattleParam_ActionType_AT_NONE = 0,
        BossRifleBattleParam_ActionType_AT_HAND_L = 1,
        BossRifleBattleParam_ActionType_AT_HAND_R = 2,
        BossRifleBattleParam_ActionType_AT_SHOT1 = 3,
        BossRifleBattleParam_ActionType_AT_SHOT2 = 4,
        BossRifleBattleParam_ActionType_AT_SHOT3 = 5,
        BossRifleBattleParam_ActionType_AT_SHOT4 = 6,
        BossRifleBattleParam_ActionType_AT_QTE_NONE = 7,
        BossRifleBattleParam_ActionType_AT_WAIT = 8,
        BossRifleBattleParam_ActionType_AT_LASER = 9,
        BossRifleBattleParam_ActionType_AT_HOMINGLASER_NORMAL = 10,
        BossRifleBattleParam_ActionType_AT_HOMINGLASER_FLY = 11,
        BossRifleBattleParam_ActionType_AT_BIT_WAVE = 12,
        BossRifleBattleParam_ActionType_AT_BIT_WAVE_END = 13,
        BossRifleBattleParam_ActionType_AT_COUNTER_BLOW = 14,
        BossRifleBattleParam_ActionType_AT_SP01 = 15,
        BossRifleBattleParam_ActionType_AT_SP02 = 16,
        BossRifleBattleParam_ActionType_NUM_ACTION_TYPE = 17
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct BossRifleCyloopFloatActionParam
    {
        [FieldOffset(0x00)] public float landingCounterHPRatio;
        [FieldOffset(0x04)] public float floatCounterHPRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct BossRifleBattleAttackHomingLaserShotPoint
    {
        [FieldOffset(0x00)] public bool isParry;
        [FieldOffset(0x01)] public bool isUse;
        [FieldOffset(0x04)] public float shotDirElevation;
        [FieldOffset(0x08)] public float shotDirRoll;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x270)]
    public struct BossRifleBattleAttackHomingLaserAttackParam
    {
        [FieldOffset(0x00)] public UnmanagedString nodeName;
        [FieldOffset(0x10)] public Vector3 nodePos;
        [FieldOffset(0x20)] public Vector3 nodeFront;
        [FieldOffset(0x30)] public Vector3 nodeAxis;
        [FieldOffset(0x40)] public float straightKeepTime;
        [FieldOffset(0x44)] public uint parryMax;
        [FieldOffset(0x48)] public uint num;
        [FieldOffset(0x4C)] public uint countMax;
        [FieldOffset(0x50)] public float initSpeed;
        [FieldOffset(0x54)] public float speed;
        [FieldOffset(0x58)] public float acceleDelay;
        [FieldOffset(0x5C)] public float acceleTime;
        [FieldOffset(0x60)] public float interval;
        [FieldOffset(0x64)] public float intervals__arr0;
        [FieldOffset(0x68)] public float intervals__arr1;
        [FieldOffset(0x6C)] public float intervals__arr2;
        [FieldOffset(0x70)] public float intervals__arr3;
        [FieldOffset(0x74)] public float intervals__arr4;
        [FieldOffset(0x78)] public float intervals__arr5;
        [FieldOffset(0x7C)] public float intervals__arr6;
        [FieldOffset(0x80)] public float intervals__arr7;
        [FieldOffset(0x84)] public float delay;
        [FieldOffset(0x88)] public BossRifleBattleAttackHomingLaserShotPoint points__arr0;
        [FieldOffset(0x94)] public BossRifleBattleAttackHomingLaserShotPoint points__arr1;
        [FieldOffset(0xA0)] public BossRifleBattleAttackHomingLaserShotPoint points__arr2;
        [FieldOffset(0xAC)] public BossRifleBattleAttackHomingLaserShotPoint points__arr3;
        [FieldOffset(0xB8)] public BossRifleBattleAttackHomingLaserShotPoint points__arr4;
        [FieldOffset(0xC4)] public BossRifleBattleAttackHomingLaserShotPoint points__arr5;
        [FieldOffset(0xD0)] public BossRifleBattleAttackHomingLaserShotPoint points__arr6;
        [FieldOffset(0xDC)] public BossRifleBattleAttackHomingLaserShotPoint points__arr7;
        [FieldOffset(0xE8)] public BossRifleBattleAttackHomingLaserShotPoint points__arr8;
        [FieldOffset(0xF4)] public BossRifleBattleAttackHomingLaserShotPoint points__arr9;
        [FieldOffset(0x100)] public BossRifleBattleAttackHomingLaserShotPoint points__arr10;
        [FieldOffset(0x10C)] public BossRifleBattleAttackHomingLaserShotPoint points__arr11;
        [FieldOffset(0x118)] public BossRifleBattleAttackHomingLaserShotPoint points__arr12;
        [FieldOffset(0x124)] public BossRifleBattleAttackHomingLaserShotPoint points__arr13;
        [FieldOffset(0x130)] public BossRifleBattleAttackHomingLaserShotPoint points__arr14;
        [FieldOffset(0x13C)] public BossRifleBattleAttackHomingLaserShotPoint points__arr15;
        [FieldOffset(0x148)] public BossRifleBattleAttackHomingLaserShotPoint points__arr16;
        [FieldOffset(0x154)] public BossRifleBattleAttackHomingLaserShotPoint points__arr17;
        [FieldOffset(0x160)] public BossRifleBattleAttackHomingLaserShotPoint points__arr18;
        [FieldOffset(0x16C)] public BossRifleBattleAttackHomingLaserShotPoint points__arr19;
        [FieldOffset(0x178)] public BossRifleBattleAttackHomingLaserShotPoint points__arr20;
        [FieldOffset(0x184)] public BossRifleBattleAttackHomingLaserShotPoint points__arr21;
        [FieldOffset(0x190)] public BossRifleBattleAttackHomingLaserShotPoint points__arr22;
        [FieldOffset(0x19C)] public BossRifleBattleAttackHomingLaserShotPoint points__arr23;
        [FieldOffset(0x1A8)] public BossRifleBattleAttackHomingLaserShotPoint points__arr24;
        [FieldOffset(0x1B4)] public BossRifleBattleAttackHomingLaserShotPoint points__arr25;
        [FieldOffset(0x1C0)] public BossRifleBattleAttackHomingLaserShotPoint points__arr26;
        [FieldOffset(0x1CC)] public BossRifleBattleAttackHomingLaserShotPoint points__arr27;
        [FieldOffset(0x1D8)] public BossRifleBattleAttackHomingLaserShotPoint points__arr28;
        [FieldOffset(0x1E4)] public BossRifleBattleAttackHomingLaserShotPoint points__arr29;
        [FieldOffset(0x1F0)] public BossRifleBattleAttackHomingLaserShotPoint points__arr30;
        [FieldOffset(0x1FC)] public BossRifleBattleAttackHomingLaserShotPoint points__arr31;
        [FieldOffset(0x210)] public Vector3 fixedCameraEyePos;
        [FieldOffset(0x220)] public Vector3 fixedCameraLookAtPos;
        [FieldOffset(0x230)] public float fixedCameraDelay;
        [FieldOffset(0x234)] public float fixedCameraTime;
        [FieldOffset(0x238)] public float fixedCameraStartEaseTime;
        [FieldOffset(0x23C)] public float fixedCameraEndEaseTime;
        [FieldOffset(0x240)] public Vector3 parryCameraEyePos;
        [FieldOffset(0x250)] public Vector3 parryCameraLookAtPos;
        [FieldOffset(0x260)] public float parryCameraStartEaseTime;
        [FieldOffset(0x264)] public float parryCameraEndEaseTime;
        [FieldOffset(0x268)] public bool isParrySlow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x770)]
    public struct BossRifleBattleAttackHomingLaser
    {
        [FieldOffset(0x00)] public float bulletScale;
        [FieldOffset(0x04)] public float parryMoveTime;
        [FieldOffset(0x10)] public BossRifleBattleAttackHomingLaserAttackParam headShotParam;
        [FieldOffset(0x280)] public BossRifleBattleAttackHomingLaserAttackParam headShotFlyParam;
        [FieldOffset(0x4F0)] public BossRifleBattleAttackHomingLaserAttackParam normalShotParam;
        [FieldOffset(0x760)] public bool isDebugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct BossRifleBattleAttackHandLaserPatternParam
    {
        [FieldOffset(0x00)] public float intarvalDistance;
        [FieldOffset(0x04)] public float delay;
        [FieldOffset(0x10)] public Vector3 localStartPos;
        [FieldOffset(0x20)] public Vector3 localEndPos;
        [FieldOffset(0x30)] public Vector3 localStartDir;
        [FieldOffset(0x40)] public Vector3 localEndDir;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2A0)]
    public struct BossRifleBattleAttackHandLaser
    {
        [FieldOffset(0x00)] public float bulletRadius;
        [FieldOffset(0x04)] public float bulletSpeed;
        [FieldOffset(0x08)] public float wayAngle;
        [FieldOffset(0x0C)] public uint wayNum;
        [FieldOffset(0x10)] public float limitDistance;
        [FieldOffset(0x14)] public float blowoffSpeed;
        [FieldOffset(0x18)] public float outOfControlTime;
        [FieldOffset(0x1C)] public float keepVelocity;
        [FieldOffset(0x20)] public BossRifleBattleAttackHandLaserPatternParam handLeftPatterns__arr0;
        [FieldOffset(0x70)] public BossRifleBattleAttackHandLaserPatternParam handLeftPatterns__arr1;
        [FieldOffset(0xC0)] public BossRifleBattleAttackHandLaserPatternParam handLeftPatterns__arr2;
        [FieldOffset(0x110)] public BossRifleBattleAttackHandLaserPatternParam handLeftPatterns__arr3;
        [FieldOffset(0x160)] public BossRifleBattleAttackHandLaserPatternParam handRightPatterns__arr0;
        [FieldOffset(0x1B0)] public BossRifleBattleAttackHandLaserPatternParam handRightPatterns__arr1;
        [FieldOffset(0x200)] public BossRifleBattleAttackHandLaserPatternParam handRightPatterns__arr2;
        [FieldOffset(0x250)] public BossRifleBattleAttackHandLaserPatternParam handRightPatterns__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct BossRifleBattleFlyParam
    {
        [FieldOffset(0x00)] public float flyHeight;
        [FieldOffset(0x04)] public float flyRotationSpeed;
        [FieldOffset(0x08)] public float flyMoveHitDamageDownSpeedRatio;
        [FieldOffset(0x0C)] public float flyMoveHitDamageDownSpeedTime;
        [FieldOffset(0x10)] public float flyMoveSpeed;
        [FieldOffset(0x14)] public float flyMoveCircleRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct BossRifleBattleZoomCamera
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float elevation;
        [FieldOffset(0x08)] public float playerHeight;
        [FieldOffset(0x0C)] public float easeInTime;
        [FieldOffset(0x10)] public float easeOutTime;
        [FieldOffset(0x14)] public float changeParamDistanceMin;
        [FieldOffset(0x18)] public float changeParamDistanceMax;
        [FieldOffset(0x1C)] public float addDistance;
        [FieldOffset(0x20)] public float addElevation;
        [FieldOffset(0x24)] public float addPlayerHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct BossRifleBattleCameraParam
    {
        [FieldOffset(0x00)] public BossRifleBattleZoomCamera normalCamera__arr0;
        [FieldOffset(0x28)] public BossRifleBattleZoomCamera normalCamera__arr1;
        [FieldOffset(0x50)] public BossRifleBattleZoomCamera flyCamera__arr0;
        [FieldOffset(0x78)] public BossRifleBattleZoomCamera flyCamera__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossRifleParrySlowParam
    {
        [FieldOffset(0x00)] public float scale;
        [FieldOffset(0x04)] public float time;
        [FieldOffset(0x08)] public float easeOutTime;
        [FieldOffset(0x0C)] public bool cameraSlow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BossRifleParryParam
    {
        [FieldOffset(0x00)] public BossRifleParrySlowParam homingLaserParrySlow;
        [FieldOffset(0x10)] public BossRifleParrySlowParam homingLaserLastParrySlow;
        [FieldOffset(0x20)] public BossRifleParrySlowParam homingLaserOneShotParrySlow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4FC0)]
    public struct BossRifleBattleParam
    {
        [FieldOffset(0x00)] public BossRiflePhaseParam giantPhaseParams__arr0;
        [FieldOffset(0x1000)] public BossRiflePhaseParam giantPhaseParams__arr1;
        [FieldOffset(0x2000)] public BossRiflePhaseParam giantPhaseParams__arr2;
        [FieldOffset(0x3000)] public BossRiflePhaseParam giantPhaseParams__arr3;
        [FieldOffset(0x4000)] public BossRiflePhaseAttackActionParam actionParams__arr0;
        [FieldOffset(0x4048)] public BossRiflePhaseAttackActionParam actionParams__arr1;
        [FieldOffset(0x4090)] public BossRiflePhaseAttackActionParam actionParams__arr2;
        [FieldOffset(0x40D8)] public BossRiflePhaseAttackActionParam actionParams__arr3;
        [FieldOffset(0x4120)] public BossRiflePhaseAttackActionParam actionParams__arr4;
        [FieldOffset(0x4168)] public BossRiflePhaseAttackActionParam actionParams__arr5;
        [FieldOffset(0x41B0)] public BossRiflePhaseAttackActionParam actionParams__arr6;
        [FieldOffset(0x41F8)] public BossRiflePhaseAttackActionParam actionParams__arr7;
        [FieldOffset(0x4240)] public BossRiflePhaseAttackActionParam actionParams__arr8;
        [FieldOffset(0x4288)] public BossRiflePhaseAttackActionParam actionParams__arr9;
        [FieldOffset(0x42D0)] public BossRiflePhaseAttackActionParam actionParams__arr10;
        [FieldOffset(0x4318)] public BossRiflePhaseAttackActionParam actionParams__arr11;
        [FieldOffset(0x4360)] public BossRiflePhaseAttackActionParam actionParams__arr12;
        [FieldOffset(0x43A8)] public BossRiflePhaseAttackActionParam actionParams__arr13;
        [FieldOffset(0x43F0)] public BossRiflePhaseAttackActionParam actionParams__arr14;
        [FieldOffset(0x4438)] public BossRiflePhaseAttackActionParam actionParams__arr15;
        [FieldOffset(0x4480)] public BossRifleBattleParam_ActionType immediateActions__arr0;
        [FieldOffset(0x4481)] public BossRifleBattleParam_ActionType immediateActions__arr1;
        [FieldOffset(0x4482)] public BossRifleBattleParam_ActionType immediateActions__arr2;
        [FieldOffset(0x4483)] public BossRifleBattleParam_ActionType immediateActions__arr3;
        [FieldOffset(0x4484)] public BossRifleBattleParam_ActionType immediateActions__arr4;
        [FieldOffset(0x4485)] public BossRifleBattleParam_ActionType immediateActions__arr5;
        [FieldOffset(0x4486)] public BossRifleBattleParam_ActionType immediateActions__arr6;
        [FieldOffset(0x4487)] public BossRifleBattleParam_ActionType immediateActions__arr7;
        [FieldOffset(0x4488)] public BossRifleBattleParam_ActionType immediateActions__arr8;
        [FieldOffset(0x4489)] public BossRifleBattleParam_ActionType immediateActions__arr9;
        [FieldOffset(0x448A)] public BossRifleBattleParam_ActionType immediateActions__arr10;
        [FieldOffset(0x448B)] public BossRifleBattleParam_ActionType immediateActions__arr11;
        [FieldOffset(0x448C)] public BossRifleBattleParam_ActionType immediateActions__arr12;
        [FieldOffset(0x448D)] public BossRifleBattleParam_ActionType immediateActions__arr13;
        [FieldOffset(0x448E)] public BossRifleBattleParam_ActionType immediateActions__arr14;
        [FieldOffset(0x448F)] public BossRifleBattleParam_ActionType immediateActions__arr15;
        [FieldOffset(0x4490)] public BossRifleBattleParam_ActionType immediateActions__arr16;
        [FieldOffset(0x4491)] public BossRifleBattleParam_ActionType immediateActions__arr17;
        [FieldOffset(0x4492)] public BossRifleBattleParam_ActionType immediateActions__arr18;
        [FieldOffset(0x4493)] public BossRifleBattleParam_ActionType immediateActions__arr19;
        [FieldOffset(0x4494)] public BossRifleCyloopFloatActionParam cyloopFloatAction;
        [FieldOffset(0x44A0)] public BossRifleBattleAttackHomingLaser attackHomingLaser;
        [FieldOffset(0x4C10)] public BossRifleBattleAttackHandLaser attackHandLaser;
        [FieldOffset(0x4EB0)] public BossRifleBattleFlyParam flyParam;
        [FieldOffset(0x4EC8)] public BossRifleBattleCameraParam cameraParam;
        [FieldOffset(0x4F68)] public BossRifleParryParam parryParam;
        [FieldOffset(0x4F98)] public float thresholdDamageEffectHPRatio__arr0;
        [FieldOffset(0x4F9C)] public float thresholdDamageEffectHPRatio__arr1;
        [FieldOffset(0x4FA0)] public float thresholdDamageEffectHPRatio__arr2;
        [FieldOffset(0x4FA4)] public float qteSucceedWaitTimes__arr0;
        [FieldOffset(0x4FA8)] public float qteSucceedWaitTimes__arr1;
        [FieldOffset(0x4FAC)] public float qteSucceedWaitTimes__arr2;
        [FieldOffset(0x4FB0)] public float qteSucceedWaitTimes__arr3;
        [FieldOffset(0x4FB4)] public bool isDebugDraw;
        [FieldOffset(0x4FB5)] public bool isSkip;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x03)]
    public struct EnemyPracticeNotifierConfig
    {
        [FieldOffset(0x00)] public bool usePracticeNotifier;
        [FieldOffset(0x01)] public sbyte practiceNo;
        [FieldOffset(0x02)] public sbyte tipsNo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x06)]
    public struct BossRifleNotifierParam
    {
        [FieldOffset(0x00)] public EnemyPracticeNotifierConfig notifierConfigBattle1;
        [FieldOffset(0x03)] public EnemyPracticeNotifierConfig notifierConfigBattle2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x17790)]
    public struct BossRifleConfig
    {
        [FieldOffset(0)]     public BossBaseConfig bossBaseConfig;
        [FieldOffset(0x127C0)] public BossRifleBattleParam battleParam;
        [FieldOffset(0x17780)] public BossRifleNotifierParam notifierParam;
    }

}