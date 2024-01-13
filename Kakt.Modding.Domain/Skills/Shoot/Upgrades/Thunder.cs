namespace Kakt.Modding.Domain.Skills.Shoot.Upgrades;


public class Thunder : SkillUpgrade
{
    public Thunder()
    {
        Name = nameof(Thunder);
        CodeName = "Hero_marksman__shoot_thunder";
        PrerequisiteEffects = Effects.Shock;
    }
}
