Library "DevConfigParameters"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum ReplayMode : sbyte
    {
        REPLAY_MODE_OFF = 0,
        REPLAY_MODE_RECORD = 1,
        REPLAY_MODE_PLAY = 2,
        REPLAY_MODE_GHOST = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x05)]
    public struct DevConfigParameters
    {
        [FieldOffset(0x00)] public bool autoSaveEnabled;
        [FieldOffset(0x01)] public bool gismoEnabled;
        [FieldOffset(0x02)] public bool reportEnabled;
        [FieldOffset(0x03)] public bool creditsEnabled;
        [FieldOffset(0x04)] public ReplayMode replayMode;
    }

}