using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNArea : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNArea()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Area select e.id).Max() + 1;
            }
            catch(Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(Area objArea)
        {
            try
            {
                Esquema.Area.Add(objArea);
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
                Area objArea = Esquema.Area.FirstOrDefault(a => a.id == id);
                Esquema.Area.Remove(objArea);
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

        public List<Area> ListaArea(string a)
        {
            if (a == "")
                return (from e in Esquema.Area select e).ToList();
            else
                return (from e in Esquema.Area where e.NombreArea.ToUpper().Contains(a) select e).ToList();
        }

    }
}
