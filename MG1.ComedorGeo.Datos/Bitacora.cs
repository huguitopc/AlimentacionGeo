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
    
    public partial class Bitacora
    {
        public long id { get; set; }
        public string Transaccion { get; set; }
        public string Tabla { get; set; }
        public Nullable<long> idTabla { get; set; }
        public long idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string Host { get; set; }
        public string Aplicacion { get; set; }
        public Nullable<System.DateTime> Modificado { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
