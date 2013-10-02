namespace App.Domain.Entities
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class EtapasDemandas
    {
        public int Id { get; set; }
        public int IdEtapa { get; set; }
        public int IdDemanda { get; set; }
    
        public virtual Etapas Etapas { get; set; }
    }
}
