using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNEstado : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNEstado()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Estado select e.id).Max() + 1;
            }
            catch(Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(Estado objEstadoProgramacion)
        {
            try
            {
                Esquema.Estado.Add(objEstadoProgramacion);
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
                Estado objEstadoProgramacion = Esquema.Estado.FirstOrDefault(a => a.id == id);
                Esquema.Estado.Remove(objEstadoProgramacion);
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

        public Int64 BuscarEstado(string Estado)
        {
            try
            {
                return Int64.Parse((from e in Esquema.Estado where e.NombreEstado.Equals(Estado) select e.id).ToString());
            }
            catch (Exception f)
            {
                return -1;
            }
        }

        public List<Estado> ListaEstado(string nom)
        {
            if (nom == "")
                return (from e in Esquema.Estado select e).ToList();
            else
                return (from e in Esquema.Estado where e.NombreEstado.ToUpper().Contains(nom) select e).ToList();
        }

    }
}
