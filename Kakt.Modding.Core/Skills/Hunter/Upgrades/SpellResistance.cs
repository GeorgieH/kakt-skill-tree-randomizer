namespace Kakt.Modding.Core.Skills.Hunter.Upgrades;

public class SpellResistance : SkillUpgrade<Hunter>
{
    public SpellResistance()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__spellResistance";
}
