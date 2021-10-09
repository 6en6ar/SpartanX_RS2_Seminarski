using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IKorisniciService
    {
        List<ModelSpartanX.Korisnici> Get(ModelSpartanX.Search.KorisniciSearchObject request);

        ModelSpartanX.Korisnici GetById(int id);

        ModelSpartanX.Korisnici Insert(ModelSpartanX.Requests.KorisniciInsertRequest request);

        ModelSpartanX.Korisnici Update(int id, ModelSpartanX.Requests.KorisniciUpdateRequest request);
        Task<ModelSpartanX.Korisnici> Authenticate(string username, string password);

    }
}
