namespace Kakt.Modding.Core.Skills.Scout.Upgrades;

public class FirstDodge : SkillUpgrade<Scout>
{
    public FirstDodge()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__fleetFooted_firstDodge";
}
