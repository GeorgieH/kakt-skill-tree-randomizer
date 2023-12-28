namespace Kakt.Modding.Core.Skills.Rampage.Upgrades;

public class Frenzy : SkillUpgrade<Rampage>
{
    public Frenzy()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__rampage_frenzy";
}
