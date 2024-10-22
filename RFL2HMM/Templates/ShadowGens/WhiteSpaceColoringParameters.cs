Library "WhiteSpaceColoringParameters"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct WhiteSpaceVanishingParameter
    {
        [FieldOffset(0x00)] public float m_startHeight;
        [FieldOffset(0x04)] public float m_endHeight;
        [FieldOffset(0x08)] public float m_coloringSpeed;
        [FieldOffset(0x0C)] public float m_width;
        [FieldOffset(0x10)] public float m_noisePower;
        [FieldOffset(0x14)] public float m_noiseSpeed;
        [FieldOffset(0x18)] public float m_rgb__arr0;
        [FieldOffset(0x1C)] public float m_rgb__arr1;
        [FieldOffset(0x20)] public float m_rgb__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct WhiteSpaceMaterialLuminesParameter
    {
        [FieldOffset(0x00)] public float m_width;
        [FieldOffset(0x04)] public float m_luminesPower;
        [FieldOffset(0x08)] public float m_luminesColoringWitdh;
        [FieldOffset(0x0C)] public float m_luminesOffset;
        [FieldOffset(0x10)] public float m_rgb__arr0;
        [FieldOffset(0x14)] public float m_rgb__arr1;
        [FieldOffset(0x18)] public float m_rgb__arr2;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct WhiteSpaceColoringParameter
    {
        [FieldOffset(0x00)] public float m_startHeight;
        [FieldOffset(0x04)] public float m_endHeight;
        [FieldOffset(0x08)] public float m_coloringSpeed;
        [FieldOffset(0x0C)] public float m_startEffectTime;
        [FieldOffset(0x10)] public float m_cameraStartHeight;
        [FieldOffset(0x14)] public float m_cameraEndHeight;
        [FieldOffset(0x18)] public float m_middleHeight;
        [FieldOffset(0x1C)] public WhiteSpaceMaterialLuminesParameter luminesParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct WhiteSpaceStageGateColoringParameter
    {
        [FieldOffset(0x00)] public WhiteSpaceColoringParameter coloringParam__arr0;
        [FieldOffset(0x38)] public WhiteSpaceColoringParameter coloringParam__arr1;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x424)]
    public struct WhiteSpaceColoringParameters
    {
        [FieldOffset(0x00)] public WhiteSpaceVanishingParameter vainishParam;
        [FieldOffset(0x24)] public WhiteSpaceColoringParameter coloringParam__arr0;
        [FieldOffset(0x5C)] public WhiteSpaceColoringParameter coloringParam__arr1;
        [FieldOffset(0x94)] public WhiteSpaceColoringParameter coloringParam__arr2;
        [FieldOffset(0xCC)] public WhiteSpaceColoringParameter coloringParam__arr3;
        [FieldOffset(0x104)] public WhiteSpaceColoringParameter coloringParam__arr4;
        [FieldOffset(0x13C)] public WhiteSpaceStageGateColoringParameter stagegateParam__arr0;
        [FieldOffset(0x1AC)] public WhiteSpaceStageGateColoringParameter stagegateParam__arr1;
        [FieldOffset(0x21C)] public WhiteSpaceStageGateColoringParameter stagegateParam__arr2;
        [FieldOffset(0x28C)] public WhiteSpaceStageGateColoringParameter stagegateParam__arr3;
        [FieldOffset(0x2FC)] public WhiteSpaceStageGateColoringParameter stagegateParam__arr4;
        [FieldOffset(0x36C)] public WhiteSpaceStageGateColoringParameter stagegateParam__arr5;
        [FieldOffset(0x3DC)] public WhiteSpaceVanishingParameter eclipseParam;
        [FieldOffset(0x400)] public WhiteSpaceVanishingParameter eclipseEndParam;
    }

}