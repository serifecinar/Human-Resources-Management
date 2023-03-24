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
        public int PersonelId { get; set; }
        public String Il { get; set; }
        public String Ilce { get; set; }
        public String Mahalle { get; set; }
        public String Sokak { get; set; }
        public int KapiNo1 { get; set; }
        public int KapiNo2 { get; set; }
        public int Daire { get; set; }
        public int CepTelNo1 { get; set; }
        public int CepTelNo2 { get; set; }
        public String EMailAdresi { get; set; }
    }
}
