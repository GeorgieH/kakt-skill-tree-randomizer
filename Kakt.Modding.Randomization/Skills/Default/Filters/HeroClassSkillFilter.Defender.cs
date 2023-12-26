using Kakt.Modding.Core.Skills.BatteringRam;
using Kakt.Modding.Core.Skills.BleedingStrike;
using Kakt.Modding.Core.Skills.CastStigma;
using Kakt.Modding.Core.Skills.ChainLightning;
using Kakt.Modding.Core.Skills.CleansingFire;
using Kakt.Modding.Core.Skills.Cleave;
using Kakt.Modding.Core.Skills.CounterAttack;
using Kakt.Modding.Core.Skills.DeathStrike;
using Kakt.Modding.Core.Skills.DivineFavour;
using Kakt.Modding.Core.Skills.Encouragement;
using Kakt.Modding.Core.Skills.Flurry;
using Kakt.Modding.Core.Skills.FreezingAttack;
using Kakt.Modding.Core.Skills.Guard;
using Kakt.Modding.Core.Skills.HardenedArmour;
using Kakt.Modding.Core.Skills.HolySmite;
using Kakt.Modding.Core.Skills.Hunter;
using Kakt.Modding.Core.Skills.Hunter.Upgrades;
using Kakt.Modding.Core.Skills.IceShield;
using Kakt.Modding.Core.Skills.Immolation;
using Kakt.Modding.Core.Skills.Kick;
using Kakt.Modding.Core.Skills.LightningCleave;
using Kakt.Modding.Core.Skills.MeleeExpertise;
using Kakt.Modding.Core.Skills.Mock;
using Kakt.Modding.Core.Skills.MonsterHunter;
using Kakt.Modding.Core.Skills.Recuperate;
using Kakt.Modding.Core.Skills.Robust;
using Kakt.Modding.Core.Skills.Ruthlessness;
using Kakt.Modding.Core.Skills.ShieldBlock;
using Kakt.Modding.Core.Skills.ShieldCharge;
using Kakt.Modding.Core.Skills.Strength;
using Kakt.Modding.Core.Skills.StrongWilled;
using Kakt.Modding.Core.Skills.Taunt;
using Kakt.Modding.Core.Skills.ThrowingAxe;
using Kakt.Modding.Core.Skills.Thunderbolt;
using Kakt.Modding.Core.Skills.Unyielding;
using Kakt.Modding.Core.Skills.Vengeance;
using Kakt.Modding.Core.Skills.Vigilance;

namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public partial class HeroClassSkillFilter
{
    private static readonly IEnumerable<Type> DefenderSkills = CommonSkills!.Concat(new HashSet<Type>
    {
        typeof(BatteringRam),
        typeof(BleedingStrike),
        typeof(CastStigma),
        typeof(ChainLightning),
        typeof(CleansingFire),
        typeof(RedKnightCleave),
        typeof(CounterAttack),
        typeof(DeathStrike),
        typeof(DivineFavour),
        typeof(Encouragement),
        typeof(Flurry),
        typeof(FreezingAttack),
        typeof(Guard),
        typeof(HardenedArmour),
        typeof(HolySmite),
        typeof(Hunter),
        typeof(IceShield),
        typeof(Immolation),
        typeof(Kick),
        typeof(LightningCleave),
        typeof(MeleeExpertise),
        typeof(Mock),
        typeof(MonsterHunter),
        typeof(Recuperate),
        typeof(Robust),
        typeof(Ruthlessness),
        typeof(ShieldBlock),
        typeof(ShieldCharge),
        typeof(SpellResistance),
        typeof(Strength),
        typeof(StrongWilled),
        typeof(DefenderTaunt),
        typeof(ThrowingAxe),
        typeof(Thunderbolt),
        typeof(Unyielding),
        typeof(Vengeance),
        typeof(Vigilance)
    });
}
