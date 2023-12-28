namespace Kakt.Modding.Core.Heroes;

public static class Heroes
{
    public static IEnumerable<Hero> GetAll()
    {
        return new HashSet<Hero>
        {
            new BlackKnight(),
            new FaerieKnight(),
            new LadyBoudicea(),
            new LadyDindraine(),
            new LadyGuinevere(),
            new LadyIsolde(),
            new LadyMorganaLeFay(),
            new LadyMorgawse(),
            new Merlin(),
            new RedKnight(),
            new SirBalan(),
            new SirBalin(),
            new SirBedievere(),
            new SirBors(),
            new SirBrunorLeNoir(),
            new SirDagonet(),
            new SirDamas(),
            new SirEctor(),
            new SirGalahad(),
            new SirGawain(),
            new SirGeraint(),
            new SirKay(),
            new SirLancelot(),
            new SirLanval(),
            new SirLeodegrance(),
            new SirLucan(),
            new SirMordred(),
            new SirPelleas(),
            new SirPercival(),
            new SirTegyr(),
            new SirTristan(),
            new SirYvain(),
            new WhiteKnight()
        };
    }
}
