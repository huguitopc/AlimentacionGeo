using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNEmpresa : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNEmpresa()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Empresa select e.id).Max() + 1;
            }
            catch(Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(Empresa objEmpresa)
        {
            try
            {
                Esquema.Empresa.Add(objEmpresa);
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
                Empresa objEmpresa = Esquema.Empresa.FirstOrDefault(a => a.id == id);

                Esquema.Empresa.Remove(objEmpresa);

                if (Esquema.SaveChanges() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<VEmpleado> ListaEmpleado(Int64 Cod)
        {
            if (Cod == 0)
                return (from e in Esquema.VEmpleado select e).ToList();
            else
                return (from e in Esquema.VEmpleado where e.id.Equals(Cod) select e).ToList();
        }

    }
}
