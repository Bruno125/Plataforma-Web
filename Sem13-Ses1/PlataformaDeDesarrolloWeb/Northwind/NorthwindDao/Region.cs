//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindDao
{
    using System;
    using System.Collections.Generic;
    
    public partial class Region
    {
        public Region()
        {
            this.Territories = new HashSet<Territory>();
        }
    
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
