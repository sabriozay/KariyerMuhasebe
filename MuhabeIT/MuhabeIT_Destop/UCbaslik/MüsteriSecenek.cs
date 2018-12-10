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
        AnaSayfa home = new AnaSayfa();
        
        MüsteriEkle ekle = new MüsteriEkle();
        private void button1_Click(object sender, EventArgs e)
        {

            home.panel3.Controls.Clear();
            home.panel3.Controls.Add(ekle);
            ekle.Dock = DockStyle.Fill;
            ekle.BringToFront();
            Degiskenler.müsterimod = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Degiskenler.müsterimod = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Degiskenler.müsterimod = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Degiskenler.müsterimod = 4;
        }   
    }
}
