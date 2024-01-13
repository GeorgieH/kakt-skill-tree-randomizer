using Kakt.Modding.Configuration;
using Kakt.Modding.Domain.Heroes;

namespace Kakt.Modding.Application;

public interface IDocumentRepository
{
    IEnumerable<CfgDocument> AsEnumerable();
    CfgDocument GetSkillTreeDocument();
    CfgDocument GetHeroDocument(Hero hero);
    CfgDocument GetHermitDocument();
}
