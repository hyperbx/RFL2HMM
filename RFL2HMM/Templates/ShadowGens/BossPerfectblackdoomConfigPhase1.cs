Library "BossPerfectblackdoomConfigPhase1"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossPerfectblackdoomConfigPhase1CommonParam
    {
        [FieldOffset(0x00)] public float floatHeight;
        [FieldOffset(0x04)] public sbyte laneNum;
        [FieldOffset(0x08)] public float laneWidth;
        [FieldOffset(0x0C)] public float distanceOfAttackBasePointFromPlayer;
        [FieldOffset(0x10)] public float hormingDistanceOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct BossPerfectblackdoomAutorunParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float width;
        [FieldOffset(0x08)] public float bossSpeedMax;
        [FieldOffset(0x0C)] public float bossSpeedMin;
        [FieldOffset(0x10)] public float bossAccelSpeed;
        [FieldOffset(0x14)] public float bossDecelSpeed;
        [FieldOffset(0x18)] public float bossKeepDistanceDefault;
        [FieldOffset(0x1C)] public float bossKeepDistanceLimit;
        [FieldOffset(0x20)] public float bossStanLostDistance;
        [FieldOffset(0x24)] public float bossDefalutDistanceReturnTime;
        [FieldOffset(0x28)] public float bossDefalutDistanceReturnSpeed;
        [FieldOffset(0x2C)] public float nearBossAccelDecelTime;
        [FieldOffset(0x30)] public float nearBossAccelSpeed;
        [FieldOffset(0x34)] public float nearBossDecelSpeed;
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

    public enum LaserDirectionKind : sbyte
    {
        UP_DIRECTION = 0,
        DOWN_DIRECTION = 1,
        RIGHT_DIRECTION = 2,
        LEFT_DIRECTION = 3,
        UP_DOWN_DIRECTION = 4,
        LEFT_RIGHT_DIRECTION = 5,
        UDLR_DIRECTION = 6
    }

    public enum InputGuideKind : sbyte
    {
        INPUT_GUIDE_KIND_NONE = 0,
        INPUT_GUIDE_KIND_LEFT_STEP = 1,
        INPUT_GUIDE_KIND_RIGHT_STEP = 2,
        INPUT_GUIDE_KIND_NUM = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BossPerfectblackdoomPhase1MeteoriteBeamInfo
    {
        [FieldOffset(0x00)] public sbyte laneNumber;
        [FieldOffset(0x04)] public float height;
        [FieldOffset(0x08)] public float createTime;
        [FieldOffset(0x0C)] public LaserDirectionKind laserDirKind;
        [FieldOffset(0x10)] public float rotSpeed;
        [FieldOffset(0x14)] public float moveSpeedOffset;
        [FieldOffset(0x18)] public float length;
        [FieldOffset(0x1C)] public InputGuideKind inputGuideKind;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA08)]
    public struct BossPerfectblackdoomPhase1MeteoriteBeamPatternData
    {
        [FieldOffset(0x00)] public float endWaitTime;
        [FieldOffset(0x04)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr0;
        [FieldOffset(0x24)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr1;
        [FieldOffset(0x44)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr2;
        [FieldOffset(0x64)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr3;
        [FieldOffset(0x84)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr4;
        [FieldOffset(0xA4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr5;
        [FieldOffset(0xC4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr6;
        [FieldOffset(0xE4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr7;
        [FieldOffset(0x104)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr8;
        [FieldOffset(0x124)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr9;
        [FieldOffset(0x144)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr10;
        [FieldOffset(0x164)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr11;
        [FieldOffset(0x184)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr12;
        [FieldOffset(0x1A4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr13;
        [FieldOffset(0x1C4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr14;
        [FieldOffset(0x1E4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr15;
        [FieldOffset(0x204)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr16;
        [FieldOffset(0x224)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr17;
        [FieldOffset(0x244)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr18;
        [FieldOffset(0x264)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr19;
        [FieldOffset(0x284)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr20;
        [FieldOffset(0x2A4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr21;
        [FieldOffset(0x2C4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr22;
        [FieldOffset(0x2E4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr23;
        [FieldOffset(0x304)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr24;
        [FieldOffset(0x324)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr25;
        [FieldOffset(0x344)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr26;
        [FieldOffset(0x364)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr27;
        [FieldOffset(0x384)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr28;
        [FieldOffset(0x3A4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr29;
        [FieldOffset(0x3C4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr30;
        [FieldOffset(0x3E4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr31;
        [FieldOffset(0x404)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr32;
        [FieldOffset(0x424)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr33;
        [FieldOffset(0x444)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr34;
        [FieldOffset(0x464)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr35;
        [FieldOffset(0x484)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr36;
        [FieldOffset(0x4A4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr37;
        [FieldOffset(0x4C4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr38;
        [FieldOffset(0x4E4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr39;
        [FieldOffset(0x504)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr40;
        [FieldOffset(0x524)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr41;
        [FieldOffset(0x544)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr42;
        [FieldOffset(0x564)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr43;
        [FieldOffset(0x584)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr44;
        [FieldOffset(0x5A4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr45;
        [FieldOffset(0x5C4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr46;
        [FieldOffset(0x5E4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr47;
        [FieldOffset(0x604)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr48;
        [FieldOffset(0x624)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr49;
        [FieldOffset(0x644)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr50;
        [FieldOffset(0x664)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr51;
        [FieldOffset(0x684)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr52;
        [FieldOffset(0x6A4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr53;
        [FieldOffset(0x6C4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr54;
        [FieldOffset(0x6E4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr55;
        [FieldOffset(0x704)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr56;
        [FieldOffset(0x724)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr57;
        [FieldOffset(0x744)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr58;
        [FieldOffset(0x764)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr59;
        [FieldOffset(0x784)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr60;
        [FieldOffset(0x7A4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr61;
        [FieldOffset(0x7C4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr62;
        [FieldOffset(0x7E4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr63;
        [FieldOffset(0x804)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr64;
        [FieldOffset(0x824)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr65;
        [FieldOffset(0x844)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr66;
        [FieldOffset(0x864)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr67;
        [FieldOffset(0x884)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr68;
        [FieldOffset(0x8A4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr69;
        [FieldOffset(0x8C4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr70;
        [FieldOffset(0x8E4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr71;
        [FieldOffset(0x904)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr72;
        [FieldOffset(0x924)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr73;
        [FieldOffset(0x944)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr74;
        [FieldOffset(0x964)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr75;
        [FieldOffset(0x984)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr76;
        [FieldOffset(0x9A4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr77;
        [FieldOffset(0x9C4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr78;
        [FieldOffset(0x9E4)] public BossPerfectblackdoomPhase1MeteoriteBeamInfo meteoriteBeamInfoTabel__arr79;
        [FieldOffset(0xA04)] public uint randomSeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3278)]
    public struct BossPerfectblackdoomPhase1MeteoriteBeamParam
    {
        [FieldOffset(0x00)] public float laneOffsetDistance;
        [FieldOffset(0x04)] public float backwardMoveDistance;
        [FieldOffset(0x08)] public float startWarpWaitTime;
        [FieldOffset(0x0C)] public float startWaitTime;
        [FieldOffset(0x10)] public float endWarpWaitTime;
        [FieldOffset(0x14)] public float colRadius;
        [FieldOffset(0x18)] public float dsurfBlowColScale;
        [FieldOffset(0x1C)] public float beamColRadius;
        [FieldOffset(0x20)] public float curveTime;
        [FieldOffset(0x24)] public float speed;
        [FieldOffset(0x28)] public float blowSpeed;
        [FieldOffset(0x2C)] public float lifeTime;
        [FieldOffset(0x30)] public int blowHitDamagePoint;
        [FieldOffset(0x34)] public float leaveDistance;
        [FieldOffset(0x38)] public float blowCurvedTime;
        [FieldOffset(0x3C)] public float blowCurvedYMax;
        [FieldOffset(0x40)] public float floatHeight;
        [FieldOffset(0x44)] public float moveStopDeltaTimeScale;
        [FieldOffset(0x48)] public int requestMeteoriteBeamCaptionPatternNo;
        [FieldOffset(0x4C)] public float requestMeteoriteBeamCaptionTime;
        [FieldOffset(0x50)] public BossPerfectblackdoomPhase1MeteoriteBeamPatternData meteoriteBeamPatterns__arr0;
        [FieldOffset(0xA58)] public BossPerfectblackdoomPhase1MeteoriteBeamPatternData meteoriteBeamPatterns__arr1;
        [FieldOffset(0x1460)] public BossPerfectblackdoomPhase1MeteoriteBeamPatternData meteoriteBeamPatterns__arr2;
        [FieldOffset(0x1E68)] public BossPerfectblackdoomPhase1MeteoriteBeamPatternData meteoriteBeamPatterns__arr3;
        [FieldOffset(0x2870)] public BossPerfectblackdoomPhase1MeteoriteBeamPatternData meteoriteBeamPatterns__arr4;
    }

    public enum BossPerfectblackdoomPhase1MeteoriteHockeyInfo_InputGuideKind : sbyte
    {
        BossPerfectblackdoomPhase1MeteoriteHockeyInfo_InputGuideKind_INPUT_GUIDE_KIND_NONE = 0,
        BossPerfectblackdoomPhase1MeteoriteHockeyInfo_InputGuideKind_INPUT_GUIDE_KIND_LEFT_STEP = 1,
        BossPerfectblackdoomPhase1MeteoriteHockeyInfo_InputGuideKind_INPUT_GUIDE_KIND_RIGHT_STEP = 2,
        BossPerfectblackdoomPhase1MeteoriteHockeyInfo_InputGuideKind_INPUT_GUIDE_KIND_NUM = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BossPerfectblackdoomPhase1MeteoriteHockeyInfo
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool isToPlayer;
        [FieldOffset(0x04)] public float createTime;
        [FieldOffset(0x08)] public float moveSpeedOffset;
        [FieldOffset(0x10)] public Vector3 createPos;
        [FieldOffset(0x20)] public Vector3 shotVelocity;
        [FieldOffset(0x30)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo_InputGuideKind inputGuideKind;
        [FieldOffset(0x31)] public bool colliderEnable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1420)]
    public struct BossPerfectblackdoomPhase1MeteoriteHockeyPatternData
    {
        [FieldOffset(0x00)] public float endWaitTime;
        [FieldOffset(0x10)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr0;
        [FieldOffset(0x50)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr1;
        [FieldOffset(0x90)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr2;
        [FieldOffset(0xD0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr3;
        [FieldOffset(0x110)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr4;
        [FieldOffset(0x150)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr5;
        [FieldOffset(0x190)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr6;
        [FieldOffset(0x1D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr7;
        [FieldOffset(0x210)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr8;
        [FieldOffset(0x250)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr9;
        [FieldOffset(0x290)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr10;
        [FieldOffset(0x2D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr11;
        [FieldOffset(0x310)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr12;
        [FieldOffset(0x350)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr13;
        [FieldOffset(0x390)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr14;
        [FieldOffset(0x3D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr15;
        [FieldOffset(0x410)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr16;
        [FieldOffset(0x450)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr17;
        [FieldOffset(0x490)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr18;
        [FieldOffset(0x4D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr19;
        [FieldOffset(0x510)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr20;
        [FieldOffset(0x550)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr21;
        [FieldOffset(0x590)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr22;
        [FieldOffset(0x5D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr23;
        [FieldOffset(0x610)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr24;
        [FieldOffset(0x650)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr25;
        [FieldOffset(0x690)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr26;
        [FieldOffset(0x6D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr27;
        [FieldOffset(0x710)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr28;
        [FieldOffset(0x750)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr29;
        [FieldOffset(0x790)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr30;
        [FieldOffset(0x7D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr31;
        [FieldOffset(0x810)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr32;
        [FieldOffset(0x850)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr33;
        [FieldOffset(0x890)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr34;
        [FieldOffset(0x8D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr35;
        [FieldOffset(0x910)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr36;
        [FieldOffset(0x950)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr37;
        [FieldOffset(0x990)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr38;
        [FieldOffset(0x9D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr39;
        [FieldOffset(0xA10)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr40;
        [FieldOffset(0xA50)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr41;
        [FieldOffset(0xA90)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr42;
        [FieldOffset(0xAD0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr43;
        [FieldOffset(0xB10)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr44;
        [FieldOffset(0xB50)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr45;
        [FieldOffset(0xB90)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr46;
        [FieldOffset(0xBD0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr47;
        [FieldOffset(0xC10)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr48;
        [FieldOffset(0xC50)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr49;
        [FieldOffset(0xC90)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr50;
        [FieldOffset(0xCD0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr51;
        [FieldOffset(0xD10)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr52;
        [FieldOffset(0xD50)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr53;
        [FieldOffset(0xD90)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr54;
        [FieldOffset(0xDD0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr55;
        [FieldOffset(0xE10)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr56;
        [FieldOffset(0xE50)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr57;
        [FieldOffset(0xE90)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr58;
        [FieldOffset(0xED0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr59;
        [FieldOffset(0xF10)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr60;
        [FieldOffset(0xF50)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr61;
        [FieldOffset(0xF90)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr62;
        [FieldOffset(0xFD0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr63;
        [FieldOffset(0x1010)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr64;
        [FieldOffset(0x1050)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr65;
        [FieldOffset(0x1090)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr66;
        [FieldOffset(0x10D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr67;
        [FieldOffset(0x1110)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr68;
        [FieldOffset(0x1150)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr69;
        [FieldOffset(0x1190)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr70;
        [FieldOffset(0x11D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr71;
        [FieldOffset(0x1210)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr72;
        [FieldOffset(0x1250)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr73;
        [FieldOffset(0x1290)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr74;
        [FieldOffset(0x12D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr75;
        [FieldOffset(0x1310)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr76;
        [FieldOffset(0x1350)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr77;
        [FieldOffset(0x1390)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr78;
        [FieldOffset(0x13D0)] public BossPerfectblackdoomPhase1MeteoriteHockeyInfo meteoriteHockeyInfoTabel__arr79;
        [FieldOffset(0x1410)] public uint randomSeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x64E0)]
    public struct BossPerfectblackdoomPhase1MeteoriteHockeyParam
    {
        [FieldOffset(0x00)] public float backwardMoveDistance;
        [FieldOffset(0x04)] public float startWarpWaitTime;
        [FieldOffset(0x08)] public float startWaitTime;
        [FieldOffset(0x0C)] public float endWarpWaitTime;
        [FieldOffset(0x10)] public float meteoColRadius;
        [FieldOffset(0x14)] public float dsurfBlowColScale;
        [FieldOffset(0x18)] public float meteoStartMoveTime;
        [FieldOffset(0x1C)] public float meteoSpeed;
        [FieldOffset(0x20)] public float blowSpeed;
        [FieldOffset(0x24)] public float lifeTime;
        [FieldOffset(0x28)] public int blowHitDamagePoint;
        [FieldOffset(0x2C)] public float leaveDistance;
        [FieldOffset(0x30)] public float blowCurvedTime;
        [FieldOffset(0x34)] public float blowCurvedYMax;
        [FieldOffset(0x38)] public float floatHeight;
        [FieldOffset(0x40)] public BossPerfectblackdoomPhase1MeteoriteHockeyPatternData meteoriteHockeyPatterns__arr0;
        [FieldOffset(0x1460)] public BossPerfectblackdoomPhase1MeteoriteHockeyPatternData meteoriteHockeyPatterns__arr1;
        [FieldOffset(0x2880)] public BossPerfectblackdoomPhase1MeteoriteHockeyPatternData meteoriteHockeyPatterns__arr2;
        [FieldOffset(0x3CA0)] public BossPerfectblackdoomPhase1MeteoriteHockeyPatternData meteoriteHockeyPatterns__arr3;
        [FieldOffset(0x50C0)] public BossPerfectblackdoomPhase1MeteoriteHockeyPatternData meteoriteHockeyPatterns__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct BossPerfectblackdoomPhase1DamageParam
    {
        [FieldOffset(0x00)] public float rushTime;
        [FieldOffset(0x04)] public float rushCameraDelayTime;
        [FieldOffset(0x08)] public float damageAfterTime;
        [FieldOffset(0x0C)] public float damageAfterDistance;
        [FieldOffset(0x10)] public float rushFinishDamageScale;
        [FieldOffset(0x14)] public float blowPower;
        [FieldOffset(0x18)] public float blowUpPower;
        [FieldOffset(0x1C)] public float blowDeceleration;
        [FieldOffset(0x20)] public float gravityPower;
        [FieldOffset(0x24)] public float blowEndHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x99F0)]
    public struct BossPerfectblackdoomConfigPhase1
    {
        [FieldOffset(0x00)] public BossPerfectblackdoomConfigPhase1CommonParam common;
        [FieldOffset(0x14)] public BossPerfectblackdoomAutorunParam autorun;
        [FieldOffset(0x50)] public BossPerfectblackdoomBattleLockOnCameraParam mainCamera;
        [FieldOffset(0x80)] public BossPerfectblackdoomPointCameraParam damageCamera;
        [FieldOffset(0x120)] public BossPerfectblackdoomPointCameraParam attackChanceBeforeCamera;
        [FieldOffset(0x1C0)] public BossPerfectblackdoomPointCameraParam rushDamageCamera;
        [FieldOffset(0x260)] public BossPerfectblackdoomPhase1MeteoriteBeamParam meteoriteBeamParam;
        [FieldOffset(0x34E0)] public BossPerfectblackdoomPhase1MeteoriteHockeyParam meteoriteHockeyParam;
        [FieldOffset(0x99C0)] public BossPerfectblackdoomPhase1DamageParam damageParam;
    }

}