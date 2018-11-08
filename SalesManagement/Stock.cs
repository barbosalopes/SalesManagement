using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public class Stock
    {
        protected SalesManagement.Product[] Products
        {
            get => default(Product);
            set
            {
            }
        }

        protected void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        protected void RemoveProduct()
        {
            throw new System.NotImplementedException();
        }

        public void ValidateStockAmount()
        {
            throw new System.NotImplementedException();
        }
    }
}