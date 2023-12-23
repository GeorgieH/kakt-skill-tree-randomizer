namespace Kakt.Modding.Core.Skills;

public class SkillPositionCalculatorInput
{
    public SkillPositionCalculatorInput(int skillNumber, Skill skill)
    {
        if (skill.Tier == SkillTier.One || skill.Tier == SkillTier.Three)
        {
            if (skillNumber < 1 || skillNumber > 7)
            {
                throw new ArgumentOutOfRangeException(nameof(skillNumber));
            }
        }

        if (skill.Tier == SkillTier.Two)
        {
            if (skillNumber < 1 || skillNumber > 6)
            {
                throw new ArgumentOutOfRangeException(nameof(skillNumber));
            }
        }

        SkillNumber = skillNumber;
        Skill = skill;
    }

    public int SkillNumber { get; }
    public Skill Skill { get; }
}
