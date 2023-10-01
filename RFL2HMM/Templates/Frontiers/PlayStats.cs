using System.Numerics;
using System.Runtime.InteropServices;

public class PlayStatsClass
{
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

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayStatsSummary
    {
        [FieldOffset(0x00)] public UnmanagedString stagecode;
        [FieldOffset(0x10)] public int highTime;
        [FieldOffset(0x14)] public int highScore;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayStatsSummaryArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct PlayLog
    {
        [FieldOffset(0x00)] public UnmanagedString stagecode;
        [FieldOffset(0x10)] public UnmanagedString play;
        [FieldOffset(0x20)] public UnmanagedString option;
        [FieldOffset(0x30)] public Vector3 position;
        [FieldOffset(0x40)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PlayLogArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct PlayStatsData
    {
        [FieldOffset(0x00)] public int enemies;
        [FieldOffset(0x04)] public int damages;
        [FieldOffset(0x08)] public int misses;
        [FieldOffset(0x0C)] public int retry;
        [FieldOffset(0x10)] public int restart;
        [FieldOffset(0x18)] public PlayLogArray logs;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x78)]
    public struct PlayStats
    {
        [FieldOffset(0x00)] public UnmanagedString username;
        [FieldOffset(0x10)] public UnmanagedString time;
        [FieldOffset(0x20)] public PlayStatsSummaryArray summaries;
        [FieldOffset(0x40)] public PlayStatsData playLog;
    }

}