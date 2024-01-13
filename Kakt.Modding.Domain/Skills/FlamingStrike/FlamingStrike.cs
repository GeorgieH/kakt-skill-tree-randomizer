namespace Kakt.Modding.Domain.Skills.FlamingStrike;

public class FlamingStrike : ActiveSkill
{
    public FlamingStrike()
    {
        Name = nameof(FlamingStrike);
        CodeName = "SirPercivale__flamingStrike";
        ConfigurationName = Name;
        Attributes = SkillAttributes.Melee | SkillAttributes.Fire;
        Effects = Effects.Burn;
    }
}
