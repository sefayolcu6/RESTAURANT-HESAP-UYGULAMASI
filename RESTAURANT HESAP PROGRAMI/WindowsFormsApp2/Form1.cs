using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true || checkBox8.Checked == true) 
            {
                try
                {
                    int fiyat = 0;

                    if (checkBox1.Checked == true)
                    {
                        int iskembe = Convert.ToInt32(textBox2.Text);
                        fiyat += 3 * iskembe;
                    }
                    if (checkBox1.Checked == false && textBox2.Text == "")
                    {
                        fiyat += 0 * 0;
                    }

                    if (checkBox2.Checked == true)
                    {
                        int ezogelin = Convert.ToInt32(textBox4.Text);
                        fiyat += 5 * ezogelin;
                    }
                    if (checkBox1.Checked == false && textBox3.Text == "")
                    {
                        fiyat += 0 * 0;
                    }

                    if (checkBox3.Checked == true)
                    {
                        int eyemekleri = Convert.ToInt32(textBox6.Text);
                        fiyat += 7 * eyemekleri;
                    }
                    if (checkBox1.Checked == false && textBox4.Text == "")
                    {
                        fiyat += 0 * 0;
                    }

                    if (checkBox4.Checked == true)
                    {
                        int turlu = Convert.ToInt32(textBox7.Text);
                        fiyat += 5 * turlu;
                    }
                    if (checkBox1.Checked == false && textBox5.Text == "")
                    {
                        fiyat += 0 * 0;
                    }

                    if (checkBox5.Checked == true)
                    {
                        int su = Convert.ToInt32(textBox3.Text);
                        fiyat += 1 * su;
                    }
                    if (checkBox1.Checked == false && textBox6.Text == "")
                    {
                        fiyat += 0 * 0;
                    }

                    if (checkBox6.Checked == true)
                    {
                        int kola = Convert.ToInt32(textBox5.Text);
                        fiyat += 4 * kola;
                    }
                    if (checkBox1.Checked == false && textBox7.Text == "")
                    {
                        fiyat += 0 * 0;
                    }

                    if (checkBox7.Checked == true)
                    {
                        int revani = Convert.ToInt32(textBox8.Text);
                        fiyat += 4 * revani;
                    }
                    if (checkBox1.Checked == false && textBox8.Text == "")
                    {
                        fiyat += 0 * 0;
                    }

                    if (checkBox8.Checked == true)
                    {
                        int pudıng = Convert.ToInt32(textBox9.Text);
                        fiyat += 5 * pudıng;
                    }
                    if (checkBox1.Checked == false && textBox9.Text == "")
                    {
                        fiyat += 0 * 0;
                    }
                    label1.Text = "TOPLAM ÖDEMENİZ GEREKEN ÜCRET: " + fiyat.ToString() + " ₺'DIR. BİZİ TERCİH ETTİĞİNİZ İÇİN TEŞEKKÜR EDER, İYİ GÜNLER DİLERİZ..";
                }
                catch
                {
                    MessageBox.Show("HATALI İŞLEM YAPTINIZ!!!!", "HATA UYARISI");
                }

            }
            else
            {
                MessageBox.Show("İşlemleriniz hesaplanamadı. Lütfen kutucukları da işaretleyip tekrar hesaplatın!!!!", "HATA UYARISI");

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
