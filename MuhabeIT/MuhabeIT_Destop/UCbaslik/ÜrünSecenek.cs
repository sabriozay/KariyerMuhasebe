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
using MuhabeIT_Destop.Classlar;
using MuhabeIT_Destop.Formlar;
namespace MuhabeIT_Destop.UCbaslik
{
    public partial class ÜrünSecenek : UserControl
    {
        public ÜrünSecenek()
        {
            InitializeComponent();
        }
        ÜrünEkle ekle = new ÜrünEkle();
        private void button1_Click(object sender, EventArgs e)
        {
            ekle.groupBox2.Visible = true;
            Degiskenler.productcode = 1;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.dataGridView1.Visible = false;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ekle.groupBox2.Visible = false;
            Degiskenler.productcode = 2;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.dataGridView1.Visible = true;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Degiskenler.productcode = 3;
            ekle.dataGridView1.Visible = true;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.groupBox2.Visible = false;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Degiskenler.müsterimod = 4;
            ekle.dataGridView1.Visible = true;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.groupBox2.Visible = false;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }
    }
}
