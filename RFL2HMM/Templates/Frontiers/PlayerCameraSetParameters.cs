using System.Numerics;
using System.Runtime.InteropServices;

public class PlayerCameraSetParametersClass
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

    public enum Priority : byte
    {
        Default = 0,
        High = 1
    }

    public enum CameraType : byte
    {
        None = 0,
        Fixed = 1,
        Offset = 2,
        Follow = 3,
        Pan = 4,
        StaticPan = 5,
        PanUpByFront = 6
    }

    public enum CameraCoordType : byte
    {
        Orthgonal = 0,
        Spherical = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct PlayerCameraParameter
    {
        [FieldOffset(0x00)] public CameraType type;
        [FieldOffset(0x04)] public float time;
        [FieldOffset(0x08)] public float easeinTime;
        [FieldOffset(0x0C)] public CameraCoordType lookAtCoord;
        [FieldOffset(0x10)] public Vector3 localLookAtOffset;
        [FieldOffset(0x20)] public Vector3 worldLookAtOffset;
        [FieldOffset(0x30)] public CameraCoordType eyeCoord;
        [FieldOffset(0x40)] public Vector3 localEyeOffset;
        [FieldOffset(0x50)] public Vector3 worldEyeOffset;
        [FieldOffset(0x60)] public float roll;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3A0)]
    public struct PlayerCameraSetParameter
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public float easeoutTime;
        [FieldOffset(0x14)] public Priority priority;
        [FieldOffset(0x20)] public PlayerCameraParameter param__arr0;
        [FieldOffset(0x90)] public PlayerCameraParameter param__arr1;
        [FieldOffset(0x100)] public PlayerCameraParameter param__arr2;
        [FieldOffset(0x170)] public PlayerCameraParameter param__arr3;
        [FieldOffset(0x1E0)] public PlayerCameraParameter param__arr4;
        [FieldOffset(0x250)] public PlayerCameraParameter param__arr5;
        [FieldOffset(0x2C0)] public PlayerCameraParameter param__arr6;
        [FieldOffset(0x330)] public PlayerCameraParameter param__arr7;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA320)]
    public struct PlayerCameraSetParameters
    {
        [FieldOffset(0x00)] public PlayerCameraSetParameter data__arr0;
        [FieldOffset(0x3A0)] public PlayerCameraSetParameter data__arr1;
        [FieldOffset(0x740)] public PlayerCameraSetParameter data__arr2;
        [FieldOffset(0xAE0)] public PlayerCameraSetParameter data__arr3;
        [FieldOffset(0xE80)] public PlayerCameraSetParameter data__arr4;
        [FieldOffset(0x1220)] public PlayerCameraSetParameter data__arr5;
        [FieldOffset(0x15C0)] public PlayerCameraSetParameter data__arr6;
        [FieldOffset(0x1960)] public PlayerCameraSetParameter data__arr7;
        [FieldOffset(0x1D00)] public PlayerCameraSetParameter data__arr8;
        [FieldOffset(0x20A0)] public PlayerCameraSetParameter data__arr9;
        [FieldOffset(0x2440)] public PlayerCameraSetParameter data__arr10;
        [FieldOffset(0x27E0)] public PlayerCameraSetParameter data__arr11;
        [FieldOffset(0x2B80)] public PlayerCameraSetParameter data__arr12;
        [FieldOffset(0x2F20)] public PlayerCameraSetParameter data__arr13;
        [FieldOffset(0x32C0)] public PlayerCameraSetParameter data__arr14;
        [FieldOffset(0x3660)] public PlayerCameraSetParameter data__arr15;
        [FieldOffset(0x3A00)] public PlayerCameraSetParameter data__arr16;
        [FieldOffset(0x3DA0)] public PlayerCameraSetParameter data__arr17;
        [FieldOffset(0x4140)] public PlayerCameraSetParameter data__arr18;
        [FieldOffset(0x44E0)] public PlayerCameraSetParameter data__arr19;
        [FieldOffset(0x4880)] public PlayerCameraSetParameter data__arr20;
        [FieldOffset(0x4C20)] public PlayerCameraSetParameter data__arr21;
        [FieldOffset(0x4FC0)] public PlayerCameraSetParameter data__arr22;
        [FieldOffset(0x5360)] public PlayerCameraSetParameter data__arr23;
        [FieldOffset(0x5700)] public PlayerCameraSetParameter data__arr24;
        [FieldOffset(0x5AA0)] public PlayerCameraSetParameter data__arr25;
        [FieldOffset(0x5E40)] public PlayerCameraSetParameter data__arr26;
        [FieldOffset(0x61E0)] public PlayerCameraSetParameter data__arr27;
        [FieldOffset(0x6580)] public PlayerCameraSetParameter data__arr28;
        [FieldOffset(0x6920)] public PlayerCameraSetParameter data__arr29;
        [FieldOffset(0x6CC0)] public PlayerCameraSetParameter data__arr30;
        [FieldOffset(0x7060)] public PlayerCameraSetParameter data__arr31;
        [FieldOffset(0x7400)] public PlayerCameraSetParameter data__arr32;
        [FieldOffset(0x77A0)] public PlayerCameraSetParameter data__arr33;
        [FieldOffset(0x7B40)] public PlayerCameraSetParameter data__arr34;
        [FieldOffset(0x7EE0)] public PlayerCameraSetParameter data__arr35;
        [FieldOffset(0x8280)] public PlayerCameraSetParameter data__arr36;
        [FieldOffset(0x8620)] public PlayerCameraSetParameter data__arr37;
        [FieldOffset(0x89C0)] public PlayerCameraSetParameter data__arr38;
        [FieldOffset(0x8D60)] public PlayerCameraSetParameter data__arr39;
        [FieldOffset(0x9100)] public PlayerCameraSetParameter data__arr40;
        [FieldOffset(0x94A0)] public PlayerCameraSetParameter data__arr41;
        [FieldOffset(0x9840)] public PlayerCameraSetParameter data__arr42;
        [FieldOffset(0x9BE0)] public PlayerCameraSetParameter data__arr43;
        [FieldOffset(0x9F80)] public PlayerCameraSetParameter data__arr44;
    }

}