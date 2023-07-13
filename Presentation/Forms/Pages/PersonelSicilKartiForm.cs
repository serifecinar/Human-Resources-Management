using Business.Services;
using Data_Acces.Models;
using DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PersonelSicilKartiForm : Form
    {
        GenelService genelService = new GenelService();
        NufusService nufusService = new NufusService();
        TahsilService tahsilService = new TahsilService();
        SertifikaService sertifikaService = new SertifikaService();
        NakilService nakilService = new NakilService();
        IletisimService iletisimService = new IletisimService();

        Genel genel = new Genel();
        Nufus nufus = new Nufus();
        Tahsil tahsil = new Tahsil();
        Sertifika sertifika = new Sertifika();
        Nakil nakil = new Nakil();
        Iletisim iletisim = new Iletisim();

        private object convert;

        public PersonelSicilKartiForm(int personelId)
        {
            InitializeComponent();

            genel = genelService.GetByPersonelId(personelId);
            nufus = nufusService.GetByPersonelId(personelId);
            tahsil = tahsilService.GetByPersonelId(personelId);
            sertifika = sertifikaService.GetByPersonelId(personelId);
            nakil = nakilService.GetByPersonelId(personelId);
            iletisim = iletisimService.GetByPersonelId(personelId);

           //Genel 
            TCKimlikNoTextBox.Text = genel.TCKimlikNo;
            SicilNoTextBox.Text = Convert.ToString(genel.SicilNo);
            AdiTextBox.Text = genel.Adi;
            SoyadiTextBox.Text = genel.Soyadi;
            IseGirisTarihiTextBox.Text = Convert.ToString(genel.IseGirisTarihi);
            MudurlukTextBox.Text = genel.Mudurluk;
            SeflikTextBox.Text = genel.Seflik;
            GorevYeriTextBox.Text = genel.GorevYeri;
            UnvaniTextBox.Text = genel.Unvani;
            MKTextBox.Text = Convert.ToString(genel.MK);
            PKTextBox.Text = Convert.ToString(genel.PK);
            ToplamKatsayiTextBox.Text = Convert.ToString(genel.ToplamKatsayi);

            //Nüfus
            CinsiyetTextBox.Text = nufus.Cinsiyet;
            AnneAdiTextBox.Text = nufus.AnneAdi;
            BabaAdiTextBox.Text = nufus.BabaAdi;
            DogumTarihiTextBox.Text = Convert.ToString(nufus.DogumTarihi);
            DogumYeriTextBox.Text = nufus.DogumYeri;
            KanGrubuTextBox.Text = nufus.KanGrubu;
            MedinHaliTextBox.Text = nufus.MedeniHali;
            AskerlikTextBox.Text = nufus.Askerlik;
            NufusaKayitliOlduguIlTextBox.Text = nufus.NufusaKayitliOlduguIl;
            EsAdiTextBox.Text = nufus.EsAdi;
            EsMeslegiTextBox.Text = nufus.EsMeslegi;
            EsCalismaDurumuTextBox.Text = nufus.EsCalismaDurumu;
            EsCalistigiKurumAdiTextBox.Text = nufus.EsCalistigiKurumAdi;
            CocukSayisiTextBox.Text = Convert.ToString(nufus.CocukSayisi);

            //1.Çocuk
            CocukAdi1TextBox.Text = nufus.CocukAdi1;
            CocukCinsiyeti1TextBox.Text = nufus.CocukCinsiyeti1;
            CocukDogumTarihi1TextBox.Text = Convert.ToString(nufus.CocukDogumTarihi1);
            CocukHakkinda1TextBox.Text = nufus.CocukHakkinda1;
            //2.Çocuk
            CocukAdi2TextBox.Text = nufus.CocukAdi2;
            CocukCinsiyeti2TextBox.Text = nufus.CocukCinsiyeti2;
            CocukDogumTarihi2TextBox.Text = Convert.ToString(nufus.CocukDogumTarihi2);
            CocukHakkinda2TextBox.Text = nufus.CocukHakkinda2;
            //3.Çocuk
            CocukAdi3TextBox.Text = nufus.CocukAdi3;
            CocukCinsiyeti3TextBox.Text = nufus.CocukCinsiyeti3;
            CocukDogumTarihi3TextBox.Text = Convert.ToString(nufus.CocukDogumTarihi3);
            CocukHakkinda3TextBox.Text = nufus.CocukHakkinda3;
            //4.Çocuk
            CocukAdi4TextBox.Text = nufus.CocukAdi4;
            CocukCinsiyeti4TextBox.Text = nufus.CocukCinsiyeti4;
            CocukDogumTarihi4TextBox.Text = Convert.ToString(nufus.CocukDogumTarihi4);
            CocukHakkinda4TextBox.Text = nufus.CocukHakkinda4;
            //5.Çocuk
            CocukAdi5TextBox.Text = nufus.CocukAdi5;
            CocukCinsiyeti5TextBox.Text = nufus.CocukCinsiyeti5;
            CocukDogumTarihi5TextBox.Text = Convert.ToString(nufus.CocukDogumTarihi5);
            CocukHakkinda5TextBox.Text = nufus.CocukHakkinda5;
            //6.Çocuk
            CocukAdi6TextBox.Text = nufus.CocukAdi6;
            CocukCinsiyeti6TextBox.Text = nufus.CocukCinsiyeti6;
            CocukDogumTarihi6TextBox.Text = Convert.ToString(nufus.CocukDogumTarihi6);
            CocukHakkinda6TextBox.Text = nufus.CocukHakkinda6;

            //1. Tahsil 
            TahsilAdi1TextBox.Text = tahsil.TahsilAdi1;
            OkulAdi1TextBox.Text = tahsil.OkulAdi1;
            BolumAdi1TextBox.Text = tahsil.BolumAdi1;
            MezuniyetTarihi1TextBox.Text = Convert.ToString(tahsil.MezuniyetTarihi1);

            //2. Tahsil 
            TahsilAdi2TextBox.Text = tahsil.TahsilAdi2;
            OkulAdi2TextBox.Text = tahsil.OkulAdi2;
            BolumAdi2TextBox.Text = tahsil.BolumAdi2;
            MezuniyetTarihi2TextBox.Text = Convert.ToString(tahsil.MezuniyetTarihi2);

            //3. Tahsil 
            TahsilAdi3TextBox.Text = tahsil.TahsilAdi3;
            OkulAdi3TextBox.Text = tahsil.OkulAdi3;
            BolumAdi3TextBox.Text = tahsil.BolumAdi3;
            MezuniyetTarihi3TextBox.Text = Convert.ToString(tahsil.MezuniyetTarihi3);

            //4. Tahsil 
            TahsilAdi4TextBox.Text = tahsil.TahsilAdi4;
            OkulAdi4TextBox.Text = tahsil.OkulAdi4;
            BolumAdi4TextBox.Text = tahsil.BolumAdi4;
            MezuniyetTarihi4TextBox.Text = Convert.ToString(tahsil.MezuniyetTarihi4);

            //5. Tahsil 
            TahsilAdi5TextBox.Text = tahsil.TahsilAdi5;
            OkulAdi5TextBox.Text = tahsil.OkulAdi5;
            BolumAdi5TextBox.Text = tahsil.BolumAdi5;
            MezuniyetTarihi5TextBox.Text = Convert.ToString(tahsil.MezuniyetTarihi5);

            //Sertifika
            //Sertifika1TextBox.Text = sertifika.SertifikaAdi1;
            //Sertifika2TextBox.Text = sertifika.SertifikaAdi2;
            //Sertifika3TextBox.Text = sertifika.SertifikaAdi3;
            //Sertifika4TextBox.Text = sertifika.SertifikaAdi4;
            //Sertifika5TextBox.Text = sertifika.SertifikaAdi5;
            //Sertifika6TextBox.Text = sertifika.SertifikaAdi6;
            //Sertifika7TextBox.Text = sertifika.SertifikaAdi7;
            //Sertifika8TextBox.Text = sertifika.SertifikaAdi8;
            //Sertifika9TextBox.Text = sertifika.SertifikaAdi9;
            //Sertifika10TextBox.Text = sertifika.SertifikaAdi10;

            //1.Nakil
            BaslangicTarihi1TextBox.Text = Convert.ToString(nakil.BaslangicTarihi1);
            AyrilisTarihi1TextBox.Text = Convert.ToString(nakil.AyrilisTarihi1);
            Kurum1TextBox.Text = nakil.Kurum1;
            Birim1TextBox.Text = nakil.Birim1;
            Gorev1TextBox.Text = nakil.Gorev1;
            Aciklama1TextBox.Text = nakil.Aciklama1;

            //2.Nakil
            BaslangicTarihi2TextBox.Text = Convert.ToString(nakil.BaslangicTarihi2);
            AyrilisTarihi2TextBox.Text = Convert.ToString(nakil.AyrilisTarihi2);
            Kurum2TextBox.Text = nakil.Kurum2;
            Birim2TextBox.Text = nakil.Birim2;
            Gorev2TextBox.Text = nakil.Gorev2;
            Aciklama2TextBox.Text = nakil.Aciklama2;

            //3.Nakil
            BaslangicTarihi3TextBox.Text = Convert.ToString(nakil.BaslangicTarihi3);
            AyrilisTarihi3TextBox.Text = Convert.ToString(nakil.AyrilisTarihi3);
            Kurum3TextBox.Text = nakil.Kurum3;
            Birim3TextBox.Text = nakil.Birim3;
            Gorev3TextBox.Text = nakil.Gorev3;
            Aciklama3TextBox.Text = nakil.Aciklama3;

            //4.Nakil
            BaslangicTarihi4TextBox.Text = Convert.ToString(nakil.BaslangicTarihi4);
            AyrilisTarihi4TextBox.Text = Convert.ToString(nakil.AyrilisTarihi4);
            Kurum4TextBox.Text = nakil.Kurum4;
            Birim4TextBox.Text = nakil.Birim4;
            Gorev4TextBox.Text = nakil.Gorev4;
            Aciklama4TextBox.Text = nakil.Aciklama4;

            //5.Nakil
            BaslangicTarihi5TextBox.Text = Convert.ToString(nakil.BaslangicTarihi5);
            AyrilisTarihi5TextBox.Text = Convert.ToString(nakil.AyrilisTarihi5);
            Kurum5TextBox.Text = nakil.Kurum5;
            Birim5TextBox.Text = nakil.Birim5;
            Gorev5TextBox.Text = nakil.Gorev5;
            Aciklama5TextBox.Text = nakil.Aciklama5;

            //6.Nakil
            BaslangicTarihi6TextBox.Text = Convert.ToString(nakil.BaslangicTarihi6);
            AyrilisTarihi6TextBox.Text = Convert.ToString(nakil.AyrilisTarihi6);
            Kurum6TextBox.Text = nakil.Kurum6;
            Birim6TextBox.Text = nakil.Birim6;
            Gorev6TextBox.Text = nakil.Gorev6;
            Aciklama6TextBox.Text = nakil.Aciklama6;

            //7.Nakil
            BaslangicTarihi7TextBox.Text = Convert.ToString(nakil.BaslangicTarihi7);
            AyrilisTarihi7TextBox.Text = Convert.ToString(nakil.AyrilisTarihi7);
            Kurum7TextBox.Text = nakil.Kurum7;
            Birim7TextBox.Text = nakil.Birim7;
            Gorev7TextBox.Text = nakil.Gorev7;
            Aciklama7TextBox.Text = nakil.Aciklama7;

            //8.Nakil
            BaslangicTarihi8TextBox.Text = Convert.ToString(nakil.BaslangicTarihi8);
            AyrilisTarihi8TextBox.Text = Convert.ToString(nakil.AyrilisTarihi8);
            Kurum8TextBox.Text = nakil.Kurum8;
            Birim8TextBox.Text = nakil.Birim8;
            Gorev8TextBox.Text = nakil.Gorev8;
            Aciklama8TextBox.Text = nakil.Aciklama8;

            //9.Nakil
            BaslangicTarihi9TextBox.Text = Convert.ToString(nakil.BaslangicTarihi9);
            AyrilisTarihi9TextBox.Text = Convert.ToString(nakil.AyrilisTarihi9);
            Kurum9TextBox.Text = nakil.Kurum9;
            Birim9TextBox.Text = nakil.Birim9;
            Gorev9TextBox.Text = nakil.Gorev9;
            Aciklama9TextBox.Text = nakil.Aciklama9;

            //10.Nakil
            BaslangicTarihi10TextBox.Text = Convert.ToString(nakil.BaslangicTarihi10);
            AyrilisTarihi10TextBox.Text = Convert.ToString(nakil.AyrilisTarihi10);
            Kurum10TextBox.Text = nakil.Kurum10;
            Birim10TextBox.Text = nakil.Birim10;
            Gorev10TextBox.Text = nakil.Gorev10;
            Aciklama10TextBox.Text = nakil.Aciklama10;

            //Iletisim
            MahalleTextBox.Text = iletisim.Mahalle;
            SokakTextBox.Text = iletisim.Sokak;
            KapiNo1TextBox.Text = iletisim.KapiNo1;
            KapiNo2TextBox.Text = iletisim.KapiNo2;
            IlceTextBox.Text = iletisim.Ilce;
            IlTextBox.Text = iletisim.Il;
            CepTelNo1TextBox.Text = iletisim.CepTelNo1;
            CepTelNo2TextBox.Text = iletisim.CepTelNo2;
        }


        private void PersonelSicilKartiForm_Load(object sender, EventArgs e)
        {
            
        }

        private void PersonelListesiButton_Click(object sender, EventArgs e)
        {

        }
    }
}
