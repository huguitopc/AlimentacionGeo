using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNOrdenServicio : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNOrdenServicio()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.OrdenServicio select e.id).Max() + 1;
            }
            catch (Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(OrdenServicio objOrdenServicio)
        {
            try
            {
                Esquema.OrdenServicio.Add(objOrdenServicio);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception f)
            {
                return false;
            }
        }

        public List<OrdenServicio> Traer(Int64 id)
        {
            if (id == 0)
            {
                return (from e in Esquema.OrdenServicio select e).ToList();
            }
            else
            {
                return (from e in Esquema.OrdenServicio where e.id == id select e).ToList();
            }
        }

    }
}
