namespace Kakt.Modding.Core.Skills.RupturingStrike.Upgrades;

public class Hemorrhage : RupturingStrikeUpgrade
{
    public Hemorrhage()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__rupturingStrike_hemorrhage";
}
