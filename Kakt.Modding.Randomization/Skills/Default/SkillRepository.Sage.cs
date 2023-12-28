using Kakt.Modding.Core.Skills.Bless;
using Kakt.Modding.Core.Skills.ChainLightning;
using Kakt.Modding.Core.Skills.CleansingFire;
using Kakt.Modding.Core.Skills.CounterAttack;
using Kakt.Modding.Core.Skills.Dash;
using Kakt.Modding.Core.Skills.Dedication;
using Kakt.Modding.Core.Skills.Divine;
using Kakt.Modding.Core.Skills.EnchantedWeapon;
using Kakt.Modding.Core.Skills.Favoured;
using Kakt.Modding.Core.Skills.FreezingAttack;
using Kakt.Modding.Core.Skills.FrostArmour;
using Kakt.Modding.Core.Skills.GlobeOfProtection;
using Kakt.Modding.Core.Skills.IceAura;
using Kakt.Modding.Core.Skills.IceLance;
using Kakt.Modding.Core.Skills.IceShield;
using Kakt.Modding.Core.Skills.IceSpikes;
using Kakt.Modding.Core.Skills.IceWall;
using Kakt.Modding.Core.Skills.Inspire;
using Kakt.Modding.Core.Skills.Ironclad;
using Kakt.Modding.Core.Skills.Judgement;
using Kakt.Modding.Core.Skills.MassProtection;
using Kakt.Modding.Core.Skills.MonsterHunter;
using Kakt.Modding.Core.Skills.Mysticism;
using Kakt.Modding.Core.Skills.PurgingStrike;
using Kakt.Modding.Core.Skills.RayOfLight;
using Kakt.Modding.Core.Skills.SoothingWords;
using Kakt.Modding.Core.Skills.StrongWilled;
using Kakt.Modding.Core.Skills.Teleport;
using Kakt.Modding.Core.Skills.Thunderbolt;
using Kakt.Modding.Core.Skills.ThunderStorm;
using Kakt.Modding.Core.Skills.Unburdened;
using Kakt.Modding.Core.Skills.WishOfDeath;

namespace Kakt.Modding.Randomization.Skills.Default;

public static partial class SkillRepository
{
    private static IEnumerable<Type>? SageSkills;

    public static IEnumerable<Type> GetSageSkills()
    {
        SageSkills ??= new HashSet<Type>
        {
            typeof(Bless),
            typeof(ChainLightning),
            typeof(CleansingFire),
            typeof(CounterAttack),
            typeof(MarksmanDash),
            typeof(Dedication),
            typeof(Divine),
            typeof(EnchantedWeapon),
            typeof(Favoured),
            typeof(FreezingAttack),
            typeof(FrostArmour),
            typeof(GlobeOfProtection),
            typeof(IceAura),
            typeof(IceLance),
            typeof(IceShield),
            typeof(IceSpikes),
            typeof(IceWall),
            typeof(Inspire),
            typeof(Ironclad),
            typeof(Judgement),
            typeof(MassProtection),
            typeof(MonsterHunter),
            typeof(Mysticism),
            typeof(PurgingStrike),
            typeof(RayOfLight),
            typeof(SoothingWords),
            typeof(StrongWilled),
            typeof(Teleport),
            typeof(Thunderbolt),
            typeof(ThunderStorm),
            typeof(Unburdened),
            typeof(WishOfDeath)
        }.Concat(GetCommonSkills());

        return SageSkills;
    }
}
