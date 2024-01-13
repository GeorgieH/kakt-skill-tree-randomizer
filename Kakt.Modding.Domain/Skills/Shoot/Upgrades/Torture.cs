namespace Kakt.Modding.Domain.Skills.Shoot.Upgrades;

public class Torture : SkillUpgrade
{
    public Torture()
    {
        Name = nameof(Torture);
        CodeName = "Hero_marksman__shoot_torture";
        PrerequisiteEffects = Effects.Burn | Effects.Poison;
    }
}
