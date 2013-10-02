namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Rol
    {
        public Rol()
        {
            this.RolPropiedad = new HashSet<RolPropiedad>();
            this.RolUsuario = new HashSet<RolUsuario>();
        }
    
        public int RolId { get; set; }
        public int AplicacionId { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<RolPropiedad> RolPropiedad { get; set; }
        public virtual ICollection<RolUsuario> RolUsuario { get; set; }
    }
}
