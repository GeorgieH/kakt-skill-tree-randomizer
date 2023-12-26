namespace Kakt.Modding.Core.Skills.Scout.Marksman.Upgrades;

public class FirstDodge : SkillUpgrade<MarksmanScout>
{
    public FirstDodge()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_marksman__fleetFooted_firstDodge";
}
