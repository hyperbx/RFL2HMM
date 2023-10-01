using System.Numerics;
using System.Runtime.InteropServices;

public class EnemyDefenceRecordBaseTableClass
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

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct EnemyDefenceRecord
    {
        [FieldOffset(0)]  public Record record;
        [FieldOffset(0x08)] public UnmanagedString name;
        [FieldOffset(0x18)] public float baseRate;
        [FieldOffset(0x1C)] public float slashRate;
        [FieldOffset(0x20)] public float quickRate;
        [FieldOffset(0x24)] public float stunRate;
        [FieldOffset(0x28)] public float staggerRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xC00)]
    public struct EnemyDefenceRecordBaseTable
    {
        [FieldOffset(0x00)] public EnemyDefenceRecord data__arr0;
        [FieldOffset(0x30)] public EnemyDefenceRecord data__arr1;
        [FieldOffset(0x60)] public EnemyDefenceRecord data__arr2;
        [FieldOffset(0x90)] public EnemyDefenceRecord data__arr3;
        [FieldOffset(0xC0)] public EnemyDefenceRecord data__arr4;
        [FieldOffset(0xF0)] public EnemyDefenceRecord data__arr5;
        [FieldOffset(0x120)] public EnemyDefenceRecord data__arr6;
        [FieldOffset(0x150)] public EnemyDefenceRecord data__arr7;
        [FieldOffset(0x180)] public EnemyDefenceRecord data__arr8;
        [FieldOffset(0x1B0)] public EnemyDefenceRecord data__arr9;
        [FieldOffset(0x1E0)] public EnemyDefenceRecord data__arr10;
        [FieldOffset(0x210)] public EnemyDefenceRecord data__arr11;
        [FieldOffset(0x240)] public EnemyDefenceRecord data__arr12;
        [FieldOffset(0x270)] public EnemyDefenceRecord data__arr13;
        [FieldOffset(0x2A0)] public EnemyDefenceRecord data__arr14;
        [FieldOffset(0x2D0)] public EnemyDefenceRecord data__arr15;
        [FieldOffset(0x300)] public EnemyDefenceRecord data__arr16;
        [FieldOffset(0x330)] public EnemyDefenceRecord data__arr17;
        [FieldOffset(0x360)] public EnemyDefenceRecord data__arr18;
        [FieldOffset(0x390)] public EnemyDefenceRecord data__arr19;
        [FieldOffset(0x3C0)] public EnemyDefenceRecord data__arr20;
        [FieldOffset(0x3F0)] public EnemyDefenceRecord data__arr21;
        [FieldOffset(0x420)] public EnemyDefenceRecord data__arr22;
        [FieldOffset(0x450)] public EnemyDefenceRecord data__arr23;
        [FieldOffset(0x480)] public EnemyDefenceRecord data__arr24;
        [FieldOffset(0x4B0)] public EnemyDefenceRecord data__arr25;
        [FieldOffset(0x4E0)] public EnemyDefenceRecord data__arr26;
        [FieldOffset(0x510)] public EnemyDefenceRecord data__arr27;
        [FieldOffset(0x540)] public EnemyDefenceRecord data__arr28;
        [FieldOffset(0x570)] public EnemyDefenceRecord data__arr29;
        [FieldOffset(0x5A0)] public EnemyDefenceRecord data__arr30;
        [FieldOffset(0x5D0)] public EnemyDefenceRecord data__arr31;
        [FieldOffset(0x600)] public EnemyDefenceRecord data__arr32;
        [FieldOffset(0x630)] public EnemyDefenceRecord data__arr33;
        [FieldOffset(0x660)] public EnemyDefenceRecord data__arr34;
        [FieldOffset(0x690)] public EnemyDefenceRecord data__arr35;
        [FieldOffset(0x6C0)] public EnemyDefenceRecord data__arr36;
        [FieldOffset(0x6F0)] public EnemyDefenceRecord data__arr37;
        [FieldOffset(0x720)] public EnemyDefenceRecord data__arr38;
        [FieldOffset(0x750)] public EnemyDefenceRecord data__arr39;
        [FieldOffset(0x780)] public EnemyDefenceRecord data__arr40;
        [FieldOffset(0x7B0)] public EnemyDefenceRecord data__arr41;
        [FieldOffset(0x7E0)] public EnemyDefenceRecord data__arr42;
        [FieldOffset(0x810)] public EnemyDefenceRecord data__arr43;
        [FieldOffset(0x840)] public EnemyDefenceRecord data__arr44;
        [FieldOffset(0x870)] public EnemyDefenceRecord data__arr45;
        [FieldOffset(0x8A0)] public EnemyDefenceRecord data__arr46;
        [FieldOffset(0x8D0)] public EnemyDefenceRecord data__arr47;
        [FieldOffset(0x900)] public EnemyDefenceRecord data__arr48;
        [FieldOffset(0x930)] public EnemyDefenceRecord data__arr49;
        [FieldOffset(0x960)] public EnemyDefenceRecord data__arr50;
        [FieldOffset(0x990)] public EnemyDefenceRecord data__arr51;
        [FieldOffset(0x9C0)] public EnemyDefenceRecord data__arr52;
        [FieldOffset(0x9F0)] public EnemyDefenceRecord data__arr53;
        [FieldOffset(0xA20)] public EnemyDefenceRecord data__arr54;
        [FieldOffset(0xA50)] public EnemyDefenceRecord data__arr55;
        [FieldOffset(0xA80)] public EnemyDefenceRecord data__arr56;
        [FieldOffset(0xAB0)] public EnemyDefenceRecord data__arr57;
        [FieldOffset(0xAE0)] public EnemyDefenceRecord data__arr58;
        [FieldOffset(0xB10)] public EnemyDefenceRecord data__arr59;
        [FieldOffset(0xB40)] public EnemyDefenceRecord data__arr60;
        [FieldOffset(0xB70)] public EnemyDefenceRecord data__arr61;
        [FieldOffset(0xBA0)] public EnemyDefenceRecord data__arr62;
        [FieldOffset(0xBD0)] public EnemyDefenceRecord data__arr63;
    }

}