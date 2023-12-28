namespace Kakt.Modding.Core.Skills.CounterAttack.Upgrades;

public class RegainFooting : SkillUpgrade<CounterAttack>
{
    public RegainFooting()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__counterAttack_regainFooting";
}
