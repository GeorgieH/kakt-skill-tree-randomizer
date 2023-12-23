namespace Kakt.Modding.Core.Skills.BearTrap.Upgrades;

public class HandyTrap : SkillUpgrade<BearTrap>
{
    public HandyTrap()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__bearTrap_handyTrap";
}
