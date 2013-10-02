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
    
    internal partial class RolUsuarioMapping : EntityTypeConfiguration<RolUsuario>
    {
        public RolUsuarioMapping()
        {                        
              this.HasKey(t => t.RolUsuarioId);        
              this.ToTable("RolUsuario", "adm");
              this.Property(t => t.RolUsuarioId).HasColumnName("RolUsuarioId");
              this.Property(t => t.UsuarioId).HasColumnName("UsuarioId");
              this.Property(t => t.RolId).HasColumnName("RolId");
              this.HasRequired(t => t.Rol).WithMany(t => t.RolUsuario).HasForeignKey(d => d.RolId);
              this.HasRequired(t => t.Usuario).WithMany(t => t.RolUsuario).HasForeignKey(d => d.UsuarioId);
         }
    }
}
