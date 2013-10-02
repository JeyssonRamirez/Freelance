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
    
    internal partial class DamandasAbogadosMapping : EntityTypeConfiguration<DamandasAbogados>
    {
        public DamandasAbogadosMapping()
        {                        
              this.HasKey(t => t.IdDemandaAbogado);        
              this.ToTable("DamandasAbogados");
              this.Property(t => t.IdDemandaAbogado).HasColumnName("IdDemandaAbogado");
              this.Property(t => t.IdAbogado).HasColumnName("IdAbogado");
              this.Property(t => t.IdDemanda).HasColumnName("IdDemanda");
              this.Property(t => t.UsuarioCrea).HasColumnName("UsuarioCrea").IsRequired().HasMaxLength(250);
              this.Property(t => t.FechaCrea).HasColumnName("FechaCrea");
              this.Property(t => t.UsuarioModifica).HasColumnName("UsuarioModifica").HasMaxLength(250);
              this.Property(t => t.FechaModifica).HasColumnName("FechaModifica");
              this.HasRequired(t => t.Abogados).WithMany(t => t.DamandasAbogados).HasForeignKey(d => d.IdAbogado);
              this.HasRequired(t => t.Demandas).WithMany(t => t.DamandasAbogados).HasForeignKey(d => d.IdDemanda);
         }
    }
}
