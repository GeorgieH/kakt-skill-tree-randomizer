using Kakt.Modding.Domain.Skills;
using MediatR;

namespace Kakt.Modding.Application.Skills;

public record AddSkillUpgradeCommand(Skill Skill, SkillUpgrade SkillUpgrade) : IRequest;

public class AddSkillUpgradeHandler : IRequestHandler<AddSkillUpgradeCommand>
{
    private readonly ISkillUpgradeRepository skillUpgradeRepository;

    public AddSkillUpgradeHandler(ISkillUpgradeRepository skillUpgradeRepository)
    {
        this.skillUpgradeRepository = skillUpgradeRepository;
    }

    public Task Handle(AddSkillUpgradeCommand request, CancellationToken cancellationToken)
    {
        this.skillUpgradeRepository.Add(request.Skill, request.SkillUpgrade);
        return Task.CompletedTask;
    }
}
