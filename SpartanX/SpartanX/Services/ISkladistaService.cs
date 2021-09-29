using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface ISkladistaService 
    {
        List<Model.Skladista> Get(Model.Search.SkladistaSearchObject request);

        Model.Skladista GetById(int id);

        void Insert(Model.Requests.SkladisteInsertRequest request);

        Model.Skladista Update(int id, Model.Requests.SkladisteUpdateRequest request);
    }
}
