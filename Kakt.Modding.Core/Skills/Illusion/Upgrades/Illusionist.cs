namespace Kakt.Modding.Core.Skills.Illusion.Upgrades;

public class Illusionist : SkillUpgrade<Illusion>
{
    public Illusionist()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__illusion_illusionist";
}
