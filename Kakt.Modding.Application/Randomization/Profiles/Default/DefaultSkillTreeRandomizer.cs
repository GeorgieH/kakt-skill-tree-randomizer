using Kakt.Modding.Application.Skills;
using Kakt.Modding.Domain.Heroes;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class DefaultSkillTreeRandomizer
{
    private readonly ISkillRepository skillRepository;

    public DefaultSkillTreeRandomizer(ISkillRepository skillRepository)
    {
        this.skillRepository = skillRepository;
    }

    public void SetRandomSkillTree(Hero hero)
    {
        hero.SkillTree.TierOneActiveSkillOne = GetBasicAttack(hero);
        hero.SkillTree.TierOneActiveSkillTwo = GetActiveSkill(hero, SkillTier.One, 2, profile);
        hero.SkillTree.TierOneActiveSkillThree = GetActiveSkill(hero, SkillTier.One, 3, profile, starter: true);

        if (hero is Vanguard)
        {
            hero.SkillTree.TierOneActiveSkillFour = GetActiveSkill(hero, SkillTier.One, 4, profile);
        }
        else
        {
            hero.SkillTree.TierOneUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.One, 4, profile);
        }

        hero.SkillTree.TierOnePassiveSkillOne = GetPassiveSkill(hero, SkillTier.One, 5, profile);
        hero.SkillTree.TierOnePassiveSkillTwo = GetPassiveSkill(hero, SkillTier.One, 6, profile);
        hero.SkillTree.TierOnePassiveSkillThree = GetPassiveSkill(hero, SkillTier.One, 7, profile);

        hero.SkillTree.TierTwoActiveSkillOne = GetActiveSkill(hero, SkillTier.Two, 8, profile);
        hero.SkillTree.TierTwoActiveSkillTwo = GetActiveSkill(hero, SkillTier.Two, 9, profile);
        hero.SkillTree.TierTwoActiveSkillThree = GetActiveSkill(hero, SkillTier.Two, 11, profile);
        hero.SkillTree.TierTwoUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.Two, 10, profile);
        hero.SkillTree.TierTwoPassiveSkillOne = GetPassiveSkill(hero, SkillTier.Two, 12, profile);
        hero.SkillTree.TierTwoPassiveSkillTwo = GetPassiveSkill(hero, SkillTier.Two, 13, profile);

        hero.SkillTree.TierThreeActiveSkillOne = GetActiveSkill(hero, SkillTier.Three, 14, profile);
        hero.SkillTree.TierThreeActiveSkillTwo = GetActiveSkill(hero, SkillTier.Three, 17, profile);
        hero.SkillTree.TierThreeUpgradablePassiveSkillOne = GetUpgradablePassiveSkill(hero, SkillTier.Three, 15, profile);
        hero.SkillTree.TierThreeUpgradablePassiveSkillTwo = GetUpgradablePassiveSkill(hero, SkillTier.Three, 16, profile);
        hero.SkillTree.TierThreePassiveSkillOne = GetPassiveSkill(hero, SkillTier.Three, 18, profile);
        hero.SkillTree.TierThreePassiveSkillTwo = GetPassiveSkill(hero, SkillTier.Three, 19, profile);
        hero.SkillTree.TierThreePassiveSkillThree = GetPassiveSkill(hero, SkillTier.Three, 20, profile);

        DeduplicateSkillNames(hero);

        AcquireSkills(hero, profile);
    }

    private static Skill GetBasicAttack(Hero hero)
    {
        Skill skill;

        if (hero is FaerieKnight)
        {
            skill = new LightningStrike();
        }
        else if (hero is LadyMorganaLeFay)
        {
            skill = new IceBolt();
        }
        else if (hero is Merlin)
        {
            skill = new FireBolt();
        }
        else if (hero is SirDagonet)
        {
            skill = new ShadowBolt();
        }
        else if (hero is SirEctor)
        {
            skill = new ForceBolt();
        }
        else if (hero is SirMordred)
        {
            skill = new SirMordredStrike();
        }
        else if (hero is SirGalahad || hero is SirPercival)
        {
            skill = new FlamingStrike();
        }
        else if (hero is SirTristan)
        {
            skill = new PoisonCut();
        }
        else if (hero is Champion)
        {
            skill = new ChampionStrike();
        }
        else if (hero is Defender)
        {
            skill = new DefenderStrike();
        }
        else if (hero is Marksman)
        {
            skill = new Shoot();
        }
        else if (hero is Sage)
        {
            skill = new SageStrike();
        }
        else if (hero is Vanguard)
        {
            skill = new VanguardStrike();
        }
        else
        {
            throw new NotImplementedException();
        }

        SkillFactory.Build(skill, SkillTier.One, 1, starter: true);

        return (ActiveSkill)skill;
    }
}
