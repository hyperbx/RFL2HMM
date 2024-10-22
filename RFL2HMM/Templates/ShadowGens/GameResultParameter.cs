Library "GameResultParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct ResultViewParam
    {
        [FieldOffset(0x00)] public float waitTimeStart;
        [FieldOffset(0x04)] public float waitTimeRing;
        [FieldOffset(0x08)] public float waitTimeRank;
        [FieldOffset(0x0C)] public float waitTimeRankAS;
        [FieldOffset(0x10)] public float waitTimeNextRank;
        [FieldOffset(0x14)] public float waitTimeObj;
        [FieldOffset(0x18)] public float scoreChangeTime;
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
    public struct ResultScoreParam
    {
        [FieldOffset(0x00)] public UnmanagedString stageCode;
        [FieldOffset(0x10)] public int baseScore;
        [FieldOffset(0x14)] public int coefTime;
        [FieldOffset(0x18)] public int coefRing;
        [FieldOffset(0x1C)] public int ringScoreMax;
        [FieldOffset(0x20)] public int scoreRankS;
        [FieldOffset(0x24)] public int scoreRankA;
        [FieldOffset(0x28)] public int scoreRankB;
        [FieldOffset(0x2C)] public int scoreRankC;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x410)]
    public struct GameResultParameter
    {
        [FieldOffset(0x00)] public ResultViewParam viewParam;
        [FieldOffset(0x20)] public ResultScoreParam defaultScore;
        [FieldOffset(0x50)] public ResultScoreParam stageScore__arr0;
        [FieldOffset(0x80)] public ResultScoreParam stageScore__arr1;
        [FieldOffset(0xB0)] public ResultScoreParam stageScore__arr2;
        [FieldOffset(0xE0)] public ResultScoreParam stageScore__arr3;
        [FieldOffset(0x110)] public ResultScoreParam stageScore__arr4;
        [FieldOffset(0x140)] public ResultScoreParam stageScore__arr5;
        [FieldOffset(0x170)] public ResultScoreParam stageScore__arr6;
        [FieldOffset(0x1A0)] public ResultScoreParam stageScore__arr7;
        [FieldOffset(0x1D0)] public ResultScoreParam stageScore__arr8;
        [FieldOffset(0x200)] public ResultScoreParam stageScore__arr9;
        [FieldOffset(0x230)] public ResultScoreParam stageScore__arr10;
        [FieldOffset(0x260)] public ResultScoreParam stageScore__arr11;
        [FieldOffset(0x290)] public ResultScoreParam stageScore__arr12;
        [FieldOffset(0x2C0)] public ResultScoreParam stageScore__arr13;
        [FieldOffset(0x2F0)] public ResultScoreParam stageScore__arr14;
        [FieldOffset(0x320)] public ResultScoreParam stageScore__arr15;
        [FieldOffset(0x350)] public ResultScoreParam stageScore__arr16;
        [FieldOffset(0x380)] public ResultScoreParam stageScore__arr17;
        [FieldOffset(0x3B0)] public ResultScoreParam stageScore__arr18;
        [FieldOffset(0x3E0)] public ResultScoreParam stageScore__arr19;
    }

}