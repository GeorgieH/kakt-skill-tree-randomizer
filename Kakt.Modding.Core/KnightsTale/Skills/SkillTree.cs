namespace Kakt.Modding.Core.KnightsTale.Skills;

public class SkillTree
{
    private readonly Skill?[] skills = new Skill?[20];

    public IEnumerable<Skill> Skills => skills.Where(s => s is not null)!;

    public IEnumerable<Skill?> UpgradablePassiveSkills =>
    [
        TierOneUpgradablePassiveSkillOne,
        TierTwoUpgradablePassiveSkillOne,
        TierThreeUpgradablePassiveSkillOne,
        TierThreeUpgradablePassiveSkillTwo
    ];

    public IEnumerable<Skill?> PassiveSkills =>
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

    public IEnumerable<Skill?> StarterSkills =>
    [
        TierOneActiveSkillOne,
        TierOneActiveSkillThree
    ];

    public Skill? TierOneActiveSkillOne
    {
        get => skills[0];
        set => skills[0] = value;
    }

    public Skill? TierOneActiveSkillTwo
    {
        get => skills[1];
        set => skills[1] = value;
    }

    public Skill? TierOneActiveSkillThree
    {
        get => skills[2];
        set => skills[2] = value;
    }

    public Skill? TierOneActiveSkillFour
    {
        get => skills[3];
        set => skills[3] = value;
    }

    public Skill? TierOneUpgradablePassiveSkillOne
    {
        get => skills[3];
        set => skills[3] = value;
    }

    public Skill? TierOnePassiveSkillOne
    {
        get => skills[4];
        set => skills[4] = value;
    }

    public Skill? TierOnePassiveSkillTwo
    {
        get => skills[5];
        set => skills[5] = value;
    }

    public Skill? TierOnePassiveSkillThree
    {
        get => skills[6];
        set => skills[6] = value;
    }

    public Skill? TierTwoActiveSkillOne
    {
        get => skills[7];
        set => skills[7] = value;
    }

    public Skill? TierTwoActiveSkillTwo
    {
        get => skills[8];
        set => skills[8] = value;
    }

    public Skill? TierTwoUpgradablePassiveSkillOne
    {
        get => skills[9];
        set => skills[9] = value;
    }

    public Skill? TierTwoActiveSkillThree
    {
        get => skills[10];
        set => skills[10] = value;
    }

    public Skill? TierTwoPassiveSkillOne
    {
        get => skills[11];
        set => skills[11] = value;
    }

    public Skill? TierTwoPassiveSkillTwo
    {
        get => skills[12];
        set => skills[12] = value;
    }

    public Skill? TierThreeActiveSkillOne
    {
        get => skills[13];
        set => skills[13] = value;
    }

    public Skill? TierThreeUpgradablePassiveSkillOne
    {
        get => skills[14];
        set => skills[14] = value;
    }

    public Skill? TierThreeUpgradablePassiveSkillTwo
    {
        get => skills[15];
        set => skills[15] = value;
    }

    public Skill? TierThreeActiveSkillTwo
    {
        get => skills[16];
        set => skills[16] = value;
    }

    public Skill? TierThreePassiveSkillOne
    {
        get => skills[17];
        set => skills[17] = value;
    }

    public Skill? TierThreePassiveSkillTwo
    {
        get => skills[18];
        set => skills[18] = value;
    }

    public Skill? TierThreePassiveSkillThree
    {
        get => skills[19];
        set => skills[19] = value;
    }
}
