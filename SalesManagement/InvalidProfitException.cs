using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    class InvalidProfitException : Exception
    {
        public InvalidProfitException(double min, double max) :
            base("The profit must be between " + min + " and " + max)
        { }
    }
}
