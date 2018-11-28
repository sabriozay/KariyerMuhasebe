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
using System.Data.SqlClient;

namespace MuhabeIT_Destop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        
        AnaSayfa home = new AnaSayfa();
        SqlCommand komut = new SqlCommand();

        private void button1_Click(object sender, EventArgs e)
        {
          
           
        }
    }
}
