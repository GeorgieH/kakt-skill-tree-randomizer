namespace Kakt.Modding.Domain.Skills.Strike.Vanguard.Upgrades;

public class PoisonedBlade : StrikeUpgrade
{
    public PoisonedBlade()
    {
        Name = nameof(PoisonedBlade);
        CodeName = "Hero_vanguard__strike_poisonedBlade";
        Effects = Effects.Poison;
    }
}
