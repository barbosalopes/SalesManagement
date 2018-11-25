using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public class Company
    {
        private List<Sale> Sales;

        public double GetGrossValue()
        {
            double grossValue = 0;

            foreach(Product product in Stock.GetProducts())
            {
                grossValue += product.GetPriceWithoutTax() - product.GetBasePrice();
            }
            return grossValue;
        }

        public double GetNetValue()
        {
            double netValue = 0;

            foreach (Product product in Stock.GetProducts())
            {
                netValue += product.GetPrice() - product.GetBasePrice();
            }
            return netValue;
        }

        public Product GetBestSellerUni()
        {
            int maxUnSelled = -1;
            Product bestUnSelled;

            foreach(Product productType in Stock.GetProductTypes())
            {

            }
            return maxUnSelled;
        }

        public Product GetBestSellerFat()
        {
            throw new System.NotImplementedException();
        }

        public Product GetBestSeller()
        {
            throw new System.NotImplementedException();
        }

        public void AddSale(Sale sale)
        {
            Sales.Add(sale);
        }
    }
}