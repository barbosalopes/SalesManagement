using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public class Food : Product
    {
        private static int MinAmount = 10;

        public Food(string name, double basePrice, double profit, double tax = 0) : base(name, basePrice, profit, tax)
        {
        }

        public static void SetMinAmount(int minAmount)
        {
            if (minAmount > 0)
                MinAmount = minAmount;
        }

        public override int GetMinAmount()
        {
            return MinAmount;
        }

        public override double GetMaxProfit()
        {
            return 0.2;
        }

        public override double GetMinProfit()
        {
            return 0.1;
        }
        
    }
}