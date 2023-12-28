
namespace Kakt.Modding.Randomization.Skills.Default;
public class SkillRepository : ISkillRepository
{
    private readonly HashSet<Type> arcanistSkillTypes = [];
    private readonly HashSet<Type> championSkillTypes = [];
    private readonly HashSet<Type> defenderSkillTypes = [];
    private readonly HashSet<Type> marksmanSkillTypes = [];
    private readonly HashSet<Type> sageSkillTypes = [];
    private readonly HashSet<Type> vanguardSkillTypes = [];

    public void AddCommonSkillType(Type skillType)
    {
        AddArcanistSkillType(skillType);
        AddChampionSkillType(skillType);
        AddDefenderSkillType(skillType);
        AddMarksmanSkillType(skillType);
        AddSageSkillType(skillType);
        AddVanguardSkillType(skillType);
    }

    public void AddArcanistSkillType(Type skillType)
    {
        arcanistSkillTypes.Add(skillType);
    }

    public void AddChampionSkillType(Type skillType)
    {
        championSkillTypes.Add(skillType);
    }

    public void AddDefenderSkillType(Type skillType)
    {
        defenderSkillTypes.Add(skillType);
    }

    public void AddMarksmanSkillType(Type skillType)
    {
        marksmanSkillTypes.Add(skillType);
    }

    public void AddSageSkillType(Type skillType)
    {
        sageSkillTypes.Add(skillType);
    }

    public void AddVanguardSkillType(Type skillType)
    {
        vanguardSkillTypes.Add(skillType);
    }

    public IEnumerable<Type> GetArcanistSkillTypes()
    {
        return arcanistSkillTypes;
    }

    public IEnumerable<Type> GetChampionSkillTypes()
    {
        return championSkillTypes;
    }

    public IEnumerable<Type> GetDefenderSkillTypes()
    {
        return defenderSkillTypes;
    }

    public IEnumerable<Type> GetMarksmanSkillTypes()
    {
        return marksmanSkillTypes;
    }

    public IEnumerable<Type> GetSageSkillTypes()
    {
        return sageSkillTypes;
    }

    public IEnumerable<Type> GetVanguardSkillTypes()
    {
        return vanguardSkillTypes;
    }
}
