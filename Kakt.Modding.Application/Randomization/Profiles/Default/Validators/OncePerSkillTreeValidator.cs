namespace Kakt.Modding.Application.Randomization.Profiles.Default.Validators;

public class OncePerSkillTreeValidator : ISkillSelector
{
    private static readonly HashSet<string> Skills =
    [
        SkillNames.Adrenaline,
        SkillNames.Alchemist,
        SkillNames.AllResistance,
        SkillNames.Armourer,
        SkillNames.Assassination,
        SkillNames.AuraOfProtection,
        SkillNames.Backstab,
        SkillNames.BitterDread,
        SkillNames.CounterAttack,
        SkillNames.CoverExpert,
        SkillNames.DamageFocus,
        SkillNames.DazingStrikes,
        SkillNames.Dedication,
        SkillNames.Deflection,
        SkillNames.Divine,
        SkillNames.Dodge,
        SkillNames.Evasion,
        SkillNames.ExtraAreaDamage,
        SkillNames.ExtraBleeding,
        SkillNames.ExtraDamage,
        SkillNames.ExtraStun,
        SkillNames.Favoured,
        SkillNames.FirstShot,
        SkillNames.FrostArmour,
        SkillNames.HardenedArmour,
        SkillNames.Hunter,
        SkillNames.Ironclad,
        SkillNames.IronSkinned,
        SkillNames.Juggernaut,
        SkillNames.LoneWolf,
        SkillNames.LongReach,
        SkillNames.ArcanistLongReach,
        SkillNames.LowProfile,
        SkillNames.MagicalArmour,
        SkillNames.MasterAlchemist,
        SkillNames.MasterAssassin,
        SkillNames.MasterBleeding,
        SkillNames.MasterInvoker,
        SkillNames.MasterOfFire,
        SkillNames.MasterOfHexes,
        SkillNames.MasterOfIce,
        SkillNames.MasterOfLightning,
        SkillNames.MasterOfPotions,
        SkillNames.MasterOfTraps,
        SkillNames.MeleeExpertise,
        SkillNames.MentalGuard,
        SkillNames.MindStorm,
        SkillNames.MonsterHunter,
        SkillNames.Mysticism,
        SkillNames.OnTheProwl,
        SkillNames.PotentHex,
        SkillNames.Pyromania,
        SkillNames.QuickCurse,
        SkillNames.QuickFooted,
        SkillNames.Rage,
        SkillNames.Ready,
        SkillNames.Ruthlessness,
        SkillNames.Sentinel,
        SkillNames.SerratedTraps,
        SkillNames.ShieldBlock,
        SkillNames.Skirmisher,
        SkillNames.SoothingWords,
        SkillNames.Spellpower,
        SkillNames.SpellResistance,
        SkillNames.StrongWilled,
        SkillNames.TerrorWings,
        SkillNames.Unburdened,
        SkillNames.Unyielding,
        SkillNames.Vengeance,
        SkillNames.Vigilance,
        SkillNames.Wildfire,
        SkillNames.WishOfDeath
    ];

    private readonly ISkillSelector next;

    public OncePerSkillTreeValidator(ISkillSelector next)
    {
        this.next = next;
    }

    public SkillSelectorOutput SelectSkill(SkillSelectorInput input)
    {
        var output = this.next.SelectSkill(input);

        if (!Skills.Contains(output.Skill.Name))
        {
            return output;
        }

        var exists = input.Hero.SkillTree.Skills.Any(output.Skill.Equals);

        if (exists)
        {
            throw new InvalidSkillSelectionException(output.Skill);
        }

        return output;
    }
}
