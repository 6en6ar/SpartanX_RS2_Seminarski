using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IKupciService
    {

        List<ModelSpartanX.Kupci> Get(ModelSpartanX.Search.KupciSearchObject request);
        List<ModelSpartanX.Kupci> GetKupce(ModelSpartanX.Search.KupciSearchObject request, string username, string password);

        ModelSpartanX.Kupci GetById(int id);

        ModelSpartanX.Kupci Insert(ModelSpartanX.Requests.KupciInsertRequest request);

        ModelSpartanX.Kupci Update(int id, ModelSpartanX.Requests.KupciUpdateRequest request, string username, string password);
        ModelSpartanX.Kupci Authenticate(string username, string password);
    }
}
