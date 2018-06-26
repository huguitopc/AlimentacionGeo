using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNPersona : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNPersona()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Persona select e.id).Max() + 1;
            }
            catch (Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(Persona objPersona)
        {
            try
            {
                Esquema.Persona.Add(objPersona);
                return Esquema.SaveChanges() == 1;
            }
            catch (Exception f)
            {
                return false;
            }
        }

        public String TraerNombre(Int64 id)
        {
            try
            {
                return (from e in Esquema.Persona where e.id == id select e.NombrePersona).ToString();
            }
            catch (Exception g)
            {
                return "";
            }
        }

        public Int64 TraerID(string nom)
        {
            try
            {
                return Convert.ToInt64(from e in Esquema.Persona where e.NombreCompleto.ToUpper().StartsWith(nom.ToUpper()) select e.id);
            }
            catch (Exception g)
            {
                return 0;
            }
        }

        public List<VEmpleadoProgramacion> ListaNombreCompleto(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.VEmpleadoProgramacion select e).ToList();
            else
                return (from e in Esquema.VEmpleadoProgramacion where e.id.Equals(id) select e).ToList();
        }

        public string NombrePersona(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.Persona select e).FirstOrDefault().ToString();
            else
                return (from e in Esquema.Persona where e.id.Equals(id) select e.NombrePersona).FirstOrDefault().ToString();
        }

        public string ApellidoPaterno(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.Persona select e).FirstOrDefault().ToString();
            else
                return (from e in Esquema.Persona where e.id.Equals(id) select e.ApellidoPaterno).FirstOrDefault().ToString();
        }

        public string ApellidoMaterno(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.Persona select e).FirstOrDefault().ToString();
            else
                return (from e in Esquema.Persona where e.id.Equals(id) select e.ApellidoMaterno).FirstOrDefault().ToString();
        }

        public string Sexo(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.Persona select e).FirstOrDefault().ToString();
            else
                return (from e in Esquema.Persona where e.id.Equals(id) select e.Sexo).FirstOrDefault().ToString();
        }

        public DateTime FechaNacimiento(Int64 id)
        {
            if (id == 0)
                return Convert.ToDateTime((from e in Esquema.Persona select e).FirstOrDefault());
            else
                return Convert.ToDateTime((from e in Esquema.Persona where e.id.Equals(id) select e.FechaNacimiento).FirstOrDefault());
        }

        public Int64 DocumentoIdentidad(Int64 id)
        {
            if (id == 0)
                return Convert.ToInt64((from e in Esquema.Persona select e).FirstOrDefault());
            else
                return Convert.ToInt64((from e in Esquema.Persona where e.id.Equals(id) select e.DocumentoIdentidad).FirstOrDefault());
        }

    }
}
