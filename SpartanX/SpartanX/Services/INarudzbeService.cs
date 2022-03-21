using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface INarudzbeService
    {
        List<ModelSpartanX.Narudzbe> Get(object search);
        List<ModelSpartanX.Narudzbe> GetNarudzbe(string username, string password, object search);

        ModelSpartanX.Narudzbe GetById(int id);

        void Insert(ModelSpartanX.Requests.NarudzbeInsertRequest request);
        void InsertNarudzba(ModelSpartanX.Requests.NarudzbeInsertRequest request, string username, string password);

        ModelSpartanX.Narudzbe Update(int id, ModelSpartanX.Requests.NarudzbeUpdateRequest request);

    }
}
