using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhabeIT_Destop.Database;
using MuhabeIT_Destop.Models;

namespace MuhabeIT_Destop.UC
{

    public partial class Calisan : UserControl
    {
        VeriTabani db = new VeriTabani();
        List<CalisanModel> Clist = new List<CalisanModel>();
        public Calisan()
        {
            InitializeComponent();

            tabloyuGüncelle();
        }

        private void tabloyuGüncelle()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            Clist.Clear();

            DataTable dt = db.VeriTablosuCek("select * from Calisan");
            foreach (DataRow Satir in dt.Rows)
            {
                CalisanModel cls = new CalisanModel();
                cls.Id = int.Parse(Satir["Id"].ToString());
                cls.Ad = Satir["Ad"].ToString();
                cls.Soyad = Satir["Soyadi"].ToString();
                cls.Departman = Satir["Departman"].ToString();
                cls.Yetki = Satir["Yetki"].ToString();
                cls.Maas = Satir["Maas"].ToString();
                cls.Gsm = Satir["Gsm"].ToString();
                cls.TC = Satir["TC"].ToString();
                cls.Adres = Satir["Adres"].ToString();
                Clist.Add(cls);

            }
            foreach (CalisanModel item in Clist)
            {
                dataGridView1.Rows.Add(item.Id, item.Ad, item.Soyad);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            foreach (CalisanModel item in Clist)
            {
                if (secilenId == item.Id)
                {
                    adtxt.Text = item.Ad;
                    sydtxt.Text = item.Soyad;
                    departtxt.Text = item.Departman;
                    yetktxt.Text = item.Yetki;
                    maastxt.Text = item.Maas;
                    teltxt.Text = item.Gsm;
                    tctxt.Text = item.TC;
                    adrstxt.Text = item.Adres;
                    label6.Text = item.Id.ToString();
                   

                }
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            CalisanModel isci = new CalisanModel();
            isci.Ad = adtxt.Text;
            isci.Soyad = sydtxt.Text;
            isci.Departman = departtxt.Text;
            isci.Yetki = yetktxt.Text;
            isci.Maas = maastxt.Text;
            isci.Gsm = teltxt.Text;
            isci.TC = tctxt.Text;
            isci.Adres = adrstxt.Text;
            if (isci.Ad !="" && isci.Soyad !="" && isci.Departman !="" && isci.Yetki !="" && isci.Maas !="" && isci.Gsm !="" && isci.TC !="" && isci.Adres !="")
            {
                int gelen = db.cmd("insert into Calisan (Ad,Soyadi,Departman,Yetki,Maas,Gsm,TC,Adres) Values ('" + isci.Ad + "','" +isci.Soyad+"','" +isci.Departman+"','"+isci.Yetki+"','"+isci.Maas+"','"+isci.Gsm+"','"+isci.TC+"','"+isci.Adres+"')");
                if (gelen == 1)
                {
                    MessageBox.Show("Personel Başarıyla Eklendi");
                    tabloyuGüncelle();
                    
                }
                else
                {
                    MessageBox.Show("Lütfen Bilgileri Kontrol Edin");
                }

            }
            else
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz");
            }

           
        }
    }
}
