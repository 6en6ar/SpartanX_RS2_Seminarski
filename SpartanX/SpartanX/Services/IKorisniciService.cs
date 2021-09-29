using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> Get(Model.Search.KorisniciSearchObject request);

        Model.Korisnici GetById(int id);

        Model.Korisnici Insert(Model.Requests.KorisniciInsertRequest request);

        Model.Korisnici Update(int id, Model.Requests.KorisniciInsertRequest request);
        public Task<Model.Korisnici> Authenticate(string username, string password);

    }
}
