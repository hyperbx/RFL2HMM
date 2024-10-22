Library "BossMetaloverloadConfig"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct BossMetaloverloadSwitchLayerData
    {
        [FieldOffset(0x00)] public UnmanagedString layerName;
        [FieldOffset(0x10)] public int phase;
        [FieldOffset(0x14)] public int lifeMin;
        [FieldOffset(0x18)] public int lifeMax;
        [FieldOffset(0x20)] public UnmanagedString tag;
        [FieldOffset(0x30)] public bool isChangePhaseEnable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x710)]
    public struct BossMetaloverloadCommonParam
    {
        [FieldOffset(0x00)] public float floatHeight;
        [FieldOffset(0x04)] public float upperRotSpeed;
        [FieldOffset(0x08)] public float upperResetRotSpeed;
        [FieldOffset(0x10)] public BossMetaloverloadSwitchLayerData switchLayers__arr0;
        [FieldOffset(0x48)] public BossMetaloverloadSwitchLayerData switchLayers__arr1;
        [FieldOffset(0x80)] public BossMetaloverloadSwitchLayerData switchLayers__arr2;
        [FieldOffset(0xB8)] public BossMetaloverloadSwitchLayerData switchLayers__arr3;
        [FieldOffset(0xF0)] public BossMetaloverloadSwitchLayerData switchLayers__arr4;
        [FieldOffset(0x128)] public BossMetaloverloadSwitchLayerData switchLayers__arr5;
        [FieldOffset(0x160)] public BossMetaloverloadSwitchLayerData switchLayers__arr6;
        [FieldOffset(0x198)] public BossMetaloverloadSwitchLayerData switchLayers__arr7;
        [FieldOffset(0x1D0)] public BossMetaloverloadSwitchLayerData switchLayers__arr8;
        [FieldOffset(0x208)] public BossMetaloverloadSwitchLayerData switchLayers__arr9;
        [FieldOffset(0x240)] public BossMetaloverloadSwitchLayerData switchLayers__arr10;
        [FieldOffset(0x278)] public BossMetaloverloadSwitchLayerData switchLayers__arr11;
        [FieldOffset(0x2B0)] public BossMetaloverloadSwitchLayerData switchLayers__arr12;
        [FieldOffset(0x2E8)] public BossMetaloverloadSwitchLayerData switchLayers__arr13;
        [FieldOffset(0x320)] public BossMetaloverloadSwitchLayerData switchLayers__arr14;
        [FieldOffset(0x358)] public BossMetaloverloadSwitchLayerData switchLayers__arr15;
        [FieldOffset(0x390)] public BossMetaloverloadSwitchLayerData switchLayers__arr16;
        [FieldOffset(0x3C8)] public BossMetaloverloadSwitchLayerData switchLayers__arr17;
        [FieldOffset(0x400)] public BossMetaloverloadSwitchLayerData switchLayers__arr18;
        [FieldOffset(0x438)] public BossMetaloverloadSwitchLayerData switchLayers__arr19;
        [FieldOffset(0x470)] public BossMetaloverloadSwitchLayerData switchLayers__arr20;
        [FieldOffset(0x4A8)] public BossMetaloverloadSwitchLayerData switchLayers__arr21;
        [FieldOffset(0x4E0)] public BossMetaloverloadSwitchLayerData switchLayers__arr22;
        [FieldOffset(0x518)] public BossMetaloverloadSwitchLayerData switchLayers__arr23;
        [FieldOffset(0x550)] public BossMetaloverloadSwitchLayerData switchLayers__arr24;
        [FieldOffset(0x588)] public BossMetaloverloadSwitchLayerData switchLayers__arr25;
        [FieldOffset(0x5C0)] public BossMetaloverloadSwitchLayerData switchLayers__arr26;
        [FieldOffset(0x5F8)] public BossMetaloverloadSwitchLayerData switchLayers__arr27;
        [FieldOffset(0x630)] public BossMetaloverloadSwitchLayerData switchLayers__arr28;
        [FieldOffset(0x668)] public BossMetaloverloadSwitchLayerData switchLayers__arr29;
        [FieldOffset(0x6A0)] public BossMetaloverloadSwitchLayerData switchLayers__arr30;
        [FieldOffset(0x6D8)] public BossMetaloverloadSwitchLayerData switchLayers__arr31;
    }

    public enum ActionType : sbyte
    {
        INVALID_ACTION = 0,
        PHASE2_IDLE = 1,
        PHASE2_ATTACK_MISSILE = 2,
        PHASE2_ATTACK_SHOT = 3,
        PHASE2_ATTACK_NORMAL_THROWING = 4,
        PHASE2_ATTACK_SP_THROWING = 5,
        PHASE2_RING_POP = 6,
        PHASE2_RING_POP_1 = 7,
        PHASE2_ATTACK_MINE = 8,
        PHASE2_ATTACK_MINE_1 = 9,
        PHASE2_ATTACK_MINE_2 = 10,
        PHASE2_ATTACK_MINE_3 = 11,
        PHASE2_ATTACK_MINE_4 = 12,
        PHASE2_ATTACK_THORNBALL = 13,
        ACTION_TYPE_NUM = 14
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossMetaloverloadActionData
    {
        [FieldOffset(0x00)] public ActionType actionType;
        [FieldOffset(0x04)] public float time;
        [FieldOffset(0x08)] public int successSkip;
        [FieldOffset(0x0C)] public int patternIndex;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x110C)]
    public struct BossMetaloverloadPhaseParam
    {
        [FieldOffset(0x00)] public int lifeCount;
        [FieldOffset(0x04)] public int healthPoint;
        [FieldOffset(0x08)] public int healthPointByHard;
        [FieldOffset(0x0C)] public BossMetaloverloadActionData actionTable1__arr0;
        [FieldOffset(0x1C)] public BossMetaloverloadActionData actionTable1__arr1;
        [FieldOffset(0x2C)] public BossMetaloverloadActionData actionTable1__arr2;
        [FieldOffset(0x3C)] public BossMetaloverloadActionData actionTable1__arr3;
        [FieldOffset(0x4C)] public BossMetaloverloadActionData actionTable1__arr4;
        [FieldOffset(0x5C)] public BossMetaloverloadActionData actionTable1__arr5;
        [FieldOffset(0x6C)] public BossMetaloverloadActionData actionTable1__arr6;
        [FieldOffset(0x7C)] public BossMetaloverloadActionData actionTable1__arr7;
        [FieldOffset(0x8C)] public BossMetaloverloadActionData actionTable1__arr8;
        [FieldOffset(0x9C)] public BossMetaloverloadActionData actionTable1__arr9;
        [FieldOffset(0xAC)] public BossMetaloverloadActionData actionTable1__arr10;
        [FieldOffset(0xBC)] public BossMetaloverloadActionData actionTable1__arr11;
        [FieldOffset(0xCC)] public BossMetaloverloadActionData actionTable1__arr12;
        [FieldOffset(0xDC)] public BossMetaloverloadActionData actionTable1__arr13;
        [FieldOffset(0xEC)] public BossMetaloverloadActionData actionTable1__arr14;
        [FieldOffset(0xFC)] public BossMetaloverloadActionData actionTable1__arr15;
        [FieldOffset(0x10C)] public BossMetaloverloadActionData actionTable1__arr16;
        [FieldOffset(0x11C)] public BossMetaloverloadActionData actionTable1__arr17;
        [FieldOffset(0x12C)] public BossMetaloverloadActionData actionTable1__arr18;
        [FieldOffset(0x13C)] public BossMetaloverloadActionData actionTable1__arr19;
        [FieldOffset(0x14C)] public BossMetaloverloadActionData actionTable1__arr20;
        [FieldOffset(0x15C)] public BossMetaloverloadActionData actionTable1__arr21;
        [FieldOffset(0x16C)] public BossMetaloverloadActionData actionTable1__arr22;
        [FieldOffset(0x17C)] public BossMetaloverloadActionData actionTable1__arr23;
        [FieldOffset(0x18C)] public BossMetaloverloadActionData actionTable1__arr24;
        [FieldOffset(0x19C)] public BossMetaloverloadActionData actionTable1__arr25;
        [FieldOffset(0x1AC)] public BossMetaloverloadActionData actionTable1__arr26;
        [FieldOffset(0x1BC)] public BossMetaloverloadActionData actionTable1__arr27;
        [FieldOffset(0x1CC)] public BossMetaloverloadActionData actionTable1__arr28;
        [FieldOffset(0x1DC)] public BossMetaloverloadActionData actionTable1__arr29;
        [FieldOffset(0x1EC)] public BossMetaloverloadActionData actionTable1__arr30;
        [FieldOffset(0x1FC)] public BossMetaloverloadActionData actionTable1__arr31;
        [FieldOffset(0x20C)] public BossMetaloverloadActionData actionTable1__arr32;
        [FieldOffset(0x21C)] public BossMetaloverloadActionData actionTable1__arr33;
        [FieldOffset(0x22C)] public BossMetaloverloadActionData actionTable2__arr0;
        [FieldOffset(0x23C)] public BossMetaloverloadActionData actionTable2__arr1;
        [FieldOffset(0x24C)] public BossMetaloverloadActionData actionTable2__arr2;
        [FieldOffset(0x25C)] public BossMetaloverloadActionData actionTable2__arr3;
        [FieldOffset(0x26C)] public BossMetaloverloadActionData actionTable2__arr4;
        [FieldOffset(0x27C)] public BossMetaloverloadActionData actionTable2__arr5;
        [FieldOffset(0x28C)] public BossMetaloverloadActionData actionTable2__arr6;
        [FieldOffset(0x29C)] public BossMetaloverloadActionData actionTable2__arr7;
        [FieldOffset(0x2AC)] public BossMetaloverloadActionData actionTable2__arr8;
        [FieldOffset(0x2BC)] public BossMetaloverloadActionData actionTable2__arr9;
        [FieldOffset(0x2CC)] public BossMetaloverloadActionData actionTable2__arr10;
        [FieldOffset(0x2DC)] public BossMetaloverloadActionData actionTable2__arr11;
        [FieldOffset(0x2EC)] public BossMetaloverloadActionData actionTable2__arr12;
        [FieldOffset(0x2FC)] public BossMetaloverloadActionData actionTable2__arr13;
        [FieldOffset(0x30C)] public BossMetaloverloadActionData actionTable2__arr14;
        [FieldOffset(0x31C)] public BossMetaloverloadActionData actionTable2__arr15;
        [FieldOffset(0x32C)] public BossMetaloverloadActionData actionTable2__arr16;
        [FieldOffset(0x33C)] public BossMetaloverloadActionData actionTable2__arr17;
        [FieldOffset(0x34C)] public BossMetaloverloadActionData actionTable2__arr18;
        [FieldOffset(0x35C)] public BossMetaloverloadActionData actionTable2__arr19;
        [FieldOffset(0x36C)] public BossMetaloverloadActionData actionTable2__arr20;
        [FieldOffset(0x37C)] public BossMetaloverloadActionData actionTable2__arr21;
        [FieldOffset(0x38C)] public BossMetaloverloadActionData actionTable2__arr22;
        [FieldOffset(0x39C)] public BossMetaloverloadActionData actionTable2__arr23;
        [FieldOffset(0x3AC)] public BossMetaloverloadActionData actionTable2__arr24;
        [FieldOffset(0x3BC)] public BossMetaloverloadActionData actionTable2__arr25;
        [FieldOffset(0x3CC)] public BossMetaloverloadActionData actionTable2__arr26;
        [FieldOffset(0x3DC)] public BossMetaloverloadActionData actionTable2__arr27;
        [FieldOffset(0x3EC)] public BossMetaloverloadActionData actionTable2__arr28;
        [FieldOffset(0x3FC)] public BossMetaloverloadActionData actionTable2__arr29;
        [FieldOffset(0x40C)] public BossMetaloverloadActionData actionTable2__arr30;
        [FieldOffset(0x41C)] public BossMetaloverloadActionData actionTable2__arr31;
        [FieldOffset(0x42C)] public BossMetaloverloadActionData actionTable2__arr32;
        [FieldOffset(0x43C)] public BossMetaloverloadActionData actionTable2__arr33;
        [FieldOffset(0x44C)] public BossMetaloverloadActionData actionTable3__arr0;
        [FieldOffset(0x45C)] public BossMetaloverloadActionData actionTable3__arr1;
        [FieldOffset(0x46C)] public BossMetaloverloadActionData actionTable3__arr2;
        [FieldOffset(0x47C)] public BossMetaloverloadActionData actionTable3__arr3;
        [FieldOffset(0x48C)] public BossMetaloverloadActionData actionTable3__arr4;
        [FieldOffset(0x49C)] public BossMetaloverloadActionData actionTable3__arr5;
        [FieldOffset(0x4AC)] public BossMetaloverloadActionData actionTable3__arr6;
        [FieldOffset(0x4BC)] public BossMetaloverloadActionData actionTable3__arr7;
        [FieldOffset(0x4CC)] public BossMetaloverloadActionData actionTable3__arr8;
        [FieldOffset(0x4DC)] public BossMetaloverloadActionData actionTable3__arr9;
        [FieldOffset(0x4EC)] public BossMetaloverloadActionData actionTable3__arr10;
        [FieldOffset(0x4FC)] public BossMetaloverloadActionData actionTable3__arr11;
        [FieldOffset(0x50C)] public BossMetaloverloadActionData actionTable3__arr12;
        [FieldOffset(0x51C)] public BossMetaloverloadActionData actionTable3__arr13;
        [FieldOffset(0x52C)] public BossMetaloverloadActionData actionTable3__arr14;
        [FieldOffset(0x53C)] public BossMetaloverloadActionData actionTable3__arr15;
        [FieldOffset(0x54C)] public BossMetaloverloadActionData actionTable3__arr16;
        [FieldOffset(0x55C)] public BossMetaloverloadActionData actionTable3__arr17;
        [FieldOffset(0x56C)] public BossMetaloverloadActionData actionTable3__arr18;
        [FieldOffset(0x57C)] public BossMetaloverloadActionData actionTable3__arr19;
        [FieldOffset(0x58C)] public BossMetaloverloadActionData actionTable3__arr20;
        [FieldOffset(0x59C)] public BossMetaloverloadActionData actionTable3__arr21;
        [FieldOffset(0x5AC)] public BossMetaloverloadActionData actionTable3__arr22;
        [FieldOffset(0x5BC)] public BossMetaloverloadActionData actionTable3__arr23;
        [FieldOffset(0x5CC)] public BossMetaloverloadActionData actionTable3__arr24;
        [FieldOffset(0x5DC)] public BossMetaloverloadActionData actionTable3__arr25;
        [FieldOffset(0x5EC)] public BossMetaloverloadActionData actionTable3__arr26;
        [FieldOffset(0x5FC)] public BossMetaloverloadActionData actionTable3__arr27;
        [FieldOffset(0x60C)] public BossMetaloverloadActionData actionTable3__arr28;
        [FieldOffset(0x61C)] public BossMetaloverloadActionData actionTable3__arr29;
        [FieldOffset(0x62C)] public BossMetaloverloadActionData actionTable3__arr30;
        [FieldOffset(0x63C)] public BossMetaloverloadActionData actionTable3__arr31;
        [FieldOffset(0x64C)] public BossMetaloverloadActionData actionTable3__arr32;
        [FieldOffset(0x65C)] public BossMetaloverloadActionData actionTable3__arr33;
        [FieldOffset(0x66C)] public BossMetaloverloadActionData actionTable4__arr0;
        [FieldOffset(0x67C)] public BossMetaloverloadActionData actionTable4__arr1;
        [FieldOffset(0x68C)] public BossMetaloverloadActionData actionTable4__arr2;
        [FieldOffset(0x69C)] public BossMetaloverloadActionData actionTable4__arr3;
        [FieldOffset(0x6AC)] public BossMetaloverloadActionData actionTable4__arr4;
        [FieldOffset(0x6BC)] public BossMetaloverloadActionData actionTable4__arr5;
        [FieldOffset(0x6CC)] public BossMetaloverloadActionData actionTable4__arr6;
        [FieldOffset(0x6DC)] public BossMetaloverloadActionData actionTable4__arr7;
        [FieldOffset(0x6EC)] public BossMetaloverloadActionData actionTable4__arr8;
        [FieldOffset(0x6FC)] public BossMetaloverloadActionData actionTable4__arr9;
        [FieldOffset(0x70C)] public BossMetaloverloadActionData actionTable4__arr10;
        [FieldOffset(0x71C)] public BossMetaloverloadActionData actionTable4__arr11;
        [FieldOffset(0x72C)] public BossMetaloverloadActionData actionTable4__arr12;
        [FieldOffset(0x73C)] public BossMetaloverloadActionData actionTable4__arr13;
        [FieldOffset(0x74C)] public BossMetaloverloadActionData actionTable4__arr14;
        [FieldOffset(0x75C)] public BossMetaloverloadActionData actionTable4__arr15;
        [FieldOffset(0x76C)] public BossMetaloverloadActionData actionTable4__arr16;
        [FieldOffset(0x77C)] public BossMetaloverloadActionData actionTable4__arr17;
        [FieldOffset(0x78C)] public BossMetaloverloadActionData actionTable4__arr18;
        [FieldOffset(0x79C)] public BossMetaloverloadActionData actionTable4__arr19;
        [FieldOffset(0x7AC)] public BossMetaloverloadActionData actionTable4__arr20;
        [FieldOffset(0x7BC)] public BossMetaloverloadActionData actionTable4__arr21;
        [FieldOffset(0x7CC)] public BossMetaloverloadActionData actionTable4__arr22;
        [FieldOffset(0x7DC)] public BossMetaloverloadActionData actionTable4__arr23;
        [FieldOffset(0x7EC)] public BossMetaloverloadActionData actionTable4__arr24;
        [FieldOffset(0x7FC)] public BossMetaloverloadActionData actionTable4__arr25;
        [FieldOffset(0x80C)] public BossMetaloverloadActionData actionTable4__arr26;
        [FieldOffset(0x81C)] public BossMetaloverloadActionData actionTable4__arr27;
        [FieldOffset(0x82C)] public BossMetaloverloadActionData actionTable4__arr28;
        [FieldOffset(0x83C)] public BossMetaloverloadActionData actionTable4__arr29;
        [FieldOffset(0x84C)] public BossMetaloverloadActionData actionTable4__arr30;
        [FieldOffset(0x85C)] public BossMetaloverloadActionData actionTable4__arr31;
        [FieldOffset(0x86C)] public BossMetaloverloadActionData actionTable4__arr32;
        [FieldOffset(0x87C)] public BossMetaloverloadActionData actionTable4__arr33;
        [FieldOffset(0x88C)] public BossMetaloverloadActionData actionTable1ByHard__arr0;
        [FieldOffset(0x89C)] public BossMetaloverloadActionData actionTable1ByHard__arr1;
        [FieldOffset(0x8AC)] public BossMetaloverloadActionData actionTable1ByHard__arr2;
        [FieldOffset(0x8BC)] public BossMetaloverloadActionData actionTable1ByHard__arr3;
        [FieldOffset(0x8CC)] public BossMetaloverloadActionData actionTable1ByHard__arr4;
        [FieldOffset(0x8DC)] public BossMetaloverloadActionData actionTable1ByHard__arr5;
        [FieldOffset(0x8EC)] public BossMetaloverloadActionData actionTable1ByHard__arr6;
        [FieldOffset(0x8FC)] public BossMetaloverloadActionData actionTable1ByHard__arr7;
        [FieldOffset(0x90C)] public BossMetaloverloadActionData actionTable1ByHard__arr8;
        [FieldOffset(0x91C)] public BossMetaloverloadActionData actionTable1ByHard__arr9;
        [FieldOffset(0x92C)] public BossMetaloverloadActionData actionTable1ByHard__arr10;
        [FieldOffset(0x93C)] public BossMetaloverloadActionData actionTable1ByHard__arr11;
        [FieldOffset(0x94C)] public BossMetaloverloadActionData actionTable1ByHard__arr12;
        [FieldOffset(0x95C)] public BossMetaloverloadActionData actionTable1ByHard__arr13;
        [FieldOffset(0x96C)] public BossMetaloverloadActionData actionTable1ByHard__arr14;
        [FieldOffset(0x97C)] public BossMetaloverloadActionData actionTable1ByHard__arr15;
        [FieldOffset(0x98C)] public BossMetaloverloadActionData actionTable1ByHard__arr16;
        [FieldOffset(0x99C)] public BossMetaloverloadActionData actionTable1ByHard__arr17;
        [FieldOffset(0x9AC)] public BossMetaloverloadActionData actionTable1ByHard__arr18;
        [FieldOffset(0x9BC)] public BossMetaloverloadActionData actionTable1ByHard__arr19;
        [FieldOffset(0x9CC)] public BossMetaloverloadActionData actionTable1ByHard__arr20;
        [FieldOffset(0x9DC)] public BossMetaloverloadActionData actionTable1ByHard__arr21;
        [FieldOffset(0x9EC)] public BossMetaloverloadActionData actionTable1ByHard__arr22;
        [FieldOffset(0x9FC)] public BossMetaloverloadActionData actionTable1ByHard__arr23;
        [FieldOffset(0xA0C)] public BossMetaloverloadActionData actionTable1ByHard__arr24;
        [FieldOffset(0xA1C)] public BossMetaloverloadActionData actionTable1ByHard__arr25;
        [FieldOffset(0xA2C)] public BossMetaloverloadActionData actionTable1ByHard__arr26;
        [FieldOffset(0xA3C)] public BossMetaloverloadActionData actionTable1ByHard__arr27;
        [FieldOffset(0xA4C)] public BossMetaloverloadActionData actionTable1ByHard__arr28;
        [FieldOffset(0xA5C)] public BossMetaloverloadActionData actionTable1ByHard__arr29;
        [FieldOffset(0xA6C)] public BossMetaloverloadActionData actionTable1ByHard__arr30;
        [FieldOffset(0xA7C)] public BossMetaloverloadActionData actionTable1ByHard__arr31;
        [FieldOffset(0xA8C)] public BossMetaloverloadActionData actionTable1ByHard__arr32;
        [FieldOffset(0xA9C)] public BossMetaloverloadActionData actionTable1ByHard__arr33;
        [FieldOffset(0xAAC)] public BossMetaloverloadActionData actionTable2ByHard__arr0;
        [FieldOffset(0xABC)] public BossMetaloverloadActionData actionTable2ByHard__arr1;
        [FieldOffset(0xACC)] public BossMetaloverloadActionData actionTable2ByHard__arr2;
        [FieldOffset(0xADC)] public BossMetaloverloadActionData actionTable2ByHard__arr3;
        [FieldOffset(0xAEC)] public BossMetaloverloadActionData actionTable2ByHard__arr4;
        [FieldOffset(0xAFC)] public BossMetaloverloadActionData actionTable2ByHard__arr5;
        [FieldOffset(0xB0C)] public BossMetaloverloadActionData actionTable2ByHard__arr6;
        [FieldOffset(0xB1C)] public BossMetaloverloadActionData actionTable2ByHard__arr7;
        [FieldOffset(0xB2C)] public BossMetaloverloadActionData actionTable2ByHard__arr8;
        [FieldOffset(0xB3C)] public BossMetaloverloadActionData actionTable2ByHard__arr9;
        [FieldOffset(0xB4C)] public BossMetaloverloadActionData actionTable2ByHard__arr10;
        [FieldOffset(0xB5C)] public BossMetaloverloadActionData actionTable2ByHard__arr11;
        [FieldOffset(0xB6C)] public BossMetaloverloadActionData actionTable2ByHard__arr12;
        [FieldOffset(0xB7C)] public BossMetaloverloadActionData actionTable2ByHard__arr13;
        [FieldOffset(0xB8C)] public BossMetaloverloadActionData actionTable2ByHard__arr14;
        [FieldOffset(0xB9C)] public BossMetaloverloadActionData actionTable2ByHard__arr15;
        [FieldOffset(0xBAC)] public BossMetaloverloadActionData actionTable2ByHard__arr16;
        [FieldOffset(0xBBC)] public BossMetaloverloadActionData actionTable2ByHard__arr17;
        [FieldOffset(0xBCC)] public BossMetaloverloadActionData actionTable2ByHard__arr18;
        [FieldOffset(0xBDC)] public BossMetaloverloadActionData actionTable2ByHard__arr19;
        [FieldOffset(0xBEC)] public BossMetaloverloadActionData actionTable2ByHard__arr20;
        [FieldOffset(0xBFC)] public BossMetaloverloadActionData actionTable2ByHard__arr21;
        [FieldOffset(0xC0C)] public BossMetaloverloadActionData actionTable2ByHard__arr22;
        [FieldOffset(0xC1C)] public BossMetaloverloadActionData actionTable2ByHard__arr23;
        [FieldOffset(0xC2C)] public BossMetaloverloadActionData actionTable2ByHard__arr24;
        [FieldOffset(0xC3C)] public BossMetaloverloadActionData actionTable2ByHard__arr25;
        [FieldOffset(0xC4C)] public BossMetaloverloadActionData actionTable2ByHard__arr26;
        [FieldOffset(0xC5C)] public BossMetaloverloadActionData actionTable2ByHard__arr27;
        [FieldOffset(0xC6C)] public BossMetaloverloadActionData actionTable2ByHard__arr28;
        [FieldOffset(0xC7C)] public BossMetaloverloadActionData actionTable2ByHard__arr29;
        [FieldOffset(0xC8C)] public BossMetaloverloadActionData actionTable2ByHard__arr30;
        [FieldOffset(0xC9C)] public BossMetaloverloadActionData actionTable2ByHard__arr31;
        [FieldOffset(0xCAC)] public BossMetaloverloadActionData actionTable2ByHard__arr32;
        [FieldOffset(0xCBC)] public BossMetaloverloadActionData actionTable2ByHard__arr33;
        [FieldOffset(0xCCC)] public BossMetaloverloadActionData actionTable3ByHard__arr0;
        [FieldOffset(0xCDC)] public BossMetaloverloadActionData actionTable3ByHard__arr1;
        [FieldOffset(0xCEC)] public BossMetaloverloadActionData actionTable3ByHard__arr2;
        [FieldOffset(0xCFC)] public BossMetaloverloadActionData actionTable3ByHard__arr3;
        [FieldOffset(0xD0C)] public BossMetaloverloadActionData actionTable3ByHard__arr4;
        [FieldOffset(0xD1C)] public BossMetaloverloadActionData actionTable3ByHard__arr5;
        [FieldOffset(0xD2C)] public BossMetaloverloadActionData actionTable3ByHard__arr6;
        [FieldOffset(0xD3C)] public BossMetaloverloadActionData actionTable3ByHard__arr7;
        [FieldOffset(0xD4C)] public BossMetaloverloadActionData actionTable3ByHard__arr8;
        [FieldOffset(0xD5C)] public BossMetaloverloadActionData actionTable3ByHard__arr9;
        [FieldOffset(0xD6C)] public BossMetaloverloadActionData actionTable3ByHard__arr10;
        [FieldOffset(0xD7C)] public BossMetaloverloadActionData actionTable3ByHard__arr11;
        [FieldOffset(0xD8C)] public BossMetaloverloadActionData actionTable3ByHard__arr12;
        [FieldOffset(0xD9C)] public BossMetaloverloadActionData actionTable3ByHard__arr13;
        [FieldOffset(0xDAC)] public BossMetaloverloadActionData actionTable3ByHard__arr14;
        [FieldOffset(0xDBC)] public BossMetaloverloadActionData actionTable3ByHard__arr15;
        [FieldOffset(0xDCC)] public BossMetaloverloadActionData actionTable3ByHard__arr16;
        [FieldOffset(0xDDC)] public BossMetaloverloadActionData actionTable3ByHard__arr17;
        [FieldOffset(0xDEC)] public BossMetaloverloadActionData actionTable3ByHard__arr18;
        [FieldOffset(0xDFC)] public BossMetaloverloadActionData actionTable3ByHard__arr19;
        [FieldOffset(0xE0C)] public BossMetaloverloadActionData actionTable3ByHard__arr20;
        [FieldOffset(0xE1C)] public BossMetaloverloadActionData actionTable3ByHard__arr21;
        [FieldOffset(0xE2C)] public BossMetaloverloadActionData actionTable3ByHard__arr22;
        [FieldOffset(0xE3C)] public BossMetaloverloadActionData actionTable3ByHard__arr23;
        [FieldOffset(0xE4C)] public BossMetaloverloadActionData actionTable3ByHard__arr24;
        [FieldOffset(0xE5C)] public BossMetaloverloadActionData actionTable3ByHard__arr25;
        [FieldOffset(0xE6C)] public BossMetaloverloadActionData actionTable3ByHard__arr26;
        [FieldOffset(0xE7C)] public BossMetaloverloadActionData actionTable3ByHard__arr27;
        [FieldOffset(0xE8C)] public BossMetaloverloadActionData actionTable3ByHard__arr28;
        [FieldOffset(0xE9C)] public BossMetaloverloadActionData actionTable3ByHard__arr29;
        [FieldOffset(0xEAC)] public BossMetaloverloadActionData actionTable3ByHard__arr30;
        [FieldOffset(0xEBC)] public BossMetaloverloadActionData actionTable3ByHard__arr31;
        [FieldOffset(0xECC)] public BossMetaloverloadActionData actionTable3ByHard__arr32;
        [FieldOffset(0xEDC)] public BossMetaloverloadActionData actionTable3ByHard__arr33;
        [FieldOffset(0xEEC)] public BossMetaloverloadActionData actionTable4ByHard__arr0;
        [FieldOffset(0xEFC)] public BossMetaloverloadActionData actionTable4ByHard__arr1;
        [FieldOffset(0xF0C)] public BossMetaloverloadActionData actionTable4ByHard__arr2;
        [FieldOffset(0xF1C)] public BossMetaloverloadActionData actionTable4ByHard__arr3;
        [FieldOffset(0xF2C)] public BossMetaloverloadActionData actionTable4ByHard__arr4;
        [FieldOffset(0xF3C)] public BossMetaloverloadActionData actionTable4ByHard__arr5;
        [FieldOffset(0xF4C)] public BossMetaloverloadActionData actionTable4ByHard__arr6;
        [FieldOffset(0xF5C)] public BossMetaloverloadActionData actionTable4ByHard__arr7;
        [FieldOffset(0xF6C)] public BossMetaloverloadActionData actionTable4ByHard__arr8;
        [FieldOffset(0xF7C)] public BossMetaloverloadActionData actionTable4ByHard__arr9;
        [FieldOffset(0xF8C)] public BossMetaloverloadActionData actionTable4ByHard__arr10;
        [FieldOffset(0xF9C)] public BossMetaloverloadActionData actionTable4ByHard__arr11;
        [FieldOffset(0xFAC)] public BossMetaloverloadActionData actionTable4ByHard__arr12;
        [FieldOffset(0xFBC)] public BossMetaloverloadActionData actionTable4ByHard__arr13;
        [FieldOffset(0xFCC)] public BossMetaloverloadActionData actionTable4ByHard__arr14;
        [FieldOffset(0xFDC)] public BossMetaloverloadActionData actionTable4ByHard__arr15;
        [FieldOffset(0xFEC)] public BossMetaloverloadActionData actionTable4ByHard__arr16;
        [FieldOffset(0xFFC)] public BossMetaloverloadActionData actionTable4ByHard__arr17;
        [FieldOffset(0x100C)] public BossMetaloverloadActionData actionTable4ByHard__arr18;
        [FieldOffset(0x101C)] public BossMetaloverloadActionData actionTable4ByHard__arr19;
        [FieldOffset(0x102C)] public BossMetaloverloadActionData actionTable4ByHard__arr20;
        [FieldOffset(0x103C)] public BossMetaloverloadActionData actionTable4ByHard__arr21;
        [FieldOffset(0x104C)] public BossMetaloverloadActionData actionTable4ByHard__arr22;
        [FieldOffset(0x105C)] public BossMetaloverloadActionData actionTable4ByHard__arr23;
        [FieldOffset(0x106C)] public BossMetaloverloadActionData actionTable4ByHard__arr24;
        [FieldOffset(0x107C)] public BossMetaloverloadActionData actionTable4ByHard__arr25;
        [FieldOffset(0x108C)] public BossMetaloverloadActionData actionTable4ByHard__arr26;
        [FieldOffset(0x109C)] public BossMetaloverloadActionData actionTable4ByHard__arr27;
        [FieldOffset(0x10AC)] public BossMetaloverloadActionData actionTable4ByHard__arr28;
        [FieldOffset(0x10BC)] public BossMetaloverloadActionData actionTable4ByHard__arr29;
        [FieldOffset(0x10CC)] public BossMetaloverloadActionData actionTable4ByHard__arr30;
        [FieldOffset(0x10DC)] public BossMetaloverloadActionData actionTable4ByHard__arr31;
        [FieldOffset(0x10EC)] public BossMetaloverloadActionData actionTable4ByHard__arr32;
        [FieldOffset(0x10FC)] public BossMetaloverloadActionData actionTable4ByHard__arr33;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct BossMetaloverloadPhase1AutorunParam
    {
        [FieldOffset(0x00)] public float speed;
        [FieldOffset(0x04)] public float width;
        [FieldOffset(0x08)] public float bossSpeedMax;
        [FieldOffset(0x0C)] public float bossSpeedMin;
        [FieldOffset(0x10)] public float bossAccelSpeed;
        [FieldOffset(0x14)] public float bossDecelSpeed;
        [FieldOffset(0x18)] public float bossKeepDistanceDefault;
        [FieldOffset(0x1C)] public float bossKeepDistanceLimit;
        [FieldOffset(0x20)] public float bossStanLostDistance;
        [FieldOffset(0x24)] public float bossDefalutDistanceReturnTime;
        [FieldOffset(0x28)] public float bossDefalutDistanceReturnSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct BossBattleLockOnCameraParam
    {
        [FieldOffset(0x00)] public UnmanagedString nodeName;
        [FieldOffset(0x10)] public Vector3 offset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct BossPointCameraParam
    {
        [FieldOffset(0x00)] public float fovy;
        [FieldOffset(0x04)] public float toPointDistanceMin;
        [FieldOffset(0x08)] public float toPointDistanceMax;
        [FieldOffset(0x0C)] public float distanceMin;
        [FieldOffset(0x10)] public float distanceMax;
        [FieldOffset(0x14)] public float gravityOffsetMin;
        [FieldOffset(0x18)] public float gravityOffsetMax;
        [FieldOffset(0x20)] public Vector3 playerOffsetMin;
        [FieldOffset(0x30)] public Vector3 playerOffsetMax;
        [FieldOffset(0x40)] public Vector3 worldOffsetMin;
        [FieldOffset(0x50)] public Vector3 worldOffsetMax;
        [FieldOffset(0x60)] public Vector3 pointLocalOffsetMin;
        [FieldOffset(0x70)] public Vector3 pointLocalOffsetMax;
        [FieldOffset(0x80)] public UnmanagedString nodeName;
        [FieldOffset(0x90)] public float roll;
        [FieldOffset(0x94)] public float easeInTime;
        [FieldOffset(0x98)] public float easeOutTime;
        [FieldOffset(0x9C)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct BossMetaloverloadLockonCameraParam
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float distance;
        [FieldOffset(0x08)] public float minElevation;
        [FieldOffset(0x0C)] public float maxElevation;
        [FieldOffset(0x10)] public float panningSuspensionK;
        [FieldOffset(0x14)] public float interiorPanningSuspensionK;
        [FieldOffset(0x18)] public float time;
        [FieldOffset(0x1C)] public float easeInTime;
        [FieldOffset(0x20)] public float easeOutTime;
    }

    public enum InputGuideKind : sbyte
    {
        INPUT_GUIDE_KIND_NONE = 0,
        INPUT_GUIDE_KIND_LEFT_STEP = 1,
        INPUT_GUIDE_KIND_RIGHT_STEP = 2,
        INPUT_GUIDE_KIND_JUMP = 3,
        INPUT_GUIDE_KIND_NUM = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossMetaloverloadPhase1MissileInfo
    {
        [FieldOffset(0x00)] public sbyte laneNumber;
        [FieldOffset(0x01)] public bool missileStepsEneble__arr0;
        [FieldOffset(0x02)] public bool missileStepsEneble__arr1;
        [FieldOffset(0x03)] public bool missileStepsEneble__arr2;
        [FieldOffset(0x04)] public bool missileStepsEneble__arr3;
        [FieldOffset(0x05)] public bool enebleBounce;
        [FieldOffset(0x08)] public float shotTime;
        [FieldOffset(0x0C)] public InputGuideKind inputGuideKind;
        [FieldOffset(0x0D)] public bool isScreenInputGuide;
        [FieldOffset(0x10)] public float screenInputGuideDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x320)]
    public struct BossMetaloverloadPhase1MissilePatternData
    {
        [FieldOffset(0x00)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr0;
        [FieldOffset(0x14)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr1;
        [FieldOffset(0x28)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr2;
        [FieldOffset(0x3C)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr3;
        [FieldOffset(0x50)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr4;
        [FieldOffset(0x64)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr5;
        [FieldOffset(0x78)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr6;
        [FieldOffset(0x8C)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr7;
        [FieldOffset(0xA0)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr8;
        [FieldOffset(0xB4)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr9;
        [FieldOffset(0xC8)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr10;
        [FieldOffset(0xDC)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr11;
        [FieldOffset(0xF0)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr12;
        [FieldOffset(0x104)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr13;
        [FieldOffset(0x118)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr14;
        [FieldOffset(0x12C)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr15;
        [FieldOffset(0x140)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr16;
        [FieldOffset(0x154)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr17;
        [FieldOffset(0x168)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr18;
        [FieldOffset(0x17C)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr19;
        [FieldOffset(0x190)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr20;
        [FieldOffset(0x1A4)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr21;
        [FieldOffset(0x1B8)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr22;
        [FieldOffset(0x1CC)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr23;
        [FieldOffset(0x1E0)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr24;
        [FieldOffset(0x1F4)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr25;
        [FieldOffset(0x208)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr26;
        [FieldOffset(0x21C)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr27;
        [FieldOffset(0x230)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr28;
        [FieldOffset(0x244)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr29;
        [FieldOffset(0x258)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr30;
        [FieldOffset(0x26C)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr31;
        [FieldOffset(0x280)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr32;
        [FieldOffset(0x294)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr33;
        [FieldOffset(0x2A8)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr34;
        [FieldOffset(0x2BC)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr35;
        [FieldOffset(0x2D0)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr36;
        [FieldOffset(0x2E4)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr37;
        [FieldOffset(0x2F8)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr38;
        [FieldOffset(0x30C)] public BossMetaloverloadPhase1MissileInfo missileInfoTabel__arr39;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1970)]
    public struct BossMetaloverloadPhase1MissileParam
    {
        [FieldOffset(0x00)] public float backwardMoveTime;
        [FieldOffset(0x04)] public float backwardMoveDistance;
        [FieldOffset(0x08)] public float originalPosMoveTime;
        [FieldOffset(0x0C)] public float startWaitTime;
        [FieldOffset(0x10)] public float endWaitTime;
        [FieldOffset(0x14)] public float straightSpeed;
        [FieldOffset(0x18)] public float straightSpeedByHard;
        [FieldOffset(0x1C)] public float curveTime;
        [FieldOffset(0x20)] public float curveTimeByHard;
        [FieldOffset(0x24)] public float blowSpeed;
        [FieldOffset(0x28)] public float laneHeight;
        [FieldOffset(0x2C)] public float lifeTime;
        [FieldOffset(0x30)] public float leaveDistance;
        [FieldOffset(0x34)] public int blowHitDamagePoint;
        [FieldOffset(0x38)] public float blowCurvedTime;
        [FieldOffset(0x3C)] public float blowCurvedYMax;
        [FieldOffset(0x40)] public float floatHeight;
        [FieldOffset(0x44)] public float missileScale;
        [FieldOffset(0x48)] public float stepHeight;
        [FieldOffset(0x4C)] public float colRadius;
        [FieldOffset(0x50)] public float colHeight;
        [FieldOffset(0x60)] public Vector3 colOffset;
        [FieldOffset(0x70)] public BossMetaloverloadPhase1MissilePatternData missilePatterns__arr0;
        [FieldOffset(0x390)] public BossMetaloverloadPhase1MissilePatternData missilePatterns__arr1;
        [FieldOffset(0x6B0)] public BossMetaloverloadPhase1MissilePatternData missilePatterns__arr2;
        [FieldOffset(0x9D0)] public BossMetaloverloadPhase1MissilePatternData missilePatterns__arr3;
        [FieldOffset(0xCF0)] public BossMetaloverloadPhase1MissilePatternData missilePatternsByHard__arr0;
        [FieldOffset(0x1010)] public BossMetaloverloadPhase1MissilePatternData missilePatternsByHard__arr1;
        [FieldOffset(0x1330)] public BossMetaloverloadPhase1MissilePatternData missilePatternsByHard__arr2;
        [FieldOffset(0x1650)] public BossMetaloverloadPhase1MissilePatternData missilePatternsByHard__arr3;
    }

    public enum Phase1TailAttackType : sbyte
    {
        TAIL_ACT_NONE = 0,
        TAIL_ACT_1 = 1,
        TAIL_ACT_2 = 2,
        TAIL_ACT_3 = 3,
        TAIL_ACT_4 = 4,
        TAIL_ACT_NUM = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct BossMetaloverloadPhaseTailInfo
    {
        [FieldOffset(0x00)] public Phase1TailAttackType type;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct BossMetaloverloadPhase1TailPatternData
    {
        [FieldOffset(0x00)] public float attackInterval;
        [FieldOffset(0x04)] public BossMetaloverloadPhaseTailInfo tailTypeTabel__arr0;
        [FieldOffset(0x05)] public BossMetaloverloadPhaseTailInfo tailTypeTabel__arr1;
        [FieldOffset(0x06)] public BossMetaloverloadPhaseTailInfo tailTypeTabel__arr2;
        [FieldOffset(0x07)] public BossMetaloverloadPhaseTailInfo tailTypeTabel__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct BossMetaloverloadPhase1TailParam
    {
        [FieldOffset(0x00)] public float frontMoveDistance;
        [FieldOffset(0x04)] public float frontMoveUpPos;
        [FieldOffset(0x08)] public float riseAndFallMotionSpeed;
        [FieldOffset(0x0C)] public float attackMotionSpeed;
        [FieldOffset(0x10)] public float attackIntervalMotionSpeed;
        [FieldOffset(0x14)] public float colliderOffsetHeight;
        [FieldOffset(0x18)] public float floatHeight;
        [FieldOffset(0x1C)] public BossMetaloverloadPhase1TailPatternData tailPatterns__arr0;
        [FieldOffset(0x24)] public BossMetaloverloadPhase1TailPatternData tailPatterns__arr1;
        [FieldOffset(0x2C)] public BossMetaloverloadPhase1TailPatternData tailPatterns__arr2;
        [FieldOffset(0x34)] public BossMetaloverloadPhase1TailPatternData tailPatterns__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct BossMetaloverloadPhase1FlameParam
    {
        [FieldOffset(0x00)] public float backwardMoveTime;
        [FieldOffset(0x04)] public float backwardMoveDistance;
        [FieldOffset(0x08)] public float floatHeight;
        [FieldOffset(0x0C)] public float originalPosMoveTime;
        [FieldOffset(0x10)] public float startWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct BossMetaloverloadPhase1SelfRecoverDebris
    {
        [FieldOffset(0x00)] public int stopPosNo;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct BossMetaloverloadPhase1SelfRecoverParam
    {
        [FieldOffset(0x00)] public float selfRecoverActiveHp;
        [FieldOffset(0x04)] public float recoverHp;
        [FieldOffset(0x08)] public float limitRecoverHp;
        [FieldOffset(0x0C)] public float bossKeepDistance;
        [FieldOffset(0x10)] public float debrisSpeed;
        [FieldOffset(0x14)] public float frontSpeed;
        [FieldOffset(0x18)] public float upSpeed;
        [FieldOffset(0x1C)] public float outOfControlTime;
        [FieldOffset(0x20)] public float keepVelocityTime;
        [FieldOffset(0x24)] public float miniDebrisCreateIntervalTime;
        [FieldOffset(0x28)] public int miniDebrisNum;
        [FieldOffset(0x2C)] public float miniDebrisSpeed;
        [FieldOffset(0x30)] public float floatHeight;
        [FieldOffset(0x34)] public BossMetaloverloadPhase1SelfRecoverDebris debrisList__arr0;
        [FieldOffset(0x38)] public BossMetaloverloadPhase1SelfRecoverDebris debrisList__arr1;
        [FieldOffset(0x3C)] public BossMetaloverloadPhase1SelfRecoverDebris debrisList__arr2;
        [FieldOffset(0x40)] public BossMetaloverloadPhase1SelfRecoverDebris debrisList__arr3;
        [FieldOffset(0x44)] public BossMetaloverloadPhase1SelfRecoverDebris debrisList__arr4;
        [FieldOffset(0x48)] public BossMetaloverloadPhase1SelfRecoverDebris debrisList__arr5;
        [FieldOffset(0x4C)] public BossMetaloverloadPhase1SelfRecoverDebris debrisList__arr6;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct BossMetaloverloadPhase1TimeStopParam
    {
        [FieldOffset(0x00)] public float bossKeepDistance;
        [FieldOffset(0x04)] public float photonDashBossKeepDistance;
        [FieldOffset(0x08)] public float photonDashBossKeepTime;
        [FieldOffset(0x0C)] public float photonDashDistanceOffset;
        [FieldOffset(0x10)] public float photonDashAttackAfterCameraStartTime;
        [FieldOffset(0x14)] public float photonDashAttackAfterCameraInvalidationTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct BossMetaloverloadPhase1DamageParam
    {
        [FieldOffset(0x00)] public float stunTime;
        [FieldOffset(0x04)] public float rushTime;
        [FieldOffset(0x08)] public float rushCameraDelayTime;
        [FieldOffset(0x0C)] public float damageAfterTime;
        [FieldOffset(0x10)] public float damageAfterDistance;
        [FieldOffset(0x14)] public int debrisBlowHitDamagePoint;
        [FieldOffset(0x18)] public int debrisSurfSpinBlowHitDamagePoint;
        [FieldOffset(0x1C)] public int mineBlowHitDamagePoint;
        [FieldOffset(0x20)] public float rushFinishDamageScale;
        [FieldOffset(0x24)] public int photonDashDamagePoint;
        [FieldOffset(0x28)] public float phaseChangeWaitTime;
        [FieldOffset(0x2C)] public float photonPhaseChangeWaitTime;
        [FieldOffset(0x30)] public float blowPower;
        [FieldOffset(0x34)] public float blowUpPower;
        [FieldOffset(0x38)] public float blowDeceleration;
        [FieldOffset(0x3C)] public float gravityPower;
        [FieldOffset(0x40)] public float blowEndHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct BossMetaloverloadPhase1AttackChanceParam
    {
        [FieldOffset(0x00)] public float distanceOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1E80)]
    public struct BossMetaloverloadPhase1Param
    {
        [FieldOffset(0x00)] public int useActTblHealthPoint2;
        [FieldOffset(0x04)] public sbyte laneNum;
        [FieldOffset(0x08)] public float laneWidth;
        [FieldOffset(0x0C)] public BossMetaloverloadPhase1AutorunParam autorun;
        [FieldOffset(0x40)] public BossBattleLockOnCameraParam mainCamera;
        [FieldOffset(0x60)] public BossPointCameraParam damageCamera;
        [FieldOffset(0x100)] public BossPointCameraParam bossLookAtCamera;
        [FieldOffset(0x1A0)] public BossMetaloverloadLockonCameraParam subCamera;
        [FieldOffset(0x1D0)] public BossMetaloverloadPhase1MissileParam missileParam;
        [FieldOffset(0x1B40)] public BossMetaloverloadPhase1TailParam tailParam;
        [FieldOffset(0x1B7C)] public BossMetaloverloadPhase1FlameParam flameParam;
        [FieldOffset(0x1B90)] public BossMetaloverloadPhase1SelfRecoverParam selfRecoverParam;
        [FieldOffset(0x1BE0)] public BossMetaloverloadPhase1TimeStopParam timeStopParam;
        [FieldOffset(0x1C00)] public BossPointCameraParam photonBeforeBossLookAtCamera;
        [FieldOffset(0x1CA0)] public BossPointCameraParam photonBossLookAtCamera;
        [FieldOffset(0x1D40)] public BossMetaloverloadPhase1DamageParam damageParam;
        [FieldOffset(0x1D84)] public BossMetaloverloadPhase1AttackChanceParam attackChanceParam;
        [FieldOffset(0x1D88)] public bool attackChanceBeforeBossLookAtCameraEneble;
        [FieldOffset(0x1D90)] public BossPointCameraParam attackChanceBeforeBossLookAtCamera;
        [FieldOffset(0x1E30)] public float startCaptionTime;
        [FieldOffset(0x1E38)] public UnmanagedString startCaptionLabel;
        [FieldOffset(0x1E48)] public float tutorialCaptionTime;
        [FieldOffset(0x1E50)] public UnmanagedString tutorialCaptionLabel;
        [FieldOffset(0x1E60)] public float chaosBreakCaptionTime;
        [FieldOffset(0x1E68)] public UnmanagedString chaosBreakCaptionLabel;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE0)]
    public struct BossSVCameraParam
    {
        [FieldOffset(0x00)] public float fovy;
        [FieldOffset(0x04)] public float toPointDistanceMin;
        [FieldOffset(0x08)] public float toPointDistanceMax;
        [FieldOffset(0x0C)] public float distanceMin;
        [FieldOffset(0x10)] public float distanceMax;
        [FieldOffset(0x14)] public float gravityOffsetMin;
        [FieldOffset(0x18)] public float gravityOffsetMax;
        [FieldOffset(0x20)] public Vector3 playerOffsetMin;
        [FieldOffset(0x30)] public Vector3 playerOffsetMax;
        [FieldOffset(0x40)] public Vector3 worldOffsetMin;
        [FieldOffset(0x50)] public Vector3 worldOffsetMax;
        [FieldOffset(0x60)] public Vector3 pointLocalOffsetMin;
        [FieldOffset(0x70)] public Vector3 pointLocalOffsetMax;
        [FieldOffset(0x80)] public UnmanagedString nodeName;
        [FieldOffset(0x90)] public Vector3 pointLocalDir;
        [FieldOffset(0xA0)] public float baseDistance;
        [FieldOffset(0xA4)] public float addSideMoveLimitAngle;
        [FieldOffset(0xA8)] public float addSideMoveDistance;
        [FieldOffset(0xAC)] public float inputStickRotAngle;
        [FieldOffset(0xB0)] public float inputStickDistanceRatioMin;
        [FieldOffset(0xB4)] public float inputStickDistanceRatioMax;
        [FieldOffset(0xB8)] public float inputStickOffsetHeightMin;
        [FieldOffset(0xBC)] public float inputStickOffsetHeightMax;
        [FieldOffset(0xC0)] public float inputStickRollMin;
        [FieldOffset(0xC4)] public float inputStickRollMax;
        [FieldOffset(0xC8)] public float inputStickAddRatio;
        [FieldOffset(0xCC)] public float noInputStickAddRatio;
        [FieldOffset(0xD0)] public float inputStickDelay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct BossMetaloverloadPhase2WaterFlowParam
    {
        [FieldOffset(0x00)] public sbyte laneNum;
        [FieldOffset(0x04)] public float minDistance;
        [FieldOffset(0x08)] public float maxDistance;
        [FieldOffset(0x0C)] public float svPathRadius;
        [FieldOffset(0x10)] public float speed;
        [FieldOffset(0x14)] public float suctionPowerRatio;
        [FieldOffset(0x18)] public float playerBackSpeed;
        [FieldOffset(0x1C)] public float moveDistance;
        [FieldOffset(0x20)] public bool moveUnlock;
        [FieldOffset(0x24)] public float bossRationAngleMin;
        [FieldOffset(0x28)] public float bossRationAngleMax;
        [FieldOffset(0x2C)] public float bossRationSpeedMin;
        [FieldOffset(0x30)] public float bossRationSpeedMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossMetaloverloadPhase2ThornballPatternData
    {
        [FieldOffset(0x00)] public float delay;
        [FieldOffset(0x04)] public float popAngle;
        [FieldOffset(0x08)] public float popInterval;
        [FieldOffset(0x0C)] public sbyte num;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x64)]
    public struct BossMetaloverloadPhase2ThornballParam
    {
        [FieldOffset(0x00)] public int blowHitDamagePoint;
        [FieldOffset(0x04)] public float moveTime;
        [FieldOffset(0x08)] public float blowSpeed;
        [FieldOffset(0x0C)] public float blowUpRatio;
        [FieldOffset(0x10)] public bool firstInputGuideDisplay;
        [FieldOffset(0x14)] public BossMetaloverloadPhase2ThornballPatternData patterns__arr0;
        [FieldOffset(0x24)] public BossMetaloverloadPhase2ThornballPatternData patterns__arr1;
        [FieldOffset(0x34)] public BossMetaloverloadPhase2ThornballPatternData patterns__arr2;
        [FieldOffset(0x44)] public BossMetaloverloadPhase2ThornballPatternData patterns__arr3;
        [FieldOffset(0x54)] public BossMetaloverloadPhase2ThornballPatternData patterns__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct BossMetaloverloadPhase2MoveRingPatternData
    {
        [FieldOffset(0x00)] public float delay;
        [FieldOffset(0x04)] public float popAngle;
        [FieldOffset(0x08)] public float popInterval;
        [FieldOffset(0x0C)] public sbyte num;
        [FieldOffset(0x10)] public float height;
        [FieldOffset(0x14)] public float heightPatterns__arr0;
        [FieldOffset(0x18)] public float heightPatterns__arr1;
        [FieldOffset(0x1C)] public float heightPatterns__arr2;
        [FieldOffset(0x20)] public float heightPatterns__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x94)]
    public struct BossMetaloverloadPhase2MoveRingParam
    {
        [FieldOffset(0x00)] public float moveTime;
        [FieldOffset(0x04)] public BossMetaloverloadPhase2MoveRingPatternData patterns__arr0;
        [FieldOffset(0x28)] public BossMetaloverloadPhase2MoveRingPatternData patterns__arr1;
        [FieldOffset(0x4C)] public BossMetaloverloadPhase2MoveRingPatternData patterns__arr2;
        [FieldOffset(0x70)] public BossMetaloverloadPhase2MoveRingPatternData patterns__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossMetaloverloadPhase2MissileInfo
    {
        [FieldOffset(0x00)] public sbyte laneIndex;
        [FieldOffset(0x01)] public bool isLeft;
        [FieldOffset(0x04)] public float popTime;
        [FieldOffset(0x08)] public float height;
        [FieldOffset(0x0C)] public bool isInvincible;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x108)]
    public struct BossMetaloverloadPhase2MissilePatternData
    {
        [FieldOffset(0x00)] public float hpRatioMin;
        [FieldOffset(0x04)] public float hpRatioMax;
        [FieldOffset(0x08)] public BossMetaloverloadPhase2MissileInfo infos__arr0;
        [FieldOffset(0x18)] public BossMetaloverloadPhase2MissileInfo infos__arr1;
        [FieldOffset(0x28)] public BossMetaloverloadPhase2MissileInfo infos__arr2;
        [FieldOffset(0x38)] public BossMetaloverloadPhase2MissileInfo infos__arr3;
        [FieldOffset(0x48)] public BossMetaloverloadPhase2MissileInfo infos__arr4;
        [FieldOffset(0x58)] public BossMetaloverloadPhase2MissileInfo infos__arr5;
        [FieldOffset(0x68)] public BossMetaloverloadPhase2MissileInfo infos__arr6;
        [FieldOffset(0x78)] public BossMetaloverloadPhase2MissileInfo infos__arr7;
        [FieldOffset(0x88)] public BossMetaloverloadPhase2MissileInfo infos__arr8;
        [FieldOffset(0x98)] public BossMetaloverloadPhase2MissileInfo infos__arr9;
        [FieldOffset(0xA8)] public BossMetaloverloadPhase2MissileInfo infos__arr10;
        [FieldOffset(0xB8)] public BossMetaloverloadPhase2MissileInfo infos__arr11;
        [FieldOffset(0xC8)] public BossMetaloverloadPhase2MissileInfo infos__arr12;
        [FieldOffset(0xD8)] public BossMetaloverloadPhase2MissileInfo infos__arr13;
        [FieldOffset(0xE8)] public BossMetaloverloadPhase2MissileInfo infos__arr14;
        [FieldOffset(0xF8)] public BossMetaloverloadPhase2MissileInfo infos__arr15;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct BossMetaloverloadSVCameraExtensionParam
    {
        [FieldOffset(0x00)] public float addDistance;
        [FieldOffset(0x04)] public float addGravityOffset;
        [FieldOffset(0x10)] public Vector3 addPlayerOffset;
        [FieldOffset(0x20)] public Vector3 addWorldOffset;
        [FieldOffset(0x30)] public Vector3 addPointLocalOffset;
        [FieldOffset(0x40)] public float time;
        [FieldOffset(0x44)] public float easeIn;
        [FieldOffset(0x48)] public float easeOut;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x8D0)]
    public struct BossMetaloverloadPhase2MissileParam
    {
        [FieldOffset(0x00)] public int blowHitDamagePoint;
        [FieldOffset(0x04)] public float flySpeed;
        [FieldOffset(0x08)] public float flySpeedByHard;
        [FieldOffset(0x0C)] public float onWaterSpeed;
        [FieldOffset(0x10)] public float onWaterSpeedByHard;
        [FieldOffset(0x14)] public float shotAngle;
        [FieldOffset(0x18)] public float blowSpeed;
        [FieldOffset(0x1C)] public float blowUpRatio;
        [FieldOffset(0x20)] public float radius;
        [FieldOffset(0x24)] public float waitTime;
        [FieldOffset(0x28)] public float moveTime;
        [FieldOffset(0x2C)] public int spinBlowRingNum;
        [FieldOffset(0x30)] public bool firstInputGuideDisplay;
        [FieldOffset(0x34)] public BossMetaloverloadPhase2MissilePatternData patterns__arr0;
        [FieldOffset(0x13C)] public BossMetaloverloadPhase2MissilePatternData patterns__arr1;
        [FieldOffset(0x244)] public BossMetaloverloadPhase2MissilePatternData patterns__arr2;
        [FieldOffset(0x34C)] public BossMetaloverloadPhase2MissilePatternData patterns__arr3;
        [FieldOffset(0x454)] public BossMetaloverloadPhase2MissilePatternData patternsByHard__arr0;
        [FieldOffset(0x55C)] public BossMetaloverloadPhase2MissilePatternData patternsByHard__arr1;
        [FieldOffset(0x664)] public BossMetaloverloadPhase2MissilePatternData patternsByHard__arr2;
        [FieldOffset(0x76C)] public BossMetaloverloadPhase2MissilePatternData patternsByHard__arr3;
        [FieldOffset(0x880)] public BossMetaloverloadSVCameraExtensionParam cameraEx;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct BossMetaloverloadPhase2ThrowingFocusCameraParam
    {
        [FieldOffset(0x00)] public float hitstopStartTime;
        [FieldOffset(0x04)] public float startTime;
        [FieldOffset(0x08)] public float easeOutTime;
        [FieldOffset(0x0C)] public float keepTime;
        [FieldOffset(0x10)] public Vector3 localOffsetDirection;
        [FieldOffset(0x20)] public float offsetDistance;
        [FieldOffset(0x24)] public float cancelDelay;
        [FieldOffset(0x30)] public Vector3 guideOffset;
        [FieldOffset(0x40)] public float targetOffsetHeight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct BossMetaloverloadPhase2ThrowingBreakDebrisInfo
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector3 landingPos;
        [FieldOffset(0x20)] public float landingTime;
        [FieldOffset(0x24)] public float blowPower;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC20)]
    public struct BossMetaloverloadPhase2ThrowingBreakDebrisParam
    {
        [FieldOffset(0x00)] public int tankBlowHitDamagePoint;
        [FieldOffset(0x04)] public int shipBlowHitDamagePoint;
        [FieldOffset(0x08)] public int tankBlowHitDamagePointByHard;
        [FieldOffset(0x0C)] public int shipBlowHitDamagePointByHard;
        [FieldOffset(0x10)] public float tankRadius;
        [FieldOffset(0x14)] public float shipRadius;
        [FieldOffset(0x18)] public float blowSpeed;
        [FieldOffset(0x1C)] public float blowUpRatio;
        [FieldOffset(0x20)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr0;
        [FieldOffset(0x50)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr1;
        [FieldOffset(0x80)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr2;
        [FieldOffset(0xB0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr3;
        [FieldOffset(0xE0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr4;
        [FieldOffset(0x110)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr5;
        [FieldOffset(0x140)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr6;
        [FieldOffset(0x170)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr7;
        [FieldOffset(0x1A0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr8;
        [FieldOffset(0x1D0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr9;
        [FieldOffset(0x200)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr10;
        [FieldOffset(0x230)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr11;
        [FieldOffset(0x260)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr12;
        [FieldOffset(0x290)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr13;
        [FieldOffset(0x2C0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr14;
        [FieldOffset(0x2F0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebris__arr15;
        [FieldOffset(0x320)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr0;
        [FieldOffset(0x350)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr1;
        [FieldOffset(0x380)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr2;
        [FieldOffset(0x3B0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr3;
        [FieldOffset(0x3E0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr4;
        [FieldOffset(0x410)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr5;
        [FieldOffset(0x440)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr6;
        [FieldOffset(0x470)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr7;
        [FieldOffset(0x4A0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr8;
        [FieldOffset(0x4D0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr9;
        [FieldOffset(0x500)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr10;
        [FieldOffset(0x530)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr11;
        [FieldOffset(0x560)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr12;
        [FieldOffset(0x590)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr13;
        [FieldOffset(0x5C0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr14;
        [FieldOffset(0x5F0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebris__arr15;
        [FieldOffset(0x620)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr0;
        [FieldOffset(0x650)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr1;
        [FieldOffset(0x680)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr2;
        [FieldOffset(0x6B0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr3;
        [FieldOffset(0x6E0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr4;
        [FieldOffset(0x710)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr5;
        [FieldOffset(0x740)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr6;
        [FieldOffset(0x770)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr7;
        [FieldOffset(0x7A0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr8;
        [FieldOffset(0x7D0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr9;
        [FieldOffset(0x800)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr10;
        [FieldOffset(0x830)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr11;
        [FieldOffset(0x860)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr12;
        [FieldOffset(0x890)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr13;
        [FieldOffset(0x8C0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr14;
        [FieldOffset(0x8F0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo tankBreakDebrisByHard__arr15;
        [FieldOffset(0x920)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr0;
        [FieldOffset(0x950)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr1;
        [FieldOffset(0x980)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr2;
        [FieldOffset(0x9B0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr3;
        [FieldOffset(0x9E0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr4;
        [FieldOffset(0xA10)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr5;
        [FieldOffset(0xA40)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr6;
        [FieldOffset(0xA70)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr7;
        [FieldOffset(0xAA0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr8;
        [FieldOffset(0xAD0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr9;
        [FieldOffset(0xB00)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr10;
        [FieldOffset(0xB30)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr11;
        [FieldOffset(0xB60)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr12;
        [FieldOffset(0xB90)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr13;
        [FieldOffset(0xBC0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr14;
        [FieldOffset(0xBF0)] public BossMetaloverloadPhase2ThrowingBreakDebrisInfo shipBreakDebrisByHard__arr15;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct BossMetaloverloadFixedCamera
    {
        [FieldOffset(0x00)] public Vector3 eyeLocalOffset;
        [FieldOffset(0x10)] public Vector3 lookAtLocalOffset;
        [FieldOffset(0x20)] public float fov;
        [FieldOffset(0x24)] public float roll;
        [FieldOffset(0x28)] public float easeInTime;
        [FieldOffset(0x2C)] public float easeOutTime;
        [FieldOffset(0x30)] public float keepTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xE50)]
    public struct BossMetaloverloadPhase2ThrowingParam
    {
        [FieldOffset(0x00)] public int tankHp;
        [FieldOffset(0x04)] public float tankWaterline;
        [FieldOffset(0x10)] public Vector3 tankStartVelocity;
        [FieldOffset(0x20)] public float tankEndWaitTimeByOutOfRange;
        [FieldOffset(0x24)] public float tankEndWaitTimeByBreak;
        [FieldOffset(0x28)] public float tankMoveTime;
        [FieldOffset(0x2C)] public int tankKnokbackRingNum;
        [FieldOffset(0x30)] public int tankNormalBreakRingNum;
        [FieldOffset(0x34)] public int tankTimeStopBreakRingNum;
        [FieldOffset(0x38)] public int shipHp;
        [FieldOffset(0x3C)] public int shipTimeStopRefDebrisNum;
        [FieldOffset(0x40)] public int shipTimeStopRefDebrisDamage;
        [FieldOffset(0x44)] public int shipTimeStopRefDebrisNumByHard;
        [FieldOffset(0x48)] public int shipTimeStopRefDebrisDamageByHard;
        [FieldOffset(0x4C)] public float shipThrowingDecleSpeedRatio;
        [FieldOffset(0x50)] public float shipThrowingDecleTime;
        [FieldOffset(0x54)] public float shipThrowingDecleDelay;
        [FieldOffset(0x60)] public Vector3 shipStartVelocity;
        [FieldOffset(0x70)] public float shipLandingVelocityXZ;
        [FieldOffset(0x74)] public float shipLandingVelocityY;
        [FieldOffset(0x78)] public float shipLandingPosOffsetXZ;
        [FieldOffset(0x7C)] public float shipLandingPosOffsetSide;
        [FieldOffset(0x80)] public float shipEndWaitTimeByOutOfRange;
        [FieldOffset(0x84)] public float shipEndWaitTimeByBreak;
        [FieldOffset(0x88)] public int shipNormalBreakRingNum;
        [FieldOffset(0x8C)] public int shipTimeStopBreakRingNum;
        [FieldOffset(0x90)] public BossMetaloverloadSVCameraExtensionParam tankCameraEx;
        [FieldOffset(0xE0)] public BossMetaloverloadSVCameraExtensionParam tankBreakCameraEx;
        [FieldOffset(0x130)] public BossMetaloverloadPhase2ThrowingFocusCameraParam camera;
        [FieldOffset(0x180)] public BossMetaloverloadSVCameraExtensionParam shipBreakCameraEx;
        [FieldOffset(0x1D0)] public BossMetaloverloadPhase2ThrowingBreakDebrisParam debris;
        [FieldOffset(0xDF0)] public bool shipTargetEnables__arr0;
        [FieldOffset(0xDF1)] public bool shipTargetEnables__arr1;
        [FieldOffset(0xDF2)] public bool shipTargetEnables__arr2;
        [FieldOffset(0xDF3)] public bool shipTargetEnables__arr3;
        [FieldOffset(0xDF4)] public bool shipTargetEnables__arr4;
        [FieldOffset(0xDF5)] public bool shipTargetEnables__arr5;
        [FieldOffset(0xDF8)] public float underwaterAnimRatio;
        [FieldOffset(0xE00)] public BossMetaloverloadFixedCamera shipThrowingCamera;
        [FieldOffset(0xE40)] public float shipThrowingCameraDelay;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct BossMetaloverloadPhase2ShotParam
    {
        [FieldOffset(0x00)] public int reflectMaxCount;
        [FieldOffset(0x04)] public int reflectMaxCountByHard;
        [FieldOffset(0x08)] public int blowHitDamagePoint;
        [FieldOffset(0x0C)] public float speed;
        [FieldOffset(0x10)] public float shotOffset;
        [FieldOffset(0x14)] public float addSpeedBoss;
        [FieldOffset(0x18)] public float addSpeedBossByHard;
        [FieldOffset(0x1C)] public float addSpeedPlyer;
        [FieldOffset(0x20)] public float scale;
        [FieldOffset(0x24)] public float homingParam;
        [FieldOffset(0x28)] public int knokbackRingNum;
        [FieldOffset(0x2C)] public int breakRingNum;
        [FieldOffset(0x30)] public bool firstInputGuideDisplay;
        [FieldOffset(0x40)] public BossMetaloverloadSVCameraExtensionParam cameraEx;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1A60)]
    public struct BossMetaloverloadPhase2Param
    {
        [FieldOffset(0x00)] public BossSVCameraParam mainCamera;
        [FieldOffset(0xE0)] public BossMetaloverloadPhase2WaterFlowParam waterFlow;
        [FieldOffset(0x114)] public BossMetaloverloadPhase2ThornballParam thornball;
        [FieldOffset(0x178)] public BossMetaloverloadPhase2MoveRingParam thornballEx;
        [FieldOffset(0x210)] public BossMetaloverloadPhase2MissileParam missile;
        [FieldOffset(0xAE0)] public BossMetaloverloadPhase2ThrowingParam throwing;
        [FieldOffset(0x1930)] public BossMetaloverloadPhase2ShotParam shot;
        [FieldOffset(0x19C0)] public BossMetaloverloadPhase2MoveRingParam ring;
        [FieldOffset(0x1A54)] public int bigDamageRaction;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x6210)]
    public struct BossMetaloverloadConfig
    {
        [FieldOffset(0x00)] public BossMetaloverloadCommonParam commonParam;
        [FieldOffset(0x710)] public BossMetaloverloadPhaseParam phaseParam__arr0;
        [FieldOffset(0x181C)] public BossMetaloverloadPhaseParam phaseParam__arr1;
        [FieldOffset(0x2930)] public BossMetaloverloadPhase1Param phase1;
        [FieldOffset(0x47B0)] public BossMetaloverloadPhase2Param phase2;
    }

}