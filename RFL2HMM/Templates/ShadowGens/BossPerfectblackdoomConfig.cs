Library "BossPerfectblackdoomConfig"
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
    public struct BossPerfectblackdoomSwitchLayerData
    {
        [FieldOffset(0x00)] public UnmanagedString layerName;
        [FieldOffset(0x10)] public int phase;
        [FieldOffset(0x14)] public int lifeMin;
        [FieldOffset(0x18)] public int lifeMax;
        [FieldOffset(0x20)] public UnmanagedString tag;
        [FieldOffset(0x30)] public bool isChangePhaseEnable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x708)]
    public struct BossPerfectblackdoomCommonParam
    {
        [FieldOffset(0x00)] public float upperRotSpeed;
        [FieldOffset(0x04)] public float upperResetRotSpeed;
        [FieldOffset(0x08)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr0;
        [FieldOffset(0x40)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr1;
        [FieldOffset(0x78)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr2;
        [FieldOffset(0xB0)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr3;
        [FieldOffset(0xE8)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr4;
        [FieldOffset(0x120)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr5;
        [FieldOffset(0x158)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr6;
        [FieldOffset(0x190)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr7;
        [FieldOffset(0x1C8)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr8;
        [FieldOffset(0x200)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr9;
        [FieldOffset(0x238)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr10;
        [FieldOffset(0x270)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr11;
        [FieldOffset(0x2A8)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr12;
        [FieldOffset(0x2E0)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr13;
        [FieldOffset(0x318)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr14;
        [FieldOffset(0x350)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr15;
        [FieldOffset(0x388)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr16;
        [FieldOffset(0x3C0)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr17;
        [FieldOffset(0x3F8)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr18;
        [FieldOffset(0x430)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr19;
        [FieldOffset(0x468)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr20;
        [FieldOffset(0x4A0)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr21;
        [FieldOffset(0x4D8)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr22;
        [FieldOffset(0x510)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr23;
        [FieldOffset(0x548)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr24;
        [FieldOffset(0x580)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr25;
        [FieldOffset(0x5B8)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr26;
        [FieldOffset(0x5F0)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr27;
        [FieldOffset(0x628)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr28;
        [FieldOffset(0x660)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr29;
        [FieldOffset(0x698)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr30;
        [FieldOffset(0x6D0)] public BossPerfectblackdoomSwitchLayerData switchLayers__arr31;
    }

    public enum ActionType : sbyte
    {
        INVALID_ACTION = 0,
        PHASE2_IDLE = 1,
        PHASE2_ATTACK_FIREBEAM = 2,
        PHASE2_ATTACK_FIREBOMB = 3,
        PHASE3_IDLE = 4,
        ACTION_TYPE_NUM = 5
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct BossPerfectblackdoomActionData
    {
        [FieldOffset(0x00)] public ActionType actionType;
        [FieldOffset(0x04)] public float time;
        [FieldOffset(0x08)] public int successSkip;
        [FieldOffset(0x0C)] public int patternIndex;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x614)]
    public struct BossPerfectblackdoomPhaseParam
    {
        [FieldOffset(0x00)] public int lifeCount;
        [FieldOffset(0x04)] public int healthPoint;
        [FieldOffset(0x08)] public BossPerfectblackdoomActionData actionTable1__arr0;
        [FieldOffset(0x18)] public BossPerfectblackdoomActionData actionTable1__arr1;
        [FieldOffset(0x28)] public BossPerfectblackdoomActionData actionTable1__arr2;
        [FieldOffset(0x38)] public BossPerfectblackdoomActionData actionTable1__arr3;
        [FieldOffset(0x48)] public BossPerfectblackdoomActionData actionTable1__arr4;
        [FieldOffset(0x58)] public BossPerfectblackdoomActionData actionTable1__arr5;
        [FieldOffset(0x68)] public BossPerfectblackdoomActionData actionTable1__arr6;
        [FieldOffset(0x78)] public BossPerfectblackdoomActionData actionTable1__arr7;
        [FieldOffset(0x88)] public BossPerfectblackdoomActionData actionTable1__arr8;
        [FieldOffset(0x98)] public BossPerfectblackdoomActionData actionTable1__arr9;
        [FieldOffset(0xA8)] public BossPerfectblackdoomActionData actionTable1__arr10;
        [FieldOffset(0xB8)] public BossPerfectblackdoomActionData actionTable1__arr11;
        [FieldOffset(0xC8)] public BossPerfectblackdoomActionData actionTable1__arr12;
        [FieldOffset(0xD8)] public BossPerfectblackdoomActionData actionTable1__arr13;
        [FieldOffset(0xE8)] public BossPerfectblackdoomActionData actionTable1__arr14;
        [FieldOffset(0xF8)] public BossPerfectblackdoomActionData actionTable1__arr15;
        [FieldOffset(0x108)] public BossPerfectblackdoomActionData actionTable1__arr16;
        [FieldOffset(0x118)] public BossPerfectblackdoomActionData actionTable1__arr17;
        [FieldOffset(0x128)] public BossPerfectblackdoomActionData actionTable1__arr18;
        [FieldOffset(0x138)] public BossPerfectblackdoomActionData actionTable1__arr19;
        [FieldOffset(0x148)] public BossPerfectblackdoomActionData actionTable1__arr20;
        [FieldOffset(0x158)] public BossPerfectblackdoomActionData actionTable1__arr21;
        [FieldOffset(0x168)] public BossPerfectblackdoomActionData actionTable1__arr22;
        [FieldOffset(0x178)] public BossPerfectblackdoomActionData actionTable1__arr23;
        [FieldOffset(0x188)] public BossPerfectblackdoomActionData actionTable2__arr0;
        [FieldOffset(0x198)] public BossPerfectblackdoomActionData actionTable2__arr1;
        [FieldOffset(0x1A8)] public BossPerfectblackdoomActionData actionTable2__arr2;
        [FieldOffset(0x1B8)] public BossPerfectblackdoomActionData actionTable2__arr3;
        [FieldOffset(0x1C8)] public BossPerfectblackdoomActionData actionTable2__arr4;
        [FieldOffset(0x1D8)] public BossPerfectblackdoomActionData actionTable2__arr5;
        [FieldOffset(0x1E8)] public BossPerfectblackdoomActionData actionTable2__arr6;
        [FieldOffset(0x1F8)] public BossPerfectblackdoomActionData actionTable2__arr7;
        [FieldOffset(0x208)] public BossPerfectblackdoomActionData actionTable2__arr8;
        [FieldOffset(0x218)] public BossPerfectblackdoomActionData actionTable2__arr9;
        [FieldOffset(0x228)] public BossPerfectblackdoomActionData actionTable2__arr10;
        [FieldOffset(0x238)] public BossPerfectblackdoomActionData actionTable2__arr11;
        [FieldOffset(0x248)] public BossPerfectblackdoomActionData actionTable2__arr12;
        [FieldOffset(0x258)] public BossPerfectblackdoomActionData actionTable2__arr13;
        [FieldOffset(0x268)] public BossPerfectblackdoomActionData actionTable2__arr14;
        [FieldOffset(0x278)] public BossPerfectblackdoomActionData actionTable2__arr15;
        [FieldOffset(0x288)] public BossPerfectblackdoomActionData actionTable2__arr16;
        [FieldOffset(0x298)] public BossPerfectblackdoomActionData actionTable2__arr17;
        [FieldOffset(0x2A8)] public BossPerfectblackdoomActionData actionTable2__arr18;
        [FieldOffset(0x2B8)] public BossPerfectblackdoomActionData actionTable2__arr19;
        [FieldOffset(0x2C8)] public BossPerfectblackdoomActionData actionTable2__arr20;
        [FieldOffset(0x2D8)] public BossPerfectblackdoomActionData actionTable2__arr21;
        [FieldOffset(0x2E8)] public BossPerfectblackdoomActionData actionTable2__arr22;
        [FieldOffset(0x2F8)] public BossPerfectblackdoomActionData actionTable2__arr23;
        [FieldOffset(0x308)] public BossPerfectblackdoomActionData actionTable3__arr0;
        [FieldOffset(0x318)] public BossPerfectblackdoomActionData actionTable3__arr1;
        [FieldOffset(0x328)] public BossPerfectblackdoomActionData actionTable3__arr2;
        [FieldOffset(0x338)] public BossPerfectblackdoomActionData actionTable3__arr3;
        [FieldOffset(0x348)] public BossPerfectblackdoomActionData actionTable3__arr4;
        [FieldOffset(0x358)] public BossPerfectblackdoomActionData actionTable3__arr5;
        [FieldOffset(0x368)] public BossPerfectblackdoomActionData actionTable3__arr6;
        [FieldOffset(0x378)] public BossPerfectblackdoomActionData actionTable3__arr7;
        [FieldOffset(0x388)] public BossPerfectblackdoomActionData actionTable3__arr8;
        [FieldOffset(0x398)] public BossPerfectblackdoomActionData actionTable3__arr9;
        [FieldOffset(0x3A8)] public BossPerfectblackdoomActionData actionTable3__arr10;
        [FieldOffset(0x3B8)] public BossPerfectblackdoomActionData actionTable3__arr11;
        [FieldOffset(0x3C8)] public BossPerfectblackdoomActionData actionTable3__arr12;
        [FieldOffset(0x3D8)] public BossPerfectblackdoomActionData actionTable3__arr13;
        [FieldOffset(0x3E8)] public BossPerfectblackdoomActionData actionTable3__arr14;
        [FieldOffset(0x3F8)] public BossPerfectblackdoomActionData actionTable3__arr15;
        [FieldOffset(0x408)] public BossPerfectblackdoomActionData actionTable3__arr16;
        [FieldOffset(0x418)] public BossPerfectblackdoomActionData actionTable3__arr17;
        [FieldOffset(0x428)] public BossPerfectblackdoomActionData actionTable3__arr18;
        [FieldOffset(0x438)] public BossPerfectblackdoomActionData actionTable3__arr19;
        [FieldOffset(0x448)] public BossPerfectblackdoomActionData actionTable3__arr20;
        [FieldOffset(0x458)] public BossPerfectblackdoomActionData actionTable3__arr21;
        [FieldOffset(0x468)] public BossPerfectblackdoomActionData actionTable3__arr22;
        [FieldOffset(0x478)] public BossPerfectblackdoomActionData actionTable3__arr23;
        [FieldOffset(0x488)] public BossPerfectblackdoomActionData actionTable4__arr0;
        [FieldOffset(0x498)] public BossPerfectblackdoomActionData actionTable4__arr1;
        [FieldOffset(0x4A8)] public BossPerfectblackdoomActionData actionTable4__arr2;
        [FieldOffset(0x4B8)] public BossPerfectblackdoomActionData actionTable4__arr3;
        [FieldOffset(0x4C8)] public BossPerfectblackdoomActionData actionTable4__arr4;
        [FieldOffset(0x4D8)] public BossPerfectblackdoomActionData actionTable4__arr5;
        [FieldOffset(0x4E8)] public BossPerfectblackdoomActionData actionTable4__arr6;
        [FieldOffset(0x4F8)] public BossPerfectblackdoomActionData actionTable4__arr7;
        [FieldOffset(0x508)] public BossPerfectblackdoomActionData actionTable4__arr8;
        [FieldOffset(0x518)] public BossPerfectblackdoomActionData actionTable4__arr9;
        [FieldOffset(0x528)] public BossPerfectblackdoomActionData actionTable4__arr10;
        [FieldOffset(0x538)] public BossPerfectblackdoomActionData actionTable4__arr11;
        [FieldOffset(0x548)] public BossPerfectblackdoomActionData actionTable4__arr12;
        [FieldOffset(0x558)] public BossPerfectblackdoomActionData actionTable4__arr13;
        [FieldOffset(0x568)] public BossPerfectblackdoomActionData actionTable4__arr14;
        [FieldOffset(0x578)] public BossPerfectblackdoomActionData actionTable4__arr15;
        [FieldOffset(0x588)] public BossPerfectblackdoomActionData actionTable4__arr16;
        [FieldOffset(0x598)] public BossPerfectblackdoomActionData actionTable4__arr17;
        [FieldOffset(0x5A8)] public BossPerfectblackdoomActionData actionTable4__arr18;
        [FieldOffset(0x5B8)] public BossPerfectblackdoomActionData actionTable4__arr19;
        [FieldOffset(0x5C8)] public BossPerfectblackdoomActionData actionTable4__arr20;
        [FieldOffset(0x5D8)] public BossPerfectblackdoomActionData actionTable4__arr21;
        [FieldOffset(0x5E8)] public BossPerfectblackdoomActionData actionTable4__arr22;
        [FieldOffset(0x5F8)] public BossPerfectblackdoomActionData actionTable4__arr23;
        [FieldOffset(0x608)] public int useActTblHealthPoint1;
        [FieldOffset(0x60C)] public int useActTblHealthPoint2;
        [FieldOffset(0x610)] public int useActTblHealthPoint3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1948)]
    public struct BossPerfectblackdoomConfig
    {
        [FieldOffset(0x00)] public BossPerfectblackdoomCommonParam commonParam;
        [FieldOffset(0x708)] public BossPerfectblackdoomPhaseParam phaseParam__arr0;
        [FieldOffset(0xD1C)] public BossPerfectblackdoomPhaseParam phaseParam__arr1;
        [FieldOffset(0x1330)] public BossPerfectblackdoomPhaseParam phaseParam__arr2;
    }

}