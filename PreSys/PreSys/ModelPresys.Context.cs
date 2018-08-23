﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreSys
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PreSysEntities : DbContext
    {
        public PreSysEntities()
            : base("name=PreSysEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banco> Bancos { get; set; }
        public virtual DbSet<Ciudad> Ciudads { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Correo> Correos { get; set; }
        public virtual DbSet<Cuota> Cuotas { get; set; }
        public virtual DbSet<Direccion> Direccions { get; set; }
        public virtual DbSet<DireccionTipo> DireccionTipoes { get; set; }
        public virtual DbSet<Empresa> Empresas { get; set; }
        public virtual DbSet<Estado> Estadoes { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }
        public virtual DbSet<Gasto> Gastos { get; set; }
        public virtual DbSet<Genero> Generoes { get; set; }
        public virtual DbSet<Identificacion> Identificacions { get; set; }
        public virtual DbSet<IdentificacionTipo> IdentificacionTipoes { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Mensaje> Mensajes { get; set; }
        public virtual DbSet<Pago> Pagos { get; set; }
        public virtual DbSet<Prestamo> Prestamos { get; set; }
        public virtual DbSet<PrestamoTipo> PrestamoTipoes { get; set; }
        public virtual DbSet<Profesion> Profesions { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Referencia> Referencias { get; set; }
        public virtual DbSet<ReferenciaTipo> ReferenciaTipoes { get; set; }
        public virtual DbSet<Telefono> Telefonoes { get; set; }
        public virtual DbSet<TelefonoTipo> TelefonoTipoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioTipo> UsuarioTipoes { get; set; }
        public virtual DbSet<ViaDesembolso> ViaDesembolsoes { get; set; }
        public virtual DbSet<ViaPago> ViaPagoes { get; set; }
        public virtual DbSet<ViaTipo> ViaTipoes { get; set; }
    }
}