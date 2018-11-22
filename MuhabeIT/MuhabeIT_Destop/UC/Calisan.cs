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
                    textBox1.Text = item.Ad;
                    textBox2.Text = item.Soyad;
                    textBox3.Text = item.Departman;
                    textBox4.Text = item.Yetki;
                    textBox5.Text = item.Maas;
                    textBox6.Text = item.Gsm;
                    textBox7.Text = item.TC;
                    textBox8.Text = item.Adres;
                    label6.Text = item.Id.ToString();
                   

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

           
        }
    }
}
