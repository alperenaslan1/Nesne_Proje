using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text += 1 + Environment.NewLine;
            textBox6.Text += "Alperen" + Environment.NewLine;
            textBox2.Text += "Aslan" + Environment.NewLine;
            textBox3.Text += "5532535345" + Environment.NewLine;
            textBox4.Text += "alperen@hotmail.com" + Environment.NewLine;
            textBox5.Text += "kuzeykent 1 2 3" + Environment.NewLine;

            textBox1.Text += 2 + Environment.NewLine;
            textBox6.Text += "İrem" + Environment.NewLine;
            textBox2.Text += "Çetinkol" + Environment.NewLine;
            textBox3.Text += "5345555789" + Environment.NewLine;
            textBox4.Text += "iremc@gmail.com" + Environment.NewLine;
            textBox5.Text += "Kuzeykent kız yurdu kastamonu " + Environment.NewLine;

            textBox1.Text += 3 + Environment.NewLine;
            textBox6.Text += "Faruk" + Environment.NewLine;
            textBox2.Text += "Çetin" + Environment.NewLine;
            textBox3.Text += "5535448791" + Environment.NewLine;
            textBox4.Text += "faruk123@gmail.com" + Environment.NewLine;
            textBox5.Text += "ankara çankaya 1. sokak 55/4" + Environment.NewLine;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string id = richTextBox2.Text;
            string adres = textBox7.Text;
            string telefon = textBox8.Text;
            string soyad = textBox10.Text;
            string email = textBox11.Text;
            string ad = textBox9.Text;
            textBox1.Text += id + Environment.NewLine;
            textBox2.Text += soyad + Environment.NewLine;
            textBox3.Text += telefon + Environment.NewLine;
            textBox4.Text += email + Environment.NewLine;
            textBox5.Text += adres + Environment.NewLine;
            textBox6.Text += ad + Environment.NewLine;
            richTextBox2.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox9.Clear();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
