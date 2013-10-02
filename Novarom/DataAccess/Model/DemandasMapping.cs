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
    
    internal partial class DemandasMapping : EntityTypeConfiguration<Demandas>
    {
        public DemandasMapping()
        {                        
              this.HasKey(t => t.IdDemanda);        
              this.ToTable("Demandas");
              this.Property(t => t.IdDemanda).HasColumnName("IdDemanda");
              this.Property(t => t.IdUsuario).HasColumnName("IdUsuario");
              this.Property(t => t.NombreDemanda).HasColumnName("NombreDemanda").IsRequired().HasMaxLength(250);
              this.Property(t => t.FechaRadicacion).HasColumnName("FechaRadicacion");
              this.Property(t => t.FechaAdicion).HasColumnName("FechaAdicion");
              this.Property(t => t.NumeroProceso).HasColumnName("NumeroProceso").HasMaxLength(50);
              this.Property(t => t.Fechacontestacion).HasColumnName("Fechacontestacion");
              this.Property(t => t.UsuarioCrea).HasColumnName("UsuarioCrea").HasMaxLength(250);
              this.Property(t => t.FechaCrea).HasColumnName("FechaCrea");
              this.Property(t => t.UsuarioModifica).HasColumnName("UsuarioModifica").HasMaxLength(250);
              this.Property(t => t.FechaModifica).HasColumnName("FechaModifica");
         }
    }
}
