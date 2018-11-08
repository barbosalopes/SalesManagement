using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public class Company
    {
        public SalesManagement.Sale[] Sales
        {
            get => default(Sale[]);
            set
            {
            }
        }

        public double GetGrossValue()
        {
            throw new System.NotImplementedException();
        }

        public double GetNetValue()
        {
            throw new System.NotImplementedException();
        }

        public Product GetBestSellerUni()
        {
            throw new System.NotImplementedException();
        }

        public Product GetBestSellerFat()
        {
            throw new System.NotImplementedException();
        }

        public Product GetBestSeller()
        {
            throw new System.NotImplementedException();
        }

        public void AddSale()
        {
            throw new System.NotImplementedException();
        }
    }
}