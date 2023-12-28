namespace Kakt.Modding.Core.Skills.FreezingAttack.Upgrades;

public class ChilledToTheBone : SkillUpgrade<FreezingAttack>
{
    public ChilledToTheBone()
    {
        LevelLimit = HeroLevelLimits.Ten;
    }

    public override string Name => "Hero_sage__freezingAttack_chilledTothebone";
}
