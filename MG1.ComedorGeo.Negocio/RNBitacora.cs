using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNBitacora : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNBitacora()
        {
            Esquema = this.TraerContexto();
        }

        public List<Bitacora> MostrarBitacora(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.Bitacora select e).ToList();
            else
                return (from e in Esquema.Bitacora where e.idUsuario.Equals(id) select e).ToList();
        }

    }
}
