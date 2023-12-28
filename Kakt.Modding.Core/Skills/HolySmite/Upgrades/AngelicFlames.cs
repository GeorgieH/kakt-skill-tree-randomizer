namespace Kakt.Modding.Core.Skills.HolySmite.Upgrades;

[CausesEffects(Effects.Burn)]
public class AngelicFlames : SkillUpgrade<HolySmite>
{
    public AngelicFlames()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirGalahad__holySmite_angelicFlames";
}
