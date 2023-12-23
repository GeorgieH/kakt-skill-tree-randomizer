namespace Kakt.Modding.Core.Skills.FlamingStrike;

public class FlamingStrike : Skill
{
    public override string Name => "SirPercivale__flamingStrike";

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
