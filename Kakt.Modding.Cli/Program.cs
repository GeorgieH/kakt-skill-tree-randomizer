using Kakt.Modding.Cli;
using Kakt.Modding.Configuration;
using Kakt.Modding.Configuration.SkillTree;
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

var randomizer = new DefaultSkillTreeRandomizer(new ConsoleLogger());
var heroes = randomizer.Generate();

SkillTreeWriter.Overwrite(document, heroes);

var outputPath = Path.Combine(localPath, "King Arthur Knight's Tale");

if (Directory.Exists(outputPath))
{
    Directory.Delete(outputPath, true);
}

var configPath = Path.Combine(outputPath, "Cfg", "Config");
Directory.CreateDirectory(configPath);

File.WriteAllText(Path.Combine(configPath, "SkillTree.cfg"), document.ToString(), Encoding.UTF8);

Exit("Done!");
