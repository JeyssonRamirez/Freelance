namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class RolPropiedad
    {
        public int RolPropiedadId { get; set; }
        public int RolId { get; set; }
        public int PropiedadId { get; set; }
    
        public virtual Propiedad Propiedad { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
