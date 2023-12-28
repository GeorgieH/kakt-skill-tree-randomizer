namespace Kakt.Modding.Core.Skills.IceAura.Upgrades;

public class FrostSkin : SkillUpgrade<IceAura>
{
    public FrostSkin()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__iceAura_frostSkin";
}
