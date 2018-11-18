using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuhabeIT_Destop.Models;

namespace MuhabeIT_Destop.Database
{
    // ekleme silme güncelleme yapılacagı zaman cmd methodu kullanılacak
    // bir tablodaki bütün bilgiler icin  VeriTablosuCek methodu kullanılacak
    //bir tablodaki bir satır icin VeriSatiriCek methodu kullanılacak
    // bir tablodki bir satırın bir veriri icin vericek methodu kullanilacak


      

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
            VeriDb = "MuhasebeDb";
            String BaglantiYol = "Data Source=www.portsispos.com;Initial Catalog = '" + VeriDb + "'; User ID = sa; Password=@p0rTs|s897*@;";
            SqlConnection baglanti = new SqlConnection(BaglantiYol);
            baglanti.Open();
            return baglanti;
        }
        public int cmd(string Sorgu)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand sorgu = new SqlCommand(Sorgu, baglan);
            int sonuc = 0;
            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + "(" + Sorgu + ")");
            }
            sorgu.Dispose();
            baglan.Close();
            baglan.Dispose();
            return sonuc;
        }

        public DataTable VeriTablosuCek(string sorgu)
        {
            SqlConnection baglanti = this.baglan();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch (SqlException hata)
            {

                throw new Exception(hata.Message +"("+sorgu+")");
            }
            adapter.Dispose();
            baglanti.Close();
            baglanti.Dispose();
            return dt;

        }

        public DataRow VeriSatiriCek(string Sorgu)
        {
            DataTable table = this.VeriTablosuCek(Sorgu);
            DataRow satir;
            if (table.Rows.Count==0)
            {
                satir = null;
            }
            else
            {
                satir = table.Rows[0];
            }
            return satir;
        }

        public string Vericek(string Sorgu)
        {
            DataTable table = this.VeriTablosuCek(Sorgu);
            string veri;
            if (table.Rows.Count==0)
            {
                veri = null;
            }
            else
            {
                veri = table.Rows[0][0].ToString();
            }
            return veri;
        }



    }
}
