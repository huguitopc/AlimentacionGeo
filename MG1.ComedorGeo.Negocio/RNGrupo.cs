using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNGrupo : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNGrupo()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Grupo select e.id).Max() + 1;
            }
            catch(Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(Grupo objGrupo)
        {
            try
            {
                Esquema.Grupo.Add(objGrupo);
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
                Grupo objGrupo = Esquema.Grupo.FirstOrDefault(a => a.id == id);
                Esquema.Grupo.Remove(objGrupo);
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

        public List<Grupo> ListaGrupo(Int64 idusuario)
        {
            if (idusuario == 0)
                return (from e in Esquema.Grupo select e).ToList();
            else
                return (from e in Esquema.Grupo where e.Usuario.Equals(idusuario) select e).ToList();
        }

    }
}
