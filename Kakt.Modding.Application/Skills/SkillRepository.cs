using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Skills;

public interface ISkillRepository
{
    IEnumerable<Skill> AsEnumerable();
    void Add(Skill skill);
    Skill Get(Skill skill);
    Skill Get(Type skillType);
}

public class SkillRepository : ISkillRepository
{
    private readonly HashSet<Skill> skills = [];

    public IEnumerable<Skill> AsEnumerable()
    {
        return skills.AsEnumerable();
    }

    public void Add(Skill skill)
    {
        skills.Add(skill);
    }

    public Skill Get(Skill skill)
    {
        return skills.First(skill.Equals).Copy();
    }

    public Skill Get(Type skillType)
    {
        return skills.First(x => x.GetType() == skillType).Copy();
    }
}
