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
                DB.cmd("Select * From Login Where KullaniciAdi='" + user + "' and Pw='" + pass + "'");
                MessageBox.Show(user + " Giriş Başarılı Ana Sayfaya Yönlendiriliyorsunuz");
                home.Show();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
           
        }
    }
}
