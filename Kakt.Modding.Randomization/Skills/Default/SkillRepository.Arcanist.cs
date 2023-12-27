using Kakt.Modding.Core.Skills.CastStigma;
using Kakt.Modding.Core.Skills.ChainLightning;
using Kakt.Modding.Core.Skills.CursedGround;
using Kakt.Modding.Core.Skills.DeathHex;
using Kakt.Modding.Core.Skills.Dodge;
using Kakt.Modding.Core.Skills.ExtraDamage;
using Kakt.Modding.Core.Skills.FallingStar;
using Kakt.Modding.Core.Skills.FireBlast;
using Kakt.Modding.Core.Skills.FireDrake;
using Kakt.Modding.Core.Skills.Fog;
using Kakt.Modding.Core.Skills.ForceCleave;
using Kakt.Modding.Core.Skills.GlacialStrike;
using Kakt.Modding.Core.Skills.IceShield;
using Kakt.Modding.Core.Skills.IceThorns;
using Kakt.Modding.Core.Skills.IceWall;
using Kakt.Modding.Core.Skills.Illusion;
using Kakt.Modding.Core.Skills.Ironclad;
using Kakt.Modding.Core.Skills.LongReach;
using Kakt.Modding.Core.Skills.MagicalArmour;
using Kakt.Modding.Core.Skills.MasterInvoker;
using Kakt.Modding.Core.Skills.MentalGuard;
using Kakt.Modding.Core.Skills.MindFog;
using Kakt.Modding.Core.Skills.Mindstorm;
using Kakt.Modding.Core.Skills.RavenSwarm;
using Kakt.Modding.Core.Skills.Skirmisher;
using Kakt.Modding.Core.Skills.Spellpower;
using Kakt.Modding.Core.Skills.SpellResistance;
using Kakt.Modding.Core.Skills.StrongWilled;
using Kakt.Modding.Core.Skills.SummonLostCommoner;
using Kakt.Modding.Core.Skills.SummonLostKnight;
using Kakt.Modding.Core.Skills.Teleport;
using Kakt.Modding.Core.Skills.WallOfFlame;

namespace Kakt.Modding.Randomization.Skills.Default;

public static partial class SkillRepository
{
    private static IEnumerable<Type>? ArcanistSkills;

    public static IEnumerable<Type> GetArcanistSkills()
    {
        ArcanistSkills ??= new HashSet<Type>
        {
            typeof(CastStigma),
            typeof(ChainLightning),
            typeof(CursedGround),
            typeof(DeathHex),
            typeof(Dodge),
            typeof(ExtraDamage),
            typeof(FallingStar),
            typeof(FireBlast),
            typeof(FireDrake),
            typeof(Fog),
            typeof(ForceCleave),
            typeof(GlacialStrike),
            typeof(IceShield),
            typeof(IceThorns),
            typeof(IceWall),
            typeof(Illusion),
            typeof(Ironclad),
            typeof(ArcanistLongReach),
            typeof(MagicalArmour),
            typeof(MasterInvoker),
            typeof(MentalGuard),
            typeof(MindFog),
            typeof(MindStorm),
            typeof(RavenSwarm),
            typeof(Skirmisher),
            typeof(Spellpower),
            typeof(SpellResistance),
            typeof(StrongWilled),
            typeof(SummonLostCommoner),
            typeof(SummonLostKnight),
            typeof(Teleport),
            typeof(WallOfFlame)
        }.Concat(GetCommonSkills());

        return ArcanistSkills;
    }
}
