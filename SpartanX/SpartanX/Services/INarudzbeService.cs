using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface INarudzbeService
    {
        List<ModelSpartanX.Narudzbe> Get(object search);

        ModelSpartanX.Narudzbe GetById(int id);

        public ModelSpartanX.Narudzbe Insert(ModelSpartanX.Requests.NarudzbeInsertRequest request);

        ModelSpartanX.Narudzbe Update(int id, ModelSpartanX.Requests.NarudzbeUpdateRequest request);

    }
}
