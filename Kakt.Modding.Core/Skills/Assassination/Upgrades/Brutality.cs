namespace Kakt.Modding.Core.Skills.Assassination.Upgrades;

public class Brutality : SkillUpgrade<Assassination>
{
    public Brutality()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__assassination_brutality";
}
