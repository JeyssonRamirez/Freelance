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
    
    internal partial class AplicacionMapping : EntityTypeConfiguration<Aplicacion>
    {
        public AplicacionMapping()
        {                        
              this.HasKey(t => t.AplicacionId);        
              this.ToTable("Aplicacion", "adm");
              this.Property(t => t.AplicacionId).HasColumnName("AplicacionId");
              this.Property(t => t.Nombre).HasColumnName("Nombre").IsRequired().HasMaxLength(256);
         }
    }
}
