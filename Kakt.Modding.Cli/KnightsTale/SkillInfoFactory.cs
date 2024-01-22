using Kakt.Modding.Core;
using Kakt.Modding.Core.KnightsTale.Skills;
using System.Text.Json;

namespace Kakt.Modding.Cli.KnightsTale;

public interface ISkillInfoFactory
{
    void Initialize();
}

public class SkillInfoFactory : ISkillInfoFactory
{
    private readonly ILogger logger;
    private readonly IFileSystemService fileSystemService;
    private readonly ISkillInfoRepository skillInfoRepository;
    private readonly ISkillUpgradeInfoRepository skillUpgradeInfoRepository;

    public SkillInfoFactory(
        ILogger logger,
        IFileSystemService fileSystemService,
        ISkillInfoRepository skillInfoRepository,
        ISkillUpgradeInfoRepository skillUpgradeInfoRepository)
    {
        this.logger = logger;
        this.fileSystemService = fileSystemService;
        this.skillInfoRepository = skillInfoRepository;
        this.skillUpgradeInfoRepository = skillUpgradeInfoRepository;
    }

    public void Initialize()
    {
        var path = fileSystemService.SkillInfoDirectory;

        foreach (var file in fileSystemService.GetFiles(path))
        {
            var json = fileSystemService.GetFileText(file);
            var document = JsonDocument.Parse(json);

            var skillInfos = GetSkills(document);

            foreach (var skillInfo in skillInfos)
            {
                logger.Log($"Adding {skillInfo.Name}...");

                skillInfoRepository.Add(skillInfo);

                var skillUpgradeInfos = GetSkillUpgrades(document);

                foreach (var skillUpgradeInfo in skillUpgradeInfos)
                {
                    skillUpgradeInfo.Prerequisite = skillInfo.ConfigurationName!;
                    skillUpgradeInfoRepository.Add(skillInfo, skillUpgradeInfo);
                }
            }
        }
    }

    private IEnumerable<SkillInfo> GetSkills(JsonDocument document)
    {
        var skills = new HashSet<SkillInfo>();

        foreach (var skill in document.RootElement.GetProperty("Skills").EnumerateArray())
        {
            var s = DeserializeToSkill(skill, skills);
            skills.Add(s);
        }

        return skills;
    }

    private IEnumerable<SkillUpgradeInfo> GetSkillUpgrades(JsonDocument document)
    {
        var upgrades = new HashSet<SkillUpgradeInfo>();

        if (document.RootElement.TryGetProperty("Upgrades", out var element))
        {
            foreach (var upgrade in element.EnumerateArray())
            {
                var u = DeserializeToSkillUpgrade(upgrade);
                upgrades.Add(u);
            }
        }

        return upgrades;
    }

    private static SkillInfo DeserializeToSkill(JsonElement element, IEnumerable<SkillInfo> skills)
    {
        var info = new SkillInfo();

        if (element.TryGetProperty("_Base", out var @base))
        {
            var baseSkill = skills.FirstOrDefault(x => x.Name.Equals(@base.GetString()));

            if (baseSkill is not null)
            {
                info = baseSkill.Copy();
            }
        }

        if (element.TryGetProperty(nameof(SkillInfo.Name), out var name))
        {
            info.Name = name.GetString()!;
        }

        if (element.TryGetProperty(nameof(SkillInfo.CodeName), out var codeName))
        {
            info.CodeName = codeName.GetString()!;
        }

        if (element.TryGetProperty(nameof(SkillInfo.Type), out var type))
        {
            info.Type = Enum.Parse<SkillType>(type.GetString()!);
        }

        if (element.TryGetProperty(nameof(SkillInfo.ConfigurationName), out var configurationName))
        {
            info.ConfigurationName = configurationName.GetString();
        }
        else if (info.ConfigurationName is null)
        {
            info.ConfigurationName = info.Name;
        }

        if (element.TryGetProperty(nameof(SkillInfo.IconName), out var iconName))
        {
            info.IconName = iconName.GetString();
        }

        if (element.TryGetProperty(nameof(SkillInfo.Upgradable), out var upgradable))
        {
            info.Upgradable = upgradable.GetBoolean();
        }
        else
        {
            info.Upgradable = info.Type switch
            {
                SkillType.Active => true,
                SkillType.Passive => false,
                _ => throw new NotImplementedException(),
            };
        }

        if (element.TryGetProperty(nameof(SkillInfo.Attributes), out var attributes))
        {
            foreach (var attribute in attributes.EnumerateArray())
            {
                info.Attributes |= Enum.Parse<SkillAttributes>(attribute.GetString()!);
            }
        }

        if (element.TryGetProperty(nameof(SkillInfo.PrerequisiteAttributes), out var prerequisiteAttributes))
        {
            foreach (var attribute in prerequisiteAttributes.EnumerateArray())
            {
                info.PrerequisiteAttributes |= Enum.Parse<SkillAttributes>(attribute.GetString()!);
            }
        }

        if (element.TryGetProperty(nameof(SkillInfo.PrerequisiteAttributesCheckType), out var prerequisiteAttributesCheckType))
        {
            info.PrerequisiteAttributesCheckType = Enum.Parse<PrerequisiteCheckType>(prerequisiteAttributesCheckType.GetString()!);
        }

        if (element.TryGetProperty(nameof(SkillInfo.Effects), out var effects))
        {
            foreach (var effect in effects.EnumerateArray())
            {
                info.Effects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        if (element.TryGetProperty(nameof(SkillInfo.PrerequisiteEffects), out var prerequisiteEffects))
        {
            foreach (var effect in prerequisiteEffects.EnumerateArray())
            {
                info.PrerequisiteEffects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        return info;
    }

    private SkillUpgradeInfo DeserializeToSkillUpgrade(JsonElement element)
    {
        var info = new SkillUpgradeInfo();

        if (element.TryGetProperty(nameof(SkillUpgradeInfo.Name), out var name))
        {
            info.Name = name.GetString()!;
        }

        if (element.TryGetProperty(nameof(SkillUpgradeInfo.CodeName), out var codeName))
        {
            info.CodeName = codeName.GetString()!;
        }

        if (element.TryGetProperty(nameof(SkillUpgradeInfo.Effects), out var effects))
        {
            foreach (var effect in effects.EnumerateArray())
            {
                info.Effects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        if (element.TryGetProperty(nameof(SkillUpgradeInfo.PrerequisiteEffects), out var prerequisiteEffects))
        {
            foreach (var effect in prerequisiteEffects.EnumerateArray())
            {
                info.PrerequisiteEffects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        return info;
    }
}