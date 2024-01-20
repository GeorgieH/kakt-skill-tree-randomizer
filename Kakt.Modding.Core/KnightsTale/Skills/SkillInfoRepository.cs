namespace Kakt.Modding.Core.KnightsTale.Skills;

public interface ISkillInfoRepository
{
    void Add(SkillInfo skillInfo);
    IEnumerable<SkillInfo> GetAll();
}

public class SkillInfoRepository : ISkillInfoRepository
{
    private readonly HashSet<SkillInfo> infos = [];

    public void Add(SkillInfo skill)
    {
        infos.Add(skill);
    }

    public IEnumerable<SkillInfo> GetAll()
    {
        return infos;
    }
}
