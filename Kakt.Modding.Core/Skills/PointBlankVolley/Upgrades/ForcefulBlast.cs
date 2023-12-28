namespace Kakt.Modding.Core.Skills.PointBlankVolley.Upgrades;

[CausesEffects(Effects.Knockback)]
public class ForcefulBlast : SkillUpgrade<PointBlankVolley>
{
    public ForcefulBlast()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__pointBlankVolley_forcefulBlast";
}
