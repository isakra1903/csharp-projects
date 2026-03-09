using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaci
{
    public partial class Form1 : Form
    {
        int fiyat = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                fiyat += 10;
            }
            else
            {
                fiyat -= 10;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                fiyat += 15;
            }
            else
            {
                fiyat -= 15;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) {
                fiyat += 20;
            }
            else
            {
                fiyat -= 20;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                fiyat += 20;
            }
            else
            {
                fiyat -= 20;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";


        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked) 
            {
                fiyat += 0;
            }
            else 
            {
                fiyat -= 0;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked) 
            {
                fiyat += 10;
            }
            else 
            {
                fiyat -= 10;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton6.Checked)
            {
                fiyat += 20;
            }
            else 
            {
                fiyat -= 20;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) 
            {
                fiyat += 25;
            }
            else 
            { 
                fiyat -= 25;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) 
            {
                fiyat += 3;
            }
            else 
            {
                fiyat -= 3;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) 
            {
                fiyat += 8;
            }
            else 
            {
                fiyat -= 8;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) 
            {
                fiyat += 1;
            }
            else 
            {
                fiyat -= 1;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) 
            {
                fiyat += 3;
            }
            else 
            {
                fiyat -= 3;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) 
            {
                fiyat += 2;
            }
            else 
            {
                fiyat -= 2;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                fiyat += 2;
            }
            else
            {
                fiyat -= 2;
            }
            label12.Text = fiyat.ToString() + " Türk Lirası";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad= textBox2.Text;
            string adresBaslıgı= textBox3.Text;
            string telefon= textBox4.Text;
            string AcikAdres=richTextBox1.Text;
            if(ad != "" && soyad != "" && adresBaslıgı != "" && telefon != "" && AcikAdres != "") 
            {
                MessageBox.Show("Siparişiniz Alındı");
            }
            else 
            {
                MessageBox.Show("Boş alan bırakmayın");
            }

        }
    }
}
