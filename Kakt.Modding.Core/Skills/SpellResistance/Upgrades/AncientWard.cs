namespace Kakt.Modding.Core.Skills.SpellResistance.Upgrades;

public class AncientWard : SkillUpgrade<SpellResistance>
{
    public AncientWard()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__spellResistance_ancientWard";
}
