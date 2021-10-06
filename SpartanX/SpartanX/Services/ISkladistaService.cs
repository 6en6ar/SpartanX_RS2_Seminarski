using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface ISkladistaService 
    {
        List<ModelSpartanX.Skladista> Get(ModelSpartanX.Search.SkladistaSearchObject request);

        ModelSpartanX.Skladista GetById(int id);

        void Insert(ModelSpartanX.Requests.SkladisteInsertRequest request);

        ModelSpartanX.Skladista Update(int id, ModelSpartanX.Requests.SkladisteUpdateRequest request);
    }
}
