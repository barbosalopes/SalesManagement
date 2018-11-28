using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public static class Company
    {
        private static List<Sale> Sales = new List<Sale>();

        public static double GetGrossValue()
        {
            double grossValue = 0;

            foreach (Sale sale in Sales)
            {
                foreach (Product product in sale.GetProducts())
                {
                    grossValue += product.GetPriceWithoutTax() - product.GetBasePrice();
                }
            }
            return grossValue;
        }

        public static double GetNetValue()
        {
            double netValue = 0;

            foreach (Product product in Stock.GetProducts())
            {
                netValue += product.GetPrice() - product.GetBasePrice();
            }
            return netValue;
        }

        public static Product GetBestSellerUni()
        {
            int maxUnSelled = -1;
            Product bestUnSelled = null;
            int uniSelled;

            foreach(Product productType in Stock.GetProductTypes())
            {
                uniSelled = GetSelledProducts().Count(p => p.Equals(productType));
                if (uniSelled > maxUnSelled)
                {
                    maxUnSelled = uniSelled;
                    bestUnSelled = productType;
                }
            }
            return bestUnSelled;
        }

        public static List<Product> GetSelledProducts()
        {
            List<Product> products = new List<Product>();
            foreach(Sale sale in Sales)
            {
                foreach (Product product in sale.GetProducts())
                {
                    products.Add(product);
                }
            }
            return products;
        }

        public static Product GetBestSellerFat()
        {
            double maxFat = -1;
            Product bestSellerFat = null;
            double fat = 0;
            List<Product> products;

            foreach (Product productType in Stock.GetProductTypes())
            {
                products = GetSelledProducts().FindAll(p => p.Equals(productType));
                foreach(Product product in products)
                {
                    fat += product.GetPrice();
                }

                if (fat > maxFat)
                {
                    maxFat = fat;
                    bestSellerFat = productType;
                }
            }
            return bestSellerFat;
        }

        public static Product GetBestSeller()
        {
            double maxProfit = -1;
            Product bestSeller = null;
            double profit = 0;
            List<Product> products;

            foreach (Product productType in Stock.GetProductTypes())
            {
                products = GetSelledProducts().FindAll(p => p.Equals(productType));
                foreach (Product product in products)
                {
                    profit += product.GetPrice() - product.GetBasePrice();
                }

                if (profit > maxProfit)
                {
                    maxProfit = profit;
                    bestSeller = productType;
                }
            }
            return bestSeller;
        }

        public static void AddSale(Sale sale)
        {
            Sales.Add(sale);
        }

        public static string ToString()
        {
            StringBuilder s = new StringBuilder();
            int index = 0;
            foreach(Sale sale in Sales)
            {
                s.AppendLine(index.ToString());
                foreach(Product p in sale.GetProducts())
                {
                    s.AppendLine("Prod: " + p.GetName());
                }
                index++;
            }
            return s.ToString();
        }
    }
}