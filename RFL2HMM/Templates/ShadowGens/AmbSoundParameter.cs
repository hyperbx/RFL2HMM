Library "AmbSoundParameter"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct AmbInfo
    {
        [FieldOffset(0x00)] public UnmanagedString cueName;
        [FieldOffset(0x10)] public float fadeInTime;
        [FieldOffset(0x14)] public float fadeOutTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct AmbBaseNoiseParameter
    {
        [FieldOffset(0x00)] public UnmanagedString cueName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct AmbRelativeWindParameter
    {
        [FieldOffset(0x00)] public UnmanagedString cueName;
        [FieldOffset(0x10)] public float speedThreshold;
        [FieldOffset(0x14)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct AmbNearPointParameter
    {
        [FieldOffset(0x00)] public UnmanagedString cueName;
        [FieldOffset(0x10)] public float sensorRebootTime;
        [FieldOffset(0x14)] public float sensorRepositionTime;
        [FieldOffset(0x18)] public float lifeAreaRadius;
        [FieldOffset(0x1C)] public float lifeTime;
        [FieldOffset(0x20)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct AmbRiverParameter_Nearest
    {
        [FieldOffset(0x00)] public UnmanagedString cueName;
        [FieldOffset(0x10)] public float sensorRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct AmbRiverParameter_Multiple3D
    {
        [FieldOffset(0x00)] public UnmanagedString cueName;
        [FieldOffset(0x10)] public float attenuationDistance;
        [FieldOffset(0x14)] public float maxLevelPerPoint;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x168)]
    public struct AmbSoundParameter
    {
        [FieldOffset(0x00)] public AmbInfo ambSoundInfo__arr0;
        [FieldOffset(0x18)] public AmbInfo ambSoundInfo__arr1;
        [FieldOffset(0x30)] public AmbInfo ambSoundInfo__arr2;
        [FieldOffset(0x48)] public AmbInfo ambSoundInfo__arr3;
        [FieldOffset(0x60)] public AmbInfo ambSoundInfo__arr4;
        [FieldOffset(0x78)] public AmbInfo ambSoundInfo__arr5;
        [FieldOffset(0x90)] public AmbInfo ambSoundInfo__arr6;
        [FieldOffset(0xA8)] public AmbInfo ambSoundInfo__arr7;
        [FieldOffset(0xC0)] public AmbBaseNoiseParameter baseNoise;
        [FieldOffset(0xD0)] public AmbRelativeWindParameter relativeWind;
        [FieldOffset(0xE8)] public AmbNearPointParameter insect;
        [FieldOffset(0x110)] public AmbNearPointParameter grass;
        [FieldOffset(0x138)] public AmbRiverParameter_Nearest riverNearest;
        [FieldOffset(0x150)] public AmbRiverParameter_Multiple3D riverMultiple3D;
    }

}