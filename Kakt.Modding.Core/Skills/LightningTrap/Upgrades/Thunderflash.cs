namespace Kakt.Modding.Core.Skills.LightningTrap.Upgrades;

public class Thunderflash : SkillUpgrade<LightningTrap>
{
    public Thunderflash()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__lightningTrap_thunderflash";
}
