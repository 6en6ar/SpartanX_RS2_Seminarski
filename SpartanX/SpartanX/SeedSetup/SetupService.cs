using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpartanX.SeedSetup
{
    public class SetupService
    {
        public void Init(SpartanX.Database.SpartanXContext context)
        {
            //context.Database.Migrate();
            //dodavanje podataka
        }
    }
}
