namespace Kakt.Modding.Domain.Skills.Shoot;

public class Shoot : ActiveSkill
{
    public Shoot()
    {
        Name = nameof(Shoot);
        CodeName = "Hero_marksman__shoot";
        ConfigurationName = Name;
        Attributes = SkillAttributes.Ranged;
    }
}
