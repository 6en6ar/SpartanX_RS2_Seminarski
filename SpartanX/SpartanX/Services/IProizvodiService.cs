using SpartanX.Model.Requests;
using SpartanX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IProizvodiService : ICRUDService<ModelSpartanX.Proizvodi, ModelSpartanX.Search.ProizvodiSearchObject, ModelSpartanX.Requests.ProizvodiInsertRequest, ModelSpartanX.Requests.ProizvodiUpdateRequest>
    {
        public List<ModelSpartanX.Proizvodi> Recommend(int id);
    }
}
