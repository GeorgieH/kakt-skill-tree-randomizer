namespace Kakt.Modding.Core.Skills.Taunt.Upgrades;

public class Demoralize : SkillUpgrade<Taunt>
{
    public Demoralize()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__taunt_demoralize";
}
