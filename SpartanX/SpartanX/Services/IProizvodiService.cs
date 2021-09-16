using SpartanX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.Services
{
    public interface IProizvodiService : IReadService<Model.Proizvodi, Model.Search.ProizvodiSearchObject>
    {
      
    }
}
