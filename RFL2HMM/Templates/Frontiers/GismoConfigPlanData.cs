using System.Numerics;
using System.Runtime.InteropServices;

public class GismoConfigPlanDataClass
{
    public enum ContactDamageType : sbyte
    {
        CONTACT_DAMAGE_NONE = 0,
        CONTACT_DAMAGE_LOW_SPEED = 1,
        CONTACT_DAMAGE_MIDDLE_SPEED = 2,
        CONTACT_DAMAGE_HIGH_SPEED = 3
    }

    [StructLayout(LayoutKind.Explicit, Size = 0x04)]
    public struct GismoConfigPlanData
    {
        [FieldOffset(0x00)] public ContactDamageType contactDamageType;
        [FieldOffset(0x01)] public bool noneDamageSpin;
        [FieldOffset(0x02)] public bool rideOnDamage;
        [FieldOffset(0x03)] public bool aerialBounce;
    }

}