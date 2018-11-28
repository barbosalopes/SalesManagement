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
                profit /= 100;
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

        public static string Run(string fileLocation)
        {
            string line;
            StreamReader runFile = new StreamReader(@fileLocation);
            StreamWriter controlFile = new StreamWriter(@"c:/Users/mateu/Documents/controlVendas.txt");

            Product p = null, pAux = null;
            Sale s = null;
            string productName;
            int productAmount, selledAmount;

            while ((line = runFile.ReadLine()) != null)
            {
                string[] sellParams = line.Split(';');
                productAmount = int.Parse(sellParams[1]);
                s = new Sale();
                for (int i = 0; i < productAmount; i++)
                {
                    line = runFile.ReadLine();
                    string[] saleParams = line.Split(';');
                    productName = saleParams[0];
                    selledAmount = int.Parse(saleParams[1]);
                    pAux = Stock.GetProductType(productName);

                    for (int j = 0; j < selledAmount; j++)
                    {
                        switch (pAux.GetTypeCode())
                        {
                            case 1:
                                p = new Drink(productName, pAux.GetBasePrice(), pAux.GetProfit());
                                break;
                            case 2:
                                p = new Food(productName, pAux.GetBasePrice(), pAux.GetProfit());
                                break;
                            case 3:
                                p = new OfficeSupplie(productName, pAux.GetBasePrice(), pAux.GetProfit());
                                break;
                            case 4:
                                p = new DomesticUtensil(productName, pAux.GetBasePrice(), pAux.GetProfit());
                                break;
                        }
                        s.AddProduct(p);
                    }
                    s.Finish();
                    Company.AddSale(s);
                    controlFile.WriteLine(sellParams[0]);
                }
            }
            controlFile.Close();
            return Company.ToString();
        }
    }
}
