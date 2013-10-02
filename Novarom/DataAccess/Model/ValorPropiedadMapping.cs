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
    
    internal partial class ValorPropiedadMapping : EntityTypeConfiguration<ValorPropiedad>
    {
        public ValorPropiedadMapping()
        {                        
              this.HasKey(t => new {t.UsuarioId, t.PropiedadId});        
              this.ToTable("ValorPropiedad", "adm");
              this.Property(t => t.UsuarioId).HasColumnName("UsuarioId").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.PropiedadId).HasColumnName("PropiedadId").HasDatabaseGeneratedOption(new Nullable<DatabaseGeneratedOption>(DatabaseGeneratedOption.None));
              this.Property(t => t.Valor).HasColumnName("Valor").IsRequired();
              this.HasRequired(t => t.Propiedad).WithMany(t => t.ValorPropiedad).HasForeignKey(d => d.PropiedadId);
              this.HasRequired(t => t.Usuario).WithMany(t => t.ValorPropiedad).HasForeignKey(d => d.UsuarioId);
         }
    }
}

