using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryCalculator.DataLayer.Repos.Contracts;
using DeliveryCalculator.Classes;
using DeliveryCalculator.DataLayer.Repos.Base;

namespace DeliveryCalculator.DataLayer.Repos
{
    public class PersonRepository : RepoBase, IRepository<Person>
    {
        public bool Add(Person entity)
        {
            Context.Entry(entity).State = System.Data.Entity.EntityState.Added;
            return Context.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
