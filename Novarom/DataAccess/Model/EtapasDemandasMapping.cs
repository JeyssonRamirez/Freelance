namespace App.DataAccess.Model
{
    #pragma warning disable 1573
    using App.Domain.Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class EtapasDemandasMapping : EntityTypeConfiguration<EtapasDemandas>
    {
        public EtapasDemandasMapping()
        {                        
              this.HasKey(t => t.Id);        
              this.ToTable("EtapasDemandas");
              this.Property(t => t.Id).HasColumnName("Id");
              this.Property(t => t.IdEtapa).HasColumnName("IdEtapa");
              this.Property(t => t.IdDemanda).HasColumnName("IdDemanda");
              this.HasRequired(t => t.Etapas).WithMany(t => t.EtapasDemandas).HasForeignKey(d => d.IdEtapa);
         }
    }
}
