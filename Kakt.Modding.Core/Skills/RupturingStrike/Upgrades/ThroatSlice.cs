namespace Kakt.Modding.Core.Skills.RupturingStrike.Upgrades;

public class ThroatSlice : RupturingStrikeUpgrade
{
    public ThroatSlice()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__rupturingStrike_throatSlice";
}
