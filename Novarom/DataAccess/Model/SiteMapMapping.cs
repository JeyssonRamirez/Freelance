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
    
    internal partial class SiteMapMapping : EntityTypeConfiguration<SiteMap>
    {
        public SiteMapMapping()
        {                        
              this.HasKey(t => t.SiteMapId);        
              this.ToTable("SiteMap", "adm");
              this.Property(t => t.SiteMapId).HasColumnName("SiteMapId");
              this.Property(t => t.AplicacionId).HasColumnName("AplicacionId");
              this.Property(t => t.Titulo).HasColumnName("Titulo").IsRequired().HasMaxLength(64);
              this.Property(t => t.Descripcion).HasColumnName("Descripcion").HasMaxLength(512);
              this.Property(t => t.Url).HasColumnName("Url").HasMaxLength(512);
              this.Property(t => t.Roles).HasColumnName("Roles").HasMaxLength(512);
              this.Property(t => t.PadreId).HasColumnName("PadreId");
              this.Property(t => t.Activo).HasColumnName("Activo");
         }
    }
}
