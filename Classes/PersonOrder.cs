using DeliveryCalculator.Classes.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.Classes
{
    public class PersonOrder : BaseEntity
    {
        #region props
        public Person Person { get; set; }
        public Order Order { get; set; }
        #endregion
    }
}
