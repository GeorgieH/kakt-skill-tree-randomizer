namespace Kakt.Modding.Core.Skills.SmokeBomb.Upgrades;

public class AlchemistsPurse : SkillUpgrade<SmokeBomb>
{
    public AlchemistsPurse()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirTristan__smokeBomb_alchemistsPurse";
}
