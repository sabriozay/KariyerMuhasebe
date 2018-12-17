using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhabeIT_Destop.UC;
using MuhabeIT_Destop.UCbaslik;
using MuhabeIT_Destop.Classlar;

namespace MuhabeIT_Destop.UCbaslik
{
    public partial class CalisanSecenek : UserControl
    {
        public CalisanSecenek()
        {
            InitializeComponent();
        }
        Calisan ekle = new Calisan();
       


        private void button1_Click_1(object sender, EventArgs e)
        {
            ekle.groupBox1.Visible = true;
            Degiskenler.employecode = 1;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.dataGridView1.Visible = false;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Degiskenler.employecode = 2;
            ekle.dataGridView1.Visible = true;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.groupBox1.Visible = false;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Degiskenler.employecode = 3;
            ekle.dataGridView1.Visible = true;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.groupBox1.Visible = false;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }
    }
}
