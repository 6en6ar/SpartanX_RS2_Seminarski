using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IDobavljaciService : ICRUDService<ModelSpartanX.Dobavljaci, ModelSpartanX.Search.DobavljaciSearchObject, ModelSpartanX.Requests.DobavljaciInsertRequest, object>
    {
    }
}
