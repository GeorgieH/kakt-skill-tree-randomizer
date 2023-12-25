namespace Kakt.Modding.Core.Skills.LoneWolf.Upgrades;

public class Unyielding : SkillUpgrade<LoneWolf>
{
    public Unyielding()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirLancelot__loneWolf_unyielding";
}
