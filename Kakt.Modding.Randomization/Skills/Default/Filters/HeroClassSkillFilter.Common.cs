using Kakt.Modding.Core.Skills.Adrenaline;
using Kakt.Modding.Core.Skills.Alchemist;
using Kakt.Modding.Core.Skills.AllResistance;
using Kakt.Modding.Core.Skills.Armourer;
using Kakt.Modding.Core.Skills.Assassination;
using Kakt.Modding.Core.Skills.AuraOfProtection;
using Kakt.Modding.Core.Skills.Backstab;
using Kakt.Modding.Core.Skills.BitterDread;
using Kakt.Modding.Core.Skills.BloodHex;
using Kakt.Modding.Core.Skills.DamageFocus;
using Kakt.Modding.Core.Skills.MasterAlchemist;
using Kakt.Modding.Core.Skills.MasterBleeding;
using Kakt.Modding.Core.Skills.MasterOfFire;
using Kakt.Modding.Core.Skills.MasterOfHexes;
using Kakt.Modding.Core.Skills.MasterOfIce;
using Kakt.Modding.Core.Skills.MasterOfLightning;
using Kakt.Modding.Core.Skills.MasterOfPotions;
using Kakt.Modding.Core.Skills.PotentHex;
using Kakt.Modding.Core.Skills.Pyromania;
using Kakt.Modding.Core.Skills.QuickCurse;
using Kakt.Modding.Core.Skills.SlowingHex;
using Kakt.Modding.Core.Skills.SoothingWords;
using Kakt.Modding.Core.Skills.TerrorWings;
using Kakt.Modding.Core.Skills.Wildfire;

namespace Kakt.Modding.Randomization.Skills.Default.Filters;

public partial class HeroClassSkillFilter
{
    private static readonly HashSet<Type> CommonSkills =
    [
        typeof(Adrenaline),
        typeof(Alchemist),
        typeof(AllResistance),
        typeof(Armourer),
        typeof(Assassination),
        typeof(AuraOfProtection),
        typeof(Backstab),
        typeof(BitterDread),
        typeof(BloodHex),
        typeof(DamageFocus),
        typeof(MasterAlchemist),
        typeof(MasterBleeding),
        typeof(MasterOfFire),
        typeof(MasterOfHexes),
        typeof(MasterOfIce),
        typeof(MasterOfLightning),
        typeof(MasterOfPotions),
        typeof(PotentHex),
        typeof(Pyromania),
        typeof(QuickCurse),
        typeof(SlowingHex),
        typeof(SoothingWords),
        typeof(TerrorWings),
        typeof(Wildfire)
    ];
}
