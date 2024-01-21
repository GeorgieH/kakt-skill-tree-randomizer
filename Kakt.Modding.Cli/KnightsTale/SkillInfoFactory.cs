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

        foreach (var directory in fileSystemService.GetDirectories(path))
        {
            var skillInfos = GetSkills(directory);

            foreach (var skillInfo in skillInfos)
            {
                logger.Log($"Adding {skillInfo.Name}...");

                skillInfoRepository.Add(skillInfo);

                var skillUpgradeInfos = GetSkillUpgrades(directory);

                foreach (var skillUpgradeInfo in skillUpgradeInfos)
                {
                    skillUpgradeInfo.Prerequisite = skillInfo.ConfigurationName!;
                    skillUpgradeInfoRepository.Add(skillInfo, skillUpgradeInfo);
                }
            }
        }
    }

    private IEnumerable<SkillInfo> GetSkills(string directory)
    {
        var infoFiles = new Queue<string>(fileSystemService.GetFiles(directory));
        var infos = new HashSet<SkillInfo>();

        while (infoFiles.Any())
        {
            var infoFile = infoFiles.Dequeue();
            var infoJson = fileSystemService.GetFileText(infoFile);

            if (TryDeserializeToSkill(infoJson, infos, out var skill))
            {
                infos.Add(skill!);
            }
            else
            {
                infoFiles.Enqueue(infoFile);
            }
        }

        return infos;
    }

    private IEnumerable<SkillUpgradeInfo> GetSkillUpgrades(string directory)
    {
        var skillUpgrades = new HashSet<SkillUpgradeInfo>();
        var upgradesDirectory = fileSystemService.GetSkillUpgradesDirectory(directory);

        if (fileSystemService.DirectoryExists(upgradesDirectory))
        {
            foreach (var skillUpgradeFile in fileSystemService.GetFiles(upgradesDirectory))
            {
                var skillUpgradeJson = fileSystemService.GetFileText(skillUpgradeFile);
                skillUpgrades.Add(DeserializeToSkillUpgrade(skillUpgradeJson));
            }
        }

        return skillUpgrades;
    }

    private static bool TryDeserializeToSkill(string infoJson, IEnumerable<SkillInfo> infos, out SkillInfo? info)
    {
        info = new();

        var jsonObject = JsonSerializer.Deserialize<JsonElement>(infoJson);

        if (jsonObject.TryGetProperty("_Base", out var @base))
        {
            var baseSkill = infos.FirstOrDefault(x => x.Name.Equals(@base.GetString()));

            if (baseSkill is not null)
            {
                info = baseSkill.Copy();
            }
            else
            {
                info = null;
                return false;
            }
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.Name), out var name))
        {
            info.Name = name.GetString()!;
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.CodeName), out var codeName))
        {
            info.CodeName = codeName.GetString()!;
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.Type), out var type))
        {
            info.Type = Enum.Parse<SkillType>(type.GetString()!);
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.ConfigurationName), out var configurationName))
        {
            info.ConfigurationName = configurationName.GetString();
        }
        else if (info.ConfigurationName is null)
        {
            info.ConfigurationName = info.Name;
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.IconName), out var iconName))
        {
            info.IconName = iconName.GetString();
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.Upgradable), out var upgradable))
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

        if (jsonObject.TryGetProperty(nameof(SkillInfo.Attributes), out var attributes))
        {
            foreach (var attribute in attributes.EnumerateArray())
            {
                info.Attributes |= Enum.Parse<SkillAttributes>(attribute.GetString()!);
            }
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.PrerequisiteAttributes), out var prerequisiteAttributes))
        {
            foreach (var attribute in prerequisiteAttributes.EnumerateArray())
            {
                info.PrerequisiteAttributes |= Enum.Parse<SkillAttributes>(attribute.GetString()!);
            }
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.PrerequisiteAttributesCheckType), out var prerequisiteAttributesCheckType))
        {
            info.PrerequisiteAttributesCheckType = Enum.Parse<PrerequisiteCheckType>(prerequisiteAttributesCheckType.GetString()!);
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.Effects), out var effects))
        {
            foreach (var effect in effects.EnumerateArray())
            {
                info.Effects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        if (jsonObject.TryGetProperty(nameof(SkillInfo.PrerequisiteEffects), out var prerequisiteEffects))
        {
            foreach (var effect in prerequisiteEffects.EnumerateArray())
            {
                info.PrerequisiteEffects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        return true;
    }

    private SkillUpgradeInfo DeserializeToSkillUpgrade(string skillUpgradeJson)
    {
        var info = new SkillUpgradeInfo();

        var jsonObject = JsonSerializer.Deserialize<JsonElement>(skillUpgradeJson);

        if (jsonObject.TryGetProperty(nameof(SkillUpgradeInfo.Name), out var name))
        {
            info.Name = name.GetString()!;
        }

        if (jsonObject.TryGetProperty(nameof(SkillUpgradeInfo.CodeName), out var codeName))
        {
            info.CodeName = codeName.GetString()!;
        }

        if (jsonObject.TryGetProperty(nameof(SkillUpgradeInfo.Effects), out var effects))
        {
            foreach (var effect in effects.EnumerateArray())
            {
                info.Effects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        if (jsonObject.TryGetProperty(nameof(SkillUpgradeInfo.PrerequisiteEffects), out var prerequisiteEffects))
        {
            foreach (var effect in prerequisiteEffects.EnumerateArray())
            {
                info.PrerequisiteEffects |= Enum.Parse<Effects>(effect.GetString()!);
            }
        }

        return info;
    }
}