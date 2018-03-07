using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using DeliveryCalculator.Classes;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryCalculator.DB
{
    public class DeliveryDBContextConfigurations
    {
        #region Person
        public class PersonConfiguration : EntityTypeConfiguration<Person>
        {
            public PersonConfiguration()
            {
                this.ToTable("Persons");
                this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                this.Property(x => x.Id).HasColumnName("Id").IsRequired();
                this.Property(x => x.Name).HasColumnName("Name").IsRequired();
            }
        }
        #endregion
        
        #region Order
        public class OrderConfiguration : EntityTypeConfiguration<Order>
        {
            public OrderConfiguration()
            {
                this.ToTable("Orders");
                this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

                this.Property(x => x.Id).HasColumnName("Id").IsRequired();
                this.Property(x => x.Name).HasColumnName("Name").IsRequired();
            }
        }
        #endregion
    }
}
