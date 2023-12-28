namespace Kakt.Modding.Core.Skills.Shoot.Upgrades;

public class Elusive : SkillUpgrade<Shoot>
{
    public Elusive()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__shoot_elusive";
}
