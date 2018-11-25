using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public abstract class Product : Saleable
    {
        protected double BasePrice;
        protected double Tax;
        protected double Profit;
        protected string Name;

        public Product(string name, double basePrice, double profit, double tax = 0)
        {
            BasePrice = basePrice;
            Tax = tax;
            Profit = profit;
            Name = name;
        }

        public virtual void SetProfit(double profit)
        {
            if(profit < GetMinProfit() || profit > GetMaxProfit())
            {
                throw new InvalidProfitException(GetMinProfit(), GetMaxProfit());
            }
            else
            {
                Profit = profit;
            }
        }
    
        public abstract double GetMaxProfit();

        public abstract double GetMinProfit();

        public virtual double GetPrice()
        {
            return BasePrice * (1 + Profit) * (1 + GetTax());
        }

        public virtual double GetBasePrice()
        {
            return BasePrice;
        }

        public virtual double GetPriceWithoutTax()
        {
            return BasePrice * (1 + Profit);
        }

        public virtual double GetTax()
        {
            return Tax;
        }

        public abstract int GetMinAmount();

        public virtual string GetName()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            return (GetName() == product.GetName()) &&
                        GetType() == product.GetType();
        }
    }
}