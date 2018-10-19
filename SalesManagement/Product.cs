using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public abstract class Product : Saleable
    {
        public virtual double GetMaxProfit()
        {
            throw new NotImplementedException();
        }

        public virtual double GetMinProfit()
        {
            throw new NotImplementedException();
        }

        public virtual double GetPrice()
        {
            throw new NotImplementedException();
        }

        public virtual double GetTax()
        {
            throw new NotImplementedException();
        }
    }
}