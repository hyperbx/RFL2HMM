using System.Numerics;
using System.Runtime.InteropServices;

public class EffectRecordBaseTableClass
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

            set => pValue = Marshal.StringToHGlobalAnsi(value);
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

    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct EffectRecord
    {
        [FieldOffset(0)] public Record record;
        [FieldOffset(0x08)] public UnmanagedString emitterSetName__arr0;
        [FieldOffset(0x107)] public UnmanagedString emitterSetName__arr1;
        [FieldOffset(0x206)] public UnmanagedString emitterSetName__arr2;
        [FieldOffset(0x305)] public UnmanagedString emitterSetName__arr3;
        [FieldOffset(0x404)] public UnmanagedString emitterSetName__arr4;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2260)]
    public struct EffectRecordBaseTable
    {
        [FieldOffset(0x00)] public EffectRecord data__arr0;
        [FieldOffset(0x58)] public EffectRecord data__arr1;
        [FieldOffset(0xB0)] public EffectRecord data__arr2;
        [FieldOffset(0x108)] public EffectRecord data__arr3;
        [FieldOffset(0x160)] public EffectRecord data__arr4;
        [FieldOffset(0x1B8)] public EffectRecord data__arr5;
        [FieldOffset(0x210)] public EffectRecord data__arr6;
        [FieldOffset(0x268)] public EffectRecord data__arr7;
        [FieldOffset(0x2C0)] public EffectRecord data__arr8;
        [FieldOffset(0x318)] public EffectRecord data__arr9;
        [FieldOffset(0x370)] public EffectRecord data__arr10;
        [FieldOffset(0x3C8)] public EffectRecord data__arr11;
        [FieldOffset(0x420)] public EffectRecord data__arr12;
        [FieldOffset(0x478)] public EffectRecord data__arr13;
        [FieldOffset(0x4D0)] public EffectRecord data__arr14;
        [FieldOffset(0x528)] public EffectRecord data__arr15;
        [FieldOffset(0x580)] public EffectRecord data__arr16;
        [FieldOffset(0x5D8)] public EffectRecord data__arr17;
        [FieldOffset(0x630)] public EffectRecord data__arr18;
        [FieldOffset(0x688)] public EffectRecord data__arr19;
        [FieldOffset(0x6E0)] public EffectRecord data__arr20;
        [FieldOffset(0x738)] public EffectRecord data__arr21;
        [FieldOffset(0x790)] public EffectRecord data__arr22;
        [FieldOffset(0x7E8)] public EffectRecord data__arr23;
        [FieldOffset(0x840)] public EffectRecord data__arr24;
        [FieldOffset(0x898)] public EffectRecord data__arr25;
        [FieldOffset(0x8F0)] public EffectRecord data__arr26;
        [FieldOffset(0x948)] public EffectRecord data__arr27;
        [FieldOffset(0x9A0)] public EffectRecord data__arr28;
        [FieldOffset(0x9F8)] public EffectRecord data__arr29;
        [FieldOffset(0xA50)] public EffectRecord data__arr30;
        [FieldOffset(0xAA8)] public EffectRecord data__arr31;
        [FieldOffset(0xB00)] public EffectRecord data__arr32;
        [FieldOffset(0xB58)] public EffectRecord data__arr33;
        [FieldOffset(0xBB0)] public EffectRecord data__arr34;
        [FieldOffset(0xC08)] public EffectRecord data__arr35;
        [FieldOffset(0xC60)] public EffectRecord data__arr36;
        [FieldOffset(0xCB8)] public EffectRecord data__arr37;
        [FieldOffset(0xD10)] public EffectRecord data__arr38;
        [FieldOffset(0xD68)] public EffectRecord data__arr39;
        [FieldOffset(0xDC0)] public EffectRecord data__arr40;
        [FieldOffset(0xE18)] public EffectRecord data__arr41;
        [FieldOffset(0xE70)] public EffectRecord data__arr42;
        [FieldOffset(0xEC8)] public EffectRecord data__arr43;
        [FieldOffset(0xF20)] public EffectRecord data__arr44;
        [FieldOffset(0xF78)] public EffectRecord data__arr45;
        [FieldOffset(0xFD0)] public EffectRecord data__arr46;
        [FieldOffset(0x1028)] public EffectRecord data__arr47;
        [FieldOffset(0x1080)] public EffectRecord data__arr48;
        [FieldOffset(0x10D8)] public EffectRecord data__arr49;
        [FieldOffset(0x1130)] public EffectRecord data__arr50;
        [FieldOffset(0x1188)] public EffectRecord data__arr51;
        [FieldOffset(0x11E0)] public EffectRecord data__arr52;
        [FieldOffset(0x1238)] public EffectRecord data__arr53;
        [FieldOffset(0x1290)] public EffectRecord data__arr54;
        [FieldOffset(0x12E8)] public EffectRecord data__arr55;
        [FieldOffset(0x1340)] public EffectRecord data__arr56;
        [FieldOffset(0x1398)] public EffectRecord data__arr57;
        [FieldOffset(0x13F0)] public EffectRecord data__arr58;
        [FieldOffset(0x1448)] public EffectRecord data__arr59;
        [FieldOffset(0x14A0)] public EffectRecord data__arr60;
        [FieldOffset(0x14F8)] public EffectRecord data__arr61;
        [FieldOffset(0x1550)] public EffectRecord data__arr62;
        [FieldOffset(0x15A8)] public EffectRecord data__arr63;
        [FieldOffset(0x1600)] public EffectRecord data__arr64;
        [FieldOffset(0x1658)] public EffectRecord data__arr65;
        [FieldOffset(0x16B0)] public EffectRecord data__arr66;
        [FieldOffset(0x1708)] public EffectRecord data__arr67;
        [FieldOffset(0x1760)] public EffectRecord data__arr68;
        [FieldOffset(0x17B8)] public EffectRecord data__arr69;
        [FieldOffset(0x1810)] public EffectRecord data__arr70;
        [FieldOffset(0x1868)] public EffectRecord data__arr71;
        [FieldOffset(0x18C0)] public EffectRecord data__arr72;
        [FieldOffset(0x1918)] public EffectRecord data__arr73;
        [FieldOffset(0x1970)] public EffectRecord data__arr74;
        [FieldOffset(0x19C8)] public EffectRecord data__arr75;
        [FieldOffset(0x1A20)] public EffectRecord data__arr76;
        [FieldOffset(0x1A78)] public EffectRecord data__arr77;
        [FieldOffset(0x1AD0)] public EffectRecord data__arr78;
        [FieldOffset(0x1B28)] public EffectRecord data__arr79;
        [FieldOffset(0x1B80)] public EffectRecord data__arr80;
        [FieldOffset(0x1BD8)] public EffectRecord data__arr81;
        [FieldOffset(0x1C30)] public EffectRecord data__arr82;
        [FieldOffset(0x1C88)] public EffectRecord data__arr83;
        [FieldOffset(0x1CE0)] public EffectRecord data__arr84;
        [FieldOffset(0x1D38)] public EffectRecord data__arr85;
        [FieldOffset(0x1D90)] public EffectRecord data__arr86;
        [FieldOffset(0x1DE8)] public EffectRecord data__arr87;
        [FieldOffset(0x1E40)] public EffectRecord data__arr88;
        [FieldOffset(0x1E98)] public EffectRecord data__arr89;
        [FieldOffset(0x1EF0)] public EffectRecord data__arr90;
        [FieldOffset(0x1F48)] public EffectRecord data__arr91;
        [FieldOffset(0x1FA0)] public EffectRecord data__arr92;
        [FieldOffset(0x1FF8)] public EffectRecord data__arr93;
        [FieldOffset(0x2050)] public EffectRecord data__arr94;
        [FieldOffset(0x20A8)] public EffectRecord data__arr95;
        [FieldOffset(0x2100)] public EffectRecord data__arr96;
        [FieldOffset(0x2158)] public EffectRecord data__arr97;
        [FieldOffset(0x21B0)] public EffectRecord data__arr98;
        [FieldOffset(0x2208)] public EffectRecord data__arr99;
    }

}