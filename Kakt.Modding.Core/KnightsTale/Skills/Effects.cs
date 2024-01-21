namespace Kakt.Modding.Core.KnightsTale.Skills;

[Flags]
public enum Effects
{
    None = 0,
    Bleed = 1,
    Blind = 2,
    Burn = 4,
    Chill = 8,
    Freeze = 16,
    Hidden = 32,
    Knockback = 64,
    Knockdown = 128,
    Poison = 256,
    Shock = 512,
    Silence = 1024,
    Slow = 2048,
    Stun = 4096,
    Vulnerability = 8192,
    Weakness = 16384
}
