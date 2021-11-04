using SpartanX.Model.Requests;
using SpartanX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IProizvodiService 
    {
        public List<ModelSpartanX.Proizvodi> Recommend(int id);
        List<ModelSpartanX.Proizvodi> Get(ModelSpartanX.Search.ProizvodiSearchObject request);

        ModelSpartanX.Proizvodi GetById(int id);

        ModelSpartanX.Proizvodi Insert(ModelSpartanX.Requests.ProizvodiInsertRequest request);

        ModelSpartanX.Proizvodi Update(int id, ModelSpartanX.Requests.ProizvodiUpdateRequest request);
    }
}
