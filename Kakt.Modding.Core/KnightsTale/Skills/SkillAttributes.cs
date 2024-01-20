namespace Kakt.Modding.Core.KnightsTale.Skills;

[Flags]
public enum SkillAttributes
{
    None = 0,
    Area = 1,
    Fire = 2,
    Hex = 4,
    Ice = 8,
    Lightning = 16,
    Melee = 32,
    Movement = 64,
    Ranged = 128,
    Spell = 256,
    Summon = 512,
    Support = 1024,
    Trap = 2048
}
