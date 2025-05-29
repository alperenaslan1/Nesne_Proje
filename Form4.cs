using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text += 1 + Environment.NewLine;
            textBox2.Text += "Mert Hakan" + Environment.NewLine;
            textBox3.Text += "Yandaş"+ Environment.NewLine;
            textBox4.Text += "Kupa" + Environment.NewLine;
            textBox5.Text += "Yok" + Environment.NewLine;
            textBox6.Text += "Beklemede" + Environment.NewLine;

            textBox1.Text += 2 + Environment.NewLine;
            textBox2.Text += "Ali Veli" + Environment.NewLine;
            textBox3.Text += "Battaniye" + Environment.NewLine;
            textBox4.Text += "Kışlık Yardım" + Environment.NewLine;
            textBox5.Text += "Mevcut" + Environment.NewLine;
            textBox6.Text += "Teslim Edildi" + Environment.NewLine;

            textBox1.Text += 3 + Environment.NewLine;
            textBox2.Text += "Ayşe Demir" + Environment.NewLine;
            textBox3.Text += "Gıda Paketi" + Environment.NewLine;
            textBox4.Text += "Erzak" + Environment.NewLine;
            textBox5.Text += "Yok" + Environment.NewLine;
            textBox6.Text += "Hazırlanıyor" + Environment.NewLine;

            textBox1.Text += 4 + Environment.NewLine;
            textBox2.Text += "Kemal Can" + Environment.NewLine;
            textBox3.Text += "Temizlik Seti" + Environment.NewLine;
            textBox4.Text += "Sabun, Deterjan" + Environment.NewLine;
            textBox5.Text += "Var" + Environment.NewLine;
            textBox6.Text += "Dağıtımda" + Environment.NewLine;

            textBox1.Text += 5 + Environment.NewLine;
            textBox2.Text += "Zeynep Kılıç" + Environment.NewLine;
            textBox3.Text += "Oyuncak" + Environment.NewLine;
            textBox4.Text += "Çocuk Yardımı" + Environment.NewLine;
            textBox5.Text += "Bekleniyor" + Environment.NewLine;
            textBox6.Text += "Beklemede" + Environment.NewLine;

            textBox1.Text += 6 + Environment.NewLine;
            textBox2.Text += "Hasan Koç" + Environment.NewLine;
            textBox3.Text += "Mont" + Environment.NewLine;
            textBox4.Text += "Kıyafet Yardımı" + Environment.NewLine;
            textBox5.Text += "Mevcut" + Environment.NewLine;
            textBox6.Text += "Hazır" + Environment.NewLine;

            textBox1.Text += 7 + Environment.NewLine;
            textBox2.Text += "Elif Yılmaz" + Environment.NewLine;
            textBox3.Text += "Hijyen Paketi" + Environment.NewLine;
            textBox4.Text += "Sabun, Maske" + Environment.NewLine;
            textBox5.Text += "Yok" + Environment.NewLine;
            textBox6.Text += "Teslim Edildi" + Environment.NewLine;

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
    }
}

