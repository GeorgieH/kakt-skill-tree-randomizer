namespace Kakt.Modding.Core.Skills.SmotheringShot.Upgrades;

[CausesEffects(Effects.Slow)]
public class Slowness : SkillUpgrade<SmotheringShot>
{
    public Slowness()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__smotheringShot_slowness";
}
