namespace Kakt.Modding.Core.Skills;

[Flags]
public enum SkillAttributes
{
    None = 0,
    Area = 1,
    Fire = 2,
    Hex = 4,
    Lightning = 8,
    Melee = 16,
    Movement = 32,
    Ranged = 64,
    Spell = 128,
    Summon = 256,
    Support = 512,
    Trap = 1024
}
