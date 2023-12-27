namespace Kakt.Modding.Core.Skills.Flurry;

[ConfigurationElement(nameof(Flurry))]
[SkillAttributes(SkillAttributes.Melee)]
public class Flurry : ActiveSkill
{
    public override string Name => "Hero_defender__flurry";
}
