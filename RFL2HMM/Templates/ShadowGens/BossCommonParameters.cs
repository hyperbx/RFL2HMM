Library "BossCommonParameters"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct BossResourceInfo
    {
        [FieldOffset(0x00)] public UnmanagedString modelName;
        [FieldOffset(0x10)] public UnmanagedString animName;
        [FieldOffset(0x20)] public Vector3 scale;
        [FieldOffset(0x30)] public UnmanagedString stageName;
        [FieldOffset(0x40)] public Vector3 stagePos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct HoldPoint
    {
        [FieldOffset(0x00)] public UnmanagedString nodeName;
        [FieldOffset(0x10)] public Vector3 offset;
        [FieldOffset(0x20)] public Vector3 rot;
        [FieldOffset(0x30)] public UnmanagedString tagName;
        [FieldOffset(0x40)] public int nextPointId;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2800)]
    public struct HoldPointParameter
    {
        [FieldOffset(0x00)] public HoldPoint holdPoints__arr0;
        [FieldOffset(0x50)] public HoldPoint holdPoints__arr1;
        [FieldOffset(0xA0)] public HoldPoint holdPoints__arr2;
        [FieldOffset(0xF0)] public HoldPoint holdPoints__arr3;
        [FieldOffset(0x140)] public HoldPoint holdPoints__arr4;
        [FieldOffset(0x190)] public HoldPoint holdPoints__arr5;
        [FieldOffset(0x1E0)] public HoldPoint holdPoints__arr6;
        [FieldOffset(0x230)] public HoldPoint holdPoints__arr7;
        [FieldOffset(0x280)] public HoldPoint holdPoints__arr8;
        [FieldOffset(0x2D0)] public HoldPoint holdPoints__arr9;
        [FieldOffset(0x320)] public HoldPoint holdPoints__arr10;
        [FieldOffset(0x370)] public HoldPoint holdPoints__arr11;
        [FieldOffset(0x3C0)] public HoldPoint holdPoints__arr12;
        [FieldOffset(0x410)] public HoldPoint holdPoints__arr13;
        [FieldOffset(0x460)] public HoldPoint holdPoints__arr14;
        [FieldOffset(0x4B0)] public HoldPoint holdPoints__arr15;
        [FieldOffset(0x500)] public HoldPoint holdPoints__arr16;
        [FieldOffset(0x550)] public HoldPoint holdPoints__arr17;
        [FieldOffset(0x5A0)] public HoldPoint holdPoints__arr18;
        [FieldOffset(0x5F0)] public HoldPoint holdPoints__arr19;
        [FieldOffset(0x640)] public HoldPoint holdPoints__arr20;
        [FieldOffset(0x690)] public HoldPoint holdPoints__arr21;
        [FieldOffset(0x6E0)] public HoldPoint holdPoints__arr22;
        [FieldOffset(0x730)] public HoldPoint holdPoints__arr23;
        [FieldOffset(0x780)] public HoldPoint holdPoints__arr24;
        [FieldOffset(0x7D0)] public HoldPoint holdPoints__arr25;
        [FieldOffset(0x820)] public HoldPoint holdPoints__arr26;
        [FieldOffset(0x870)] public HoldPoint holdPoints__arr27;
        [FieldOffset(0x8C0)] public HoldPoint holdPoints__arr28;
        [FieldOffset(0x910)] public HoldPoint holdPoints__arr29;
        [FieldOffset(0x960)] public HoldPoint holdPoints__arr30;
        [FieldOffset(0x9B0)] public HoldPoint holdPoints__arr31;
        [FieldOffset(0xA00)] public HoldPoint holdPoints__arr32;
        [FieldOffset(0xA50)] public HoldPoint holdPoints__arr33;
        [FieldOffset(0xAA0)] public HoldPoint holdPoints__arr34;
        [FieldOffset(0xAF0)] public HoldPoint holdPoints__arr35;
        [FieldOffset(0xB40)] public HoldPoint holdPoints__arr36;
        [FieldOffset(0xB90)] public HoldPoint holdPoints__arr37;
        [FieldOffset(0xBE0)] public HoldPoint holdPoints__arr38;
        [FieldOffset(0xC30)] public HoldPoint holdPoints__arr39;
        [FieldOffset(0xC80)] public HoldPoint holdPoints__arr40;
        [FieldOffset(0xCD0)] public HoldPoint holdPoints__arr41;
        [FieldOffset(0xD20)] public HoldPoint holdPoints__arr42;
        [FieldOffset(0xD70)] public HoldPoint holdPoints__arr43;
        [FieldOffset(0xDC0)] public HoldPoint holdPoints__arr44;
        [FieldOffset(0xE10)] public HoldPoint holdPoints__arr45;
        [FieldOffset(0xE60)] public HoldPoint holdPoints__arr46;
        [FieldOffset(0xEB0)] public HoldPoint holdPoints__arr47;
        [FieldOffset(0xF00)] public HoldPoint holdPoints__arr48;
        [FieldOffset(0xF50)] public HoldPoint holdPoints__arr49;
        [FieldOffset(0xFA0)] public HoldPoint holdPoints__arr50;
        [FieldOffset(0xFF0)] public HoldPoint holdPoints__arr51;
        [FieldOffset(0x1040)] public HoldPoint holdPoints__arr52;
        [FieldOffset(0x1090)] public HoldPoint holdPoints__arr53;
        [FieldOffset(0x10E0)] public HoldPoint holdPoints__arr54;
        [FieldOffset(0x1130)] public HoldPoint holdPoints__arr55;
        [FieldOffset(0x1180)] public HoldPoint holdPoints__arr56;
        [FieldOffset(0x11D0)] public HoldPoint holdPoints__arr57;
        [FieldOffset(0x1220)] public HoldPoint holdPoints__arr58;
        [FieldOffset(0x1270)] public HoldPoint holdPoints__arr59;
        [FieldOffset(0x12C0)] public HoldPoint holdPoints__arr60;
        [FieldOffset(0x1310)] public HoldPoint holdPoints__arr61;
        [FieldOffset(0x1360)] public HoldPoint holdPoints__arr62;
        [FieldOffset(0x13B0)] public HoldPoint holdPoints__arr63;
        [FieldOffset(0x1400)] public HoldPoint holdPoints__arr64;
        [FieldOffset(0x1450)] public HoldPoint holdPoints__arr65;
        [FieldOffset(0x14A0)] public HoldPoint holdPoints__arr66;
        [FieldOffset(0x14F0)] public HoldPoint holdPoints__arr67;
        [FieldOffset(0x1540)] public HoldPoint holdPoints__arr68;
        [FieldOffset(0x1590)] public HoldPoint holdPoints__arr69;
        [FieldOffset(0x15E0)] public HoldPoint holdPoints__arr70;
        [FieldOffset(0x1630)] public HoldPoint holdPoints__arr71;
        [FieldOffset(0x1680)] public HoldPoint holdPoints__arr72;
        [FieldOffset(0x16D0)] public HoldPoint holdPoints__arr73;
        [FieldOffset(0x1720)] public HoldPoint holdPoints__arr74;
        [FieldOffset(0x1770)] public HoldPoint holdPoints__arr75;
        [FieldOffset(0x17C0)] public HoldPoint holdPoints__arr76;
        [FieldOffset(0x1810)] public HoldPoint holdPoints__arr77;
        [FieldOffset(0x1860)] public HoldPoint holdPoints__arr78;
        [FieldOffset(0x18B0)] public HoldPoint holdPoints__arr79;
        [FieldOffset(0x1900)] public HoldPoint holdPoints__arr80;
        [FieldOffset(0x1950)] public HoldPoint holdPoints__arr81;
        [FieldOffset(0x19A0)] public HoldPoint holdPoints__arr82;
        [FieldOffset(0x19F0)] public HoldPoint holdPoints__arr83;
        [FieldOffset(0x1A40)] public HoldPoint holdPoints__arr84;
        [FieldOffset(0x1A90)] public HoldPoint holdPoints__arr85;
        [FieldOffset(0x1AE0)] public HoldPoint holdPoints__arr86;
        [FieldOffset(0x1B30)] public HoldPoint holdPoints__arr87;
        [FieldOffset(0x1B80)] public HoldPoint holdPoints__arr88;
        [FieldOffset(0x1BD0)] public HoldPoint holdPoints__arr89;
        [FieldOffset(0x1C20)] public HoldPoint holdPoints__arr90;
        [FieldOffset(0x1C70)] public HoldPoint holdPoints__arr91;
        [FieldOffset(0x1CC0)] public HoldPoint holdPoints__arr92;
        [FieldOffset(0x1D10)] public HoldPoint holdPoints__arr93;
        [FieldOffset(0x1D60)] public HoldPoint holdPoints__arr94;
        [FieldOffset(0x1DB0)] public HoldPoint holdPoints__arr95;
        [FieldOffset(0x1E00)] public HoldPoint holdPoints__arr96;
        [FieldOffset(0x1E50)] public HoldPoint holdPoints__arr97;
        [FieldOffset(0x1EA0)] public HoldPoint holdPoints__arr98;
        [FieldOffset(0x1EF0)] public HoldPoint holdPoints__arr99;
        [FieldOffset(0x1F40)] public HoldPoint holdPoints__arr100;
        [FieldOffset(0x1F90)] public HoldPoint holdPoints__arr101;
        [FieldOffset(0x1FE0)] public HoldPoint holdPoints__arr102;
        [FieldOffset(0x2030)] public HoldPoint holdPoints__arr103;
        [FieldOffset(0x2080)] public HoldPoint holdPoints__arr104;
        [FieldOffset(0x20D0)] public HoldPoint holdPoints__arr105;
        [FieldOffset(0x2120)] public HoldPoint holdPoints__arr106;
        [FieldOffset(0x2170)] public HoldPoint holdPoints__arr107;
        [FieldOffset(0x21C0)] public HoldPoint holdPoints__arr108;
        [FieldOffset(0x2210)] public HoldPoint holdPoints__arr109;
        [FieldOffset(0x2260)] public HoldPoint holdPoints__arr110;
        [FieldOffset(0x22B0)] public HoldPoint holdPoints__arr111;
        [FieldOffset(0x2300)] public HoldPoint holdPoints__arr112;
        [FieldOffset(0x2350)] public HoldPoint holdPoints__arr113;
        [FieldOffset(0x23A0)] public HoldPoint holdPoints__arr114;
        [FieldOffset(0x23F0)] public HoldPoint holdPoints__arr115;
        [FieldOffset(0x2440)] public HoldPoint holdPoints__arr116;
        [FieldOffset(0x2490)] public HoldPoint holdPoints__arr117;
        [FieldOffset(0x24E0)] public HoldPoint holdPoints__arr118;
        [FieldOffset(0x2530)] public HoldPoint holdPoints__arr119;
        [FieldOffset(0x2580)] public HoldPoint holdPoints__arr120;
        [FieldOffset(0x25D0)] public HoldPoint holdPoints__arr121;
        [FieldOffset(0x2620)] public HoldPoint holdPoints__arr122;
        [FieldOffset(0x2670)] public HoldPoint holdPoints__arr123;
        [FieldOffset(0x26C0)] public HoldPoint holdPoints__arr124;
        [FieldOffset(0x2710)] public HoldPoint holdPoints__arr125;
        [FieldOffset(0x2760)] public HoldPoint holdPoints__arr126;
        [FieldOffset(0x27B0)] public HoldPoint holdPoints__arr127;
    }

    public enum Shape : sbyte
    {
        SHAPE_SPHERER = 0,
        SHAPE_BOX = 1,
        SHAPE_CYLINDER = 2,
        SHAPE_CAPCULE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct CollisionPart
    {
        [FieldOffset(0x00)] public UnmanagedString nodeName;
        [FieldOffset(0x10)] public Shape shape;
        [FieldOffset(0x11)] public bool isPhysics;
        [FieldOffset(0x20)] public Vector3 size;
        [FieldOffset(0x30)] public Vector3 offset;
        [FieldOffset(0x40)] public Vector3 rot;
        [FieldOffset(0x50)] public UnmanagedString tagName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC00)]
    public struct CollisionPartParameter
    {
        [FieldOffset(0x00)] public CollisionPart colParts__arr0;
        [FieldOffset(0x60)] public CollisionPart colParts__arr1;
        [FieldOffset(0xC0)] public CollisionPart colParts__arr2;
        [FieldOffset(0x120)] public CollisionPart colParts__arr3;
        [FieldOffset(0x180)] public CollisionPart colParts__arr4;
        [FieldOffset(0x1E0)] public CollisionPart colParts__arr5;
        [FieldOffset(0x240)] public CollisionPart colParts__arr6;
        [FieldOffset(0x2A0)] public CollisionPart colParts__arr7;
        [FieldOffset(0x300)] public CollisionPart colParts__arr8;
        [FieldOffset(0x360)] public CollisionPart colParts__arr9;
        [FieldOffset(0x3C0)] public CollisionPart colParts__arr10;
        [FieldOffset(0x420)] public CollisionPart colParts__arr11;
        [FieldOffset(0x480)] public CollisionPart colParts__arr12;
        [FieldOffset(0x4E0)] public CollisionPart colParts__arr13;
        [FieldOffset(0x540)] public CollisionPart colParts__arr14;
        [FieldOffset(0x5A0)] public CollisionPart colParts__arr15;
        [FieldOffset(0x600)] public CollisionPart colParts__arr16;
        [FieldOffset(0x660)] public CollisionPart colParts__arr17;
        [FieldOffset(0x6C0)] public CollisionPart colParts__arr18;
        [FieldOffset(0x720)] public CollisionPart colParts__arr19;
        [FieldOffset(0x780)] public CollisionPart colParts__arr20;
        [FieldOffset(0x7E0)] public CollisionPart colParts__arr21;
        [FieldOffset(0x840)] public CollisionPart colParts__arr22;
        [FieldOffset(0x8A0)] public CollisionPart colParts__arr23;
        [FieldOffset(0x900)] public CollisionPart colParts__arr24;
        [FieldOffset(0x960)] public CollisionPart colParts__arr25;
        [FieldOffset(0x9C0)] public CollisionPart colParts__arr26;
        [FieldOffset(0xA20)] public CollisionPart colParts__arr27;
        [FieldOffset(0xA80)] public CollisionPart colParts__arr28;
        [FieldOffset(0xAE0)] public CollisionPart colParts__arr29;
        [FieldOffset(0xB40)] public CollisionPart colParts__arr30;
        [FieldOffset(0xBA0)] public CollisionPart colParts__arr31;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3450)]
    public struct BossCommonParameters
    {
        [FieldOffset(0x00)] public BossResourceInfo resource;
        [FieldOffset(0x50)] public HoldPointParameter holdParam;
        [FieldOffset(0x2850)] public CollisionPartParameter colParam;
    }

}