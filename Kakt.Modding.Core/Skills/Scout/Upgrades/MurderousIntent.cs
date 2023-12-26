namespace Kakt.Modding.Core.Skills.Scout.Upgrades;

[RequiresSkillAttributes(SkillAttributes.Movement)]
public class MurderousIntent : SkillUpgrade<Scout>
{
    public MurderousIntent()
    {
        LevelLimit = HeroLevelLimits.Five;
    }

    public override string Name => "Hero_vanguard__scout_murderousIntent";
}
