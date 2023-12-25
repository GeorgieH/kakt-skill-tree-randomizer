namespace Kakt.Modding.Core.Skills.Rampage.Upgrades;

public class Persistence : SkillUpgrade<Rampage>
{
    public Persistence()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__rampage_persistence";
}
