using Kakt.Modding.Core.Skills.Adrenaline;
using Kakt.Modding.Core.Skills.Alchemist;
using Kakt.Modding.Core.Skills.AllResistance;
using Kakt.Modding.Core.Skills.Armourer;
using Kakt.Modding.Core.Skills.Assassination;
using Kakt.Modding.Core.Skills.AuraOfProtection;
using Kakt.Modding.Core.Skills.Backstab;
using Kakt.Modding.Core.Skills.BearTrap;
using Kakt.Modding.Core.Skills.Bless;
using Kakt.Modding.Core.Skills.BloodHex;
using Kakt.Modding.Core.Skills.Charge;
using Kakt.Modding.Core.Skills.Cleave;
using Kakt.Modding.Core.Skills.CounterAttack;
using Kakt.Modding.Core.Skills.DamageFocus;
using Kakt.Modding.Core.Skills.Dash;
using Kakt.Modding.Core.Skills.DazingStrikes;
using Kakt.Modding.Core.Skills.DeathHex;
using Kakt.Modding.Core.Skills.DeathStrike;
using Kakt.Modding.Core.Skills.DebilitatingThrow;
using Kakt.Modding.Core.Skills.DefensiveStance;
using Kakt.Modding.Core.Skills.Deflection;
using Kakt.Modding.Core.Skills.Divine;
using Kakt.Modding.Core.Skills.DrainBlood;
using Kakt.Modding.Core.Skills.EarthShaker;
using Kakt.Modding.Core.Skills.EnchantedWeapon;

namespace Kakt.Modding.Randomization.Skills.Default;

public partial class HeroClassSkillSelector
{
    private readonly Type[] ChampionSkills =
    [
        typeof(Adrenaline),
        typeof(Alchemist),
        typeof(AllResistance),
        typeof(Armourer),
        typeof(Assassination),
        typeof(AuraOfProtection),
        typeof(Backstab),
        typeof(BearTrap),
        typeof(Bless),
        typeof(BloodHex),
        typeof(Charge),
        typeof(Cleave),
        typeof(CounterAttack),
        typeof(DamageFocus),
        typeof(VanguardDash),
        typeof(DazingStrikes),
        typeof(DeathHex),
        typeof(DeathStrike),
        typeof(DebilitatingThrow),
        typeof(DefensiveStance),
        typeof(Deflection),
        typeof(Divine),
        typeof(DrainBlood),
        typeof(EarthShaker),
        typeof(EnchantedWeapon)
    ];
}
