using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IKorisniciService : ICRUDService<Model.Korisnici, Model.Search.KorisniciSearchObject, object, object>
    {

    }
}
