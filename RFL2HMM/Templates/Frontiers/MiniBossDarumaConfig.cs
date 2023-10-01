using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossDarumaConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossCommonConfig
    {
        [FieldOffset(0x00)] public float scoutDistance;
        [FieldOffset(0x04)] public float scoutDistanceOutside;
        [FieldOffset(0x08)] public float zoomDistance;
        [FieldOffset(0x10)] public Vector3 zoomOffset;
        [FieldOffset(0x20)] public Vector3 zoomAngle;
        [FieldOffset(0x30)] public float zoomFov;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct MiniBossDarumaShotParam
    {
        [FieldOffset(0x00)] public int count;
        [FieldOffset(0x04)] public float intervalTime;
        [FieldOffset(0x08)] public float pitchMin;
        [FieldOffset(0x0C)] public float pitchMax;
        [FieldOffset(0x10)] public float pitchOffsetMin;
        [FieldOffset(0x14)] public float pitchOffsetMax;
        [FieldOffset(0x18)] public float yawOffsetRange;
        [FieldOffset(0x1C)] public bool sweepFire;
        [FieldOffset(0x1D)] public bool predict;
        [FieldOffset(0x20)] public float radius;
        [FieldOffset(0x24)] public float speed;
        [FieldOffset(0x28)] public float lifeTime;
        [FieldOffset(0x2C)] public float waitTime;
    }

    public enum ScatterType : sbyte
    {
        RANDOM = 0,
        HOMING = 1,
        SPIRAL = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct MiniBossDarumaSpecialShotParamBase
    {
        [FieldOffset(0x00)] public int count;
        [FieldOffset(0x04)] public float intervalTime;
        [FieldOffset(0x08)] public float shootPitchMin;
        [FieldOffset(0x0C)] public float shootPitchMax;
        [FieldOffset(0x10)] public float initialSpeedMin;
        [FieldOffset(0x14)] public float initialSpeedMax;
        [FieldOffset(0x18)] public float maxAngle;
        [FieldOffset(0x1C)] public float moveRadius;
        [FieldOffset(0x20)] public float maxMoveSpeed;
        [FieldOffset(0x24)] public float accel;
        [FieldOffset(0x28)] public float waitTime;
        [FieldOffset(0x2C)] public float featherLifeTime;
        [FieldOffset(0x30)] public ScatterType m_scatterTypeTable__arr0;
        [FieldOffset(0x31)] public ScatterType m_scatterTypeTable__arr1;
        [FieldOffset(0x32)] public ScatterType m_scatterTypeTable__arr2;
        [FieldOffset(0x33)] public ScatterType m_scatterTypeTable__arr3;
        [FieldOffset(0x34)] public ScatterType m_scatterTypeTable__arr4;
        [FieldOffset(0x35)] public ScatterType m_scatterTypeTable__arr5;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x44)]
    public struct MiniBossDarumaBombParam
    {
        [FieldOffset(0)]  public MiniBossDarumaSpecialShotParamBase miniBossDarumaSpecialShotParamBase;
        [FieldOffset(0x38)] public float explosionRadius;
        [FieldOffset(0x3C)] public float explosionEffectScale;
        [FieldOffset(0x40)] public float explosionTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x3C)]
    public struct MiniBossDarumaFlamePillarParam
    {
        [FieldOffset(0)]  public MiniBossDarumaSpecialShotParamBase miniBossDarumaSpecialShotParamBase;
        [FieldOffset(0x38)] public float burnLifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct MiniBossDarumaWaveBombParam
    {
        [FieldOffset(0)]  public MiniBossDarumaSpecialShotParamBase miniBossDarumaSpecialShotParamBase;
        [FieldOffset(0x38)] public float burnLifeTime;
        [FieldOffset(0x3C)] public float cycleTime;
        [FieldOffset(0x40)] public float cycleDistance;
        [FieldOffset(0x44)] public float homingLimitAngle;
        [FieldOffset(0x48)] public float maxTurnAngle;
        [FieldOffset(0x4C)] public uint cycleCount;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x78)]
    public struct MiniBossDarumaStompingParam
    {
        [FieldOffset(0x00)] public float range;
        [FieldOffset(0x04)] public float riseDistance;
        [FieldOffset(0x08)] public float riseTime;
        [FieldOffset(0x0C)] public float chaseSpeed;
        [FieldOffset(0x10)] public float chaseTime;
        [FieldOffset(0x14)] public float speed;
        [FieldOffset(0x18)] public float rotationSpeed;
        [FieldOffset(0x1C)] public float timingGap;
        [FieldOffset(0x20)] public float spinTime;
        [FieldOffset(0x24)] public float ringRiseTime;
        [FieldOffset(0x28)] public float waitTime;
        [FieldOffset(0x2C)] public float staggerTime;
        [FieldOffset(0x30)] public float staggerDistance;
        [FieldOffset(0x34)] public float groundImpactRadius;
        [FieldOffset(0x38)] public float waveRadius;
        [FieldOffset(0x3C)] public float waveAppearRadius;
        [FieldOffset(0x40)] public float waveKeepRadius;
        [FieldOffset(0x44)] public float waveDisappearRadius;
        [FieldOffset(0x48)] public float waveHeightMin;
        [FieldOffset(0x4C)] public float waveHeightMax;
        [FieldOffset(0x50)] public float waveLifeTime;
        [FieldOffset(0x54)] public float waveVelocityX;
        [FieldOffset(0x58)] public float waveVelocityY;
        [FieldOffset(0x5C)] public float laserRadius;
        [FieldOffset(0x60)] public float laserLength;
        [FieldOffset(0x64)] public float laserTime;
        [FieldOffset(0x68)] public float laserRotationInitialSpeed;
        [FieldOffset(0x6C)] public float laserRotationAccel;
        [FieldOffset(0x70)] public float laserRotationMaxSpeed;
        [FieldOffset(0x74)] public float laserAccelDelayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x50)]
    public struct MiniBossDarumaCyloopReactionParam
    {
        [FieldOffset(0x00)] public Vector3 targetOffSet;
        [FieldOffset(0x10)] public float azimuth;
        [FieldOffset(0x14)] public float elevation;
        [FieldOffset(0x18)] public float distance;
        [FieldOffset(0x1C)] public float zRoll;
        [FieldOffset(0x20)] public float fovy;
        [FieldOffset(0x30)] public Vector3 cameraMoveDir;
        [FieldOffset(0x40)] public float cameraMoveSpeed;
        [FieldOffset(0x44)] public float interpolateTime;
        [FieldOffset(0x48)] public float bodyBreakWaitTime;
        [FieldOffset(0x4C)] public float changeStateWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x40)]
    public struct MiniBossDarumaDebrisBodySmallParam
    {
        [FieldOffset(0x00)] public float lifeTime;
        [FieldOffset(0x04)] public float forceScale;
        [FieldOffset(0x08)] public float forceMin;
        [FieldOffset(0x0C)] public float forceMax;
        [FieldOffset(0x10)] public float forceCyloopExplode;
        [FieldOffset(0x14)] public float gravity;
        [FieldOffset(0x18)] public float weight;
        [FieldOffset(0x1C)] public float friction;
        [FieldOffset(0x20)] public sbyte maxPieceNum;
        [FieldOffset(0x30)] public Vector3 centerOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x90)]
    public struct MiniBossDarumaDebrisParam
    {
        [FieldOffset(0x00)] public float damageVelocityScale;
        [FieldOffset(0x04)] public float minSpeed;
        [FieldOffset(0x08)] public float maxSpeed;
        [FieldOffset(0x10)] public MiniBossDarumaDebrisBodySmallParam body;
        [FieldOffset(0x50)] public MiniBossDarumaDebrisBodySmallParam cyloop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x14)]
    public struct MiniBossDarumaCameraShakeParam
    {
        [FieldOffset(0x00)] public float time;
        [FieldOffset(0x04)] public float magnitude;
        [FieldOffset(0x08)] public int freq;
        [FieldOffset(0x0C)] public float attnRatio;
        [FieldOffset(0x10)] public float shakeRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xB60)]
    public struct MiniBossDarumaCommonParam
    {
        [FieldOffset(0x00)] public MiniBossCommonConfig commonConfig;
        [FieldOffset(0x40)] public float headHeight;
        [FieldOffset(0x44)] public int bodyMaxHealthPoint;
        [FieldOffset(0x48)] public float bodyRadius;
        [FieldOffset(0x4C)] public float bodyHeight;
        [FieldOffset(0x50)] public float baseHeight;
        [FieldOffset(0x54)] public float partSpace;
        [FieldOffset(0x58)] public float ringRadius;
        [FieldOffset(0x5C)] public float ringHeight;
        [FieldOffset(0x60)] public float ringRotationSpeed;
        [FieldOffset(0x64)] public float gravity;
        [FieldOffset(0x68)] public float stunTime;
        [FieldOffset(0x6C)] public float maxSpeed;
        [FieldOffset(0x70)] public float stompingTransitRange;
        [FieldOffset(0x74)] public int questKodamaMaxNum__arr0;
        [FieldOffset(0x78)] public int questKodamaMaxNum__arr1;
        [FieldOffset(0x7C)] public int questKodamaMaxNum__arr2;
        [FieldOffset(0x80)] public MiniBossDarumaShotParam shot;
        [FieldOffset(0xB0)] public MiniBossDarumaShotParam shot3way;
        [FieldOffset(0xE0)] public MiniBossDarumaShotParam shot5way;
        [FieldOffset(0x110)] public MiniBossDarumaBombParam bomb;
        [FieldOffset(0x154)] public MiniBossDarumaFlamePillarParam flamePillar;
        [FieldOffset(0x190)] public MiniBossDarumaWaveBombParam waveBomb;
        [FieldOffset(0x1E0)] public MiniBossDarumaStompingParam stomping;
        [FieldOffset(0x258)] public MiniBossDarumaStompingParam stompingThorn;
        [FieldOffset(0x2D0)] public MiniBossDarumaStompingParam stompingQuest__arr0;
        [FieldOffset(0x348)] public MiniBossDarumaStompingParam stompingQuest__arr1;
        [FieldOffset(0x3C0)] public MiniBossDarumaStompingParam stompingQuest__arr2;
        [FieldOffset(0x438)] public MiniBossDarumaStompingParam stompingQuestHigh__arr0;
        [FieldOffset(0x4B0)] public MiniBossDarumaStompingParam stompingQuestHigh__arr1;
        [FieldOffset(0x528)] public MiniBossDarumaStompingParam stompingQuestHigh__arr2;
        [FieldOffset(0x5A0)] public MiniBossDarumaStompingParam stompingQuest2__arr0;
        [FieldOffset(0x618)] public MiniBossDarumaStompingParam stompingQuest2__arr1;
        [FieldOffset(0x690)] public MiniBossDarumaStompingParam stompingQuest2__arr2;
        [FieldOffset(0x708)] public MiniBossDarumaStompingParam stompingQuest2High__arr0;
        [FieldOffset(0x780)] public MiniBossDarumaStompingParam stompingQuest2High__arr1;
        [FieldOffset(0x7F8)] public MiniBossDarumaStompingParam stompingQuest2High__arr2;
        [FieldOffset(0x870)] public MiniBossDarumaCyloopReactionParam cyloopReaction;
        [FieldOffset(0x8C0)] public MiniBossDarumaShotParam shotBerserk;
        [FieldOffset(0x8F0)] public MiniBossDarumaShotParam shotBerserk3way;
        [FieldOffset(0x920)] public MiniBossDarumaShotParam shotBerserk5way;
        [FieldOffset(0x950)] public MiniBossDarumaStompingParam hop;
        [FieldOffset(0x9C8)] public MiniBossDarumaStompingParam stompingBerserk;
        [FieldOffset(0xA40)] public MiniBossDarumaFlamePillarParam flamePillarBerserk;
        [FieldOffset(0xA80)] public MiniBossDarumaDebrisParam debris;
        [FieldOffset(0xB10)] public MiniBossDarumaCameraShakeParam cameraShakeStomping;
        [FieldOffset(0xB24)] public MiniBossDarumaCameraShakeParam cameraShakeStompingQuest;
        [FieldOffset(0xB38)] public MiniBossDarumaCameraShakeParam cameraShakeStompingQuest2;
        [FieldOffset(0xB4C)] public MiniBossDarumaCameraShakeParam cameraShakeDrop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x34)]
    public struct MiniBossLevelCommonConfig
    {
        [FieldOffset(0x00)] public int maxHealthPoint;
        [FieldOffset(0x04)] public float maxStunPoint__arr0;
        [FieldOffset(0x08)] public float maxStunPoint__arr1;
        [FieldOffset(0x0C)] public float maxStunPoint__arr2;
        [FieldOffset(0x10)] public float stunDecreaseStartTime;
        [FieldOffset(0x14)] public float stunDecreaseSpeed;
        [FieldOffset(0x18)] public float maxStaggerPoint__arr0;
        [FieldOffset(0x1C)] public float maxStaggerPoint__arr1;
        [FieldOffset(0x20)] public float maxStaggerPoint__arr2;
        [FieldOffset(0x24)] public float staggerDecreaseStartTime;
        [FieldOffset(0x28)] public float staggerDecreaseSpeed;
        [FieldOffset(0x2C)] public float attackRate;
        [FieldOffset(0x30)] public ushort expItemNum;
        [FieldOffset(0x32)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x38)]
    public struct MiniBossDarumaLevelParam
    {
        [FieldOffset(0x00)] public int level;
        [FieldOffset(0x04)] public MiniBossLevelCommonConfig commonConfig;
    }

    public enum StompingType : sbyte
    {
        WEEK = 0,
        WAVE = 1
    }

    public enum BulletType : sbyte
    {
        NORMAL = 0,
        THREE_WAY = 1,
        FIVE_WAY = 2
    }

    public enum SpecialBulletType : sbyte
    {
        BOMB = 0,
        PILLAR = 1,
        WAVE_BOMB = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    public struct MiniBossDarumaLevelBand
    {
        [FieldOffset(0x00)] public uint level;
        [FieldOffset(0x04)] public StompingType stompingType;
        [FieldOffset(0x05)] public sbyte laserCount;
        [FieldOffset(0x06)] public bool isBarrier;
        [FieldOffset(0x07)] public StompingType stompingTypeThorn;
        [FieldOffset(0x08)] public sbyte laserCountThorn;
        [FieldOffset(0x09)] public bool isBarrierThorn;
        [FieldOffset(0x0A)] public BulletType bulletType;
        [FieldOffset(0x0B)] public SpecialBulletType specialBulletType;
        [FieldOffset(0x0C)] public sbyte stompingMaxBreakBodyCount;
        [FieldOffset(0x0D)] public bool isThorn;
        [FieldOffset(0x10)] public Vector3 headRigidColliderExtents;
        [FieldOffset(0x20)] public Vector3 headRigidCollHeightOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 0xDE0)]
    public struct MiniBossDarumaConfig
    {
        [FieldOffset(0x00)] public MiniBossDarumaCommonParam commonParam;
        [FieldOffset(0xB60)] public MiniBossDarumaLevelParam levelParams__arr0;
        [FieldOffset(0xB98)] public MiniBossDarumaLevelParam levelParams__arr1;
        [FieldOffset(0xBD0)] public MiniBossDarumaLevelParam levelParams__arr2;
        [FieldOffset(0xC08)] public MiniBossDarumaLevelParam levelParams__arr3;
        [FieldOffset(0xC40)] public MiniBossDarumaLevelParam levelParams__arr4;
        [FieldOffset(0xC80)] public MiniBossDarumaLevelBand levelBands__arr0;
        [FieldOffset(0xCB0)] public MiniBossDarumaLevelBand levelBands__arr1;
        [FieldOffset(0xCE0)] public MiniBossDarumaLevelBand levelBands__arr2;
        [FieldOffset(0xD10)] public MiniBossDarumaLevelBand levelBands__arr3;
        [FieldOffset(0xD40)] public MiniBossDarumaLevelBand levelBands__arr4;
        [FieldOffset(0xD70)] public MiniBossDarumaLevelParam levelParamQuest;
        [FieldOffset(0xDB0)] public MiniBossDarumaLevelBand levelBandQuest;
    }

}