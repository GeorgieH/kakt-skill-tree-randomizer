namespace Kakt.Modding.Core.Skills.BitterDread;

[SkillAttributes(SkillAttributes.Ice)]
[RequiresEffects(Effects.Chill | Effects.Freeze)]
public class BitterDread : PassiveSkill
{
    public override string Name => "Hero_arcanist__bitterDread";
}
