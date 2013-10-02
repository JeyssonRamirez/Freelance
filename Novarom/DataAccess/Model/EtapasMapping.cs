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
    
    internal partial class EtapasMapping : EntityTypeConfiguration<Etapas>
    {
        public EtapasMapping()
        {                        
              this.HasKey(t => t.IdEtapa);        
              this.ToTable("Etapas");
              this.Property(t => t.IdEtapa).HasColumnName("IdEtapa");
              this.Property(t => t.Nombre).HasColumnName("Nombre").IsRequired().HasMaxLength(50);
              this.Property(t => t.FechaCreate).HasColumnName("FechaCreate");
         }
    }
}
