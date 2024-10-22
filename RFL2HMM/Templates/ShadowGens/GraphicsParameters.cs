Library "GraphicsParameters"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct AuraEffectLerpNode
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float noiseTextureScrollSpeed;
        [FieldOffset(0x08)] public float blurScale;
        [FieldOffset(0x0C)] public float colorGain;
        [FieldOffset(0x10)] public float noiseGain;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct AuraEffectLerpParameter
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public AuraEffectLerpNode node__arr0;
        [FieldOffset(0x24)] public AuraEffectLerpNode node__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE0)]
    public struct AuraEffectParameters
    {
        [FieldOffset(0x00)] public AuraEffectLerpParameter _params__arr0;
        [FieldOffset(0x38)] public AuraEffectLerpParameter _params__arr1;
        [FieldOffset(0x70)] public AuraEffectLerpParameter _params__arr2;
        [FieldOffset(0xA8)] public AuraEffectLerpParameter _params__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct EffectParameters
    {
        [FieldOffset(0x00)] public float localLightIntensityScale;
        [FieldOffset(0x04)] public bool dropPriorityEnabled;
        [FieldOffset(0x05)] public sbyte dropPriority;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x05)]
    public struct WeatherBlockParameter
    {
        [FieldOffset(0x00)] public byte blockWeights__arr0;
        [FieldOffset(0x01)] public byte blockWeights__arr1;
        [FieldOffset(0x02)] public byte blockWeights__arr2;
        [FieldOffset(0x03)] public byte blockWeights__arr3;
        [FieldOffset(0x04)] public byte blockWeights__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1E)]
    public struct WeatherTypeParameter
    {
        [FieldOffset(0x00)] public byte transitWeights__arr0;
        [FieldOffset(0x01)] public byte transitWeights__arr1;
        [FieldOffset(0x02)] public byte transitWeights__arr2;
        [FieldOffset(0x03)] public byte transitWeights__arr3;
        [FieldOffset(0x04)] public byte transitWeights__arr4;
        [FieldOffset(0x05)] public WeatherBlockParameter blockParams__arr0;
        [FieldOffset(0x0A)] public WeatherBlockParameter blockParams__arr1;
        [FieldOffset(0x0F)] public WeatherBlockParameter blockParams__arr2;
        [FieldOffset(0x14)] public WeatherBlockParameter blockParams__arr3;
        [FieldOffset(0x19)] public WeatherBlockParameter blockParams__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x02)]
    public struct WeatherTimeParameter
    {
        [FieldOffset(0x00)] public byte hour;
        [FieldOffset(0x01)] public byte minute;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0A)]
    public struct WeatherTimeControlParameter
    {
        [FieldOffset(0x00)] public WeatherTimeParameter sunriseBeginTime;
        [FieldOffset(0x02)] public WeatherTimeParameter dayBeginTime;
        [FieldOffset(0x04)] public WeatherTimeParameter sunsetBeginTime;
        [FieldOffset(0x06)] public WeatherTimeParameter nightBeginTime;
        [FieldOffset(0x08)] public WeatherTimeParameter blockTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct WeatherParameters
    {
        [FieldOffset(0x00)] public WeatherTypeParameter type__arr0;
        [FieldOffset(0x1E)] public WeatherTypeParameter type__arr1;
        [FieldOffset(0x3C)] public WeatherTypeParameter type__arr2;
        [FieldOffset(0x5A)] public WeatherTypeParameter type__arr3;
        [FieldOffset(0x78)] public WeatherTypeParameter type__arr4;
        [FieldOffset(0x96)] public WeatherTimeControlParameter timeControl;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x188)]
    public struct GraphicsParameters
    {
        [FieldOffset(0x00)] public AuraEffectParameters aura;
        [FieldOffset(0xE0)] public EffectParameters effect;
        [FieldOffset(0xE8)] public WeatherParameters weather;
    }

}