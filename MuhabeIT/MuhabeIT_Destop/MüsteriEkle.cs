using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuhabeIT_Destop.Database;
using MuhabeIT_Destop.Models;

namespace MuhabeIT_Destop
{
    public partial class MüsteriEkle : Form
    {
        
        public MüsteriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (müsteriad.Text != "" && müsterisoyad.Text != "" && müsteritcbox.Text !="" && tel1.Text != "" && tel2.Text != "" && adresbox.Text !="")
            {
                MessageBox.Show("Kayıt Eklendi!");
            }
            else
            {
                MessageBox.Show("Lütfen alanları Boş Bırakmayınız...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
