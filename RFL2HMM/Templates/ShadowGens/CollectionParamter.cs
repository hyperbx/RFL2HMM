Library "CollectionParamter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum OpenState : int
    {
        Locked = 0,
        LockedCollectionBox = 1,
        Opened = 2,
        DLC_DDX = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct CollectionItemInfo
    {
        [FieldOffset(0x00)] public bool isEnable;
        [FieldOffset(0x04)] public OpenState openState;
        [FieldOffset(0x08)] public int textLabelNumber;
        [FieldOffset(0x0C)] public int textureNumber;
        [FieldOffset(0x10)] public int objNumber;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct CollectionArtInfo
    {
        [FieldOffset(0x00)] public CollectionItemInfo info;
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

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct CollectionSoundInfo
    {
        [FieldOffset(0x00)] public CollectionItemInfo info;
        [FieldOffset(0x18)] public UnmanagedString assetName;
        [FieldOffset(0x28)] public int playTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct CollectionMovieInfo
    {
        [FieldOffset(0x00)] public CollectionItemInfo info;
        [FieldOffset(0x18)] public UnmanagedString assetName;
        [FieldOffset(0x28)] public bool isEclipseMode;
        [FieldOffset(0x2C)] public int wsLevel;
        [FieldOffset(0x30)] public int eyeCount;
        [FieldOffset(0x34)] public bool fps30;
    }

    public enum CollectionCharaKind : int
    {
        CollectionCharaKindShadow = 0,
        CollectionCharaKindOmega = 1,
        CollectionCharaKindBig = 2,
        CollectionCharaKindMaria = 3,
        CollectionCharaKindGerald = 4,
        CollectionCharaKindOrbot = 5,
        CollectionCharaKindCubot = 6,
        CollectionCharaKindNum = 7,
        CollectionCharaKindNone = -1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct CollectionCharacterInfo
    {
        [FieldOffset(0x00)] public CollectionItemInfo info;
        [FieldOffset(0x14)] public CollectionCharaKind charaKind;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct CollectionHistoryInfo
    {
        [FieldOffset(0x00)] public CollectionItemInfo info;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct CollectionGeraldNoteInfo
    {
        [FieldOffset(0x00)] public CollectionItemInfo info;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct CollectionCharacterModelParam
    {
        [FieldOffset(0x00)] public Vector3 modelPos;
        [FieldOffset(0x10)] public Vector3 cameraPos;
        [FieldOffset(0x20)] public Vector3 cameraTarget;
        [FieldOffset(0x30)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1D0)]
    public struct CollectionCharacterMenuParam
    {
        [FieldOffset(0x00)] public float turnSpeed;
        [FieldOffset(0x10)] public CollectionCharacterModelParam charaModelParams__arr0;
        [FieldOffset(0x50)] public CollectionCharacterModelParam charaModelParams__arr1;
        [FieldOffset(0x90)] public CollectionCharacterModelParam charaModelParams__arr2;
        [FieldOffset(0xD0)] public CollectionCharacterModelParam charaModelParams__arr3;
        [FieldOffset(0x110)] public CollectionCharacterModelParam charaModelParams__arr4;
        [FieldOffset(0x150)] public CollectionCharacterModelParam charaModelParams__arr5;
        [FieldOffset(0x190)] public CollectionCharacterModelParam charaModelParams__arr6;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct CollectionRoomPlayerAction
    {
        [FieldOffset(0x00)] public float moveSpeed;
        [FieldOffset(0x04)] public float tolerance;
        [FieldOffset(0x08)] public float chairTolerance;
        [FieldOffset(0x0C)] public float chairStartWaitTime;
        [FieldOffset(0x10)] public float chairStartMoveTime;
        [FieldOffset(0x14)] public float chairStartPosOffsetY;
        [FieldOffset(0x18)] public float chairEndWaitTime;
        [FieldOffset(0x1C)] public float chairEndMoveTime;
        [FieldOffset(0x20)] public float chairEndMoveDistance;
        [FieldOffset(0x24)] public float bikeTolerance;
        [FieldOffset(0x28)] public float bikeStartWaitTime;
        [FieldOffset(0x2C)] public float bikeStartMoveTime;
        [FieldOffset(0x30)] public float bikeStartMenuOpenWait;
        [FieldOffset(0x34)] public float bikeStartPosOffsetY;
        [FieldOffset(0x38)] public float bikeEndWaitTime;
        [FieldOffset(0x3C)] public float bikeEndMoveTime;
        [FieldOffset(0x40)] public float bikeEndMoveDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct CollectionGeraldNotePlayer
    {
        [FieldOffset(0x00)] public float moveSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct CollectionRoomCamera
    {
        [FieldOffset(0x00)] public float beginInterpolateTime;
        [FieldOffset(0x04)] public float endInterpolateTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct CollectionSoundMenuParam
    {
        [FieldOffset(0x00)] public float endFadeTime;
        [FieldOffset(0x04)] public float endWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28D0)]
    public struct CollectionParamter
    {
        [FieldOffset(0x00)] public CollectionArtInfo artInfos__arr0;
        [FieldOffset(0x14)] public CollectionArtInfo artInfos__arr1;
        [FieldOffset(0x28)] public CollectionArtInfo artInfos__arr2;
        [FieldOffset(0x3C)] public CollectionArtInfo artInfos__arr3;
        [FieldOffset(0x50)] public CollectionArtInfo artInfos__arr4;
        [FieldOffset(0x64)] public CollectionArtInfo artInfos__arr5;
        [FieldOffset(0x78)] public CollectionArtInfo artInfos__arr6;
        [FieldOffset(0x8C)] public CollectionArtInfo artInfos__arr7;
        [FieldOffset(0xA0)] public CollectionArtInfo artInfos__arr8;
        [FieldOffset(0xB4)] public CollectionArtInfo artInfos__arr9;
        [FieldOffset(0xC8)] public CollectionArtInfo artInfos__arr10;
        [FieldOffset(0xDC)] public CollectionArtInfo artInfos__arr11;
        [FieldOffset(0xF0)] public CollectionArtInfo artInfos__arr12;
        [FieldOffset(0x104)] public CollectionArtInfo artInfos__arr13;
        [FieldOffset(0x118)] public CollectionArtInfo artInfos__arr14;
        [FieldOffset(0x12C)] public CollectionArtInfo artInfos__arr15;
        [FieldOffset(0x140)] public CollectionArtInfo artInfos__arr16;
        [FieldOffset(0x154)] public CollectionArtInfo artInfos__arr17;
        [FieldOffset(0x168)] public CollectionArtInfo artInfos__arr18;
        [FieldOffset(0x17C)] public CollectionArtInfo artInfos__arr19;
        [FieldOffset(0x190)] public CollectionArtInfo artInfos__arr20;
        [FieldOffset(0x1A4)] public CollectionArtInfo artInfos__arr21;
        [FieldOffset(0x1B8)] public CollectionArtInfo artInfos__arr22;
        [FieldOffset(0x1CC)] public CollectionArtInfo artInfos__arr23;
        [FieldOffset(0x1E0)] public CollectionArtInfo artInfos__arr24;
        [FieldOffset(0x1F4)] public CollectionArtInfo artInfos__arr25;
        [FieldOffset(0x208)] public CollectionArtInfo artInfos__arr26;
        [FieldOffset(0x21C)] public CollectionArtInfo artInfos__arr27;
        [FieldOffset(0x230)] public CollectionArtInfo artInfos__arr28;
        [FieldOffset(0x244)] public CollectionArtInfo artInfos__arr29;
        [FieldOffset(0x258)] public CollectionArtInfo artInfos__arr30;
        [FieldOffset(0x26C)] public CollectionArtInfo artInfos__arr31;
        [FieldOffset(0x280)] public CollectionArtInfo artInfos__arr32;
        [FieldOffset(0x294)] public CollectionArtInfo artInfos__arr33;
        [FieldOffset(0x2A8)] public CollectionArtInfo artInfos__arr34;
        [FieldOffset(0x2BC)] public CollectionArtInfo artInfos__arr35;
        [FieldOffset(0x2D0)] public CollectionArtInfo artInfos__arr36;
        [FieldOffset(0x2E4)] public CollectionArtInfo artInfos__arr37;
        [FieldOffset(0x2F8)] public CollectionArtInfo artInfos__arr38;
        [FieldOffset(0x30C)] public CollectionArtInfo artInfos__arr39;
        [FieldOffset(0x320)] public CollectionArtInfo artInfos__arr40;
        [FieldOffset(0x334)] public CollectionArtInfo artInfos__arr41;
        [FieldOffset(0x348)] public CollectionArtInfo artInfos__arr42;
        [FieldOffset(0x35C)] public CollectionArtInfo artInfos__arr43;
        [FieldOffset(0x370)] public CollectionArtInfo artInfos__arr44;
        [FieldOffset(0x384)] public CollectionArtInfo artInfos__arr45;
        [FieldOffset(0x398)] public CollectionArtInfo artInfos__arr46;
        [FieldOffset(0x3AC)] public CollectionArtInfo artInfos__arr47;
        [FieldOffset(0x3C0)] public CollectionArtInfo artInfos__arr48;
        [FieldOffset(0x3D4)] public CollectionArtInfo artInfos__arr49;
        [FieldOffset(0x3E8)] public CollectionArtInfo artInfos__arr50;
        [FieldOffset(0x3FC)] public CollectionArtInfo artInfos__arr51;
        [FieldOffset(0x410)] public CollectionArtInfo artInfos__arr52;
        [FieldOffset(0x424)] public CollectionArtInfo artInfos__arr53;
        [FieldOffset(0x438)] public CollectionArtInfo artInfos__arr54;
        [FieldOffset(0x44C)] public CollectionArtInfo artInfos__arr55;
        [FieldOffset(0x460)] public CollectionArtInfo artInfos__arr56;
        [FieldOffset(0x474)] public CollectionArtInfo artInfos__arr57;
        [FieldOffset(0x488)] public CollectionArtInfo artInfos__arr58;
        [FieldOffset(0x49C)] public CollectionArtInfo artInfos__arr59;
        [FieldOffset(0x4B0)] public CollectionArtInfo artInfos__arr60;
        [FieldOffset(0x4C4)] public CollectionArtInfo artInfos__arr61;
        [FieldOffset(0x4D8)] public CollectionArtInfo artInfos__arr62;
        [FieldOffset(0x4EC)] public CollectionArtInfo artInfos__arr63;
        [FieldOffset(0x500)] public CollectionArtInfo artInfos__arr64;
        [FieldOffset(0x514)] public CollectionArtInfo artInfos__arr65;
        [FieldOffset(0x528)] public CollectionArtInfo artInfos__arr66;
        [FieldOffset(0x53C)] public CollectionArtInfo artInfos__arr67;
        [FieldOffset(0x550)] public CollectionArtInfo artInfos__arr68;
        [FieldOffset(0x564)] public CollectionArtInfo artInfos__arr69;
        [FieldOffset(0x578)] public CollectionArtInfo artInfos__arr70;
        [FieldOffset(0x58C)] public CollectionArtInfo artInfos__arr71;
        [FieldOffset(0x5A0)] public CollectionArtInfo artInfos__arr72;
        [FieldOffset(0x5B4)] public CollectionArtInfo artInfos__arr73;
        [FieldOffset(0x5C8)] public CollectionArtInfo artInfos__arr74;
        [FieldOffset(0x5DC)] public CollectionArtInfo artInfos__arr75;
        [FieldOffset(0x5F0)] public CollectionArtInfo artInfos__arr76;
        [FieldOffset(0x604)] public CollectionArtInfo artInfos__arr77;
        [FieldOffset(0x618)] public CollectionArtInfo artInfos__arr78;
        [FieldOffset(0x62C)] public CollectionArtInfo artInfos__arr79;
        [FieldOffset(0x640)] public CollectionArtInfo artInfos__arr80;
        [FieldOffset(0x654)] public CollectionArtInfo artInfos__arr81;
        [FieldOffset(0x668)] public CollectionArtInfo artInfos__arr82;
        [FieldOffset(0x67C)] public CollectionArtInfo artInfos__arr83;
        [FieldOffset(0x690)] public CollectionArtInfo artInfos__arr84;
        [FieldOffset(0x6A4)] public CollectionArtInfo artInfos__arr85;
        [FieldOffset(0x6B8)] public CollectionArtInfo artInfos__arr86;
        [FieldOffset(0x6CC)] public CollectionArtInfo artInfos__arr87;
        [FieldOffset(0x6E0)] public CollectionArtInfo artInfos__arr88;
        [FieldOffset(0x6F4)] public CollectionArtInfo artInfos__arr89;
        [FieldOffset(0x708)] public CollectionArtInfo artInfos__arr90;
        [FieldOffset(0x71C)] public CollectionArtInfo artInfos__arr91;
        [FieldOffset(0x730)] public CollectionArtInfo artInfos__arr92;
        [FieldOffset(0x744)] public CollectionArtInfo artInfos__arr93;
        [FieldOffset(0x758)] public CollectionArtInfo artInfos__arr94;
        [FieldOffset(0x76C)] public CollectionArtInfo artInfos__arr95;
        [FieldOffset(0x780)] public CollectionArtInfo artInfos__arr96;
        [FieldOffset(0x794)] public CollectionArtInfo artInfos__arr97;
        [FieldOffset(0x7A8)] public CollectionArtInfo artInfos__arr98;
        [FieldOffset(0x7BC)] public CollectionArtInfo artInfos__arr99;
        [FieldOffset(0x7D0)] public CollectionArtInfo artInfos__arr100;
        [FieldOffset(0x7E4)] public CollectionArtInfo artInfos__arr101;
        [FieldOffset(0x7F8)] public CollectionArtInfo artInfos__arr102;
        [FieldOffset(0x80C)] public CollectionArtInfo artInfos__arr103;
        [FieldOffset(0x820)] public CollectionArtInfo artInfos__arr104;
        [FieldOffset(0x834)] public CollectionArtInfo artInfos__arr105;
        [FieldOffset(0x848)] public CollectionArtInfo artInfos__arr106;
        [FieldOffset(0x85C)] public CollectionArtInfo artInfos__arr107;
        [FieldOffset(0x870)] public CollectionArtInfo artInfos__arr108;
        [FieldOffset(0x884)] public CollectionArtInfo artInfos__arr109;
        [FieldOffset(0x898)] public CollectionArtInfo artInfos__arr110;
        [FieldOffset(0x8AC)] public CollectionArtInfo artInfos__arr111;
        [FieldOffset(0x8C0)] public CollectionArtInfo artInfos__arr112;
        [FieldOffset(0x8D4)] public CollectionArtInfo artInfos__arr113;
        [FieldOffset(0x8E8)] public CollectionArtInfo artInfos__arr114;
        [FieldOffset(0x8FC)] public CollectionArtInfo artInfos__arr115;
        [FieldOffset(0x910)] public CollectionArtInfo artInfos__arr116;
        [FieldOffset(0x924)] public CollectionArtInfo artInfos__arr117;
        [FieldOffset(0x938)] public CollectionArtInfo artInfos__arr118;
        [FieldOffset(0x94C)] public CollectionArtInfo artInfos__arr119;
        [FieldOffset(0x960)] public CollectionArtInfo artInfos__arr120;
        [FieldOffset(0x978)] public CollectionSoundInfo soundInfos__arr0;
        [FieldOffset(0x9A8)] public CollectionSoundInfo soundInfos__arr1;
        [FieldOffset(0x9D8)] public CollectionSoundInfo soundInfos__arr2;
        [FieldOffset(0xA08)] public CollectionSoundInfo soundInfos__arr3;
        [FieldOffset(0xA38)] public CollectionSoundInfo soundInfos__arr4;
        [FieldOffset(0xA68)] public CollectionSoundInfo soundInfos__arr5;
        [FieldOffset(0xA98)] public CollectionSoundInfo soundInfos__arr6;
        [FieldOffset(0xAC8)] public CollectionSoundInfo soundInfos__arr7;
        [FieldOffset(0xAF8)] public CollectionSoundInfo soundInfos__arr8;
        [FieldOffset(0xB28)] public CollectionSoundInfo soundInfos__arr9;
        [FieldOffset(0xB58)] public CollectionSoundInfo soundInfos__arr10;
        [FieldOffset(0xB88)] public CollectionSoundInfo soundInfos__arr11;
        [FieldOffset(0xBB8)] public CollectionSoundInfo soundInfos__arr12;
        [FieldOffset(0xBE8)] public CollectionSoundInfo soundInfos__arr13;
        [FieldOffset(0xC18)] public CollectionSoundInfo soundInfos__arr14;
        [FieldOffset(0xC48)] public CollectionSoundInfo soundInfos__arr15;
        [FieldOffset(0xC78)] public CollectionSoundInfo soundInfos__arr16;
        [FieldOffset(0xCA8)] public CollectionSoundInfo soundInfos__arr17;
        [FieldOffset(0xCD8)] public CollectionSoundInfo soundInfos__arr18;
        [FieldOffset(0xD08)] public CollectionSoundInfo soundInfos__arr19;
        [FieldOffset(0xD38)] public CollectionSoundInfo soundInfos__arr20;
        [FieldOffset(0xD68)] public CollectionSoundInfo soundInfos__arr21;
        [FieldOffset(0xD98)] public CollectionSoundInfo soundInfos__arr22;
        [FieldOffset(0xDC8)] public CollectionSoundInfo soundInfos__arr23;
        [FieldOffset(0xDF8)] public CollectionSoundInfo soundInfos__arr24;
        [FieldOffset(0xE28)] public CollectionSoundInfo soundInfos__arr25;
        [FieldOffset(0xE58)] public CollectionSoundInfo soundInfos__arr26;
        [FieldOffset(0xE88)] public CollectionSoundInfo soundInfos__arr27;
        [FieldOffset(0xEB8)] public CollectionSoundInfo soundInfos__arr28;
        [FieldOffset(0xEE8)] public CollectionSoundInfo soundInfos__arr29;
        [FieldOffset(0xF18)] public CollectionSoundInfo soundInfos__arr30;
        [FieldOffset(0xF48)] public CollectionSoundInfo soundInfos__arr31;
        [FieldOffset(0xF78)] public CollectionSoundInfo soundInfos__arr32;
        [FieldOffset(0xFA8)] public CollectionSoundInfo soundInfos__arr33;
        [FieldOffset(0xFD8)] public CollectionSoundInfo soundInfos__arr34;
        [FieldOffset(0x1008)] public CollectionSoundInfo soundInfos__arr35;
        [FieldOffset(0x1038)] public CollectionSoundInfo soundInfos__arr36;
        [FieldOffset(0x1068)] public CollectionSoundInfo soundInfos__arr37;
        [FieldOffset(0x1098)] public CollectionSoundInfo soundInfos__arr38;
        [FieldOffset(0x10C8)] public CollectionSoundInfo soundInfos__arr39;
        [FieldOffset(0x10F8)] public CollectionSoundInfo soundInfos__arr40;
        [FieldOffset(0x1128)] public CollectionSoundInfo soundInfos__arr41;
        [FieldOffset(0x1158)] public CollectionSoundInfo soundInfos__arr42;
        [FieldOffset(0x1188)] public CollectionSoundInfo soundInfos__arr43;
        [FieldOffset(0x11B8)] public CollectionSoundInfo soundInfos__arr44;
        [FieldOffset(0x11E8)] public CollectionSoundInfo soundInfos__arr45;
        [FieldOffset(0x1218)] public CollectionSoundInfo soundInfos__arr46;
        [FieldOffset(0x1248)] public CollectionSoundInfo soundInfos__arr47;
        [FieldOffset(0x1278)] public CollectionSoundInfo soundInfos__arr48;
        [FieldOffset(0x12A8)] public CollectionSoundInfo soundInfos__arr49;
        [FieldOffset(0x12D8)] public CollectionSoundInfo soundInfos__arr50;
        [FieldOffset(0x1308)] public CollectionSoundInfo soundInfos__arr51;
        [FieldOffset(0x1338)] public CollectionSoundInfo soundInfos__arr52;
        [FieldOffset(0x1368)] public CollectionSoundInfo soundInfos__arr53;
        [FieldOffset(0x1398)] public CollectionSoundInfo soundInfos__arr54;
        [FieldOffset(0x13C8)] public CollectionSoundInfo soundInfos__arr55;
        [FieldOffset(0x13F8)] public CollectionSoundInfo soundInfos__arr56;
        [FieldOffset(0x1428)] public CollectionSoundInfo soundInfos__arr57;
        [FieldOffset(0x1458)] public CollectionSoundInfo soundInfos__arr58;
        [FieldOffset(0x1488)] public CollectionSoundInfo soundInfos__arr59;
        [FieldOffset(0x14B8)] public CollectionSoundInfo soundInfos__arr60;
        [FieldOffset(0x14E8)] public CollectionSoundInfo soundInfos__arr61;
        [FieldOffset(0x1518)] public CollectionSoundInfo soundInfos__arr62;
        [FieldOffset(0x1548)] public CollectionSoundInfo soundInfos__arr63;
        [FieldOffset(0x1578)] public CollectionSoundInfo soundInfos__arr64;
        [FieldOffset(0x15A8)] public CollectionSoundInfo soundInfos__arr65;
        [FieldOffset(0x15D8)] public CollectionSoundInfo soundInfos__arr66;
        [FieldOffset(0x1608)] public CollectionSoundInfo soundInfos__arr67;
        [FieldOffset(0x1638)] public CollectionSoundInfo soundInfos__arr68;
        [FieldOffset(0x1668)] public CollectionSoundInfo soundInfos__arr69;
        [FieldOffset(0x1698)] public CollectionSoundInfo soundInfos__arr70;
        [FieldOffset(0x16C8)] public CollectionSoundInfo soundInfos__arr71;
        [FieldOffset(0x16F8)] public CollectionSoundInfo soundInfos__arr72;
        [FieldOffset(0x1728)] public CollectionSoundInfo soundInfos__arr73;
        [FieldOffset(0x1758)] public CollectionSoundInfo soundInfos__arr74;
        [FieldOffset(0x1788)] public CollectionSoundInfo soundInfos__arr75;
        [FieldOffset(0x17B8)] public CollectionSoundInfo soundInfos__arr76;
        [FieldOffset(0x17E8)] public CollectionSoundInfo soundInfos__arr77;
        [FieldOffset(0x1818)] public CollectionSoundInfo soundInfos__arr78;
        [FieldOffset(0x1848)] public CollectionSoundInfo soundInfos__arr79;
        [FieldOffset(0x1878)] public CollectionSoundInfo soundInfos__arr80;
        [FieldOffset(0x18A8)] public CollectionSoundInfo soundInfos__arr81;
        [FieldOffset(0x18D8)] public CollectionSoundInfo soundInfos__arr82;
        [FieldOffset(0x1908)] public CollectionSoundInfo soundInfos__arr83;
        [FieldOffset(0x1938)] public CollectionSoundInfo soundInfos__arr84;
        [FieldOffset(0x1968)] public CollectionSoundInfo soundInfos__arr85;
        [FieldOffset(0x1998)] public CollectionSoundInfo soundInfos__arr86;
        [FieldOffset(0x19C8)] public CollectionSoundInfo soundInfos__arr87;
        [FieldOffset(0x19F8)] public CollectionSoundInfo soundInfos__arr88;
        [FieldOffset(0x1A28)] public CollectionSoundInfo soundInfos__arr89;
        [FieldOffset(0x1A58)] public CollectionSoundInfo soundInfos__arr90;
        [FieldOffset(0x1A88)] public CollectionSoundInfo soundInfos__arr91;
        [FieldOffset(0x1AB8)] public CollectionSoundInfo soundInfos__arr92;
        [FieldOffset(0x1AE8)] public CollectionSoundInfo soundInfos__arr93;
        [FieldOffset(0x1B18)] public CollectionSoundInfo soundInfos__arr94;
        [FieldOffset(0x1B48)] public CollectionSoundInfo soundInfos__arr95;
        [FieldOffset(0x1B78)] public CollectionSoundInfo soundInfos__arr96;
        [FieldOffset(0x1BA8)] public CollectionSoundInfo soundInfos__arr97;
        [FieldOffset(0x1BD8)] public CollectionSoundInfo soundInfos__arr98;
        [FieldOffset(0x1C08)] public CollectionSoundInfo soundInfos__arr99;
        [FieldOffset(0x1C38)] public CollectionMovieInfo movieInfos__arr0;
        [FieldOffset(0x1C70)] public CollectionMovieInfo movieInfos__arr1;
        [FieldOffset(0x1CA8)] public CollectionMovieInfo movieInfos__arr2;
        [FieldOffset(0x1CE0)] public CollectionMovieInfo movieInfos__arr3;
        [FieldOffset(0x1D18)] public CollectionMovieInfo movieInfos__arr4;
        [FieldOffset(0x1D50)] public CollectionMovieInfo movieInfos__arr5;
        [FieldOffset(0x1D88)] public CollectionMovieInfo movieInfos__arr6;
        [FieldOffset(0x1DC0)] public CollectionMovieInfo movieInfos__arr7;
        [FieldOffset(0x1DF8)] public CollectionMovieInfo movieInfos__arr8;
        [FieldOffset(0x1E30)] public CollectionMovieInfo movieInfos__arr9;
        [FieldOffset(0x1E68)] public CollectionMovieInfo movieInfos__arr10;
        [FieldOffset(0x1EA0)] public CollectionMovieInfo movieInfos__arr11;
        [FieldOffset(0x1ED8)] public CollectionMovieInfo movieInfos__arr12;
        [FieldOffset(0x1F10)] public CollectionMovieInfo movieInfos__arr13;
        [FieldOffset(0x1F48)] public CollectionMovieInfo movieInfos__arr14;
        [FieldOffset(0x1F80)] public CollectionMovieInfo movieInfos__arr15;
        [FieldOffset(0x1FB8)] public CollectionMovieInfo movieInfos__arr16;
        [FieldOffset(0x1FF0)] public CollectionMovieInfo movieInfos__arr17;
        [FieldOffset(0x2028)] public CollectionMovieInfo movieInfos__arr18;
        [FieldOffset(0x2060)] public CollectionMovieInfo movieInfos__arr19;
        [FieldOffset(0x2098)] public CollectionMovieInfo movieInfos__arr20;
        [FieldOffset(0x20D0)] public CollectionMovieInfo movieInfos__arr21;
        [FieldOffset(0x2108)] public CollectionMovieInfo movieInfos__arr22;
        [FieldOffset(0x2140)] public CollectionMovieInfo movieInfos__arr23;
        [FieldOffset(0x2178)] public CollectionMovieInfo movieInfos__arr24;
        [FieldOffset(0x21B0)] public CollectionMovieInfo movieInfos__arr25;
        [FieldOffset(0x21E8)] public CollectionMovieInfo movieInfos__arr26;
        [FieldOffset(0x2220)] public CollectionMovieInfo movieInfos__arr27;
        [FieldOffset(0x2258)] public CollectionMovieInfo movieInfos__arr28;
        [FieldOffset(0x2290)] public CollectionMovieInfo movieInfos__arr29;
        [FieldOffset(0x22C8)] public CollectionCharacterInfo charaInfos__arr0;
        [FieldOffset(0x22E0)] public CollectionCharacterInfo charaInfos__arr1;
        [FieldOffset(0x22F8)] public CollectionCharacterInfo charaInfos__arr2;
        [FieldOffset(0x2310)] public CollectionCharacterInfo charaInfos__arr3;
        [FieldOffset(0x2328)] public CollectionCharacterInfo charaInfos__arr4;
        [FieldOffset(0x2340)] public CollectionCharacterInfo charaInfos__arr5;
        [FieldOffset(0x2358)] public CollectionCharacterInfo charaInfos__arr6;
        [FieldOffset(0x2370)] public CollectionHistoryInfo historyInfos__arr0;
        [FieldOffset(0x2384)] public CollectionHistoryInfo historyInfos__arr1;
        [FieldOffset(0x2398)] public CollectionHistoryInfo historyInfos__arr2;
        [FieldOffset(0x23AC)] public CollectionHistoryInfo historyInfos__arr3;
        [FieldOffset(0x23C0)] public CollectionHistoryInfo historyInfos__arr4;
        [FieldOffset(0x23D4)] public CollectionHistoryInfo historyInfos__arr5;
        [FieldOffset(0x23E8)] public CollectionHistoryInfo historyInfos__arr6;
        [FieldOffset(0x23FC)] public CollectionHistoryInfo historyInfos__arr7;
        [FieldOffset(0x2410)] public CollectionHistoryInfo historyInfos__arr8;
        [FieldOffset(0x2424)] public CollectionHistoryInfo historyInfos__arr9;
        [FieldOffset(0x2438)] public CollectionHistoryInfo historyInfos__arr10;
        [FieldOffset(0x244C)] public CollectionGeraldNoteInfo noteInfos__arr0;
        [FieldOffset(0x2460)] public CollectionGeraldNoteInfo noteInfos__arr1;
        [FieldOffset(0x2474)] public CollectionGeraldNoteInfo noteInfos__arr2;
        [FieldOffset(0x2488)] public CollectionGeraldNoteInfo noteInfos__arr3;
        [FieldOffset(0x249C)] public CollectionGeraldNoteInfo noteInfos__arr4;
        [FieldOffset(0x24B0)] public CollectionGeraldNoteInfo noteInfos__arr5;
        [FieldOffset(0x24C4)] public CollectionGeraldNoteInfo noteInfos__arr6;
        [FieldOffset(0x24D8)] public CollectionGeraldNoteInfo noteInfos__arr7;
        [FieldOffset(0x24EC)] public CollectionGeraldNoteInfo noteInfos__arr8;
        [FieldOffset(0x2500)] public CollectionGeraldNoteInfo noteInfos__arr9;
        [FieldOffset(0x2514)] public CollectionGeraldNoteInfo noteInfos__arr10;
        [FieldOffset(0x2528)] public CollectionGeraldNoteInfo noteInfos__arr11;
        [FieldOffset(0x253C)] public CollectionGeraldNoteInfo noteInfos__arr12;
        [FieldOffset(0x2550)] public CollectionGeraldNoteInfo noteInfos__arr13;
        [FieldOffset(0x2564)] public CollectionGeraldNoteInfo noteInfos__arr14;
        [FieldOffset(0x2578)] public CollectionGeraldNoteInfo noteInfos__arr15;
        [FieldOffset(0x258C)] public CollectionGeraldNoteInfo noteInfos__arr16;
        [FieldOffset(0x25A0)] public CollectionGeraldNoteInfo noteInfos__arr17;
        [FieldOffset(0x25B4)] public CollectionGeraldNoteInfo noteInfos__arr18;
        [FieldOffset(0x25C8)] public CollectionGeraldNoteInfo noteInfos__arr19;
        [FieldOffset(0x25DC)] public CollectionGeraldNoteInfo noteInfos__arr20;
        [FieldOffset(0x25F0)] public CollectionGeraldNoteInfo noteInfos__arr21;
        [FieldOffset(0x2604)] public CollectionGeraldNoteInfo noteInfos__arr22;
        [FieldOffset(0x2618)] public CollectionGeraldNoteInfo noteInfos__arr23;
        [FieldOffset(0x262C)] public CollectionGeraldNoteInfo noteInfos__arr24;
        [FieldOffset(0x2640)] public CollectionGeraldNoteInfo noteInfos__arr25;
        [FieldOffset(0x2654)] public CollectionGeraldNoteInfo noteInfos__arr26;
        [FieldOffset(0x2668)] public CollectionGeraldNoteInfo noteInfos__arr27;
        [FieldOffset(0x2680)] public CollectionCharacterMenuParam charaMenuParam;
        [FieldOffset(0x2850)] public CollectionRoomPlayerAction roomActionParam;
        [FieldOffset(0x2894)] public CollectionGeraldNotePlayer notePlayerParam;
        [FieldOffset(0x2898)] public CollectionRoomCamera artCamera;
        [FieldOffset(0x28A0)] public CollectionRoomCamera soundCamera;
        [FieldOffset(0x28A8)] public CollectionRoomCamera movieCamera;
        [FieldOffset(0x28B0)] public CollectionRoomCamera charaCamera;
        [FieldOffset(0x28B8)] public CollectionRoomCamera historyCamera;
        [FieldOffset(0x28C0)] public CollectionRoomCamera noteCamera;
        [FieldOffset(0x28C8)] public CollectionSoundMenuParam soundMenuParam;
    }

}