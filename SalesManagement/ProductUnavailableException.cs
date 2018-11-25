using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    class ProductUnavailableException : Exception
    {
        public ProductUnavailableException(string location) : base("The product does not exists on the " + location) { }
    }
}
