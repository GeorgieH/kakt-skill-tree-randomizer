namespace Kakt.Modding.Core.Skills.PowerAttack.Upgrades;

public class Initiator : SkillUpgrade<PowerAttack>
{
    public Initiator()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_champion__powerAttack_initiator";
}
