namespace Kakt.Modding.Core.Skills.Encouragement.Upgrades;

public class TheLordsWrath : SkillUpgrade<Encouragement>
{
    public TheLordsWrath()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirPercivale__encouragement_theLordswrath";
}
