using System.Numerics;
using System.Runtime.InteropServices;

public class HeightFieldConfigClass
{
    public enum LayerType : sbyte
    {
        LAYER_NONE = 0,
        LAYER_SOLID = 1,
        LAYER_LIQUID = 2,
        LAYER_THROUGH = 3,
        LAYER_CAMERA = 4,
        LAYER_SOLID_ONEWAY = 5,
        LAYER_SOLID_THROUGH = 6,
        LAYER_SOLID_TINY = 7,
        LAYER_SOLID_DETAIL = 8,
        LAYER_LEAF = 9,
        LAYER_LAND = 10,
        LAYER_RAYBLOCK = 11,
        LAYER_EVENT = 12,
        LAYER_RESERVED13 = 13,
        LAYER_RESERVED14 = 14,
        LAYER_PLAYER = 15,
        LAYER_ENEMY = 16,
        LAYER_ENEMY_BODY = 17,
        LAYER_GIMMICK = 18,
        LAYER_DYNAMICS = 19,
        LAYER_RING = 20,
        LAYER_CHARACTER_CONTROL = 21,
        LAYER_PLAYER_ONLY = 22,
        LAYER_DYNAMICS_THROUGH = 23,
        LAYER_ENEMY_ONLY = 24,
        LAYER_SENSOR_PLAYER = 25,
        LAYER_SENSOR_RING = 26,
        LAYER_SENSOR_GIMMICK = 27,
        LAYER_SENSOR_LAND = 28,
        LAYER_SENSOR_ALL = 29,
        LAYER_RESERVED30 = 30,
        LAYER_RESERVED31 = 31
    }

