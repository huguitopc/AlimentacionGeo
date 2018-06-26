using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MG1.ComedorGeo.Datos
{
    public class Contexto
    {
        public dbAlimentacionGeoEntities TraerContexto()
        {
            dbAlimentacionGeoEntities con = new dbAlimentacionGeoEntities();
            return con;
        }

    }
}
