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
    
    internal partial class RolMapping : EntityTypeConfiguration<Rol>
    {
        public RolMapping()
        {                        
              this.HasKey(t => t.RolId);        
              this.ToTable("Rol", "adm");
              this.Property(t => t.RolId).HasColumnName("RolId");
              this.Property(t => t.AplicacionId).HasColumnName("AplicacionId");
              this.Property(t => t.Nombre).HasColumnName("Nombre").IsRequired().HasMaxLength(128);
         }
    }
}
