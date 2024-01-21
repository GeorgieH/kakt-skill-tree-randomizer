using Kakt.Modding.Application.Skills;
using Kakt.Modding.Domain.Skills.FireBolt;
using Kakt.Modding.Domain.Skills.FlamingStrike;
using Kakt.Modding.Domain.Skills.ForceBolt;
using Kakt.Modding.Domain.Skills.IceBolt;
using Kakt.Modding.Domain.Skills.LightningStrike;
using Kakt.Modding.Domain.Skills.PoisonCut;
using Kakt.Modding.Domain.Skills.ShadowBolt;
using Kakt.Modding.Domain.Skills.Shoot;
using Kakt.Modding.Domain.Skills.Strike.Champion;
using Kakt.Modding.Domain.Skills.Strike.Defender;
using Kakt.Modding.Domain.Skills.Strike.Sage;
using Kakt.Modding.Domain.Skills.Strike.Vanguard;
using Kakt.Modding.Domain.Skills.Strike;
using Kakt.Modding.Domain.Skills;

namespace Kakt.Modding.Application.Randomization.Profiles.Default;

public class SkillRepositoryManager
{
    private readonly ISkillRepository skillRepository;
    private readonly ISkillUpgradeRepository skillUpgradeRepository;

    public SkillRepositoryManager(
        ISkillRepository skillRepository,
        ISkillUpgradeRepository skillUpgradeRepository)
    {
        this.skillRepository = skillRepository;
        this.skillUpgradeRepository = skillUpgradeRepository;
    }

    public void AddBasicSkills()
    {
        ExpandSkillRepository(
            new ChampionStrike(),
            new Domain.Skills.Strike.Champion.Upgrades.GloryKill(),
            new Domain.Skills.Strike.Champion.Upgrades.MindBreak(),
            new Domain.Skills.Strike.Champion.Upgrades.OpenWounds(),
            new Domain.Skills.Strike.Champion.Upgrades.ReelingBlow(),
            new Domain.Skills.Strike.Champion.Upgrades.StrongGrip());

        ExpandSkillRepository(
            new DefenderStrike(),
            new Domain.Skills.Strike.Defender.Upgrades.BoneBreaker(),
            new Domain.Skills.Strike.Defender.Upgrades.KillingBlow(),
            new Domain.Skills.Strike.Defender.Upgrades.Shredder(),
            new Domain.Skills.Strike.Defender.Upgrades.SweepingStrike());

        ExpandSkillRepository(
            new FireBolt(),
            new Domain.Skills.FireBolt.Upgrades.Inferno(),
            new Domain.Skills.FireBolt.Upgrades.Mindgame(),
            new Domain.Skills.FireBolt.Upgrades.MultipleTargets(),
            new Domain.Skills.FireBolt.Upgrades.Overheat());

        ExpandSkillRepository(
            new FlamingStrike(),
            new Domain.Skills.FlamingStrike.Upgrades.CharredFlesh(),
            new Domain.Skills.FlamingStrike.Upgrades.EternalFlame(),
            new Domain.Skills.FlamingStrike.Upgrades.SearingBlaze(),
            new Domain.Skills.FlamingStrike.Upgrades.UndeadBane());

        ExpandSkillRepository(
            new ForceBolt(),
            new Domain.Skills.ForceBolt.Upgrades.DamnedPrey(),
            new Domain.Skills.ForceBolt.Upgrades.Mindgame(),
            new Domain.Skills.ForceBolt.Upgrades.MultipleTargets(),
            new Domain.Skills.ForceBolt.Upgrades.PiercingBolt());

        ExpandSkillRepository(
            new IceBolt(),
            new Domain.Skills.IceBolt.Upgrades.DamnedPrey(),
            new Domain.Skills.IceBolt.Upgrades.Mindgame(),
            new Domain.Skills.IceBolt.Upgrades.MultipleTargets(),
            new Domain.Skills.IceBolt.Upgrades.PiercingBolt());

        ExpandSkillRepository(
            new LightningStrike(),
            new Domain.Skills.LightningStrike.Upgrades.Disruption(),
            new Domain.Skills.LightningStrike.Upgrades.GloryKill(),
            new Domain.Skills.LightningStrike.Upgrades.GreaterLighting(),
            new Domain.Skills.LightningStrike.Upgrades.Overheat());

        ExpandSkillRepository(
            new PoisonCut(),
            new Domain.Skills.PoisonCut.Upgrades.Blight(),
            new Domain.Skills.PoisonCut.Upgrades.FetidBlade(),
            new Domain.Skills.PoisonCut.Upgrades.Gangrene());

        ExpandSkillRepository(
            new SageStrike(),
            new Domain.Skills.Strike.Sage.Upgrades.ChillingTouch(),
            new Domain.Skills.Strike.Sage.Upgrades.DrainingStrike(),
            new Domain.Skills.Strike.Sage.Upgrades.Might(),
            new Domain.Skills.Strike.Sage.Upgrades.ReelingBlow(),
            new Domain.Skills.Strike.Sage.Upgrades.Shredder(),
            new Domain.Skills.Strike.Sage.Upgrades.Splinter());

        ExpandSkillRepository(
            new ShadowBolt(),
            new Domain.Skills.ShadowBolt.Upgrades.Empower(),
            new Domain.Skills.ShadowBolt.Upgrades.ErodeWill(),
            new Domain.Skills.ShadowBolt.Upgrades.Mindgame(),
            new Domain.Skills.ShadowBolt.Upgrades.MultipleTargets());

        ExpandSkillRepository(
            new Shoot(),
            new Domain.Skills.Shoot.Upgrades.Elusive(),
            new Domain.Skills.Shoot.Upgrades.PiercingArrow(),
            new Domain.Skills.Shoot.Upgrades.QuickDraw(),
            new Domain.Skills.Shoot.Upgrades.Thunder(),
            new Domain.Skills.Shoot.Upgrades.Torture());

        ExpandSkillRepository(
            new SirMordredStrike(),
            new Domain.Skills.Strike.Defender.Upgrades.BoneBreaker(),
            new Domain.Skills.Strike.Defender.Upgrades.KillingBlow(),
            new Domain.Skills.Strike.Defender.Upgrades.Shredder(),
            new Domain.Skills.Strike.Defender.Upgrades.SweepingStrike());

        ExpandSkillRepository(
            new VanguardStrike(),
            new Domain.Skills.Strike.Vanguard.Upgrades.DeepCuts(),
            new Domain.Skills.Strike.Vanguard.Upgrades.FinishingBlow(),
            new Domain.Skills.Strike.Vanguard.Upgrades.PoisonedBlade(),
            new Domain.Skills.Strike.Vanguard.Upgrades.RelentlessStrikes(),
            new Domain.Skills.Strike.Vanguard.Upgrades.Shredder(),
            new Domain.Skills.Strike.Vanguard.Upgrades.SinisterBlow());
    }

    private void ExpandSkillRepository(Skill skill, params SkillUpgrade[] skillUpgrades)
    {
        skillRepository.Add(skill);

        foreach (var skillUpgrade in skillUpgrades)
        {
            skillUpgradeRepository.Add(skill, skillUpgrade);
        }
    }
}
