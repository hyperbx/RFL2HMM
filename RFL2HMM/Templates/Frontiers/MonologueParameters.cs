using System.Numerics;
using System.Runtime.InteropServices;

public class MonologueParametersClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x188)]
    public struct MonologueIslandParameters
    {
        [FieldOffset(0x00)] public float playSpanTime;
        [FieldOffset(0x08)] public UnmanagedString labelNames__arr0;
        [FieldOffset(0x18)] public UnmanagedString labelNames__arr1;
        [FieldOffset(0x28)] public UnmanagedString labelNames__arr2;
        [FieldOffset(0x38)] public UnmanagedString labelNames__arr3;
        [FieldOffset(0x48)] public UnmanagedString labelNames__arr4;
        [FieldOffset(0x58)] public UnmanagedString labelNames__arr5;
        [FieldOffset(0x68)] public UnmanagedString labelNames__arr6;
        [FieldOffset(0x78)] public UnmanagedString labelNames__arr7;
        [FieldOffset(0x88)] public UnmanagedString labelNames__arr8;
        [FieldOffset(0x98)] public UnmanagedString labelNames__arr9;
        [FieldOffset(0xA8)] public UnmanagedString labelNames__arr10;
        [FieldOffset(0xB8)] public UnmanagedString labelNames__arr11;
        [FieldOffset(0xC8)] public UnmanagedString labelNames__arr12;
        [FieldOffset(0xD8)] public UnmanagedString labelNames__arr13;
        [FieldOffset(0xE8)] public UnmanagedString labelNames__arr14;
        [FieldOffset(0xF8)] public UnmanagedString labelNames__arr15;
        [FieldOffset(0x108)] public UnmanagedString labelNames__arr16;
        [FieldOffset(0x118)] public UnmanagedString labelNames__arr17;
        [FieldOffset(0x128)] public UnmanagedString labelNames__arr18;
        [FieldOffset(0x138)] public UnmanagedString labelNames__arr19;
        [FieldOffset(0x148)] public UnmanagedString labelNames__arr20;
        [FieldOffset(0x158)] public UnmanagedString labelNames__arr21;
        [FieldOffset(0x168)] public UnmanagedString labelNames__arr22;
        [FieldOffset(0x178)] public UnmanagedString labelNames__arr23;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MonologueMultiTextParameters
    {
        [FieldOffset(0x00)] public UnmanagedString labelNames__arr0;
        [FieldOffset(0x10)] public UnmanagedString labelNames__arr1;
        [FieldOffset(0x20)] public UnmanagedString labelNames__arr2;
        [FieldOffset(0x30)] public UnmanagedString labelNames__arr3;
    }

    public enum Value : sbyte
    {
        SteppeIsland1 = 0,
        DesertIsland = 1,
        VolcanicIsland = 2,
        TowerIsland = 3,
        SteppeIsland2 = 4,
        Num = 5,
        ExtraIsland = 5,
        NumInExtra = 6
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x7F0)]
    public struct MonologueParameters
    {
        [FieldOffset(0x00)] public MonologueIslandParameters islands__arr0;
        [FieldOffset(0x188)] public MonologueIslandParameters islands__arr1;
        [FieldOffset(0x310)] public MonologueIslandParameters islands__arr2;
        [FieldOffset(0x498)] public MonologueIslandParameters islands__arr3;
        [FieldOffset(0x620)] public MonologueIslandParameters islands__arr4;
        [FieldOffset(0x7A8)] public MonologueMultiTextParameters multiText;
        [FieldOffset(0x7E8)] public sbyte firstTheEndNotifyCount;
        [FieldOffset(0x7E9)] public sbyte theEndNotifyCount;
        [FieldOffset(0x7EA)] public Value dummy;
    }

}