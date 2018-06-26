using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNUsuario:Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNUsuario()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Usuario select e.id).Max() + 1;
            }
            catch(Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(Usuario objUsuario)
        {
            try
            {
                Esquema.Usuario.Add(objUsuario);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception f)
            {
                return false;
            }
        }

        public Boolean ExisteUsuario(Usuario objUsuario)
        {
            try
            {
                
                if ((from e in Esquema.Usuario where e.Contraseña.Equals(objUsuario.Contraseña) && e.NombreUsuario.ToUpper().StartsWith(objUsuario.NombreUsuario.ToUpper()) select e).Count() > 0)
                    return (from e in Esquema.Usuario where e.NombreUsuario.StartsWith(objUsuario.NombreUsuario) select e).Count() > 0;
                else
                    return false;
            }
            catch(Exception f)
            {
                return false;
            }
        }


        public Int64 ExisteUsuarioId(string Nombre)
        {
            try
            {
                var codigo = (from e in Esquema.Usuario where e.NombreUsuario.ToUpper().Equals(Nombre.ToUpper()) select e.id).FirstOrDefault();
                return Convert.ToInt64(codigo);
            }
            catch (Exception f)
            {
                return -1;
            }
        }

        public string ExisteUsuarioNombre(string Nombre)
        {
            try
            {
                return (from e in Esquema.Usuario where e.NombreUsuario.ToUpper().Equals(Nombre.ToUpper()) select e.NombreUsuario).ToString();
            }
            catch (Exception f)
            {
                return "";
            }
        }

        public Int64 TraerGrupoUsuario(Int64 id)
        {
            if (id == 0)
                return Convert.ToInt64((from e in Esquema.Usuario select e.idGrupo).FirstOrDefault());
            else
                return Convert.ToInt64((from e in Esquema.Usuario where e.id.Equals(id) select e.idGrupo).FirstOrDefault());
        }

        public String TraerGrupoUsuarioN(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.Usuario select e.idGrupo).FirstOrDefault().ToString();
            else
                return (from e in Esquema.Usuario where e.id.Equals(id) select e.idGrupo).FirstOrDefault().ToString();
        }

        public String TraerUsuario(Int64 id)
        {
            try
            {
                return (from e in Esquema.Usuario where e.id == id select e.NombreUsuario).ToString();
            }
            catch (Exception g)
            {
                return "";
            }
        }

        public List<Usuario> ListaUsuario(Int64 us)
        {
            if (us == 0)
                return (from e in Esquema.Usuario select e).ToList();
            else
                return (from e in Esquema.Usuario where e.idGrupo.Equals(us) select e).ToList();
        }

    }
}
