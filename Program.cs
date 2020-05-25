﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;




namespace LicenseKey
{
    public static class Program
    {
        //[STAThread]

         
           static string CONTAINER_NAME = "MyContainerName";

           public enum KeySizes
           {
               SIZE_512 = 512,
               SIZE_1024 = 1024,
               SIZE_2048 = 2048,
               SIZE_952 = 952,
               SIZE_1369 = 1369
           };
           


       public static void Main()
        {
             string message = "The quick brown fox jumps over the lazy dog";
             generateKeys();
             byte[] encrypted = Encrypt(Encoding.UTF8.GetBytes(message));
             byte[] decrypted = Decrypt(encrypted);
             DeleteKeyInCSP();
             Console.WriteLine("Original\n\t " + message + "\n");
             Console.WriteLine("Encrypted\n\t" + BitConverter.ToString(encrypted).Replace("-", "") + "\n");
             Console.WriteLine("Decrypted\n\t" + Encoding.UTF8.GetString(decrypted));

             Console.ReadLine();

         }
        

         static void generateKeys()
         {
             int rsa_provider = 1;

             CspParameters cspParameters = new CspParameters(rsa_provider); //1 for rsa ; 13 for DSA ( Digital signature algorithm)
             cspParameters.KeyContainerName = CONTAINER_NAME;
             cspParameters.Flags = CspProviderFlags.UseMachineKeyStore;
             cspParameters.ProviderName = "Microsoft Strong Cryptographic Provider";
             var rsa = new RSACryptoServiceProvider(cspParameters);
             rsa.PersistKeyInCsp = true;
         }

         public static void DeleteKeyInCSP()
         {
             var cspParams = new CspParameters();
             cspParams.KeyContainerName = CONTAINER_NAME;
             var rsa = new RSACryptoServiceProvider(cspParams);
             rsa.PersistKeyInCsp = false;
             rsa.Clear();
         }


         private static byte[] Encrypt(byte[] plain)
         {
             byte[] encrypted;
             int rsa_provider = 1;
             CspParameters cspParameters = new CspParameters(rsa_provider);
             cspParameters.KeyContainerName = CONTAINER_NAME;

             using (var rsa = new RSACryptoServiceProvider((int)KeySizes.SIZE_2048, cspParameters))
             {
                 encrypted = rsa.Encrypt(plain, true);
             }
             return encrypted;
         }

         private static byte[] Decrypt(byte[] encrypted)
         {
             byte[] decrypted;

             CspParameters cspParameters = new CspParameters();
             cspParameters.KeyContainerName = CONTAINER_NAME;

             using (var rsa = new RSACryptoServiceProvider((int)KeySizes.SIZE_2048, cspParameters))
             {
                 decrypted = rsa.Decrypt(encrypted, true);
             }
             return decrypted;
         }

        


           /* Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LicenseTerm());*/
        }

    }


