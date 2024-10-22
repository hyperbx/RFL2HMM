Library "SoundCommonParameter"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct BGMVolumeChangeInfo
    {
        [FieldOffset(0x00)] public float value;
        [FieldOffset(0x04)] public float delayTime;
        [FieldOffset(0x08)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct BGMVolumeChangeInfoList
    {
        [FieldOffset(0x00)] public BGMVolumeChangeInfo playerStop;
        [FieldOffset(0x0C)] public BGMVolumeChangeInfo playerWalk;
        [FieldOffset(0x18)] public BGMVolumeChangeInfo playerRun;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct AisacChangeInfo
    {
        [FieldOffset(0x00)] public float value;
        [FieldOffset(0x04)] public float fadeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct AisacChangeInfoList
    {
        [FieldOffset(0x00)] public AisacChangeInfo beginTimeStopBGM;
        [FieldOffset(0x08)] public AisacChangeInfo endTimeStopBGM;
        [FieldOffset(0x10)] public AisacChangeInfo beginTimeStopSE;
        [FieldOffset(0x18)] public AisacChangeInfo endTimeStopSE;
        [FieldOffset(0x20)] public AisacChangeInfo beginUnderWater;
        [FieldOffset(0x28)] public AisacChangeInfo endUnderWater;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x64)]
    public struct SoundCommonParameter
    {
        [FieldOffset(0x00)] public float pauseFadeOutTime;
        [FieldOffset(0x04)] public float pauseFadeInTime;
        [FieldOffset(0x08)] public float enterWhitespaceFadeOutTime;
        [FieldOffset(0x0C)] public float leaveWhitespaceResultFadeOutTime;
        [FieldOffset(0x10)] public BGMVolumeChangeInfoList bgmVolumeInfo;
        [FieldOffset(0x34)] public AisacChangeInfoList aisacInfo;
    }

}