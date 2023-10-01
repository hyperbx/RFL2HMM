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

    [StructLayout(LayoutKind.Explicit, Size = 0x188)]
    public struct MonologueIslandParameters
    {
        [FieldOffset(0x00)] public float playSpanTime;
        [FieldOffset(0x08)] public UnmanagedString labelNames__arr0;
        [FieldOffset(0x107)] public UnmanagedString labelNames__arr1;
        [FieldOffset(0x206)] public UnmanagedString labelNames__arr2;
        [FieldOffset(0x305)] public UnmanagedString labelNames__arr3;
        [FieldOffset(0x404)] public UnmanagedString labelNames__arr4;
        [FieldOffset(0x503)] public UnmanagedString labelNames__arr5;
        [FieldOffset(0x602)] public UnmanagedString labelNames__arr6;
        [FieldOffset(0x701)] public UnmanagedString labelNames__arr7;
        [FieldOffset(0x800)] public UnmanagedString labelNames__arr8;
        [FieldOffset(0x8FF)] public UnmanagedString labelNames__arr9;
        [FieldOffset(0x9FE)] public UnmanagedString labelNames__arr10;
        [FieldOffset(0xAFD)] public UnmanagedString labelNames__arr11;
        [FieldOffset(0xBFC)] public UnmanagedString labelNames__arr12;
        [FieldOffset(0xCFB)] public UnmanagedString labelNames__arr13;
        [FieldOffset(0xDFA)] public UnmanagedString labelNames__arr14;
        [FieldOffset(0xEF9)] public UnmanagedString labelNames__arr15;
        [FieldOffset(0xFF8)] public UnmanagedString labelNames__arr16;
        [FieldOffset(0x10F7)] public UnmanagedString labelNames__arr17;
        [FieldOffset(0x11F6)] public UnmanagedString labelNames__arr18;
        [FieldOffset(0x12F5)] public UnmanagedString labelNames__arr19;
        [FieldOffset(0x13F4)] public UnmanagedString labelNames__arr20;
        [FieldOffset(0x14F3)] public UnmanagedString labelNames__arr21;
        [FieldOffset(0x15F2)] public UnmanagedString labelNames__arr22;
        [FieldOffset(0x16F1)] public UnmanagedString labelNames__arr23;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MonologueMultiTextParameters
    {
        [FieldOffset(0x00)] public UnmanagedString labelNames__arr0;
        [FieldOffset(0xFF)] public UnmanagedString labelNames__arr1;
        [FieldOffset(0x1FE)] public UnmanagedString labelNames__arr2;
        [FieldOffset(0x2FD)] public UnmanagedString labelNames__arr3;
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