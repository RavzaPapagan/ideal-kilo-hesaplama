using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru3idealkilohesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isim = Convert.ToString(textBox1.Text);
            string soyisim = Convert.ToString(textBox2.Text);
            double yas = Convert.ToDouble(textBox3.Text);
            double boy = Convert.ToDouble(textBox4.Text);
            double kilo = Convert.ToDouble(textBox5.Text);

            double idealKilo=0;

            if (comboBox1.SelectedIndex == 0)               //cinsiyete göre kilo hesabı 
            {
                idealKilo = (boy - 100 + yas / 10) * 8 / 10;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                idealKilo= (boy - 100 + yas / 10) * 9 / 10;
            }
            else
            {
                MessageBox.Show("Cinsiyeti seçmelisiziz.");
            }

            textBox6.Text = idealKilo.ToString();

            if (kilo > idealKilo)                              //kilo ile ideal kiloyu hesaplayıp karşılaştırır
            {
                label9.Text = "Şişmansın, " + (kilo - idealKilo) + " kilo zayıflamalısın.";
                label9.ForeColor = Color.Red;                 // labelım rengini degiştirmek için
            }
            else if (kilo < idealKilo)
            {
                label9.Text = "Zayıfsın, " + (idealKilo - kilo) + " kilo almalısın.";
                label9.ForeColor = Color.Purple;
            }
            else
            {
                label9.Text = "Bravo ideal kilondasın.";
                label9.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)       //silme işlemi
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label9.Text = "";
            comboBox1.SelectedIndex = -1;
        }
    }
}
