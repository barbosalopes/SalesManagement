using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public class Drink : Product
    {
        private static int MinAmount = 10;

        public Drink(string name, double basePrice, double profit, double tax = 0) : base(name, basePrice, profit, tax)
        {
        }

        public static void SetMinAmount(int minAmount)
        {
            if(minAmount > 0)
                MinAmount = minAmount;
        }

        public override int GetMinAmount()
        {
            return MinAmount;
        }

        public override double GetMaxProfit()
        {
            return 0.4;
        }
        
        public override double GetMinProfit()
        {
            return 0.15;
        }

        public override int GetTypeCode()
        {
            return 1;
        }
    }
}