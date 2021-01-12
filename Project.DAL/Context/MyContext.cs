using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("myConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductAtrributeMap());
            modelBuilder.Configurations.Add(new AttributeMap());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ENTITIES.Models.PAttribute> Attributes { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<ENTITIES.Models.Category> Categories { get; set; }



    }
}
