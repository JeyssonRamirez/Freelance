namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class RolUsuario
    {
        public int RolUsuarioId { get; set; }
        public int UsuarioId { get; set; }
        public int RolId { get; set; }
    
        public virtual Rol Rol { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
