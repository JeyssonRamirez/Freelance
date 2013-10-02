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
    
    internal partial class PerfilMapping : EntityTypeConfiguration<Perfil>
    {
        public PerfilMapping()
        {                        
              this.HasKey(t => t.PerfilId);        
              this.ToTable("Perfil", "adm");
              this.Property(t => t.PerfilId).HasColumnName("PerfilId");
              this.Property(t => t.AplicacionId).HasColumnName("AplicacionId");
              this.Property(t => t.UsuarioId).HasColumnName("UsuarioId");
              this.Property(t => t.UltimaActividad).HasColumnName("UltimaActividad");
              this.Property(t => t.UltimaActualizacion).HasColumnName("UltimaActualizacion");
              this.HasRequired(t => t.Usuario).WithMany(t => t.Perfil).HasForeignKey(d => d.UsuarioId);
         }
    }
}
