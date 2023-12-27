using Kakt.Modding.Configuration.IO;
using Kakt.Modding.Configuration.IO.SkillTree;
using Kakt.Modding.Randomization.Skills.Default;
using System.Text;

static void Exit(string message)
{
    Console.WriteLine(message);
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();
}

var localPath = AppDomain.CurrentDomain.BaseDirectory;
var skillTreePath = Path.Combine(localPath, "SkillTree.cfg");

if (!File.Exists(skillTreePath))
{
    Exit($"File not found: {skillTreePath}");
    return;
}

var document = CfgDocument.Parse(skillTreePath);

var randomizer = new DefaultSkillTreeRandomizer();
var heroes = randomizer.Generate();

SkillTreeWriter.Overwrite(document, heroes);

var outputPath = Path.Combine(localPath, "King Arthur Knight's Tale");

if (Directory.Exists(outputPath))
{
    Directory.Delete(outputPath, true);
}

File.WriteAllText(Path.Combine(outputPath, "Cfg", "Config", "SkillTree.cfg"), document.ToString(), Encoding.UTF8);
