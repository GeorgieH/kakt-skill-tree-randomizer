using Kakt.Modding.Core;
using Kakt.Modding.Core.Heroes;
using Kakt.Modding.Core.Skills;
using Kakt.Modding.Core.Skills.Scout;

namespace Kakt.Modding.Configuration.IO;

public static class CfgObjectFactory
{
    public static CfgObject Get(Hero hero)
    {
        var heroName = hero.GetConfigurationElementName();
        var heroObj = new CfgObject(heroName);

        var skillRegister = new Dictionary<string, List<int>>();

        foreach (var skill in hero.SkillTree.Skills)
        {
            var skillName = skill!.GetConfigurationElementName();

            if (skillRegister.TryGetValue(skillName, out var list))
            {
                var newIndex = list.Last() + 1;
                list.Add(newIndex);
            }
            else
            {
                skillRegister.Add(skillName, [1]);
            }
        }

        var toRemove = new List<string>();
        
        foreach (var kvp in skillRegister)
        {
            if (kvp.Value.Count == 1)
            {
                toRemove.Add(kvp.Key);
            }
        }

        foreach (var skillName in toRemove)
        {
            skillRegister.Remove(skillName);
        }

        foreach (var skill in hero.SkillTree.Skills)
        {
            var skillName = skill!.GetConfigurationElementName();

            if (skillRegister.TryGetValue(skillName, out var list))
            {
                var index = list.First();
                list.RemoveAt(0);
                var postfix = GetSkillNamePostfix(skillName, index);
                skillName = $"{skillName}{postfix}";

                foreach (var skillUpgrade in skill!.Upgrades)
                {
                    skillUpgrade.OverridePrerequisite(skillName);
                }
            }

            var skillObj = GetSkillObject(skill!, skillName);
            heroObj.Elements.Add(skillObj);

            for (var i = 0; i < skill!.Upgrades.Count; i++)
            {
                var skillUpgrade = skill.Upgrades[i];
                var skillUpgradeObj = GetSkillUpgradeObject(skillUpgrade, skillName, i + 1);
                heroObj.Elements.Add(skillUpgradeObj);
            }
        }

        return heroObj;
    }

    private static CfgObject GetSkillObject(Skill skill, string skillName)
    {
        var obj = new CfgObject(skillName);

        if (skill.Starter)
        {
            obj.Elements.Add(new CfgProperty("Starter", "1"));
        }
        else
        {
            obj.Elements.Add(new CfgProperty("Cost", skill.Cost));
        }

        if (!string.IsNullOrWhiteSpace(skill.IconName))
        {
            obj.Elements.Add(new CfgProperty("IconName", skill.IconName));
        }

        obj.Elements.Add(new CfgProperty("Skill", skill.GetNameOrOverride()));
        obj.Elements.Add(new CfgProperty("Type", skill.Type.ToString().ToLower()));
        obj.Elements.Add(new CfgProperty("IconPos", $"{skill.IconPosition.X};{skill.IconPosition.Y}"));
        obj.Elements.Add(new CfgProperty("Tier", (int)skill.Tier));

        return obj;
    }

    private static CfgObject GetSkillUpgradeObject(SkillUpgrade skillUpgrade, string skillName, int index)
    {
        var obj = new CfgObject($"{skillName}_p{index}");

        obj.Elements.Add(new CfgProperty("Cost", skillUpgrade.Cost));
        obj.Elements.Add(new CfgProperty("Prerequisite", skillUpgrade.GetPrerequisiteOrOverride()));

        if (!string.IsNullOrWhiteSpace(skillUpgrade.IconName))
        {
            obj.Elements.Add(new CfgProperty("IconName", skillUpgrade.IconName));
        }

        obj.Elements.Add(new CfgProperty("Skill", skillUpgrade.GetNameOrOverride()));
        obj.Elements.Add(new CfgProperty("Type", skillUpgrade.Type.ToString().ToLower()));
        obj.Elements.Add(new CfgProperty("IconPos", $"{skillUpgrade.IconPosition.X};{skillUpgrade.IconPosition.Y}"));
        obj.Elements.Add(new CfgProperty("Tier", (int)skillUpgrade.Tier));

        return obj;
    }

    private static string GetSkillNamePostfix(string skillName, int index)
    {
        if (skillName != nameof(Scout) && index == 1)
        {
            return string.Empty;
        }

        return index switch
        {
            1 => "_I",
            2 => "_II",
            3 => "_III",
            _ => throw new NotImplementedException(),
        };
    }
}
