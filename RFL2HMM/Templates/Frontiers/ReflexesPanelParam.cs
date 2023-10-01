using System.Numerics;
using System.Runtime.InteropServices;

public class ReflexesPanelParamClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct ReflexesPanelCameraParam
    {
        [FieldOffset(0x00)] public float interoplateTimeActivate;
        [FieldOffset(0x04)] public float interoplateTimeDeactivate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct ReflexesPanelPanelParam
    {
        [FieldOffset(0x00)] public Vector3 collisionHalfExtents;
        [FieldOffset(0x10)] public Vector3 collisionOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct ReflexesPanelParam
    {
        [FieldOffset(0x00)] public ReflexesPanelCameraParam cameraParam;
        [FieldOffset(0x10)] public ReflexesPanelPanelParam panelParam;
    }

}