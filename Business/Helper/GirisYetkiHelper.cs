using Business.Services;
using Data_Acces.Models;
using System.Collections.Generic;

namespace Business.Helper
{
    public static class GirisYetkiHelper
    {
        public static List<Genel> VeriFiltrele(string girisYetki)
        {
            GenelService genelService = new GenelService();
            GirisService girisService = new GirisService();

            Giris giris = new Giris();

            return girisYetki == "genel" ? genelService.GetAll()
                : genelService.Get(g => g.Seflik.Contains(girisYetki));

            //g => g.Seflik == yetki

            //LINQ - g ise ne ise g.seflik yetki ise olan tüm ifadeleri getir
            //Bunu liste türlerinde filtreleme gibi işlemler yaparken kullanıyoruz
        }
    }
}
