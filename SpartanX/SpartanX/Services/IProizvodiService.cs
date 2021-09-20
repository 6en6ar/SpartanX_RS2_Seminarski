using SpartanX.Model.Requests;
using SpartanX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IProizvodiService : ICRUDService<Model.Proizvodi, Model.Search.ProizvodiSearchObject, ProizvodiInsertRequest, ProizvodiUpdateRequest>
    {
      
    }
}
