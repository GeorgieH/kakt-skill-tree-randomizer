namespace Kakt.Modding.Core.Skills.FlamingStrike.Upgrades;

public class CharredFlesh : SkillUpgrade<FlamingStrike>
{
    public CharredFlesh()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirPercivale__flamingStrike_charredFlesh";
}
