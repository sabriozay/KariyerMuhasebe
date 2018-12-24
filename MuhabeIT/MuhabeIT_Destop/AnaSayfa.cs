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
using MuhabeIT_Destop.UC;


 namespace MuhabeIT_Destop
{
    public partial class AnaSayfa : Form
    {
        

        public AnaSayfa()
        {
            InitializeComponent();
          
           
        }
        MüsteriAra Ara = new MüsteriAra();
        MüsteriEkle Ekle = new MüsteriEkle();
        ÜrünEkle ürün = new ÜrünEkle();
        Calisan isci = new Calisan();
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panelkoy(panel2, new MuhabeIT_Destop.UCbaslik.MüsteriSecenek());
            panelkoy(panel3, new MuhabeIT_Destop.UC.MüsteriEkle());    
        }
       public void panelkoy(Panel IlkPanel,UserControl gelen)
        {
            IlkPanel.Controls.Clear();
            IlkPanel.Controls.Add(gelen);
            gelen.Show();
            gelen.Dock = DockStyle.Fill;
            gelen.BringToFront();

        }
        public void panelkoy2(UserControl gelen)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(gelen);
            gelen.Show();
            gelen.Dock = DockStyle.Fill;
            gelen.BringToFront();

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panelkoy(panel2,new MuhabeIT_Destop.UCbaslik.ÜrünSecenek());
            panelkoy(panel3, new MuhabeIT_Destop.UC.ÜrünEkle());

        }
        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panelkoy(panel2, new MuhabeIT_Destop.UCbaslik.CalisanSecenek());
            panelkoy(panel3, new MuhabeIT_Destop.UC.Calisan());
            //panel3.Controls.Clear();
            //panel3.Controls.Add(isci);
            //isci.Show();
            //isci.Dock = DockStyle.Fill;
            //isci.BringToFront();

        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Fatura ftr = new Fatura();
            panel3.Controls.Clear();
            panel3.Controls.Add(ftr);
            ftr.Show();
            ftr.Dock = DockStyle.Fill;
            ftr.BringToFront();
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Controls.Clear();
            panel3.Controls.Add(Ara);
            Ara.Show();
            Ara.Dock = DockStyle.Fill;
            Ara.BringToFront();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("Programdan ÇIKMAK İSTEDİĞİNİZE EMİNMİSİNİZ ?", "UYARI!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                MessageBox.Show("iyi Çalışmalar Dilerim...!");
        } 
    }
}
