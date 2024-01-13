using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Skills;

public interface ISkillRepository
{
    void Add(Skill skill);
}

public class SkillRepository : ISkillRepository
{
    private readonly List<Skill> skills = [];

    public void Add(Skill skill)
    {
        skills.Add(skill);
    }
}
