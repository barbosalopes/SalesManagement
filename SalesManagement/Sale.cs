using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public class Sale : Movement
    {
        protected SalesManagement.Product[] Products
        {
            get => default(Product[]);
            set
            {
            }
        }

        public double GetBilledValue()
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProduct()
        {
            throw new System.NotImplementedException();
        }
    }
}