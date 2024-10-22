Library "TalkEventCameraPresetParameters"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum GazePositionType : sbyte
    {
        Base = 0,
        Head = 1,
        Eye = 2,
        Center = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
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
        [FieldOffset(0x24)] public float easeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x280)]
    public struct TalkEventCameraPresetParameters
    {
        [FieldOffset(0x00)] public TalkEventCameraPresetParameter param__arr0;
        [FieldOffset(0x28)] public TalkEventCameraPresetParameter param__arr1;
        [FieldOffset(0x50)] public TalkEventCameraPresetParameter param__arr2;
        [FieldOffset(0x78)] public TalkEventCameraPresetParameter param__arr3;
        [FieldOffset(0xA0)] public TalkEventCameraPresetParameter param__arr4;
        [FieldOffset(0xC8)] public TalkEventCameraPresetParameter param__arr5;
        [FieldOffset(0xF0)] public TalkEventCameraPresetParameter param__arr6;
        [FieldOffset(0x118)] public TalkEventCameraPresetParameter param__arr7;
        [FieldOffset(0x140)] public TalkEventCameraPresetParameter param__arr8;
        [FieldOffset(0x168)] public TalkEventCameraPresetParameter param__arr9;
        [FieldOffset(0x190)] public TalkEventCameraPresetParameter param__arr10;
        [FieldOffset(0x1B8)] public TalkEventCameraPresetParameter param__arr11;
        [FieldOffset(0x1E0)] public TalkEventCameraPresetParameter param__arr12;
        [FieldOffset(0x208)] public TalkEventCameraPresetParameter param__arr13;
        [FieldOffset(0x230)] public TalkEventCameraPresetParameter param__arr14;
        [FieldOffset(0x258)] public TalkEventCameraPresetParameter param__arr15;
    }

}