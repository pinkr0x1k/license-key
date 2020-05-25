using System;
using System.Security;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Xml;
using System.Collections.Generic;



namespace LicenseKey
{
    public partial class LicenseTerm : Form

    {

        public LicenseTerm()
        {
            InitializeComponent();
        }

        private bool close;
        private const int keysize = 256;
        string belgeninadi, belgeninyolu;


        List<LicenseType> Types = new List<LicenseType>();

        List<LicenseType> types = new List<LicenseType>()
            {
                new LicenseType {Type = "Trial" },
                new LicenseType {Type = "Full" }
            };

        public static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                //Create a new instance of RSACryptoServiceProvider.
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    //Import the RSA Key information. This only needs
                    //toinclude the public key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Encrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }
            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }

        }

        public static byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                //Create a new instance of RSACryptoServiceProvider.

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    //Import the RSA Key information. This needs
                    //to include the private key information.
                    RSA.ImportParameters(RSAKeyInfo);

                    //Decrypt the passed byte array and specify OAEP padding.  
                    //OAEP padding is only available on Microsoft Windows XP or
                    //later.  
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }

            //Catch and display a CryptographicException  
            //to the console.
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }

        }


        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                belgeninyolu = folderBrowserDialog1.SelectedPath.ToString();
                sFile.Text = belgeninyolu;

            }
        }

        public void Dogrulama(string text)
        {

            if (File.Exists(belgeninyolu + @"\" + belgeninadi + ".lic"))
            {

                throw new HataYazdir(text);

            }

            else
            {
                belgeninadi = companyName.Text;
                StreamWriter SW = new StreamWriter(belgeninyolu + @"\" + belgeninadi + ".lic"); //("C:\\Users\\Semafor\\safak.lic");


                SW.WriteLine(companyName.Text);
                SW.WriteLine(cbLicenseType.Text);
                SW.WriteLine(productName.Text + " | " + productKey.Text);
                SW.WriteLine(startDate.Text + " | " + endDate.Text);

                SW.Close();

            }
        }

        private void Generate_Click(object sender, EventArgs e)
        {



            if (String.IsNullOrEmpty(cbLicenseType.Text))
            {
                DialogResult result = MessageBox.Show("Type is empty!");
            }

            else

            {
                try
                {
                    Dogrulama(belgeninadi);
                    DialogResult result = MessageBox.Show("Company key is created...");
                }
                catch (HataYazdir ex)
                {

                    errorProvider1.SetError(companyName, ex.Message);
                    DialogResult result = MessageBox.Show("Please enter another company name!");
                    DosyadanOku();
                }


            }



            /*   if (System.IO.File.Exists(belgeninyolu + @"\" + belgeninadi + ".lic"))

               {

                   MessageBox.Show("File is found!");

               }

               else

               {

                   StreamWriter file = new StreamWriter(belgeninyolu + @"\" + belgeninadi + ".lic");

                   file.Close();

               }*/


        }

        public void DosyadanOku()
        {
            StreamReader sr = new StreamReader(Application.StartupPath + @"\log.txt");
            string[] satirlar = sr.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            sr.Close();

            foreach (string satir in satirlar)
            {
                string[] sutunlar = satir.Split('|');
                ListViewItem li = new ListViewItem(sutunlar);
                listView1.Items.Add(li);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //.columncontent = contentsize

        }

        private void LicenseTerm_Load(object sender, EventArgs e)
        {
            foreach (LicenseType type in types)
            {
                cbLicenseType.Items.Add(type);
            }

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }



        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboLicenseType_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void Exit_Click(object sender, EventArgs e)
        {

            DialogResult sonuc = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.No)
            {
                close = true;
                return;
            }
            Application.Exit();
        }



        private void VisitLink()
        {

            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://ceng.deu.edu.tr/");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


    }
}









