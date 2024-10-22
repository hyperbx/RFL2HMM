Library "GameHitStopParameter"
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

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct GameHitStopParameterData
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public float scale;
        [FieldOffset(0x14)] public float time;
        [FieldOffset(0x18)] public float easeOutTime;
        [FieldOffset(0x1C)] public float delayTime;
        [FieldOffset(0x20)] public bool layerPlayer;
        [FieldOffset(0x21)] public bool layerEnemy;
        [FieldOffset(0x22)] public bool layerDamagedEnemy;
        [FieldOffset(0x23)] public bool layerGimmick;
        [FieldOffset(0x24)] public bool layerCamera;
        [FieldOffset(0x25)] public bool layerOthers;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA00)]
    public struct GameHitStopParameter
    {
        [FieldOffset(0x00)] public GameHitStopParameterData data__arr0;
        [FieldOffset(0x28)] public GameHitStopParameterData data__arr1;
        [FieldOffset(0x50)] public GameHitStopParameterData data__arr2;
        [FieldOffset(0x78)] public GameHitStopParameterData data__arr3;
        [FieldOffset(0xA0)] public GameHitStopParameterData data__arr4;
        [FieldOffset(0xC8)] public GameHitStopParameterData data__arr5;
        [FieldOffset(0xF0)] public GameHitStopParameterData data__arr6;
        [FieldOffset(0x118)] public GameHitStopParameterData data__arr7;
        [FieldOffset(0x140)] public GameHitStopParameterData data__arr8;
        [FieldOffset(0x168)] public GameHitStopParameterData data__arr9;
        [FieldOffset(0x190)] public GameHitStopParameterData data__arr10;
        [FieldOffset(0x1B8)] public GameHitStopParameterData data__arr11;
        [FieldOffset(0x1E0)] public GameHitStopParameterData data__arr12;
        [FieldOffset(0x208)] public GameHitStopParameterData data__arr13;
        [FieldOffset(0x230)] public GameHitStopParameterData data__arr14;
        [FieldOffset(0x258)] public GameHitStopParameterData data__arr15;
        [FieldOffset(0x280)] public GameHitStopParameterData data__arr16;
        [FieldOffset(0x2A8)] public GameHitStopParameterData data__arr17;
        [FieldOffset(0x2D0)] public GameHitStopParameterData data__arr18;
        [FieldOffset(0x2F8)] public GameHitStopParameterData data__arr19;
        [FieldOffset(0x320)] public GameHitStopParameterData data__arr20;
        [FieldOffset(0x348)] public GameHitStopParameterData data__arr21;
        [FieldOffset(0x370)] public GameHitStopParameterData data__arr22;
        [FieldOffset(0x398)] public GameHitStopParameterData data__arr23;
        [FieldOffset(0x3C0)] public GameHitStopParameterData data__arr24;
        [FieldOffset(0x3E8)] public GameHitStopParameterData data__arr25;
        [FieldOffset(0x410)] public GameHitStopParameterData data__arr26;
        [FieldOffset(0x438)] public GameHitStopParameterData data__arr27;
        [FieldOffset(0x460)] public GameHitStopParameterData data__arr28;
        [FieldOffset(0x488)] public GameHitStopParameterData data__arr29;
        [FieldOffset(0x4B0)] public GameHitStopParameterData data__arr30;
        [FieldOffset(0x4D8)] public GameHitStopParameterData data__arr31;
        [FieldOffset(0x500)] public GameHitStopParameterData data__arr32;
        [FieldOffset(0x528)] public GameHitStopParameterData data__arr33;
        [FieldOffset(0x550)] public GameHitStopParameterData data__arr34;
        [FieldOffset(0x578)] public GameHitStopParameterData data__arr35;
        [FieldOffset(0x5A0)] public GameHitStopParameterData data__arr36;
        [FieldOffset(0x5C8)] public GameHitStopParameterData data__arr37;
        [FieldOffset(0x5F0)] public GameHitStopParameterData data__arr38;
        [FieldOffset(0x618)] public GameHitStopParameterData data__arr39;
        [FieldOffset(0x640)] public GameHitStopParameterData data__arr40;
        [FieldOffset(0x668)] public GameHitStopParameterData data__arr41;
        [FieldOffset(0x690)] public GameHitStopParameterData data__arr42;
        [FieldOffset(0x6B8)] public GameHitStopParameterData data__arr43;
        [FieldOffset(0x6E0)] public GameHitStopParameterData data__arr44;
        [FieldOffset(0x708)] public GameHitStopParameterData data__arr45;
        [FieldOffset(0x730)] public GameHitStopParameterData data__arr46;
        [FieldOffset(0x758)] public GameHitStopParameterData data__arr47;
        [FieldOffset(0x780)] public GameHitStopParameterData data__arr48;
        [FieldOffset(0x7A8)] public GameHitStopParameterData data__arr49;
        [FieldOffset(0x7D0)] public GameHitStopParameterData data__arr50;
        [FieldOffset(0x7F8)] public GameHitStopParameterData data__arr51;
        [FieldOffset(0x820)] public GameHitStopParameterData data__arr52;
        [FieldOffset(0x848)] public GameHitStopParameterData data__arr53;
        [FieldOffset(0x870)] public GameHitStopParameterData data__arr54;
        [FieldOffset(0x898)] public GameHitStopParameterData data__arr55;
        [FieldOffset(0x8C0)] public GameHitStopParameterData data__arr56;
        [FieldOffset(0x8E8)] public GameHitStopParameterData data__arr57;
        [FieldOffset(0x910)] public GameHitStopParameterData data__arr58;
        [FieldOffset(0x938)] public GameHitStopParameterData data__arr59;
        [FieldOffset(0x960)] public GameHitStopParameterData data__arr60;
        [FieldOffset(0x988)] public GameHitStopParameterData data__arr61;
        [FieldOffset(0x9B0)] public GameHitStopParameterData data__arr62;
        [FieldOffset(0x9D8)] public GameHitStopParameterData data__arr63;
    }

}