namespace Kakt.Modding.Core.Skills.CursedGround.Upgrades;

[CausesEffects(Effects.Slow)]
public class Quagmire : SkillUpgrade<CursedGround>
{
    public Quagmire()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "SirDagonet__cursedGround_quagmire";
}
