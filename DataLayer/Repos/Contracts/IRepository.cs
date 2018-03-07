using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.DataLayer.Repos.Contracts
{
    public interface IRepository<T>
    {
        T Get(int id);
        List<T> GetAll();
        bool Add(T entity);
        bool Delete(int id);
    }
}
