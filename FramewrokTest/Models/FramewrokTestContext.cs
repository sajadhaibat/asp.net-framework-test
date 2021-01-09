using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FramewrokTest.Models
{
    public class FramewrokTestContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx





        // The MovieDBContext shoudl be same as connection string web.config
        public FramewrokTestContext() : base("name=okk")
        {
        }

        public System.Data.Entity.DbSet<FramewrokTest.Models.Movie> Movies { get; set; }
        public System.Data.Entity.DbSet<FramewrokTest.Models.test> test { get; set; }
    }
}
