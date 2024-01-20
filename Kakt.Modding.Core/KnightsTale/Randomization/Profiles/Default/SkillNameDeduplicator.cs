using Kakt.Modding.Core.KnightsTale.Heroes;
using Kakt.Modding.Core.KnightsTale.Skills;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public interface ISkillNameDeduplicator
{
    void DeduplicateSkillNames(Hero hero);
}

public class SkillNameDeduplicator : ISkillNameDeduplicator
{
    public void DeduplicateSkillNames(Hero hero)
    {
        var skillRegister = new Dictionary<string, int>();

        void DeduplicateSkillName(ISkill skill)
        {
            var skillName = skill.CodeName;

            if (skillRegister!.TryGetValue(skillName, out var index))
            {
                var newIndex = index + 1;
                skillRegister[skillName] = newIndex;
                skill.CodeName = $"{skillName}{newIndex}";

                if (string.IsNullOrWhiteSpace(skill.IconName))
                {
                    skill.IconName = skillName;
                }
            }
            else
            {
                skillRegister.Add(skillName, 1);
            }
        }

        foreach (var skill in hero.SkillTree.Skills)
        {
            DeduplicateSkillName(skill!);

            foreach (var skillUpgrade in skill!.Upgrades)
            {
                DeduplicateSkillName(skillUpgrade);
            }
        }
    }
}
