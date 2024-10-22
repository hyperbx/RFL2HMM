Library "GismoConfigDesignData"
{
    #load "System.Numerics.dll"

    using System.Numerics;
    using System.Runtime.InteropServices;

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

    [StructLayout(LayoutKind.Explicit, Size = 0x28)]
    public struct GismoBasicParam
    {
        [FieldOffset(0x00)] public UnmanagedString modelName;
        [FieldOffset(0x10)] public UnmanagedString skeltonName;
        [FieldOffset(0x20)] public bool noInstance;
    }

    public enum ShapeType : sbyte
    {
        SHAPE_BOX = 0,
        SHAPE_SPHERE = 1,
        SHAPE_CAPSULE = 2,
        SHAPE_CYLINDER = 3,
        SHAPE_MESH = 4,
        SHAPE_NONE = 5
    }

    public enum BasePoint : sbyte
    {
        BASE_CENTER = 0,
        BASE_Z_PLANE = 1,
        BASE_X_PLANE = 2,
        BASE_Y_PLANE = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct GismoCollision
    {
        [FieldOffset(0x00)] public ShapeType shape;
        [FieldOffset(0x01)] public BasePoint basePoint;
        [FieldOffset(0x04)] public float width;
        [FieldOffset(0x08)] public float height;
        [FieldOffset(0x0C)] public float depth;
        [FieldOffset(0x10)] public UnmanagedString meshName;
        [FieldOffset(0x20)] public Vector3 shapeOffset;
        [FieldOffset(0x30)] public float shapeSizeOffset;
    }

    public enum RigidBodyType : sbyte
    {
        RIGID_BODY_NONE = 0,
        RIGID_BODY_STATIC = 1,
        RIGID_BODY_DYNAMIC = 2
    }

    public enum RigidBodyMaterial : sbyte
    {
        RIGID_BODY_MAT_NONE = 0,
        RIGID_BODY_MAT_WOOD = 1,
        RIGID_BODY_MAT_IRON = 2,
        NUM_RIGID_BODY_MATS = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x1C)]
    public struct PhysicsParam
    {
        [FieldOffset(0x00)] public float mass;
        [FieldOffset(0x04)] public float friction;
        [FieldOffset(0x08)] public float gravityFactor;
        [FieldOffset(0x0C)] public float restitution;
        [FieldOffset(0x10)] public float linearDamping;
        [FieldOffset(0x14)] public float angularDamping;
        [FieldOffset(0x18)] public float maxLinearVelocity;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x20)]
    public struct GismoRegidBody
    {
        [FieldOffset(0x00)] public RigidBodyType rigidBodyType;
        [FieldOffset(0x01)] public RigidBodyMaterial rigidBodyMaterial;
        [FieldOffset(0x04)] public PhysicsParam physicsParam;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct MotionData
    {
        [FieldOffset(0x00)] public UnmanagedString motionName;
        [FieldOffset(0x10)] public bool syncFrame;
        [FieldOffset(0x11)] public bool stopEndFrame;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct MirageAnimData
    {
        [FieldOffset(0x00)] public UnmanagedString texSrtAnimName__arr0;
        [FieldOffset(0x10)] public UnmanagedString texSrtAnimName__arr1;
        [FieldOffset(0x20)] public UnmanagedString texSrtAnimName__arr2;
        [FieldOffset(0x30)] public UnmanagedString texPatAnimName__arr0;
        [FieldOffset(0x40)] public UnmanagedString texPatAnimName__arr1;
        [FieldOffset(0x50)] public UnmanagedString texPatAnimName__arr2;
        [FieldOffset(0x60)] public UnmanagedString matAnimName__arr0;
        [FieldOffset(0x70)] public UnmanagedString matAnimName__arr1;
        [FieldOffset(0x80)] public UnmanagedString matAnimName__arr2;
    }

    public enum MotionType : byte
    {
        MOTION_SWING = 0,
        MOTION_ROTATE = 1,
        MOTION_LINEAR_SWING = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct ProgramMotionData
    {
        [FieldOffset(0x00)] public MotionType motionType;
        [FieldOffset(0x10)] public Vector3 axis;
        [FieldOffset(0x20)] public float power;
        [FieldOffset(0x24)] public float speedScale;
        [FieldOffset(0x28)] public float time;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct EffectData
    {
        [FieldOffset(0x00)] public UnmanagedString effectName;
        [FieldOffset(0x10)] public bool linkMotionStop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct SoundData
    {
        [FieldOffset(0x00)] public UnmanagedString cueName;
    }

    public enum KillType : sbyte
    {
        KILL_TYPE_NOT_KILL = 0,
        KILL_TYPE_KILL = 1,
        KILL_TYPE_BREAK = 2,
        KILL_TYPE_MOTION = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct DebrisData
    {
        [FieldOffset(0x00)] public float gravity;
        [FieldOffset(0x04)] public float lifeTime;
        [FieldOffset(0x08)] public float mass;
        [FieldOffset(0x0C)] public float friction;
        [FieldOffset(0x10)] public float explosionScale;
        [FieldOffset(0x14)] public float impulseScale;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct KillData
    {
        [FieldOffset(0x00)] public KillType killType;
        [FieldOffset(0x04)] public float killTime;
        [FieldOffset(0x08)] public UnmanagedString breakMotionName;
        [FieldOffset(0x18)] public DebrisData debrisData;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x140)]
    public struct ReactionData
    {
        [FieldOffset(0x00)] public MotionData motionData;
        [FieldOffset(0x18)] public MirageAnimData mirageAnimData;
        [FieldOffset(0xB0)] public ProgramMotionData programMotionData;
        [FieldOffset(0xE0)] public EffectData effectData;
        [FieldOffset(0xF8)] public SoundData soundData;
        [FieldOffset(0x108)] public KillData killData;
    }

    public enum TimeStopEffect : sbyte
    {
        EFFECT_HIGHLIGHT = 0,
        EFFECT_GRAY_OUT = 1,
        EFFECT_ORIGIN = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x820)]
    public struct GismoConfigDesignData
    {
        [FieldOffset(0x00)] public float rangeIn;
        [FieldOffset(0x04)] public float rangeDistance;
        [FieldOffset(0x08)] public GismoBasicParam basicParam;
        [FieldOffset(0x30)] public GismoCollision collision;
        [FieldOffset(0x70)] public GismoRegidBody rigidBody;
        [FieldOffset(0x90)] public ReactionData reactionIdle;
        [FieldOffset(0x1D0)] public ReactionData reactionEnter;
        [FieldOffset(0x310)] public ReactionData reactionLeave;
        [FieldOffset(0x450)] public ReactionData reactionStay;
        [FieldOffset(0x590)] public ReactionData reactionStayMove;
        [FieldOffset(0x6D0)] public ReactionData reactionDamage;
        [FieldOffset(0x810)] public bool ignoreMeteorShowerAndRespawnOnReenterRange;
        [FieldOffset(0x811)] public TimeStopEffect timeStopEffect;
        [FieldOffset(0x812)] public bool isResetEffectOnMotionLoop;
    }

}