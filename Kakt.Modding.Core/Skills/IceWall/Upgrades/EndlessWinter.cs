namespace Kakt.Modding.Core.Skills.IceWall.Upgrades;

[CausesEffects(Effects.Freeze)]
public class EndlessWinter : SkillUpgrade<IceWall>
{
    public EndlessWinter()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__iceWall_endlessWinter";
}
