namespace Kakt.Modding.Core.Skills.MindFog.Upgrades;

public class Gloomchild : SkillUpgrade<MindFog>
{
    public Gloomchild()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_arcanist__mindFog_gloomchild";
}
