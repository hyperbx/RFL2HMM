Library "BossBaseConfig"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

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

    [StructLayout(LayoutKind.Explicit, Size = 0xD0)]
    public struct BossStatusConfig
    {
        [FieldOffset(0x00)] public uint healthPoint;
        [FieldOffset(0x04)] public float stunTime;
        [FieldOffset(0x08)] public BossPhaseParam phaseParams__arr0;
        [FieldOffset(0x10)] public BossPhaseParam phaseParams__arr1;
        [FieldOffset(0x18)] public BossPhaseParam phaseParams__arr2;
        [FieldOffset(0x20)] public BossPhaseParam phaseParams__arr3;
        [FieldOffset(0x28)] public BossPhaseParam phaseParams__arr4;
        [FieldOffset(0x30)] public BossPhaseParam phaseParams__arr5;
        [FieldOffset(0x38)] public BossPhaseParam phaseParams__arr6;
        [FieldOffset(0x40)] public BossPhaseParam phaseParams__arr7;
        [FieldOffset(0x50)] public BossLockOnCameraParam cameraParam;
        [FieldOffset(0xC0)] public bool isDebugDraw;
        [FieldOffset(0xC4)] public uint debugDrawPhaseIndex;
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

    [StructLayout(LayoutKind.Explicit, Size = 0xF0)]
    public struct BossBaseConfig
    {
        [FieldOffset(0x00)] public BossStatusConfig status;
        [FieldOffset(0xD0)] public BossDropRingConfig dropRing;
    }

}