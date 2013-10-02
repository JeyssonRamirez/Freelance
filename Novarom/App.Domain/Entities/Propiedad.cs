namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Propiedad
    {
        public Propiedad()
        {
            this.RolPropiedad = new HashSet<RolPropiedad>();
            this.ValorPropiedad = new HashSet<ValorPropiedad>();
        }
    
        public int PropiedadId { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
    
        public virtual ICollection<RolPropiedad> RolPropiedad { get; set; }
        public virtual ICollection<ValorPropiedad> ValorPropiedad { get; set; }
    }
}
