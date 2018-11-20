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
    public partial class MusteriEkle : Form
    {
        VeriTabani db = new VeriTabani();
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (müsteriad.Text != "" && müsterisoyad.Text != "" && tel1.Text != "" &&  adres.Text != "")
            {
                string sorgu = "Insert into Müsteri(Ad, Soyad, Telefon, Telefon2, Gsm, TC) values('"+müsteriad.Text+ "', '" + müsterisoyad.Text + "', '" + tel1.Text + "', '" + tel2.Text + "', '" + tel2.Text + "', '" + müsteriad.Text + "')";
               int gelen= db.cmd(sorgu);
                MessageBox.Show(gelen.ToString());
                MessageBox.Show("Kayıt Eklendi!");
            }
            else
            {
                MessageBox.Show("Lütfen alanları Boş Bırakmayınız...");
            }
        }
      
    }
}
