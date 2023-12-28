namespace Kakt.Modding.Core.Skills.RayOfLight.Upgrades;

public class Sunblaze : SkillUpgrade<RayOfLight>
{
    public Sunblaze()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__rayofLight_sunblaze";
}
