namespace Kakt.Modding.Core.Skills.DamageFocus.Upgrades;

public class FocusedWatch : DamageFocusUpgrade
{
    public FocusedWatch()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_champion__damageFocus_focusedWatch";
}
