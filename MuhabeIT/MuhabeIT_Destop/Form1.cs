using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhabeIT_Destop.Database;
using MuhabeIT_Destop.Models;

namespace MuhabeIT_Destop
{
    public partial class Form1 : Form
    {
        VeriTabani db = new VeriTabani();
        public Form1()
        {
            
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string pw = textBox2.Text;
            if (kadi == "" && pw == "")
            {
                MessageBox.Show("Lütfen Bos Alan Bırakmayınız");
            }
            else
            {
            DataRow veri = db.VeriSatiriCek("Select * From Login where KullaniciAdi='"+ kadi + "' and Pw='"+pw+"'");
                if (veri==null)
                {
                    MessageBox.Show("Kullanıcı Adınız veya Sifreniz Hatalı");
                }
                else
                {
            MessageBox.Show(kadi + " Giriş Başarılı Lütfen Bekleyiniz");
            Login.KullaniciAdi = veri[1].ToString();
            Login.Sifre = veri[2].ToString();
            Login.Yetki = veri[3].ToString();
            Login.Departman = veri[4].ToString();
             Form frm = new AnaSayfa();
             this.Hide();
              frm.Show();
                }
        
            }
          

          

        }
    }
}
