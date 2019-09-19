using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using VR4.Ejercicio.WebApp.Models;

namespace VR4.Ejercicio.WebApp.DAL
{
    class VR4Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<VR4Context>
    {
        protected override void Seed(VR4Context context)
        {
        }
    }
}