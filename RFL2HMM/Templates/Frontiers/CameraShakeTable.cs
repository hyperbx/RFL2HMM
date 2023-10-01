using System.Numerics;
using System.Runtime.InteropServices;

public class CameraShakeTableClass
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

    public enum ShakeType : byte
    {
        Directional = 0,
        WorldY = 1,
        Random = 2,
        DirectionalStaticUp = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct CameraShakeRecord
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public ShakeType type;
        [FieldOffset(0x14)] public float zRot;
        [FieldOffset(0x18)] public float duration;
        [FieldOffset(0x1C)] public float frequency;
        [FieldOffset(0x20)] public float amplitude;
        [FieldOffset(0x24)] public float timeAttenuationRate;
        [FieldOffset(0x28)] public bool enableDistanceAttenuation;
        [FieldOffset(0x2C)] public float attenuationDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC00)]
    public struct CameraShakeTable
    {
        [FieldOffset(0x00)] public CameraShakeRecord records__arr0;
        [FieldOffset(0x30)] public CameraShakeRecord records__arr1;
        [FieldOffset(0x60)] public CameraShakeRecord records__arr2;
        [FieldOffset(0x90)] public CameraShakeRecord records__arr3;
        [FieldOffset(0xC0)] public CameraShakeRecord records__arr4;
        [FieldOffset(0xF0)] public CameraShakeRecord records__arr5;
        [FieldOffset(0x120)] public CameraShakeRecord records__arr6;
        [FieldOffset(0x150)] public CameraShakeRecord records__arr7;
        [FieldOffset(0x180)] public CameraShakeRecord records__arr8;
        [FieldOffset(0x1B0)] public CameraShakeRecord records__arr9;
        [FieldOffset(0x1E0)] public CameraShakeRecord records__arr10;
        [FieldOffset(0x210)] public CameraShakeRecord records__arr11;
        [FieldOffset(0x240)] public CameraShakeRecord records__arr12;
        [FieldOffset(0x270)] public CameraShakeRecord records__arr13;
        [FieldOffset(0x2A0)] public CameraShakeRecord records__arr14;
        [FieldOffset(0x2D0)] public CameraShakeRecord records__arr15;
        [FieldOffset(0x300)] public CameraShakeRecord records__arr16;
        [FieldOffset(0x330)] public CameraShakeRecord records__arr17;
        [FieldOffset(0x360)] public CameraShakeRecord records__arr18;
        [FieldOffset(0x390)] public CameraShakeRecord records__arr19;
        [FieldOffset(0x3C0)] public CameraShakeRecord records__arr20;
        [FieldOffset(0x3F0)] public CameraShakeRecord records__arr21;
        [FieldOffset(0x420)] public CameraShakeRecord records__arr22;
        [FieldOffset(0x450)] public CameraShakeRecord records__arr23;
        [FieldOffset(0x480)] public CameraShakeRecord records__arr24;
        [FieldOffset(0x4B0)] public CameraShakeRecord records__arr25;
        [FieldOffset(0x4E0)] public CameraShakeRecord records__arr26;
        [FieldOffset(0x510)] public CameraShakeRecord records__arr27;
        [FieldOffset(0x540)] public CameraShakeRecord records__arr28;
        [FieldOffset(0x570)] public CameraShakeRecord records__arr29;
        [FieldOffset(0x5A0)] public CameraShakeRecord records__arr30;
        [FieldOffset(0x5D0)] public CameraShakeRecord records__arr31;
        [FieldOffset(0x600)] public CameraShakeRecord records__arr32;
        [FieldOffset(0x630)] public CameraShakeRecord records__arr33;
        [FieldOffset(0x660)] public CameraShakeRecord records__arr34;
        [FieldOffset(0x690)] public CameraShakeRecord records__arr35;
        [FieldOffset(0x6C0)] public CameraShakeRecord records__arr36;
        [FieldOffset(0x6F0)] public CameraShakeRecord records__arr37;
        [FieldOffset(0x720)] public CameraShakeRecord records__arr38;
        [FieldOffset(0x750)] public CameraShakeRecord records__arr39;
        [FieldOffset(0x780)] public CameraShakeRecord records__arr40;
        [FieldOffset(0x7B0)] public CameraShakeRecord records__arr41;
        [FieldOffset(0x7E0)] public CameraShakeRecord records__arr42;
        [FieldOffset(0x810)] public CameraShakeRecord records__arr43;
        [FieldOffset(0x840)] public CameraShakeRecord records__arr44;
        [FieldOffset(0x870)] public CameraShakeRecord records__arr45;
        [FieldOffset(0x8A0)] public CameraShakeRecord records__arr46;
        [FieldOffset(0x8D0)] public CameraShakeRecord records__arr47;
        [FieldOffset(0x900)] public CameraShakeRecord records__arr48;
        [FieldOffset(0x930)] public CameraShakeRecord records__arr49;
        [FieldOffset(0x960)] public CameraShakeRecord records__arr50;
        [FieldOffset(0x990)] public CameraShakeRecord records__arr51;
        [FieldOffset(0x9C0)] public CameraShakeRecord records__arr52;
        [FieldOffset(0x9F0)] public CameraShakeRecord records__arr53;
        [FieldOffset(0xA20)] public CameraShakeRecord records__arr54;
        [FieldOffset(0xA50)] public CameraShakeRecord records__arr55;
        [FieldOffset(0xA80)] public CameraShakeRecord records__arr56;
        [FieldOffset(0xAB0)] public CameraShakeRecord records__arr57;
        [FieldOffset(0xAE0)] public CameraShakeRecord records__arr58;
        [FieldOffset(0xB10)] public CameraShakeRecord records__arr59;
        [FieldOffset(0xB40)] public CameraShakeRecord records__arr60;
        [FieldOffset(0xB70)] public CameraShakeRecord records__arr61;
        [FieldOffset(0xBA0)] public CameraShakeRecord records__arr62;
        [FieldOffset(0xBD0)] public CameraShakeRecord records__arr63;
    }

}