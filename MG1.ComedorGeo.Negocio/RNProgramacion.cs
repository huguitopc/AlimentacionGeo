using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNProgramacion : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNProgramacion()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Programacion select e.id).Max() + 1;
            }
            catch(Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(Programacion objProgramacion)
        {
            try
            {
                Esquema.Programacion.Add(objProgramacion);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception f)
            {
                return false;
            }
        }

        public bool Eliminar(Int64 id)
        {
            try
            {
                Rubro objRubro = Esquema.Rubro.FirstOrDefault(a => a.id == id);
                Esquema.Rubro.Remove(objRubro);
                if (Esquema.SaveChanges() == 1)
                    return true;
                else
                    return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public List<Programacion>Traer(Int64 id)
        {
            if (id == 0)
            {
                return (from pr in Esquema.Programacion select pr).ToList();
            }
            else
            {
                return (from pr in Esquema.Programacion where pr.id == id select pr).ToList();
            }
        }

        //public Int64 TraerId(Int64 id, DateTime dt)
        //{
        //    if (id == 0)
        //    {
        //        return Convert.ToInt64(from pr in Esquema.Programacion select pr);
        //    }
        //    else
        //    {
        //        return Convert.ToInt64(from pr in Esquema.Programacion where pr.FechaInicio == dt select pr);
        //    }
        //}

        public List<Programacion>TraerPorNombre(Int64 id)
        {
            return (from pr in Esquema.Programacion where pr.id == id select pr).ToList();
        }

    }
}
