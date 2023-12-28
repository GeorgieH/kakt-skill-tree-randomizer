namespace Kakt.Modding.Core.Skills;

public class SkillPositionCalculatorInput
{
    public SkillPositionCalculatorInput(int skillNumber, Skill skill)
    {
        SkillNumber = skillNumber;
        Skill = skill;
    }

    public int SkillNumber { get; }
    public Skill Skill { get; }
}
