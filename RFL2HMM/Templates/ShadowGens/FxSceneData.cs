Library "FxSceneData"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum GIModeTypes : sbyte
    {
        GIMODE_NORMAL = 0,
        GIMODE_ONLY = 1,
        GIMODE_NONE = 2,
        GIMODE_SHADOW = 3,
        GIMODE_SEPARATED = 4
    }

    public enum LightFieldModeTypes : sbyte
    {
        LFMODE_NORMAL = 0,
        LFMODE_ONLY = 1,
        LFMODE_NONE = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FxSceneConfig
    {
        [FieldOffset(0x00)] public float gammaTVWiiU;
        [FieldOffset(0x04)] public float gammaDRCWiiU;
        [FieldOffset(0x08)] public bool fixedLdr;
        [FieldOffset(0x09)] public GIModeTypes giMode;
        [FieldOffset(0x0A)] public LightFieldModeTypes lightFieldMode;
        [FieldOffset(0x0B)] public bool drawLightFieldSamplingPoints;
        [FieldOffset(0x0C)] public bool updateLightFieldEachFrame;
        [FieldOffset(0x0D)] public bool drawLightFieldRegion;
        [FieldOffset(0x10)] public int screenshotLargeScale;
        [FieldOffset(0x14)] public bool drawFxColGeom;
        [FieldOffset(0x15)] public bool drawFxColName;
        [FieldOffset(0x16)] public bool drawLocalLightSphere;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FxCullingSettings
    {
        [FieldOffset(0x00)] public float rangeDefault;
        [FieldOffset(0x04)] public float rangeNear;
        [FieldOffset(0x08)] public float rangeMiddle;
        [FieldOffset(0x0C)] public float rangeFar;
    }

    public enum PeepingPlayerType : sbyte
    {
        TYPE_DEFAULT = 0,
        TYPE_EDGE = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct FxSceneSettings
    {
        [FieldOffset(0x00)] public float skyIntensityScale;
        [FieldOffset(0x04)] public float skyFollowupRatioY;
        [FieldOffset(0x08)] public bool pseudoFogEnable;
        [FieldOffset(0x09)] public bool pseudoFogWithoutFar;
        [FieldOffset(0x0A)] public bool pseudoDof;
        [FieldOffset(0x0B)] public bool deepBlurEnable;
        [FieldOffset(0x0C)] public bool noBlurEnable;
        [FieldOffset(0x10)] public float blurScale;
        [FieldOffset(0x14)] public bool peepingPlayerEnable;
        [FieldOffset(0x18)] public float occCheckedPlayerTime;
        [FieldOffset(0x1C)] public PeepingPlayerType peepingPlayerType;
        [FieldOffset(0x1D)] public bool clearFirstSurface;
        [FieldOffset(0x1E)] public bool useManualZPrepass;
        [FieldOffset(0x1F)] public bool useCaptureFramebufferColor;
        [FieldOffset(0x20)] public bool useCaptureFramebufferDepth;
        [FieldOffset(0x21)] public bool playerDrawOverlay;
    }

    public enum EyeLightMode : sbyte
    {
        LIGHTMODE_DIR = 0,
        LIGHTMODE_POINT = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FxLightSettings
    {
        [FieldOffset(0x00)] public bool globalLightEnable;
        [FieldOffset(0x01)] public bool ambLightEnable;
        [FieldOffset(0x02)] public bool allLocalLightEnable;
        [FieldOffset(0x03)] public bool eyeLightEnable;
        [FieldOffset(0x04)] public EyeLightMode eyeLightMode;
        [FieldOffset(0x10)] public Vector3 eyeLightDiffuse;
        [FieldOffset(0x20)] public Vector3 eyeLightSpecular;
        [FieldOffset(0x30)] public float eyeLightRangeStart;
        [FieldOffset(0x34)] public float eyeLightRangeEnd;
    }

    public enum SaturationScalingType : sbyte
    {
        SATURATION_KEEPING_LUMINANCE = 0,
        SATURATION_KEEPING_BRIGHTNESS = 1,
        SATURATION_NONE = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct FxLightFieldSettings
    {
        [FieldOffset(0x00)] public bool ignoreData;
        [FieldOffset(0x01)] public sbyte defaultUpdateInterval;
        [FieldOffset(0x10)] public Vector3 offsetColorUp;
        [FieldOffset(0x20)] public Vector3 offsetColorDown;
        [FieldOffset(0x30)] public SaturationScalingType saturationScalingType;
        [FieldOffset(0x34)] public float saturationScalingRate;
        [FieldOffset(0x38)] public float luminanceScalingRate;
        [FieldOffset(0x3C)] public bool disableFinalAdjustColor;
        [FieldOffset(0x40)] public float luminanceMin;
        [FieldOffset(0x44)] public float luminanceMax;
        [FieldOffset(0x48)] public float luminanceMidium;
        [FieldOffset(0x4C)] public float intensityThreshold;
        [FieldOffset(0x50)] public float intensityBias;
        [FieldOffset(0x54)] public float defaultInterruption;
        [FieldOffset(0x60)] public Vector3 defaultColorUp;
        [FieldOffset(0x70)] public Vector3 defaultColorDown;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FxLightScatteringSettings
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector3 color;
        [FieldOffset(0x20)] public float depthScale;
        [FieldOffset(0x24)] public float inScatteringScale;
        [FieldOffset(0x28)] public float rayleigh;
        [FieldOffset(0x2C)] public float mie;
        [FieldOffset(0x30)] public float g;
        [FieldOffset(0x34)] public float znear;
        [FieldOffset(0x38)] public float zfar;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct FxHdrSettings
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool adaptationEnable;
        [FieldOffset(0x04)] public float adaptationRatio;
        [FieldOffset(0x08)] public float middleGray;
        [FieldOffset(0x0C)] public float luminanceLow;
        [FieldOffset(0x10)] public float luminanceHigh;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct FxGlareSettings
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float brightPassThreshold;
        [FieldOffset(0x08)] public float brightPassInvScale;
        [FieldOffset(0x0C)] public float persistent;
        [FieldOffset(0x10)] public float bloomScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct FxDofSettings
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool ignoreSky;
        [FieldOffset(0x04)] public float focus;
        [FieldOffset(0x08)] public float znear;
        [FieldOffset(0x0C)] public float zfar;
        [FieldOffset(0x10)] public float focusRange;
    }

    public enum TimeType : sbyte
    {
        TIME_NONE = 0,
        TIME_MORNING = 1,
        TIME_DAY = 2,
        TIME_EVENING = 3,
        TIME_NIGHT = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct FxHourSettings
    {
        [FieldOffset(0x00)] public float middleGray;
        [FieldOffset(0x10)] public Vector3 baseColor;
        [FieldOffset(0x20)] public Vector3 light;
        [FieldOffset(0x30)] public float skyIntensity;
        [FieldOffset(0x40)] public Vector3 sky;
        [FieldOffset(0x50)] public Vector3 ambient;
        [FieldOffset(0x60)] public Vector3 lightScattering;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1E0)]
    public struct FxTimeChangeSettings
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool ignoreSky;
        [FieldOffset(0x02)] public TimeType timeDebugIndex;
        [FieldOffset(0x04)] public float morning;
        [FieldOffset(0x08)] public float day;
        [FieldOffset(0x0C)] public float evening;
        [FieldOffset(0x10)] public float night;
        [FieldOffset(0x20)] public FxHourSettings hourParams__arr0;
        [FieldOffset(0x90)] public FxHourSettings hourParams__arr1;
        [FieldOffset(0x100)] public FxHourSettings hourParams__arr2;
        [FieldOffset(0x170)] public FxHourSettings hourParams__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct FxInShadowShadowScaleSettings
    {
        [FieldOffset(0x00)] public float shadowScaleX;
        [FieldOffset(0x04)] public float shadowScaleY;
        [FieldOffset(0x08)] public float shadowScaleLightFieldY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct FxOnSceneShadowScaleSettings
    {
        [FieldOffset(0x00)] public float shadowScaleZ;
        [FieldOffset(0x04)] public float shadowScaleW;
        [FieldOffset(0x08)] public float shadowScaleLightFieldW;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FxShadowScale
    {
        [FieldOffset(0x00)] public FxInShadowShadowScaleSettings shadowScaleInShadow;
        [FieldOffset(0x0C)] public FxOnSceneShadowScaleSettings shadowScaleOnScene;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct FxGrassSettings
    {
        [FieldOffset(0x00)] public bool grassIsHide;
        [FieldOffset(0x04)] public float grassHeightMin;
        [FieldOffset(0x08)] public float grassHeight;
        [FieldOffset(0x0C)] public float grassWidth;
        [FieldOffset(0x10)] public float grassFar;
        [FieldOffset(0x14)] public float grassFarEnd;
        [FieldOffset(0x18)] public float grassWindAxis;
        [FieldOffset(0x1C)] public float grassWindSpeed;
        [FieldOffset(0x20)] public float grassWindCycle;
        [FieldOffset(0x24)] public float grassWindStrength;
        [FieldOffset(0x28)] public uint grassDupCount;
        [FieldOffset(0x2C)] public float grassDupRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct FxStageDistortion
    {
        [FieldOffset(0x00)] public bool distortionIsUse;
        [FieldOffset(0x04)] public float distortionSpeed;
        [FieldOffset(0x08)] public float distortionPower;
        [FieldOffset(0x0C)] public float distortionDensity;
        [FieldOffset(0x10)] public float distortionDepthDensity;
        [FieldOffset(0x14)] public float distortionPowerBloom;
        [FieldOffset(0x18)] public float distortionPowerDepth;
        [FieldOffset(0x1C)] public float distortionPowerFront;
        [FieldOffset(0x20)] public float distortionDensityFront;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct FxStencilShadow
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector3 shadowColor;
        [FieldOffset(0x20)] public float shadowAlpha;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FxEffectSettings
    {
        [FieldOffset(0x00)] public float lightScale;
        [FieldOffset(0x04)] public float shadowScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FxSceneCasinoLight
    {
        [FieldOffset(0x00)] public bool isUseCasinoLight;
        [FieldOffset(0x10)] public Vector3 casinoLightAABBMin;
        [FieldOffset(0x20)] public Vector3 casinoLightAABBMax;
        [FieldOffset(0x30)] public float casinoLightMoveRatio;
        [FieldOffset(0x34)] public float casinoLightStrengthMax;
        [FieldOffset(0x38)] public float casinoLightRadMin;
        [FieldOffset(0x3C)] public float casinoLightRadMax;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4A0)]
    public struct FxParameter
    {
        [FieldOffset(0x00)] public FxCullingSettings culling;
        [FieldOffset(0x10)] public FxSceneSettings scene;
        [FieldOffset(0x40)] public FxLightSettings light;
        [FieldOffset(0x80)] public FxLightFieldSettings lightField;
        [FieldOffset(0x100)] public FxLightScatteringSettings olsNear;
        [FieldOffset(0x140)] public bool separateOlsLayer;
        [FieldOffset(0x150)] public FxLightScatteringSettings olsFar;
        [FieldOffset(0x190)] public FxHdrSettings hdr;
        [FieldOffset(0x1A4)] public FxGlareSettings glare;
        [FieldOffset(0x1B8)] public FxDofSettings dof;
        [FieldOffset(0x1D0)] public FxTimeChangeSettings timeChange;
        [FieldOffset(0x3B0)] public FxShadowScale shadowScale;
        [FieldOffset(0x3C8)] public FxGrassSettings grassSetting;
        [FieldOffset(0x3F8)] public FxStageDistortion stageDistortion;
        [FieldOffset(0x420)] public FxStencilShadow stencilShadow;
        [FieldOffset(0x450)] public FxEffectSettings effect;
        [FieldOffset(0x460)] public FxSceneCasinoLight casinoLight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x12A0)]
    public struct FxSceneData
    {
        [FieldOffset(0x00)] public FxSceneConfig config;
        [FieldOffset(0x20)] public FxParameter items__arr0;
        [FieldOffset(0x4C0)] public FxParameter items__arr1;
        [FieldOffset(0x960)] public FxParameter items__arr2;
        [FieldOffset(0xE00)] public FxParameter items__arr3;
    }

}