namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class ValorPropiedad
    {
        public int UsuarioId { get; set; }
        public int PropiedadId { get; set; }
        public string Valor { get; set; }
    
        public virtual Propiedad Propiedad { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
