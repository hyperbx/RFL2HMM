using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossChargerAttackParamClass
{
    public enum AttackType : int
    {
        AttackTypeInvalid = 0,
        AttackSimpleRotateBullet = 1,
        AttackFollowLaser = 2,
        AttackVortexLaser = 3,
        AttackCrossLaser = 4,
        AttackCrossBullet = 5,
        AttackMassLaser = 6,
        AttackVerticalRoundBullet = 7,
        AttackPyramidRoundBullet = 8,
        AttackPlaneUpDownBullet = 9,
        AttackTriangleBatteryBullet = 10,
        AttackPlayerFallBullet = 11,
        AttackGatlingRevolverBullet = 12,
        AttackWinderBullet = 13,
        AttackShotgunBullet = 14,
        AttackAirDropBullet = 15,
        AttackChaseShotObject = 16,
        AttackDiffuseLaser = 17,
        AttackChaseShot = 18,
        AttackTypeNum = 19
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x10)]
    public struct MiniBossChargerAttackParam
    {
        [FieldOffset(0x00)] public AttackType type;
        [FieldOffset(0x04)] public int index;
        [FieldOffset(0x08)] public float rate;
        [FieldOffset(0x0C)] public float restTime;
    }

}