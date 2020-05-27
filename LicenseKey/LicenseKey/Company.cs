using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseKey
{
    class Company
    {

        public Company Companies { get; set; }
       

        public string CompanyName { get; set; }
        


        public override string ToString()
        {
            return CompanyName;
        }
    }
}
