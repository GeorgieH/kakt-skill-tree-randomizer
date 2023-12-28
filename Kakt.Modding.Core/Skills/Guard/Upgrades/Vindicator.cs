namespace Kakt.Modding.Core.Skills.Guard.Upgrades;

public class Vindicator : SkillUpgrade<Guard>
{
    public Vindicator()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_defender__guard_vindicator";
}
