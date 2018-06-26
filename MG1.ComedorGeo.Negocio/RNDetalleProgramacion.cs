using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNDetalleProgramacion : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNDetalleProgramacion()
        {
            Esquema = this.TraerContexto();
        }

        public Boolean Insertar(DetalleProgramacion objDetalleProgramacion)
        {
            try
            {
                Esquema.DetalleProgramacion.Add(objDetalleProgramacion);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception f)
            {
                return false;
            }
        }

        public List<VDetalleProgramacion> TraerIdEmp(Int64 id)
        {
            if (id == 0)
            {
                return (from pr in Esquema.VDetalleProgramacion select pr).ToList();
            }
            else
            {
                return (from pr in Esquema.VDetalleProgramacion where pr.idEmpleado == id select pr).ToList();
            }
        }

        public List<VDetalleProgramacion>Traer(Int64 id)
        {
            if (id == 0)
            {
                return (from pr in Esquema.VDetalleProgramacion select pr).ToList();
            }
            else
            {
                return (from pr in Esquema.VDetalleProgramacion where pr.idEmpleado == id select pr).ToList();
            }
        }

        public List<VDetalleProgramacion> TraerDetalle(Int64 id, DateTime Fecha)
        {
            if (id == 0)
            {
                return (from pr in Esquema.VDetalleProgramacion select pr).ToList();
            }
            else
            {
                return (from pr in Esquema.VDetalleProgramacion where pr.idEmpleado == id && pr.FechaInicio <= Fecha && pr.FechaFin >= Fecha select pr).ToList();
            }
        }

    }
}
