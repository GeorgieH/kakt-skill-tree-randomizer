namespace Kakt.Modding.Domain.Skills.LightningStrike;

public class LightningStrike : Skill
{
    public LightningStrike()
    {
        Name = nameof(LightningStrike);
        CodeName = "FaerieKnight__LightningStrike";
        ConfigurationName = Name;
        Type = SkillType.Active;
        Upgradable = true;
        Attributes = SkillAttributes.Melee | SkillAttributes.Lightning;
        Effects = Effects.Shock;
    }
}
