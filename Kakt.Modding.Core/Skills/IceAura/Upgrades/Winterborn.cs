namespace Kakt.Modding.Core.Skills.IceAura.Upgrades;

public class Winterborn : SkillUpgrade<IceAura>
{
    public Winterborn()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__iceAura_winterborn";
}
