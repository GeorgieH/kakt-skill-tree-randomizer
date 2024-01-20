namespace Kakt.Modding.Core.KnightsTale.Skills.PoisonCut;

public class PoisonCut : ActiveSkill
{
    public PoisonCut()
    {
        Name = nameof(PoisonCut);
        CodeName = "SirTristan__poisonCut";
        ConfigurationName = Name;
        Attributes = SkillAttributes.Melee;
        Effects = Effects.Poison;
    }
}
