using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasaporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imie = textBox3.Text;
            string nazwisko = textBox2.Text;
            string kolor = "";
            if(nazwisko=="" || imie=="")
            {
                MessageBox.Show("Wprowadź dane");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    kolor = "niebieskie";
                }
                else if (radioButton2.Checked)
                {
                    kolor = "zielone";
                }
                else if (radioButton3.Checked)
                {
                    kolor = "piwne";
                }
                MessageBox.Show(imie + " " + nazwisko + " " + kolor);
            }
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var numer = textBox1.Text;
            if (numer == "000")
            {
                pictureBox1.Load("000-zdjecie.jpg");
                pictureBox2.Load("000-odcisk.jpg");
            }
            else if (numer == "111")
            {
                pictureBox1.Load("111-zdjecie.jpg");
                pictureBox2.Load("111-odcisk.jpg");
            }
            else if (numer == "333")
            {
                pictureBox1.Load("333-zdjecie.jpg");
                pictureBox2.Load("333-odcisk.jpg");
            }
            else
            {
                pictureBox1.Load("nic.png");
                pictureBox2.Load("nic.png");
            }
        }
    }
}
