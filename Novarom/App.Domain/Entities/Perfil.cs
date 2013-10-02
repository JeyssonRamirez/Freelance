namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Perfil
    {
        public int PerfilId { get; set; }
        public int AplicacionId { get; set; }
        public int UsuarioId { get; set; }
        public System.DateTime UltimaActividad { get; set; }
        public System.DateTime UltimaActualizacion { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
