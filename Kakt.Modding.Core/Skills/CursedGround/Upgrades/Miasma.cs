namespace Kakt.Modding.Core.Skills.CursedGround.Upgrades;

[CausesEffects(Effects.Weakness)]
public class Miasma : SkillUpgrade<CursedGround>
{
    public Miasma()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "SirDagonet__cursedGround_miasma";
}
