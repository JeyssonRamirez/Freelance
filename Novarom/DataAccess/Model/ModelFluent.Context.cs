﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1573
namespace App.DataAccess.Model
{
    using System;
    using App.Domain.Entities;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelEntitiesContainer : DbContext
    {
        static ModelEntitiesContainer()
    	{ 
    		Database.SetInitializer<ModelEntitiesContainer>(null);
    	}
    	
    	public ModelEntitiesContainer() : base("name=ModelEntitiesContainer")
        {
        }
    	
    	public ModelEntitiesContainer(string nameOrConnectionString) : base(nameOrConnectionString)
    	{	
    	}
    
    	public ModelEntitiesContainer(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
    	{
    	}
    
    	public ModelEntitiesContainer(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
    	{
    	}
    
    	public ModelEntitiesContainer(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
    	{
    	}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {		
    		modelBuilder.Configurations.Add(new AbogadosMapping());
    		modelBuilder.Configurations.Add(new AplicacionMapping());
    		modelBuilder.Configurations.Add(new DamandasAbogadosMapping());
    		modelBuilder.Configurations.Add(new DemandasMapping());
    		modelBuilder.Configurations.Add(new ErrorAplicacionMapping());
    		modelBuilder.Configurations.Add(new EtapasMapping());
    		modelBuilder.Configurations.Add(new EtapasDemandasMapping());
    		modelBuilder.Configurations.Add(new MembresiaMapping());
    		modelBuilder.Configurations.Add(new PerfilMapping());
    		modelBuilder.Configurations.Add(new PropiedadMapping());
    		modelBuilder.Configurations.Add(new RolMapping());
    		modelBuilder.Configurations.Add(new RolPropiedadMapping());
    		modelBuilder.Configurations.Add(new RolUsuarioMapping());
    		modelBuilder.Configurations.Add(new SiteMapMapping());
    		modelBuilder.Configurations.Add(new UsuarioMapping());
    		modelBuilder.Configurations.Add(new ValorPropiedadMapping());
        }
    	
        public DbSet<Aplicacion> Aplicacion { get; set; }
        public DbSet<ErrorAplicacion> ErrorAplicacion { get; set; }
        public DbSet<Membresia> Membresia { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Propiedad> Propiedad { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolPropiedad> RolPropiedad { get; set; }
        public DbSet<RolUsuario> RolUsuario { get; set; }
        public DbSet<SiteMap> SiteMap { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<ValorPropiedad> ValorPropiedad { get; set; }
        public DbSet<Abogados> Abogados { get; set; }
        public DbSet<DamandasAbogados> DamandasAbogados { get; set; }
        public DbSet<Demandas> Demandas { get; set; }
        public DbSet<Etapas> Etapas { get; set; }
        public DbSet<EtapasDemandas> EtapasDemandas { get; set; }
    }
}
