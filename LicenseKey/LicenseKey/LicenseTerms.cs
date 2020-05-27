using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LicenseKey
{
    [Serializable]

    public class LicenseTerms
    {

        public DateTime StartDate { get; set; }
        public string CompanyName { get; set; }
        public string ProductName { get; set; }
        public DateTime EndDate { get; set; }

     
    }
}