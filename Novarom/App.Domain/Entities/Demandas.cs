namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Demandas
    {
        public Demandas()
        {
            this.DamandasAbogados = new HashSet<DamandasAbogados>();
        }
    
        public int IdDemanda { get; set; }
        public int IdUsuario { get; set; }
        public string NombreDemanda { get; set; }
        public Nullable<System.DateTime> FechaRadicacion { get; set; }
        public Nullable<System.DateTime> FechaAdicion { get; set; }
        public string NumeroProceso { get; set; }
        public Nullable<System.DateTime> Fechacontestacion { get; set; }
        public string UsuarioCrea { get; set; }
        public System.DateTime FechaCrea { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual ICollection<DamandasAbogados> DamandasAbogados { get; set; }
    }
}
