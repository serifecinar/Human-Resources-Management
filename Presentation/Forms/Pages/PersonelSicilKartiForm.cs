using Business.Services;
using Data_Acces.Models;
using DataAcces;
using System;
using System.Linq;
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

        int _personelId = 0;


        public PersonelSicilKartiForm(int personelId = 0)
        {
            _personelId = personelId;

            InitializeComponent();

            if (_personelId != 0)
            {
                genel = genelService.GetByPersonelId(personelId);
                nufus = nufusService.GetByPersonelId(personelId);
                tahsil = tahsilService.GetByPersonelId(personelId);
                sertifika = sertifikaService.GetByPersonelId(personelId);
                nakil = nakilService.GetByPersonelId(personelId);
                iletisim = iletisimService.GetByPersonelId(personelId);
            }
        }


        private void PersonelSicilKartiForm_Load(object sender, EventArgs e)
        {
            //var bgw = new BackgroundWorker();

            //bgw.DoWork += delegate
            //{
            if (_personelId != 0)
            {
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
                //};
            }
        }

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            if (TCKimlikNoTextBox.Text != "")
            {
                var personelVarMi = genelService.Get(m => m.TCKimlikNo == TCKimlikNoTextBox.Text).FirstOrDefault();



                if (personelVarMi != null)
                {
                    //Genel
                    personelVarMi.PersonelId = personelVarMi.PersonelId;
                    personelVarMi.TCKimlikNo = personelVarMi.TCKimlikNo;
                    personelVarMi.SicilNo = Convert.ToInt32(SicilNoTextBox.Text);
                    personelVarMi.Adi = AdiTextBox.Text;
                    personelVarMi.Soyadi = SoyadiTextBox.Text;
                    personelVarMi.IseGirisTarihi = Convert.ToDateTime(IseGirisTarihiTextBox.Text);
                    personelVarMi.Mudurluk = MudurlukTextBox.Text;
                    personelVarMi.Seflik = SeflikTextBox.Text;
                    personelVarMi.GorevYeri = GorevYeriTextBox.Text;
                    personelVarMi.Unvani = UnvaniTextBox.Text;
                    personelVarMi.MK = Convert.ToDouble(MKTextBox.Text);
                    personelVarMi.PK = Convert.ToDouble(PKTextBox.Text);
                    personelVarMi.ToplamKatsayi = Convert.ToDouble(ToplamKatsayiTextBox.Text);

                    //Nufus
                    var personelNufus= nufusService.GetAll(m => m.PersonelId == personelVarMi.PersonelId).FirstOrDefault();
                    personelNufus.Cinsiyet = CinsiyetTextBox.Text;
                    personelNufus.AnneAdi = AnneAdiTextBox.Text;
                    personelNufus.BabaAdi = BabaAdiTextBox.Text;
                    personelNufus.DogumTarihi = Convert.ToDateTime(DogumTarihiTextBox.Text);
                    personelNufus.DogumYeri = DogumYeriTextBox.Text;
                    personelNufus.KanGrubu = KanGrubuTextBox.Text;
                    personelNufus.MedeniHali = MedinHaliTextBox.Text;
                    personelNufus.Askerlik = AskerlikTextBox.Text;
                    personelNufus.NufusaKayitliOlduguIl = NufusaKayitliOlduguIlTextBox.Text;
                    personelNufus.EsAdi = EsAdiTextBox.Text;
                    personelNufus.EsMeslegi = EsMeslegiTextBox.Text;
                    personelNufus.EsCalismaDurumu = EsCalismaDurumuTextBox.Text;
                    personelNufus.EsCalistigiKurumAdi = EsCalistigiKurumAdiTextBox.Text;
                    personelNufus.CocukSayisi = CocukSayisiTextBox.Text != "" ? Convert.ToInt16(CocukSayisiTextBox.Text)
                        : 0;

                    //1.Çocuk
                    personelNufus.CocukAdi1 = CocukAdi1TextBox.Text;
                    personelNufus.CocukCinsiyeti1=CocukCinsiyeti1TextBox.Text;
                    personelNufus.CocukDogumTarihi1 = Convert.ToDateTime(CocukDogumTarihi1TextBox.Text);
                    personelNufus.CocukHakkinda1 = CocukHakkinda1TextBox.Text;

                    //2.Çocuk
                    personelNufus.CocukAdi2 = CocukAdi2TextBox.Text;
                    personelNufus.CocukCinsiyeti2 = CocukCinsiyeti2TextBox.Text;
                    personelNufus.CocukDogumTarihi2 = Convert.ToDateTime(CocukDogumTarihi2TextBox.Text);
                    personelNufus.CocukHakkinda2 = CocukHakkinda2TextBox.Text;

                    //3.Çocuk
                    personelNufus.CocukAdi3 = CocukAdi3TextBox.Text;
                    personelNufus.CocukCinsiyeti3 = CocukCinsiyeti3TextBox.Text;
                    personelNufus.CocukDogumTarihi3 = Convert.ToDateTime(CocukDogumTarihi3TextBox.Text);
                    personelNufus.CocukHakkinda3 = CocukHakkinda3TextBox.Text;

                    //4.Çocuk
                    personelNufus.CocukAdi4 = CocukAdi4TextBox.Text;
                    personelNufus.CocukCinsiyeti4 = CocukCinsiyeti4TextBox.Text;
                    personelNufus.CocukDogumTarihi4 = Convert.ToDateTime(CocukDogumTarihi4TextBox.Text);
                    personelNufus.CocukHakkinda4 = CocukHakkinda4TextBox.Text;

                    //5.Çocuk
                    personelNufus.CocukAdi5 = CocukAdi5TextBox.Text;
                    personelNufus.CocukCinsiyeti5 = CocukCinsiyeti5TextBox.Text;
                    personelNufus.CocukDogumTarihi5 = Convert.ToDateTime(CocukDogumTarihi5TextBox.Text);
                    personelNufus.CocukHakkinda5 = CocukHakkinda5TextBox.Text;

                    //6.Çocuk
                    personelNufus.CocukAdi6 = CocukAdi6TextBox.Text;
                    personelNufus.CocukCinsiyeti6 = CocukCinsiyeti6TextBox.Text;
                    personelNufus.CocukDogumTarihi6 = Convert.ToDateTime(CocukDogumTarihi6TextBox.Text);
                    personelNufus.CocukHakkinda6 = CocukHakkinda6TextBox.Text;

                    var personelTahsil= tahsilService.GetAll(m => m.PersonelId == personelVarMi.PersonelId).FirstOrDefault();
                    //1. Tahsil 
                    personelTahsil.TahsilAdi1 = TahsilAdi1TextBox.Text;
                    personelTahsil.OkulAdi1=OkulAdi1TextBox.Text;
                    personelTahsil.BolumAdi1 = BolumAdi1TextBox.Text;
                    personelTahsil.MezuniyetTarihi1 = Convert.ToDateTime(MezuniyetTarihi1TextBox.Text);
                    //2. Tahsil 
                    personelTahsil.TahsilAdi2 = TahsilAdi2TextBox.Text;
                    personelTahsil.OkulAdi2 = OkulAdi2TextBox.Text;
                    personelTahsil.BolumAdi2 = BolumAdi2TextBox.Text;
                    personelTahsil.MezuniyetTarihi2 = Convert.ToDateTime(MezuniyetTarihi2TextBox.Text);
                    //3. Tahsil 
                    personelTahsil.TahsilAdi3 = TahsilAdi3TextBox.Text;
                    personelTahsil.OkulAdi3 = OkulAdi3TextBox.Text;
                    personelTahsil.BolumAdi3 = BolumAdi3TextBox.Text;
                    personelTahsil.MezuniyetTarihi3 = Convert.ToDateTime(MezuniyetTarihi3TextBox.Text);
                    //4. Tahsil 
                    personelTahsil.TahsilAdi4 = TahsilAdi4TextBox.Text;
                    personelTahsil.OkulAdi4 = OkulAdi4TextBox.Text;
                    personelTahsil.BolumAdi4 = BolumAdi4TextBox.Text;
                    personelTahsil.MezuniyetTarihi4 = Convert.ToDateTime(MezuniyetTarihi4TextBox.Text);
                    //5. Tahsil 
                    personelTahsil.TahsilAdi5 = TahsilAdi5TextBox.Text;
                    personelTahsil.OkulAdi5 = OkulAdi5TextBox.Text;
                    personelTahsil.BolumAdi5 = BolumAdi5TextBox.Text;
                    personelTahsil.MezuniyetTarihi5 = Convert.ToDateTime(MezuniyetTarihi5TextBox.Text);

                    var personelNakil = nakilService.GetAll(m => m.PersonelId == personelVarMi.PersonelId).FirstOrDefault();
                    //1.Nakil
                    personelNakil.BaslangicTarihi1 = Convert.ToDateTime(BaslangicTarihi1TextBox.Text);
                    personelNakil.AyrilisTarihi1 = Convert.ToDateTime(AyrilisTarihi1TextBox.Text);
                    personelNakil.Kurum1 = Kurum1TextBox.Text;
                    personelNakil.Birim1=Birim1TextBox.Text;    
                    personelNakil.Gorev1=Gorev1TextBox.Text;
                    personelNakil.Aciklama1 = Aciklama1TextBox.Text;
                    //2.Nakil
                    personelNakil.BaslangicTarihi2 = Convert.ToDateTime(BaslangicTarihi2TextBox.Text);
                    personelNakil.AyrilisTarihi2 = Convert.ToDateTime(AyrilisTarihi2TextBox.Text);
                    personelNakil.Kurum2 = Kurum2TextBox.Text;
                    personelNakil.Birim2 = Birim2TextBox.Text;
                    personelNakil.Gorev2 = Gorev2TextBox.Text;
                    personelNakil.Aciklama2 = Aciklama2TextBox.Text;
                    //3.Nakil
                    personelNakil.BaslangicTarihi3 = Convert.ToDateTime(BaslangicTarihi3TextBox.Text);
                    personelNakil.AyrilisTarihi3 = Convert.ToDateTime(AyrilisTarihi3TextBox.Text);
                    personelNakil.Kurum3 = Kurum3TextBox.Text;
                    personelNakil.Birim3 = Birim3TextBox.Text;
                    personelNakil.Gorev3 = Gorev3TextBox.Text;
                    personelNakil.Aciklama3 = Aciklama3TextBox.Text;
                    //4.Nakil
                    personelNakil.BaslangicTarihi4 = Convert.ToDateTime(BaslangicTarihi4TextBox.Text);
                    personelNakil.AyrilisTarihi4 = Convert.ToDateTime(AyrilisTarihi4TextBox.Text);
                    personelNakil.Kurum4 = Kurum4TextBox.Text;
                    personelNakil.Birim4 = Birim4TextBox.Text;
                    personelNakil.Gorev4 = Gorev4TextBox.Text;
                    personelNakil.Aciklama4 = Aciklama4TextBox.Text;
                    //5.Nakil
                    personelNakil.BaslangicTarihi5 = Convert.ToDateTime(BaslangicTarihi5TextBox.Text);
                    personelNakil.AyrilisTarihi5 = Convert.ToDateTime(AyrilisTarihi5TextBox.Text);
                    personelNakil.Kurum5 = Kurum5TextBox.Text;
                    personelNakil.Birim5 = Birim5TextBox.Text;
                    personelNakil.Gorev5 = Gorev5TextBox.Text;
                    personelNakil.Aciklama5 = Aciklama5TextBox.Text;
                    //6.Nakil
                    personelNakil.BaslangicTarihi6 = Convert.ToDateTime(BaslangicTarihi6TextBox.Text);
                    personelNakil.AyrilisTarihi6 = Convert.ToDateTime(AyrilisTarihi6TextBox.Text);
                    personelNakil.Kurum6 = Kurum6TextBox.Text;
                    personelNakil.Birim6 = Birim6TextBox.Text;
                    personelNakil.Gorev6 = Gorev6TextBox.Text;
                    personelNakil.Aciklama6 = Aciklama6TextBox.Text;
                    //7.Nakil
                    personelNakil.BaslangicTarihi7 = Convert.ToDateTime(BaslangicTarihi7TextBox.Text);
                    personelNakil.AyrilisTarihi7 = Convert.ToDateTime(AyrilisTarihi7TextBox.Text);
                    personelNakil.Kurum7 = Kurum7TextBox.Text;
                    personelNakil.Birim7 = Birim7TextBox.Text;
                    personelNakil.Gorev7 = Gorev7TextBox.Text;
                    personelNakil.Aciklama7 = Aciklama7TextBox.Text;
                    //8.Nakil
                    personelNakil.BaslangicTarihi8 = Convert.ToDateTime(BaslangicTarihi8TextBox.Text);
                    personelNakil.AyrilisTarihi8 = Convert.ToDateTime(AyrilisTarihi8TextBox.Text);
                    personelNakil.Kurum8 = Kurum8TextBox.Text;
                    personelNakil.Birim8 = Birim8TextBox.Text;
                    personelNakil.Gorev8 = Gorev8TextBox.Text;
                    personelNakil.Aciklama8 = Aciklama8TextBox.Text;
                    //9.Nakil
                    personelNakil.BaslangicTarihi9 = Convert.ToDateTime(BaslangicTarihi9TextBox.Text);
                    personelNakil.AyrilisTarihi9 = Convert.ToDateTime(AyrilisTarihi9TextBox.Text);
                    personelNakil.Kurum9 = Kurum9TextBox.Text;
                    personelNakil.Birim9 = Birim9TextBox.Text;
                    personelNakil.Gorev9 = Gorev9TextBox.Text;
                    personelNakil.Aciklama9 = Aciklama9TextBox.Text;
                    //10.Nakil
                    personelNakil.BaslangicTarihi10 = Convert.ToDateTime(BaslangicTarihi10TextBox.Text);
                    personelNakil.AyrilisTarihi10 = Convert.ToDateTime(AyrilisTarihi10TextBox.Text);
                    personelNakil.Kurum10 = Kurum10TextBox.Text;
                    personelNakil.Birim10 = Birim10TextBox.Text;
                    personelNakil.Gorev10 = Gorev10TextBox.Text;
                    personelNakil.Aciklama10 = Aciklama10TextBox.Text;

                    //Iletisim
                    var personelIletisim = iletisimService.GetAll(m => m.PersonelId == personelVarMi.PersonelId).FirstOrDefault();
                    personelIletisim.Mahalle = MahalleTextBox.Text;
                    personelIletisim.Sokak = SokakTextBox.Text;
                    personelIletisim.KapiNo1 = KapiNo1TextBox.Text;
                    personelIletisim.KapiNo2= KapiNo2TextBox.Text;
                    personelIletisim.Ilce = IlceTextBox.Text;
                    personelIletisim.Il = IlTextBox.Text;
                    personelIletisim.CepTelNo1=CepTelNo1TextBox.Text;
                    personelIletisim.CepTelNo2 = CepTelNo2TextBox.Text;

                    genelService.Update(personelVarMi);
                    nufusService.Update(personelNufus);
                    tahsilService.Update(personelTahsil);
                    nakilService.Update(personelNakil);
                    iletisimService.Update(personelIletisim);

                    MessageBox.Show("Personel başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Genel yeniGenel = new Genel
                    {
                        TCKimlikNo = TCKimlikNoTextBox.Text,
                        SicilNo = Convert.ToInt32(SicilNoTextBox.Text),
                        Adi = AdiTextBox.Text,
                        Soyadi = SoyadiTextBox.Text,
                        IseGirisTarihi = Convert.ToDateTime(IseGirisTarihiTextBox.Text),
                        Mudurluk = MudurlukTextBox.Text,
                        Seflik = SeflikTextBox.Text,
                        GorevYeri = GorevYeriTextBox.Text,
                        Unvani = UnvaniTextBox.Text,
                        MK = Convert.ToDouble(MKTextBox.Text),
                        PK = Convert.ToDouble(PKTextBox.Text),
                        ToplamKatsayi = Convert.ToDouble(ToplamKatsayiTextBox.Text),
                    };

                    Nufus yeniNufus = new Nufus
                    {
                        Cinsiyet = CinsiyetTextBox.Text,
                        AnneAdi = AnneAdiTextBox.Text,
                        BabaAdi = BabaAdiTextBox.Text,
                        DogumTarihi = Convert.ToDateTime(DogumTarihiTextBox.Text),
                        DogumYeri = DogumYeriTextBox.Text,
                        KanGrubu = KanGrubuTextBox.Text,
                        MedeniHali = MedinHaliTextBox.Text,
                        Askerlik=AskerlikTextBox.Text,
                        NufusaKayitliOlduguIl=NufusaKayitliOlduguIlTextBox.Text,
                        EsAdi=EsAdiTextBox.Text,
                        EsMeslegi=EsMeslegiTextBox.Text,
                        EsCalismaDurumu=EsCalismaDurumuTextBox.Text,
                        EsCalistigiKurumAdi=EsCalistigiKurumAdiTextBox.Text,
                        CocukSayisi=Convert.ToInt32(CocukSayisiTextBox.Text),
                    };

                    Tahsil yeniTahsil = new Tahsil
                    {
                        TahsilAdi1 = TahsilAdi1TextBox.Text,
                        OkulAdi1 = OkulAdi1TextBox.Text,
                        BolumAdi1 = BolumAdi1TextBox.Text,
                        MezuniyetTarihi1 = Convert.ToDateTime(MezuniyetTarihi1TextBox.Text),

                        TahsilAdi2 = TahsilAdi2TextBox.Text,
                        OkulAdi2 = OkulAdi2TextBox.Text,
                        BolumAdi2 = BolumAdi2TextBox.Text,
                        MezuniyetTarihi2 = Convert.ToDateTime(MezuniyetTarihi2TextBox.Text),

                        TahsilAdi3 = TahsilAdi3TextBox.Text,
                        OkulAdi3 = OkulAdi3TextBox.Text,
                        BolumAdi3 = BolumAdi3TextBox.Text,
                        MezuniyetTarihi3 = Convert.ToDateTime(MezuniyetTarihi3TextBox.Text),

                        TahsilAdi4 = TahsilAdi4TextBox.Text,
                        OkulAdi4 = OkulAdi4TextBox.Text,
                        BolumAdi4 = BolumAdi4TextBox.Text,
                        MezuniyetTarihi4 = Convert.ToDateTime(MezuniyetTarihi4TextBox.Text),

                        TahsilAdi5 = TahsilAdi5TextBox.Text,
                        OkulAdi5 = OkulAdi5TextBox.Text,
                        BolumAdi5 = BolumAdi5TextBox.Text,
                        MezuniyetTarihi5 = Convert.ToDateTime(MezuniyetTarihi5TextBox.Text),
                    };

                    Nakil yeniNakil = new Nakil
                    {
                        BaslangicTarihi1 = Convert.ToDateTime(BaslangicTarihi1TextBox.Text),
                        AyrilisTarihi1=Convert.ToDateTime(AyrilisTarihi1TextBox.Text),
                        Kurum1=Kurum1TextBox.Text,
                        Birim1=Birim1TextBox.Text,
                        Gorev1=Gorev1TextBox.Text,
                        Aciklama1=Aciklama1TextBox.Text,

                        BaslangicTarihi2 = Convert.ToDateTime(BaslangicTarihi2TextBox.Text),
                        AyrilisTarihi2 = Convert.ToDateTime(AyrilisTarihi2TextBox.Text),
                        Kurum2 = Kurum2TextBox.Text,
                        Birim2 = Birim2TextBox.Text,
                        Gorev2 = Gorev2TextBox.Text,
                        Aciklama2 = Aciklama2TextBox.Text,

                        BaslangicTarihi3 = Convert.ToDateTime(BaslangicTarihi3TextBox.Text),
                        AyrilisTarihi3 = Convert.ToDateTime(AyrilisTarihi3TextBox.Text),
                        Kurum3 = Kurum3TextBox.Text,
                        Birim3 = Birim3TextBox.Text,
                        Gorev3 = Gorev3TextBox.Text,
                        Aciklama3 = Aciklama3TextBox.Text,

                        BaslangicTarihi4 = Convert.ToDateTime(BaslangicTarihi4TextBox.Text),
                        AyrilisTarihi4 = Convert.ToDateTime(AyrilisTarihi4TextBox.Text),
                        Kurum4 = Kurum4TextBox.Text,
                        Birim4 = Birim4TextBox.Text,
                        Gorev4 = Gorev4TextBox.Text,
                        Aciklama4 = Aciklama4TextBox.Text,

                        BaslangicTarihi5 = Convert.ToDateTime(BaslangicTarihi5TextBox.Text),
                        AyrilisTarihi5 = Convert.ToDateTime(AyrilisTarihi5TextBox.Text),
                        Kurum5 = Kurum5TextBox.Text,
                        Birim5 = Birim5TextBox.Text,
                        Gorev5 = Gorev5TextBox.Text,
                        Aciklama5 = Aciklama5TextBox.Text,

                        BaslangicTarihi6 = Convert.ToDateTime(BaslangicTarihi6TextBox.Text),
                        AyrilisTarihi6 = Convert.ToDateTime(AyrilisTarihi6TextBox.Text),
                        Kurum6 = Kurum6TextBox.Text,
                        Birim6 = Birim6TextBox.Text,
                        Gorev6 = Gorev6TextBox.Text,
                        Aciklama6 = Aciklama6TextBox.Text,

                        BaslangicTarihi7 = Convert.ToDateTime(BaslangicTarihi7TextBox.Text),
                        AyrilisTarihi7 = Convert.ToDateTime(AyrilisTarihi7TextBox.Text),
                        Kurum7 = Kurum7TextBox.Text,
                        Birim7 = Birim7TextBox.Text,
                        Gorev7 = Gorev7TextBox.Text,
                        Aciklama7 = Aciklama7TextBox.Text,

                        BaslangicTarihi8 = Convert.ToDateTime(BaslangicTarihi8TextBox.Text),
                        AyrilisTarihi8 = Convert.ToDateTime(AyrilisTarihi8TextBox.Text),
                        Kurum8 = Kurum8TextBox.Text,
                        Birim8 = Birim8TextBox.Text,
                        Gorev8 = Gorev8TextBox.Text,
                        Aciklama8 = Aciklama8TextBox.Text,

                        BaslangicTarihi9 = Convert.ToDateTime(BaslangicTarihi9TextBox.Text),
                        AyrilisTarihi9 = Convert.ToDateTime(AyrilisTarihi9TextBox.Text),
                        Kurum9 = Kurum9TextBox.Text,
                        Birim9 = Birim9TextBox.Text,
                        Gorev9 = Gorev9TextBox.Text,
                        Aciklama9 = Aciklama9TextBox.Text,

                        BaslangicTarihi10 = Convert.ToDateTime(BaslangicTarihi10TextBox.Text),
                        AyrilisTarihi10 = Convert.ToDateTime(AyrilisTarihi10TextBox.Text),
                        Kurum10 = Kurum10TextBox.Text,
                        Birim10 = Birim10TextBox.Text,
                        Gorev10 = Gorev10TextBox.Text,
                        Aciklama10 = Aciklama10TextBox.Text,
                    };

                    Iletisim yeniIletisim = new Iletisim
                    {
                        Mahalle = MahalleTextBox.Text,
                        Sokak = SokakTextBox.Text,
                        KapiNo1 = KapiNo1TextBox.Text,
                        KapiNo2 = KapiNo2TextBox.Text,
                        Ilce = IlceTextBox.Text,
                        Il = IlTextBox.Text,
                        CepTelNo1 = CepTelNo1TextBox.Text,
                        CepTelNo2=CepTelNo2TextBox.Text,
                    };

                    genelService.Add(yeniGenel);
                    nufusService.Add(yeniNufus);
                    tahsilService.Add(yeniTahsil);
                    nakilService.Add(yeniNakil);
                    iletisimService.Add(yeniIletisim);

                    MessageBox.Show("Yeni personel başarıyla kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz personelin TC Kimlik numarası bilgisini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
