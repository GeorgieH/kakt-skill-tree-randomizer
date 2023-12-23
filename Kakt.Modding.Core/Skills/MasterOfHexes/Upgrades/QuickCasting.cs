namespace Kakt.Modding.Core.Skills.MasterOfHexes.Upgrades;

public class QuickCasting : SkillUpgrade<MasterOfHexes>
{
    public QuickCasting()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__masterOfcurses_quickCasting";
}
