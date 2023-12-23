namespace Kakt.Modding.Core.Skills.MasterOfHexes.Upgrades;

public class PowerOfHexes : SkillUpgrade<MasterOfHexes>
{
    public PowerOfHexes()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__masterOfcurses_powerofCurses";
}
