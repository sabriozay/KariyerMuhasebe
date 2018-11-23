using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MuhabeIT_Destop.UC;
using MuhabeIT_Destop.Models;
using MuhabeIT_Destop.Database;

namespace MuhabeIT_Destop.UC
{
    public partial class ÜrünEkle : UserControl
    {
        VeriTabani db = new VeriTabani();
        Ürün ürn = new Ürün();
        
        public ÜrünEkle()
        {
            InitializeComponent();
        }

        private void Ürnekle_Click(object sender, EventArgs e)
        {
            ürn.Ürün_Adi = textBox1.Text;
            ürn.Ürün_Adeti = textBox2.Text;
            ürn.Ürün_Birimi = textBox3.Text;
            ürn.Ürün_Birim_Fiyat = textBox4.Text;
            ürn.Ürün_SeriNo = textBox5.Text;
            ürn.Aciklama = textBox6.Text;
            if (ürn.Ürün_Adi != "" && ürn.Ürün_Adeti != "" && ürn.Ürün_Birimi != "" && ürn.Ürün_Birim_Fiyat != "" && ürn.Ürün_SeriNo != "" && ürn.Aciklama != "")
            {
                string sorgu = "Insert into Ürünler(Ürün_Adi,Ürün_Adeti,Ürün_Birimi,Ürün_Birim_Fiyat,Ürün_SeriNo,Aciklama)Values('" + ürn.Ürün_Adi+"','" + ürn.Ürün_Adeti + "','" + ürn.Ürün_Birimi + "','" + ürn.Ürün_Birim_Fiyat + "','" + ürn.Ürün_SeriNo + "','" + ürn.Aciklama +"')";
                int gelen = db.cmd(sorgu);
                if (gelen == 1)
                {
                    MessageBox.Show(ürn.Ürün_Adi + "Ürünü Kayıt Edildi");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız Lütfen Bilgilerinizi Kontrol Edin");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Alanları Boş Bırakmayınız..!");

            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
