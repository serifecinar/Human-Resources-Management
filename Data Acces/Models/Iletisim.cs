using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acces.Models
{
    public class Iletisim
    {
        public int Id { get; set; }
        public int? PersonelId { get; set; }
        public string Seflik { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public string KapiNo1 { get; set; }
        public string KapiNo2 { get; set; }
        public string Daire { get; set; }
        public string CepTelNo1 { get; set; }
        public string CepTelNo2 { get; set; }
        public string EMailAdresi { get; set; }
    }
}
