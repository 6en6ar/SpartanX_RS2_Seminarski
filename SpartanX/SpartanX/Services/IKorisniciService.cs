using SpartanX.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IKorisniciService
    {
        public IList<Model.Korisnici> Get();
    }
}
