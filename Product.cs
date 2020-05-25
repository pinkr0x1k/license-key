using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseKey
{
    class Product
    {

        public Product Products { get; set; }


        public string ProductName { get; set; }
        

        public override string ToString()
        {
            return ProductName;
        }
    }
}
