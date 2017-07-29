using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace CustomAnnotationMVC.Models
{
    public class EmployeeDbContext : DbContext
    {
        #region Constructure
        public EmployeeDbContext() : base("EmployeeConnectionString") { }
        #endregion

        #region Private Method
        public DbSet<Employee> EmployeeDB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
          //  Database.SetInitializer<EmployeeDbContext>(null);
           // base.OnModelCreating(modelBuilder);
        }
        #endregion

    }
}