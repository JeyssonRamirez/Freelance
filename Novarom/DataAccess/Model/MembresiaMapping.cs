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
    
    internal partial class MembresiaMapping : EntityTypeConfiguration<Membresia>
    {
        public MembresiaMapping()
        {                        
              this.HasKey(t => t.MembresiaId);        
              this.ToTable("Membresia", "adm");
              this.Property(t => t.MembresiaId).HasColumnName("MembresiaId");
              this.Property(t => t.AplicacionId).HasColumnName("AplicacionId");
              this.Property(t => t.UsuarioId).HasColumnName("UsuarioId");
              this.Property(t => t.Password).HasColumnName("Password").IsRequired().HasMaxLength(256);
              this.Property(t => t.Email).HasColumnName("Email").IsRequired().HasMaxLength(256);
              this.Property(t => t.PreguntaPassword).HasColumnName("PreguntaPassword").HasMaxLength(256);
              this.Property(t => t.RespuestaPassword).HasColumnName("RespuestaPassword").HasMaxLength(256);
              this.Property(t => t.Comentario).HasColumnName("Comentario").HasMaxLength(512);
              this.Property(t => t.UltimaActividad).HasColumnName("UltimaActividad");
              this.Property(t => t.UltimaSesion).HasColumnName("UltimaSesion");
              this.Property(t => t.UltimoCambioDePassword).HasColumnName("UltimoCambioDePassword");
              this.Property(t => t.CantidadIntentosFallidosPassword).HasColumnName("CantidadIntentosFallidosPassword");
              this.Property(t => t.InicioIntentosFallidosPassword).HasColumnName("InicioIntentosFallidosPassword");
              this.Property(t => t.CantidadIntentosFallidosPregunta).HasColumnName("CantidadIntentosFallidosPregunta");
              this.Property(t => t.InicioIntentosFallidosPregunta).HasColumnName("InicioIntentosFallidosPregunta");
              this.Property(t => t.EstaAprobado).HasColumnName("EstaAprobado");
              this.Property(t => t.EstaBloqueado).HasColumnName("EstaBloqueado");
              this.Property(t => t.UltimoBloqueo).HasColumnName("UltimoBloqueo");
              this.Property(t => t.Registrado).HasColumnName("Registrado");
              this.HasRequired(t => t.Usuario).WithMany(t => t.Membresia).HasForeignKey(d => d.UsuarioId);
         }
    }
}
