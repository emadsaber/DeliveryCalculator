using DeliveryCalculator.Classes.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.Classes
{
    public class Order : BaseEntity
    {
        public List<FoodItem> FoodItems { get; set; }
    }
}
