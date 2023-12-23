namespace Kakt.Modding.Core.Skills.Backstab.Upgrades;

public class Mutilate : SkillUpgrade<Backstab>
{
    public Mutilate()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__backstab_mutilate";
}
