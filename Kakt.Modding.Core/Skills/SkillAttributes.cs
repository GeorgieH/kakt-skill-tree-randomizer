namespace Kakt.Modding.Core.Skills;

[Flags]
public enum SkillAttributes
{
    None = 0,
    Area = 1,
    Hex = 2,
    Lightning = 4,
    Melee = 8,
    Movement = 16,
    Ranged = 32,
    Spell = 64,
    Summon = 128,
    Support = 256,
    Trap = 512
}
