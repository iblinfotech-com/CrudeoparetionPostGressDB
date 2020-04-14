using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudWith_DpMigration_Postgresql.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext():base(nameOrConnectionString:"con")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
    }
}