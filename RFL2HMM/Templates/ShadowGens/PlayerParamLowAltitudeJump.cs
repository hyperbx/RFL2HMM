Library "PlayerParamLowAltitudeJump"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct PlayerParamLowAltitudeJump
    {
        [FieldOffset(0x00)] public float upSpeed;
        [FieldOffset(0x04)] public float frontSpeed;
        [FieldOffset(0x08)] public float damperV;
        [FieldOffset(0x0C)] public float damperH;
        [FieldOffset(0x10)] public float gravity;
        [FieldOffset(0x14)] public float time;
    }

}