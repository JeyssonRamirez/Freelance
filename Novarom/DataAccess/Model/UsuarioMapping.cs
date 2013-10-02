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
    
    internal partial class UsuarioMapping : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMapping()
        {                        
              this.HasKey(t => t.UsuarioId);        
              this.ToTable("Usuario", "adm");
              this.Property(t => t.UsuarioId).HasColumnName("UsuarioId");
              this.Property(t => t.ProviderUserKey).HasColumnName("ProviderUserKey");
              this.Property(t => t.Login).HasColumnName("Login").IsRequired().HasMaxLength(32);
         }
    }
}
