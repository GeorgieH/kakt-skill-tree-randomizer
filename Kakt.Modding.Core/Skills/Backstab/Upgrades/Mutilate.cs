namespace Kakt.Modding.Core.Skills.Backstab.Upgrades;

public class Mutilate : BackstabUpgrade
{
    public Mutilate()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_vanguard__backstab_mutilate";
}
