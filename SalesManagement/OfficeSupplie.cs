using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesManagement
{
    public class OfficeSupplie : Product
    {
        private static int MinAmount = 10;

        public OfficeSupplie(string name, double basePrice, double profit, double tax = 0) : base(name, basePrice, profit, tax)
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
            return 0.3;
        }

        public override double GetMinProfit()
        {
            return 0.1;
        }

        public override int GetTypeCode()
        {
            return 3;
        }
    }
}