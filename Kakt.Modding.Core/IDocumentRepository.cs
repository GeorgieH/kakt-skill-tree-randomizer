using Kakt.Modding.Core.KnightsTale.Configuration;
using Kakt.Modding.Core.KnightsTale.Heroes;

namespace Kakt.Modding.Core;

public interface IDocumentRepository
{
    CfgDocument GetSkillTreeDocument();
    CfgDocument GetHeroDocument(Hero hero);
    CfgDocument GetHermitDocument();
}
