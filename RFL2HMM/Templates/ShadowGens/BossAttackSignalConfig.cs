Library "BossAttackSignalConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BossAttackSignalParamInfo
    {
        [FieldOffset(0x00)] public UnmanagedString tagName;
        [FieldOffset(0x10)] public float time;
        [FieldOffset(0x14)] public float delay;
        [FieldOffset(0x18)] public float radiusMin;
        [FieldOffset(0x1C)] public float radiusMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x200)]
    public struct BossAttackSignalConfig
    {
        [FieldOffset(0x00)] public BossAttackSignalParamInfo _params__arr0;
        [FieldOffset(0x20)] public BossAttackSignalParamInfo _params__arr1;
        [FieldOffset(0x40)] public BossAttackSignalParamInfo _params__arr2;
        [FieldOffset(0x60)] public BossAttackSignalParamInfo _params__arr3;
        [FieldOffset(0x80)] public BossAttackSignalParamInfo _params__arr4;
        [FieldOffset(0xA0)] public BossAttackSignalParamInfo _params__arr5;
        [FieldOffset(0xC0)] public BossAttackSignalParamInfo _params__arr6;
        [FieldOffset(0xE0)] public BossAttackSignalParamInfo _params__arr7;
        [FieldOffset(0x100)] public BossAttackSignalParamInfo _params__arr8;
        [FieldOffset(0x120)] public BossAttackSignalParamInfo _params__arr9;
        [FieldOffset(0x140)] public BossAttackSignalParamInfo _params__arr10;
        [FieldOffset(0x160)] public BossAttackSignalParamInfo _params__arr11;
        [FieldOffset(0x180)] public BossAttackSignalParamInfo _params__arr12;
        [FieldOffset(0x1A0)] public BossAttackSignalParamInfo _params__arr13;
        [FieldOffset(0x1C0)] public BossAttackSignalParamInfo _params__arr14;
        [FieldOffset(0x1E0)] public BossAttackSignalParamInfo _params__arr15;
    }

}