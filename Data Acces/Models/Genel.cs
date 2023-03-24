using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces.Models
{
    public class Genel
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public int? TCKimlikNo { get; set; }
        public int? SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public string Mudurluk { get; set; }
        public string Seflik { get; set; }
        public string GorevYeri { get; set; }
        public string Unvani { get; set; }
        public string Pozisyonu { get; set; }
        public double? MK { get; set; }
        public double? PK { get; set; }
        public double? ToplamKatsayi { get; set; }
    }
}
