using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public abstract class Movement
    {
        protected List<Product> Products;

        public Movement()
        {
            Products = new List<Product>();
        }

        public abstract void Finish();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            bool couldRemove;
            couldRemove = Products.Remove(product);
            if (!couldRemove)
            {
                throw new ProductUnavailableException("Movement");
            }
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}