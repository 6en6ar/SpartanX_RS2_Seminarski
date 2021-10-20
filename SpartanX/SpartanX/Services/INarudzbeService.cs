using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface INarudzbeService : ICRUDService<ModelSpartanX.Narudzbe, object, ModelSpartanX.Requests.NarudzbeInsertRequest, ModelSpartanX.Requests.NarudzbeUpdateRequest>
    {

    }
}
