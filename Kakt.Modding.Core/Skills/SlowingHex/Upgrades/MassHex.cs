namespace Kakt.Modding.Core.Skills.SlowingHex.Upgrades;

public class MassHex : SkillUpgrade<SlowingHex>
{
    public MassHex()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__curse_massCurse";
}