    public enum MaterialType : sbyte
    {
        MAT_NONE = 0,
        MAT_STONE = 1,
        MAT_EARTH = 2,
        MAT_WOOD = 3,
        MAT_GRASS = 4,
        MAT_IRON = 5,
        MAT_SAND = 6,
        MAT_LAVA = 7,
        MAT_GLASS = 8,
        MAT_SNOW = 9,
        MAT_NO_ENTRY = 10,
        MAT_ICE = 11,
        MAT_WATER = 12,
        MAT_SEA = 13,
        MAT_DAMAGE = 14,
        MAT_DEAD = 15,
        MAT_FLOWER0 = 16,
        MAT_FLOWER1 = 17,
        MAT_FLOWER2 = 18,
        MAT_AIR = 19,
        MAT_DEADLEAVES = 20,
        MAT_WIREMESH = 21,
        MAT_DEAD_ANYDIR = 22,
        MAT_DAMAGE_THROUGH = 23,
        MAT_DRY_GRASS = 24,
        MAT_RELIC = 25,
        MAT_GIANT = 26,
        MAT_GRAVEL = 27,
        MAT_MUD_WATER = 28,
        MAT_SAND2 = 29,
        MAT_SAND3 = 30
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x05)]
    public struct HeightFieldConfigData
    {
        [FieldOffset(0x00)] public LayerType layer;
        [FieldOffset(0x01)] public MaterialType material;
        [FieldOffset(0x02)] public bool notStand;
        [FieldOffset(0x03)] public bool wall;
        [FieldOffset(0x04)] public bool parkour;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4FB)]
    public struct HeightFieldConfig
    {
        [FieldOffset(0x00)] public HeightFieldConfigData data__arr0;
        [FieldOffset(0x05)] public HeightFieldConfigData data__arr1;
        [FieldOffset(0x0A)] public HeightFieldConfigData data__arr2;
        [FieldOffset(0x0F)] public HeightFieldConfigData data__arr3;
        [FieldOffset(0x14)] public HeightFieldConfigData data__arr4;
        [FieldOffset(0x19)] public HeightFieldConfigData data__arr5;
        [FieldOffset(0x1E)] public HeightFieldConfigData data__arr6;
        [FieldOffset(0x23)] public HeightFieldConfigData data__arr7;
        [FieldOffset(0x28)] public HeightFieldConfigData data__arr8;
        [FieldOffset(0x2D)] public HeightFieldConfigData data__arr9;
        [FieldOffset(0x32)] public HeightFieldConfigData data__arr10;
        [FieldOffset(0x37)] public HeightFieldConfigData data__arr11;
        [FieldOffset(0x3C)] public HeightFieldConfigData data__arr12;
        [FieldOffset(0x41)] public HeightFieldConfigData data__arr13;
        [FieldOffset(0x46)] public HeightFieldConfigData data__arr14;
        [FieldOffset(0x4B)] public HeightFieldConfigData data__arr15;
        [FieldOffset(0x50)] public HeightFieldConfigData data__arr16;
        [FieldOffset(0x55)] public HeightFieldConfigData data__arr17;
        [FieldOffset(0x5A)] public HeightFieldConfigData data__arr18;
        [FieldOffset(0x5F)] public HeightFieldConfigData data__arr19;
        [FieldOffset(0x64)] public HeightFieldConfigData data__arr20;
        [FieldOffset(0x69)] public HeightFieldConfigData data__arr21;
        [FieldOffset(0x6E)] public HeightFieldConfigData data__arr22;
        [FieldOffset(0x73)] public HeightFieldConfigData data__arr23;
        [FieldOffset(0x78)] public HeightFieldConfigData data__arr24;
        [FieldOffset(0x7D)] public HeightFieldConfigData data__arr25;
        [FieldOffset(0x82)] public HeightFieldConfigData data__arr26;
        [FieldOffset(0x87)] public HeightFieldConfigData data__arr27;
        [FieldOffset(0x8C)] public HeightFieldConfigData data__arr28;
        [FieldOffset(0x91)] public HeightFieldConfigData data__arr29;
        [FieldOffset(0x96)] public HeightFieldConfigData data__arr30;
        [FieldOffset(0x9B)] public HeightFieldConfigData data__arr31;
        [FieldOffset(0xA0)] public HeightFieldConfigData data__arr32;
        [FieldOffset(0xA5)] public HeightFieldConfigData data__arr33;
        [FieldOffset(0xAA)] public HeightFieldConfigData data__arr34;
        [FieldOffset(0xAF)] public HeightFieldConfigData data__arr35;
        [FieldOffset(0xB4)] public HeightFieldConfigData data__arr36;
        [FieldOffset(0xB9)] public HeightFieldConfigData data__arr37;
        [FieldOffset(0xBE)] public HeightFieldConfigData data__arr38;
        [FieldOffset(0xC3)] public HeightFieldConfigData data__arr39;
        [FieldOffset(0xC8)] public HeightFieldConfigData data__arr40;
        [FieldOffset(0xCD)] public HeightFieldConfigData data__arr41;
        [FieldOffset(0xD2)] public HeightFieldConfigData data__arr42;
        [FieldOffset(0xD7)] public HeightFieldConfigData data__arr43;
        [FieldOffset(0xDC)] public HeightFieldConfigData data__arr44;
        [FieldOffset(0xE1)] public HeightFieldConfigData data__arr45;
        [FieldOffset(0xE6)] public HeightFieldConfigData data__arr46;
        [FieldOffset(0xEB)] public HeightFieldConfigData data__arr47;
        [FieldOffset(0xF0)] public HeightFieldConfigData data__arr48;
        [FieldOffset(0xF5)] public HeightFieldConfigData data__arr49;
        [FieldOffset(0xFA)] public HeightFieldConfigData data__arr50;
        [FieldOffset(0xFF)] public HeightFieldConfigData data__arr51;
        [FieldOffset(0x104)] public HeightFieldConfigData data__arr52;
        [FieldOffset(0x109)] public HeightFieldConfigData data__arr53;
        [FieldOffset(0x10E)] public HeightFieldConfigData data__arr54;
        [FieldOffset(0x113)] public HeightFieldConfigData data__arr55;
        [FieldOffset(0x118)] public HeightFieldConfigData data__arr56;
        [FieldOffset(0x11D)] public HeightFieldConfigData data__arr57;
        [FieldOffset(0x122)] public HeightFieldConfigData data__arr58;
        [FieldOffset(0x127)] public HeightFieldConfigData data__arr59;
        [FieldOffset(0x12C)] public HeightFieldConfigData data__arr60;
        [FieldOffset(0x131)] public HeightFieldConfigData data__arr61;
        [FieldOffset(0x136)] public HeightFieldConfigData data__arr62;
        [FieldOffset(0x13B)] public HeightFieldConfigData data__arr63;
        [FieldOffset(0x140)] public HeightFieldConfigData data__arr64;
        [FieldOffset(0x145)] public HeightFieldConfigData data__arr65;
        [FieldOffset(0x14A)] public HeightFieldConfigData data__arr66;
        [FieldOffset(0x14F)] public HeightFieldConfigData data__arr67;
        [FieldOffset(0x154)] public HeightFieldConfigData data__arr68;
        [FieldOffset(0x159)] public HeightFieldConfigData data__arr69;
        [FieldOffset(0x15E)] public HeightFieldConfigData data__arr70;
        [FieldOffset(0x163)] public HeightFieldConfigData data__arr71;
        [FieldOffset(0x168)] public HeightFieldConfigData data__arr72;
        [FieldOffset(0x16D)] public HeightFieldConfigData data__arr73;
        [FieldOffset(0x172)] public HeightFieldConfigData data__arr74;
        [FieldOffset(0x177)] public HeightFieldConfigData data__arr75;
        [FieldOffset(0x17C)] public HeightFieldConfigData data__arr76;
        [FieldOffset(0x181)] public HeightFieldConfigData data__arr77;
        [FieldOffset(0x186)] public HeightFieldConfigData data__arr78;
        [FieldOffset(0x18B)] public HeightFieldConfigData data__arr79;
        [FieldOffset(0x190)] public HeightFieldConfigData data__arr80;
        [FieldOffset(0x195)] public HeightFieldConfigData data__arr81;
        [FieldOffset(0x19A)] public HeightFieldConfigData data__arr82;
        [FieldOffset(0x19F)] public HeightFieldConfigData data__arr83;
        [FieldOffset(0x1A4)] public HeightFieldConfigData data__arr84;
        [FieldOffset(0x1A9)] public HeightFieldConfigData data__arr85;
        [FieldOffset(0x1AE)] public HeightFieldConfigData data__arr86;
        [FieldOffset(0x1B3)] public HeightFieldConfigData data__arr87;
        [FieldOffset(0x1B8)] public HeightFieldConfigData data__arr88;
        [FieldOffset(0x1BD)] public HeightFieldConfigData data__arr89;
        [FieldOffset(0x1C2)] public HeightFieldConfigData data__arr90;
        [FieldOffset(0x1C7)] public HeightFieldConfigData data__arr91;
        [FieldOffset(0x1CC)] public HeightFieldConfigData data__arr92;
        [FieldOffset(0x1D1)] public HeightFieldConfigData data__arr93;
        [FieldOffset(0x1D6)] public HeightFieldConfigData data__arr94;
        [FieldOffset(0x1DB)] public HeightFieldConfigData data__arr95;
        [FieldOffset(0x1E0)] public HeightFieldConfigData data__arr96;
        [FieldOffset(0x1E5)] public HeightFieldConfigData data__arr97;
        [FieldOffset(0x1EA)] public HeightFieldConfigData data__arr98;
        [FieldOffset(0x1EF)] public HeightFieldConfigData data__arr99;
        [FieldOffset(0x1F4)] public HeightFieldConfigData data__arr100;
        [FieldOffset(0x1F9)] public HeightFieldConfigData data__arr101;
        [FieldOffset(0x1FE)] public HeightFieldConfigData data__arr102;
        [FieldOffset(0x203)] public HeightFieldConfigData data__arr103;
        [FieldOffset(0x208)] public HeightFieldConfigData data__arr104;
        [FieldOffset(0x20D)] public HeightFieldConfigData data__arr105;
        [FieldOffset(0x212)] public HeightFieldConfigData data__arr106;
        [FieldOffset(0x217)] public HeightFieldConfigData data__arr107;
        [FieldOffset(0x21C)] public HeightFieldConfigData data__arr108;
        [FieldOffset(0x221)] public HeightFieldConfigData data__arr109;
        [FieldOffset(0x226)] public HeightFieldConfigData data__arr110;
        [FieldOffset(0x22B)] public HeightFieldConfigData data__arr111;
        [FieldOffset(0x230)] public HeightFieldConfigData data__arr112;
        [FieldOffset(0x235)] public HeightFieldConfigData data__arr113;
        [FieldOffset(0x23A)] public HeightFieldConfigData data__arr114;
        [FieldOffset(0x23F)] public HeightFieldConfigData data__arr115;
        [FieldOffset(0x244)] public HeightFieldConfigData data__arr116;
        [FieldOffset(0x249)] public HeightFieldConfigData data__arr117;
        [FieldOffset(0x24E)] public HeightFieldConfigData data__arr118;
        [FieldOffset(0x253)] public HeightFieldConfigData data__arr119;
        [FieldOffset(0x258)] public HeightFieldConfigData data__arr120;
        [FieldOffset(0x25D)] public HeightFieldConfigData data__arr121;
        [FieldOffset(0x262)] public HeightFieldConfigData data__arr122;
        [FieldOffset(0x267)] public HeightFieldConfigData data__arr123;
        [FieldOffset(0x26C)] public HeightFieldConfigData data__arr124;
        [FieldOffset(0x271)] public HeightFieldConfigData data__arr125;
        [FieldOffset(0x276)] public HeightFieldConfigData data__arr126;
        [FieldOffset(0x27B)] public HeightFieldConfigData data__arr127;
        [FieldOffset(0x280)] public HeightFieldConfigData data__arr128;
        [FieldOffset(0x285)] public HeightFieldConfigData data__arr129;
        [FieldOffset(0x28A)] public HeightFieldConfigData data__arr130;
        [FieldOffset(0x28F)] public HeightFieldConfigData data__arr131;
        [FieldOffset(0x294)] public HeightFieldConfigData data__arr132;
        [FieldOffset(0x299)] public HeightFieldConfigData data__arr133;
        [FieldOffset(0x29E)] public HeightFieldConfigData data__arr134;
        [FieldOffset(0x2A3)] public HeightFieldConfigData data__arr135;
        [FieldOffset(0x2A8)] public HeightFieldConfigData data__arr136;
        [FieldOffset(0x2AD)] public HeightFieldConfigData data__arr137;
        [FieldOffset(0x2B2)] public HeightFieldConfigData data__arr138;
        [FieldOffset(0x2B7)] public HeightFieldConfigData data__arr139;
        [FieldOffset(0x2BC)] public HeightFieldConfigData data__arr140;
        [FieldOffset(0x2C1)] public HeightFieldConfigData data__arr141;
        [FieldOffset(0x2C6)] public HeightFieldConfigData data__arr142;
        [FieldOffset(0x2CB)] public HeightFieldConfigData data__arr143;
        [FieldOffset(0x2D0)] public HeightFieldConfigData data__arr144;
        [FieldOffset(0x2D5)] public HeightFieldConfigData data__arr145;
        [FieldOffset(0x2DA)] public HeightFieldConfigData data__arr146;
        [FieldOffset(0x2DF)] public HeightFieldConfigData data__arr147;
        [FieldOffset(0x2E4)] public HeightFieldConfigData data__arr148;
        [FieldOffset(0x2E9)] public HeightFieldConfigData data__arr149;
        [FieldOffset(0x2EE)] public HeightFieldConfigData data__arr150;
        [FieldOffset(0x2F3)] public HeightFieldConfigData data__arr151;
        [FieldOffset(0x2F8)] public HeightFieldConfigData data__arr152;
        [FieldOffset(0x2FD)] public HeightFieldConfigData data__arr153;
        [FieldOffset(0x302)] public HeightFieldConfigData data__arr154;
        [FieldOffset(0x307)] public HeightFieldConfigData data__arr155;
        [FieldOffset(0x30C)] public HeightFieldConfigData data__arr156;
        [FieldOffset(0x311)] public HeightFieldConfigData data__arr157;
        [FieldOffset(0x316)] public HeightFieldConfigData data__arr158;
        [FieldOffset(0x31B)] public HeightFieldConfigData data__arr159;
        [FieldOffset(0x320)] public HeightFieldConfigData data__arr160;
        [FieldOffset(0x325)] public HeightFieldConfigData data__arr161;
        [FieldOffset(0x32A)] public HeightFieldConfigData data__arr162;
        [FieldOffset(0x32F)] public HeightFieldConfigData data__arr163;
        [FieldOffset(0x334)] public HeightFieldConfigData data__arr164;
        [FieldOffset(0x339)] public HeightFieldConfigData data__arr165;
        [FieldOffset(0x33E)] public HeightFieldConfigData data__arr166;
        [FieldOffset(0x343)] public HeightFieldConfigData data__arr167;
        [FieldOffset(0x348)] public HeightFieldConfigData data__arr168;
        [FieldOffset(0x34D)] public HeightFieldConfigData data__arr169;
        [FieldOffset(0x352)] public HeightFieldConfigData data__arr170;
        [FieldOffset(0x357)] public HeightFieldConfigData data__arr171;
        [FieldOffset(0x35C)] public HeightFieldConfigData data__arr172;
        [FieldOffset(0x361)] public HeightFieldConfigData data__arr173;
        [FieldOffset(0x366)] public HeightFieldConfigData data__arr174;
        [FieldOffset(0x36B)] public HeightFieldConfigData data__arr175;
        [FieldOffset(0x370)] public HeightFieldConfigData data__arr176;
        [FieldOffset(0x375)] public HeightFieldConfigData data__arr177;
        [FieldOffset(0x37A)] public HeightFieldConfigData data__arr178;
        [FieldOffset(0x37F)] public HeightFieldConfigData data__arr179;
        [FieldOffset(0x384)] public HeightFieldConfigData data__arr180;
        [FieldOffset(0x389)] public HeightFieldConfigData data__arr181;
        [FieldOffset(0x38E)] public HeightFieldConfigData data__arr182;
        [FieldOffset(0x393)] public HeightFieldConfigData data__arr183;
        [FieldOffset(0x398)] public HeightFieldConfigData data__arr184;
        [FieldOffset(0x39D)] public HeightFieldConfigData data__arr185;
        [FieldOffset(0x3A2)] public HeightFieldConfigData data__arr186;
        [FieldOffset(0x3A7)] public HeightFieldConfigData data__arr187;
        [FieldOffset(0x3AC)] public HeightFieldConfigData data__arr188;
        [FieldOffset(0x3B1)] public HeightFieldConfigData data__arr189;
        [FieldOffset(0x3B6)] public HeightFieldConfigData data__arr190;
        [FieldOffset(0x3BB)] public HeightFieldConfigData data__arr191;
        [FieldOffset(0x3C0)] public HeightFieldConfigData data__arr192;
        [FieldOffset(0x3C5)] public HeightFieldConfigData data__arr193;
        [FieldOffset(0x3CA)] public HeightFieldConfigData data__arr194;
        [FieldOffset(0x3CF)] public HeightFieldConfigData data__arr195;
        [FieldOffset(0x3D4)] public HeightFieldConfigData data__arr196;
        [FieldOffset(0x3D9)] public HeightFieldConfigData data__arr197;
        [FieldOffset(0x3DE)] public HeightFieldConfigData data__arr198;
        [FieldOffset(0x3E3)] public HeightFieldConfigData data__arr199;
        [FieldOffset(0x3E8)] public HeightFieldConfigData data__arr200;
        [FieldOffset(0x3ED)] public HeightFieldConfigData data__arr201;
        [FieldOffset(0x3F2)] public HeightFieldConfigData data__arr202;
        [FieldOffset(0x3F7)] public HeightFieldConfigData data__arr203;
        [FieldOffset(0x3FC)] public HeightFieldConfigData data__arr204;
        [FieldOffset(0x401)] public HeightFieldConfigData data__arr205;
        [FieldOffset(0x406)] public HeightFieldConfigData data__arr206;
        [FieldOffset(0x40B)] public HeightFieldConfigData data__arr207;
        [FieldOffset(0x410)] public HeightFieldConfigData data__arr208;
        [FieldOffset(0x415)] public HeightFieldConfigData data__arr209;
        [FieldOffset(0x41A)] public HeightFieldConfigData data__arr210;
        [FieldOffset(0x41F)] public HeightFieldConfigData data__arr211;
        [FieldOffset(0x424)] public HeightFieldConfigData data__arr212;
        [FieldOffset(0x429)] public HeightFieldConfigData data__arr213;
        [FieldOffset(0x42E)] public HeightFieldConfigData data__arr214;
        [FieldOffset(0x433)] public HeightFieldConfigData data__arr215;
        [FieldOffset(0x438)] public HeightFieldConfigData data__arr216;
        [FieldOffset(0x43D)] public HeightFieldConfigData data__arr217;
        [FieldOffset(0x442)] public HeightFieldConfigData data__arr218;
        [FieldOffset(0x447)] public HeightFieldConfigData data__arr219;
        [FieldOffset(0x44C)] public HeightFieldConfigData data__arr220;
        [FieldOffset(0x451)] public HeightFieldConfigData data__arr221;
        [FieldOffset(0x456)] public HeightFieldConfigData data__arr222;
        [FieldOffset(0x45B)] public HeightFieldConfigData data__arr223;
        [FieldOffset(0x460)] public HeightFieldConfigData data__arr224;
        [FieldOffset(0x465)] public HeightFieldConfigData data__arr225;
        [FieldOffset(0x46A)] public HeightFieldConfigData data__arr226;
        [FieldOffset(0x46F)] public HeightFieldConfigData data__arr227;
        [FieldOffset(0x474)] public HeightFieldConfigData data__arr228;
        [FieldOffset(0x479)] public HeightFieldConfigData data__arr229;
        [FieldOffset(0x47E)] public HeightFieldConfigData data__arr230;
        [FieldOffset(0x483)] public HeightFieldConfigData data__arr231;
        [FieldOffset(0x488)] public HeightFieldConfigData data__arr232;
        [FieldOffset(0x48D)] public HeightFieldConfigData data__arr233;
        [FieldOffset(0x492)] public HeightFieldConfigData data__arr234;
        [FieldOffset(0x497)] public HeightFieldConfigData data__arr235;
        [FieldOffset(0x49C)] public HeightFieldConfigData data__arr236;
        [FieldOffset(0x4A1)] public HeightFieldConfigData data__arr237;
        [FieldOffset(0x4A6)] public HeightFieldConfigData data__arr238;
        [FieldOffset(0x4AB)] public HeightFieldConfigData data__arr239;
        [FieldOffset(0x4B0)] public HeightFieldConfigData data__arr240;
        [FieldOffset(0x4B5)] public HeightFieldConfigData data__arr241;
        [FieldOffset(0x4BA)] public HeightFieldConfigData data__arr242;
        [FieldOffset(0x4BF)] public HeightFieldConfigData data__arr243;
        [FieldOffset(0x4C4)] public HeightFieldConfigData data__arr244;
        [FieldOffset(0x4C9)] public HeightFieldConfigData data__arr245;
        [FieldOffset(0x4CE)] public HeightFieldConfigData data__arr246;
        [FieldOffset(0x4D3)] public HeightFieldConfigData data__arr247;
        [FieldOffset(0x4D8)] public HeightFieldConfigData data__arr248;
        [FieldOffset(0x4DD)] public HeightFieldConfigData data__arr249;
        [FieldOffset(0x4E2)] public HeightFieldConfigData data__arr250;
        [FieldOffset(0x4E7)] public HeightFieldConfigData data__arr251;
        [FieldOffset(0x4EC)] public HeightFieldConfigData data__arr252;
        [FieldOffset(0x4F1)] public HeightFieldConfigData data__arr253;
        [FieldOffset(0x4F6)] public HeightFieldConfigData data__arr254;
    }

}