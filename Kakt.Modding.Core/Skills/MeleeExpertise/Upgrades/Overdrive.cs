namespace Kakt.Modding.Core.Skills.MeleeExpertise.Upgrades;

public class Overdrive : SkillUpgrade<MeleeExpertise>
{
    public Overdrive()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__meleeExpertise_overdrive";
}
