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
    
    internal partial class PropiedadMapping : EntityTypeConfiguration<Propiedad>
    {
        public PropiedadMapping()
        {                        
              this.HasKey(t => t.PropiedadId);        
              this.ToTable("Propiedad", "adm");
              this.Property(t => t.PropiedadId).HasColumnName("PropiedadId");
              this.Property(t => t.Nombre).HasColumnName("Nombre").IsRequired().HasMaxLength(64);
              this.Property(t => t.Tipo).HasColumnName("Tipo").IsRequired().HasMaxLength(64);
         }
    }
}
