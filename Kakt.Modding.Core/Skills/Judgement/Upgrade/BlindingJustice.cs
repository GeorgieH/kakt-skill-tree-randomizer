namespace Kakt.Modding.Core.Skills.Judgement.Upgrade;

public class BlindingJustice : SkillUpgrade<Judgement>
{
    public BlindingJustice()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__judgement_blindingJustice";
}
