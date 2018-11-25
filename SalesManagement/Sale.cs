using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public class Sale : Movement
    {
        public override void Finish()
        {
            foreach (Product product in GetProducts())
                Stock.RemoveProduct(product);
        }

        public double GetBilledValue()
        {
            double billedValue = 0;

            foreach(Product product in GetProducts())
            {
                billedValue += product.GetPrice();
            }

            return billedValue;
        }


    }
}