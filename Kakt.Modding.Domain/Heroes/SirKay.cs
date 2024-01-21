namespace Kakt.Modding.Domain.Heroes;

public class SirKay : Champion
{
    public SirKay()
    {
        Traits = HeroTraits.Talented;
    }

    public override string Name => nameof(SirKay);
}
