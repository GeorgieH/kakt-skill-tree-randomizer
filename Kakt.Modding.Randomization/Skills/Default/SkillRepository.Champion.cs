using Kakt.Modding.Core.Skills.Assault;
using Kakt.Modding.Core.Skills.BlessedWeapon;
using Kakt.Modding.Core.Skills.CastStigma;
using Kakt.Modding.Core.Skills.Cleave;
using Kakt.Modding.Core.Skills.CounterAttack;
using Kakt.Modding.Core.Skills.DazingStrikes;
using Kakt.Modding.Core.Skills.DeathStrike;
using Kakt.Modding.Core.Skills.DefensiveStance;
using Kakt.Modding.Core.Skills.DrainBlood;
using Kakt.Modding.Core.Skills.EarthShaker;
using Kakt.Modding.Core.Skills.ExtraAreaDamage;
using Kakt.Modding.Core.Skills.ExtraBleeding;
using Kakt.Modding.Core.Skills.ExtraStun;
using Kakt.Modding.Core.Skills.HardenedArmour;
using Kakt.Modding.Core.Skills.HexCleave;
using Kakt.Modding.Core.Skills.HolyArmour;
using Kakt.Modding.Core.Skills.IceAura;
using Kakt.Modding.Core.Skills.IceSpikes;
using Kakt.Modding.Core.Skills.Inspire;
using Kakt.Modding.Core.Skills.IronSkinned;
using Kakt.Modding.Core.Skills.Juggernaut;
using Kakt.Modding.Core.Skills.Kick;
using Kakt.Modding.Core.Skills.LeapAttack;
using Kakt.Modding.Core.Skills.LoneWolf;
using Kakt.Modding.Core.Skills.MeleeExpertise;
using Kakt.Modding.Core.Skills.PowerAttack;
using Kakt.Modding.Core.Skills.Preparedness;
using Kakt.Modding.Core.Skills.Pulverise;
using Kakt.Modding.Core.Skills.Radiance;
using Kakt.Modding.Core.Skills.Rage;
using Kakt.Modding.Core.Skills.Rampage;
using Kakt.Modding.Core.Skills.Robust;
using Kakt.Modding.Core.Skills.RupturingStrike;
using Kakt.Modding.Core.Skills.Strength;
using Kakt.Modding.Core.Skills.StrongWilled;
using Kakt.Modding.Core.Skills.Taunt;
using Kakt.Modding.Core.Skills.Vengeance;
using Kakt.Modding.Core.Skills.Whirlwind;

namespace Kakt.Modding.Randomization.Skills.Default;

public static partial class SkillRepository
{
    private static IEnumerable<Type>? ChampionSkills;

    public static IEnumerable<Type> GetChampionSkills()
    {
        ChampionSkills ??= new HashSet<Type>
        {
            typeof(Assault),
            typeof(BlessedWeapon),
            typeof(BlackKnightCastStigma),
            typeof(Cleave),
            typeof(CounterAttack),
            typeof(DazingStrikes),
            typeof(SirKayDeathStrike),
            typeof(DefensiveStance),
            typeof(DrainBlood),
            typeof(EarthShaker),
            typeof(ExtraAreaDamage),
            typeof(ExtraBleeding),
            typeof(ExtraStun),
            typeof(HardenedArmour),
            typeof(HexCleave),
            typeof(HolyArmour),
            typeof(IceAura),
            typeof(IceSpikes),
            typeof(Inspire),
            typeof(IronSkinned),
            typeof(Juggernaut),
            typeof(Kick),
            typeof(LeapAttack),
            typeof(LoneWolf),
            typeof(MeleeExpertise),
            typeof(PowerAttack),
            typeof(Preparedness),
            typeof(Pulverise),
            typeof(Radiance),
            typeof(Rage),
            typeof(Rampage),
            typeof(Robust),
            typeof(RupturingStrike),
            typeof(Strength),
            typeof(StrongWilled),
            typeof(ChampionTaunt),
            typeof(Vengeance),
            typeof(Whirlwind)
        }.Concat(GetCommonSkills());

        return ChampionSkills;
    }
}
