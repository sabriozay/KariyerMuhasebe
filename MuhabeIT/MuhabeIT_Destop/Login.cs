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
    public partial class Login : Form
    {
        
        VeriTabani db = new VeriTabani();
        public Login()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string pw = textBox2.Text;
            if (kadi == "" && pw == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");
            }
            else
            {
                DataRow veri = db.VeriSatiriCek("Select * From Login where KullaniciAdi='" + kadi + "' and Pw='" + pw + "'");
                if (veri == null)
                {
                    MessageBox.Show("Kullanıcı Adınız veya Sifreniz Hatalı!");
                }
                else
                {
                    MessageBox.Show(kadi + " Giriş Başarılı Ana Sayfaya Yönlendiriliyorsunuz");
                    this.Hide();
                    AnaSayfa home = new AnaSayfa();
                    home.Show();
                }
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();             
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
