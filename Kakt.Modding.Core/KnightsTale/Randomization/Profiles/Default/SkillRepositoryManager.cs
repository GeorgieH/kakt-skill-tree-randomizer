using Kakt.Modding.Core.KnightsTale.Skills;
using Kakt.Modding.Core.KnightsTale.Skills.FireBolt;
using Kakt.Modding.Core.KnightsTale.Skills.FlamingStrike;
using Kakt.Modding.Core.KnightsTale.Skills.ForceBolt;
using Kakt.Modding.Core.KnightsTale.Skills.IceBolt;
using Kakt.Modding.Core.KnightsTale.Skills.LightningStrike;
using Kakt.Modding.Core.KnightsTale.Skills.PoisonCut;
using Kakt.Modding.Core.KnightsTale.Skills.ShadowBolt;
using Kakt.Modding.Core.KnightsTale.Skills.Shoot;
using Kakt.Modding.Core.KnightsTale.Skills.Strike;
using Kakt.Modding.Core.KnightsTale.Skills.Strike.Champion;
using Kakt.Modding.Core.KnightsTale.Skills.Strike.Defender;
using Kakt.Modding.Core.KnightsTale.Skills.Strike.Sage;
using Kakt.Modding.Core.KnightsTale.Skills.Strike.Vanguard;

namespace Kakt.Modding.Core.KnightsTale.Randomization.Profiles.Default;

public class SkillRepositoryManager
{
    private readonly ISkillInfoRepository skillInfoRepository;
    private readonly ISkillUpgradeInfoRepository skillUpgradeInfoRepository;

    public SkillRepositoryManager(
        ISkillInfoRepository skillInfoRepository,
        ISkillUpgradeInfoRepository skillUpgradeInfoRepository)
    {
        this.skillInfoRepository = skillInfoRepository;
        this.skillUpgradeInfoRepository = skillUpgradeInfoRepository;
    }

    public void AddBasicSkills()
    {
        ExpandSkillInfoRepository(
            new ChampionStrike(),
            new Skills.Strike.Champion.Upgrades.GloryKill(),
            new Skills.Strike.Champion.Upgrades.MindBreak(),
            new Skills.Strike.Champion.Upgrades.OpenWounds(),
            new Skills.Strike.Champion.Upgrades.ReelingBlow(),
            new Skills.Strike.Champion.Upgrades.StrongGrip());

        ExpandSkillInfoRepository(
            new DefenderStrike(),
            new Skills.Strike.Defender.Upgrades.BoneBreaker(),
            new Skills.Strike.Defender.Upgrades.KillingBlow(),
            new Skills.Strike.Defender.Upgrades.Shredder(),
            new Skills.Strike.Defender.Upgrades.SweepingStrike());

        ExpandSkillInfoRepository(
            new FireBolt(),
            new Skills.FireBolt.Upgrades.Inferno(),
            new Skills.FireBolt.Upgrades.Mindgame(),
            new Skills.FireBolt.Upgrades.MultipleTargets(),
            new Skills.FireBolt.Upgrades.Overheat());

        ExpandSkillInfoRepository(
            new FlamingStrike(),
            new Skills.FlamingStrike.Upgrades.CharredFlesh(),
            new Skills.FlamingStrike.Upgrades.EternalFlame(),
            new Skills.FlamingStrike.Upgrades.SearingBlaze(),
            new Skills.FlamingStrike.Upgrades.UndeadBane());

        ExpandSkillInfoRepository(
            new ForceBolt(),
            new Skills.ForceBolt.Upgrades.DamnedPrey(),
            new Skills.ForceBolt.Upgrades.Mindgame(),
            new Skills.ForceBolt.Upgrades.MultipleTargets(),
            new Skills.ForceBolt.Upgrades.PiercingBolt());

        ExpandSkillInfoRepository(
            new IceBolt(),
            new Skills.IceBolt.Upgrades.DamnedPrey(),
            new Skills.IceBolt.Upgrades.Mindgame(),
            new Skills.IceBolt.Upgrades.MultipleTargets(),
            new Skills.IceBolt.Upgrades.PiercingBolt());

        ExpandSkillInfoRepository(
            new LightningStrike(),
            new Skills.LightningStrike.Upgrades.Disruption(),
            new Skills.LightningStrike.Upgrades.GloryKill(),
            new Skills.LightningStrike.Upgrades.GreaterLighting(),
            new Skills.LightningStrike.Upgrades.Overheat());

        ExpandSkillInfoRepository(
            new PoisonCut(),
            new Skills.PoisonCut.Upgrades.Blight(),
            new Skills.PoisonCut.Upgrades.FetidBlade(),
            new Skills.PoisonCut.Upgrades.Gangrene());

        ExpandSkillInfoRepository(
            new SageStrike(),
            new Skills.Strike.Sage.Upgrades.ChillingTouch(),
            new Skills.Strike.Sage.Upgrades.DrainingStrike(),
            new Skills.Strike.Sage.Upgrades.Might(),
            new Skills.Strike.Sage.Upgrades.ReelingBlow(),
            new Skills.Strike.Sage.Upgrades.Shredder(),
            new Skills.Strike.Sage.Upgrades.Splinter());

        ExpandSkillInfoRepository(
            new ShadowBolt(),
            new Skills.ShadowBolt.Upgrades.Empower(),
            new Skills.ShadowBolt.Upgrades.ErodeWill(),
            new Skills.ShadowBolt.Upgrades.Mindgame(),
            new Skills.ShadowBolt.Upgrades.MultipleTargets());

        ExpandSkillInfoRepository(
            new Shoot(),
            new Skills.Shoot.Upgrades.Elusive(),
            new Skills.Shoot.Upgrades.PiercingArrow(),
            new Skills.Shoot.Upgrades.QuickDraw(),
            new Skills.Shoot.Upgrades.Thunder(),
            new Skills.Shoot.Upgrades.Torture());

        ExpandSkillInfoRepository(
            new SirMordredStrike(),
            new Skills.Strike.Defender.Upgrades.BoneBreaker(),
            new Skills.Strike.Defender.Upgrades.KillingBlow(),
            new Skills.Strike.Defender.Upgrades.Shredder(),
            new Skills.Strike.Defender.Upgrades.SweepingStrike());

        ExpandSkillInfoRepository(
            new VanguardStrike(),
            new Skills.Strike.Vanguard.Upgrades.DeepCuts(),
            new Skills.Strike.Vanguard.Upgrades.FinishingBlow(),
            new Skills.Strike.Vanguard.Upgrades.PoisonedBlade(),
            new Skills.Strike.Vanguard.Upgrades.RelentlessStrikes(),
            new Skills.Strike.Vanguard.Upgrades.Shredder(),
            new Skills.Strike.Vanguard.Upgrades.SinisterBlow());
    }

    private void ExpandSkillInfoRepository(SkillInfo skillInfos, params SkillUpgradeInfo[] skillUpgradeInfos)
    {
        skillInfoRepository.Add(skillInfos);

        foreach (var skillUpgradeInfo in skillUpgradeInfos)
        {
            skillUpgradeInfoRepository.Add(skillInfos, skillUpgradeInfo);
        }
    }
}
