using System.Numerics;
using System.Runtime.InteropServices;

public class UIFishiGuideConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct FishCameraParam
    {
        [FieldOffset(0x00)] public Vector3 position;
        [FieldOffset(0x10)] public Vector3 target;
        [FieldOffset(0x20)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x13B0)]
    public struct UIFishiGuideConfig
    {
        [FieldOffset(0x00)] public FishCameraParam fishList__arr0;
        [FieldOffset(0x30)] public FishCameraParam fishList__arr1;
        [FieldOffset(0x60)] public FishCameraParam fishList__arr2;
        [FieldOffset(0x90)] public FishCameraParam fishList__arr3;
        [FieldOffset(0xC0)] public FishCameraParam fishList__arr4;
        [FieldOffset(0xF0)] public FishCameraParam fishList__arr5;
        [FieldOffset(0x120)] public FishCameraParam fishList__arr6;
        [FieldOffset(0x150)] public FishCameraParam fishList__arr7;
        [FieldOffset(0x180)] public FishCameraParam fishList__arr8;
        [FieldOffset(0x1B0)] public FishCameraParam fishList__arr9;
        [FieldOffset(0x1E0)] public FishCameraParam fishList__arr10;
        [FieldOffset(0x210)] public FishCameraParam fishList__arr11;
        [FieldOffset(0x240)] public FishCameraParam fishList__arr12;
        [FieldOffset(0x270)] public FishCameraParam fishList__arr13;
        [FieldOffset(0x2A0)] public FishCameraParam fishList__arr14;
        [FieldOffset(0x2D0)] public FishCameraParam fishList__arr15;
        [FieldOffset(0x300)] public FishCameraParam fishList__arr16;
        [FieldOffset(0x330)] public FishCameraParam fishList__arr17;
        [FieldOffset(0x360)] public FishCameraParam fishList__arr18;
        [FieldOffset(0x390)] public FishCameraParam fishList__arr19;
        [FieldOffset(0x3C0)] public FishCameraParam fishList__arr20;
        [FieldOffset(0x3F0)] public FishCameraParam fishList__arr21;
        [FieldOffset(0x420)] public FishCameraParam fishList__arr22;
        [FieldOffset(0x450)] public FishCameraParam fishList__arr23;
        [FieldOffset(0x480)] public FishCameraParam fishList__arr24;
        [FieldOffset(0x4B0)] public FishCameraParam fishList__arr25;
        [FieldOffset(0x4E0)] public FishCameraParam fishList__arr26;
        [FieldOffset(0x510)] public FishCameraParam fishList__arr27;
        [FieldOffset(0x540)] public FishCameraParam fishList__arr28;
        [FieldOffset(0x570)] public FishCameraParam fishList__arr29;
        [FieldOffset(0x5A0)] public FishCameraParam fishList__arr30;
        [FieldOffset(0x5D0)] public FishCameraParam fishList__arr31;
        [FieldOffset(0x600)] public FishCameraParam fishList__arr32;
        [FieldOffset(0x630)] public FishCameraParam fishList__arr33;
        [FieldOffset(0x660)] public FishCameraParam fishList__arr34;
        [FieldOffset(0x690)] public FishCameraParam fishList__arr35;
        [FieldOffset(0x6C0)] public FishCameraParam fishList__arr36;
        [FieldOffset(0x6F0)] public FishCameraParam fishList__arr37;
        [FieldOffset(0x720)] public FishCameraParam fishList__arr38;
        [FieldOffset(0x750)] public FishCameraParam fishList__arr39;
        [FieldOffset(0x780)] public FishCameraParam fishList__arr40;
        [FieldOffset(0x7B0)] public FishCameraParam fishList__arr41;
        [FieldOffset(0x7E0)] public FishCameraParam fishList__arr42;
        [FieldOffset(0x810)] public FishCameraParam fishList__arr43;
        [FieldOffset(0x840)] public FishCameraParam fishList__arr44;
        [FieldOffset(0x870)] public FishCameraParam fishList__arr45;
        [FieldOffset(0x8A0)] public FishCameraParam fishList__arr46;
        [FieldOffset(0x8D0)] public FishCameraParam fishList__arr47;
        [FieldOffset(0x900)] public FishCameraParam fishList__arr48;
        [FieldOffset(0x930)] public FishCameraParam fishList__arr49;
        [FieldOffset(0x960)] public FishCameraParam fishList__arr50;
        [FieldOffset(0x990)] public FishCameraParam fishList__arr51;
        [FieldOffset(0x9C0)] public FishCameraParam fishList__arr52;
        [FieldOffset(0x9F0)] public FishCameraParam fishList__arr53;
        [FieldOffset(0xA20)] public FishCameraParam fishList__arr54;
        [FieldOffset(0xA50)] public FishCameraParam fishList__arr55;
        [FieldOffset(0xA80)] public FishCameraParam fishList__arr56;
        [FieldOffset(0xAB0)] public FishCameraParam fishList__arr57;
        [FieldOffset(0xAE0)] public FishCameraParam fishList__arr58;
        [FieldOffset(0xB10)] public FishCameraParam fishList__arr59;
        [FieldOffset(0xB40)] public FishCameraParam fishList__arr60;
        [FieldOffset(0xB70)] public FishCameraParam fishList__arr61;
        [FieldOffset(0xBA0)] public FishCameraParam fishList__arr62;
        [FieldOffset(0xBD0)] public FishCameraParam fishList__arr63;
        [FieldOffset(0xC00)] public FishCameraParam fishList__arr64;
        [FieldOffset(0xC30)] public FishCameraParam fishList__arr65;
        [FieldOffset(0xC60)] public FishCameraParam fishList__arr66;
        [FieldOffset(0xC90)] public FishCameraParam fishList__arr67;
        [FieldOffset(0xCC0)] public FishCameraParam fishList__arr68;
        [FieldOffset(0xCF0)] public FishCameraParam fishList__arr69;
        [FieldOffset(0xD20)] public FishCameraParam fishList__arr70;
        [FieldOffset(0xD50)] public FishCameraParam fishList__arr71;
        [FieldOffset(0xD80)] public FishCameraParam fishList__arr72;
        [FieldOffset(0xDB0)] public FishCameraParam fishList__arr73;
        [FieldOffset(0xDE0)] public FishCameraParam fishList__arr74;
        [FieldOffset(0xE10)] public FishCameraParam fishList__arr75;
        [FieldOffset(0xE40)] public FishCameraParam fishList__arr76;
        [FieldOffset(0xE70)] public FishCameraParam fishList__arr77;
        [FieldOffset(0xEA0)] public FishCameraParam fishList__arr78;
        [FieldOffset(0xED0)] public FishCameraParam fishList__arr79;
        [FieldOffset(0xF00)] public FishCameraParam fishList__arr80;
        [FieldOffset(0xF30)] public FishCameraParam fishList__arr81;
        [FieldOffset(0xF60)] public FishCameraParam fishList__arr82;
        [FieldOffset(0xF90)] public FishCameraParam fishList__arr83;
        [FieldOffset(0xFC0)] public FishCameraParam fishList__arr84;
        [FieldOffset(0xFF0)] public FishCameraParam fishList__arr85;
        [FieldOffset(0x1020)] public FishCameraParam fishList__arr86;
        [FieldOffset(0x1050)] public FishCameraParam fishList__arr87;
        [FieldOffset(0x1080)] public FishCameraParam fishList__arr88;
        [FieldOffset(0x10B0)] public FishCameraParam fishList__arr89;
        [FieldOffset(0x10E0)] public FishCameraParam fishList__arr90;
        [FieldOffset(0x1110)] public FishCameraParam fishList__arr91;
        [FieldOffset(0x1140)] public FishCameraParam fishList__arr92;
        [FieldOffset(0x1170)] public FishCameraParam fishList__arr93;
        [FieldOffset(0x11A0)] public FishCameraParam fishList__arr94;
        [FieldOffset(0x11D0)] public FishCameraParam fishList__arr95;
        [FieldOffset(0x1200)] public FishCameraParam fishList__arr96;
        [FieldOffset(0x1230)] public FishCameraParam fishList__arr97;
        [FieldOffset(0x1260)] public FishCameraParam fishList__arr98;
        [FieldOffset(0x1290)] public FishCameraParam fishList__arr99;
        [FieldOffset(0x12C0)] public FishCameraParam fishList__arr100;
        [FieldOffset(0x12F0)] public FishCameraParam fishList__arr101;
        [FieldOffset(0x1320)] public FishCameraParam fishList__arr102;
        [FieldOffset(0x1350)] public FishCameraParam fishList__arr103;
        [FieldOffset(0x1380)] public FishCameraParam fishList__arr104;
    }

}