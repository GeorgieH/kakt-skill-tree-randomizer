namespace Kakt.Modding.Domain.Skills.FlamingStrike;

public class FlamingStrike : Skill
{
    public FlamingStrike()
    {
        Name = nameof(FlamingStrike);
        CodeName = "SirPercivale__flamingStrike";
        ConfigurationName = Name;
        Type = SkillType.Active;
        Attributes = SkillAttributes.Melee | SkillAttributes.Fire;
        Effects = Effects.Burn;
    }
}
