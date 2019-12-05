namespace F1Stats.Logic
{
    using System.Collections.Generic;
    using System.Linq;
    using F1Stats.Data;
    using F1Stats.Repository;

    public class VersenyzoLogic : IVersenyzoLogic
    {
        public IVersenyzoRepository versenyzoRepo;

        public VersenyzoLogic()
        {
            this.versenyzoRepo = new VersenyzoRepository(new F1StatsDatabaseEntities());
        }

        public VersenyzoLogic(IVersenyzoRepository repo)
        {
            this.versenyzoRepo = repo;
        }

        public IList<Versenyzo> GetAllVersenyzo()
        {
            return this.versenyzoRepo.GetAll().ToList();
        }

        public Versenyzo GetOneVersenyzo(int rajtszam)
        {
            return this.versenyzoRepo.GetOne(rajtszam);
        }

        public void DeleteVersenyzo(int rajtSzam)
        {
            this.versenyzoRepo.Deleteversenyzo(rajtSzam);
        }

        public void CreateVersenyzo(Versenyzo versenyzo)
        {
            this.versenyzoRepo.CreateVersenyzo(versenyzo);
        }
    }
}
