using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public static class Stock
    {
        private static List<Product> Products = new List<Product>();
        private static List<Product> ProductTypes = new List<Product>();

        public static List<Product> GetProducts()
        {
            return Products;
        }
        public static List<Product> GetProductTypes()
        {
            return ProductTypes;
        }
        public static void AddProductType(Product product)
        {
            if(!ProductTypes.Contains(product))
                ProductTypes.Add(product);
        }
        public static void AddProduct(Product product)
        {
            AddProductType(product);
            Products.Add(product);
        }
        public static void AddProducts(Product[] products)
        {
            foreach (Product p in products)
            {
                AddProduct(p);
            }
        }
        public static void RemoveProduct(Product product)
        {
            bool couldRemove;
            couldRemove = Products.Remove(product);
            if (!couldRemove)
            {
                throw new ProductUnavailableException("Stock");
            }
        }
        public static void RemoveProducts(Product[] products)
        {
            foreach (Product p in products)
            {
                RemoveProduct(p);
            }
        }
        private static void CreateOrder(Product product)
        {
            Order order = new Order();
            int amountToOrder = product.GetMinAmount() * 2;
            for(int i = 0; i < amountToOrder; i++)
            {
                order.AddProduct(product);
            }
            order.Finish();
        }
        private static void ValidateStockAmount(Product product)
        {
            int productTypeAmount = Products.FindAll(p => p.ToString() == product.ToString()).Count();
            if (product.GetMinProfit() > productTypeAmount)
            {
                CreateOrder(product);
            }
        }

        public static string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("Stock State:");
            foreach(Product product in Products)
            {
                str.AppendLine("Name:" + product.GetName());
            }

            return str.ToString();
        }
    }
}