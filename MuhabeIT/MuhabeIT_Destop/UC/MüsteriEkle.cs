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
using MuhabeIT_Destop.Classlar;
using Microsoft.VisualBasic;
namespace MuhabeIT_Destop.UC
{
    public partial class MüsteriEkle : UserControl
    {
        
        VeriTabani db = new VeriTabani();
        Müsteri mst = new Müsteri();
        public MüsteriEkle()
        {
            InitializeComponent();
            switch (Degiskenler.müsterimod)
            {
                case 1:
                    BtnEkle.Text = "Müsteri Ekle";
                    break;
                case 2:
                    groupBox1.Visible = false;
                                       BtnEkle.Text = "Müsteri Düzenle";
                    break;
                case 3:
                    BtnEkle.Text = "Müsteri Sil";
                    break;
                case 4:
                    BtnEkle.Text = "Müsteri Ara";
                    break;


                default:
                    break;
            }
        }
        private void ekle()
        {
            mst.Ad = müsteriad.Text;
            mst.Soyad = müsterisoyad.Text;
            mst.Tel1 = tel1.Text;
            mst.Tel2 = tel2.Text;
            mst.Tc = textBox1.Text;
            mst.Gsm = textBox2.Text;
          

            if (mst.Ad != "" && mst.Soyad != "" && mst.Tel1 != "" && mst.Tc != "")
            {
                string sorgu = "Insert into  Müsteri(Ad, Soyad, Telefon, Telefon2, Gsm, TC,A) values('" + mst.Ad + "', '" + mst.Soyad + "', '" + mst.Tel1 + "', '" + mst.Tel2 + "', '" + mst.Gsm + "', '" + mst.Tc + "')";
                int gelen = db.cmd(sorgu);
                if (gelen == 1)
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
        private void Düzenle()
        {
          
            mst.Ad = müsteriad.Text;
            mst.Soyad = müsterisoyad.Text;
            mst.Tel1 = tel1.Text;
            mst.Tel2 = tel2.Text;
            mst.Tc = textBox1.Text;
            mst.Gsm = textBox2.Text;
        

            if (mst.Ad != "" && mst.Soyad != "" && mst.Tel1 != "" && mst.Tc != "")
            {
                string sorgu = "Update Müsteri Set  Ad='" + mst.Ad + "',Soyad='" + mst.Soyad + "',Telefon= '" + mst.Tel1 + "',Telefon3= '" + mst.Tel2 + "', Gsm='" + mst.Gsm + "', TC='" + mst.Tc + "' ";
                int gelen = db.cmd(sorgu);
                if (gelen == 1)
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
        private void Sil()
        {

            mst.Ad = müsteriad.Text;
            mst.Soyad = müsterisoyad.Text;
            mst.Tel1 = tel1.Text;
            mst.Tel2 = tel2.Text;
            mst.Tc = textBox1.Text;
            mst.Gsm = textBox2.Text;


            if (mst.Ad != "" && mst.Soyad != "" && mst.Tel1 != "" && mst.Tc != "")
            {
                string sorgu = "Delete Müsteri Set  Ad='" + mst.Ad + "',Soyad='" + mst.Soyad + "',Telefon= '" + mst.Tel1 + "',Telefon3= '" + mst.Tel2 + "', Gsm='" + mst.Gsm + "', TC='" + mst.Tc + "' Where  ";
                int gelen = db.cmd(sorgu);
                if (gelen == 1)
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

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            switch (Degiskenler.müsterimod)
            {
                case 1:
                    ekle();
                    break;
                case 2:

                    break;
                default:
                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String adres = Interaction.InputBox("Adres Giriniz","Adres Ekle","",0,0);
            MessageBox.Show(adres + " Kaydedildi!");
            listBox1.Items.Add(adres);
        }
    }
}
