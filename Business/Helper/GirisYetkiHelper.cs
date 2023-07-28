using Business.Services;
using Data_Acces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper
{
    public static class GirisYetkiHelper
    {
        public static List<Genel> VeriFiltrele()
        {
            string yetki = "TUZLA";

            GenelService genelService = new GenelService();

            return genelService.Get(g => g.Seflik.Contains(yetki));

            //g => g.Seflik == yetki

            //LINQ - g ise ne ise g.seflik yetki ise olan tüm ifadeleri getir
            //Bunu liste türlerinde filtreleme gibi işlemler yaparken kullanıyoruz
        }
    }
}
