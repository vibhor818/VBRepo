using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
namespace PerfectAsymmetricEncryption
{
    public partial class Form1 : Form
    {
        byte[] cipherbytes;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            rsa.KeySize = 2048;
            //establish RSA asymmetric algorithm
            //provide public and private RSA params
            StreamWriter writer = new StreamWriter("PublicPrivateKey.xml");
            string publicPrivateKeyXML = rsa.ToXmlString(true);
            writer.Write(publicPrivateKeyXML);
            writer.Close();
            label1.Text = publicPrivateKeyXML;
            //provide public only RSA params
            writer = new StreamWriter("PublicOnlyKey.xml");
            string publicOnlyKeyXML = rsa.ToXmlString(false);
            label2.Text = publicOnlyKeyXML;
            writer.Write(publicOnlyKeyXML);
            writer.Close();
            //Console.WriteLine();
            //display public and private RSA key
            //Console.WriteLine(publicPrivateKeyXML.ToString());
            //Console.WriteLine(); Console.WriteLine();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //  do UI stuff
            //establish RSA asymmetric algorithm
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //public only RSA parameters for encrypt
            StreamReader reader = new StreamReader("PublicOnlyKey.xml");
            string publicOnlyKeyXML = reader.ReadToEnd();
            rsa.FromXmlString(publicOnlyKeyXML);
            reader.Close();
            //read plaintext, encrypt it to ciphertext
            byte[] plainbytes = Encoding.UTF7.GetBytes(textBox1.Text);
            cipherbytes = rsa.Encrypt(plainbytes, false); //fOAEP needs high encryption pack
            string alltext="";
            foreach (byte p in cipherbytes)
            {
                alltext = alltext + Convert.ToString((char)p); 
                //Console.Write((char)p);
            }
            label4.Text = alltext; 
            //buttonDecrypt_Click(cipherbytes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //public and private RSA parameters for encrypt
            try
            {
                StreamReader reader = new StreamReader("PublicPrivateKey.xml");
                string publicPrivateKeyXML = reader.ReadToEnd();
                rsa.FromXmlString(publicPrivateKeyXML);
                reader.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message.ToString());    
            }
            //read ciphertext, decrypt it to plaintext
            byte[] plainbytes = rsa.Decrypt(cipherbytes, false); //fOAEP needs high encryption pack
            string alltext="";
            foreach (byte p in plainbytes)
            {
                alltext =alltext+Convert.ToString((char)p);   
            }
            label4.Text =alltext; 

        }
    }
}