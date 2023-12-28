namespace Kakt.Modding.Core.Skills.IceLance.Upgrades;

[CausesEffects(Effects.Freeze)]
public class NumbingFreeze : SkillUpgrade<IceLance>
{
    public NumbingFreeze()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__iceLance_numbingFreeze";
}
