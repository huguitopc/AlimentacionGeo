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
    
    public partial class Ingrediente
    {
        public Ingrediente()
        {
            this.DetalleAlimento = new HashSet<DetalleAlimento>();
        }
    
        public long id { get; set; }
        public string NombreIngrediente { get; set; }
        public double Calorias { get; set; }
    
        public virtual ICollection<DetalleAlimento> DetalleAlimento { get; set; }
    }
}
