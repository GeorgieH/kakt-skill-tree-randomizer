namespace Kakt.Modding.Randomization.Skills.Default;

public interface ISkillRepository
{
    void AddCommonSkillType(Type skillType);

    void AddArcanistSkillType(Type skillType);
    IEnumerable<Type> GetArcanistSkillTypes();

    void AddChampionSkillType(Type skillType);
    IEnumerable<Type> GetChampionSkillTypes();

    void AddDefenderSkillType(Type skillType);
    IEnumerable<Type> GetDefenderSkillTypes();

    void AddMarksmanSkillType(Type skillType);
    IEnumerable<Type> GetMarksmanSkillTypes();

    void AddSageSkillType(Type skillType);
    IEnumerable<Type> GetSageSkillTypes();

    void AddVanguardSkillType(Type skillType);
    IEnumerable<Type> GetVanguardSkillTypes();
}
