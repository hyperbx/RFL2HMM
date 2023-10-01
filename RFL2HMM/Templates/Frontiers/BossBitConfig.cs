using System.Numerics;
using System.Runtime.InteropServices;

public class BossBitConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct LargeBitLaserParameter
    {
        [FieldOffset(0x00)] public float rangeMin;
        [FieldOffset(0x04)] public float rangeMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct SmallBitLaserBulletParameter
    {
        [FieldOffset(0x00)] public float bulletRadius;
        [FieldOffset(0x04)] public float bulletMoveLimitDistance;
        [FieldOffset(0x08)] public float bitHp;
        [FieldOffset(0x0C)] public float rotDamageAngleSpeed;
        [FieldOffset(0x10)] public float rotDamageSize;
        [FieldOffset(0x14)] public float hitDamageNotAttackTime;
        [FieldOffset(0x18)] public float blowoffSpeed;
        [FieldOffset(0x1C)] public float outOfControlTime;
        [FieldOffset(0x20)] public float keepVelocity;
        [FieldOffset(0x24)] public float muzzleEffectMinTime;
        [FieldOffset(0x28)] public byte dropRingNum;
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

    public enum BulletType : byte
    {
        Normal = 0,
        Normal2 = 1,
        Laser = 2,
        Homing = 3
    }

    public enum RotType : byte
    {
        Rotation = 0,
        RoundTrip = 1,
        Aim = 2,
        Fix = 3
    }

    public enum CameraId : byte
    {
        Invalid = 0,
        Rotate = 1,
        Trace = 2,
        Sub = 3,
        Num = 4
    }

    public enum FormationId : byte
    {
        Default = 0,
        FanShaped = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x64)]
    public struct SmallBitAttackPatternParameter
    {
        [FieldOffset(0x00)] public bool isParry;
        [FieldOffset(0x04)] public float time;
        [FieldOffset(0x08)] public float angleSpeed;
        [FieldOffset(0x0C)] public BulletType bulletType;
        [FieldOffset(0x0D)] public RotType rotType;
        [FieldOffset(0x10)] public float rotAngle;
        [FieldOffset(0x14)] public float phaseRotTime;
        [FieldOffset(0x18)] public uint shootNum;
        [FieldOffset(0x1C)] public float shootSpeed;
        [FieldOffset(0x20)] public float addShootSpeed;
        [FieldOffset(0x24)] public float shootAccel;
        [FieldOffset(0x28)] public float shootAccelMax;
        [FieldOffset(0x2C)] public float shootAccelDelay;
        [FieldOffset(0x30)] public byte wayNum;
        [FieldOffset(0x34)] public float wayAngle;
        [FieldOffset(0x38)] public float shootTime;
        [FieldOffset(0x3C)] public float phaseShootTime;
        [FieldOffset(0x40)] public uint periodShootCool;
        [FieldOffset(0x44)] public float periodShootCoolTime;
        [FieldOffset(0x48)] public float homingAccuracy;
        [FieldOffset(0x4C)] public float homingDelay;
        [FieldOffset(0x50)] public float homingLimitAngle;
        [FieldOffset(0x54)] public bool isHomingLowFly;
        [FieldOffset(0x55)] public CameraId overlookingId;
        [FieldOffset(0x58)] public float waveRotationSpeed;
        [FieldOffset(0x5C)] public float flyMoveSpeed;
        [FieldOffset(0x60)] public FormationId formationId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x78)]
    public struct SmallBitSetPatternParameter
    {
        [FieldOffset(0x00)] public UnmanagedString text;
        [FieldOffset(0x10)] public SmallBitAttackPatternParameter param;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct SmallBitFormationFanShaped
    {
        [FieldOffset(0x00)] public float distance;
        [FieldOffset(0x04)] public float height;
        [FieldOffset(0x08)] public float radius;
        [FieldOffset(0x0C)] public float angleMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct SmallBitFormationParameter
    {
        [FieldOffset(0x00)] public float changeTime;
        [FieldOffset(0x04)] public float changeDelay;
        [FieldOffset(0x08)] public float changeOffsetHeight;
        [FieldOffset(0x0C)] public SmallBitFormationFanShaped fanShaped;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1E58)]
    public struct BossBitConfig
    {
        [FieldOffset(0x00)] public LargeBitLaserParameter largeBitLaserParam;
        [FieldOffset(0x08)] public SmallBitLaserBulletParameter smallBitLaserParam;
        [FieldOffset(0x38)] public SmallBitSetPatternParameter smallBitPatternDatas__arr0;
        [FieldOffset(0xB0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr1;
        [FieldOffset(0x128)] public SmallBitSetPatternParameter smallBitPatternDatas__arr2;
        [FieldOffset(0x1A0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr3;
        [FieldOffset(0x218)] public SmallBitSetPatternParameter smallBitPatternDatas__arr4;
        [FieldOffset(0x290)] public SmallBitSetPatternParameter smallBitPatternDatas__arr5;
        [FieldOffset(0x308)] public SmallBitSetPatternParameter smallBitPatternDatas__arr6;
        [FieldOffset(0x380)] public SmallBitSetPatternParameter smallBitPatternDatas__arr7;
        [FieldOffset(0x3F8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr8;
        [FieldOffset(0x470)] public SmallBitSetPatternParameter smallBitPatternDatas__arr9;
        [FieldOffset(0x4E8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr10;
        [FieldOffset(0x560)] public SmallBitSetPatternParameter smallBitPatternDatas__arr11;
        [FieldOffset(0x5D8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr12;
        [FieldOffset(0x650)] public SmallBitSetPatternParameter smallBitPatternDatas__arr13;
        [FieldOffset(0x6C8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr14;
        [FieldOffset(0x740)] public SmallBitSetPatternParameter smallBitPatternDatas__arr15;
        [FieldOffset(0x7B8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr16;
        [FieldOffset(0x830)] public SmallBitSetPatternParameter smallBitPatternDatas__arr17;
        [FieldOffset(0x8A8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr18;
        [FieldOffset(0x920)] public SmallBitSetPatternParameter smallBitPatternDatas__arr19;
        [FieldOffset(0x998)] public SmallBitSetPatternParameter smallBitPatternDatas__arr20;
        [FieldOffset(0xA10)] public SmallBitSetPatternParameter smallBitPatternDatas__arr21;
        [FieldOffset(0xA88)] public SmallBitSetPatternParameter smallBitPatternDatas__arr22;
        [FieldOffset(0xB00)] public SmallBitSetPatternParameter smallBitPatternDatas__arr23;
        [FieldOffset(0xB78)] public SmallBitSetPatternParameter smallBitPatternDatas__arr24;
        [FieldOffset(0xBF0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr25;
        [FieldOffset(0xC68)] public SmallBitSetPatternParameter smallBitPatternDatas__arr26;
        [FieldOffset(0xCE0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr27;
        [FieldOffset(0xD58)] public SmallBitSetPatternParameter smallBitPatternDatas__arr28;
        [FieldOffset(0xDD0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr29;
        [FieldOffset(0xE48)] public SmallBitSetPatternParameter smallBitPatternDatas__arr30;
        [FieldOffset(0xEC0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr31;
        [FieldOffset(0xF38)] public SmallBitSetPatternParameter smallBitPatternDatas__arr32;
        [FieldOffset(0xFB0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr33;
        [FieldOffset(0x1028)] public SmallBitSetPatternParameter smallBitPatternDatas__arr34;
        [FieldOffset(0x10A0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr35;
        [FieldOffset(0x1118)] public SmallBitSetPatternParameter smallBitPatternDatas__arr36;
        [FieldOffset(0x1190)] public SmallBitSetPatternParameter smallBitPatternDatas__arr37;
        [FieldOffset(0x1208)] public SmallBitSetPatternParameter smallBitPatternDatas__arr38;
        [FieldOffset(0x1280)] public SmallBitSetPatternParameter smallBitPatternDatas__arr39;
        [FieldOffset(0x12F8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr40;
        [FieldOffset(0x1370)] public SmallBitSetPatternParameter smallBitPatternDatas__arr41;
        [FieldOffset(0x13E8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr42;
        [FieldOffset(0x1460)] public SmallBitSetPatternParameter smallBitPatternDatas__arr43;
        [FieldOffset(0x14D8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr44;
        [FieldOffset(0x1550)] public SmallBitSetPatternParameter smallBitPatternDatas__arr45;
        [FieldOffset(0x15C8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr46;
        [FieldOffset(0x1640)] public SmallBitSetPatternParameter smallBitPatternDatas__arr47;
        [FieldOffset(0x16B8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr48;
        [FieldOffset(0x1730)] public SmallBitSetPatternParameter smallBitPatternDatas__arr49;
        [FieldOffset(0x17A8)] public SmallBitSetPatternParameter smallBitPatternDatas__arr50;
        [FieldOffset(0x1820)] public SmallBitSetPatternParameter smallBitPatternDatas__arr51;
        [FieldOffset(0x1898)] public SmallBitSetPatternParameter smallBitPatternDatas__arr52;
        [FieldOffset(0x1910)] public SmallBitSetPatternParameter smallBitPatternDatas__arr53;
        [FieldOffset(0x1988)] public SmallBitSetPatternParameter smallBitPatternDatas__arr54;
        [FieldOffset(0x1A00)] public SmallBitSetPatternParameter smallBitPatternDatas__arr55;
        [FieldOffset(0x1A78)] public SmallBitSetPatternParameter smallBitPatternDatas__arr56;
        [FieldOffset(0x1AF0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr57;
        [FieldOffset(0x1B68)] public SmallBitSetPatternParameter smallBitPatternDatas__arr58;
        [FieldOffset(0x1BE0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr59;
        [FieldOffset(0x1C58)] public SmallBitSetPatternParameter smallBitPatternDatas__arr60;
        [FieldOffset(0x1CD0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr61;
        [FieldOffset(0x1D48)] public SmallBitSetPatternParameter smallBitPatternDatas__arr62;
        [FieldOffset(0x1DC0)] public SmallBitSetPatternParameter smallBitPatternDatas__arr63;
        [FieldOffset(0x1E38)] public SmallBitFormationParameter smallBitFormation;
    }

}