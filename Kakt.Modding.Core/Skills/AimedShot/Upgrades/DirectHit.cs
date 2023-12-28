namespace Kakt.Modding.Core.Skills.AimedShot.Upgrades;

public class DirectHit : SkillUpgrade<AimedShot>
{
    public DirectHit()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_marksman__aimedShot_directHit";
}
