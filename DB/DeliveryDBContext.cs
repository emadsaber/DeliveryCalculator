using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.DB
{
    public class DeliveryDBContext : DbContext
    {
        public DeliveryDBContext() : base("DeliveryDB")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DeliveryDBContextConfigurations.PersonConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
