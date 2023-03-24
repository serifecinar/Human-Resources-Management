using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces.Models
{
    public class Genel
    {
        public int PersonelId { get; set; }
        public int TCKimlikNo { get; set; }
        public int SicilNo { get; set; }
        public String Adi { get; set; }
        public String Soyadi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public String Mudurluk { get; set; }
        public String Seflik { get; set; }
        public String GorevYeri { get; set; }
        public String Unvani { get; set; }
        public String Pozisyonu { get; set; }
        public Double MK { get; set; }
        public Double PK { get; set; }
        public Double ToplamKatsayi { get; set; }

    }
}
