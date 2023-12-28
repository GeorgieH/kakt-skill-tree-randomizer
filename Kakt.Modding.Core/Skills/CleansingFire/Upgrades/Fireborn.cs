namespace Kakt.Modding.Core.Skills.CleansingFire.Upgrades;

public class Fireborn : SkillUpgrade<CleansingFire>
{
    public Fireborn()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__cleansingFire_fireborn";
}
