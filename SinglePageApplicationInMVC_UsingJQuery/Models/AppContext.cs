using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SinglePageApplicationInMVC_UsingJQuery.Models
{
    public class AppContext:DbContext
    {
        public AppContext():base("DefaultConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}