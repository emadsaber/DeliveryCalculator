using DeliveryCalculator.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryCalculator.DataLayer.Repos.Base
{
    public class RepoBase
    {
        private DeliveryDBContext _cxt;
        public DeliveryDBContext Context {
            get
            {
                if (_cxt == null) return new DeliveryDBContext();
                return _cxt;
            }
        }
    }
}
