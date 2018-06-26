using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNAlimento : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNAlimento()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Alimento select e.id).Max() + 1;
            }
            catch (Exception g)
            {
                return 1;
            }
        }

        //public Boolean Insertar(Alimentacion objAlimentacion)
        //{
        //    try
        //    {
        //        Esquema.Alimentacion.Add(objAlimentacion);
        //        return Esquema.SaveChanges() == 1;
        //    }
        //    catch (Exception f)
        //    {
        //        return false;
        //    }
        //}

        public List<Alimento> ListaAlimento(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.Alimento select e).ToList();
            else
                return (from e in Esquema.Alimento where e.id.Equals(id) select e).ToList();
        }

        public List<VAlimentoProgramacion> ListaAlimentoMenu(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.VAlimentoProgramacion select e).ToList();
            else
                return (from e in Esquema.VAlimentoProgramacion where e.id.Equals(id) select e).ToList();
        }
        public List<VDetalleEstadoServicio> TraerDatos(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.VDetalleEstadoServicio select e).ToList();
            else
                return (from e in Esquema.VDetalleEstadoServicio where e.idEmpleado.Equals(id) select e).ToList();
        }
    }
}
