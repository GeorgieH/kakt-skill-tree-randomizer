namespace Kakt.Modding.Core.KnightsTale.Skills.Strike;

public class Strike : ActiveSkill
{
    public Strike()
    {
        ConfigurationName = nameof(Strike);
        Attributes = SkillAttributes.Melee;
    }
}
