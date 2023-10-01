using System.Numerics;
using System.Runtime.InteropServices;

public class IslandParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x02)]
    public struct ChaosEmeraldStorageParam
    {
        [FieldOffset(0x00)] public bool isEnable;
        [FieldOffset(0x01)] public sbyte useKeyNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0E)]
    public struct IslandParam
    {
        [FieldOffset(0x00)] public ChaosEmeraldStorageParam storages__arr0;
        [FieldOffset(0x02)] public ChaosEmeraldStorageParam storages__arr1;
        [FieldOffset(0x04)] public ChaosEmeraldStorageParam storages__arr2;
        [FieldOffset(0x06)] public ChaosEmeraldStorageParam storages__arr3;
        [FieldOffset(0x08)] public ChaosEmeraldStorageParam storages__arr4;
        [FieldOffset(0x0A)] public ChaosEmeraldStorageParam storages__arr5;
        [FieldOffset(0x0C)] public ChaosEmeraldStorageParam storages__arr6;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x02)]
    public struct ExtraTowerParam
    {
        [FieldOffset(0x00)] public bool isEnable;
        [FieldOffset(0x01)] public sbyte useKeyNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0A)]
    public struct ExtraIslandParam
    {
        [FieldOffset(0x00)] public ExtraTowerParam extratowers__arr0;
        [FieldOffset(0x02)] public ExtraTowerParam extratowers__arr1;
        [FieldOffset(0x04)] public ExtraTowerParam extratowers__arr2;
        [FieldOffset(0x06)] public ExtraTowerParam extratowers__arr3;
        [FieldOffset(0x08)] public ExtraTowerParam extratowers__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct KodamaCommonParam
    {
        [FieldOffset(0x00)] public float takableRange;
        [FieldOffset(0x04)] public float fadeTime;
        [FieldOffset(0x08)] public float chestJumpOutFadeTime;
        [FieldOffset(0x0C)] public float tutorialDelayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct KodamaFollowParam
    {
        [FieldOffset(0x00)] public sbyte maxFollowNum;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float rotateSpeed;
        [FieldOffset(0x0C)] public float stopDistance;
        [FieldOffset(0x10)] public float vanishDistance;
        [FieldOffset(0x14)] public float respawnStandTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct KodamaNormalParam
    {
        [FieldOffset(0x00)] public KodamaCommonParam common;
        [FieldOffset(0x10)] public KodamaFollowParam follow;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct KodamaElderParam
    {
        [FieldOffset(0x00)] public int levelupKodamaNum__arr0;
        [FieldOffset(0x04)] public int levelupKodamaNum__arr1;
        [FieldOffset(0x08)] public int levelupKodamaNum__arr2;
        [FieldOffset(0x0C)] public int levelupKodamaNumFriends__arr0;
        [FieldOffset(0x10)] public int levelupKodamaNumFriends__arr1;
        [FieldOffset(0x14)] public int levelupKodamaNumFriends__arr2;
        [FieldOffset(0x18)] public int amyRequiredKodamaNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct KodamaHermitLvUpParam
    {
        [FieldOffset(0x00)] public int difficulty__arr0;
        [FieldOffset(0x04)] public int difficulty__arr1;
        [FieldOffset(0x08)] public int difficulty__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x94C)]
    public struct KodamaHermitParam
    {
        [FieldOffset(0x00)] public KodamaHermitLvUpParam levelupSeedNum__arr0;
        [FieldOffset(0x0C)] public KodamaHermitLvUpParam levelupSeedNum__arr1;
        [FieldOffset(0x18)] public KodamaHermitLvUpParam levelupSeedNum__arr2;
        [FieldOffset(0x24)] public KodamaHermitLvUpParam levelupSeedNum__arr3;
        [FieldOffset(0x30)] public KodamaHermitLvUpParam levelupSeedNum__arr4;
        [FieldOffset(0x3C)] public KodamaHermitLvUpParam levelupSeedNum__arr5;
        [FieldOffset(0x48)] public KodamaHermitLvUpParam levelupSeedNum__arr6;
        [FieldOffset(0x54)] public KodamaHermitLvUpParam levelupSeedNum__arr7;
        [FieldOffset(0x60)] public KodamaHermitLvUpParam levelupSeedNum__arr8;
        [FieldOffset(0x6C)] public KodamaHermitLvUpParam levelupSeedNum__arr9;
        [FieldOffset(0x78)] public KodamaHermitLvUpParam levelupSeedNum__arr10;
        [FieldOffset(0x84)] public KodamaHermitLvUpParam levelupSeedNum__arr11;
        [FieldOffset(0x90)] public KodamaHermitLvUpParam levelupSeedNum__arr12;
        [FieldOffset(0x9C)] public KodamaHermitLvUpParam levelupSeedNum__arr13;
        [FieldOffset(0xA8)] public KodamaHermitLvUpParam levelupSeedNum__arr14;
        [FieldOffset(0xB4)] public KodamaHermitLvUpParam levelupSeedNum__arr15;
        [FieldOffset(0xC0)] public KodamaHermitLvUpParam levelupSeedNum__arr16;
        [FieldOffset(0xCC)] public KodamaHermitLvUpParam levelupSeedNum__arr17;
        [FieldOffset(0xD8)] public KodamaHermitLvUpParam levelupSeedNum__arr18;
        [FieldOffset(0xE4)] public KodamaHermitLvUpParam levelupSeedNum__arr19;
        [FieldOffset(0xF0)] public KodamaHermitLvUpParam levelupSeedNum__arr20;
        [FieldOffset(0xFC)] public KodamaHermitLvUpParam levelupSeedNum__arr21;
        [FieldOffset(0x108)] public KodamaHermitLvUpParam levelupSeedNum__arr22;
        [FieldOffset(0x114)] public KodamaHermitLvUpParam levelupSeedNum__arr23;
        [FieldOffset(0x120)] public KodamaHermitLvUpParam levelupSeedNum__arr24;
        [FieldOffset(0x12C)] public KodamaHermitLvUpParam levelupSeedNum__arr25;
        [FieldOffset(0x138)] public KodamaHermitLvUpParam levelupSeedNum__arr26;
        [FieldOffset(0x144)] public KodamaHermitLvUpParam levelupSeedNum__arr27;
        [FieldOffset(0x150)] public KodamaHermitLvUpParam levelupSeedNum__arr28;
        [FieldOffset(0x15C)] public KodamaHermitLvUpParam levelupSeedNum__arr29;
        [FieldOffset(0x168)] public KodamaHermitLvUpParam levelupSeedNum__arr30;
        [FieldOffset(0x174)] public KodamaHermitLvUpParam levelupSeedNum__arr31;
        [FieldOffset(0x180)] public KodamaHermitLvUpParam levelupSeedNum__arr32;
        [FieldOffset(0x18C)] public KodamaHermitLvUpParam levelupSeedNum__arr33;
        [FieldOffset(0x198)] public KodamaHermitLvUpParam levelupSeedNum__arr34;
        [FieldOffset(0x1A4)] public KodamaHermitLvUpParam levelupSeedNum__arr35;
        [FieldOffset(0x1B0)] public KodamaHermitLvUpParam levelupSeedNum__arr36;
        [FieldOffset(0x1BC)] public KodamaHermitLvUpParam levelupSeedNum__arr37;
        [FieldOffset(0x1C8)] public KodamaHermitLvUpParam levelupSeedNum__arr38;
        [FieldOffset(0x1D4)] public KodamaHermitLvUpParam levelupSeedNum__arr39;
        [FieldOffset(0x1E0)] public KodamaHermitLvUpParam levelupSeedNum__arr40;
        [FieldOffset(0x1EC)] public KodamaHermitLvUpParam levelupSeedNum__arr41;
        [FieldOffset(0x1F8)] public KodamaHermitLvUpParam levelupSeedNum__arr42;
        [FieldOffset(0x204)] public KodamaHermitLvUpParam levelupSeedNum__arr43;
        [FieldOffset(0x210)] public KodamaHermitLvUpParam levelupSeedNum__arr44;
        [FieldOffset(0x21C)] public KodamaHermitLvUpParam levelupSeedNum__arr45;
        [FieldOffset(0x228)] public KodamaHermitLvUpParam levelupSeedNum__arr46;
        [FieldOffset(0x234)] public KodamaHermitLvUpParam levelupSeedNum__arr47;
        [FieldOffset(0x240)] public KodamaHermitLvUpParam levelupSeedNum__arr48;
        [FieldOffset(0x24C)] public KodamaHermitLvUpParam levelupSeedNum__arr49;
        [FieldOffset(0x258)] public KodamaHermitLvUpParam levelupSeedNum__arr50;
        [FieldOffset(0x264)] public KodamaHermitLvUpParam levelupSeedNum__arr51;
        [FieldOffset(0x270)] public KodamaHermitLvUpParam levelupSeedNum__arr52;
        [FieldOffset(0x27C)] public KodamaHermitLvUpParam levelupSeedNum__arr53;
        [FieldOffset(0x288)] public KodamaHermitLvUpParam levelupSeedNum__arr54;
        [FieldOffset(0x294)] public KodamaHermitLvUpParam levelupSeedNum__arr55;
        [FieldOffset(0x2A0)] public KodamaHermitLvUpParam levelupSeedNum__arr56;
        [FieldOffset(0x2AC)] public KodamaHermitLvUpParam levelupSeedNum__arr57;
        [FieldOffset(0x2B8)] public KodamaHermitLvUpParam levelupSeedNum__arr58;
        [FieldOffset(0x2C4)] public KodamaHermitLvUpParam levelupSeedNum__arr59;
        [FieldOffset(0x2D0)] public KodamaHermitLvUpParam levelupSeedNum__arr60;
        [FieldOffset(0x2DC)] public KodamaHermitLvUpParam levelupSeedNum__arr61;
        [FieldOffset(0x2E8)] public KodamaHermitLvUpParam levelupSeedNum__arr62;
        [FieldOffset(0x2F4)] public KodamaHermitLvUpParam levelupSeedNum__arr63;
        [FieldOffset(0x300)] public KodamaHermitLvUpParam levelupSeedNum__arr64;
        [FieldOffset(0x30C)] public KodamaHermitLvUpParam levelupSeedNum__arr65;
        [FieldOffset(0x318)] public KodamaHermitLvUpParam levelupSeedNum__arr66;
        [FieldOffset(0x324)] public KodamaHermitLvUpParam levelupSeedNum__arr67;
        [FieldOffset(0x330)] public KodamaHermitLvUpParam levelupSeedNum__arr68;
        [FieldOffset(0x33C)] public KodamaHermitLvUpParam levelupSeedNum__arr69;
        [FieldOffset(0x348)] public KodamaHermitLvUpParam levelupSeedNum__arr70;
        [FieldOffset(0x354)] public KodamaHermitLvUpParam levelupSeedNum__arr71;
        [FieldOffset(0x360)] public KodamaHermitLvUpParam levelupSeedNum__arr72;
        [FieldOffset(0x36C)] public KodamaHermitLvUpParam levelupSeedNum__arr73;
        [FieldOffset(0x378)] public KodamaHermitLvUpParam levelupSeedNum__arr74;
        [FieldOffset(0x384)] public KodamaHermitLvUpParam levelupSeedNum__arr75;
        [FieldOffset(0x390)] public KodamaHermitLvUpParam levelupSeedNum__arr76;
        [FieldOffset(0x39C)] public KodamaHermitLvUpParam levelupSeedNum__arr77;
        [FieldOffset(0x3A8)] public KodamaHermitLvUpParam levelupSeedNum__arr78;
        [FieldOffset(0x3B4)] public KodamaHermitLvUpParam levelupSeedNum__arr79;
        [FieldOffset(0x3C0)] public KodamaHermitLvUpParam levelupSeedNum__arr80;
        [FieldOffset(0x3CC)] public KodamaHermitLvUpParam levelupSeedNum__arr81;
        [FieldOffset(0x3D8)] public KodamaHermitLvUpParam levelupSeedNum__arr82;
        [FieldOffset(0x3E4)] public KodamaHermitLvUpParam levelupSeedNum__arr83;
        [FieldOffset(0x3F0)] public KodamaHermitLvUpParam levelupSeedNum__arr84;
        [FieldOffset(0x3FC)] public KodamaHermitLvUpParam levelupSeedNum__arr85;
        [FieldOffset(0x408)] public KodamaHermitLvUpParam levelupSeedNum__arr86;
        [FieldOffset(0x414)] public KodamaHermitLvUpParam levelupSeedNum__arr87;
        [FieldOffset(0x420)] public KodamaHermitLvUpParam levelupSeedNum__arr88;
        [FieldOffset(0x42C)] public KodamaHermitLvUpParam levelupSeedNum__arr89;
        [FieldOffset(0x438)] public KodamaHermitLvUpParam levelupSeedNum__arr90;
        [FieldOffset(0x444)] public KodamaHermitLvUpParam levelupSeedNum__arr91;
        [FieldOffset(0x450)] public KodamaHermitLvUpParam levelupSeedNum__arr92;
        [FieldOffset(0x45C)] public KodamaHermitLvUpParam levelupSeedNum__arr93;
        [FieldOffset(0x468)] public KodamaHermitLvUpParam levelupSeedNum__arr94;
        [FieldOffset(0x474)] public KodamaHermitLvUpParam levelupSeedNum__arr95;
        [FieldOffset(0x480)] public KodamaHermitLvUpParam levelupSeedNum__arr96;
        [FieldOffset(0x48C)] public KodamaHermitLvUpParam levelupSeedNum__arr97;
        [FieldOffset(0x498)] public KodamaHermitLvUpParam levelupSeedNum__arr98;
        [FieldOffset(0x4A4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr0;
        [FieldOffset(0x4B0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr1;
        [FieldOffset(0x4BC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr2;
        [FieldOffset(0x4C8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr3;
        [FieldOffset(0x4D4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr4;
        [FieldOffset(0x4E0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr5;
        [FieldOffset(0x4EC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr6;
        [FieldOffset(0x4F8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr7;
        [FieldOffset(0x504)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr8;
        [FieldOffset(0x510)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr9;
        [FieldOffset(0x51C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr10;
        [FieldOffset(0x528)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr11;
        [FieldOffset(0x534)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr12;
        [FieldOffset(0x540)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr13;
        [FieldOffset(0x54C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr14;
        [FieldOffset(0x558)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr15;
        [FieldOffset(0x564)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr16;
        [FieldOffset(0x570)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr17;
        [FieldOffset(0x57C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr18;
        [FieldOffset(0x588)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr19;
        [FieldOffset(0x594)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr20;
        [FieldOffset(0x5A0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr21;
        [FieldOffset(0x5AC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr22;
        [FieldOffset(0x5B8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr23;
        [FieldOffset(0x5C4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr24;
        [FieldOffset(0x5D0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr25;
        [FieldOffset(0x5DC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr26;
        [FieldOffset(0x5E8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr27;
        [FieldOffset(0x5F4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr28;
        [FieldOffset(0x600)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr29;
        [FieldOffset(0x60C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr30;
        [FieldOffset(0x618)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr31;
        [FieldOffset(0x624)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr32;
        [FieldOffset(0x630)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr33;
        [FieldOffset(0x63C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr34;
        [FieldOffset(0x648)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr35;
        [FieldOffset(0x654)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr36;
        [FieldOffset(0x660)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr37;
        [FieldOffset(0x66C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr38;
        [FieldOffset(0x678)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr39;
        [FieldOffset(0x684)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr40;
        [FieldOffset(0x690)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr41;
        [FieldOffset(0x69C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr42;
        [FieldOffset(0x6A8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr43;
        [FieldOffset(0x6B4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr44;
        [FieldOffset(0x6C0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr45;
        [FieldOffset(0x6CC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr46;
        [FieldOffset(0x6D8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr47;
        [FieldOffset(0x6E4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr48;
        [FieldOffset(0x6F0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr49;
        [FieldOffset(0x6FC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr50;
        [FieldOffset(0x708)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr51;
        [FieldOffset(0x714)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr52;
        [FieldOffset(0x720)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr53;
        [FieldOffset(0x72C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr54;
        [FieldOffset(0x738)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr55;
        [FieldOffset(0x744)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr56;
        [FieldOffset(0x750)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr57;
        [FieldOffset(0x75C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr58;
        [FieldOffset(0x768)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr59;
        [FieldOffset(0x774)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr60;
        [FieldOffset(0x780)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr61;
        [FieldOffset(0x78C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr62;
        [FieldOffset(0x798)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr63;
        [FieldOffset(0x7A4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr64;
        [FieldOffset(0x7B0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr65;
        [FieldOffset(0x7BC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr66;
        [FieldOffset(0x7C8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr67;
        [FieldOffset(0x7D4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr68;
        [FieldOffset(0x7E0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr69;
        [FieldOffset(0x7EC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr70;
        [FieldOffset(0x7F8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr71;
        [FieldOffset(0x804)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr72;
        [FieldOffset(0x810)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr73;
        [FieldOffset(0x81C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr74;
        [FieldOffset(0x828)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr75;
        [FieldOffset(0x834)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr76;
        [FieldOffset(0x840)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr77;
        [FieldOffset(0x84C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr78;
        [FieldOffset(0x858)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr79;
        [FieldOffset(0x864)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr80;
        [FieldOffset(0x870)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr81;
        [FieldOffset(0x87C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr82;
        [FieldOffset(0x888)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr83;
        [FieldOffset(0x894)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr84;
        [FieldOffset(0x8A0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr85;
        [FieldOffset(0x8AC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr86;
        [FieldOffset(0x8B8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr87;
        [FieldOffset(0x8C4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr88;
        [FieldOffset(0x8D0)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr89;
        [FieldOffset(0x8DC)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr90;
        [FieldOffset(0x8E8)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr91;
        [FieldOffset(0x8F4)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr92;
        [FieldOffset(0x900)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr93;
        [FieldOffset(0x90C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr94;
        [FieldOffset(0x918)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr95;
        [FieldOffset(0x924)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr96;
        [FieldOffset(0x930)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr97;
        [FieldOffset(0x93C)] public KodamaHermitLvUpParam levelupSeedNumFriends__arr98;
        [FieldOffset(0x948)] public int amyRequiredKodamaNum;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct KodamaNewFormParam
    {
        [FieldOffset(0x00)] public float takableRange;
        [FieldOffset(0x04)] public float colliderRange;
        [FieldOffset(0x08)] public float fadeTime;
        [FieldOffset(0x0C)] public float spaceVertical;
        [FieldOffset(0x10)] public float spaceHorizontal;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA30)]
    public struct KodamaParam
    {
        [FieldOffset(0x00)] public KodamaNormalParam normal;
        [FieldOffset(0x28)] public KodamaElderParam elder;
        [FieldOffset(0x44)] public KodamaHermitParam hermit;
        [FieldOffset(0x990)] public KodamaNewFormParam newform__arr0;
        [FieldOffset(0x9A4)] public KodamaNewFormParam newform__arr1;
        [FieldOffset(0x9B8)] public KodamaNewFormParam newform__arr2;
        [FieldOffset(0x9CC)] public KodamaNewFormParam newform__arr3;
        [FieldOffset(0x9E0)] public KodamaNewFormParam newform__arr4;
        [FieldOffset(0x9F4)] public KodamaNewFormParam newform__arr5;
        [FieldOffset(0xA08)] public KodamaNewFormParam newform__arr6;
        [FieldOffset(0xA1C)] public KodamaNewFormParam newform__arr7;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct NpcParam
    {
        [FieldOffset(0x00)] public int inputSequenceItemNumShort;
        [FieldOffset(0x04)] public int inputSequenceItemNumMiddle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA8C)]
    public struct IslandParameter
    {
        [FieldOffset(0x00)] public IslandParam islands__arr0;
        [FieldOffset(0x0E)] public IslandParam islands__arr1;
        [FieldOffset(0x1C)] public IslandParam islands__arr2;
        [FieldOffset(0x2A)] public IslandParam islands__arr3;
        [FieldOffset(0x38)] public IslandParam islands__arr4;
        [FieldOffset(0x46)] public ExtraIslandParam extraIsland;
        [FieldOffset(0x50)] public KodamaParam kodama;
        [FieldOffset(0xA80)] public NpcParam npc;
        [FieldOffset(0xA88)] public int portalExtraKeyNum;
    }

}