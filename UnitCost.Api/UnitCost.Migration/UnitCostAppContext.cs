/**
 * Este proyecto tiene que estar referenciado en el Startup y la consola debe de ejecutarse en este proyecto* 
 * 
 * Para generar la migracion inicial se debe de ejecutar:
 * Add-Migration InitialCreate
 * 
 * Para actualizar la base de datos se debe ejecutar:
 * Update-Database
 **/

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UnitCost.DBMigrations.Models;

namespace UnitCost.DBMigrations
{
    public class UnitCostAppContext : DbContext
    {
        public UnitCostAppContext(DbContextOptions<UnitCostAppContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
