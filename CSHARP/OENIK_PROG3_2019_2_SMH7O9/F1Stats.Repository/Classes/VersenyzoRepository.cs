﻿namespace F1Stats.Repository
{
    using System.Linq;
    using F1Stats.Data;

    public class VersenyzoRepository : IVersenyzoRepository
    {
        private F1StatsDatabaseEntities db;

        public VersenyzoRepository(F1StatsDatabaseEntities db)
        {
            this.db = db;
        }

        public void CreateVersenyzo(Versenyzo versenyzo)
        {
            this.db.Versenyzo.Add(versenyzo);
            this.db.SaveChanges();
        }

        public void Deleteversenyzo(int rajtSzam)
        {
            this.db.Versenyzo.Remove(this.GetOne(rajtSzam));
            this.db.SaveChanges();
        }

        public IQueryable<Versenyzo> GetAll()
        {
            return this.db.Versenyzo;
        }

        public Versenyzo GetOne(int rajtSzam)
        {
            return this.db.Versenyzo.Where(x => x.rajtszam == rajtSzam).FirstOrDefault();
        }

        public void UpdateCsapatNev(int rajtSzam, string newCsapatName)
        {
            var versenyzo = this.GetOne(rajtSzam);
            versenyzo.csapat_nev = newCsapatName;
            this.db.SaveChanges();
        }

        public void UpdateEetkor(int rajtSzam, int newEletkor)
        {
            var versenyzo = this.GetOne(rajtSzam);
            versenyzo.eletkor = newEletkor;
            this.db.SaveChanges();
        }

        public void UpdateIdenybeliPont(int rajtSzam, int newIdenybeliPont)
        {
            var versenyzo = this.GetOne(rajtSzam);
            versenyzo.idenybeli_pont = newIdenybeliPont;
            this.db.SaveChanges();
        }

        public void UpdateNev(int rajtSzam, string newName)
        {
            var versenyzo = this.GetOne(rajtSzam);
            versenyzo.nev = newName;
            this.db.SaveChanges();
        }

        public void UpdateOsszPont(int rajtSzam, int newOsszpont)
        {
            var versenyzo = this.GetOne(rajtSzam);
            versenyzo.ossz_pont = newOsszpont;
            this.db.SaveChanges();
        }
    }
}
