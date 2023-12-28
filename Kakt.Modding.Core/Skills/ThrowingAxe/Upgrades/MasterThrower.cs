namespace Kakt.Modding.Core.Skills.ThrowingAxe.Upgrades;

public class MasterThrower : SkillUpgrade<ThrowingAxe>
{
    public MasterThrower()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "RedKnight__throwingAxe_masterThrower";
}
