namespace Kakt.Modding.Domain.Skills.Strike.Vanguard.Upgrades;

public class DeepCuts : StrikeUpgrade
{
    public DeepCuts()
    {
        Name = nameof(DeepCuts);
        CodeName = "Hero_vanguard__strike_deepCuts";
        Effects = Effects.Bleed;
    }
}
