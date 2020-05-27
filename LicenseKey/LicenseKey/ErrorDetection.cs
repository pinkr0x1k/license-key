using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LicenseKey
{
    public class ErrorDetection : ApplicationException
    {

        public string Txt { get; set; }

        public override string Message
        {
            get
            {
                return base.Message + "A company cannot have more than one license! Please enter another company name.";
            }
        }

        public ErrorDetection(string param)
        {
            this.Txt = param;
            ExceptionYaz();
        }

        private void ExceptionYaz()
        {
            string FolderUrl = Application.StartupPath + @"\log.txt"; //var bottom litering string
            StreamWriter sw = new StreamWriter(FolderUrl, true, Encoding.UTF8);

            sw.WriteLine(Txt + " | " + Message + " | " + DateTime.Now);
            sw.Close();

        }

    }
}
