using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            

        }

        private void Form6_Load_1(object sender, EventArgs e)
        {
            textBox1.Text += 1 + Environment.NewLine;
            textBox2.Text += "Oyuncak" + Environment.NewLine;
            textBox3.Text += "Ayıcık, kahverengi" + Environment.NewLine;
            textBox4.Text += "1" + Environment.NewLine;
            textBox5.Text += "Alperen Aslan" + Environment.NewLine;
            textBox6.Text += "12/12/2024" + Environment.NewLine;

            textBox1.Text += 2 + Environment.NewLine;
            textBox2.Text += "Su" + Environment.NewLine;
            textBox3.Text += "Kayın su 500 ml" + Environment.NewLine;
            textBox4.Text += "600" + Environment.NewLine;
            textBox5.Text += "Faruk Yılmaz" + Environment.NewLine;
            textBox6.Text += "03/05/2025" + Environment.NewLine;

            textBox1.Text += 3 + Environment.NewLine;
            textBox2.Text += "Un" + Environment.NewLine;
            textBox3.Text += "Ekmeklik 1kg" + Environment.NewLine;
            textBox4.Text += "200kg" + Environment.NewLine;
            textBox5.Text += "Fatih Öz" + Environment.NewLine;
            textBox6.Text += "29/05/2025" + Environment.NewLine;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = richTextBox2.Text;
            string tür = textBox7.Text;
            string detay = textBox8.Text;
            string miktar = textBox10.Text;
            string bagisci = textBox11.Text;
            string tarih = textBox9.Text;
            textBox1.Text += id + Environment.NewLine;
            textBox2.Text += tür + Environment.NewLine;
            textBox3.Text += detay + Environment.NewLine;
            textBox4.Text += miktar + Environment.NewLine;
            textBox5.Text += bagisci + Environment.NewLine;
            textBox6.Text += tarih + Environment.NewLine;
            richTextBox2.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox9.Clear();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
