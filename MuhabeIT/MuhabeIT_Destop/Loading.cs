﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuhabeIT_Destop
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        public Form1 giris = new Form1();

        private void zaman_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);// yüklenme zaman hızı
            if (progressBar1.Value == 100)//%100 olmasını sağlayan koşul
            {
                zaman.Stop();//zamanlayıcı 100 de 100 olduğunda form1 kapatması için gerekiyor
                this.Hide();               
                giris.ShowDialog();

            }
        }
    }
}
