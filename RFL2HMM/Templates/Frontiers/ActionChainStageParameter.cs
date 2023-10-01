using System.Numerics;
using System.Runtime.InteropServices;

public class ActionChainStageParameterClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct ActionChainScoreThresholdParameter
    {
        [FieldOffset(0x00)] public uint scoreS;
        [FieldOffset(0x04)] public uint scoreA;
        [FieldOffset(0x08)] public uint scoreB;
        [FieldOffset(0x0C)] public uint scoreC;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct ActionChainPlaceParameter
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public ActionChainScoreThresholdParameter scoreEasy;
        [FieldOffset(0x14)] public ActionChainScoreThresholdParameter scoreNormal;
        [FieldOffset(0x24)] public ActionChainScoreThresholdParameter scoreHard;
        [FieldOffset(0x34)] public ActionChainScoreThresholdParameter scoreVeryHard;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x440)]
    public struct ActionChainStageParameter
    {
        [FieldOffset(0x00)] public ActionChainPlaceParameter placeParam__arr0;
        [FieldOffset(0x44)] public ActionChainPlaceParameter placeParam__arr1;
        [FieldOffset(0x88)] public ActionChainPlaceParameter placeParam__arr2;
        [FieldOffset(0xCC)] public ActionChainPlaceParameter placeParam__arr3;
        [FieldOffset(0x110)] public ActionChainPlaceParameter placeParam__arr4;
        [FieldOffset(0x154)] public ActionChainPlaceParameter placeParam__arr5;
        [FieldOffset(0x198)] public ActionChainPlaceParameter placeParam__arr6;
        [FieldOffset(0x1DC)] public ActionChainPlaceParameter placeParam__arr7;
        [FieldOffset(0x220)] public ActionChainPlaceParameter placeParam__arr8;
        [FieldOffset(0x264)] public ActionChainPlaceParameter placeParam__arr9;
        [FieldOffset(0x2A8)] public ActionChainPlaceParameter placeParam__arr10;
        [FieldOffset(0x2EC)] public ActionChainPlaceParameter placeParam__arr11;
        [FieldOffset(0x330)] public ActionChainPlaceParameter placeParam__arr12;
        [FieldOffset(0x374)] public ActionChainPlaceParameter placeParam__arr13;
        [FieldOffset(0x3B8)] public ActionChainPlaceParameter placeParam__arr14;
        [FieldOffset(0x3FC)] public ActionChainPlaceParameter placeParam__arr15;
    }

}