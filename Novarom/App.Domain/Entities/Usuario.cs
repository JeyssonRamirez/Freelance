namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Membresia = new HashSet<Membresia>();
            this.Perfil = new HashSet<Perfil>();
            this.RolUsuario = new HashSet<RolUsuario>();
            this.ValorPropiedad = new HashSet<ValorPropiedad>();
        }
    
        public int UsuarioId { get; set; }
        public System.Guid ProviderUserKey { get; set; }
        public string Login { get; set; }
    
        public virtual ICollection<Membresia> Membresia { get; set; }
        public virtual ICollection<Perfil> Perfil { get; set; }
        public virtual ICollection<RolUsuario> RolUsuario { get; set; }
        public virtual ICollection<ValorPropiedad> ValorPropiedad { get; set; }
    }
}
