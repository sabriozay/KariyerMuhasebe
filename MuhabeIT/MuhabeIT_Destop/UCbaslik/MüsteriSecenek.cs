using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhabeIT_Destop.Classlar;
using MuhabeIT_Destop.UC;


namespace MuhabeIT_Destop.UCbaslik
{
    public partial class MüsteriSecenek : UserControl
    {
        public MüsteriSecenek()
        {
            InitializeComponent();
        }

        MüsteriEkle ekle = new MüsteriEkle();
        private void button1_Click(object sender, EventArgs e)
        {
            
            ekle.groupBox1.Visible = true;
            Degiskenler.müsterimod = 1;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.dataGridView1.Visible = false;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Degiskenler.müsterimod = 2;
            ekle.dataGridView1.Visible = true;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.groupBox1.Visible = true;
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
            Degiskenler.müsterimod = 3;
            ekle.dataGridView1.Visible = true;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.groupBox1.Visible = false;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Degiskenler.müsterimod = 4;
            ekle.dataGridView1.Visible = true;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Clear();
            ekle.groupBox1.Visible = false;
            MuhabeIT_Destop.AnaSayfa.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
        }
    }
}
