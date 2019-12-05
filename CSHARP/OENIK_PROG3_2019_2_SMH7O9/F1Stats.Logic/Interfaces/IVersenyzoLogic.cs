namespace F1Stats.Logic
{
    using System.Collections.Generic;
    using F1Stats.Data;

    public interface IVersenyzoLogic
    {
        Versenyzo GetOneVersenyzo(int rajtszam);

        IList<Versenyzo> GetAllVersenyzo();
    }
}
