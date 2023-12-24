namespace Kakt.Modding.Core.Skills.Judgement.Upgrade;

[CausesEffect(Effect.Blind)]
public class BlindingJustice : SkillUpgrade<Judgement>
{
    public BlindingJustice()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_sage__judgement_blindingJustice";
}
