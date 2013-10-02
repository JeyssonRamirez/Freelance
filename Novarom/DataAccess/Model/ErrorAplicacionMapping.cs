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
    
    internal partial class ErrorAplicacionMapping : EntityTypeConfiguration<ErrorAplicacion>
    {
        public ErrorAplicacionMapping()
        {                        
              this.HasKey(t => t.ErrorAplicacionId);        
              this.ToTable("ErrorAplicacion", "adm");
              this.Property(t => t.ErrorAplicacionId).HasColumnName("ErrorAplicacionId");
              this.Property(t => t.Aplicacion).HasColumnName("Aplicacion").HasMaxLength(256);
              this.Property(t => t.Error).HasColumnName("Error").HasMaxLength(512);
              this.Property(t => t.Excepcion).HasColumnName("Excepcion").IsUnicode(false);
              this.Property(t => t.Interna).HasColumnName("Interna").IsUnicode(false);
              this.Property(t => t.Registrado).HasColumnName("Registrado");
         }
    }
}
