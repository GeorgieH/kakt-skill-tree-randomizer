using System.Reflection;

namespace Kakt.Modding.Core.Skills;

public static class Skills
{
    private static readonly Type ActiveSkillType = typeof(ActiveSkill);
    private static readonly Type PassiveSkillType = typeof(PassiveSkill);

    private static readonly Type[] activeSkillTypes = GetAllActiveSkillTypes();
    private static readonly Type[] passiveSkillTypes = GetAllPassiveSkillTypes();

    public static IEnumerable<Type> ActiveSkillTypes => activeSkillTypes;
    public static IEnumerable<Type> PassiveSkillTypes => passiveSkillTypes;
    public static IEnumerable<Type> UpgradeablePassiveSkillTypes => throw new NotImplementedException();

    private static Type[] GetAllActiveSkillTypes()
    {
        return AssemblyTypes
            .AllConcreteTypes
            .Where(ActiveSkillType.IsAssignableFrom)
            .ToArray();
    }

    private static Type[] GetAllPassiveSkillTypes()
    {
        return AssemblyTypes
            .AllConcreteTypes
            .Where(PassiveSkillType.IsAssignableFrom)
            .ToArray();
    }
}
