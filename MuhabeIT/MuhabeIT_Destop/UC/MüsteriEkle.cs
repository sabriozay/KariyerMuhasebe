using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhabeIT_Destop.Models;
using MuhabeIT_Destop.Database;
namespace MuhabeIT_Destop.UC
{
    public partial class MüsteriEkle : UserControl
    {
        VeriTabani db = new VeriTabani();
        Müsteri mst = new Müsteri();
        public MüsteriEkle()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            mst.Ad = müsteriad.Text;
            mst.Soyad = müsterisoyad.Text;
            mst.Tel1 = tel1.Text;
            mst.Tel2 = tel2.Text;
            mst.Tc = textBox1.Text;
            mst.Gsm = textBox2.Text;
            String adres =AdresTxt.Text;

            if (mst.Ad!="" && mst.Soyad!="" && mst.Tel1 != "" &&  mst.Tc != "" &&  adres!="")
            {
                string sorgu = "Insert into  Müsteri(Ad, Soyad, Telefon, Telefon2, Gsm, TC) values('" + mst.Ad + "', '" + mst.Soyad + "', '" + mst.Tel1 + "', '" + mst.Tel2 + "', '" + mst.Gsm + "', '" + mst.Tc + "')";
                int gelen = db.cmd(sorgu);
                if (gelen==1)
                {
                    MessageBox.Show(mst.Ad + " Müşterisi Kayıt Edildi");

                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız");     
                }

            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız");

            }


        }
    }
}
