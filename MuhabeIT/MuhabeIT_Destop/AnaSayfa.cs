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
            label1.Text = Login.KullaniciAdi;
            label2.Text = Login.Sifre;
            label3.Text = Login.Departman;
            label4.Text = Login.Yetki;


        }
    }
}
