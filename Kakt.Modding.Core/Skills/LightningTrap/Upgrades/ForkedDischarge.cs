namespace Kakt.Modding.Core.Skills.LightningTrap.Upgrades;

public class ForkedDischarge : SkillUpgrade<LightningTrap>
{
    public ForkedDischarge()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__lightningTrap_forkedDischarge";
}
