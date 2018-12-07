using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_06_Encryption
{
    public partial class Encryption : Form
    {
        Random rastgele = new Random();
        string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
        string uret = "";
        public int sayi;
        public int i = 0;

        public Encryption()
        {

            InitializeComponent();
        }

        private void btn_Enc_Click(object sender, EventArgs e)
        {
            if (txt_words.Text == "")
                MessageBox.Show ("Please fill the box");
            else
            { 
            sayi = rastgele.Next(1, 9);
            txt_Result.Text = "";
            string encodedText = "";
            //string encKey = txt_Key.Text;
            List<char> chrText = txt_words.Text.ToCharArray().ToList();
            //List<char> chrKey = txt_Key.Text.ToCharArray().ToList();
 
            for (int i = 0; i < chrText.Count; i++)
            {
                encodedText = encodedText + (char)(chrText[i] +2) ;
                
            }


           while (i<sayi)
                {
                uret = uret + harfler[rastgele.Next(harfler.Length)];
                
                i++;
            }
            encodedText = encodedText + uret;
            encodedText = encodedText + sayi;

           

            txt_Result.Text = encodedText;

            lbl_result.Text = "Encrypted Text";
            }

        }

        private void btn_Dec_Click(object sender, EventArgs e)
        {
            if (txt_words.Text =="")
                MessageBox.Show("Please fill the box");
            else
            { 

                string decodedText = "";
            sayi += 1;
            var dec = txt_words.Text.Remove(txt_words.Text.Length - sayi );

            List<char> chrText = dec.ToCharArray().ToList();



            for (int i = 0; i < chrText.Count; i++)
            {
                decodedText = decodedText + (char)(chrText[i] - 2)  ;

            }
            
            txt_Result.Text = decodedText;
            lbl_result.Text = "Decrypted Text";

        }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
    }

