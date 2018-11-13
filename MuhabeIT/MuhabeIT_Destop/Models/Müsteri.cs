using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhabeIT_Destop.Models
{
   public class Müsteri
    {
        public int id { get; set; }
        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String Tc { get; set; }
        public String Tel1 { get; set; }
        public String Tel2 { get; set; }
        public String Gsm { get; set; }
        public List<MüsteriExtra> Extra { get; set; }
    }
}
