namespace Kakt.Modding.Domain.Heroes;

public class SirBedievere : Vanguard
{
    public SirBedievere()
    {
        Traits = HeroTraits.Talented;
    }

    public override string Name => nameof(SirBedievere);
}
