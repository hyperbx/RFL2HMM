Library "GravityFieldOutsideHalfCylinderBoxSplineSetupParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x03)]
    public struct GravityFieldSetupParameter
    {
        [FieldOffset(0x00)] public sbyte prio;
        [FieldOffset(0x01)] public bool defaultON;
        [FieldOffset(0x02)] public bool _fixed;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct GravityFieldCylinderSplineSetupParameter
    {
        [FieldOffset(0)] public GravityFieldSetupParameter gravityFieldSetupParameter;
        [FieldOffset(0x04)] public float radius;
        [FieldOffset(0x08)] public UnmanagedString pathName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct GravityFieldOutsideCylinderSplineSetupParameter
    {
        [FieldOffset(0)]  public GravityFieldCylinderSplineSetupParameter gravityFieldCylinderSplineSetupParameter;
        [FieldOffset(0x18)] public float innerRadius;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct GravityFieldOutsideHalfCylinderBoxSplineSetupParameter
    {
        [FieldOffset(0)]  public GravityFieldOutsideCylinderSplineSetupParameter gravityFieldOutsideCylinderSplineSetupParameter;
        [FieldOffset(0x20)] public Vector3 extents;
    }

}