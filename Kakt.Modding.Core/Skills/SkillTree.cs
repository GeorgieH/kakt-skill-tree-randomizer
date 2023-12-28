namespace Kakt.Modding.Core.Skills;

public class SkillTree
{
    private readonly Skill?[] skills = new Skill?[20];

    public IEnumerable<Skill?> Skills => skills;

    public IEnumerable<UpgradablePassiveSkill?> UpgradablePassiveSkills =>
    [
        TierOneUpgradablePassiveSkillOne,
        TierTwoUpgradablePassiveSkillOne,
        TierThreeUpgradablePassiveSkillOne,
        TierThreeUpgradablePassiveSkillTwo
    ];

    public IEnumerable<PassiveSkill?> PassiveSkills =>
    [
        TierOnePassiveSkillOne,
        TierOnePassiveSkillTwo,
        TierOnePassiveSkillThree,
        TierTwoPassiveSkillOne,
        TierTwoPassiveSkillTwo,
        TierThreePassiveSkillOne,
        TierThreePassiveSkillTwo,
        TierThreePassiveSkillThree
    ];

    public IEnumerable<ActiveSkill?> StarterSkills =>
    [
        TierOneActiveSkillOne,
        TierOneActiveSkillThree
    ];

    public ActiveSkill? TierOneActiveSkillOne
    {
        get => skills[0] as ActiveSkill;
        set => skills[0] = value;
    }

    public ActiveSkill? TierOneActiveSkillTwo
    {
        get => skills[1] as ActiveSkill;
        set => skills[1] = value;
    }

    public ActiveSkill? TierOneActiveSkillThree
    {
        get => skills[2] as ActiveSkill;
        set => skills[2] = value;
    }

    public ActiveSkill? TierOneActiveSkillFour
    {
        get => skills[3] as ActiveSkill;
        set => skills[3] = value;
    }

    public UpgradablePassiveSkill? TierOneUpgradablePassiveSkillOne
    {
        get => skills[3] as UpgradablePassiveSkill;
        set => skills[3] = value;
    }

    public PassiveSkill? TierOnePassiveSkillOne
    {
        get => skills[4] as PassiveSkill;
        set => skills[4] = value;
    }

    public PassiveSkill? TierOnePassiveSkillTwo
    {
        get => skills[5] as PassiveSkill;
        set => skills[5] = value;
    }

    public PassiveSkill? TierOnePassiveSkillThree
    {
        get => skills[6] as PassiveSkill;
        set => skills[6] = value;
    }

    public ActiveSkill? TierTwoActiveSkillOne
    {
        get => skills[7] as ActiveSkill;
        set => skills[7] = value;
    }

    public ActiveSkill? TierTwoActiveSkillTwo
    {
        get => skills[8] as ActiveSkill;
        set => skills[8] = value;
    }

    public UpgradablePassiveSkill? TierTwoUpgradablePassiveSkillOne
    {
        get => skills[9] as UpgradablePassiveSkill;
        set => skills[9] = value;
    }

    public ActiveSkill? TierTwoActiveSkillThree
    {
        get => skills[10] as ActiveSkill;
        set => skills[10] = value;
    }

    public PassiveSkill? TierTwoPassiveSkillOne
    {
        get => skills[11] as PassiveSkill;
        set => skills[11] = value;
    }

    public PassiveSkill? TierTwoPassiveSkillTwo
    {
        get => skills[12] as PassiveSkill;
        set => skills[12] = value;
    }

    public ActiveSkill? TierThreeActiveSkillOne
    {
        get => skills[13] as ActiveSkill;
        set => skills[13] = value;
    }

    public UpgradablePassiveSkill? TierThreeUpgradablePassiveSkillOne
    {
        get => skills[14] as UpgradablePassiveSkill;
        set => skills[14] = value;
    }

    public UpgradablePassiveSkill? TierThreeUpgradablePassiveSkillTwo
    {
        get => skills[15] as UpgradablePassiveSkill;
        set => skills[15] = value;
    }

    public ActiveSkill? TierThreeActiveSkillTwo
    {
        get => skills[16] as ActiveSkill;
        set => skills[16] = value;
    }

    public PassiveSkill? TierThreePassiveSkillOne
    {
        get => skills[17] as PassiveSkill;
        set => skills[17] = value;
    }

    public PassiveSkill? TierThreePassiveSkillTwo
    {
        get => skills[18] as PassiveSkill;
        set => skills[18] = value;
    }

    public PassiveSkill? TierThreePassiveSkillThree
    {
        get => skills[19] as PassiveSkill;
        set => skills[19] = value;
    }
}
