//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MG1.ComedorGeo.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        public long id { get; set; }
        public string NombrePersona { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Sexo { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public long DocumentoIdentidad { get; set; }
        public string NombreCompleto { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        public virtual RepresentanteLegal RepresentanteLegal { get; set; }
    }
}
