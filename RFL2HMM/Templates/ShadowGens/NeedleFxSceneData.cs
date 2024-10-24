Library "NeedleFxSceneData"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum DOFRenderTargetSize : int
    {
        DOF_RTSIZE_FULL_SCALE = 0,
        DOF_RTSIZE_HALF_SCALE = 1,
        DOF_RTSIZE_QUARTER_SCALE = 2,
        DOF_RTSIZE_COUNT = 3,
        DOF_RTSIZE_INVALID = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct FxRenderTargetSetting
    {
        [FieldOffset(0x00)] public DOFRenderTargetSize dofRenderTargetScale;
        [FieldOffset(0x04)] public int shadowMapWidth;
        [FieldOffset(0x08)] public int shadowMapHeight;
    }

    public enum AntiAliasingType : sbyte
    {
        AATYPE_NONE = 0,
        AATYPE_TAA = 1,
        AATYPE_FXAA = 2,
        AATYPE_SMAA = 3,
        AATYPE_LAST = 4
    }

    public enum UpscaleType : sbyte
    {
        USTYPE_LINEAR = 0,
        USTYPE_FSR_FAST = 1,
        USTYPE_FSR_EASU = 2,
        USTYPE_FSR_RCAS = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FxAntiAliasing
    {
        [FieldOffset(0x00)] public AntiAliasingType aaType;
        [FieldOffset(0x01)] public UpscaleType usType;
        [FieldOffset(0x04)] public float fsrSharpness;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x84)]
    public struct FxLODParameter
    {
        [FieldOffset(0x00)] public bool enableDebugDrawLayerRange;
        [FieldOffset(0x04)] public float layerRange__arr0;
        [FieldOffset(0x08)] public float layerRange__arr1;
        [FieldOffset(0x0C)] public float layerRange__arr2;
        [FieldOffset(0x10)] public float layerRange__arr3;
        [FieldOffset(0x14)] public float layerRange__arr4;
        [FieldOffset(0x18)] public float layerRange__arr5;
        [FieldOffset(0x1C)] public float layerRange__arr6;
        [FieldOffset(0x20)] public float layerRange__arr7;
        [FieldOffset(0x24)] public float layerRange__arr8;
        [FieldOffset(0x28)] public float layerRange__arr9;
        [FieldOffset(0x2C)] public float layerRange__arr10;
        [FieldOffset(0x30)] public float layerRange__arr11;
        [FieldOffset(0x34)] public float layerRange__arr12;
        [FieldOffset(0x38)] public float layerRange__arr13;
        [FieldOffset(0x3C)] public float layerRange__arr14;
        [FieldOffset(0x40)] public float layerRange__arr15;
        [FieldOffset(0x44)] public float layerRange__arr16;
        [FieldOffset(0x48)] public float layerRange__arr17;
        [FieldOffset(0x4C)] public float layerRange__arr18;
        [FieldOffset(0x50)] public float layerRange__arr19;
        [FieldOffset(0x54)] public float layerRange__arr20;
        [FieldOffset(0x58)] public float layerRange__arr21;
        [FieldOffset(0x5C)] public float layerRange__arr22;
        [FieldOffset(0x60)] public float layerRange__arr23;
        [FieldOffset(0x64)] public float layerRange__arr24;
        [FieldOffset(0x68)] public float layerRange__arr25;
        [FieldOffset(0x6C)] public float layerRange__arr26;
        [FieldOffset(0x70)] public float layerRange__arr27;
        [FieldOffset(0x74)] public float layerRange__arr28;
        [FieldOffset(0x78)] public float layerRange__arr29;
        [FieldOffset(0x7C)] public float layerRange__arr30;
        [FieldOffset(0x80)] public float layerRange__arr31;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FxDetailParameter
    {
        [FieldOffset(0x00)] public float detailDistance;
        [FieldOffset(0x04)] public float detailFadeRange;
    }

    public enum Mode : sbyte
    {
        DISABLE = 0,
        ENABLE = 1,
        FIXED_RESOLUTION = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct FxDynamicResolutionParameter
    {
        [FieldOffset(0x00)] public Mode mode;
        [FieldOffset(0x04)] public float fixedResolutionRatio;
        [FieldOffset(0x08)] public float minResolutionRatio;
        [FieldOffset(0x0C)] public float minTargetTimeDifference;
        [FieldOffset(0x10)] public float maxTargetTimeDifference;
        [FieldOffset(0x14)] public float increaseRate;
        [FieldOffset(0x18)] public float decreaseRate;
        [FieldOffset(0x1C)] public float increaseMaxScaleDelta;
        [FieldOffset(0x20)] public float decreaseMaxScaleDelta;
        [FieldOffset(0x24)] public bool debugSineFluctuation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x02)]
    public struct HourMinuteData
    {
        [FieldOffset(0x00)] public byte hour;
        [FieldOffset(0x01)] public byte minute;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct TimeIntervalData
    {
        [FieldOffset(0x00)] public HourMinuteData beginTime;
        [FieldOffset(0x02)] public HourMinuteData endTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct ProgressTimePairData
    {
        [FieldOffset(0)] public TimeIntervalData timeIntervalData;
        [FieldOffset(0x04)] public float hourlyTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x68)]
    public struct StageCommonTimeProgressParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float solarRadiusScale;
        [FieldOffset(0x08)] public float azimuthAngle;
        [FieldOffset(0x0C)] public float latitude;
        [FieldOffset(0x10)] public float longitude;
        [FieldOffset(0x14)] public int month;
        [FieldOffset(0x18)] public int day;
        [FieldOffset(0x1C)] public float time;
        [FieldOffset(0x20)] public float hourlyTime;
        [FieldOffset(0x24)] public ProgressTimePairData overrideSpeeds__arr0;
        [FieldOffset(0x2C)] public ProgressTimePairData overrideSpeeds__arr1;
        [FieldOffset(0x34)] public ProgressTimePairData overrideSpeeds__arr2;
        [FieldOffset(0x3C)] public ProgressTimePairData overrideSpeeds__arr3;
        [FieldOffset(0x44)] public ProgressTimePairData overrideSpeeds__arr4;
        [FieldOffset(0x4C)] public ProgressTimePairData overrideSpeeds__arr5;
        [FieldOffset(0x54)] public ProgressTimePairData overrideSpeeds__arr6;
        [FieldOffset(0x5C)] public ProgressTimePairData overrideSpeeds__arr7;
        [FieldOffset(0x64)] public TimeIntervalData night;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct StageCommonWeatherProgressParameter
    {
        [FieldOffset(0x00)] public bool enable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct FxTerrainParameter
    {
        [FieldOffset(0x00)] public bool enableDrawGrid;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x02)]
    public struct FxModelParameter
    {
        [FieldOffset(0x00)] public bool zprepass;
        [FieldOffset(0x01)] public bool ditherAsBlueNoize;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct StageCommonDecalModelParameter
    {
        [FieldOffset(0x00)] public float cullingRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PerformanceSetting
    {
        [FieldOffset(0x00)] public float smallCullingThreshold;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x13C)]
    public struct NeedleFxSceneConfig
    {
        [FieldOffset(0x00)] public FxRenderTargetSetting rendertarget;
        [FieldOffset(0x0C)] public FxAntiAliasing antialiasing;
        [FieldOffset(0x14)] public FxLODParameter lod;
        [FieldOffset(0x98)] public FxDetailParameter detail;
        [FieldOffset(0xA0)] public FxDynamicResolutionParameter dynamicResolution;
        [FieldOffset(0xC8)] public StageCommonTimeProgressParameter timeProgress;
        [FieldOffset(0x130)] public StageCommonWeatherProgressParameter weatherProgress;
        [FieldOffset(0x131)] public FxTerrainParameter terrain;
        [FieldOffset(0x132)] public FxModelParameter modelParam;
        [FieldOffset(0x134)] public StageCommonDecalModelParameter decalModelParam;
        [FieldOffset(0x138)] public PerformanceSetting performance;
    }

    public enum DebugViewType : sbyte
    {
        DEBUG_VIEW_DEFAULT = 0,
        DEBUG_VIEW_DIR_DIFFUSE = 1,
        DEBUG_VIEW_DIR_SPECULAR = 2,
        DEBUG_VIEW_AMB_DIFFUSE = 3,
        DEBUG_VIEW_AMB_SPECULAR = 4,
        DEBUG_VIEW_ONLY_IBL = 5,
        DEBUG_VIEW_ONLY_IBL_SURF_NORMAL = 6,
        DEBUG_VIEW_SHADOW = 7,
        DEBUG_VIEW_WHITE_ALBEDO = 8,
        DEBUG_VIEW_WHITE_ALBEDO_NO_AO = 9,
        DEBUG_VIEW_USER0 = 10,
        DEBUG_VIEW_USER1 = 11,
        DEBUG_VIEW_USER2 = 12,
        DEBUG_VIEW_USER3 = 13,
        DEBUG_VIEW_ALBEDO = 14,
        DEBUG_VIEW_ALBEDO_CHECK_OUTLIER = 15,
        DEBUG_VIEW_OPACITY = 16,
        DEBUG_VIEW_NORMAL = 17,
        DEBUG_VIEW_ROUGHNESS = 18,
        DEBUG_VIEW_AMBIENT = 19,
        DEBUG_VIEW_CAVITY = 20,
        DEBUG_VIEW_REFLECTANCE = 21,
        DEBUG_VIEW_METALLIC = 22,
        DEBUG_VIEW_LOCAL_LIGHT = 23,
        DEBUG_VIEW_SCATTERING_FEX = 24,
        DEBUG_VIEW_SCATTERING_LIN = 25,
        DEBUG_VIEW_SSAO = 26,
        DEBUG_VIEW_RLR = 27,
        DEBUG_VIEW_IBL_DIFFUSE = 28,
        DEBUG_VIEW_IBL_SPECULAR = 29,
        DEBUG_VIEW_ENV_BRDF = 30,
        DEBUG_VIEW_WORLD_POSITION = 31,
        DEBUG_VIEW_SHADING_MODEL_ID = 32,
        DEBUG_VIEW_IBL_CAPTURE = 33,
        DEBUG_VIEW_IBL_SKY_TERRAIN = 34,
        DEBUG_VIEW_WRITE_DEPTH_TO_ALPHA = 35,
        DEBUG_VIEW_SMOOTHNESS = 36,
        DEBUG_VIEW_OCCLUSION_CAPSULE = 37,
        DEBUG_VIEW_PROBE = 38,
        DEBUG_VIEW_CHARACTER_MASK = 39,
        DEBUG_VIEW_DISTANCE = 40,
        DEBUG_VIEW_SHADING_MODEL = 41,
        DEBUG_VIEW_SHADING_KIND = 42,
        DEBUG_VIEW_AMB_DIFFUSE_LF = 43,
        DEBUG_VIEW_SGGI_ONLY = 44,
        DEBUG_VIEW_COUNT = 45,
        DEBUG_VIEW_INVALID = 45
    }

    public enum Type : sbyte
    {
        NONE = 0,
        SHADOW_LIGHT = 1,
        SHADOW_AND_DISTANT_LIGHT = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct GlobalLightAngleLimit
    {
        [FieldOffset(0x00)] public Type type;
        [FieldOffset(0x04)] public float minLightElevationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct GlobalLightParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public GlobalLightAngleLimit limit;
    }

    public enum LocalLightCullingType : sbyte
    {
        LOCAL_LIGHT_CULLING_TYPE_NONE = 0,
        LOCAL_LIGHT_CULLING_TYPE_CPU_TILE = 1,
        LOCAL_LIGHT_CULLING_TYPE_GPU_TILE = 2,
        LOCAL_LIGHT_CULLING_TYPE_GPU_CLUSTER = 3,
        LOCAL_LIGHT_CULLING_TYPE_COUNT = 4,
        LOCAL_LIGHT_CULLING_TYPE_DEFAULT = 0
    }

    public enum TextureViewType : sbyte
    {
        TEXTURE_VIEW_NONE = 0,
        TEXTURE_VIEW_DEPTH = 1,
        TEXTURE_VIEW_LUMINANCE = 2,
        TEXTURE_VIEW_DOF_BOKEH = 3,
        TEXTURE_VIEW_DOF_BOKEH_NEAR = 4,
        TEXTURE_VIEW_SSAO_SOURCE = 5,
        TEXTURE_VIEW_DOWNSAMPLE = 6,
        TEXTURE_VIEW_COUNT = 7
    }

    public enum AmbientSpecularType : sbyte
    {
        AMBIENT_SPECULAR_NONE = 0,
        AMBIENT_SPECULAR_SG = 1,
        AMBIENT_SPECULAR_IBL = 2,
        AMBIENT_SPECULAR_BLEND = 3
    }

    public enum DebugGITextureDisable : sbyte
    {
        DEBUG_GI_TEX_DISABLE_NONE = 0,
        DEBUG_GI_TEX_DISABLE_SGGI = 1,
        DEBUG_GI_TEX_DISABLE_AO = 2,
        DEBUG_GI_TEX_DISABLE_ALL = 3,
        DEBUG_GI_TEX_SGGI_ONLY = 4,
        DEBUG_GI_TEX_AOGI_ONLY = 5,
        DEBUG_GI_TEX_AOLF_OCCRATE = 6
    }

    public enum ChannelMode : sbyte
    {
        CHANNELMODE_RGB = 0,
        CHANNELMODE_RRR = 1,
        CHANNELMODE_GGG = 2,
        CHANNELMODE_BBB = 3,
        CHANNELMODE_AAA = 4,
        CHANNELMODE_RG = 5,
        CHANNELMODE_BA = 6
    }

    public enum DebugScreenType : sbyte
    {
        DEBUG_SCREEN_GBUFFER0 = 0,
        DEBUG_SCREEN_GBUFFER1 = 1,
        DEBUG_SCREEN_GBUFFER2 = 2,
        DEBUG_SCREEN_GBUFFER3 = 3,
        DEBUG_SCREEN_GBUFFER4 = 4,
        DEBUG_SCREEN_DEPTHBUFFER = 5,
        DEBUG_SCREEN_CSM0 = 6,
        DEBUG_SCREEN_CSM1 = 7,
        DEBUG_SCREEN_CSM2 = 8,
        DEBUG_SCREEN_CSM3 = 9,
        DEBUG_SCREEN_HDR = 10,
        DEBUG_SCREEN_BLOOM = 11,
        DEBUG_SCREEN_RLR = 12,
        DEBUG_SCREEN_GODRAY = 13,
        DEBUG_SCREEN_SSAO = 14,
        DEBUG_SCREEN_CSM_CACHE0 = 15,
        DEBUG_SCREEN_CSM_CACHE1 = 16,
        DEBUG_SCREEN_CSM_CACHE2 = 17,
        DEBUG_SCREEN_CSM_CACHE3 = 18,
        DEBUG_SCREEN_CSM_CACHE4 = 19,
        DEBUG_SCREEN_CSM_CACHE5 = 20,
        DEBUG_SCREEN_CUSTOM0 = 21,
        DEBUG_SCREEN_CUSTOM1 = 22,
        DEBUG_SCREEN_CUSTOM2 = 23,
        DEBUG_SCREEN_CUSTOM3 = 24,
        DEBUG_SCREEN_TYPE_NUM = 25
    }

    public enum ErrorCheckType : sbyte
    {
        ERROR_CHECK_NONE = 0,
        ERROR_CHECK_NAN = 1,
        ERROR_CHECK_ALBEDO = 2,
        ERROR_CHECK_NORMAL = 3
    }

    public enum VisualizeMode : sbyte
    {
        DEFAULT = 0,
        HEATMAP_TYPE0 = 1,
        HEATMAP_TYPE1 = 2,
        HEATMAP_TYPE2 = 3,
        VECTOR2D_TYPE0 = 4,
        VECTOR2D_TYPE1 = 5,
        VECTOR2D_TYPE2 = 6
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct DebugScreenOption
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool fullScreen;
        [FieldOffset(0x02)] public ChannelMode channelMode;
        [FieldOffset(0x04)] public float min;
        [FieldOffset(0x08)] public float max;
        [FieldOffset(0x0C)] public int renderTargetType;
        [FieldOffset(0x10)] public int depthTargetType;
        [FieldOffset(0x14)] public DebugScreenType screenType;
        [FieldOffset(0x15)] public ErrorCheckType errorCheck;
        [FieldOffset(0x16)] public VisualizeMode visualizeMode;
    }

    public enum DebugScreenView : sbyte
    {
        DEBUG_SCREEN_VIEW_DEFAULT = 0,
        DEBUG_SCREEN_VIEW_ALL_ENABLE = 1,
        DEBUG_SCREEN_VIEW_ALL_DISABLE = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct GlobalUserParamOption
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector4 value;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x250)]
    public struct FxRenderOption
    {
        [FieldOffset(0x00)] public DebugViewType debugViewType;
        [FieldOffset(0x01)] public bool clearRenderTarget;
        [FieldOffset(0x04)] public GlobalLightParameter globalLight;
        [FieldOffset(0x10)] public bool enablePointLight;
        [FieldOffset(0x14)] public int maxLocalShadow;
        [FieldOffset(0x18)] public float localShadowIntensity;
        [FieldOffset(0x1C)] public bool enableEffectDeformation;
        [FieldOffset(0x1D)] public bool enablePreMergeIBL;
        [FieldOffset(0x1E)] public LocalLightCullingType localLightCullingType;
        [FieldOffset(0x20)] public float localLightScale;
        [FieldOffset(0x24)] public float shadowIBLAttenuation;
        [FieldOffset(0x28)] public int maxCubeProbe;
        [FieldOffset(0x2C)] public bool debugDrawCubeProbe;
        [FieldOffset(0x2D)] public bool debugEnableDrawLocalLight;
        [FieldOffset(0x2E)] public TextureViewType debugTextureViewType;
        [FieldOffset(0x2F)] public bool debugEnableOutputTextureView;
        [FieldOffset(0x30)] public int debugScreenshotResolutionHeight;
        [FieldOffset(0x34)] public float debugScreenshotDepthNear;
        [FieldOffset(0x38)] public float debugScreenshotDepthFar;
        [FieldOffset(0x3C)] public AmbientSpecularType debugAmbientSpecularType;
        [FieldOffset(0x3D)] public DebugGITextureDisable debagGITextureDisableType;
        [FieldOffset(0x40)] public DebugScreenOption debugScreen__arr0;
        [FieldOffset(0x58)] public DebugScreenOption debugScreen__arr1;
        [FieldOffset(0x70)] public DebugScreenOption debugScreen__arr2;
        [FieldOffset(0x88)] public DebugScreenOption debugScreen__arr3;
        [FieldOffset(0xA0)] public DebugScreenOption debugScreen__arr4;
        [FieldOffset(0xB8)] public DebugScreenOption debugScreen__arr5;
        [FieldOffset(0xD0)] public DebugScreenOption debugScreen__arr6;
        [FieldOffset(0xE8)] public DebugScreenOption debugScreen__arr7;
        [FieldOffset(0x100)] public DebugScreenOption debugScreen__arr8;
        [FieldOffset(0x118)] public DebugScreenOption debugScreen__arr9;
        [FieldOffset(0x130)] public DebugScreenOption debugScreen__arr10;
        [FieldOffset(0x148)] public DebugScreenOption debugScreen__arr11;
        [FieldOffset(0x160)] public DebugScreenOption debugScreen__arr12;
        [FieldOffset(0x178)] public DebugScreenOption debugScreen__arr13;
        [FieldOffset(0x190)] public DebugScreenOption debugScreen__arr14;
        [FieldOffset(0x1A8)] public DebugScreenOption debugScreen__arr15;
        [FieldOffset(0x1C0)] public DebugScreenView debugScreenView;
        [FieldOffset(0x1C1)] public bool enableMSAA;
        [FieldOffset(0x1C2)] public bool debugEnableDrawFrustumCullFrustum;
        [FieldOffset(0x1C3)] public bool debugEnableFixFrustumCullFrustum;
        [FieldOffset(0x1C4)] public int debugDrawFrustumCullGroupSettingIndex;
        [FieldOffset(0x1C8)] public bool debugEnableOcclusionCullingView;
        [FieldOffset(0x1CC)] public int debugOccluderVertThreshold;
        [FieldOffset(0x1D0)] public GlobalUserParamOption globalUserParam__arr0;
        [FieldOffset(0x1F0)] public GlobalUserParamOption globalUserParam__arr1;
        [FieldOffset(0x210)] public GlobalUserParamOption globalUserParam__arr2;
        [FieldOffset(0x230)] public GlobalUserParamOption globalUserParam__arr3;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FxSGGIParameter
    {
        [FieldOffset(0x00)] public float sgStartSmoothness;
        [FieldOffset(0x04)] public float sgEndSmoothness;
        [FieldOffset(0x08)] public float doStartSmoothness;
        [FieldOffset(0x0C)] public float doEndSmoothness;
        [FieldOffset(0x10)] public float doOffset;
        [FieldOffset(0x14)] public float aoOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct FxRLRParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool traceSky;
        [FieldOffset(0x02)] public bool useTrans;
        [FieldOffset(0x03)] public bool usePenet;
        [FieldOffset(0x04)] public bool useQuat;
        [FieldOffset(0x05)] public bool useNormal;
        [FieldOffset(0x08)] public float rayMarchingCount;
        [FieldOffset(0x0C)] public float planeNormalDist;
        [FieldOffset(0x10)] public float traceThreshold;
        [FieldOffset(0x14)] public float resolveReproj;
        [FieldOffset(0x18)] public float overrideRatio;
        [FieldOffset(0x1C)] public float maxRoughness;
        [FieldOffset(0x20)] public float roughnessLevel;
        [FieldOffset(0x24)] public float uvOffsetScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FxSSGIDebugParameter
    {
        [FieldOffset(0x00)] public bool useDenoise;
        [FieldOffset(0x04)] public float rayLength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct FxSSGIParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float intensity;
        [FieldOffset(0x08)] public bool useAlbedo;
        [FieldOffset(0x09)] public bool useParameter;
        [FieldOffset(0x0C)] public FxSSGIDebugParameter debugParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct FxPlanarReflectionParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector4 plane;
        [FieldOffset(0x20)] public uint width;
        [FieldOffset(0x24)] public uint height;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FxBloomParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool fast;
        [FieldOffset(0x04)] public float bloomScale;
        [FieldOffset(0x08)] public float sampleRadiusScale;
        [FieldOffset(0x0C)] public int blurQuality;
    }

    public enum Exposure : sbyte
    {
        EXPOSURE_MANUAL = 0,
        EXPOSURE_AUTO = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct FxManualExposureParameter
    {
        [FieldOffset(0x00)] public float exposureValue;
    }

    public enum LUMINANCE_RANGE : sbyte
    {
        LUMINANCE_RANGE_CLAMP = 0,
        LUMINANCE_RANGE_CUTOFF = 1,
        LUMINANCE_RANGE_CUTOFF_PCT_RATE = 2,
        LUMINANCE_RANGE_CUTOFF_PCT_AREA = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct FxAutoExposureParameter
    {
        [FieldOffset(0x00)] public float middleGray;
        [FieldOffset(0x04)] public float lumMax;
        [FieldOffset(0x08)] public float lumMin;
        [FieldOffset(0x0C)] public float cutMax;
        [FieldOffset(0x10)] public float cutMin;
        [FieldOffset(0x14)] public float pctMax;
        [FieldOffset(0x18)] public float pctMin;
        [FieldOffset(0x1C)] public float adaptedRatio;
        [FieldOffset(0x20)] public LUMINANCE_RANGE luminanceRangeType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct FxCameraControlParameter
    {
        [FieldOffset(0x00)] public Exposure exposureType;
        [FieldOffset(0x04)] public FxManualExposureParameter manualExposure;
        [FieldOffset(0x08)] public FxAutoExposureParameter autoExposure;
    }

    public enum Tonemap : sbyte
    {
        TONEMAP_DISNEY = 0,
        TONEMAP_FILMIC = 1,
        TONEMAP_ACES = 2,
        TONEMAP_GT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct FxToneMapParameterFilmic
    {
        [FieldOffset(0x00)] public float whitePoint;
        [FieldOffset(0x04)] public float toeStrength;
        [FieldOffset(0x08)] public float linearAngle;
        [FieldOffset(0x0C)] public float linearStrength;
        [FieldOffset(0x10)] public float shoulderStrength;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct FxToneMapParameterGT
    {
        [FieldOffset(0x00)] public float maxDisplayBrightness;
        [FieldOffset(0x04)] public float contrast;
        [FieldOffset(0x08)] public float linearSectionStart;
        [FieldOffset(0x0C)] public float linearSectionLength;
        [FieldOffset(0x10)] public float black;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct FxToneMapParameter
    {
        [FieldOffset(0x00)] public Tonemap tonemapType;
        [FieldOffset(0x04)] public FxToneMapParameterFilmic tonemapParamFilmic;
        [FieldOffset(0x18)] public FxToneMapParameterGT tonemapParamGT;
        [FieldOffset(0x2C)] public bool updateLuminance;
    }

    public enum LutIndex : int
    {
        LUT_INDEX_DEFAULT = 0,
        LUT_INDEX_WB = 1,
        LUT_INDEX_USER_0 = 2,
        LUT_INDEX_USER_1 = 3,
        LUT_INDEX_USER_2 = 4,
        LUT_INDEX_USER_3 = 5,
        LUT_INDEX_USER_4 = 6,
        LUT_INDEX_USER_5 = 7,
        LUT_INDEX_COUNT = 8
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x4C)]
    public struct FxColorContrastParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float contrast;
        [FieldOffset(0x08)] public float dynamicRange;
        [FieldOffset(0x0C)] public float crushShadows;
        [FieldOffset(0x10)] public float crushHilights;
        [FieldOffset(0x14)] public bool useLut;
        [FieldOffset(0x18)] public LutIndex lutIndex0;
        [FieldOffset(0x1C)] public LutIndex lutIndex1;
        [FieldOffset(0x20)] public float blendRatio;
        [FieldOffset(0x24)] public float lutRatio;
        [FieldOffset(0x28)] public bool useHlsCorrection;
        [FieldOffset(0x2C)] public float hlsHueOffset;
        [FieldOffset(0x30)] public float hlsLightnessOffset;
        [FieldOffset(0x34)] public float hlsSaturationOffset;
        [FieldOffset(0x38)] public int hlsColorOffset__arr0;
        [FieldOffset(0x3C)] public int hlsColorOffset__arr1;
        [FieldOffset(0x40)] public int hlsColorOffset__arr2;
        [FieldOffset(0x44)] public float hlsColorizeRate;
        [FieldOffset(0x48)] public float hlsColorizeHue;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct FxLightScatteringParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector3 color;
        [FieldOffset(0x20)] public float inScatteringScale;
        [FieldOffset(0x30)] public Vector3 betaRayleigh;
        [FieldOffset(0x40)] public float betaMie;
        [FieldOffset(0x44)] public float g;
        [FieldOffset(0x48)] public float znear;
        [FieldOffset(0x4C)] public float zfar;
        [FieldOffset(0x50)] public float depthScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FxDistanceFogParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float nearDist;
        [FieldOffset(0x08)] public float farDist;
        [FieldOffset(0x0C)] public float influence;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FxHeightFogParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float minHeight;
        [FieldOffset(0x08)] public float maxHeight;
        [FieldOffset(0x0C)] public float nearDist;
        [FieldOffset(0x10)] public float farDist;
        [FieldOffset(0x14)] public float influence;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct FxFogParameter
    {
        [FieldOffset(0x00)] public Vector3 color;
        [FieldOffset(0x10)] public float intensity;
        [FieldOffset(0x14)] public float skyBlend;
        [FieldOffset(0x18)] public float skyMips;
        [FieldOffset(0x1C)] public FxDistanceFogParameter distanceFogParam;
        [FieldOffset(0x2C)] public FxHeightFogParameter heightFogParam;
    }

    public enum Quality : sbyte
    {
        LOW = 0,
        MIDDLE = 1,
        HIGH = 2,
        HIGHEST = 3
    }

    public enum FxDOFParameter_Mode : sbyte
    {
        DISTANCE = 0,
        LENS = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct FxDOFParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public Quality quality;
        [FieldOffset(0x02)] public bool useFocusLookAt;
        [FieldOffset(0x03)] public FxDOFParameter_Mode lensMode;
        [FieldOffset(0x04)] public float foregroundBokehMaxDepth;
        [FieldOffset(0x08)] public float foregroundBokehStartDepth;
        [FieldOffset(0x0C)] public float backgroundBokehStartDepth;
        [FieldOffset(0x10)] public float backgroundBokehMaxDepth;
        [FieldOffset(0x14)] public float focalLengthInMilliMeters;
        [FieldOffset(0x18)] public float fnumber;
        [FieldOffset(0x1C)] public float fixedFovy;
        [FieldOffset(0x20)] public float focusLength;
        [FieldOffset(0x24)] public float forceFocusRange;
        [FieldOffset(0x28)] public float cocMaxRadius;
        [FieldOffset(0x2C)] public float foregroundBokehScale;
        [FieldOffset(0x30)] public float backgroundBokehScale;
        [FieldOffset(0x34)] public float bladeCount;
        [FieldOffset(0x38)] public float bladeCurvature;
        [FieldOffset(0x3C)] public float bladeRotation;
        [FieldOffset(0x40)] public bool drawFocalPlane;
        [FieldOffset(0x41)] public bool enableCircleDOF;
        [FieldOffset(0x44)] public float bokehRadiusScale;
        [FieldOffset(0x48)] public int bokehSampleCount;
        [FieldOffset(0x4C)] public float skyFocusDistance;
        [FieldOffset(0x50)] public float bokehBias;
        [FieldOffset(0x54)] public bool enableSWA;
        [FieldOffset(0x58)] public float swaFocus;
        [FieldOffset(0x5C)] public float swaFocusRange;
        [FieldOffset(0x60)] public float swaNear;
        [FieldOffset(0x64)] public float swaFar;
        [FieldOffset(0x68)] public bool enableEnhancedForeBokeh;
        [FieldOffset(0x6C)] public float foreBokehMaxLuminance;
    }

    public enum ShadowRenderingType : sbyte
    {
        SHADOW_RENDERING_TYPE_SHADOW_MAP = 0,
        SHADOW_RENDERING_TYPE_PLANAR_PROJECTION = 1,
        SHADOW_RENDERING_TYPE_PLANAR_PROJECTION_SHADOW_MAP = 2,
        SHADOW_RENDERING_TYPE_MULTI_SHADOW_MAP = 3,
        SHADOW_RENDERING_TYPE_COUNT = 4
    }

    public enum ShadowFilter : sbyte
    {
        SHADOW_FILTER_POINT = 0,
        SHADOW_FILTER_PCF = 1,
        SHADOW_FILTER_PCSS = 2,
        SHADOW_FILTER_ESM = 3,
        SHADOW_FILTER_MSM = 4,
        SHADOW_FILTER_VSM_POINT = 5,
        SHADOW_FILTER_VSM_LINEAR = 6,
        SHADOW_FILTER_VSM_ANISO_2 = 7,
        SHADOW_FILTER_VSM_ANISO_4 = 8,
        SHADOW_FILTER_VSM_ANISO_8 = 9,
        SHADOW_FILTER_VSM_ANISO_16 = 10,
        SHADOW_FILTER_COUNT = 11,
        SHADOW_FILTER_VSM_FIRST = 5,
        SHADOW_FILTER_VSM_LAST = 10
    }

    public enum ShadowRangeType : sbyte
    {
        SHADOW_RANGE_TYPE_CAMERA_LOOKAT = 0,
        SHADOW_RANGE_TYPE_POSITION_MANUAL = 1,
        SHADOW_RANGE_TYPE_FULL_MANUAL = 2,
        SHADOW_RANGE_TYPE_COUNT = 3,
        SHADOW_RANGE_TYPE_DEFAULT = 0
    }

    public enum FitProjection : sbyte
    {
        FIT_PROJECTION_TO_CASCADES = 0,
        FIT_PROJECTION_TO_SCENE = 1,
        FIT_PROJECTION_TO_ROTATE_CASCADES = 2
    }

    public enum FitNearFar : sbyte
    {
        FIT_NEARFAR_ZERO_ONE = 0,
        FIT_NEARFAR_AABB = 1,
        FIT_NEARFAR_SCENE_AABB = 2
    }

    public enum PartitionType : sbyte
    {
        PARTITION_PSSM = 0,
        PARTITION_MANUAL = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x150)]
    public struct FxShadowMapParameter
    {
        [FieldOffset(0x00)] public ShadowRenderingType renderingType;
        [FieldOffset(0x01)] public bool enable;
        [FieldOffset(0x02)] public ShadowFilter shadowFilter;
        [FieldOffset(0x03)] public ShadowRangeType shadowRangeType;
        [FieldOffset(0x04)] public FitProjection fitProjection;
        [FieldOffset(0x05)] public FitNearFar fitNearFar;
        [FieldOffset(0x06)] public PartitionType partitionType;
        [FieldOffset(0x08)] public float sceneRange;
        [FieldOffset(0x0C)] public float sceneCenter__arr0;
        [FieldOffset(0x10)] public float sceneCenter__arr1;
        [FieldOffset(0x14)] public float sceneCenter__arr2;
        [FieldOffset(0x18)] public float manualLightPos__arr0;
        [FieldOffset(0x1C)] public float manualLightPos__arr1;
        [FieldOffset(0x20)] public float manualLightPos__arr2;
        [FieldOffset(0x24)] public float pssmLambda;
        [FieldOffset(0x28)] public float cascadeOffset;
        [FieldOffset(0x2C)] public int cascadeLevel;
        [FieldOffset(0x30)] public float cascadeSplits__arr0;
        [FieldOffset(0x34)] public float cascadeSplits__arr1;
        [FieldOffset(0x38)] public float cascadeSplits__arr2;
        [FieldOffset(0x3C)] public float cascadeSplits__arr3;
        [FieldOffset(0x40)] public float cascadeBias__arr0;
        [FieldOffset(0x44)] public float cascadeBias__arr1;
        [FieldOffset(0x48)] public float cascadeBias__arr2;
        [FieldOffset(0x4C)] public float cascadeBias__arr3;
        [FieldOffset(0x50)] public float bias;
        [FieldOffset(0x54)] public float offset;
        [FieldOffset(0x58)] public float normalBias;
        [FieldOffset(0x5C)] public int blurQuality;
        [FieldOffset(0x60)] public int blurSize;
        [FieldOffset(0x64)] public float fadeoutDistance;
        [FieldOffset(0x68)] public float cascadeTransitionfadeDistance;
        [FieldOffset(0x6C)] public bool enableCSMCache;
        [FieldOffset(0x70)] public float csmCacheMaxHeight;
        [FieldOffset(0x74)] public float csmCacheMinHeight;
        [FieldOffset(0x78)] public int csmCacheMaxRenderPass;
        [FieldOffset(0x7C)] public float csmCacheFixedFovy;
        [FieldOffset(0x80)] public float csmCacheLightDirectionThreshold;
        [FieldOffset(0x84)] public bool csmCacheParallaxCorrectionEnabled;
        [FieldOffset(0x88)] public float csmCacheParallaxCorrectionHorizontalBias;
        [FieldOffset(0x8C)] public float csmCacheParallaxCorrectionVerticalBias;
        [FieldOffset(0x90)] public int csmCacheFramesToRender__arr0;
        [FieldOffset(0x94)] public int csmCacheFramesToRender__arr1;
        [FieldOffset(0x98)] public int csmCacheFramesToRender__arr2;
        [FieldOffset(0x9C)] public float csmCacheFadeLightElevationAngle;
        [FieldOffset(0xA0)] public float csmCacheMinLightElevationAngle;
        [FieldOffset(0xB0)] public Matrix4x4 shadowCameraViewMatrix;
        [FieldOffset(0xF0)] public Matrix4x4 shadowCameraProjectionMatrix;
        [FieldOffset(0x130)] public float shadowCameraNearDepth;
        [FieldOffset(0x134)] public float shadowCameraFarDepth;
        [FieldOffset(0x138)] public float shadowCameraLookAtDepth;
        [FieldOffset(0x13C)] public bool enableBackFaceShadow;
        [FieldOffset(0x13D)] public bool enableShadowCamera;
        [FieldOffset(0x13E)] public bool enableDrawSceneAABB;
        [FieldOffset(0x13F)] public bool enableDrawShadowFrustum;
        [FieldOffset(0x140)] public bool enableDrawCascade;
        [FieldOffset(0x141)] public bool enableDrawCameraFrustum;
        [FieldOffset(0x142)] public bool enableDrawCSMCache;
        [FieldOffset(0x143)] public bool enableClearOnCSMCacheIsInvalidated;
        [FieldOffset(0x144)] public bool enablePauseCamera;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct FxShadowHeightMapParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float bias;
        [FieldOffset(0x08)] public float distanceFalloff;
        [FieldOffset(0x0C)] public float heightFalloffMinHeight;
        [FieldOffset(0x10)] public float heightFalloffDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct FxVolumetricShadowParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool isForceUseShadowmap;
        [FieldOffset(0x02)] public bool isUseCloudShadow;
        [FieldOffset(0x03)] public bool isUseHeightmapShadow;
    }

    public enum SSAOType : sbyte
    {
        SSAO = 0,
        HBAO = 1,
        HBAO_SSS = 2,
        SSS = 3,
        TYPE_COUNT = 4
    }

    public enum RenderTargetSize : sbyte
    {
        RTSIZE_SAME_AS_FRAMEBUFFER = 0,
        RTSIZE_ONE_SECOND = 1,
        RTSIZE_ONE_FORTH = 2,
        RTSIZE_COUNT = 3
    }

    public enum BLURType : sbyte
    {
        None = 1,
        Gauss2x2 = 2,
        Gauss3x3 = 3,
        Gauss4x4 = 4,
        Gauss5x5 = 5,
        Gauss6x6 = 6,
        Gauss7x7 = 7,
        Gauss8x8 = 8,
        Gauss9x9 = 9,
        Bilateral = 10,
        NoisySample = 11,
        BLUR_COUNT = 12
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct FxSSAO_Parameter
    {
        [FieldOffset(0x00)] public float intensity;
        [FieldOffset(0x04)] public float radius;
        [FieldOffset(0x08)] public float fadeoutDistance;
        [FieldOffset(0x0C)] public float fadeoutRadius;
        [FieldOffset(0x10)] public float power;
        [FieldOffset(0x14)] public float bias;
        [FieldOffset(0x18)] public float occlusionDistance;
        [FieldOffset(0x1C)] public float directLightingInfluence;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct FxHBAO_Parameter
    {
        [FieldOffset(0x00)] public float hbaoPower;
        [FieldOffset(0x04)] public float hbaoBias;
        [FieldOffset(0x08)] public float hbaoRadius;
        [FieldOffset(0x0C)] public float hbaoFalloff;
        [FieldOffset(0x10)] public float hbaoSteps;
        [FieldOffset(0x14)] public float hbaoGitter;
        [FieldOffset(0x18)] public sbyte hbaoRaycount;
        [FieldOffset(0x19)] public bool hbaoGiMaskEnable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2C)]
    public struct FxSSS_Parameter
    {
        [FieldOffset(0x00)] public float sssRayLength;
        [FieldOffset(0x04)] public sbyte sssRaycount;
        [FieldOffset(0x08)] public float sssBias;
        [FieldOffset(0x0C)] public float sssIntensity;
        [FieldOffset(0x10)] public float sssDepthMin;
        [FieldOffset(0x14)] public float sssDepthMax;
        [FieldOffset(0x18)] public float sssLightDistance;
        [FieldOffset(0x1C)] public float sssThickness;
        [FieldOffset(0x20)] public bool sssGiMaskEnable;
        [FieldOffset(0x24)] public float sssLimit;
        [FieldOffset(0x28)] public bool sssDitherEnable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct FxSSAOParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public SSAOType postType;
        [FieldOffset(0x02)] public RenderTargetSize renderTargetSize;
        [FieldOffset(0x03)] public BLURType blurStep;
        [FieldOffset(0x04)] public float bilateralThreshold;
        [FieldOffset(0x08)] public FxSSAO_Parameter ssaoParam;
        [FieldOffset(0x28)] public FxHBAO_Parameter hbaoParam;
        [FieldOffset(0x44)] public FxSSS_Parameter sssParam;
    }

    public enum DebugDrawType : sbyte
    {
        DEBUG_DRAW_NONE = 0,
        DEBUG_DRAW_ONLY_ENABLED = 1,
        DEBUG_DRAW_ALL = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FxLightFieldMergeParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float blendRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FxSHLightFieldParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public DebugDrawType debugDrawType;
        [FieldOffset(0x02)] public bool showSkyVisibility;
        [FieldOffset(0x04)] public float debugProbeSize;
        [FieldOffset(0x10)] public Vector3 multiplyColorUp;
        [FieldOffset(0x20)] public Vector3 multiplyColorDown;
        [FieldOffset(0x30)] public float normalBias;
        [FieldOffset(0x34)] public FxLightFieldMergeParameter lfMerge;
    }

    public enum BlurType : sbyte
    {
        BLURTYPE_PREV_SURFACE = 0,
        BLURTYPE_RADIAL = 1,
        BLURTYPE_CAMERA = 2,
        BLURTYPE_COUNT = 3
    }

    public enum FocusType : sbyte
    {
        FOCUSTYPE_CENTER = 0,
        FOCUSTYPE_LOOKAT = 1,
        FOCUSTYPE_USER_SETTING = 2,
        FOCUSTYPE_COUNT = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct FxScreenBlurParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public BlurType blurType;
        [FieldOffset(0x04)] public float blurPower;
        [FieldOffset(0x08)] public FocusType focusType;
        [FieldOffset(0x10)] public Vector3 focusPosition;
        [FieldOffset(0x20)] public float focusRange;
        [FieldOffset(0x24)] public float alphaSlope;
        [FieldOffset(0x28)] public int sampleNum;
        [FieldOffset(0x2C)] public bool singleDirectionOpt;
    }

    public struct Color8
    {
        public byte A;
        public byte R;
        public byte G;
        public byte B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct FxOcclusionCapsuleParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool enableOcclusion;
        [FieldOffset(0x04)] public Color8 occlusionColor;
        [FieldOffset(0x08)] public float occlusionPower;
        [FieldOffset(0x0C)] public bool enableSpecularOcclusion;
        [FieldOffset(0x10)] public float specularOcclusionAlpha;
        [FieldOffset(0x14)] public float specularOcclusionPower;
        [FieldOffset(0x18)] public float specularOcclusionConeAngle;
        [FieldOffset(0x1C)] public bool enableShadow;
        [FieldOffset(0x20)] public Color8 shadowColor;
        [FieldOffset(0x24)] public float shadowPower;
        [FieldOffset(0x28)] public float shadowConeAngle;
        [FieldOffset(0x2C)] public float cullingDistance;
        [FieldOffset(0x30)] public bool enableManualLight;
        [FieldOffset(0x34)] public int manualLightCount;
        [FieldOffset(0x40)] public Vector3 manualLightPos__arr0;
        [FieldOffset(0x50)] public Vector3 manualLightPos__arr1;
        [FieldOffset(0x60)] public Vector3 manualLightPos__arr2;
        [FieldOffset(0x70)] public Vector3 manualLightPos__arr3;
        [FieldOffset(0x80)] public bool debugDraw;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct FxEffectParameter
    {
        [FieldOffset(0x00)] public float lightFieldColorCoefficient;
        [FieldOffset(0x04)] public float invTonemapCoefficient;
        [FieldOffset(0x10)] public Vector3 shadowColor;
        [FieldOffset(0x20)] public Vector3 directionalLightOverwrite;
        [FieldOffset(0x30)] public float directionalLightIntensityOverwrite;
        [FieldOffset(0x34)] public bool overwriteDirectionalLight;
        [FieldOffset(0x38)] public float localLightIntensityScale;
        [FieldOffset(0x3C)] public float lodDistances__arr0;
        [FieldOffset(0x40)] public float lodDistances__arr1;
        [FieldOffset(0x44)] public float lodDistances__arr2;
        [FieldOffset(0x48)] public float lodDistances__arr3;
        [FieldOffset(0x4C)] public float lodDistances__arr4;
        [FieldOffset(0x50)] public float lodDistances__arr5;
        [FieldOffset(0x54)] public float lodDistances__arr6;
        [FieldOffset(0x58)] public float lodDistances__arr7;
        [FieldOffset(0x5C)] public bool enableVisualizeOverdraw;
        [FieldOffset(0x5D)] public bool renderWireframe;
        [FieldOffset(0x5E)] public bool upsampleBilateral;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FxScreenSpaceGodrayParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float rayMarchingCount;
        [FieldOffset(0x08)] public float density;
        [FieldOffset(0x0C)] public float decay;
        [FieldOffset(0x10)] public float threshold;
        [FieldOffset(0x14)] public float lumMax;
        [FieldOffset(0x18)] public float intensity;
        [FieldOffset(0x1C)] public bool enableDither;
        [FieldOffset(0x20)] public Vector3 lightPos;
        [FieldOffset(0x30)] public Vector3 lightDir;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FxGodrayVolumeTexture
    {
        [FieldOffset(0x00)] public bool enableVolumeTexture;
        [FieldOffset(0x04)] public float uvScale;
        [FieldOffset(0x08)] public float timeScale;
        [FieldOffset(0x0C)] public float animationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xF0)]
    public struct FxGodrayParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool isUseShadowmap;
        [FieldOffset(0x02)] public bool isVariableStep;
        [FieldOffset(0x10)] public Matrix4x4 shadow;
        [FieldOffset(0x50)] public Matrix4x4 box;
        [FieldOffset(0x90)] public Vector3 color;
        [FieldOffset(0xA0)] public float density;
        [FieldOffset(0xA4)] public float anisotropy;
        [FieldOffset(0xA8)] public float range;
        [FieldOffset(0xAC)] public float rayMarchingCount;
        [FieldOffset(0xB0)] public float rayMarchingStep;
        [FieldOffset(0xB4)] public float shadowEdge;
        [FieldOffset(0xB8)] public bool isScanFromBack;
        [FieldOffset(0xBC)] public int boxCount;
        [FieldOffset(0xC0)] public bool isNewMode;
        [FieldOffset(0xC4)] public FxGodrayVolumeTexture volumeTexture;
        [FieldOffset(0xD4)] public float transparency;
        [FieldOffset(0xD8)] public bool enable3d;
        [FieldOffset(0xDC)] public float reProject3d;
        [FieldOffset(0xE0)] public float logNear3d;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct FxHeatHazeParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float speed;
        [FieldOffset(0x08)] public float scale;
        [FieldOffset(0x0C)] public float cycle;
        [FieldOffset(0x10)] public float nearDepth;
        [FieldOffset(0x14)] public float farDepth;
        [FieldOffset(0x18)] public float maxHeight;
        [FieldOffset(0x1C)] public float parallaxCorrectFactor;
    }

    public enum IBLType : sbyte
    {
        DefaultIBL = 0,
        CreateFromSkyCube = 1,
        IBLType_None = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct FxStaticSkyDomeParameter
    {
        [FieldOffset(0x00)] public bool showSkyCube;
        [FieldOffset(0x01)] public IBLType iblType;
        [FieldOffset(0x04)] public float flatteningY;
        [FieldOffset(0x08)] public float flatteningXZ;
    }

    public enum SunPosType : sbyte
    {
        SUN_POS_TYPE_NONE = 0,
        SUN_POS_TYPE_ANGLE = 1,
        SUN_POS_TYPE_EARTH = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FxSunPosAngle
    {
        [FieldOffset(0x00)] public float azimuthAngle;
        [FieldOffset(0x04)] public float elevationAngle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct FxSunPosEarth
    {
        [FieldOffset(0x00)] public float azimuthAngle;
        [FieldOffset(0x04)] public float latitude;
        [FieldOffset(0x08)] public float longitude;
        [FieldOffset(0x0C)] public int month;
        [FieldOffset(0x10)] public int day;
        [FieldOffset(0x14)] public float time;
        [FieldOffset(0x18)] public bool enableAnimation;
        [FieldOffset(0x1C)] public float animationSpeed;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct FxSun
    {
        [FieldOffset(0x00)] public float solarRadiusScale;
        [FieldOffset(0x04)] public SunPosType sunPosType;
        [FieldOffset(0x08)] public FxSunPosAngle posTypeAngle;
        [FieldOffset(0x10)] public FxSunPosEarth posTypeEarth;
    }

    public enum MoonPosType : sbyte
    {
        MOON_POS_TYPE_NONE = 0,
        MOON_POS_TYPE_INV_SUN = 1,
        MOON_POS_TYPE_EARTH = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct FxMoon
    {
        [FieldOffset(0x00)] public MoonPosType moonPosType;
    }

    public enum SkyModel : sbyte
    {
        BRUNETON = 0,
        SEBASTIEN = 1
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FxSkyCommon
    {
        [FieldOffset(0x00)] public SkyModel skyModel;
        [FieldOffset(0x04)] public float illuminanceScale;
        [FieldOffset(0x08)] public bool enableScattering;
        [FieldOffset(0x0C)] public float scatteringRatio;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FxBrunetonSkyNight
    {
        [FieldOffset(0x00)] public float lunarIntensityInSky;
        [FieldOffset(0x04)] public float starIntensityInSky;
        [FieldOffset(0x08)] public float lunarIntensityInCloud;
        [FieldOffset(0x0C)] public float lunarIntensity;
        [FieldOffset(0x10)] public float skyIntensity;
        [FieldOffset(0x14)] public Color8 lunarLightColor;
        [FieldOffset(0x20)] public Vector4 lunarLightColorOffset;
        [FieldOffset(0x30)] public float lunarLightPower;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct FxBrunetonSky
    {
        [FieldOffset(0x00)] public float illuminanceScale;
        [FieldOffset(0x04)] public Color8 rayleighColor;
        [FieldOffset(0x08)] public Color8 lightColorScale;
        [FieldOffset(0x0C)] public float miePhaseFunctionG;
        [FieldOffset(0x10)] public Color8 mieScatteringColor;
        [FieldOffset(0x14)] public float mieScatteringScale;
        [FieldOffset(0x18)] public Color8 mieAbsorptionColor;
        [FieldOffset(0x1C)] public float mieAbsorptionScale;
        [FieldOffset(0x20)] public Color8 rayleighScatteringColor;
        [FieldOffset(0x24)] public float rayleighScatteringScale;
        [FieldOffset(0x28)] public Color8 groundAlbedo;
        [FieldOffset(0x2C)] public Color8 groundIrradianceScale;
        [FieldOffset(0x30)] public Color8 cubemapColorScale;
        [FieldOffset(0x34)] public float cubemapColorAngleRatio;
        [FieldOffset(0x38)] public bool enableScattering;
        [FieldOffset(0x3C)] public float scatteringRatio;
        [FieldOffset(0x40)] public FxBrunetonSkyNight night;
        [FieldOffset(0x80)] public bool enableLimitY;
        [FieldOffset(0x84)] public float debugSkyCubeIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct FxSebastienSky
    {
        [FieldOffset(0x00)] public float miePhaseFunctionG;
        [FieldOffset(0x04)] public Color8 mieScatteringColor;
        [FieldOffset(0x10)] public Vector4 mieScatteringColorOffset;
        [FieldOffset(0x20)] public float mieScatteringScale;
        [FieldOffset(0x24)] public Color8 mieAbsorptionColor;
        [FieldOffset(0x30)] public Vector4 mieAbsorptionColorOffset;
        [FieldOffset(0x40)] public float mieAbsorptionScale;
        [FieldOffset(0x44)] public Color8 rayleighScatteringColor;
        [FieldOffset(0x50)] public Vector4 rayleighScatteringColorOffset;
        [FieldOffset(0x60)] public float rayleighScatteringScale;
        [FieldOffset(0x64)] public Color8 groundAlbedo;
        [FieldOffset(0x70)] public Vector4 groundAlbedoOffset;
        [FieldOffset(0x80)] public bool enableGround;
        [FieldOffset(0x84)] public int numScatteringOrder;
        [FieldOffset(0x88)] public bool enableScattering;
        [FieldOffset(0x89)] public bool enableLimitY;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FxCloudProcedural
    {
        [FieldOffset(0x00)] public Vector3 uvScale;
        [FieldOffset(0x10)] public Vector3 colorGamma;
        [FieldOffset(0x20)] public Vector3 colorScale;
        [FieldOffset(0x30)] public Vector3 colorOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct FxCloudBlendParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float probability;
        [FieldOffset(0x08)] public float cloudiness;
        [FieldOffset(0x10)] public FxCloudProcedural proceduralCloud;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x100)]
    public struct FxCloudParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool enableAnimation;
        [FieldOffset(0x04)] public float animationFrame;
        [FieldOffset(0x08)] public float animationSpeed;
        [FieldOffset(0x0C)] public float animationAngle;
        [FieldOffset(0x10)] public float animationSpeedCirrus;
        [FieldOffset(0x14)] public float animationAngleCirrus;
        [FieldOffset(0x18)] public float skyHorizonOffset;
        [FieldOffset(0x1C)] public float cloudStartHeight;
        [FieldOffset(0x20)] public float cloudCoverageSpeed;
        [FieldOffset(0x24)] public float cloudTypeSpeed;
        [FieldOffset(0x28)] public float cloudWetnessSpeed;
        [FieldOffset(0x2C)] public float miePhaseFunctionG;
        [FieldOffset(0x30)] public float silverIntensity;
        [FieldOffset(0x34)] public float silverSpread;
        [FieldOffset(0x38)] public float scale;
        [FieldOffset(0x3C)] public float density;
        [FieldOffset(0x40)] public float densityThreshold;
        [FieldOffset(0x44)] public Color8 cloudsExtinctionColor1;
        [FieldOffset(0x50)] public Vector4 cloudsExtinctionColor1Offset;
        [FieldOffset(0x60)] public Color8 cloudsExtinctionColor2;
        [FieldOffset(0x70)] public Vector4 cloudsExtinctionColor2Offset;
        [FieldOffset(0x80)] public Color8 cloudsExtinctionColor3;
        [FieldOffset(0x90)] public Vector4 cloudsExtinctionColor3Offset;
        [FieldOffset(0xA0)] public float cloudExtinctionBlend;
        [FieldOffset(0xA4)] public bool enableShadow;
        [FieldOffset(0xA8)] public int shadowCoverage;
        [FieldOffset(0xAC)] public float shadowValueMin;
        [FieldOffset(0xB0)] public FxCloudBlendParameter blendParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FxCrepuscularRay
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float density;
        [FieldOffset(0x08)] public float decay;
        [FieldOffset(0x0C)] public float weight;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct FxManualHeightFog
    {
        [FieldOffset(0x00)] public Vector3 sunColor;
        [FieldOffset(0x10)] public Vector3 ambColor;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x70)]
    public struct FxHeightFog
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool enableFogMap;
        [FieldOffset(0x04)] public float heightScale;
        [FieldOffset(0x08)] public float distanceOffset;
        [FieldOffset(0x0C)] public float distanceScale;
        [FieldOffset(0x10)] public Vector3 rayleighScale;
        [FieldOffset(0x20)] public Vector3 mieScale;
        [FieldOffset(0x30)] public float noiseBlend;
        [FieldOffset(0x34)] public float noiseScale;
        [FieldOffset(0x38)] public float noiseDistance;
        [FieldOffset(0x3C)] public float animationSpeed;
        [FieldOffset(0x40)] public float animationAngle;
        [FieldOffset(0x44)] public bool isAtmospheric;
        [FieldOffset(0x50)] public FxManualHeightFog manualFog;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x300)]
    public struct FxAtmosphereParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public FxStaticSkyDomeParameter staticSkyDome;
        [FieldOffset(0x10)] public FxSun sunParam;
        [FieldOffset(0x40)] public FxMoon moonParam;
        [FieldOffset(0x44)] public FxSkyCommon commonSkyParam;
        [FieldOffset(0x60)] public FxBrunetonSky brunetonSkyParam;
        [FieldOffset(0xF0)] public FxSebastienSky sebastienSkyParam;
        [FieldOffset(0x180)] public FxCloudParameter cloudParam;
        [FieldOffset(0x280)] public FxCrepuscularRay crepuscularRayParam;
        [FieldOffset(0x290)] public FxHeightFog heightFogParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FxPuddleParameter
    {
        [FieldOffset(0x00)] public float heightThreshold;
        [FieldOffset(0x04)] public float slopeThreshold;
        [FieldOffset(0x08)] public float noiseScaleXZ;
        [FieldOffset(0x0C)] public float noiseScaleY;
        [FieldOffset(0x10)] public float noiseThreshold;
        [FieldOffset(0x14)] public float noiseAttenuationRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FxRippleParameter
    {
        [FieldOffset(0x00)] public float intensity;
        [FieldOffset(0x04)] public float uvScale;
        [FieldOffset(0x08)] public float timeScale;
        [FieldOffset(0x0C)] public float normalIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct FxDropParameter
    {
        [FieldOffset(0x00)] public float uvScale;
        [FieldOffset(0x04)] public float timeScale;
        [FieldOffset(0x08)] public float normalIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    public struct FxRainParameter
    {
        [FieldOffset(0x00)] public bool enableDrop;
        [FieldOffset(0x01)] public bool enableFilter;
        [FieldOffset(0x02)] public bool enableRipple;
        [FieldOffset(0x03)] public bool enableDropWater;
        [FieldOffset(0x04)] public float intensity;
        [FieldOffset(0x10)] public Vector4 dropColor;
        [FieldOffset(0x20)] public bool dropRotTarget;
        [FieldOffset(0x21)] public bool enableDropOcc;
        [FieldOffset(0x24)] public float dropCameraLerp;
        [FieldOffset(0x28)] public float dropCameraRate;
        [FieldOffset(0x2C)] public float dropCameraRotation;
        [FieldOffset(0x30)] public float dropWidth;
        [FieldOffset(0x34)] public float dropLength;
        [FieldOffset(0x38)] public float dropWind;
        [FieldOffset(0x3C)] public float dropRange;
        [FieldOffset(0x40)] public Vector4 filterColor;
        [FieldOffset(0x50)] public float filterRange;
        [FieldOffset(0x54)] public float filterEdge;
        [FieldOffset(0x58)] public float filterAngle;
        [FieldOffset(0x5C)] public FxRippleParameter ripple;
        [FieldOffset(0x6C)] public FxDropParameter drop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct FxWeatherParameter
    {
        [FieldOffset(0x00)] public float wetness;
        [FieldOffset(0x04)] public float char_wetness;
        [FieldOffset(0x08)] public FxPuddleParameter puddle;
        [FieldOffset(0x20)] public FxRainParameter rain;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct FxSceneEnvironmentParameter
    {
        [FieldOffset(0x00)] public float windRotationY;
        [FieldOffset(0x04)] public float windStrength;
        [FieldOffset(0x08)] public float windNoise;
        [FieldOffset(0x0C)] public float windAmplitude;
        [FieldOffset(0x10)] public float windFrequencies__arr0;
        [FieldOffset(0x14)] public float windFrequencies__arr1;
        [FieldOffset(0x18)] public float windFrequencies__arr2;
        [FieldOffset(0x1C)] public float windFrequencies__arr3;
        [FieldOffset(0x20)] public bool enableTreadGrass;
        [FieldOffset(0x30)] public Vector4 grassLodDistance;
        [FieldOffset(0x40)] public bool enableHighLight;
        [FieldOffset(0x44)] public float highLightThreshold;
        [FieldOffset(0x48)] public float highLightObjectAmbientScale;
        [FieldOffset(0x4C)] public float highLightObjectAlbedoHeighten;
        [FieldOffset(0x50)] public float highLightCharaAmbientScale;
        [FieldOffset(0x54)] public float highLightCharaAlbedoHeighten;
        [FieldOffset(0x58)] public float highLightCharaFalloffScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct FxTAAParameter
    {
        [FieldOffset(0x00)] public bool enableUpscaling;
        [FieldOffset(0x04)] public float jitterScale;
        [FieldOffset(0x08)] public float mipBias;
        [FieldOffset(0x0C)] public float sharpnessPower;
        [FieldOffset(0x10)] public float baseWeight;
        [FieldOffset(0x14)] public float velocityVarianceBasedWeightBias;
        [FieldOffset(0x18)] public float colorSpaceClippingScale;
        [FieldOffset(0x1C)] public float colorSpaceClippingScaleForStatic;
        [FieldOffset(0x20)] public float velocityVarianceMin;
        [FieldOffset(0x24)] public float velocityVarianceMax;
        [FieldOffset(0x28)] public bool enableCharaStencilMask;
        [FieldOffset(0x29)] public bool enableLiteMode;
        [FieldOffset(0x2A)] public bool enablePassThrough;
        [FieldOffset(0x2B)] public bool debugVisualizeVelcotiyVariance;
        [FieldOffset(0x30)] public Vector4 debug;
    }

    public enum PlacementType : sbyte
    {
        CirclePacking = 0,
        RandomPos = 1,
        PT_COUNT = 2
    }

    public enum ShadowCullingType : sbyte
    {
        Normal = 0,
        AabbUpScale2 = 1,
        ShadowFrustum = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct FxDensityLodParameter
    {
        [FieldOffset(0x00)] public float lodRatio;
        [FieldOffset(0x04)] public float lodRise;
        [FieldOffset(0x08)] public float lodDecrease;
        [FieldOffset(0x0C)] public float lodThreshold;
        [FieldOffset(0x10)] public bool lodFadeEnable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xCC)]
    public struct FxDensityDebugParameter
    {
        [FieldOffset(0x00)] public bool underSelect;
        [FieldOffset(0x04)] public float factor;
        [FieldOffset(0x08)] public float unit__arr0;
        [FieldOffset(0x0C)] public float unit__arr1;
        [FieldOffset(0x10)] public float unit__arr2;
        [FieldOffset(0x14)] public float unit__arr3;
        [FieldOffset(0x18)] public float unit__arr4;
        [FieldOffset(0x1C)] public float unit__arr5;
        [FieldOffset(0x20)] public float unit__arr6;
        [FieldOffset(0x24)] public float unit__arr7;
        [FieldOffset(0x28)] public float unit__arr8;
        [FieldOffset(0x2C)] public float unit__arr9;
        [FieldOffset(0x30)] public float unit__arr10;
        [FieldOffset(0x34)] public float unit__arr11;
        [FieldOffset(0x38)] public float unit__arr12;
        [FieldOffset(0x3C)] public float unit__arr13;
        [FieldOffset(0x40)] public float unit__arr14;
        [FieldOffset(0x44)] public float unit__arr15;
        [FieldOffset(0x48)] public float unit__arr16;
        [FieldOffset(0x4C)] public float unit__arr17;
        [FieldOffset(0x50)] public float unit__arr18;
        [FieldOffset(0x54)] public float unit__arr19;
        [FieldOffset(0x58)] public float unit__arr20;
        [FieldOffset(0x5C)] public float unit__arr21;
        [FieldOffset(0x60)] public float unit__arr22;
        [FieldOffset(0x64)] public float unit__arr23;
        [FieldOffset(0x68)] public float unit__arr24;
        [FieldOffset(0x6C)] public float unit__arr25;
        [FieldOffset(0x70)] public float unit__arr26;
        [FieldOffset(0x74)] public float unit__arr27;
        [FieldOffset(0x78)] public float unit__arr28;
        [FieldOffset(0x7C)] public float unit__arr29;
        [FieldOffset(0x80)] public float unit__arr30;
        [FieldOffset(0x84)] public float unit__arr31;
        [FieldOffset(0x88)] public sbyte chunk__arr0;
        [FieldOffset(0x89)] public sbyte chunk__arr1;
        [FieldOffset(0x8A)] public sbyte chunk__arr2;
        [FieldOffset(0x8B)] public sbyte chunk__arr3;
        [FieldOffset(0x8C)] public sbyte chunk__arr4;
        [FieldOffset(0x8D)] public sbyte chunk__arr5;
        [FieldOffset(0x8E)] public sbyte chunk__arr6;
        [FieldOffset(0x8F)] public sbyte chunk__arr7;
        [FieldOffset(0x90)] public sbyte chunk__arr8;
        [FieldOffset(0x91)] public sbyte chunk__arr9;
        [FieldOffset(0x92)] public sbyte chunk__arr10;
        [FieldOffset(0x93)] public sbyte chunk__arr11;
        [FieldOffset(0x94)] public sbyte chunk__arr12;
        [FieldOffset(0x95)] public sbyte chunk__arr13;
        [FieldOffset(0x96)] public sbyte chunk__arr14;
        [FieldOffset(0x97)] public sbyte chunk__arr15;
        [FieldOffset(0x98)] public sbyte chunk__arr16;
        [FieldOffset(0x99)] public sbyte chunk__arr17;
        [FieldOffset(0x9A)] public sbyte chunk__arr18;
        [FieldOffset(0x9B)] public sbyte chunk__arr19;
        [FieldOffset(0x9C)] public sbyte chunk__arr20;
        [FieldOffset(0x9D)] public sbyte chunk__arr21;
        [FieldOffset(0x9E)] public sbyte chunk__arr22;
        [FieldOffset(0x9F)] public sbyte chunk__arr23;
        [FieldOffset(0xA0)] public sbyte chunk__arr24;
        [FieldOffset(0xA1)] public sbyte chunk__arr25;
        [FieldOffset(0xA2)] public sbyte chunk__arr26;
        [FieldOffset(0xA3)] public sbyte chunk__arr27;
        [FieldOffset(0xA4)] public sbyte chunk__arr28;
        [FieldOffset(0xA5)] public sbyte chunk__arr29;
        [FieldOffset(0xA6)] public sbyte chunk__arr30;
        [FieldOffset(0xA7)] public sbyte chunk__arr31;
        [FieldOffset(0xA8)] public float lodAddition;
        [FieldOffset(0xAC)] public int chunkAddition;
        [FieldOffset(0xB0)] public float drawLimitLenght;
        [FieldOffset(0xB4)] public bool drawCallReduction;
        [FieldOffset(0xB5)] public bool enableDither;
        [FieldOffset(0xB8)] public int ditherGrass;
        [FieldOffset(0xBC)] public int ditherOther;
        [FieldOffset(0xC0)] public int ditherPreComputeGrass;
        [FieldOffset(0xC4)] public int ditherPreComputeOther;
        [FieldOffset(0xC8)] public int computeMode;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10C)]
    public struct FxDensityParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool precomputeEnable;
        [FieldOffset(0x02)] public bool cameraUpdate;
        [FieldOffset(0x03)] public PlacementType placement;
        [FieldOffset(0x04)] public float placementScale;
        [FieldOffset(0x08)] public bool alphaEnable;
        [FieldOffset(0x0C)] public float alphaThreshold;
        [FieldOffset(0x10)] public float alphaScale;
        [FieldOffset(0x14)] public bool complementEnable;
        [FieldOffset(0x15)] public bool disableCut;
        [FieldOffset(0x16)] public ShadowCullingType shadowCulling;
        [FieldOffset(0x17)] public bool occlusionCulling;
        [FieldOffset(0x18)] public float occlusionSize;
        [FieldOffset(0x1C)] public float occlusionShadowSize;
        [FieldOffset(0x20)] public float occlusionBias;
        [FieldOffset(0x24)] public FxDensityLodParameter lodParam;
        [FieldOffset(0x38)] public bool angleCulling;
        [FieldOffset(0x3C)] public float angleCullingParam;
        [FieldOffset(0x40)] public FxDensityDebugParameter debugParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x24)]
    public struct FxChromaticAberrationParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float offsetR;
        [FieldOffset(0x08)] public float offsetG;
        [FieldOffset(0x0C)] public float offsetB;
        [FieldOffset(0x10)] public float curve;
        [FieldOffset(0x14)] public float scaleX;
        [FieldOffset(0x18)] public float scaleY;
        [FieldOffset(0x1C)] public float centerX;
        [FieldOffset(0x20)] public float centerY;
    }

    public enum GradationMode : sbyte
    {
        GRADATION_MODE_CIRCLE = 0,
        GRADATION_MODE_LINE = 1
    }

    public enum BlendMode : sbyte
    {
        BLEND_MODE_ALPHA_BLEND = 0,
        BLEND_MODE_ADD = 1,
        BLEND_MODE_MUL = 2,
        BLEND_MODE_SCREEN = 3,
        BLEND_MODE_OVERLAY = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FxVfImageCircleParameter
    {
        [FieldOffset(0x00)] public float centerX;
        [FieldOffset(0x04)] public float centerY;
        [FieldOffset(0x08)] public float scaleX;
        [FieldOffset(0x0C)] public float scaleY;
        [FieldOffset(0x10)] public float scale;
        [FieldOffset(0x14)] public float rotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct FxVfLineParameter
    {
        [FieldOffset(0x00)] public float centerX;
        [FieldOffset(0x04)] public float centerY;
        [FieldOffset(0x08)] public float directionX;
        [FieldOffset(0x0C)] public float directionY;
        [FieldOffset(0x10)] public float rotation;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x60)]
    public struct FxVignetteParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public GradationMode gradationType;
        [FieldOffset(0x02)] public BlendMode blendMode;
        [FieldOffset(0x10)] public Vector3 color;
        [FieldOffset(0x20)] public float opacity;
        [FieldOffset(0x24)] public FxVfImageCircleParameter imageCircle;
        [FieldOffset(0x3C)] public FxVfLineParameter line;
        [FieldOffset(0x50)] public float penumbraScale;
        [FieldOffset(0x54)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FxWindComputeDebugParameter
    {
        [FieldOffset(0x00)] public bool debugEnable;
        [FieldOffset(0x01)] public bool debugSpace;
        [FieldOffset(0x02)] public bool debugGlobal;
        [FieldOffset(0x03)] public bool debugGlobalMap;
        [FieldOffset(0x04)] public bool debugSpaceAll;
        [FieldOffset(0x08)] public int spaceIndex;
        [FieldOffset(0x0C)] public float spaceThreshold;
        [FieldOffset(0x10)] public float min;
        [FieldOffset(0x14)] public float max;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA0)]
    public struct FxWindComputeParameter
    {
        [FieldOffset(0x00)] public bool enableAll;
        [FieldOffset(0x01)] public bool enableDynamicWind;
        [FieldOffset(0x02)] public bool enableGlobalWind;
        [FieldOffset(0x04)] public float timeScale;
        [FieldOffset(0x08)] public float decreaseRate;
        [FieldOffset(0x10)] public Vector3 globalWind;
        [FieldOffset(0x20)] public float globalWindPower;
        [FieldOffset(0x24)] public float globalWindSpeed;
        [FieldOffset(0x28)] public float globalWindOffset;
        [FieldOffset(0x30)] public Vector3 globalSecondWind;
        [FieldOffset(0x40)] public float globalSecondWindPower;
        [FieldOffset(0x44)] public float globalSecondWindSpeed;
        [FieldOffset(0x48)] public float globalSecondWindOffset;
        [FieldOffset(0x50)] public Vector3 globalWindMapSize;
        [FieldOffset(0x60)] public Vector3 globalWindMapCenter;
        [FieldOffset(0x70)] public Vector3 globalWindMapOffset;
        [FieldOffset(0x80)] public float globalWindMapPower;
        [FieldOffset(0x84)] public float globalWindMapTimeScale;
        [FieldOffset(0x88)] public FxWindComputeDebugParameter debugParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct FxTerrainMaterialBlendingParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float blendPower;
        [FieldOffset(0x08)] public float blendHightPower;
        [FieldOffset(0x0C)] public float cullingDistance;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct FxInteractionDebugParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool collisionEnable;
        [FieldOffset(0x04)] public float threshold;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct FxInteractionParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float power;
        [FieldOffset(0x08)] public float decrease;
        [FieldOffset(0x0C)] public float timeScale;
        [FieldOffset(0x10)] public FxInteractionDebugParameter debug;
        [FieldOffset(0x18)] public float tremorPower;
        [FieldOffset(0x1C)] public float tremorSpeed;
        [FieldOffset(0x20)] public float tremorScaleCriterion;
        [FieldOffset(0x24)] public float tremorScaleReduce;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct FxGpuEnvironmentParameter
    {
        [FieldOffset(0x00)] public float grassDitherStart;
        [FieldOffset(0x04)] public float grassDitherEnd;
        [FieldOffset(0x08)] public FxInteractionParameter interaction;
        [FieldOffset(0x30)] public bool enableZoomBias;
        [FieldOffset(0x34)] public float zoomBias;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct FxInteractiveWaveParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public bool enableDebugDisplay;
        [FieldOffset(0x04)] public float waveDamping;
        [FieldOffset(0x08)] public float waveReduceRange;
        [FieldOffset(0x0C)] public float waveSpeed;
        [FieldOffset(0x10)] public float simurationScale;
        [FieldOffset(0x14)] public float playerMaxSpeed;
        [FieldOffset(0x18)] public bool isInWaterDummy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct FxCyberNoiseEffectParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float tileX;
        [FieldOffset(0x08)] public float tileY;
        [FieldOffset(0x0C)] public float tileScrollSpeed;
        [FieldOffset(0x10)] public float noiseScrollSpeed;
        [FieldOffset(0x14)] public float thresholdSpeed;
        [FieldOffset(0x18)] public float thredholdMin;
        [FieldOffset(0x1C)] public float thredholdMax;
        [FieldOffset(0x20)] public float selectRate;
        [FieldOffset(0x24)] public float scanLineRSpeed;
        [FieldOffset(0x28)] public float scanLineRBlend;
        [FieldOffset(0x2C)] public float scanLineGSpeed;
        [FieldOffset(0x30)] public float scanLineGBlend;
        [FieldOffset(0x34)] public float rgbLineScale;
        [FieldOffset(0x38)] public float rgbLineBlend;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct UVShift
    {
        [FieldOffset(0x00)] public float blockLNoiseSizeX;
        [FieldOffset(0x04)] public float blockLNoiseSizeY;
        [FieldOffset(0x08)] public float blockHNoiseSizeX;
        [FieldOffset(0x0C)] public float blockHNoiseSizeY;
        [FieldOffset(0x10)] public float bNoiseHighRate;
        [FieldOffset(0x14)] public float intensity;
        [FieldOffset(0x18)] public float pixelShiftIntensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct ColorShift
    {
        [FieldOffset(0x00)] public float blockLNoiseSize;
        [FieldOffset(0x04)] public float blockHNoiseSize;
        [FieldOffset(0x08)] public float bNoiseHighRate;
        [FieldOffset(0x0C)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct InterlaceNoise
    {
        [FieldOffset(0x00)] public float blockLNoiseSize;
        [FieldOffset(0x04)] public float blockHNoiseSize;
        [FieldOffset(0x08)] public float bNoiseHighRate;
        [FieldOffset(0x0C)] public float intensity;
        [FieldOffset(0x10)] public float dropout;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct ColorDropout
    {
        [FieldOffset(0x00)] public float blockLNoiseSizeX;
        [FieldOffset(0x04)] public float blockLNoiseSizeY;
        [FieldOffset(0x08)] public float blockHNoiseSizeX;
        [FieldOffset(0x0C)] public float blockHNoiseSizeY;
        [FieldOffset(0x10)] public float bNoiseHighRate;
        [FieldOffset(0x14)] public float intensity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct InvertColor
    {
        [FieldOffset(0x00)] public float blockLNoiseSizeX;
        [FieldOffset(0x04)] public float blockLNoiseSizeY;
        [FieldOffset(0x08)] public float blockHNoiseSizeX;
        [FieldOffset(0x0C)] public float blockHNoiseSizeY;
        [FieldOffset(0x10)] public float bNoiseHighRate;
        [FieldOffset(0x14)] public float intensity;
        [FieldOffset(0x18)] public float invertAllRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct GlayScaleColor
    {
        [FieldOffset(0x00)] public float blockLNoiseSizeX;
        [FieldOffset(0x04)] public float blockLNoiseSizeY;
        [FieldOffset(0x08)] public float blockHNoiseSizeX;
        [FieldOffset(0x0C)] public float blockHNoiseSizeY;
        [FieldOffset(0x10)] public float bNoiseHighRate;
        [FieldOffset(0x14)] public float intensity;
        [FieldOffset(0x18)] public float invertAllRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA4)]
    public struct FxCyberSpaceStartNoiseParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public UVShift uvShift;
        [FieldOffset(0x20)] public ColorShift colorShift;
        [FieldOffset(0x30)] public InterlaceNoise interlaceNoise;
        [FieldOffset(0x44)] public ColorDropout colorDrop;
        [FieldOffset(0x5C)] public InvertColor invertColor;
        [FieldOffset(0x78)] public GlayScaleColor glayscaleColor;
        [FieldOffset(0x94)] public float noiseSpeed;
        [FieldOffset(0x98)] public float noiseBias;
        [FieldOffset(0x9C)] public float noiseWaveAmplitude;
        [FieldOffset(0xA0)] public float noiseWaveCycle;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x01)]
    public struct FxCyberNPCSSEffectRenderParameter
    {
        [FieldOffset(0x00)] public bool enable;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct FxFieldScanEffectRenderParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector3 centerPos;
        [FieldOffset(0x20)] public Color8 color;
        [FieldOffset(0x24)] public float radius1;
        [FieldOffset(0x28)] public float radius2;
        [FieldOffset(0x2C)] public float radius3;
        [FieldOffset(0x30)] public float intensity1;
        [FieldOffset(0x34)] public float intensity2;
        [FieldOffset(0x38)] public float intensity3;
        [FieldOffset(0x3C)] public float gridIntensity;
        [FieldOffset(0x40)] public float innerWidth;
        [FieldOffset(0x44)] public float gridLineWidth;
        [FieldOffset(0x48)] public float gridLineSpan;
    }

    public enum ColorblinidSimulationType : sbyte
    {
        COLORBLIND_SIM_NONE = 0,
        COLORBLIND_SIM_PROTANOPIA = 1,
        COLORBLIND_SIM_DEUTERANOPIA = 2,
        COLORBLIND_SIM_TRITANOPIA = 3,
        COLORBLIND_SIM_ALL = 4
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct FxColorAccessibilityFilterParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float daltonizeFactor;
        [FieldOffset(0x08)] public float protanopiaFactor;
        [FieldOffset(0x0C)] public float deuteranopiaFactor;
        [FieldOffset(0x10)] public float tritanopiaFactor;
        [FieldOffset(0x14)] public float brightness;
        [FieldOffset(0x18)] public float contrast;
        [FieldOffset(0x1C)] public float maskIntensity__arr0;
        [FieldOffset(0x20)] public float maskIntensity__arr1;
        [FieldOffset(0x24)] public float maskIntensity__arr2;
        [FieldOffset(0x28)] public float maskIntensity__arr3;
        [FieldOffset(0x2C)] public float maskIntensity__arr4;
        [FieldOffset(0x30)] public ColorblinidSimulationType simulationType;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct FxDentParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float simRadius;
        [FieldOffset(0x08)] public float dentDepth;
        [FieldOffset(0x0C)] public float normalIntensity;
        [FieldOffset(0x10)] public float edgeBulge;
        [FieldOffset(0x14)] public float fade;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x130)]
    public struct FxSeparableSSSParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x10)] public Vector4 ambientColorBoost;
        [FieldOffset(0x20)] public bool transmitEnable;
        [FieldOffset(0x24)] public float width;
        [FieldOffset(0x28)] public float normalOffset;
        [FieldOffset(0x2C)] public float blurOffsetMax;
        [FieldOffset(0x30)] public Vector4 strength__arr0;
        [FieldOffset(0x40)] public Vector4 strength__arr1;
        [FieldOffset(0x50)] public Vector4 strength__arr2;
        [FieldOffset(0x60)] public Vector4 strength__arr3;
        [FieldOffset(0x70)] public Vector4 strength__arr4;
        [FieldOffset(0x80)] public Vector4 strength__arr5;
        [FieldOffset(0x90)] public Vector4 strength__arr6;
        [FieldOffset(0xA0)] public Vector4 strength__arr7;
        [FieldOffset(0xB0)] public Vector4 strength__arr8;
        [FieldOffset(0xC0)] public Vector4 strength__arr9;
        [FieldOffset(0xD0)] public Vector4 strength__arr10;
        [FieldOffset(0xE0)] public Vector4 strength__arr11;
        [FieldOffset(0xF0)] public Vector4 strength__arr12;
        [FieldOffset(0x100)] public Vector4 strength__arr13;
        [FieldOffset(0x110)] public Vector4 strength__arr14;
        [FieldOffset(0x120)] public Vector4 strength__arr15;
    }

    public enum FxTimeStopParameter_Mode : sbyte
    {
        Active = 0,
        End = 1
    }

    public enum EffectType : sbyte
    {
        Gray = 0,
        Nega = 1,
        NegaGray = 2
    }

    public struct ColorF
    {
        public float A;
        public float R;
        public float G;
        public float B;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xA4)]
    public struct FxTimeStopParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x01)] public FxTimeStopParameter_Mode mode;
        [FieldOffset(0x04)] public float startSpeed;
        [FieldOffset(0x08)] public EffectType colorType;
        [FieldOffset(0x0C)] public float rimPower;
        [FieldOffset(0x10)] public float rimThreshold;
        [FieldOffset(0x14)] public ColorF rimColor__arr0;
        [FieldOffset(0x113)] public ColorF rimColor__arr1;
        [FieldOffset(0x34)] public float highlightPower;
        [FieldOffset(0x38)] public ColorF highlightColor__arr0;
        [FieldOffset(0x137)] public ColorF highlightColor__arr1;
        [FieldOffset(0x58)] public uint highlightCount;
        [FieldOffset(0x5C)] public float highlightDepth;
        [FieldOffset(0x60)] public float flashSpeed;
        [FieldOffset(0x64)] public float speedX;
        [FieldOffset(0x68)] public float speedY;
        [FieldOffset(0x6C)] public ColorF maskColor;
        [FieldOffset(0x7C)] public float distortionPower;
        [FieldOffset(0x80)] public float framesize;
        [FieldOffset(0x84)] public float frameDistortion;
        [FieldOffset(0x88)] public float frameSpeed;
        [FieldOffset(0x8C)] public float rotSpeed;
        [FieldOffset(0x90)] public bool rotMode;
        [FieldOffset(0x94)] public float rotDistortionSpeed;
        [FieldOffset(0x98)] public bool endFade;
        [FieldOffset(0x9C)] public float endSpeed;
        [FieldOffset(0xA0)] public bool overrideParam;
        [FieldOffset(0xA1)] public bool transObjectEnable;
        [FieldOffset(0xA2)] public bool objectTimeStop;
        [FieldOffset(0xA3)] public bool vignette;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1390)]
    public struct NeedleFxParameter
    {
        [FieldOffset(0x00)] public FxRenderOption renderOption;
        [FieldOffset(0x250)] public FxSGGIParameter sggi;
        [FieldOffset(0x268)] public FxRLRParameter rlr;
        [FieldOffset(0x290)] public FxSSGIParameter ssgi;
        [FieldOffset(0x2B0)] public FxPlanarReflectionParameter planarReflection;
        [FieldOffset(0x2E0)] public FxBloomParameter bloom;
        [FieldOffset(0x2F0)] public FxCameraControlParameter cameraControl;
        [FieldOffset(0x31C)] public FxToneMapParameter tonemap;
        [FieldOffset(0x34C)] public FxColorContrastParameter colorContrast;
        [FieldOffset(0x3A0)] public FxLightScatteringParameter lightscattering;
        [FieldOffset(0x400)] public FxFogParameter fog;
        [FieldOffset(0x450)] public FxDOFParameter dof;
        [FieldOffset(0x4C0)] public FxShadowMapParameter shadowmap;
        [FieldOffset(0x610)] public FxShadowHeightMapParameter shadowHeightMap;
        [FieldOffset(0x624)] public FxVolumetricShadowParameter volShadow;
        [FieldOffset(0x628)] public FxSSAOParameter ssao;
        [FieldOffset(0x6A0)] public FxSHLightFieldParameter shlightfield;
        [FieldOffset(0x6E0)] public FxScreenBlurParameter blur;
        [FieldOffset(0x710)] public FxOcclusionCapsuleParameter occlusionCapsule;
        [FieldOffset(0x7A0)] public FxEffectParameter effect;
        [FieldOffset(0x800)] public FxScreenSpaceGodrayParameter ssGodray;
        [FieldOffset(0x840)] public FxGodrayParameter godray;
        [FieldOffset(0x930)] public FxHeatHazeParameter heatHaze;
        [FieldOffset(0x950)] public FxAtmosphereParameter atmosphere;
        [FieldOffset(0xC50)] public FxWeatherParameter weather;
        [FieldOffset(0xCF0)] public FxSceneEnvironmentParameter sceneEnv;
        [FieldOffset(0xD50)] public FxTAAParameter taa;
        [FieldOffset(0xD90)] public FxDensityParameter density;
        [FieldOffset(0xE9C)] public FxChromaticAberrationParameter chromaticAberration;
        [FieldOffset(0xEC0)] public FxVignetteParameter vignette;
        [FieldOffset(0xF20)] public FxWindComputeParameter wind;
        [FieldOffset(0xFC0)] public FxTerrainMaterialBlendingParameter terrainBlend;
        [FieldOffset(0xFD0)] public FxGpuEnvironmentParameter gpuEnvironment;
        [FieldOffset(0x1008)] public FxInteractiveWaveParameter interactiveWave;
        [FieldOffset(0x1024)] public FxCyberNoiseEffectParameter cyberNoise;
        [FieldOffset(0x1060)] public FxCyberSpaceStartNoiseParameter cyberStartNoise;
        [FieldOffset(0x1104)] public FxCyberNPCSSEffectRenderParameter cyberNPCSS;
        [FieldOffset(0x1110)] public FxFieldScanEffectRenderParameter fieldScan;
        [FieldOffset(0x1160)] public FxColorAccessibilityFilterParameter colorAccessibility;
        [FieldOffset(0x1194)] public FxDentParameter dent;
        [FieldOffset(0x11B0)] public FxSeparableSSSParameter ssss;
        [FieldOffset(0x12E0)] public FxTimeStopParameter timestop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x2B0)]
    public struct TimeProgressAtmosphereParameter
    {
        [FieldOffset(0x00)] public FxSkyCommon commonSkyParam;
        [FieldOffset(0x10)] public FxBrunetonSky brunetonSkyParam;
        [FieldOffset(0xA0)] public FxSebastienSky sebastienSkyParam;
        [FieldOffset(0x130)] public FxCloudParameter cloudParam;
        [FieldOffset(0x230)] public FxCrepuscularRay crepuscularRayParam;
        [FieldOffset(0x240)] public FxHeightFog heightFogParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x650)]
    public struct TimeProgressNeedleFxParam
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public float time;
        [FieldOffset(0x08)] public FxBloomParameter bloom;
        [FieldOffset(0x18)] public FxCameraControlParameter cameraControl;
        [FieldOffset(0x44)] public FxCameraControlParameter cameraControlEvent;
        [FieldOffset(0x70)] public FxToneMapParameter tonemap;
        [FieldOffset(0xA0)] public FxColorContrastParameter colorContrast;
        [FieldOffset(0xF0)] public FxLightScatteringParameter lightscattering;
        [FieldOffset(0x150)] public FxEffectParameter effect;
        [FieldOffset(0x1B0)] public FxScreenSpaceGodrayParameter ssGodray;
        [FieldOffset(0x1F0)] public FxGodrayParameter godray;
        [FieldOffset(0x2E0)] public FxHeatHazeParameter heatHaze;
        [FieldOffset(0x300)] public TimeProgressAtmosphereParameter atmosphere;
        [FieldOffset(0x5B0)] public FxWeatherParameter weather;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x6F0)]
    public struct WeatherFxParameter
    {
        [FieldOffset(0x00)] public bool enable;
        [FieldOffset(0x04)] public FxBloomParameter bloom;
        [FieldOffset(0x14)] public FxCameraControlParameter cameraControl;
        [FieldOffset(0x40)] public FxCameraControlParameter cameraControlEvent;
        [FieldOffset(0x6C)] public FxToneMapParameter tonemap;
        [FieldOffset(0x9C)] public FxColorContrastParameter colorContrast;
        [FieldOffset(0xF0)] public FxLightScatteringParameter lightscattering;
        [FieldOffset(0x150)] public FxEffectParameter effect;
        [FieldOffset(0x1B0)] public FxScreenSpaceGodrayParameter ssGodray;
        [FieldOffset(0x1F0)] public FxGodrayParameter godray;
        [FieldOffset(0x2E0)] public FxHeatHazeParameter heatHaze;
        [FieldOffset(0x300)] public TimeProgressAtmosphereParameter atmosphere;
        [FieldOffset(0x5B0)] public FxWeatherParameter weather;
        [FieldOffset(0x650)] public FxWindComputeParameter wind;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct StageCommonParameter
    {
        [FieldOffset(0x00)] public float deadline;
        [FieldOffset(0x04)] public float oceanSurface;
        [FieldOffset(0x08)] public float deadFallTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0C)]
    public struct StageCameraParameter
    {
        [FieldOffset(0x00)] public float zNear;
        [FieldOffset(0x04)] public float zFar;
        [FieldOffset(0x08)] public float fovy;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct StageTerrainPrecisionParameter
    {
        [FieldOffset(0x00)] public float heightRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct StageTerrainMaterialParameter
    {
        [FieldOffset(0x00)] public float uvScaleDetail;
        [FieldOffset(0x04)] public float uvScaleBase;
        [FieldOffset(0x08)] public float detailDistance;
        [FieldOffset(0x0C)] public float detailFadeRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct StageTerrainParameter
    {
        [FieldOffset(0x00)] public bool useHeightMapTerrain;
        [FieldOffset(0x01)] public bool useHalfPrecision;
        [FieldOffset(0x04)] public StageTerrainPrecisionParameter precision;
        [FieldOffset(0x08)] public int worldSize;
        [FieldOffset(0x0C)] public int heightMapTexelDensity;
        [FieldOffset(0x10)] public float heightScale;
        [FieldOffset(0x14)] public float smallestCellSize;
        [FieldOffset(0x18)] public float slopeClipThrethold;
        [FieldOffset(0x1C)] public Vector2 aabbMin;
        [FieldOffset(0x24)] public Vector2 aabbMax;
        [FieldOffset(0x2C)] public StageTerrainMaterialParameter material;
        [FieldOffset(0x3C)] public bool enableGbufferBlending;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x58)]
    public struct StageConfig
    {
        [FieldOffset(0x00)] public StageCommonParameter common;
        [FieldOffset(0x0C)] public StageCameraParameter camera;
        [FieldOffset(0x18)] public StageTerrainParameter terrain;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x202B0)]
    public struct NeedleFxSceneData
    {
        [FieldOffset(0x00)] public NeedleFxSceneConfig config;
        [FieldOffset(0x140)] public NeedleFxParameter items__arr0;
        [FieldOffset(0x14D0)] public NeedleFxParameter items__arr1;
        [FieldOffset(0x2860)] public NeedleFxParameter items__arr2;
        [FieldOffset(0x3BF0)] public NeedleFxParameter items__arr3;
        [FieldOffset(0x4F80)] public NeedleFxParameter items__arr4;
        [FieldOffset(0x6310)] public NeedleFxParameter items__arr5;
        [FieldOffset(0x76A0)] public NeedleFxParameter items__arr6;
        [FieldOffset(0x8A30)] public NeedleFxParameter items__arr7;
        [FieldOffset(0x9DC0)] public NeedleFxParameter items__arr8;
        [FieldOffset(0xB150)] public NeedleFxParameter items__arr9;
        [FieldOffset(0xC4E0)] public NeedleFxParameter items__arr10;
        [FieldOffset(0xD870)] public NeedleFxParameter items__arr11;
        [FieldOffset(0xEC00)] public NeedleFxParameter items__arr12;
        [FieldOffset(0xFF90)] public NeedleFxParameter items__arr13;
        [FieldOffset(0x11320)] public NeedleFxParameter items__arr14;
        [FieldOffset(0x126B0)] public NeedleFxParameter items__arr15;
        [FieldOffset(0x13A40)] public TimeProgressNeedleFxParam timeItems__arr0;
        [FieldOffset(0x14090)] public TimeProgressNeedleFxParam timeItems__arr1;
        [FieldOffset(0x146E0)] public TimeProgressNeedleFxParam timeItems__arr2;
        [FieldOffset(0x14D30)] public TimeProgressNeedleFxParam timeItems__arr3;
        [FieldOffset(0x15380)] public TimeProgressNeedleFxParam timeItems__arr4;
        [FieldOffset(0x159D0)] public TimeProgressNeedleFxParam timeItems__arr5;
        [FieldOffset(0x16020)] public TimeProgressNeedleFxParam timeItems__arr6;
        [FieldOffset(0x16670)] public TimeProgressNeedleFxParam timeItems__arr7;
        [FieldOffset(0x16CC0)] public TimeProgressNeedleFxParam timeItems__arr8;
        [FieldOffset(0x17310)] public TimeProgressNeedleFxParam timeItems__arr9;
        [FieldOffset(0x17960)] public TimeProgressNeedleFxParam timeItems__arr10;
        [FieldOffset(0x17FB0)] public TimeProgressNeedleFxParam timeItems__arr11;
        [FieldOffset(0x18600)] public TimeProgressNeedleFxParam timeItems__arr12;
        [FieldOffset(0x18C50)] public TimeProgressNeedleFxParam timeItems__arr13;
        [FieldOffset(0x192A0)] public TimeProgressNeedleFxParam timeItems__arr14;
        [FieldOffset(0x198F0)] public TimeProgressNeedleFxParam timeItems__arr15;
        [FieldOffset(0x19F40)] public TimeProgressNeedleFxParam timeItems__arr16;
        [FieldOffset(0x1A590)] public TimeProgressNeedleFxParam timeItems__arr17;
        [FieldOffset(0x1ABE0)] public TimeProgressNeedleFxParam timeItems__arr18;
        [FieldOffset(0x1B230)] public TimeProgressNeedleFxParam timeItems__arr19;
        [FieldOffset(0x1B880)] public TimeProgressNeedleFxParam timeItems__arr20;
        [FieldOffset(0x1BED0)] public TimeProgressNeedleFxParam timeItems__arr21;
        [FieldOffset(0x1C520)] public TimeProgressNeedleFxParam timeItems__arr22;
        [FieldOffset(0x1CB70)] public TimeProgressNeedleFxParam timeItems__arr23;
        [FieldOffset(0x1D1C0)] public WeatherFxParameter weatherItems__arr0;
        [FieldOffset(0x1D8B0)] public WeatherFxParameter weatherItems__arr1;
        [FieldOffset(0x1DFA0)] public WeatherFxParameter weatherItems__arr2;
        [FieldOffset(0x1E690)] public WeatherFxParameter weatherItems__arr3;
        [FieldOffset(0x1ED80)] public WeatherFxParameter weatherItems__arr4;
        [FieldOffset(0x1F470)] public WeatherFxParameter weatherItems__arr5;
        [FieldOffset(0x1FB60)] public WeatherFxParameter weatherItems__arr6;
        [FieldOffset(0x20250)] public StageConfig stageConfig;
    }

}