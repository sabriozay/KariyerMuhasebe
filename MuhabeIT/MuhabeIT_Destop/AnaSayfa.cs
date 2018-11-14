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
            Eklemüsteri.ShowDialog();
        }
    }
}
