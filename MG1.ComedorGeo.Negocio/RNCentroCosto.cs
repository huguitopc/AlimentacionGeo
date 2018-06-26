using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNCentroCosto : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        //public int id
        //{
        //    get { return this.id; }
        //    set { this.id = value; }
        //}

        //public string NombreCentroCosto
        //{
        //    get { return this.NombreCentroCosto; }
        //    set { this.NombreCentroCosto = value; }
        //}

        public RNCentroCosto()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.CentroCosto select e.id).Max() + 1;
            }
            catch(Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(CentroCosto objCentroCosto)
        {
            try
            {
                Esquema.CentroCosto.Add(objCentroCosto);
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
                CentroCosto objCentroCosto = Esquema.CentroCosto.FirstOrDefault(a => a.id == id);
                Esquema.CentroCosto.Remove(objCentroCosto);
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

        //public DataTable TraerDatos()
        //{
        //    if (Cod == 0)
        //        return (from e in Esquema.VCentroCosto select e).ToList();
        //    else
        //        return (from e in Esquema.VCentroCosto where e.idArea.Equals(Cod) select e).ToList();
        //}

        public List<VCentroCosto> ListaCentro(Int64 Cod)
        {
            if (Cod == 0)
                return (from e in Esquema.VCentroCosto select e).ToList();
            else
                return (from e in Esquema.VCentroCosto where e.idArea.Equals(Cod) select e).ToList();
        }

    }
}
