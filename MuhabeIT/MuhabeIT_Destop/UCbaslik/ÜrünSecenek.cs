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

namespace MuhabeIT_Destop.UCbaslik
{
    public partial class ÜrünSecenek : UserControl
    {
        public ÜrünSecenek()
        {
            InitializeComponent();
        }
        ÜrünEkle ekle = new ÜrünEkle();

        private void ürünekle_Click(object sender, EventArgs e)
        {
            ekle.Show();
        }
    }
}
