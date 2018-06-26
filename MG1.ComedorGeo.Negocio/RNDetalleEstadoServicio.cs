using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNDetalleEstadoServicio : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNDetalleEstadoServicio()
        {
            Esquema = this.TraerContexto();
        }

        public Boolean Insertar(DetalleEstadoServicio objDetalleEstadoServicio)
        {
            try
            {
                Esquema.DetalleEstadoServicio.Add(objDetalleEstadoServicio);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception f)
            {
                return false;
            }
        }

        public List<DetalleEstadoServicio> Traer(Int64 id)
        {
            if (id == 0)
            {
                return (from pr in Esquema.DetalleEstadoServicio select pr).ToList();
            }
            else
            {
                return (from pr in Esquema.DetalleEstadoServicio where pr.idEmpleado == id select pr).ToList();
            }
        }

    }
}
