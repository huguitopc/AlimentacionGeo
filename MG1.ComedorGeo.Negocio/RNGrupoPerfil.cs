using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNGrupoPerfil : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNGrupoPerfil()
        {
            Esquema = this.TraerContexto();
        }

        public Boolean Insertar(VGrupoPerfil objGrupoPerfil)
        {
            try
            {
                Esquema.VGrupoPerfil.Add(objGrupoPerfil);
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
                VGrupoPerfil objGrupoPerfil = Esquema.VGrupoPerfil.FirstOrDefault(a => a.idGrupo == id);
                Esquema.VGrupoPerfil.Remove(objGrupoPerfil);
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

        public Int64 ExistePerfil(Int64 g, Int64 p)
        {
            try
            {
                return Convert.ToInt64((from e in Esquema.GrupoPerfil where e.idGrupo.Equals(g) && e.idPerfil.Equals(p) select e.Flag).FirstOrDefault());
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public Boolean ExisteMenu(Int64 id)
        {
            try
            {
                return (from e in Esquema.VGrupoPerfil where e.idGrupo.Equals(id) && e.idPerfil.Equals(2) select e.idPerfil).Count() > 0;
            }
            catch (Exception g)
            {
                return false;
            }
        }

        public Boolean ExisteProgramacion(Int64 id)
        {
            try
            {
                return (from e in Esquema.VGrupoPerfil where e.idGrupo.Equals(id) && e.idPerfil.Equals(3) select e.idPerfil).Count() > 0;
            }
            catch (Exception g)
            {
                return false;
            }
        }

        public Boolean ExisteUsuario(Int64 id)
        {
            try
            {
                return (from e in Esquema.VGrupoPerfil where e.idGrupo.Equals(id) && e.idPerfil.Equals(4) select e.idPerfil).Count() > 0;
            }
            catch (Exception g)
            {
                return false;
            }
        }
        public Boolean ExisteReporte(Int64 id)
        {
            try
            {
                return (from e in Esquema.VGrupoPerfil where e.idGrupo.Equals(id) && e.idPerfil.Equals(5) select e.idPerfil).Count() > 0;
            }
            catch (Exception g)
            {
                return false;
            }
        }

        public List<VGrupoPerfil> ListaGrupoPerfil(string gr)
        {
            if (gr == "")
                return (from e in Esquema.VGrupoPerfil select e).ToList();
            else
                return (from e in Esquema.VGrupoPerfil where e.idGrupo.Equals(gr) select e).ToList();
        }

    }
}
