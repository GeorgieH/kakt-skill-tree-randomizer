namespace Kakt.Modding.Core.Skills.Strike;

// ensures specializations of Strike are configured correctly
[ConfigurationElement(nameof(Strike))]
[SkillAttributes(SkillAttributes.Melee)]
public abstract class Strike : ActiveSkill
{
}
