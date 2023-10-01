using System.Numerics;
using System.Runtime.InteropServices;

public class SwayParamIndivisualClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct SwayParamNode
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float gravity;
        [FieldOffset(0x08)] public float resist;
        [FieldOffset(0x0C)] public float resist_decay;
        [FieldOffset(0x10)] public float recover;
        [FieldOffset(0x14)] public float recover_decay;
        [FieldOffset(0x18)] public float spring;
        [FieldOffset(0x1C)] public float radius;
        [FieldOffset(0x20)] public float transmit;
        [FieldOffset(0x24)] public float inertia;
        [FieldOffset(0x28)] public float angle_limit;
        [FieldOffset(0x30)] public UnmanagedString nodeName;
    }

    public enum CollisionType : sbyte
    {
        SWAY_COLLISTION_TYPE_NONE = 0,
        SWAY_COLLISTION_TYPE_SPHERE = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct SwayParamCollision
    {
        [FieldOffset(0x00)] public CollisionType type;
        [FieldOffset(0x10)] public Vector3 translation;
        [FieldOffset(0x20)] public Vector3 rotation;
        [FieldOffset(0x30)] public Vector3 scale;
        [FieldOffset(0x40)] public int modelPartId;
        [FieldOffset(0x48)] public UnmanagedString modelNodeName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x300)]
    public struct SwayParamNodeCollision
    {
        [FieldOffset(0x00)] public SwayParamCollision collisionParam__arr0;
        [FieldOffset(0x60)] public SwayParamCollision collisionParam__arr1;
        [FieldOffset(0xC0)] public SwayParamCollision collisionParam__arr2;
        [FieldOffset(0x120)] public SwayParamCollision collisionParam__arr3;
        [FieldOffset(0x180)] public SwayParamCollision collisionParam__arr4;
        [FieldOffset(0x1E0)] public SwayParamCollision collisionParam__arr5;
        [FieldOffset(0x240)] public SwayParamCollision collisionParam__arr6;
        [FieldOffset(0x2A0)] public SwayParamCollision collisionParam__arr7;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3410)]
    public struct SwayParamIndivisual
    {
        [FieldOffset(0x00)] public UnmanagedString idName;
        [FieldOffset(0x10)] public SwayParamNode nodeParam__arr0;
        [FieldOffset(0x50)] public SwayParamNode nodeParam__arr1;
        [FieldOffset(0x90)] public SwayParamNode nodeParam__arr2;
        [FieldOffset(0xD0)] public SwayParamNode nodeParam__arr3;
        [FieldOffset(0x110)] public SwayParamNode nodeParam__arr4;
        [FieldOffset(0x150)] public SwayParamNode nodeParam__arr5;
        [FieldOffset(0x190)] public SwayParamNode nodeParam__arr6;
        [FieldOffset(0x1D0)] public SwayParamNode nodeParam__arr7;
        [FieldOffset(0x210)] public SwayParamNode nodeParam__arr8;
        [FieldOffset(0x250)] public SwayParamNode nodeParam__arr9;
        [FieldOffset(0x290)] public SwayParamNode nodeParam__arr10;
        [FieldOffset(0x2D0)] public SwayParamNode nodeParam__arr11;
        [FieldOffset(0x310)] public SwayParamNode nodeParam__arr12;
        [FieldOffset(0x350)] public SwayParamNode nodeParam__arr13;
        [FieldOffset(0x390)] public SwayParamNode nodeParam__arr14;
        [FieldOffset(0x3D0)] public SwayParamNode nodeParam__arr15;
        [FieldOffset(0x410)] public SwayParamNodeCollision collisionParam__arr0;
        [FieldOffset(0x710)] public SwayParamNodeCollision collisionParam__arr1;
        [FieldOffset(0xA10)] public SwayParamNodeCollision collisionParam__arr2;
        [FieldOffset(0xD10)] public SwayParamNodeCollision collisionParam__arr3;
        [FieldOffset(0x1010)] public SwayParamNodeCollision collisionParam__arr4;
        [FieldOffset(0x1310)] public SwayParamNodeCollision collisionParam__arr5;
        [FieldOffset(0x1610)] public SwayParamNodeCollision collisionParam__arr6;
        [FieldOffset(0x1910)] public SwayParamNodeCollision collisionParam__arr7;
        [FieldOffset(0x1C10)] public SwayParamNodeCollision collisionParam__arr8;
        [FieldOffset(0x1F10)] public SwayParamNodeCollision collisionParam__arr9;
        [FieldOffset(0x2210)] public SwayParamNodeCollision collisionParam__arr10;
        [FieldOffset(0x2510)] public SwayParamNodeCollision collisionParam__arr11;
        [FieldOffset(0x2810)] public SwayParamNodeCollision collisionParam__arr12;
        [FieldOffset(0x2B10)] public SwayParamNodeCollision collisionParam__arr13;
        [FieldOffset(0x2E10)] public SwayParamNodeCollision collisionParam__arr14;
        [FieldOffset(0x3110)] public SwayParamNodeCollision collisionParam__arr15;
    }

}