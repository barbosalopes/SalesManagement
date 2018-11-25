using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public class Order : Movement
    {
        public override void Finish()
        {
            foreach(Product product in GetProducts())
            {
                Stock.AddProduct(product);
            }
        }
    }
}