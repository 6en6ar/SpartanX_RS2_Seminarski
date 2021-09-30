using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IDobavljaciService : ICRUDService<Model.Dobavljaci, Model.Search.DobavljaciSearchObject, Model.Requests.DobavljaciInsertRequest, object>
    {
    }
}
