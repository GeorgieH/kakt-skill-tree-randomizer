using Kakt.Modding.Core.Heroes;

namespace Kakt.Modding.Configuration.SkillTree;

public static class SkillTreeWriter
{
    public static void Overwrite(CfgDocument document, IEnumerable<Hero> heroes)
    {
        foreach (var hero in heroes)
        {
            var heroObj = CfgObjectFactory.Get(hero);
            document.OverwriteObject(heroObj.Name, heroObj);
        }
    }
}
