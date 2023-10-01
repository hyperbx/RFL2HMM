Library "FxSMAAParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum Preset : sbyte
    {
        PRESET_SPEED = 0,
        PRESET_QUALITY = 1
    }

    public enum TestMode : sbyte
    {
        TEST_MODE_DISABLE = 0,
        TEST_MODE_1 = 1,
        TEST_MODE_2 = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x02)]
    public struct FxSMAAParameter
    {
        [FieldOffset(0x00)] public Preset preset;
        [FieldOffset(0x01)] public TestMode testMode;
    }

}