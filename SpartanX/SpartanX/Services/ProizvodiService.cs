using SpartanX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public class ProizvodiService : IProizvodiService
    {
        private static List<Proizvod> proizvodi;
        static ProizvodiService()
        {
            proizvodi = new List<Proizvod>()
            {
                new Proizvod()
                {
                    Id = 0,
                    Naziv = "Protein"
                },
                new Proizvod()
                {
                    Id= 1,
                    Naziv = "BCAA"
                }

            };
        }
        public IEnumerable<Proizvod> Get()
        {
            return proizvodi;
        }
        public Proizvod GetById(int id)
        {
            var pro = proizvodi.FirstOrDefault(x=>x.Id == id);
            return pro;
        }
        public Proizvod Insert(Proizvod proizvod)
        {
            proizvodi.Add(proizvod);
            return proizvod;
            
        }
        public Proizvod Update(int id, Proizvod proizvod)
        {
            var pro = proizvodi.Find(x=>x.Id == id);
            pro.Naziv = proizvod.Naziv;
            return pro;
        }
        public IEnumerable<Proizvod> Delete(int id)
        {
            var pro = proizvodi.Find(x => x.Id == id);
            proizvodi.Remove(pro);
            return proizvodi;
        }
    }
}
