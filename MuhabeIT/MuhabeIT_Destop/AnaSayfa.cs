using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhabeIT_Destop.Models;


namespace MuhabeIT_Destop
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
          

        }
        MüsteriEkle Eklemüsteri = new MüsteriEkle();

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            var myControl = new MuhabeIT_Destop.UC.MüsteriEkle();
            panel3.Controls.Add(myControl);

          //  Eklemüsteri.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Size = new Size(909, 629);
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            var ürüncontrol = new MuhabeIT_Destop.UC.ÜrünEkle();
            panel3.Controls.Add(ürüncontrol);

        }
    }
}
