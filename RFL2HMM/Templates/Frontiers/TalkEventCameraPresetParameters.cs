using System.Numerics;
using System.Runtime.InteropServices;

public class TalkEventCameraPresetParametersClass
{
    public enum GazePositionType : sbyte
    {
        Base = 0,
        Head = 1,
        Eye = 2,
        Center = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct TalkEventCameraPresetParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public GazePositionType primaryTarget;
        [FieldOffset(0x02)] public GazePositionType secondaryTarget;
        [FieldOffset(0x04)] public float targetRatio;
        [FieldOffset(0x08)] public float rotateDegreePitch;
        [FieldOffset(0x0C)] public float rotateDegreeYaw;
        [FieldOffset(0x10)] public float cameraOffsetRatio;
        [FieldOffset(0x14)] public float fovy;
        [FieldOffset(0x18)] public float targetOffsetX;
        [FieldOffset(0x1C)] public float targetOffsetY;
        [FieldOffset(0x20)] public float targetOffsetZ;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x240)]
    public struct TalkEventCameraPresetParameters
    {
        [FieldOffset(0x00)] public TalkEventCameraPresetParameter param__arr0;
        [FieldOffset(0x24)] public TalkEventCameraPresetParameter param__arr1;
        [FieldOffset(0x48)] public TalkEventCameraPresetParameter param__arr2;
        [FieldOffset(0x6C)] public TalkEventCameraPresetParameter param__arr3;
        [FieldOffset(0x90)] public TalkEventCameraPresetParameter param__arr4;
        [FieldOffset(0xB4)] public TalkEventCameraPresetParameter param__arr5;
        [FieldOffset(0xD8)] public TalkEventCameraPresetParameter param__arr6;
        [FieldOffset(0xFC)] public TalkEventCameraPresetParameter param__arr7;
        [FieldOffset(0x120)] public TalkEventCameraPresetParameter param__arr8;
        [FieldOffset(0x144)] public TalkEventCameraPresetParameter param__arr9;
        [FieldOffset(0x168)] public TalkEventCameraPresetParameter param__arr10;
        [FieldOffset(0x18C)] public TalkEventCameraPresetParameter param__arr11;
        [FieldOffset(0x1B0)] public TalkEventCameraPresetParameter param__arr12;
        [FieldOffset(0x1D4)] public TalkEventCameraPresetParameter param__arr13;
        [FieldOffset(0x1F8)] public TalkEventCameraPresetParameter param__arr14;
        [FieldOffset(0x21C)] public TalkEventCameraPresetParameter param__arr15;
    }

}