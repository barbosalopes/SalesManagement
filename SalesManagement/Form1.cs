using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class Form1 : Form
    {
        private Sale currentSale = new Sale();

        public Form1()
        {
            InitializeComponent();
            FileApplication.Build("c:/Users/mateu/Documents/AEDprodutos.txt");
            FileApplication.Run("c:/Users/mateu/Documents/AEDvendas.txt");
            UpdateOutput();            
        }

        private void UpdateOutput()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Best Seller in units: " + Company.GetBestSellerUni().GetName());
            s.AppendLine("Best Seller in fat: " + Company.GetBestSellerFat().GetName());
            s.AppendLine("Best Seller (Biggest profit): " + Company.GetBestSeller().GetName());
            output.Text = s.ToString();
        }

        private void UpdateProducts()
        {
            StringBuilder s = new StringBuilder();
            foreach(Product p in currentSale.GetProducts())
            {
                s.AppendLine(p.ToString());
            }
            products_on_sell.Text = s.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = product_name.Text;
            int selledAmount = int.Parse(amount_selled.Text);
            Product p = null;
            Product pAux = Stock.GetProductType(productName);

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
                currentSale.AddProduct(p);
            }
            UpdateProducts();
            product_name.Text = "";
            amount_selled.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentSale.Finish();
            Company.AddSale(currentSale);
            currentSale = new Sale();
            UpdateOutput();
            UpdateProducts();
        }
    }
}
