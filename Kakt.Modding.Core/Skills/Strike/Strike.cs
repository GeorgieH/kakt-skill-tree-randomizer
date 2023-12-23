namespace Kakt.Modding.Core.Skills.Strike;

// Champions, Defenders, Sages and Vanguards always start with their basic Strike skill
public abstract class Strike : Skill
{
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
