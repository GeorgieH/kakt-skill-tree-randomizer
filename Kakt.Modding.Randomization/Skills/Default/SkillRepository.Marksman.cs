using Kakt.Modding.Core.Skills.AimedShot;
using Kakt.Modding.Core.Skills.CoverExpert;
using Kakt.Modding.Core.Skills.CripplingShot;
using Kakt.Modding.Core.Skills.Dash;
using Kakt.Modding.Core.Skills.Deflection;
using Kakt.Modding.Core.Skills.DelayedBarrage;
using Kakt.Modding.Core.Skills.Evasion;
using Kakt.Modding.Core.Skills.FireArrow;
using Kakt.Modding.Core.Skills.FireBomb;
using Kakt.Modding.Core.Skills.FirstShot;
using Kakt.Modding.Core.Skills.GasTrap;
using Kakt.Modding.Core.Skills.Hunter;
using Kakt.Modding.Core.Skills.Ironclad;
using Kakt.Modding.Core.Skills.LightningArrow;
using Kakt.Modding.Core.Skills.LongReach;
using Kakt.Modding.Core.Skills.LowProfile;
using Kakt.Modding.Core.Skills.MarkTarget;
using Kakt.Modding.Core.Skills.MasterOfTraps;
using Kakt.Modding.Core.Skills.OnTheProwl;
using Kakt.Modding.Core.Skills.PiercingShot;
using Kakt.Modding.Core.Skills.PointBlankVolley;
using Kakt.Modding.Core.Skills.PoisonBomb;
using Kakt.Modding.Core.Skills.PoisonedArrow;
using Kakt.Modding.Core.Skills.RainOfArrows;
using Kakt.Modding.Core.Skills.RazorArrow;
using Kakt.Modding.Core.Skills.Ready;
using Kakt.Modding.Core.Skills.Robust;
using Kakt.Modding.Core.Skills.Scout;
using Kakt.Modding.Core.Skills.Scout.Marksman;
using Kakt.Modding.Core.Skills.Sentinel;
using Kakt.Modding.Core.Skills.Skirmisher;
using Kakt.Modding.Core.Skills.SmokeBomb;
using Kakt.Modding.Core.Skills.SmotheringShot;
using Kakt.Modding.Core.Skills.StormOfArrows;
using Kakt.Modding.Core.Skills.Surge;
using Kakt.Modding.Core.Skills.TrueAim;

namespace Kakt.Modding.Randomization.Skills.Default;

public static partial class SkillRepository
{
    private static IEnumerable<Type>? MarksmanSkills;

    public static IEnumerable<Type> GetMarksmanSkills()
    {
        MarksmanSkills ??= new HashSet<Type>
        {
            typeof(AimedShot),
            typeof(CripplingShot),
            typeof(CoverExpert),
            typeof(MarksmanDash),
            typeof(Deflection),
            typeof(DelayedBarrage),
            typeof(Evasion),
            typeof(FireArrow),
            typeof(FireBomb),
            typeof(FirstShot),
            typeof(SirDamasGasTrap),
            typeof(Hunter),
            typeof(Ironclad),
            typeof(LightningArrow),
            typeof(MarksmanLongReach),
            typeof(LowProfile),
            typeof(MarkTarget),
            typeof(MasterOfTraps),
            typeof(OnTheProwl),
            typeof(PiercingShot),
            typeof(PointBlankVolley),
            typeof(PoisonBomb),
            typeof(PoisonedArrow),
            typeof(RainOfArrows),
            typeof(RazorArrow),
            typeof(Ready),
            typeof(Robust),
            typeof(Scout),
            typeof(MarksmanScout),
            typeof(Sentinel),
            typeof(Skirmisher),
            typeof(SirDamasSmokeBomb),
            typeof(SmotheringShot),
            typeof(StormOfArrows),
            typeof(Surge),
            typeof(TrueAim)
        }.Concat(GetCommonSkills());

        return MarksmanSkills;
    }
}
