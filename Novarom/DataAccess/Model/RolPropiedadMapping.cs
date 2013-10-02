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
    
    internal partial class RolPropiedadMapping : EntityTypeConfiguration<RolPropiedad>
    {
        public RolPropiedadMapping()
        {                        
              this.HasKey(t => t.RolPropiedadId);        
              this.ToTable("RolPropiedad", "adm");
              this.Property(t => t.RolPropiedadId).HasColumnName("RolPropiedadId");
              this.Property(t => t.RolId).HasColumnName("RolId");
              this.Property(t => t.PropiedadId).HasColumnName("PropiedadId");
              this.HasRequired(t => t.Propiedad).WithMany(t => t.RolPropiedad).HasForeignKey(d => d.PropiedadId);
              this.HasRequired(t => t.Rol).WithMany(t => t.RolPropiedad).HasForeignKey(d => d.RolId);
         }
    }
}
