﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CicloMania.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CicloEntities1 : DbContext
    {
        public CicloEntities1()
            : base("name=CicloEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<articulo> articulo { get; set; }
        public virtual DbSet<cliente> cliente { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<envio> envio { get; set; }
        public virtual DbSet<factura> factura { get; set; }
        public virtual DbSet<facturaMantenimientos> facturaMantenimientos { get; set; }
        public virtual DbSet<inventario> inventario { get; set; }
        public virtual DbSet<mantenimientos> mantenimientos { get; set; }
        public virtual DbSet<proveedor> proveedor { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<UserRolesMapping> UserRolesMapping { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
