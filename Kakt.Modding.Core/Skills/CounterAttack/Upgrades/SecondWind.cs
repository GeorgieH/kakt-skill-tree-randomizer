namespace Kakt.Modding.Core.Skills.CounterAttack.Upgrades;

public class SecondWind : SkillUpgrade<CounterAttack>
{
    public SecondWind()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__counterAttack_secondWind";
}
