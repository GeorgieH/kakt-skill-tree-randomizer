namespace Kakt.Modding.Core.Skills.DamageFocus.Upgrades;

public class FocusedWatch : SkillUpgrade<DamageFocus>
{
    public FocusedWatch()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__damageFocus_focusedWatch";
}
