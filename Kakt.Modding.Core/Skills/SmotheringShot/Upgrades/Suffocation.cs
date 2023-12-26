namespace Kakt.Modding.Core.Skills.SmotheringShot.Upgrades;

[CausesEffects(Effects.Weakness)]
public class Suffocation : SkillUpgrade<SmotheringShot>
{
    public Suffocation()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__smotheringShot_suffocation";
}
