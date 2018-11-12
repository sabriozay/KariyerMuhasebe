using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuhabeIT_Destop.Models;

namespace MuhabeIT_Destop.Database
{
  


    class VeriTabani
    {
        private static string VeriDb;

        public static string Veri_Db
        {
            get { return VeriDb; }
            set { VeriDb = value; }
        }
        public SqlConnection baglan()
        {
            String BaglantiYol = "Data Source=www.portsispos.com;Initial Catalog = '" + VeriDb + "'; User ID = sa; Password=@p0rTs|s897*@;";
            SqlConnection baglanti = new SqlConnection(BaglantiYol);
            baglanti.Open();
            return baglanti;
        }
        public int cmd(string sqlcumle)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand sorgu = new SqlCommand(sqlcumle, baglan);
            int sonuc = 0;
            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + "(" + sqlcumle + ")");
            }
            sorgu.Dispose();
            baglan.Close();
            baglan.Dispose();
            return sonuc;
        }

        public Login LoginQuary(string kullaniciAdi,String sifre)
        {
            string sql = "select * from Login where KullaniciAdi='"+kullaniciAdi+"' And Pw='"+sifre+"'";
            SqlConnection baglanti =this.baglan();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglanti);
            Login lg = new Login();            
            return lg;
        }



    }
}
