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
    
    public partial class Perfil
    {
        public Perfil()
        {
            this.GrupoPerfil = new HashSet<GrupoPerfil>();
        }
    
        public long id { get; set; }
        public string NombrePerfil { get; set; }
    
        public virtual ICollection<GrupoPerfil> GrupoPerfil { get; set; }
    }
}
