namespace Kakt.Modding.Core.Skills.Backstab.Upgrades;

public class FocusedStrike : SkillUpgrade<Backstab>
{
    public FocusedStrike()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__backstab_focusedStrike";
}
