using Kakt.Modding.Core;
using Kakt.Modding.Core.KnightsTale.Configuration;
using Kakt.Modding.Core.KnightsTale.Heroes;

namespace Kakt.Modding.Cli.KnightsTale;

public class DocumentRepository : IDocumentRepository
{
    private Dictionary<string, CfgDocument> documents = [];

    private readonly IFileSystemService fileSystemService;

    public DocumentRepository(IFileSystemService fileSystemService)
    {
        this.fileSystemService = fileSystemService;
    }

    public CfgDocument GetHermitDocument()
    {
        var path = fileSystemService.GetCfgPath(FileNames.MerlinHermit);
        return GetDocument(path);
    }

    public CfgDocument GetHeroDocument(Hero hero)
    {
        var fileName = fileSystemService.GetHeroConfigurationFileName(hero);
        var path = fileSystemService.GetCfgPath(fileName);
        return GetDocument(path);
    }

    public CfgDocument GetSkillTreeDocument()
    {
        var path = fileSystemService.GetCfgPath(FileNames.SkillTree);
        return GetDocument(path);
    }

    private CfgDocument GetDocument(string path)
    {
        if (documents.TryGetValue(path, out var document))
        {
            return document;
        }

        document = CfgDocument.Parse(path);
        documents.Add(path, document);

        return document;
    }
}
