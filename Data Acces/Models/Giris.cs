using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces.Models
{
    public class Giris
    {
        public int Id { get; set; }
        public string GirisKullaniciAdi { get; set; }
        public string GirisSifre { get; set; }
        public string GirisAdi { get; set; }
        public string GirisSoyadı { get; set; }
        public string GirisBirimi{ get; set; }
        public string GirisGörevi { get; set; }
        public string GirisYetki { get; set; }
    }
}