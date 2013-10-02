namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Etapas
    {
        public Etapas()
        {
            this.EtapasDemandas = new HashSet<EtapasDemandas>();
        }
    
        public int IdEtapa { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaCreate { get; set; }
    
        public virtual ICollection<EtapasDemandas> EtapasDemandas { get; set; }
    }
}
