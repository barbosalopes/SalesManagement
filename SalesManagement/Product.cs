using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public abstract class Product : Saleable
    {
        public Product(double tax, string basePrice)
        {
            throw new System.NotImplementedException();
        }

        protected double basePrice
        {
            get => default(int);
            set
            {
            }
        }

        protected double tax
        {
            get => default(int);
            set
            {
            }
        }

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