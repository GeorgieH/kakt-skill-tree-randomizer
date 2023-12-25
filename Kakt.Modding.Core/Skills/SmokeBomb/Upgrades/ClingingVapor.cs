namespace Kakt.Modding.Core.Skills.SmokeBomb.Upgrades;

public class ClingingVapor : SkillUpgrade<SmokeBomb>
{
    public ClingingVapor()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirTristan__smokeBomb_clingingVapor";
}
