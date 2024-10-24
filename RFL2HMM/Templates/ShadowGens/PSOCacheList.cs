Library "PSOCacheList"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

    public enum TYPE : byte
    {
        GRAPHICS = 0,
        COMPUTE = 1,
        MESHLET = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct UnmanagedString
    {
        [FieldOffset(0)] public long pValue;

        public string Value
        {
            get
            {
                if (pValue == 0)
                    return string.Empty;

                return Marshal.PtrToStringAnsi((nint)pValue);
            }

            set => pValue = (long)Marshal.StringToHGlobalAnsi(value);
        }

        public UnmanagedString(string in_value)
        {
            Value = in_value;
        }

        public static implicit operator UnmanagedString(string in_value)
        {
            return new UnmanagedString(in_value);
        }

        public static bool operator ==(UnmanagedString in_left, string in_right)
        {
            return in_left.Value == in_right;
        }

        public static bool operator !=(UnmanagedString in_left, string in_right)
        {
            return !(in_left == in_right);
        }

        public override bool Equals(object in_obj)
        {
            if (in_obj is string str)
                return Value == str;

            return base.Equals(in_obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct stringArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct PSOCacheShader
    {
        [FieldOffset(0x00)] public UnmanagedString Name;
        [FieldOffset(0x10)] public stringArray Variation;
        [FieldOffset(0x30)] public uint Hash;
    }

    public enum BLEND : byte
    {
        BLEND_INVALID = 0,
        ZERO = 1,
        ONE = 2,
        SRC_COLOR = 3,
        INV_SRC_COLOR = 4,
        SRC_ALPHA = 5,
        INV_SRC_ALPHA = 6,
        DEST_ALPHA = 7,
        INV_DEST_ALPHA = 8,
        DEST_COLOR = 9,
        INV_DEST_COLOR = 10,
        SRC_ALPHA_SAT = 11,
        BLEND_FACTOR = 12,
        INV_BLEND_FACTOR = 13,
        SRC1_COLOR = 14,
        INV_SRC1_COLOR = 15,
        SRC1_ALPHA = 16,
        INV_SRC1_ALPHA = 17
    }

    public enum BLEND_OP : byte
    {
        BLEND_OP_INVALID = 0,
        ADD = 1,
        SUBTRACT = 2,
        REV_SUBTRACT = 3,
        MIN = 4,
        MAX = 5
    }

    public enum LOGIC_OP : byte
    {
        LOGIC_OP_CLEAR = 0,
        LOGIC_OP_SET = 1,
        LOGIC_OP_COPY = 2,
        LOGIC_OP_COPY_INVERTED = 3,
        LOGIC_OP_NOOP = 4,
        LOGIC_OP_INVERT = 5,
        LOGIC_OP_AND = 6,
        LOGIC_OP_NAND = 7,
        LOGIC_OP_OR = 8,
        LOGIC_OP_NOR = 9,
        LOGIC_OP_XOR = 10,
        LOGIC_OP_EQUIV = 11,
        LOGIC_OP_AND_REVERSE = 12,
        LOGIC_OP_AND_INVERTED = 13,
        LOGIC_OP_OR_REVERSE = 14,
        LOGIC_OP_OR_INVERTED = 15
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0A)]
    public struct PSOCacheRenderTargetBlend
    {
        [FieldOffset(0x00)] public bool BlendEnable;
        [FieldOffset(0x01)] public bool LogicOpEnable;
        [FieldOffset(0x02)] public BLEND SrcBlend;
        [FieldOffset(0x03)] public BLEND DestBlend;
        [FieldOffset(0x04)] public BLEND_OP BlendOp;
        [FieldOffset(0x05)] public BLEND SrcBlendAlpha;
        [FieldOffset(0x06)] public BLEND DestBlendAlpha;
        [FieldOffset(0x07)] public BLEND_OP BlendOpAlpha;
        [FieldOffset(0x08)] public LOGIC_OP LogicOp;
        [FieldOffset(0x09)] public byte RenderTargetWriteMask;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x52)]
    public struct PSOCacheBlend
    {
        [FieldOffset(0x00)] public bool AlphaToCoverageEnable;
        [FieldOffset(0x01)] public bool IndependentBlendEnable;
        [FieldOffset(0x02)] public PSOCacheRenderTargetBlend RenderTarget__arr0;
        [FieldOffset(0x0C)] public PSOCacheRenderTargetBlend RenderTarget__arr1;
        [FieldOffset(0x16)] public PSOCacheRenderTargetBlend RenderTarget__arr2;
        [FieldOffset(0x20)] public PSOCacheRenderTargetBlend RenderTarget__arr3;
        [FieldOffset(0x2A)] public PSOCacheRenderTargetBlend RenderTarget__arr4;
        [FieldOffset(0x34)] public PSOCacheRenderTargetBlend RenderTarget__arr5;
        [FieldOffset(0x3E)] public PSOCacheRenderTargetBlend RenderTarget__arr6;
        [FieldOffset(0x48)] public PSOCacheRenderTargetBlend RenderTarget__arr7;
    }

    public enum FILL_MODE : byte
    {
        FILL_MODE_INVALID = 0,
        FILL_MODE_INVALID2 = 1,
        FILL_MODE_WIREFRAME = 2,
        FILL_MODE_SOLID = 3
    }

    public enum CULL_MODE : byte
    {
        CULL_MODE_INVALID = 0,
        CULL_MODE_NONE = 1,
        CULL_MODE_FRONT = 2,
        CULL_MODE_BACK = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PSOCacheRasterizer
    {
        [FieldOffset(0x00)] public FILL_MODE FillMode;
        [FieldOffset(0x01)] public CULL_MODE CullMode;
        [FieldOffset(0x02)] public bool FrontCounterClockwise;
        [FieldOffset(0x04)] public int DepthBias;
        [FieldOffset(0x08)] public float DepthBiasClamp;
        [FieldOffset(0x0C)] public float SlopeScaledDepthBias;
        [FieldOffset(0x10)] public bool DepthClipEnable;
        [FieldOffset(0x11)] public bool MultisampleEnable;
        [FieldOffset(0x12)] public bool AntialiasedLineEnable;
        [FieldOffset(0x14)] public uint ForcedSampleCount;
        [FieldOffset(0x18)] public bool ConservativeRaster;
    }

    public enum STENCIL_OP : byte
    {
        STENCIL_OP_INVALID = 0,
        STENCIL_OP_KEEP = 1,
        STENCIL_OP_ZERO = 2,
        STENCIL_OP_REPLACE = 3,
        STENCIL_OP_INCR_SAT = 4,
        STENCIL_OP_DECR_SAT = 5,
        STENCIL_OP_INVERT = 6,
        STENCIL_OP_INCR = 7,
        STENCIL_OP_DECR = 8
    }

    public enum COMPARISON_FUNC : byte
    {
        COMPARISON_FUNC_INVALID = 0,
        COMPARISON_FUNC_NEVER = 1,
        COMPARISON_FUNC_LESS = 2,
        COMPARISON_FUNC_EQUAL = 3,
        COMPARISON_FUNC_LESS_EQUAL = 4,
        COMPARISON_FUNC_GREATER = 5,
        COMPARISON_FUNC_NOT_EQUAL = 6,
        COMPARISON_FUNC_GREATER_EQUAL = 7,
        COMPARISON_FUNC_ALWAYS = 8
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct PSOCacheDepthStencilOp
    {
        [FieldOffset(0x00)] public STENCIL_OP StencilFailOp;
        [FieldOffset(0x01)] public STENCIL_OP StencilDepthFailOp;
        [FieldOffset(0x02)] public STENCIL_OP StencilPassOp;
        [FieldOffset(0x03)] public COMPARISON_FUNC StencilFunc;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x0E)]
    public struct PSOCacheDepthStencil
    {
        [FieldOffset(0x00)] public bool DepthEnable;
        [FieldOffset(0x01)] public bool DepthWriteMask;
        [FieldOffset(0x02)] public PSOCacheDepthStencilOp DepthFunc;
        [FieldOffset(0x03)] public bool StencilEnable;
        [FieldOffset(0x04)] public byte StencilReadMask;
        [FieldOffset(0x05)] public byte StencilWriteMask;
        [FieldOffset(0x06)] public PSOCacheDepthStencilOp FrontFace;
        [FieldOffset(0x0A)] public PSOCacheDepthStencilOp BackFace;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct PSOCacheInputElement
    {
        [FieldOffset(0x00)] public UnmanagedString SemanticName;
        [FieldOffset(0x10)] public uint SemanticIndex;
        [FieldOffset(0x14)] public uint Format;
        [FieldOffset(0x18)] public uint InputSlot;
        [FieldOffset(0x1C)] public uint AlignedByteOffset;
        [FieldOffset(0x20)] public bool InputSlotClass;
        [FieldOffset(0x24)] public uint InstanceDataStepRate;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PSOCacheInputElementArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct PSOCacheInputLayout
    {
        [FieldOffset(0x00)] public PSOCacheInputElementArray InputElements;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x08)]
    public struct PSOCacheSample
    {
        [FieldOffset(0x00)] public uint Count;
        [FieldOffset(0x04)] public uint Quality;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x198)]
    public struct PSOCache
    {
        [FieldOffset(0x00)] public TYPE Type;
        [FieldOffset(0x08)] public PSOCacheShader VS;
        [FieldOffset(0x40)] public PSOCacheShader PS;
        [FieldOffset(0x78)] public PSOCacheShader CS;
        [FieldOffset(0xB0)] public PSOCacheBlend BlendState;
        [FieldOffset(0x104)] public uint SampleMask;
        [FieldOffset(0x108)] public PSOCacheRasterizer RasterizerState;
        [FieldOffset(0x124)] public PSOCacheDepthStencil DepthStencilState;
        [FieldOffset(0x138)] public PSOCacheInputLayout InputLayout;
        [FieldOffset(0x158)] public uint IBStripCutValue;
        [FieldOffset(0x15C)] public uint PrimitiveTopologyType;
        [FieldOffset(0x160)] public uint NumRenderTargets;
        [FieldOffset(0x164)] public uint RTVFormats__arr0;
        [FieldOffset(0x168)] public uint RTVFormats__arr1;
        [FieldOffset(0x16C)] public uint RTVFormats__arr2;
        [FieldOffset(0x170)] public uint RTVFormats__arr3;
        [FieldOffset(0x174)] public uint RTVFormats__arr4;
        [FieldOffset(0x178)] public uint RTVFormats__arr5;
        [FieldOffset(0x17C)] public uint RTVFormats__arr6;
        [FieldOffset(0x180)] public uint RTVFormats__arr7;
        [FieldOffset(0x184)] public uint DSVFormat;
        [FieldOffset(0x188)] public PSOCacheSample SampleDesc;
        [FieldOffset(0x190)] public uint NodeMask;
        [FieldOffset(0x194)] public uint Flags;
    }

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct PSOCacheArray
    {
        [FieldOffset(0)] public long pData;
        [FieldOffset(8)] public long Size;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct PSOCacheList
    {
        [FieldOffset(0x00)] public uint version;
        [FieldOffset(0x08)] public PSOCacheArray caches;
    }

}