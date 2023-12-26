namespace Kakt.Modding.Core.Skills.BatteringRam.Upgrades;

[CausesEffects(Effects.Weakness)]
public class CripplingBlow : SkillUpgrade<BatteringRam>
{
    public CripplingBlow()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_defender__batteringRam_cripplingBlow";
}
