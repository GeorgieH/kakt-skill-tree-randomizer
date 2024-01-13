namespace Kakt.Modding.Domain.Skills;

public class ActiveSkill : Skill
{
    public ActiveSkill()
    {
        Type = SkillType.Active;
        Upgradable = true;
    }
}
