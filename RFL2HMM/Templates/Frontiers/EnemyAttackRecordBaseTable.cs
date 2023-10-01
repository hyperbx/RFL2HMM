using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyAttackRecordBaseTableClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct Record
    {
        [FieldOffset(0x00)] public byte no;
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

    public enum Kind : short
    {
        InvalidKind = -1,
        Dead_BattleJellymanLv1 = 0,
        Dead_BattleJellymanLv2 = 1,
        Dead_BattleJellymanLv3 = 2,
        Dead_BattleJellymanLv4 = 3,
        Dead_BattleWolf = 4,
        Dead_BattleBird = 5,
        Dead_BattleSniper = 6,
        Dead_BattleTwister = 7,
        Dead_BattleBommer = 8,
        Dead_BattleBubble = 9,
        Dead_BattleDefender = 10,
        Dead_BattleUmbrella = 11,
        Dead_BattleAquaBall = 12,
        Dead_BattleJumper = 13,
        Dead_BattleBladeLv1 = 14,
        Dead_BattleBladeLv2 = 15,
        Dead_BattleBladeLv3 = 16,
        Dead_BattleBladeLv4 = 17,
        Dead_BattleDarumaLv1 = 18,
        Dead_BattleDarumaLv2 = 19,
        Dead_BattleDarumaLv3 = 20,
        Dead_BattleDarumaLv4 = 21,
        Dead_BattleSpider = 22,
        Dead_BattleCharger = 23,
        Dead_BattleFlyer = 24,
        Dead_BattleTracker = 25,
        Dead_BattleAsura = 26,
        Dead_BattleSkier = 27,
        Dead_BattleTyrant = 28,
        Dead_BattleSumo = 29,
        Dead_BattleStrider = 30,
        Dead_BattleWarship = 31,
        Dead_BattleGiantFC = 32,
        Dead_BattleGiantClimb = 33,
        Dead_BattleGiant = 34,
        Dead_BattleDragonFC = 35,
        Dead_BattleDragonClimb = 36,
        Dead_BattleDragon = 37,
        Dead_BattleKnightFC = 38,
        Dead_BattleKnightClimb = 39,
        Dead_BattleKnight = 40,
        Dead_BattleRifle = 41,
        Dead_BattleTheEnd = 42,
        Dead_Gimmick = 43,
        Dead_Fall = 44,
        Dead_Water = 45,
        Dead_Lava = 46,
        Failed_QuestKodamaCollect1 = 47,
        Failed_QuestMowingGrass = 48,
        Failed_QuestKodamaEscort = 49,
        Failed_QuestKodamaCollect2 = 50,
        Failed_QuestDarumaBattle = 51,
        Failed_QuestCollectItem = 52,
        Failed_QuestDrawBridge = 53,
        Failed_PinBall = 54,
        Failed_Hacking = 55,
        Transit_ToIsland = 56,
        Transit_ToCyber = 57,
        Transit_ToFishing = 58,
        Transit_ToHacking = 59,
        Transit_ToTheEnd = 60,
        Transit_ToSkill1 = 61,
        Transit_ToSkill2 = 62,
        Transit_ToSkill3 = 63,
        Transit_ToSkill4 = 64,
        Transit_ToSkill5 = 65,
        Transit_ToSkill6 = 66,
        Transit_ToSkill7 = 67,
        Transit_ToSkill8 = 68,
        Transit_ToSkill9 = 69,
        Transit_ToSkill10 = 70,
        Transit_ToSkill11 = 71,
        Transit_ToSkill12 = 72,
        Transit_ToSkill13 = 73,
        Transit_ToSkill14 = 74,
        Transit_ToSkill15 = 75,
        Transit_ToSkill16 = 76,
        Transit_ToSkill17 = 77,
        Transit_ToSkill18 = 78,
        Transit_ToSkill19 = 79,
        Transit_ToSkill20 = 80,
        BattleRifleBeast_Fase3_Cable = 81,
        BattleRifleBeast_Fase3_Parry = 82,
        BattleRifleBeast_Fase3_Down = 83,
        BattleRifleBeast_Fase4 = 84,
        TransitAmy_ToSkill1 = 85,
        TransitAmy_ToSkill2 = 86,
        TransitAmy_ToSkill3 = 87,
        TransitAmy_ToSkill4 = 88,
        TransitAmy_ToSkill5 = 89,
        TransitAmy_ToSkill6 = 90,
        TransitAmy_ToSkill7 = 91,
        TransitAmy_ToSkill8 = 92,
        TransitAmy_ToSkill9 = 93,
        TransitAmy_ToSkill10 = 94,
        TransitAmy_ToSkill11 = 95,
        TransitAmy_ToSkill12 = 96,
        TransitAmy_ToSkill13 = 97,
        TransitAmy_ToSkill14 = 98,
        TransitAmy_ToSkill15 = 99,
        TransitAmy_ToSkill16 = 100,
        TransitAmy_ToSkill17 = 101,
        TransitAmy_ToSkill18 = 102,
        TransitAmy_ToSkill19 = 103,
        TransitAmy_ToSkill20 = 104,
        DeadAmy_BattleBlade = 105,
        DeadAmy_BattleDaruma = 106,
        DeadAmy_BattleCharger = 107,
        DeadAmy_BattleSpider = 108,
        DeadAmy_BattleTracker = 109,
        DeadAmy_BattleTyrant = 110,
        DeadAmy_Gimmick = 111,
        DeadAmy_Fall = 112,
        DeadAmy_Water = 113,
        TransitKnuckles_ToSkill1 = 114,
        TransitKnuckles_ToSkill2 = 115,
        TransitKnuckles_ToSkill3 = 116,
        TransitKnuckles_ToSkill4 = 117,
        TransitKnuckles_ToSkill5 = 118,
        TransitKnuckles_ToSkill6 = 119,
        TransitKnuckles_ToSkill7 = 120,
        TransitKnuckles_ToSkill8 = 121,
        TransitKnuckles_ToSkill9 = 122,
        TransitKnuckles_ToSkill10 = 123,
        TransitKnuckles_ToSkill11 = 124,
        TransitKnuckles_ToSkill12 = 125,
        TransitKnuckles_ToSkill13 = 126,
        TransitKnuckles_ToSkill14 = 127,
        TransitKnuckles_ToSkill15 = 128,
        TransitKnuckles_ToSkill16 = 129,
        TransitKnuckles_ToSkill17 = 130,
        TransitKnuckles_ToSkill18 = 131,
        TransitKnuckles_ToSkill19 = 132,
        TransitKnuckles_ToSkill20 = 133,
        DeadKnuckles_BattleBlade = 134,
        DeadKnuckles_BattleDaruma = 135,
        DeadKnuckles_BattleCharger = 136,
        DeadKnuckles_BattleSpider = 137,
        DeadKnuckles_BattleTracker = 138,
        DeadKnuckles_BattleTyrant = 139,
        DeadKnuckles_Gimmick = 140,
        DeadKnuckles_Fall = 141,
        DeadKnuckles_Water = 142,
        TransitTails_ToSkill1 = 143,
        TransitTails_ToSkill2 = 144,
        TransitTails_ToSkill3 = 145,
        TransitTails_ToSkill4 = 146,
        TransitTails_ToSkill5 = 147,
        TransitTails_ToSkill6 = 148,
        TransitTails_ToSkill7 = 149,
        TransitTails_ToSkill8 = 150,
        TransitTails_ToSkill9 = 151,
        TransitTails_ToSkill10 = 152,
        TransitTails_ToSkill11 = 153,
        TransitTails_ToSkill12 = 154,
        TransitTails_ToSkill13 = 155,
        TransitTails_ToSkill14 = 156,
        TransitTails_ToSkill15 = 157,
        TransitTails_ToSkill16 = 158,
        TransitTails_ToSkill17 = 159,
        TransitTails_ToSkill18 = 160,
        TransitTails_ToSkill19 = 161,
        TransitTails_ToSkill20 = 162,
        DeadTails_BattleBlade = 163,
        DeadTails_BattleDaruma = 164,
        DeadTails_BattleCharger = 165,
        DeadTails_BattleSpider = 166,
        DeadTails_BattleTracker = 167,
        DeadTails_BattleTyrant = 168,
        DeadTails_Gimmick = 169,
        DeadTails_Fall = 170,
        DeadTails_Water = 171,
        DeadSonic_BattleBlade = 172,
        DeadSonic_BattleDaruma = 173,
        DeadSonic_BattleCharger = 174,
        DeadSonic_BattleSpider = 175,
        DeadSonic_BattleTracker = 176,
        DeadSonic_BattleTyrant = 177,
        DeadSonic_Gimmick = 178,
        DeadSonic_Fall = 179,
        DeadSonic_Water = 180,
        NumKinds = 181
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct EnemyAttackRecord
    {
        [FieldOffset(0)]  public Record record;
        [FieldOffset(0x08)] public UnmanagedString name;
        [FieldOffset(0x18)] public int damage;
        [FieldOffset(0x1C)] public float velocityX;
        [FieldOffset(0x20)] public float velocityY;
        [FieldOffset(0x28)] public UnmanagedString hitStopName;
        [FieldOffset(0x38)] public UnmanagedString cameraShakeName;
        [FieldOffset(0x48)] public Kind practice;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C00)]
    public struct EnemyAttackRecordBaseTable
    {
        [FieldOffset(0x00)] public EnemyAttackRecord data__arr0;
        [FieldOffset(0x50)] public EnemyAttackRecord data__arr1;
        [FieldOffset(0xA0)] public EnemyAttackRecord data__arr2;
        [FieldOffset(0xF0)] public EnemyAttackRecord data__arr3;
        [FieldOffset(0x140)] public EnemyAttackRecord data__arr4;
        [FieldOffset(0x190)] public EnemyAttackRecord data__arr5;
        [FieldOffset(0x1E0)] public EnemyAttackRecord data__arr6;
        [FieldOffset(0x230)] public EnemyAttackRecord data__arr7;
        [FieldOffset(0x280)] public EnemyAttackRecord data__arr8;
        [FieldOffset(0x2D0)] public EnemyAttackRecord data__arr9;
        [FieldOffset(0x320)] public EnemyAttackRecord data__arr10;
        [FieldOffset(0x370)] public EnemyAttackRecord data__arr11;
        [FieldOffset(0x3C0)] public EnemyAttackRecord data__arr12;
        [FieldOffset(0x410)] public EnemyAttackRecord data__arr13;
        [FieldOffset(0x460)] public EnemyAttackRecord data__arr14;
        [FieldOffset(0x4B0)] public EnemyAttackRecord data__arr15;
        [FieldOffset(0x500)] public EnemyAttackRecord data__arr16;
        [FieldOffset(0x550)] public EnemyAttackRecord data__arr17;
        [FieldOffset(0x5A0)] public EnemyAttackRecord data__arr18;
        [FieldOffset(0x5F0)] public EnemyAttackRecord data__arr19;
        [FieldOffset(0x640)] public EnemyAttackRecord data__arr20;
        [FieldOffset(0x690)] public EnemyAttackRecord data__arr21;
        [FieldOffset(0x6E0)] public EnemyAttackRecord data__arr22;
        [FieldOffset(0x730)] public EnemyAttackRecord data__arr23;
        [FieldOffset(0x780)] public EnemyAttackRecord data__arr24;
        [FieldOffset(0x7D0)] public EnemyAttackRecord data__arr25;
        [FieldOffset(0x820)] public EnemyAttackRecord data__arr26;
        [FieldOffset(0x870)] public EnemyAttackRecord data__arr27;
        [FieldOffset(0x8C0)] public EnemyAttackRecord data__arr28;
        [FieldOffset(0x910)] public EnemyAttackRecord data__arr29;
        [FieldOffset(0x960)] public EnemyAttackRecord data__arr30;
        [FieldOffset(0x9B0)] public EnemyAttackRecord data__arr31;
        [FieldOffset(0xA00)] public EnemyAttackRecord data__arr32;
        [FieldOffset(0xA50)] public EnemyAttackRecord data__arr33;
        [FieldOffset(0xAA0)] public EnemyAttackRecord data__arr34;
        [FieldOffset(0xAF0)] public EnemyAttackRecord data__arr35;
        [FieldOffset(0xB40)] public EnemyAttackRecord data__arr36;
        [FieldOffset(0xB90)] public EnemyAttackRecord data__arr37;
        [FieldOffset(0xBE0)] public EnemyAttackRecord data__arr38;
        [FieldOffset(0xC30)] public EnemyAttackRecord data__arr39;
        [FieldOffset(0xC80)] public EnemyAttackRecord data__arr40;
        [FieldOffset(0xCD0)] public EnemyAttackRecord data__arr41;
        [FieldOffset(0xD20)] public EnemyAttackRecord data__arr42;
        [FieldOffset(0xD70)] public EnemyAttackRecord data__arr43;
        [FieldOffset(0xDC0)] public EnemyAttackRecord data__arr44;
        [FieldOffset(0xE10)] public EnemyAttackRecord data__arr45;
        [FieldOffset(0xE60)] public EnemyAttackRecord data__arr46;
        [FieldOffset(0xEB0)] public EnemyAttackRecord data__arr47;
        [FieldOffset(0xF00)] public EnemyAttackRecord data__arr48;
        [FieldOffset(0xF50)] public EnemyAttackRecord data__arr49;
        [FieldOffset(0xFA0)] public EnemyAttackRecord data__arr50;
        [FieldOffset(0xFF0)] public EnemyAttackRecord data__arr51;
        [FieldOffset(0x1040)] public EnemyAttackRecord data__arr52;
        [FieldOffset(0x1090)] public EnemyAttackRecord data__arr53;
        [FieldOffset(0x10E0)] public EnemyAttackRecord data__arr54;
        [FieldOffset(0x1130)] public EnemyAttackRecord data__arr55;
        [FieldOffset(0x1180)] public EnemyAttackRecord data__arr56;
        [FieldOffset(0x11D0)] public EnemyAttackRecord data__arr57;
        [FieldOffset(0x1220)] public EnemyAttackRecord data__arr58;
        [FieldOffset(0x1270)] public EnemyAttackRecord data__arr59;
        [FieldOffset(0x12C0)] public EnemyAttackRecord data__arr60;
        [FieldOffset(0x1310)] public EnemyAttackRecord data__arr61;
        [FieldOffset(0x1360)] public EnemyAttackRecord data__arr62;
        [FieldOffset(0x13B0)] public EnemyAttackRecord data__arr63;
        [FieldOffset(0x1400)] public EnemyAttackRecord data__arr64;
        [FieldOffset(0x1450)] public EnemyAttackRecord data__arr65;
        [FieldOffset(0x14A0)] public EnemyAttackRecord data__arr66;
        [FieldOffset(0x14F0)] public EnemyAttackRecord data__arr67;
        [FieldOffset(0x1540)] public EnemyAttackRecord data__arr68;
        [FieldOffset(0x1590)] public EnemyAttackRecord data__arr69;
        [FieldOffset(0x15E0)] public EnemyAttackRecord data__arr70;
        [FieldOffset(0x1630)] public EnemyAttackRecord data__arr71;
        [FieldOffset(0x1680)] public EnemyAttackRecord data__arr72;
        [FieldOffset(0x16D0)] public EnemyAttackRecord data__arr73;
        [FieldOffset(0x1720)] public EnemyAttackRecord data__arr74;
        [FieldOffset(0x1770)] public EnemyAttackRecord data__arr75;
        [FieldOffset(0x17C0)] public EnemyAttackRecord data__arr76;
        [FieldOffset(0x1810)] public EnemyAttackRecord data__arr77;
        [FieldOffset(0x1860)] public EnemyAttackRecord data__arr78;
        [FieldOffset(0x18B0)] public EnemyAttackRecord data__arr79;
        [FieldOffset(0x1900)] public EnemyAttackRecord data__arr80;
        [FieldOffset(0x1950)] public EnemyAttackRecord data__arr81;
        [FieldOffset(0x19A0)] public EnemyAttackRecord data__arr82;
        [FieldOffset(0x19F0)] public EnemyAttackRecord data__arr83;
        [FieldOffset(0x1A40)] public EnemyAttackRecord data__arr84;
        [FieldOffset(0x1A90)] public EnemyAttackRecord data__arr85;
        [FieldOffset(0x1AE0)] public EnemyAttackRecord data__arr86;
        [FieldOffset(0x1B30)] public EnemyAttackRecord data__arr87;
        [FieldOffset(0x1B80)] public EnemyAttackRecord data__arr88;
        [FieldOffset(0x1BD0)] public EnemyAttackRecord data__arr89;
        [FieldOffset(0x1C20)] public EnemyAttackRecord data__arr90;
        [FieldOffset(0x1C70)] public EnemyAttackRecord data__arr91;
        [FieldOffset(0x1CC0)] public EnemyAttackRecord data__arr92;
        [FieldOffset(0x1D10)] public EnemyAttackRecord data__arr93;
        [FieldOffset(0x1D60)] public EnemyAttackRecord data__arr94;
        [FieldOffset(0x1DB0)] public EnemyAttackRecord data__arr95;
        [FieldOffset(0x1E00)] public EnemyAttackRecord data__arr96;
        [FieldOffset(0x1E50)] public EnemyAttackRecord data__arr97;
        [FieldOffset(0x1EA0)] public EnemyAttackRecord data__arr98;
        [FieldOffset(0x1EF0)] public EnemyAttackRecord data__arr99;
        [FieldOffset(0x1F40)] public EnemyAttackRecord data__arr100;
        [FieldOffset(0x1F90)] public EnemyAttackRecord data__arr101;
        [FieldOffset(0x1FE0)] public EnemyAttackRecord data__arr102;
        [FieldOffset(0x2030)] public EnemyAttackRecord data__arr103;
        [FieldOffset(0x2080)] public EnemyAttackRecord data__arr104;
        [FieldOffset(0x20D0)] public EnemyAttackRecord data__arr105;
        [FieldOffset(0x2120)] public EnemyAttackRecord data__arr106;
        [FieldOffset(0x2170)] public EnemyAttackRecord data__arr107;
        [FieldOffset(0x21C0)] public EnemyAttackRecord data__arr108;
        [FieldOffset(0x2210)] public EnemyAttackRecord data__arr109;
        [FieldOffset(0x2260)] public EnemyAttackRecord data__arr110;
        [FieldOffset(0x22B0)] public EnemyAttackRecord data__arr111;
        [FieldOffset(0x2300)] public EnemyAttackRecord data__arr112;
        [FieldOffset(0x2350)] public EnemyAttackRecord data__arr113;
        [FieldOffset(0x23A0)] public EnemyAttackRecord data__arr114;
        [FieldOffset(0x23F0)] public EnemyAttackRecord data__arr115;
        [FieldOffset(0x2440)] public EnemyAttackRecord data__arr116;
        [FieldOffset(0x2490)] public EnemyAttackRecord data__arr117;
        [FieldOffset(0x24E0)] public EnemyAttackRecord data__arr118;
        [FieldOffset(0x2530)] public EnemyAttackRecord data__arr119;
        [FieldOffset(0x2580)] public EnemyAttackRecord data__arr120;
        [FieldOffset(0x25D0)] public EnemyAttackRecord data__arr121;
        [FieldOffset(0x2620)] public EnemyAttackRecord data__arr122;
        [FieldOffset(0x2670)] public EnemyAttackRecord data__arr123;
        [FieldOffset(0x26C0)] public EnemyAttackRecord data__arr124;
        [FieldOffset(0x2710)] public EnemyAttackRecord data__arr125;
        [FieldOffset(0x2760)] public EnemyAttackRecord data__arr126;
        [FieldOffset(0x27B0)] public EnemyAttackRecord data__arr127;
        [FieldOffset(0x2800)] public EnemyAttackRecord data__arr128;
        [FieldOffset(0x2850)] public EnemyAttackRecord data__arr129;
        [FieldOffset(0x28A0)] public EnemyAttackRecord data__arr130;
        [FieldOffset(0x28F0)] public EnemyAttackRecord data__arr131;
        [FieldOffset(0x2940)] public EnemyAttackRecord data__arr132;
        [FieldOffset(0x2990)] public EnemyAttackRecord data__arr133;
        [FieldOffset(0x29E0)] public EnemyAttackRecord data__arr134;
        [FieldOffset(0x2A30)] public EnemyAttackRecord data__arr135;
        [FieldOffset(0x2A80)] public EnemyAttackRecord data__arr136;
        [FieldOffset(0x2AD0)] public EnemyAttackRecord data__arr137;
        [FieldOffset(0x2B20)] public EnemyAttackRecord data__arr138;
        [FieldOffset(0x2B70)] public EnemyAttackRecord data__arr139;
        [FieldOffset(0x2BC0)] public EnemyAttackRecord data__arr140;
        [FieldOffset(0x2C10)] public EnemyAttackRecord data__arr141;
        [FieldOffset(0x2C60)] public EnemyAttackRecord data__arr142;
        [FieldOffset(0x2CB0)] public EnemyAttackRecord data__arr143;
        [FieldOffset(0x2D00)] public EnemyAttackRecord data__arr144;
        [FieldOffset(0x2D50)] public EnemyAttackRecord data__arr145;
        [FieldOffset(0x2DA0)] public EnemyAttackRecord data__arr146;
        [FieldOffset(0x2DF0)] public EnemyAttackRecord data__arr147;
        [FieldOffset(0x2E40)] public EnemyAttackRecord data__arr148;
        [FieldOffset(0x2E90)] public EnemyAttackRecord data__arr149;
        [FieldOffset(0x2EE0)] public EnemyAttackRecord data__arr150;
        [FieldOffset(0x2F30)] public EnemyAttackRecord data__arr151;
        [FieldOffset(0x2F80)] public EnemyAttackRecord data__arr152;
        [FieldOffset(0x2FD0)] public EnemyAttackRecord data__arr153;
        [FieldOffset(0x3020)] public EnemyAttackRecord data__arr154;
        [FieldOffset(0x3070)] public EnemyAttackRecord data__arr155;
        [FieldOffset(0x30C0)] public EnemyAttackRecord data__arr156;
        [FieldOffset(0x3110)] public EnemyAttackRecord data__arr157;
        [FieldOffset(0x3160)] public EnemyAttackRecord data__arr158;
        [FieldOffset(0x31B0)] public EnemyAttackRecord data__arr159;
        [FieldOffset(0x3200)] public EnemyAttackRecord data__arr160;
        [FieldOffset(0x3250)] public EnemyAttackRecord data__arr161;
        [FieldOffset(0x32A0)] public EnemyAttackRecord data__arr162;
        [FieldOffset(0x32F0)] public EnemyAttackRecord data__arr163;
        [FieldOffset(0x3340)] public EnemyAttackRecord data__arr164;
        [FieldOffset(0x3390)] public EnemyAttackRecord data__arr165;
        [FieldOffset(0x33E0)] public EnemyAttackRecord data__arr166;
        [FieldOffset(0x3430)] public EnemyAttackRecord data__arr167;
        [FieldOffset(0x3480)] public EnemyAttackRecord data__arr168;
        [FieldOffset(0x34D0)] public EnemyAttackRecord data__arr169;
        [FieldOffset(0x3520)] public EnemyAttackRecord data__arr170;
        [FieldOffset(0x3570)] public EnemyAttackRecord data__arr171;
        [FieldOffset(0x35C0)] public EnemyAttackRecord data__arr172;
        [FieldOffset(0x3610)] public EnemyAttackRecord data__arr173;
        [FieldOffset(0x3660)] public EnemyAttackRecord data__arr174;
        [FieldOffset(0x36B0)] public EnemyAttackRecord data__arr175;
        [FieldOffset(0x3700)] public EnemyAttackRecord data__arr176;
        [FieldOffset(0x3750)] public EnemyAttackRecord data__arr177;
        [FieldOffset(0x37A0)] public EnemyAttackRecord data__arr178;
        [FieldOffset(0x37F0)] public EnemyAttackRecord data__arr179;
        [FieldOffset(0x3840)] public EnemyAttackRecord data__arr180;
        [FieldOffset(0x3890)] public EnemyAttackRecord data__arr181;
        [FieldOffset(0x38E0)] public EnemyAttackRecord data__arr182;
        [FieldOffset(0x3930)] public EnemyAttackRecord data__arr183;
        [FieldOffset(0x3980)] public EnemyAttackRecord data__arr184;
        [FieldOffset(0x39D0)] public EnemyAttackRecord data__arr185;
        [FieldOffset(0x3A20)] public EnemyAttackRecord data__arr186;
        [FieldOffset(0x3A70)] public EnemyAttackRecord data__arr187;
        [FieldOffset(0x3AC0)] public EnemyAttackRecord data__arr188;
        [FieldOffset(0x3B10)] public EnemyAttackRecord data__arr189;
        [FieldOffset(0x3B60)] public EnemyAttackRecord data__arr190;
        [FieldOffset(0x3BB0)] public EnemyAttackRecord data__arr191;
    }

}