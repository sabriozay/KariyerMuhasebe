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
using MuhabeIT_Destop.Classlar;
using System.Data.SqlClient;
namespace MuhabeIT_Destop.UC
{
    public partial class MüsteriAra : UserControl
    {
        public MüsteriAra()
        {
            InitializeComponent();
        }
        
        DataTable tablo = new DataTable();
        VeriTabani db = new VeriTabani();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="")
            {
                string bilgi = textBox1.Text;
                string sorgu = ("SELECT * FROM Müsteri WHERE TC='" + textBox1.Text + "'");               
                int gelen = db.cmd(sorgu);
                if (gelen == 1)
                {
                    DataSet ds = new DataSet();
                    dataGridView1.DataSource = ds.Tables["Müsteri"];
                    MessageBox.Show(bilgi + "Müşteri Görüntülendi");
                }
                else
                {
                    MessageBox.Show("Kayıt Görüntülenemedi!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen TC Kimlik Numarasını Kontrol Ediniz..!");
            }
            
           
           
        }
    }
}
