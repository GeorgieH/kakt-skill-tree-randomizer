namespace Kakt.Modding.Core.Skills.Strike.Vanguard.Upgrades;

[RequiresEffects(Effects.Bleed)]
public class RelentlessStrikes : SkillUpgrade<VanguardStrike>
{
    public RelentlessStrikes()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__strike_relentlessStrikes";
}
