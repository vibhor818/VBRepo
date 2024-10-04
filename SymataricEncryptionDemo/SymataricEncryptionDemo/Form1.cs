using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace SymataricEncryptionDemo
{
    public partial class Form1 : Form
    {
        private SymmetricAlgorithm symatricobject;
        public enum SymmProvEnum 
        {
            DES, Rijndael,AES
        }
        public Form1()
        {
            InitializeComponent();
        string []s=new string []{"DES","Rijndael","AES"};
        Array.Sort(s); 
        comboBox1.Items.AddRange(s);   
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string  Encryption(string source, string key)
        {
            byte[] bytIn = System.Text.ASCIIEncoding.ASCII.GetBytes(source);
            // create a MemoryStream so that the process can be done without I/O files
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            symatricobject.KeySize = 128;
            byte[] bytKey = GetLegalKey(key);

            int i = 0;
            for (i = 0; i < bytKey.Length; i++)
                if (bytKey[i] == 0)
                    break;
            // convert into Base64 so that the result can be used in xml
           
            string str= System.Convert.ToBase64String(bytKey, 0, i);
            MessageBox.Show(str);
            // set the private key
            symatricobject.Key = bytKey;
            symatricobject.IV = bytKey;
            // create an Encryptor from the Provider Service instance
            ICryptoTransform encrypto = symatricobject.CreateEncryptor();
            // create Crypto Stream that transforms a stream using the encryption
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);

            // write out encrypted content into MemoryStream
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();                      

            // get the output and trim the '\0' bytes
            byte[] bytOut = ms.GetBuffer();
           
            for (i = 0; i < bytOut.Length; i++)
                if (bytOut[i] == 0)
                    break;
            // convert into Base64 so that the result can be used in xml
            ms.Close();
            return System.Convert.ToBase64String(bytOut, 0, i);
        }
        private byte[] GetLegalKey(string Key)
        {
            string sTemp;
            if (symatricobject.LegalKeySizes.Length > 0)
            {
                int lessSize = 0, moreSize = symatricobject.LegalKeySizes[0].MinSize;
                // key sizes are in bits
                while (Key.Length * 8 > moreSize)
                {
                    lessSize = moreSize;
                    moreSize += symatricobject.LegalKeySizes[0].SkipSize;
                }
                sTemp = Key.PadRight(moreSize / 8, ' ');
            }
            else
                sTemp = Key;

            // convert the secret key to byte array
            return ASCIIEncoding.ASCII.GetBytes(sTemp);
        }
        public void SelectEncryption(SymmProvEnum s)
        {
            switch (s)
            {
                case SymmProvEnum.DES:
                    symatricobject = new DESCryptoServiceProvider();
                    break;
                case SymmProvEnum.AES:
                    symatricobject = new AesCryptoServiceProvider();
                    break;
                case SymmProvEnum.Rijndael:
                    symatricobject = new RijndaelManaged();
                    break;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.SelectedItem.ToString ();
            switch (s)
            {
                case "DES":
                    SelectEncryption(SymmProvEnum.DES);
                    break;
                case "AES":
                    SelectEncryption(SymmProvEnum.AES);
                    break;
                case "Rijndael":
                    SelectEncryption(SymmProvEnum.Rijndael);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtData.Text!=string.Empty && txtKey.Text!=string.Empty)
            {
                textBox1.Text =Encryption(txtData.Text, txtKey.Text);    
            }
        }
        public string Decrypting(string Source, string Key)
        {
            // convert from Base64 to binary
            byte[] bytIn = System.Convert.FromBase64String(Source);
            // create a MemoryStream with the input
            System.IO.MemoryStream ms = new System.IO.MemoryStream(bytIn, 0, bytIn.Length);

            byte[] bytKey = GetLegalKey(Key);

            // set the private key
            symatricobject.Key = bytKey;
            symatricobject.IV = bytKey;

            // create a Decryptor from the Provider Service instance
            ICryptoTransform encrypto = symatricobject.CreateDecryptor();

            // create Crypto Stream that transforms a stream using the decryption
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);

            // read out the result from the Crypto Stream
            System.IO.StreamReader sr = new System.IO.StreamReader(cs);
            return sr.ReadToEnd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtData.Text != string.Empty && txtKey.Text != string.Empty)
            {
                textBox1.Text = Decrypting(textBox1.Text, txtKey.Text);     
            }
        }
    }
}