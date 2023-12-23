namespace Kakt.Modding.Core.Skills.FlamingStrike.Upgrades;

public class UndeadBane : FlamingStrikeUpgrade
{
    public UndeadBane()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirPercivale__flamingStrike_undeadbane";
}
