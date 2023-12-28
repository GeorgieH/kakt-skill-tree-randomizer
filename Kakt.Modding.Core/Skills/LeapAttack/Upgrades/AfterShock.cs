namespace Kakt.Modding.Core.Skills.LeapAttack.Upgrades;

public class AfterShock : SkillUpgrade<LeapAttack>
{
    public AfterShock()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "BlackKnight__leapAttack_aftershock";
}
