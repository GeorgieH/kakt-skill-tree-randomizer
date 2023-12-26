using Kakt.Modding.Core.Skills.BearTrap;
using Kakt.Modding.Core.Skills.Berserking;
using Kakt.Modding.Core.Skills.Charge;
using Kakt.Modding.Core.Skills.CounterAttack;
using Kakt.Modding.Core.Skills.Dash;
using Kakt.Modding.Core.Skills.Dash.Upgrades;
using Kakt.Modding.Core.Skills.DebilitatingThrow;
using Kakt.Modding.Core.Skills.Dodge;
using Kakt.Modding.Core.Skills.DrainLife;
using Kakt.Modding.Core.Skills.Encouragement;
using Kakt.Modding.Core.Skills.Flurry;
using Kakt.Modding.Core.Skills.GasTrap;
using Kakt.Modding.Core.Skills.Hide;
using Kakt.Modding.Core.Skills.Ironclad;
using Kakt.Modding.Core.Skills.Juggernaut;
using Kakt.Modding.Core.Skills.Jump;
using Kakt.Modding.Core.Skills.JumpingAttack;
using Kakt.Modding.Core.Skills.LightningTrap;
using Kakt.Modding.Core.Skills.LowProfile;
using Kakt.Modding.Core.Skills.MarkTarget;
using Kakt.Modding.Core.Skills.MasterAssassin;
using Kakt.Modding.Core.Skills.MasterOfTraps;
using Kakt.Modding.Core.Skills.PoisonBomb;
using Kakt.Modding.Core.Skills.QuickFooted;
using Kakt.Modding.Core.Skills.Rage;
using Kakt.Modding.Core.Skills.Robust;
using Kakt.Modding.Core.Skills.Scout;
using Kakt.Modding.Core.Skills.SerratedTraps;
using Kakt.Modding.Core.Skills.SmokeBomb;
using Kakt.Modding.Core.Skills.ThrowingDagger;
using Kakt.Modding.Core.Skills.Thunderbolt;
using Kakt.Modding.Core.Skills.Unyielding;

namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public partial class HeroClassSkillFilter
{
    private static readonly IEnumerable<Type> VanguardSkills = CommonSkills!.Concat(new HashSet<Type>
    {
        typeof(BearTrap),
        typeof(Berserking),
        typeof(Charge),
        typeof(CounterAttack),
        typeof(VanguardDash),
        typeof(DebilitatingThrow),
        typeof(Dodge),
        typeof(DrainLife),
        typeof(Encouragement),
        typeof(LadyBoudiceaFlurry),
        typeof(GasTrap),
        typeof(Hide),
        typeof(Ironclad),
        typeof(Juggernaut),
        typeof(Jump),
        typeof(JumpingAttack),
        typeof(LightningTrap),
        typeof(LowProfile),
        typeof(MarkTarget),
        typeof(MasterAssassin),
        typeof(MasterOfTraps),
        typeof(LadyBoudiceaPoisonBomb),
        typeof(QuickFooted),
        typeof(Rage),
        typeof(Robust),
        typeof(Scout),
        typeof(SerratedTraps),
        typeof(SirTristanSmokeBomb),
        typeof(Sprint),
        typeof(ThrowingDagger),
        typeof(Thunderbolt),
        typeof(Unyielding)
    });
}
