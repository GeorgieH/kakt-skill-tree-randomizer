using Kakt.Modding.Domain.Skills;
using MediatR;

namespace Kakt.Modding.Application.Skills;

public record AddSkillCommand(Skill Skill) : IRequest;

public class AddSkillHandler : IRequestHandler<AddSkillCommand>
{
    private readonly ISkillRepository skillRepository;

    public AddSkillHandler(ISkillRepository skillRepository)
    {
        this.skillRepository = skillRepository;
    }

    public Task Handle(AddSkillCommand request, CancellationToken cancellationToken)
    {
        this.skillRepository.Add(request.Skill);
        return Task.CompletedTask;
    }
}
