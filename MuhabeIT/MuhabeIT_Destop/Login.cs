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
using System.Data.SqlClient;



namespace MuhabeIT_Destop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        
        AnaSayfa home = new AnaSayfa();
        VeriTabani DB = new VeriTabani();
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            if (textBox1.Text !="" && textBox2.Text !="")
            {
                String Sorgu=("Select * From Login Where KullaniciAdi='" + user.ToString() + "' and Pw='" + pass.ToString() + "'");
                int gelen = DB.cmd(Sorgu);
                if (gelen==1)
                {
                    MessageBox.Show(user + " Giriş Başarılı Ana Sayfaya Yönlendiriliyorsunuz");
                    home.Show();                  
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız");
                }
            }
            else
            {
                MessageBox.Show("Lütfen ID ve Şifreyi Boş Bırakmayınız...!");
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
