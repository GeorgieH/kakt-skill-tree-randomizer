namespace Kakt.Modding.Core.Skills.Illusion.Upgrades;

public class Mirage : SkillUpgrade<Illusion>
{
    public Mirage()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_arcanist__illusion_mirage";
}
