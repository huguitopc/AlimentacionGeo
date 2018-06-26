using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MG1.ComedorGeo.Datos;
using MG1.ComedorGeo.Utilitarios;

namespace MG1.ComedorGeo.Negocio
{
    public class RNEmpleado : Contexto
    {
        dbAlimentacionGeoEntities Esquema;

        public RNEmpleado()
        {
            Esquema = this.TraerContexto();
        }

        public Int64 GenerarId()
        {
            try
            {
                return (from e in Esquema.Empleado select e.id).Max() + 1;
            }
            catch(Exception g)
            {
                return 1;
            }
        }

        public Boolean Insertar(Empleado objEmpleado)
        {
            try
            {
                Esquema.Empleado.Add(objEmpleado);
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
                Empleado objEmpleado = Esquema.Empleado.FirstOrDefault(a => a.id == id);

                Esquema.Empleado.Remove(objEmpleado);

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

        public List<VEmpleado> ListaEmpleado(string nom)
        {
            if (nom == "")
                return (from e in Esquema.VEmpleado select e).ToList();
            else
                return (from e in Esquema.VEmpleado where e.NombreCompleto.ToUpper().Contains(nom) select e).ToList();
        }

        public List<VEmpleado> ListaEmpleado(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.VEmpleado select e).ToList();
            else
                return (from e in Esquema.VEmpleado where e.NombreCompleto.Equals(id) select e).ToList();
        }

        public List<VEmpleado> ListaEmpleadoProgramacion(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.VEmpleado select e).ToList();
            else
                return (from e in Esquema.VEmpleado where e.NombreCompleto.Equals(id) select e).ToList();
        }

        public List<VEmpleadoProgramacion> ListaEmpleadoProgramado(Int64 id)
        {
            if (id == 0)
                return (from e in Esquema.VEmpleadoProgramacion select e).ToList();
            else
                //return (from e in Esquema.VEmpleadoProgramacion where e.NombreCompleto.ToUpper().Contains(nom) select e).ToList();
                return (from e in Esquema.VEmpleadoProgramacion where e.id.Equals(id) select e).ToList();
        }

        //public List<VEmpleadoProgramacion> TraerEmpleado(Int64 Cod)
        //{
        //    if (Cod == 0)
        //        return (from e in Esquema.VEmpleadoProgramacion select e).ToList();
        //    else
        //        return (from e in Esquema.VEmpleadoProgramacion where e.CodigoEmpleado.Equals(Cod) select e).ToList();
        //}

        //public List<VEmpleadoProgramacion> TraerEmpleadoNombre(String Nombre)
        //{
        //    if (Nombre == "")
        //        return (from e in Esquema.VEmpleadoProgramacion select e).ToList();
        //    else
        //        return (from e in Esquema.VEmpleadoProgramacion where e.NombreCompleto.ToUpper().Contains(Nombre.ToUpper()) select e).ToList();
        //}

    }
}
