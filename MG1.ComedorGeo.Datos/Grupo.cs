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
    
    public partial class Grupo
    {
        public Grupo()
        {
            this.GrupoPerfil = new HashSet<GrupoPerfil>();
            this.Usuario = new HashSet<Usuario>();
        }
    
        public long id { get; set; }
        public string NombreGrupo { get; set; }
    
        public virtual ICollection<GrupoPerfil> GrupoPerfil { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
