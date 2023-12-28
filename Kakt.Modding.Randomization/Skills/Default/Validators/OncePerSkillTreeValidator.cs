using Kakt.Modding.Core.Skills.Adrenaline;
using Kakt.Modding.Core.Skills.Alchemist;
using Kakt.Modding.Core.Skills.AllResistance;
using Kakt.Modding.Core.Skills.Armourer;
using Kakt.Modding.Core.Skills.Assassination;
using Kakt.Modding.Core.Skills.Backstab;
using Kakt.Modding.Core.Skills.BitterDread;
using Kakt.Modding.Core.Skills.CounterAttack;
using Kakt.Modding.Core.Skills.CoverExpert;
using Kakt.Modding.Core.Skills.DamageFocus;
using Kakt.Modding.Core.Skills.DazingStrikes;
using Kakt.Modding.Core.Skills.Dedication;
using Kakt.Modding.Core.Skills.Deflection;
using Kakt.Modding.Core.Skills.Divine;
using Kakt.Modding.Core.Skills.Dodge;
using Kakt.Modding.Core.Skills.Evasion;
using Kakt.Modding.Core.Skills.ExtraAreaDamage;
using Kakt.Modding.Core.Skills.ExtraBleeding;
using Kakt.Modding.Core.Skills.ExtraDamage;
using Kakt.Modding.Core.Skills.ExtraStun;
using Kakt.Modding.Core.Skills.Favoured;
using Kakt.Modding.Core.Skills.FirstShot;
using Kakt.Modding.Core.Skills.FrostArmour;
using Kakt.Modding.Core.Skills.HardenedArmour;
using Kakt.Modding.Core.Skills.Hunter;
using Kakt.Modding.Core.Skills.Hunter.Upgrades;
using Kakt.Modding.Core.Skills.Ironclad;
using Kakt.Modding.Core.Skills.IronSkinned;
using Kakt.Modding.Core.Skills.Juggernaut;
using Kakt.Modding.Core.Skills.LoneWolf;
using Kakt.Modding.Core.Skills.LongReach;
using Kakt.Modding.Core.Skills.LowProfile;
using Kakt.Modding.Core.Skills.MagicalArmour;
using Kakt.Modding.Core.Skills.MasterAlchemist;
using Kakt.Modding.Core.Skills.MasterAssassin;
using Kakt.Modding.Core.Skills.MasterBleeding;
using Kakt.Modding.Core.Skills.MasterInvoker;
using Kakt.Modding.Core.Skills.MasterOfFire;
using Kakt.Modding.Core.Skills.MasterOfHexes;
using Kakt.Modding.Core.Skills.MasterOfIce;
using Kakt.Modding.Core.Skills.MasterOfLightning;
using Kakt.Modding.Core.Skills.MasterOfPotions;
using Kakt.Modding.Core.Skills.MasterOfTraps;
using Kakt.Modding.Core.Skills.MeleeExpertise;
using Kakt.Modding.Core.Skills.MentalGuard;
using Kakt.Modding.Core.Skills.Mindstorm;
using Kakt.Modding.Core.Skills.MonsterHunter;
using Kakt.Modding.Core.Skills.Mysticism;
using Kakt.Modding.Core.Skills.OnTheProwl;
using Kakt.Modding.Core.Skills.PotentHex;
using Kakt.Modding.Core.Skills.Pyromania;
using Kakt.Modding.Core.Skills.QuickCurse;
using Kakt.Modding.Core.Skills.QuickFooted;
using Kakt.Modding.Core.Skills.Rage;
using Kakt.Modding.Core.Skills.Ready;
using Kakt.Modding.Core.Skills.Ruthlessness;
using Kakt.Modding.Core.Skills.Sentinel;
using Kakt.Modding.Core.Skills.SerratedTraps;
using Kakt.Modding.Core.Skills.ShieldBlock;
using Kakt.Modding.Core.Skills.Skirmisher;
using Kakt.Modding.Core.Skills.SoothingWords;
using Kakt.Modding.Core.Skills.Spellpower;
using Kakt.Modding.Core.Skills.StrongWilled;
using Kakt.Modding.Core.Skills.TerrorWings;
using Kakt.Modding.Core.Skills.Unburdened;
using Kakt.Modding.Core.Skills.Unyielding;
using Kakt.Modding.Core.Skills.Vengeance;
using Kakt.Modding.Core.Skills.Vigilance;
using Kakt.Modding.Core.Skills.Wildfire;
using Kakt.Modding.Core.Skills.WishOfDeath;

namespace Kakt.Modding.Randomization.Skills.Default.Validators;

public class OncePerSkillTreeValidator : ISkillSelector
{
    private static readonly HashSet<Type> Types =
    [
        typeof(Adrenaline),
        typeof(Alchemist),
        typeof(AllResistance),
        typeof(Armourer),
        typeof(Assassination),
        typeof(Backstab),
        typeof(BitterDread),
        typeof(CounterAttack),
        typeof(CoverExpert),
        typeof(DamageFocus),
        typeof(DazingStrikes),
        typeof(Dedication),
        typeof(Deflection),
        typeof(Divine),
        typeof(Dodge),
        typeof(Evasion),
        typeof(ExtraAreaDamage),
        typeof(ExtraBleeding),
        typeof(ExtraDamage),
        typeof(ExtraStun),
        typeof(Favoured),
        typeof(FirstShot),
        typeof(FrostArmour),
        typeof(HardenedArmour),
        typeof(Hunter),
        typeof(Ironclad),
        typeof(IronSkinned),
        typeof(Juggernaut),
        typeof(LoneWolf),
        typeof(ArcanistLongReach),
        typeof(MarksmanLongReach),
        typeof(LowProfile),
        typeof(MagicalArmour),
        typeof(MasterAlchemist),
        typeof(MasterAssassin),
        typeof(MasterBleeding),
        typeof(MasterInvoker),
        typeof(MasterOfFire),
        typeof(MasterOfHexes),
        typeof(MasterOfIce),
        typeof(MasterOfLightning),
        typeof(MasterOfPotions),
        typeof(MasterOfTraps),
        typeof(MeleeExpertise),
        typeof(MentalGuard),
        typeof(MindStorm),
        typeof(MonsterHunter),
        typeof(Mysticism),
        typeof(OnTheProwl),
        typeof(PotentHex),
        typeof(Pyromania),
        typeof(QuickCurse),
        typeof(QuickFooted),
        typeof(Rage),
        typeof(Ready),
        typeof(Ruthlessness),
        typeof(Sentinel),
        typeof(SerratedTraps),
        typeof(ShieldBlock),
        typeof(Skirmisher),
        typeof(SoothingWords),
        typeof(Spellpower),
        typeof(SpellResistance),
        typeof(StrongWilled),
        typeof(TerrorWings),
        typeof(Unburdened),
        typeof(Unyielding),
        typeof(Vengeance),
        typeof(Vigilance),
        typeof(Wildfire),
        typeof(WishOfDeath)
    ];

    private readonly ISkillSelector next;

    public OncePerSkillTreeValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = this.next.SelectSkill(input);

        if (!Types.Contains(output.SkillType))
        {
            return output;
        }

        var exists = input.Hero.SkillTree.Skills
            .Where(s => s is not null)
            .Any(s => s!.GetType() == output.SkillType);

        if (exists)
        {
            throw new InvalidSkillSelectionException(output.SkillType);
        }

        return output;
    }
}
