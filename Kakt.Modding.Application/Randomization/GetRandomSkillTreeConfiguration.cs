using Kakt.Modding.Configuration;
using Kakt.Modding.Domain.Heroes;
using MediatR;

namespace Kakt.Modding.Application.Randomization;

public record GetRandomSkillTreeConfigurationCommand(
    Hero Hero,
    ISkillTreeRandomizer SkillTreeRandomizer,
    CfgDocument SkillTreeConfiguration,
    CfgDocument HeroConfiguration) : IRequest;

public class GetRandomSkillTreeConfigurationHandler : IRequestHandler<GetRandomSkillTreeConfigurationCommand>
{
    private readonly ILogger logger;

    public GetRandomSkillTreeConfigurationHandler(ILogger logger)
    {
        this.logger = logger;
    }

    public Task Handle(GetRandomSkillTreeConfigurationCommand request, CancellationToken cancellationToken)
    {
        logger.Log($"Randomizing {request.Hero.GetType().Name}...");

        return Task.CompletedTask;
    }
}
