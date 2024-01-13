using Kakt.Modding.Application.Skills;
using Kakt.Modding.Domain.Skills;
using MediatR;
using System.Text.Json;

namespace Kakt.Modding.Cli;

internal static class Bootstrapper
{
    private static readonly string SkillsPath = @"Resources\Knight's Tale\Skills";

    public static async Task Run(IMediator mediator)
    {
        var rootPath = AppDomain.CurrentDomain.BaseDirectory;
        var skillsPath = Path.Combine(rootPath, SkillsPath);

        foreach (var directory in Directory.EnumerateDirectories(skillsPath))
        {
            var skills = GetSkills(directory);
            var skillUpgrades = GetSkillUpgrades(directory);

            foreach (var skill in skills)
            {
                await mediator.Send(new AddSkillCommand(skill));

                foreach (var skillUpgrade in skillUpgrades)
                {
                    await mediator.Send(new AddSkillUpgradeCommand(skill, skillUpgrade));
                }
            }
        }
    }

    private static IEnumerable<Skill> GetSkills(string directory)
    {
        var skillFiles = new Queue<string>(Directory.EnumerateFiles(directory));
        var skills = new HashSet<Skill>();

        while (skillFiles.Any())
        {
            var skillFile = skillFiles.Dequeue();
            var skillJson = File.ReadAllText(skillFile);

            if (TryDeserializeToSkill(skillJson, skills, out var skill))
            {
                skills.Add(skill!);
            }
            else
            {
                skillFiles.Enqueue(skillFile);
            }
        }

        return skills;
    }

    private static IEnumerable<SkillUpgrade> GetSkillUpgrades(string directory)
    {
        var skillUpgrades = new HashSet<SkillUpgrade>();
        var upgradesDirectory = Path.Combine(directory, "Upgrades");

        if (Directory.Exists(upgradesDirectory))
        {
            foreach (var skillUpgradeFile in Directory.EnumerateFiles(upgradesDirectory))
            {
                var skillUpgradeJson = File.ReadAllText(skillUpgradeFile);
                skillUpgrades.Add(DeserializeToSkillUpgrade(skillUpgradeJson));
            }
        }

        return skillUpgrades;
    }

    private static bool TryDeserializeToSkill(string skillJson, IEnumerable<Skill> skills, out Skill? skill)
    {
        skill = new();

        var jsonObject = JsonSerializer.Deserialize<JsonElement>(skillJson);

        if (jsonObject.TryGetProperty("_Base", out var @base))
        {
            var baseSkill = skills.FirstOrDefault(x => x.Name.Equals(@base.GetString()));

            if (baseSkill is not null)
            {
                skill = baseSkill.Copy();
            }
            else
            {
                skill = null;
                return false;
            }
        }

        if (jsonObject.TryGetProperty(nameof(Skill.Name), out var name))
        {
            skill.Name = name.GetString()!;
        }

        if (jsonObject.TryGetProperty(nameof(Skill.CodeName), out var codeName))
        {
            skill.CodeName = codeName.GetString()!;
        }

        if (jsonObject.TryGetProperty(nameof(Skill.Type), out var type))
        {
            skill.Type = Enum.Parse<SkillType>(type.GetString()!);
        }

        if (jsonObject.TryGetProperty(nameof(Skill.ConfigurationName), out var configurationName))
        {
            skill.ConfigurationName = configurationName.GetString();
        }
        else
        {
            skill.ConfigurationName = skill.Name;
        }

        if (jsonObject.TryGetProperty(nameof(Skill.IconName), out var iconName))
        {
            skill.IconName = iconName.GetString();
        }

        if (jsonObject.TryGetProperty(nameof(Skill.Upgradable), out var upgradable))
        {
            skill.Upgradable = upgradable.GetBoolean();
        }
        else
        {
            skill.Upgradable = skill.Type switch
            {
                SkillType.Active => true,
                SkillType.Passive => false,
                _ => throw new NotImplementedException(),
            };
        }

        if (jsonObject.TryGetProperty(nameof(Skill.Attributes), out var attributes))
        {
            foreach (var attribute in attributes.EnumerateArray())
            {
                skill.Attributes |= Enum.Parse<SkillAttributes>(attribute.GetString()!);
            }
        }

        if (jsonObject.TryGetProperty(nameof(Skill.PrerequisiteAttributes), out var prerequisiteAttributes))
        {
            foreach (var attribute in prerequisiteAttributes.EnumerateArray())
            {
                skill.PrerequisiteAttributes |= Enum.Parse<SkillAttributes>(attribute.GetString()!);
            }
        }

        if (jsonObject.TryGetProperty(nameof(Skill.Effects), out var effects))
        {
            foreach (var effect in effects.EnumerateArray())
            {
                skill.Effects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        if (jsonObject.TryGetProperty(nameof(Skill.PrerequisiteEffects), out var prerequisiteEffects))
        {
            foreach (var effect in prerequisiteEffects.EnumerateArray())
            {
                skill.PrerequisiteEffects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        return true;
    }

    private static SkillUpgrade DeserializeToSkillUpgrade(string skillUpgradeJson)
    {
        var skillUpgrade = new SkillUpgrade();

        var jsonObject = JsonSerializer.Deserialize<JsonElement>(skillUpgradeJson);

        if (jsonObject.TryGetProperty(nameof(SkillUpgrade.Name), out var name))
        {
            skillUpgrade.Name = name.GetString()!;
        }

        if (jsonObject.TryGetProperty(nameof(SkillUpgrade.CodeName), out var codeName))
        {
            skillUpgrade.CodeName = codeName.GetString()!;
        }

        if (jsonObject.TryGetProperty(nameof(SkillUpgrade.Effects), out var effects))
        {
            foreach (var effect in effects.EnumerateArray())
            {
                skillUpgrade.Effects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        return skillUpgrade;
    }
}
