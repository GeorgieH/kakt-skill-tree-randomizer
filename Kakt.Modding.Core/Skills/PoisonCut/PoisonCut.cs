namespace Kakt.Modding.Core.Skills.PoisonCut;

public class PoisonCut : Skill
{
    public override string Name => "SirTristan__poisonCut";

    public override bool Starter
    {
        get => true;
        set { return; }
    }

    public override SkillTier Tier
    {
        get => SkillTier.One;
        set { return; }
    }

    public override SkillType Type => SkillType.Active;
}
