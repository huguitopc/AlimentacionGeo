﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNPerfil : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNPerfil()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Perfil select e.id).Max() + 1;
            }
            catch(Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(Perfil objPerfil)
        {
            try
            {
                Esquema.Perfil.Add(objPerfil);
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
                Perfil objPerfil = Esquema.Perfil.FirstOrDefault(a => a.id == id);
                Esquema.Perfil.Remove(objPerfil);
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

        public List<VPerfil> ListaPerfil(string pf)
        {
            if (pf == "")
                return (from e in Esquema.VPerfil orderby e.id select e).ToList();
            else
                return (from e in Esquema.VPerfil where e.NombrePerfil.Contains(pf) orderby e.id select e).ToList();
        }

    }
}
