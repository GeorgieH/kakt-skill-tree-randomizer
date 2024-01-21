namespace Kakt.Modding.Core.KnightsTale.Skills.LightningStrike;

public class LightningStrike : ActiveSkill
{
    public LightningStrike()
    {
        Name = nameof(LightningStrike);
        CodeName = "FaerieKnight__LightningStrike";
        ConfigurationName = Name;
        Attributes = SkillAttributes.Melee | SkillAttributes.Lightning;
        Effects = Effects.Shock;
    }
}
