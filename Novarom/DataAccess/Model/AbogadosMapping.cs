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
    
    internal partial class AbogadosMapping : EntityTypeConfiguration<Abogados>
    {
        public AbogadosMapping()
        {                        
              this.HasKey(t => t.IdAbogado);        
              this.ToTable("Abogados");
              this.Property(t => t.IdAbogado).HasColumnName("IdAbogado");
              this.Property(t => t.Nombres).HasColumnName("Nombres").IsRequired().HasMaxLength(50);
              this.Property(t => t.Apellidos).HasColumnName("Apellidos").IsRequired().HasMaxLength(50);
              this.Property(t => t.NumeroIdentificacion).HasColumnName("NumeroIdentificacion").IsRequired().HasMaxLength(25);
              this.Property(t => t.CiudadExpedicion).HasColumnName("CiudadExpedicion").IsRequired().HasMaxLength(45);
              this.Property(t => t.TarjetaProfesional).HasColumnName("TarjetaProfesional").IsRequired().HasMaxLength(25);
              this.Property(t => t.Telefono1).HasColumnName("Telefono1").HasMaxLength(15);
              this.Property(t => t.Telefono2).HasColumnName("Telefono2").HasMaxLength(15);
              this.Property(t => t.Email).HasColumnName("Email").HasMaxLength(50);
              this.Property(t => t.Direccion).HasColumnName("Direccion").HasMaxLength(60);
              this.Property(t => t.Descripcion).HasColumnName("Descripcion").IsRequired().HasMaxLength(100);
              this.Property(t => t.UsuarioCrea).HasColumnName("UsuarioCrea").IsRequired().HasMaxLength(250);
              this.Property(t => t.FechaCrea).HasColumnName("FechaCrea");
              this.Property(t => t.UsuarioModifica).HasColumnName("UsuarioModifica").HasMaxLength(250);
              this.Property(t => t.FechaModifica).HasColumnName("FechaModifica");
         }
    }
}
