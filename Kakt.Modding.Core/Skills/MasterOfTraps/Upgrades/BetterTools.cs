namespace Kakt.Modding.Core.Skills.MasterOfTraps.Upgrades;

public class BetterTools : SkillUpgrade<MasterOfTraps>
{
    public BetterTools()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__masterOftraps_betterTools";
}
