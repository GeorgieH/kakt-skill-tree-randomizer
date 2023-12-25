namespace Kakt.Modding.Core.Skills.HolySmite.Upgrades;

[CausesEffect(Effect.Stun)]
public class Castigation : SkillUpgrade<HolySmite>
{
    public Castigation()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirGalahad__holySmite_castigation";
}
