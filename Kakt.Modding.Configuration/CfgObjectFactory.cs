using Kakt.Modding.Domain.Heroes;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Configuration;

public static class CfgObjectFactory
{
    public static CfgObject Get(Hero hero)
    {
        var heroObj = new CfgObject(hero.Name);

        var skillRegister = new Dictionary<string, List<int>>();

        foreach (var skill in hero.SkillTree.Skills)
        {
            var skillName = skill!.ConfigurationName!;

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
            var skillName = skill!.ConfigurationName!;

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
        skill.ConfigurationName = skillName;

        var obj = new CfgObject(skill.ConfigurationName);

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
        skillUpgrade.ConfigurationName = $"{skillName}_p{index}";

        var obj = new CfgObject(skillUpgrade.ConfigurationName);

        obj.Elements.Add(new CfgProperty("Cost", skillUpgrade.Cost));

        if (skillUpgrade.LevelLimit > 0)
        {
            obj.Elements.Add(new CfgProperty("LevelLimit", skillUpgrade.LevelLimit));
        }

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
        if (skillName != "Scout" && index == 1)
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
