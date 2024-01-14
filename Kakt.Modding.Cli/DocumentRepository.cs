using Kakt.Modding.Application;
using Kakt.Modding.Configuration;
using Kakt.Modding.Domain.Heroes;

namespace Kakt.Modding.Cli;

public class DocumentRepository : IDocumentRepository
{
    private Dictionary<string, CfgDocument> documents = [];

    public CfgDocument GetHermitDocument()
    {
        var path = Path.Combine(FileSystemHelpers.GetCfgPath(), FileNames.MerlinHermit);
        return GetDocument(path);
    }

    public CfgDocument GetHeroDocument(Hero hero)
    {
        var path = Path.Combine(FileSystemHelpers.GetCfgPath(), FileSystemHelpers.GetHeroConfigurationFileName(hero));
        return GetDocument(path);
    }

    public CfgDocument GetSkillTreeDocument()
    {
        var path = Path.Combine(FileSystemHelpers.GetCfgPath(), FileNames.SkillTree);
        return GetDocument(path);
    }

    private CfgDocument GetDocument(string path)
    {
        if (!File.Exists(path))
        {
            throw new DocumentNotFoundException(path);
        }

        if (documents.TryGetValue(path, out var document))
        {
            return document;
        }

        document = CfgDocument.Parse(path);
        documents.Add(path, document);

        return document;
    }
}
