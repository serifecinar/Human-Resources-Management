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
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public int? KapiNo1 { get; set; }
        public int? KapiNo2 { get; set; }
        public int? Daire { get; set; }
        public int? CepTelNo1 { get; set; }
        public int? CepTelNo2 { get; set; }
        public string EMailAdresi { get; set; }
    }
}
