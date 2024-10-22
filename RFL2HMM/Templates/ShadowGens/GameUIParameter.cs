Library "GameUIParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct GameUIBoostParam
    {
        [FieldOffset(0x00)] public float lossAnimRatio;
        [FieldOffset(0x04)] public float useAnimRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct GameUICursorParam
    {
        [FieldOffset(0x00)] public float targetCursorOffsetY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct WhiteSpaceStageUIModelParam
    {
        [FieldOffset(0x00)] public Vector3 modelPos;
        [FieldOffset(0x10)] public Vector3 cameraPos;
        [FieldOffset(0x20)] public Vector3 cameraTarget;
        [FieldOffset(0x30)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct WhiteSpaceStageUI
    {
        [FieldOffset(0x00)] public WhiteSpaceStageUIModelParam modelParam;
        [FieldOffset(0x40)] public WhiteSpaceStageUIModelParam dwingModelParam;
    }

    public enum OpenState : int
    {
        Locked = 0,
        Opened = 1
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

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct WhiteSpaceQAPage
    {
        [FieldOffset(0x00)] public UnmanagedString headerLabel;
        [FieldOffset(0x10)] public UnmanagedString textLabel;
        [FieldOffset(0x20)] public UnmanagedString movieName;
        [FieldOffset(0x30)] public UnmanagedString textureName;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x148)]
    public struct WhiteSpaceQAInfo
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public OpenState openState;
        [FieldOffset(0x08)] public WhiteSpaceQAPage pages__arr0;
        [FieldOffset(0x48)] public WhiteSpaceQAPage pages__arr1;
        [FieldOffset(0x88)] public WhiteSpaceQAPage pages__arr2;
        [FieldOffset(0xC8)] public WhiteSpaceQAPage pages__arr3;
        [FieldOffset(0x108)] public WhiteSpaceQAPage pages__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3340)]
    public struct WhiteSpaceQAParamter
    {
        [FieldOffset(0x00)] public WhiteSpaceQAInfo infos__arr0;
        [FieldOffset(0x148)] public WhiteSpaceQAInfo infos__arr1;
        [FieldOffset(0x290)] public WhiteSpaceQAInfo infos__arr2;
        [FieldOffset(0x3D8)] public WhiteSpaceQAInfo infos__arr3;
        [FieldOffset(0x520)] public WhiteSpaceQAInfo infos__arr4;
        [FieldOffset(0x668)] public WhiteSpaceQAInfo infos__arr5;
        [FieldOffset(0x7B0)] public WhiteSpaceQAInfo infos__arr6;
        [FieldOffset(0x8F8)] public WhiteSpaceQAInfo infos__arr7;
        [FieldOffset(0xA40)] public WhiteSpaceQAInfo infos__arr8;
        [FieldOffset(0xB88)] public WhiteSpaceQAInfo infos__arr9;
        [FieldOffset(0xCD0)] public WhiteSpaceQAInfo infos__arr10;
        [FieldOffset(0xE18)] public WhiteSpaceQAInfo infos__arr11;
        [FieldOffset(0xF60)] public WhiteSpaceQAInfo infos__arr12;
        [FieldOffset(0x10A8)] public WhiteSpaceQAInfo infos__arr13;
        [FieldOffset(0x11F0)] public WhiteSpaceQAInfo infos__arr14;
        [FieldOffset(0x1338)] public WhiteSpaceQAInfo infos__arr15;
        [FieldOffset(0x1480)] public WhiteSpaceQAInfo infos__arr16;
        [FieldOffset(0x15C8)] public WhiteSpaceQAInfo infos__arr17;
        [FieldOffset(0x1710)] public WhiteSpaceQAInfo infos__arr18;
        [FieldOffset(0x1858)] public WhiteSpaceQAInfo infos__arr19;
        [FieldOffset(0x19A0)] public WhiteSpaceQAInfo infos__arr20;
        [FieldOffset(0x1AE8)] public WhiteSpaceQAInfo infos__arr21;
        [FieldOffset(0x1C30)] public WhiteSpaceQAInfo infos__arr22;
        [FieldOffset(0x1D78)] public WhiteSpaceQAInfo infos__arr23;
        [FieldOffset(0x1EC0)] public WhiteSpaceQAInfo infos__arr24;
        [FieldOffset(0x2008)] public WhiteSpaceQAInfo infos__arr25;
        [FieldOffset(0x2150)] public WhiteSpaceQAInfo infos__arr26;
        [FieldOffset(0x2298)] public WhiteSpaceQAInfo infos__arr27;
        [FieldOffset(0x23E0)] public WhiteSpaceQAInfo infos__arr28;
        [FieldOffset(0x2528)] public WhiteSpaceQAInfo infos__arr29;
        [FieldOffset(0x2670)] public WhiteSpaceQAInfo infos__arr30;
        [FieldOffset(0x27B8)] public WhiteSpaceQAInfo infos__arr31;
        [FieldOffset(0x2900)] public WhiteSpaceQAInfo infos__arr32;
        [FieldOffset(0x2A48)] public WhiteSpaceQAInfo infos__arr33;
        [FieldOffset(0x2B90)] public WhiteSpaceQAInfo infos__arr34;
        [FieldOffset(0x2CD8)] public WhiteSpaceQAInfo infos__arr35;
        [FieldOffset(0x2E20)] public WhiteSpaceQAInfo infos__arr36;
        [FieldOffset(0x2F68)] public WhiteSpaceQAInfo infos__arr37;
        [FieldOffset(0x30B0)] public WhiteSpaceQAInfo infos__arr38;
        [FieldOffset(0x31F8)] public WhiteSpaceQAInfo infos__arr39;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct WhiteSpaceMapUI
    {
        [FieldOffset(0x00)] public float mapZoomScale;
        [FieldOffset(0x04)] public float mapUnderGroundZoomScale;
        [FieldOffset(0x08)] public float mapScale;
        [FieldOffset(0x0C)] public float mapZoomAnimRatio;
        [FieldOffset(0x10)] public float mapZoomRangeX;
        [FieldOffset(0x14)] public float mapZoomRangeY;
        [FieldOffset(0x20)] public Vector3 mapUnderGroundPos;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3400)]
    public struct GameUIWhiteSpaceParam
    {
        [FieldOffset(0x00)] public float itemInfoTimer;
        [FieldOffset(0x10)] public WhiteSpaceStageUI stageUIParam;
        [FieldOffset(0x90)] public WhiteSpaceQAParamter qaParam;
        [FieldOffset(0x33D0)] public WhiteSpaceMapUI mapParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3410)]
    public struct GameUIParameter
    {
        [FieldOffset(0x00)] public GameUIBoostParam boostParam;
        [FieldOffset(0x08)] public GameUICursorParam cursorParam;
        [FieldOffset(0x10)] public GameUIWhiteSpaceParam whiteSpaceParam;
    }

}