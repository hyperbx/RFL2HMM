using System.Numerics;
using System.Runtime.InteropServices;

public class GameGrassInteractionParameterClass
{
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

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct GameGrassInteractionParameterData
    {
        [FieldOffset(0x00)] public UnmanagedString name;
        [FieldOffset(0x10)] public float radius;
        [FieldOffset(0x14)] public float height;
        [FieldOffset(0x18)] public float power;
        [FieldOffset(0x1C)] public bool moveHitEnabled;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x400)]
    public struct GameGrassInteractionParameter
    {
        [FieldOffset(0x00)] public GameGrassInteractionParameterData data__arr0;
        [FieldOffset(0x20)] public GameGrassInteractionParameterData data__arr1;
        [FieldOffset(0x40)] public GameGrassInteractionParameterData data__arr2;
        [FieldOffset(0x60)] public GameGrassInteractionParameterData data__arr3;
        [FieldOffset(0x80)] public GameGrassInteractionParameterData data__arr4;
        [FieldOffset(0xA0)] public GameGrassInteractionParameterData data__arr5;
        [FieldOffset(0xC0)] public GameGrassInteractionParameterData data__arr6;
        [FieldOffset(0xE0)] public GameGrassInteractionParameterData data__arr7;
        [FieldOffset(0x100)] public GameGrassInteractionParameterData data__arr8;
        [FieldOffset(0x120)] public GameGrassInteractionParameterData data__arr9;
        [FieldOffset(0x140)] public GameGrassInteractionParameterData data__arr10;
        [FieldOffset(0x160)] public GameGrassInteractionParameterData data__arr11;
        [FieldOffset(0x180)] public GameGrassInteractionParameterData data__arr12;
        [FieldOffset(0x1A0)] public GameGrassInteractionParameterData data__arr13;
        [FieldOffset(0x1C0)] public GameGrassInteractionParameterData data__arr14;
        [FieldOffset(0x1E0)] public GameGrassInteractionParameterData data__arr15;
        [FieldOffset(0x200)] public GameGrassInteractionParameterData data__arr16;
        [FieldOffset(0x220)] public GameGrassInteractionParameterData data__arr17;
        [FieldOffset(0x240)] public GameGrassInteractionParameterData data__arr18;
        [FieldOffset(0x260)] public GameGrassInteractionParameterData data__arr19;
        [FieldOffset(0x280)] public GameGrassInteractionParameterData data__arr20;
        [FieldOffset(0x2A0)] public GameGrassInteractionParameterData data__arr21;
        [FieldOffset(0x2C0)] public GameGrassInteractionParameterData data__arr22;
        [FieldOffset(0x2E0)] public GameGrassInteractionParameterData data__arr23;
        [FieldOffset(0x300)] public GameGrassInteractionParameterData data__arr24;
        [FieldOffset(0x320)] public GameGrassInteractionParameterData data__arr25;
        [FieldOffset(0x340)] public GameGrassInteractionParameterData data__arr26;
        [FieldOffset(0x360)] public GameGrassInteractionParameterData data__arr27;
        [FieldOffset(0x380)] public GameGrassInteractionParameterData data__arr28;
        [FieldOffset(0x3A0)] public GameGrassInteractionParameterData data__arr29;
        [FieldOffset(0x3C0)] public GameGrassInteractionParameterData data__arr30;
        [FieldOffset(0x3E0)] public GameGrassInteractionParameterData data__arr31;
    }

}