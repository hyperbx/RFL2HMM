Library "GameChallengeParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

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

    public enum ChallengeType : byte
    {
        Ring = 0,
        OneRing = 1,
        TargetAnnihilation = 2,
        ChaosControllMaster = 3,
        CleaningSea = 4,
        DashRing = 5,
        ArcEscape = 6,
        BilliardBlow = 7,
        SpearRunner = 8,
        HighSpeedRailCanyon = 9,
        StoneLabyrinth = 10,
        DeathEggRobotPanic = 11,
        GondolaSurveyTeam = 12,
        Num = 13
    }

    public enum IconType : sbyte
    {
        RING = 0,
        CLOCK = 1,
        ENEMYCHAOS = 2,
        ENEMYBEETLE = 3,
        OBJCHAOSSPEAR = 4,
        OBJDASHRING = 5,
        OBJSURFSPIN = 6,
        ENEMYEGGSTINGER = 7,
        ENEMYTWISTER = 8,
        None = 9,
        NUM = 10
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct ResultChallengeParam
    {
        [FieldOffset(0x00)] public float timeRankS;
        [FieldOffset(0x04)] public float timeRankA;
        [FieldOffset(0x08)] public float timeRankB;
        [FieldOffset(0x0C)] public float timeRankC;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct GameChallengeCollectionData
    {
        [FieldOffset(0x00)] public int clearCollectionNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x88)]
    public struct GameChallengeAnnihilationData
    {
        [FieldOffset(0x00)] public UnmanagedString targetIDs__arr0;
        [FieldOffset(0x10)] public UnmanagedString targetIDs__arr1;
        [FieldOffset(0x20)] public UnmanagedString targetIDs__arr2;
        [FieldOffset(0x30)] public UnmanagedString targetIDs__arr3;
        [FieldOffset(0x40)] public UnmanagedString targetIDs__arr4;
        [FieldOffset(0x50)] public UnmanagedString targetIDs__arr5;
        [FieldOffset(0x60)] public UnmanagedString targetIDs__arr6;
        [FieldOffset(0x70)] public UnmanagedString targetIDs__arr7;
        [FieldOffset(0x80)] public int clearAnnihilationNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x88)]
    public struct GameChallengeTouchData
    {
        [FieldOffset(0x00)] public UnmanagedString targetIDs__arr0;
        [FieldOffset(0x10)] public UnmanagedString targetIDs__arr1;
        [FieldOffset(0x20)] public UnmanagedString targetIDs__arr2;
        [FieldOffset(0x30)] public UnmanagedString targetIDs__arr3;
        [FieldOffset(0x40)] public UnmanagedString targetIDs__arr4;
        [FieldOffset(0x50)] public UnmanagedString targetIDs__arr5;
        [FieldOffset(0x60)] public UnmanagedString targetIDs__arr6;
        [FieldOffset(0x70)] public UnmanagedString targetIDs__arr7;
        [FieldOffset(0x80)] public int clearTouchNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x160)]
    public struct GameChallengeData
    {
        [FieldOffset(0x00)] public UnmanagedString stageCode;
        [FieldOffset(0x10)] public ChallengeType challenge;
        [FieldOffset(0x11)] public IconType iconType;
        [FieldOffset(0x14)] public float limitTime;
        [FieldOffset(0x18)] public UnmanagedString titleLabel;
        [FieldOffset(0x28)] public UnmanagedString explainLabel;
        [FieldOffset(0x38)] public ResultChallengeParam resultData;
        [FieldOffset(0x48)] public GameChallengeCollectionData chalengeRingData;
        [FieldOffset(0x50)] public GameChallengeAnnihilationData challengeAnnihilationData;
        [FieldOffset(0xD8)] public GameChallengeTouchData challengeTouchData;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3B20)]
    public struct GameChallengeParameter
    {
        [FieldOffset(0x00)] public GameChallengeData datas__arr0;
        [FieldOffset(0x160)] public GameChallengeData datas__arr1;
        [FieldOffset(0x2C0)] public GameChallengeData datas__arr2;
        [FieldOffset(0x420)] public GameChallengeData datas__arr3;
        [FieldOffset(0x580)] public GameChallengeData datas__arr4;
        [FieldOffset(0x6E0)] public GameChallengeData datas__arr5;
        [FieldOffset(0x840)] public GameChallengeData datas__arr6;
        [FieldOffset(0x9A0)] public GameChallengeData datas__arr7;
        [FieldOffset(0xB00)] public GameChallengeData datas__arr8;
        [FieldOffset(0xC60)] public GameChallengeData datas__arr9;
        [FieldOffset(0xDC0)] public GameChallengeData datas__arr10;
        [FieldOffset(0xF20)] public GameChallengeData datas__arr11;
        [FieldOffset(0x1080)] public GameChallengeData datas__arr12;
        [FieldOffset(0x11E0)] public GameChallengeData datas__arr13;
        [FieldOffset(0x1340)] public GameChallengeData datas__arr14;
        [FieldOffset(0x14A0)] public GameChallengeData datas__arr15;
        [FieldOffset(0x1600)] public GameChallengeData datas__arr16;
        [FieldOffset(0x1760)] public GameChallengeData datas__arr17;
        [FieldOffset(0x18C0)] public GameChallengeData datas__arr18;
        [FieldOffset(0x1A20)] public GameChallengeData datas__arr19;
        [FieldOffset(0x1B80)] public GameChallengeData datas__arr20;
        [FieldOffset(0x1CE0)] public GameChallengeData datas__arr21;
        [FieldOffset(0x1E40)] public GameChallengeData datas__arr22;
        [FieldOffset(0x1FA0)] public GameChallengeData datas__arr23;
        [FieldOffset(0x2100)] public GameChallengeData datas__arr24;
        [FieldOffset(0x2260)] public GameChallengeData datas__arr25;
        [FieldOffset(0x23C0)] public GameChallengeData datas__arr26;
        [FieldOffset(0x2520)] public GameChallengeData datas__arr27;
        [FieldOffset(0x2680)] public GameChallengeData datas__arr28;
        [FieldOffset(0x27E0)] public GameChallengeData datas__arr29;
        [FieldOffset(0x2940)] public GameChallengeData datas__arr30;
        [FieldOffset(0x2AA0)] public GameChallengeData datas__arr31;
        [FieldOffset(0x2C00)] public GameChallengeData hardChallenges__arr0;
        [FieldOffset(0x2D60)] public GameChallengeData hardChallenges__arr1;
        [FieldOffset(0x2EC0)] public GameChallengeData hardChallenges__arr2;
        [FieldOffset(0x3020)] public GameChallengeData hardChallenges__arr3;
        [FieldOffset(0x3180)] public GameChallengeData hardChallenges__arr4;
        [FieldOffset(0x32E0)] public GameChallengeData hardChallenges__arr5;
        [FieldOffset(0x3440)] public GameChallengeData hardChallenges__arr6;
        [FieldOffset(0x35A0)] public GameChallengeData hardChallenges__arr7;
        [FieldOffset(0x3700)] public GameChallengeData hardChallenges__arr8;
        [FieldOffset(0x3860)] public GameChallengeData hardChallenges__arr9;
        [FieldOffset(0x39C0)] public GameChallengeData hardChallenges__arr10;
    }

}