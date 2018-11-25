using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesManagement
{
    static class FileApplication
    {
        public static string Build(string fileLocation)
        {
            string line;
            StreamReader buildFile = new StreamReader(@fileLocation);

            Product p = null;
            string name;
            int category, initialStock, minStock;
            double basePrice, profit;

            while ((line = buildFile.ReadLine()) != null)
            {
                string[] productParams = line.Split(';');
                name = productParams[0];
                category = int.Parse(productParams[1]);
                profit = double.Parse(productParams[2]);
                basePrice = double.Parse(productParams[3]);
                initialStock = int.Parse(productParams[4]);
                minStock = int.Parse(productParams[5]);

                switch (category)
                {
                    case 1:
                            p = new Drink(name, basePrice, profit);
                        break;
                    case 2:
                            p = new Food(name, basePrice, profit);
                        break;
                    case 3:
                            p = new OfficeSupplie(name, basePrice, profit);
                        break;
                    case 4:
                            p = new DomesticUtensil(name, basePrice, profit);
                        break;
                }
                for (int i = 0; i < initialStock; i++)
                    Stock.AddProduct(p);
            }

            return Stock.ToString();
        }
    }
}
