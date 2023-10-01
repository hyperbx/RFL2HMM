using System.Numerics;
using System.Runtime.InteropServices;

public class OcclusionCapsuleListClass
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

    public enum VolumeType : sbyte
    {
        VOLUME_SPHERE = 0,
        VOLUME_CAPSULE = 1
    }

    public enum LODLevel : sbyte
    {
        LOD_HIGH = 0,
        LOD_MIDDLE = 1,
        LOD_LOW = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct CapsuleParam
    {
        [FieldOffset(0x00)] public UnmanagedString type;
        [FieldOffset(0x10)] public VolumeType volume;
        [FieldOffset(0x14)] public int priority;
        [FieldOffset(0x20)] public Vector3 translation;
        [FieldOffset(0x30)] public Vector3 rotation;
        [FieldOffset(0x40)] public Vector3 scale;
        [FieldOffset(0x50)] public Vector3 rate;
        [FieldOffset(0x60)] public float radius;
        [FieldOffset(0x64)] public LODLevel lod;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C00)]
    public struct OcclusionCapsuleList
    {
        [FieldOffset(0x00)] public CapsuleParam capsules__arr0;
        [FieldOffset(0x70)] public CapsuleParam capsules__arr1;
        [FieldOffset(0xE0)] public CapsuleParam capsules__arr2;
        [FieldOffset(0x150)] public CapsuleParam capsules__arr3;
        [FieldOffset(0x1C0)] public CapsuleParam capsules__arr4;
        [FieldOffset(0x230)] public CapsuleParam capsules__arr5;
        [FieldOffset(0x2A0)] public CapsuleParam capsules__arr6;
        [FieldOffset(0x310)] public CapsuleParam capsules__arr7;
        [FieldOffset(0x380)] public CapsuleParam capsules__arr8;
        [FieldOffset(0x3F0)] public CapsuleParam capsules__arr9;
        [FieldOffset(0x460)] public CapsuleParam capsules__arr10;
        [FieldOffset(0x4D0)] public CapsuleParam capsules__arr11;
        [FieldOffset(0x540)] public CapsuleParam capsules__arr12;
        [FieldOffset(0x5B0)] public CapsuleParam capsules__arr13;
        [FieldOffset(0x620)] public CapsuleParam capsules__arr14;
        [FieldOffset(0x690)] public CapsuleParam capsules__arr15;
        [FieldOffset(0x700)] public CapsuleParam capsules__arr16;
        [FieldOffset(0x770)] public CapsuleParam capsules__arr17;
        [FieldOffset(0x7E0)] public CapsuleParam capsules__arr18;
        [FieldOffset(0x850)] public CapsuleParam capsules__arr19;
        [FieldOffset(0x8C0)] public CapsuleParam capsules__arr20;
        [FieldOffset(0x930)] public CapsuleParam capsules__arr21;
        [FieldOffset(0x9A0)] public CapsuleParam capsules__arr22;
        [FieldOffset(0xA10)] public CapsuleParam capsules__arr23;
        [FieldOffset(0xA80)] public CapsuleParam capsules__arr24;
        [FieldOffset(0xAF0)] public CapsuleParam capsules__arr25;
        [FieldOffset(0xB60)] public CapsuleParam capsules__arr26;
        [FieldOffset(0xBD0)] public CapsuleParam capsules__arr27;
        [FieldOffset(0xC40)] public CapsuleParam capsules__arr28;
        [FieldOffset(0xCB0)] public CapsuleParam capsules__arr29;
        [FieldOffset(0xD20)] public CapsuleParam capsules__arr30;
        [FieldOffset(0xD90)] public CapsuleParam capsules__arr31;
        [FieldOffset(0xE00)] public CapsuleParam capsules__arr32;
        [FieldOffset(0xE70)] public CapsuleParam capsules__arr33;
        [FieldOffset(0xEE0)] public CapsuleParam capsules__arr34;
        [FieldOffset(0xF50)] public CapsuleParam capsules__arr35;
        [FieldOffset(0xFC0)] public CapsuleParam capsules__arr36;
        [FieldOffset(0x1030)] public CapsuleParam capsules__arr37;
        [FieldOffset(0x10A0)] public CapsuleParam capsules__arr38;
        [FieldOffset(0x1110)] public CapsuleParam capsules__arr39;
        [FieldOffset(0x1180)] public CapsuleParam capsules__arr40;
        [FieldOffset(0x11F0)] public CapsuleParam capsules__arr41;
        [FieldOffset(0x1260)] public CapsuleParam capsules__arr42;
        [FieldOffset(0x12D0)] public CapsuleParam capsules__arr43;
        [FieldOffset(0x1340)] public CapsuleParam capsules__arr44;
        [FieldOffset(0x13B0)] public CapsuleParam capsules__arr45;
        [FieldOffset(0x1420)] public CapsuleParam capsules__arr46;
        [FieldOffset(0x1490)] public CapsuleParam capsules__arr47;
        [FieldOffset(0x1500)] public CapsuleParam capsules__arr48;
        [FieldOffset(0x1570)] public CapsuleParam capsules__arr49;
        [FieldOffset(0x15E0)] public CapsuleParam capsules__arr50;
        [FieldOffset(0x1650)] public CapsuleParam capsules__arr51;
        [FieldOffset(0x16C0)] public CapsuleParam capsules__arr52;
        [FieldOffset(0x1730)] public CapsuleParam capsules__arr53;
        [FieldOffset(0x17A0)] public CapsuleParam capsules__arr54;
        [FieldOffset(0x1810)] public CapsuleParam capsules__arr55;
        [FieldOffset(0x1880)] public CapsuleParam capsules__arr56;
        [FieldOffset(0x18F0)] public CapsuleParam capsules__arr57;
        [FieldOffset(0x1960)] public CapsuleParam capsules__arr58;
        [FieldOffset(0x19D0)] public CapsuleParam capsules__arr59;
        [FieldOffset(0x1A40)] public CapsuleParam capsules__arr60;
        [FieldOffset(0x1AB0)] public CapsuleParam capsules__arr61;
        [FieldOffset(0x1B20)] public CapsuleParam capsules__arr62;
        [FieldOffset(0x1B90)] public CapsuleParam capsules__arr63;
    }

}