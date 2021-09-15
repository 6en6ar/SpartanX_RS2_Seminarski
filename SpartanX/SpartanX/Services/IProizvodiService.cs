using SpartanX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IProizvodiService//<T> where T:class
    {
        IEnumerable<Proizvod> Get();
        public Proizvod GetById(int id);
        public Proizvod Insert(Proizvod proizvod);
        public Proizvod Update(int id, Proizvod proizvod);
        IEnumerable<Proizvod> Delete(int id);
    }
}
