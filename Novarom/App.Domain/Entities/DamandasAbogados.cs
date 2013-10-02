namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class DamandasAbogados
    {
        public int IdDemandaAbogado { get; set; }
        public int IdAbogado { get; set; }
        public int IdDemanda { get; set; }
        public string UsuarioCrea { get; set; }
        public System.DateTime FechaCrea { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual Abogados Abogados { get; set; }
        public virtual Demandas Demandas { get; set; }
    }
}
