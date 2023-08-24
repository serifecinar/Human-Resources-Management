using Business.Services;
using Data_Acces.Models;
using DataAcces;
using Presentation.Utils;
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
                AdiSoyadiTextBox.Text = genel.Adi + " " + genel.Soyadi;
                IseGirisTarihiDTP.Text = Convert.ToString(genel.IseGirisTarihi);
                MudurlukComboBox.Text = genel.Mudurluk;
                SeflikComboBox.Text = genel.Seflik;
                GorevYeriComboBox.Text = genel.GorevYeri;
                UnvanComboBox.Text = genel.Unvani;
                PozisyonComboBox.Text = genel.Pozisyonu;
                MKTextBox.Text = Convert.ToString(genel.MK);
                PKTextBox.Text = Convert.ToString(genel.PK);
                ToplamKatsayiTextBox.Text = Convert.ToString(genel.ToplamKatsayi);

                //Nüfus
                CinsiyetComboBox.Text = nufus.Cinsiyet;
                AnneAdiTextBox.Text = nufus.AnneAdi;
                BabaAdiTextBox.Text = nufus.BabaAdi;
                DogumTarihiDTP.Text = Convert.ToString(nufus.DogumTarihi);
                DogumYeriTextBox.Text = nufus.DogumYeri;
                KanGrubuComboBox.Text = nufus.KanGrubu;
                MedenihaliComboBox.Text = nufus.MedeniHali;
                AskerlikTextBox.Text = nufus.Askerlik;
                NufusaKayitliOlduguIlTextBoxComboBox.Text = nufus.NufusaKayitliOlduguIl;
                EsAdiTextBox.Text = nufus.EsAdi;
                EsMeslegiTextBox.Text = nufus.EsMeslegi;
                EsCalismaDurumuTextBox.Text = nufus.EsCalismaDurumu;
                EsCalistigiKurumAdiTextBox.Text = nufus.EsCalistigiKurumAdi;
                CocukSayisiTextBox.Text = Convert.ToString(nufus.CocukSayisi);

                //1.Çocuk
                CocukAdi1TextBox.Text = nufus.CocukAdi1;
                CocukCinsiyeti1ComboBox.Text = nufus.CocukCinsiyeti1;
                CocukDogumTarihi1DTP.Text = Convert.ToString(nufus.CocukDogumTarihi1);
                CocukHakkinda1TextBox.Text = nufus.CocukHakkinda1;
                //2.Çocuk
                CocukAdi2TextBox.Text = nufus.CocukAdi2;
                CocukCinsiyeti2ComboBox.Text = nufus.CocukCinsiyeti2;
                CocukDogumTarihi2DTP.Text = Convert.ToString(nufus.CocukDogumTarihi2);
                CocukHakkinda2TextBox.Text = nufus.CocukHakkinda2;
                //3.Çocuk
                CocukAdi3TextBox.Text = nufus.CocukAdi3;
                CocukCinsiyeti3ComboBox.Text = nufus.CocukCinsiyeti3;
                CocukDogumTarihi3DTP.Text = Convert.ToString(nufus.CocukDogumTarihi3);
                CocukHakkinda3TextBox.Text = nufus.CocukHakkinda3;
                //4.Çocuk
                CocukAdi4TextBox.Text = nufus.CocukAdi4;
                CocukCinsiyeti4ComboBox.Text = nufus.CocukCinsiyeti4;
                CocukDogumTarihi4DTP.Text = Convert.ToString(nufus.CocukDogumTarihi4);
                CocukHakkinda4TextBox.Text = nufus.CocukHakkinda4;
                //5.Çocuk
                CocukAdi5TextBox.Text = nufus.CocukAdi5;
                CocukCinsiyeti5ComboBox.Text = nufus.CocukCinsiyeti5;
                CocukDogumTarihi5DTP.Text = Convert.ToString(nufus.CocukDogumTarihi5);
                CocukHakkinda5TextBox.Text = nufus.CocukHakkinda5;
                //6.Çocuk
                CocukAdi6TextBox.Text = nufus.CocukAdi6;
                CocukCinsiyeti6ComboBox.Text = nufus.CocukCinsiyeti6;
                CocukDogumTarihi6DTP.Text = Convert.ToString(nufus.CocukDogumTarihi6);
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
                Sertifika1TextBox.Text = sertifika.SertifikaAdi1;
                Sertifika2TextBox.Text = sertifika.SertifikaAdi2;
                Sertifika3TextBox.Text = sertifika.SertifikaAdi3;
                Sertifika4TextBox.Text = sertifika.SertifikaAdi4;
                Sertifika5TextBox.Text = sertifika.SertifikaAdi5;
                Sertifika6TextBox.Text = sertifika.SertifikaAdi6;
                Sertifika7TextBox.Text = sertifika.SertifikaAdi7;
                Sertifika8TextBox.Text = sertifika.SertifikaAdi8;
                Sertifika9TextBox.Text = sertifika.SertifikaAdi9;
                Sertifika10TextBox.Text = sertifika.SertifikaAdi10;

                //1.Nakil
                BaslangicTarihi1DTP.Text = Convert.ToString(nakil.BaslangicTarihi1);
                AyrilisTarihi1DTP.Text = Convert.ToString(nakil.AyrilisTarihi1);
                Kurum1TextBox.Text = nakil.Kurum1;
                Birim1TextBox.Text = nakil.Birim1;
                Gorev1TextBox.Text = nakil.Gorev1;
                Aciklama1TextBox.Text = nakil.Aciklama1;

                //2.Nakil
                BaslangicTarihi2DTP.Text = Convert.ToString(nakil.BaslangicTarihi2);
                AyrilisTarihi2DTP.Text = Convert.ToString(nakil.AyrilisTarihi2);
                Kurum2TextBox.Text = nakil.Kurum2;
                Birim2TextBox.Text = nakil.Birim2;
                Gorev2TextBox.Text = nakil.Gorev2;
                Aciklama2TextBox.Text = nakil.Aciklama2;

                //3.Nakil
                BaslangicTarihi3DTP.Text = Convert.ToString(nakil.BaslangicTarihi3);
                AyrilisTarihi3DTP.Text = Convert.ToString(nakil.AyrilisTarihi3);
                Kurum3TextBox.Text = nakil.Kurum3;
                Birim3TextBox.Text = nakil.Birim3;
                Gorev3TextBox.Text = nakil.Gorev3;
                Aciklama3TextBox.Text = nakil.Aciklama3;

                //4.Nakil
                BaslangicTarihi4DTP.Text = Convert.ToString(nakil.BaslangicTarihi4);
                AyrilisTarihi4DTP.Text = Convert.ToString(nakil.AyrilisTarihi4);
                Kurum4TextBox.Text = nakil.Kurum4;
                Birim4TextBox.Text = nakil.Birim4;
                Gorev4TextBox.Text = nakil.Gorev4;
                Aciklama4TextBox.Text = nakil.Aciklama4;

                //5.Nakil
                BaslangicTarihi5DTP.Text = Convert.ToString(nakil.BaslangicTarihi5);
                AyrilisTarihi5DTP.Text = Convert.ToString(nakil.AyrilisTarihi5);
                Kurum5TextBox.Text = nakil.Kurum5;
                Birim5TextBox.Text = nakil.Birim5;
                Gorev5TextBox.Text = nakil.Gorev5;
                Aciklama5TextBox.Text = nakil.Aciklama5;

                //6.Nakil
                BaslangicTarihi6DTP.Text = Convert.ToString(nakil.BaslangicTarihi6);
                AyrilisTarihi6DTP.Text = Convert.ToString(nakil.AyrilisTarihi6);
                Kurum6TextBox.Text = nakil.Kurum6;
                Birim6TextBox.Text = nakil.Birim6;
                Gorev6TextBox.Text = nakil.Gorev6;
                Aciklama6TextBox.Text = nakil.Aciklama6;

                //7.Nakil
                BaslangicTarihi7DTP.Text = Convert.ToString(nakil.BaslangicTarihi7);
                AyrilisTarihi7DTP.Text = Convert.ToString(nakil.AyrilisTarihi7);
                Kurum7TextBox.Text = nakil.Kurum7;
                Birim7TextBox.Text = nakil.Birim7;
                Gorev7TextBox.Text = nakil.Gorev7;
                Aciklama7TextBox.Text = nakil.Aciklama7;

                //8.Nakil
                BaslangicTarihi8DTP.Text = Convert.ToString(nakil.BaslangicTarihi8);
                AyrilisTarihi8DTP.Text = Convert.ToString(nakil.AyrilisTarihi8);
                Kurum8TextBox.Text = nakil.Kurum8;
                Birim8TextBox.Text = nakil.Birim8;
                Gorev8TextBox.Text = nakil.Gorev8;
                Aciklama8TextBox.Text = nakil.Aciklama8;

                //9.Nakil
                BaslangicTarihi9DTP.Text = Convert.ToString(nakil.BaslangicTarihi9);
                AyrilisTarihi9DTP.Text = Convert.ToString(nakil.AyrilisTarihi9);
                Kurum9TextBox.Text = nakil.Kurum9;
                Birim9TextBox.Text = nakil.Birim9;
                Gorev9TextBox.Text = nakil.Gorev9;
                Aciklama9TextBox.Text = nakil.Aciklama9;

                //10.Nakil
                BaslangicTarihi10DTP.Text = Convert.ToString(nakil.BaslangicTarihi10);
                AyrilisTarihi10DTP.Text = Convert.ToString(nakil.AyrilisTarihi10);
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
                    personelVarMi.SicilNo = TypeConversion.GetValidInt(SicilNoTextBox);
                    personelVarMi.Adi = AdiTextBox.Text;
                    personelVarMi.Soyadi = SoyadiTextBox.Text;
                    personelVarMi.IseGirisTarihi = TypeConversion.GetValidDate(IseGirisTarihiDTP);
                    personelVarMi.Mudurluk = MudurlukComboBox.Text;
                    personelVarMi.Seflik = SeflikComboBox.Text;
                    personelVarMi.GorevYeri = GorevYeriComboBox.Text;
                    personelVarMi.Unvani = UnvanComboBox.Text;
                    personelVarMi.Pozisyonu = PozisyonComboBox.Text;
                    personelVarMi.MK = TypeConversion.GetValidDouble(MKTextBox);
                    personelVarMi.PK = TypeConversion.GetValidDouble(PKTextBox);
                    personelVarMi.ToplamKatsayi = TypeConversion.GetValidDouble(ToplamKatsayiTextBox);

                    //Nufus
                    var personelNufus = nufusService.GetAll(m => m.PersonelId == personelVarMi.PersonelId).FirstOrDefault();
                    personelNufus.Cinsiyet = CinsiyetComboBox.Text;
                    personelNufus.AnneAdi = AnneAdiTextBox.Text;
                    personelNufus.BabaAdi = BabaAdiTextBox.Text;
                    personelNufus.DogumTarihi = TypeConversion.GetValidDate(DogumTarihiDTP);
                    personelNufus.DogumYeri = DogumYeriTextBox.Text;
                    personelNufus.KanGrubu = KanGrubuComboBox.Text;
                    personelNufus.MedeniHali = MedenihaliComboBox.Text;
                    personelNufus.Askerlik = AskerlikTextBox.Text;
                    personelNufus.NufusaKayitliOlduguIl = NufusaKayitliOlduguIlTextBoxComboBox.Text;
                    personelNufus.EsAdi = EsAdiTextBox.Text;
                    personelNufus.EsMeslegi = EsMeslegiTextBox.Text;
                    personelNufus.EsCalismaDurumu = EsCalismaDurumuTextBox.Text;
                    personelNufus.EsCalistigiKurumAdi = EsCalistigiKurumAdiTextBox.Text;
                    personelNufus.CocukSayisi = TypeConversion.GetValidInt(CocukSayisiTextBox);                    

                    //1.Çocuk
                    personelNufus.CocukAdi1 = CocukAdi1TextBox.Text;
                    personelNufus.CocukCinsiyeti1 = CocukCinsiyeti1ComboBox.Text;
                    personelNufus.CocukDogumTarihi1 = TypeConversion.GetValidDate(CocukDogumTarihi1DTP);
                    personelNufus.CocukHakkinda1 = CocukHakkinda1TextBox.Text;

                    //2.Çocuk
                    personelNufus.CocukAdi2 = CocukAdi2TextBox.Text;
                    personelNufus.CocukCinsiyeti2 = CocukCinsiyeti2ComboBox.Text;
                    personelNufus.CocukDogumTarihi1 = TypeConversion.GetValidDate(CocukDogumTarihi2DTP);
                    personelNufus.CocukHakkinda2 = CocukHakkinda2TextBox.Text;

                    //3.Çocuk
                    personelNufus.CocukAdi3 = CocukAdi3TextBox.Text;
                    personelNufus.CocukCinsiyeti3 = CocukCinsiyeti3ComboBox.Text;
                    personelNufus.CocukDogumTarihi1 = TypeConversion.GetValidDate(CocukDogumTarihi3DTP);
                    personelNufus.CocukHakkinda3 = CocukHakkinda3TextBox.Text;

                    //4.Çocuk
                    personelNufus.CocukAdi4 = CocukAdi4TextBox.Text;
                    personelNufus.CocukCinsiyeti4 = CocukCinsiyeti4ComboBox.Text;
                    personelNufus.CocukDogumTarihi1 = TypeConversion.GetValidDate(CocukDogumTarihi4DTP);
                    personelNufus.CocukHakkinda4 = CocukHakkinda4TextBox.Text;

                    //5.Çocuk
                    personelNufus.CocukAdi5 = CocukAdi5TextBox.Text;
                    personelNufus.CocukCinsiyeti5 = CocukCinsiyeti5ComboBox.Text;
                    personelNufus.CocukDogumTarihi1 = TypeConversion.GetValidDate(CocukDogumTarihi5DTP);
                    personelNufus.CocukHakkinda5 = CocukHakkinda5TextBox.Text;

                    //6.Çocuk
                    personelNufus.CocukAdi6 = CocukAdi6TextBox.Text;
                    personelNufus.CocukCinsiyeti6 = CocukCinsiyeti6ComboBox.Text;
                    personelNufus.CocukDogumTarihi1 = TypeConversion.GetValidDate(CocukDogumTarihi6DTP);
                    personelNufus.CocukHakkinda6 = CocukHakkinda6TextBox.Text;

                    var personelTahsil = tahsilService.GetAll(m => m.PersonelId == personelVarMi.PersonelId).FirstOrDefault();
                    //1. Tahsil 
                    personelTahsil.TahsilAdi1 = TahsilAdi1TextBox.Text;
                    personelTahsil.OkulAdi1 = OkulAdi1TextBox.Text;
                    personelTahsil.BolumAdi1 = BolumAdi1TextBox.Text;
                    personelTahsil.MezuniyetTarihi1 = TypeConversion.GetValidDate(MezuniyetTarihi1TextBox);
                    //2. Tahsil 
                    personelTahsil.TahsilAdi2 = TahsilAdi2TextBox.Text;
                    personelTahsil.OkulAdi2 = OkulAdi2TextBox.Text;
                    personelTahsil.BolumAdi2 = BolumAdi2TextBox.Text;
                    personelTahsil.MezuniyetTarihi2 = TypeConversion.GetValidDate(MezuniyetTarihi2TextBox);
                    //3. Tahsil 
                    personelTahsil.TahsilAdi3 = TahsilAdi3TextBox.Text;
                    personelTahsil.OkulAdi3 = OkulAdi3TextBox.Text;
                    personelTahsil.BolumAdi3 = BolumAdi3TextBox.Text;
                    personelTahsil.MezuniyetTarihi3 = TypeConversion.GetValidDate(MezuniyetTarihi3TextBox);
                    //4. Tahsil 
                    personelTahsil.TahsilAdi4 = TahsilAdi4TextBox.Text;
                    personelTahsil.OkulAdi4 = OkulAdi4TextBox.Text;
                    personelTahsil.BolumAdi4 = BolumAdi4TextBox.Text;
                    personelTahsil.MezuniyetTarihi4 = TypeConversion.GetValidDate(MezuniyetTarihi4TextBox);
                    //5. Tahsil 
                    personelTahsil.TahsilAdi5 = TahsilAdi5TextBox.Text;
                    personelTahsil.OkulAdi5 = OkulAdi5TextBox.Text;
                    personelTahsil.BolumAdi5 = BolumAdi5TextBox.Text;
                    personelTahsil.MezuniyetTarihi5 = TypeConversion.GetValidDate(MezuniyetTarihi5TextBox);

                    //Sertifika
                    var personelSertifika = sertifikaService.GetAll(m=>m.PersonelId==personelVarMi.PersonelId).FirstOrDefault();
                    personelSertifika.SertifikaAdi1 = Sertifika1TextBox.Text;
                    personelSertifika.SertifikaAdi2 = Sertifika2TextBox.Text;
                    personelSertifika.SertifikaAdi3 = Sertifika3TextBox.Text;
                    personelSertifika.SertifikaAdi4 = Sertifika4TextBox.Text;
                    personelSertifika.SertifikaAdi5 = Sertifika5TextBox.Text;
                    personelSertifika.SertifikaAdi6 = Sertifika6TextBox.Text;
                    personelSertifika.SertifikaAdi7 = Sertifika7TextBox.Text;
                    personelSertifika.SertifikaAdi8 = Sertifika8TextBox.Text;
                    personelSertifika.SertifikaAdi9 = Sertifika9TextBox.Text;
                    personelSertifika.SertifikaAdi10 = Sertifika10TextBox.Text;

                    var personelNakil = nakilService.GetAll(m => m.PersonelId == personelVarMi.PersonelId).FirstOrDefault();
                    //1.Nakil
                    personelNakil.BaslangicTarihi1 = TypeConversion.GetValidDate(BaslangicTarihi1DTP);
                    personelNakil.AyrilisTarihi1 = TypeConversion.GetValidDate(AyrilisTarihi1DTP);
                    personelNakil.Kurum1 = Kurum1TextBox.Text;
                    personelNakil.Birim1 = Birim1TextBox.Text;
                    personelNakil.Gorev1 = Gorev1TextBox.Text;
                    personelNakil.Aciklama1 = Aciklama1TextBox.Text;
                    //2.Nakil
                    personelNakil.BaslangicTarihi2 = TypeConversion.GetValidDate(BaslangicTarihi2DTP);
                    personelNakil.AyrilisTarihi2 = TypeConversion.GetValidDate(AyrilisTarihi2DTP);
                    personelNakil.Kurum2 = Kurum2TextBox.Text;
                    personelNakil.Birim2 = Birim2TextBox.Text;
                    personelNakil.Gorev2 = Gorev2TextBox.Text;
                    personelNakil.Aciklama2 = Aciklama2TextBox.Text;
                    //3.Nakil
                    personelNakil.BaslangicTarihi3 = TypeConversion.GetValidDate(BaslangicTarihi3DTP);
                    personelNakil.AyrilisTarihi3 = TypeConversion.GetValidDate(AyrilisTarihi3DTP);
                    personelNakil.Kurum3 = Kurum3TextBox.Text;
                    personelNakil.Birim3 = Birim3TextBox.Text;
                    personelNakil.Gorev3 = Gorev3TextBox.Text;
                    personelNakil.Aciklama3 = Aciklama3TextBox.Text;
                    //4.Nakil
                    personelNakil.BaslangicTarihi4 = TypeConversion.GetValidDate(BaslangicTarihi4DTP);
                    personelNakil.AyrilisTarihi4 = TypeConversion.GetValidDate(AyrilisTarihi4DTP);
                    personelNakil.Kurum4 = Kurum4TextBox.Text;
                    personelNakil.Birim4 = Birim4TextBox.Text;
                    personelNakil.Gorev4 = Gorev4TextBox.Text;
                    personelNakil.Aciklama4 = Aciklama4TextBox.Text;
                    //5.Nakil
                    personelNakil.BaslangicTarihi5 = TypeConversion.GetValidDate(BaslangicTarihi5DTP);
                    personelNakil.AyrilisTarihi5 = TypeConversion.GetValidDate(AyrilisTarihi5DTP);
                    personelNakil.Kurum5 = Kurum5TextBox.Text;
                    personelNakil.Birim5 = Birim5TextBox.Text;
                    personelNakil.Gorev5 = Gorev5TextBox.Text;
                    personelNakil.Aciklama5 = Aciklama5TextBox.Text;
                    //6.Nakil
                    personelNakil.BaslangicTarihi6 = TypeConversion.GetValidDate(BaslangicTarihi6DTP);
                    personelNakil.AyrilisTarihi6 = TypeConversion.GetValidDate(AyrilisTarihi6DTP);
                    personelNakil.Kurum6 = Kurum6TextBox.Text;
                    personelNakil.Birim6 = Birim6TextBox.Text;
                    personelNakil.Gorev6 = Gorev6TextBox.Text;
                    personelNakil.Aciklama6 = Aciklama6TextBox.Text;
                    //7.Nakil
                    personelNakil.BaslangicTarihi7 = TypeConversion.GetValidDate(BaslangicTarihi7DTP);
                    personelNakil.AyrilisTarihi7 = TypeConversion.GetValidDate(AyrilisTarihi7DTP);
                    personelNakil.Kurum7 = Kurum7TextBox.Text;
                    personelNakil.Birim7 = Birim7TextBox.Text;
                    personelNakil.Gorev7 = Gorev7TextBox.Text;
                    personelNakil.Aciklama7 = Aciklama7TextBox.Text;
                    //8.Nakil
                    personelNakil.BaslangicTarihi8 = TypeConversion.GetValidDate(BaslangicTarihi8DTP);
                    personelNakil.AyrilisTarihi8 = TypeConversion.GetValidDate(AyrilisTarihi8DTP);
                    personelNakil.Kurum8 = Kurum8TextBox.Text;
                    personelNakil.Birim8 = Birim8TextBox.Text;
                    personelNakil.Gorev8 = Gorev8TextBox.Text;
                    personelNakil.Aciklama8 = Aciklama8TextBox.Text;
                    //9.Nakil
                    personelNakil.BaslangicTarihi9 = TypeConversion.GetValidDate(BaslangicTarihi9DTP);
                    personelNakil.AyrilisTarihi9 = TypeConversion.GetValidDate(AyrilisTarihi9DTP);
                    personelNakil.Kurum9 = Kurum9TextBox.Text;
                    personelNakil.Birim9 = Birim9TextBox.Text;
                    personelNakil.Gorev9 = Gorev9TextBox.Text;
                    personelNakil.Aciklama9 = Aciklama9TextBox.Text;
                    //10.Nakil
                    personelNakil.BaslangicTarihi10 = TypeConversion.GetValidDate(BaslangicTarihi10DTP);
                    personelNakil.AyrilisTarihi10 = TypeConversion.GetValidDate(AyrilisTarihi10DTP);
                    personelNakil.Kurum10 = Kurum10TextBox.Text;
                    personelNakil.Birim10 = Birim10TextBox.Text;
                    personelNakil.Gorev10 = Gorev10TextBox.Text;
                    personelNakil.Aciklama10 = Aciklama10TextBox.Text;

                    //Iletisim
                    var personelIletisim = iletisimService.GetAll(m => m.PersonelId == personelVarMi.PersonelId).FirstOrDefault();
                    personelIletisim.Mahalle = MahalleTextBox.Text;
                    personelIletisim.Sokak = SokakTextBox.Text;
                    personelIletisim.KapiNo1 = KapiNo1TextBox.Text;
                    personelIletisim.KapiNo2 = KapiNo2TextBox.Text;
                    personelIletisim.Ilce = IlceTextBox.Text;
                    personelIletisim.Il = IlTextBox.Text;
                    personelIletisim.CepTelNo1 = CepTelNo1TextBox.Text;
                    personelIletisim.CepTelNo2 = CepTelNo2TextBox.Text;

                    genelService.Update(personelVarMi);
                    nufusService.Update(personelNufus);
                    tahsilService.Update(personelTahsil);
                    sertifikaService.Update(personelSertifika);
                    nakilService.Update(personelNakil);
                    iletisimService.Update(personelIletisim);

                    MessageBox.Show("Personel başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    Genel yeniGenel = new Genel
                    {
                        TCKimlikNo = TCKimlikNoTextBox.Text,
                        SicilNo = TypeConversion.GetValidInt(SicilNoTextBox),
                        Adi = AdiTextBox.Text,
                        Soyadi = SoyadiTextBox.Text,
                        IseGirisTarihi = TypeConversion.GetValidDate(IseGirisTarihiDTP),
                        Mudurluk = MudurlukComboBox.Text,
                        Seflik = SeflikComboBox.Text,
                        GorevYeri = GorevYeriComboBox.Text,
                        Unvani = UnvanComboBox.Text,
                        Pozisyonu= PozisyonComboBox.Text,
                        MK = TypeConversion.GetValidDouble(MKTextBox),
                        PK = TypeConversion.GetValidDouble(PKTextBox),
                        ToplamKatsayi = TypeConversion.GetValidDouble(ToplamKatsayiTextBox),
                    };

                    Nufus yeniNufus = new Nufus
                    {
                        Cinsiyet = CinsiyetComboBox.Text,
                        AnneAdi = AnneAdiTextBox.Text,
                        BabaAdi = BabaAdiTextBox.Text,
                        DogumTarihi = TypeConversion.GetValidDate(DogumTarihiDTP),
                        DogumYeri = DogumYeriTextBox.Text,
                        KanGrubu = KanGrubuComboBox.Text,
                        MedeniHali = MedenihaliComboBox.Text,
                        Askerlik = AskerlikTextBox.Text,
                        NufusaKayitliOlduguIl = NufusaKayitliOlduguIlTextBoxComboBox.Text,
                        EsAdi = EsAdiTextBox.Text,
                        EsMeslegi = EsMeslegiTextBox.Text,
                        EsCalismaDurumu = EsCalismaDurumuTextBox.Text,
                        EsCalistigiKurumAdi = EsCalistigiKurumAdiTextBox.Text,
                        CocukSayisi = TypeConversion.GetValidInt(CocukSayisiTextBox),

                        CocukAdi1 = CocukAdi1TextBox.Text,
                        CocukCinsiyeti1 = CocukCinsiyeti1ComboBox.Text,
                        CocukDogumTarihi1= TypeConversion.GetValidDate(CocukDogumTarihi1DTP),
                        CocukHakkinda1=CocukHakkinda1TextBox.Text,

                        CocukAdi2 = CocukAdi2TextBox.Text,
                        CocukCinsiyeti2 = CocukCinsiyeti2ComboBox.Text,
                        CocukDogumTarihi2 = TypeConversion.GetValidDate(CocukDogumTarihi2DTP),
                        CocukHakkinda2 = CocukHakkinda2TextBox.Text,

                        CocukAdi3 = CocukAdi3TextBox.Text,
                        CocukCinsiyeti3 = CocukCinsiyeti3ComboBox.Text,
                        CocukDogumTarihi3 = TypeConversion.GetValidDate(CocukDogumTarihi3DTP),
                        CocukHakkinda3 = CocukHakkinda3TextBox.Text,

                        CocukAdi4 = CocukAdi4TextBox.Text,
                        CocukCinsiyeti4 = CocukCinsiyeti4ComboBox.Text,
                        CocukDogumTarihi4 = TypeConversion.GetValidDate(CocukDogumTarihi4DTP),
                        CocukHakkinda4 = CocukHakkinda4TextBox.Text,

                        CocukAdi5 = CocukAdi5TextBox.Text,
                        CocukCinsiyeti5 = CocukCinsiyeti5ComboBox.Text,
                        CocukDogumTarihi5 = TypeConversion.GetValidDate(CocukDogumTarihi5DTP),
                        CocukHakkinda5 = CocukHakkinda5TextBox.Text,

                        CocukAdi6 = CocukAdi6TextBox.Text,
                        CocukCinsiyeti6 = CocukCinsiyeti6ComboBox.Text,
                        CocukDogumTarihi6 = TypeConversion.GetValidDate(CocukDogumTarihi6DTP),
                        CocukHakkinda6 = CocukHakkinda6TextBox.Text,
                    };

                    Tahsil yeniTahsil = new Tahsil
                    {
                        TahsilAdi1 = TahsilAdi1TextBox.Text,
                        OkulAdi1 = OkulAdi1TextBox.Text,
                        BolumAdi1 = BolumAdi1TextBox.Text,
                        MezuniyetTarihi1 = TypeConversion.GetValidDate(MezuniyetTarihi1TextBox),

                        TahsilAdi2 = TahsilAdi2TextBox.Text,
                        OkulAdi2 = OkulAdi2TextBox.Text,
                        BolumAdi2 = BolumAdi2TextBox.Text,
                        MezuniyetTarihi2 = TypeConversion.GetValidDate(MezuniyetTarihi2TextBox),

                        TahsilAdi3 = TahsilAdi3TextBox.Text,
                        OkulAdi3 = OkulAdi3TextBox.Text,
                        BolumAdi3 = BolumAdi3TextBox.Text,
                        MezuniyetTarihi3 = TypeConversion.GetValidDate(MezuniyetTarihi3TextBox),

                        TahsilAdi4 = TahsilAdi4TextBox.Text,
                        OkulAdi4 = OkulAdi4TextBox.Text,
                        BolumAdi4 = BolumAdi4TextBox.Text,
                        MezuniyetTarihi4 = TypeConversion.GetValidDate(MezuniyetTarihi4TextBox),

                        TahsilAdi5 = TahsilAdi5TextBox.Text,
                        OkulAdi5 = OkulAdi5TextBox.Text,
                        BolumAdi5 = BolumAdi5TextBox.Text,
                        MezuniyetTarihi5 = TypeConversion.GetValidDate(MezuniyetTarihi5TextBox),
                    };

                    Sertifika yeniSertifika = new Sertifika
                    {
                        SertifikaAdi1=Sertifika1TextBox.Text,
                        SertifikaAdi2 = Sertifika2TextBox.Text,
                        SertifikaAdi3 = Sertifika3TextBox.Text,
                        SertifikaAdi4 = Sertifika4TextBox.Text,
                        SertifikaAdi5 = Sertifika5TextBox.Text,
                        SertifikaAdi6 = Sertifika6TextBox.Text,
                        SertifikaAdi7 = Sertifika7TextBox.Text,
                        SertifikaAdi8 = Sertifika8TextBox.Text,
                        SertifikaAdi9 = Sertifika9TextBox.Text,
                        SertifikaAdi10 = Sertifika10TextBox.Text,
                    };

                    Nakil yeniNakil = new Nakil
                    {
                        BaslangicTarihi1 = TypeConversion.GetValidDate(BaslangicTarihi1DTP),
                        AyrilisTarihi1 = TypeConversion.GetValidDate(AyrilisTarihi1DTP),
                        Kurum1 = Kurum1TextBox.Text,
                        Birim1 = Birim1TextBox.Text,
                        Gorev1 = Gorev1TextBox.Text,
                        Aciklama1 = Aciklama1TextBox.Text,

                        BaslangicTarihi2 = TypeConversion.GetValidDate(BaslangicTarihi2DTP),
                        AyrilisTarihi2 = TypeConversion.GetValidDate(BaslangicTarihi2DTP),
                        Kurum2 = Kurum2TextBox.Text,
                        Birim2 = Birim2TextBox.Text,
                        Gorev2 = Gorev2TextBox.Text,
                        Aciklama2 = Aciklama2TextBox.Text,

                        BaslangicTarihi3 = TypeConversion.GetValidDate(BaslangicTarihi3DTP),
                        AyrilisTarihi3 = TypeConversion.GetValidDate(AyrilisTarihi3DTP),
                        Kurum3 = Kurum3TextBox.Text,
                        Birim3 = Birim3TextBox.Text,
                        Gorev3 = Gorev3TextBox.Text,
                        Aciklama3 = Aciklama3TextBox.Text,

                        BaslangicTarihi4 = TypeConversion.GetValidDate(BaslangicTarihi4DTP),
                        AyrilisTarihi4 = TypeConversion.GetValidDate(AyrilisTarihi4DTP),
                        Kurum4 = Kurum4TextBox.Text,
                        Birim4 = Birim4TextBox.Text,
                        Gorev4 = Gorev4TextBox.Text,
                        Aciklama4 = Aciklama4TextBox.Text,

                        BaslangicTarihi5 = TypeConversion.GetValidDate(BaslangicTarihi5DTP),
                        AyrilisTarihi5 = TypeConversion.GetValidDate(AyrilisTarihi5DTP),
                        Kurum5 = Kurum5TextBox.Text,
                        Birim5 = Birim5TextBox.Text,
                        Gorev5 = Gorev5TextBox.Text,
                        Aciklama5 = Aciklama5TextBox.Text,

                        BaslangicTarihi6 = TypeConversion.GetValidDate(BaslangicTarihi6DTP),
                        AyrilisTarihi6 = TypeConversion.GetValidDate(AyrilisTarihi6DTP),
                        Kurum6 = Kurum6TextBox.Text,
                        Birim6 = Birim6TextBox.Text,
                        Gorev6 = Gorev6TextBox.Text,
                        Aciklama6 = Aciklama6TextBox.Text,

                        BaslangicTarihi7 = TypeConversion.GetValidDate(BaslangicTarihi7DTP),
                        AyrilisTarihi7 = TypeConversion.GetValidDate(AyrilisTarihi7DTP),
                        Kurum7 = Kurum7TextBox.Text,
                        Birim7 = Birim7TextBox.Text,
                        Gorev7 = Gorev7TextBox.Text,
                        Aciklama7 = Aciklama7TextBox.Text,

                        BaslangicTarihi8 = TypeConversion.GetValidDate(BaslangicTarihi8DTP),
                        AyrilisTarihi8 = TypeConversion.GetValidDate(AyrilisTarihi8DTP),
                        Kurum8 = Kurum8TextBox.Text,
                        Birim8 = Birim8TextBox.Text,
                        Gorev8 = Gorev8TextBox.Text,
                        Aciklama8 = Aciklama8TextBox.Text,

                        BaslangicTarihi9 = TypeConversion.GetValidDate(BaslangicTarihi9DTP),
                        AyrilisTarihi9 = TypeConversion.GetValidDate(AyrilisTarihi9DTP),
                        Kurum9 = Kurum9TextBox.Text,
                        Birim9 = Birim9TextBox.Text,
                        Gorev9 = Gorev9TextBox.Text,
                        Aciklama9 = Aciklama9TextBox.Text,

                        BaslangicTarihi10 = TypeConversion.GetValidDate(BaslangicTarihi10DTP),
                        AyrilisTarihi10 = TypeConversion.GetValidDate(AyrilisTarihi10DTP),
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
                        CepTelNo2 = CepTelNo2TextBox.Text,
                    };

                    genelService.Add(yeniGenel);
                    nufusService.Add(yeniNufus);
                    tahsilService.Add(yeniTahsil);
                    sertifikaService.Add(yeniSertifika);
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

        private void DateTimePickerChanged(object sender, EventArgs e)
        {
            DateTimePicker picker = (DateTimePicker)sender;
            picker.CustomFormat = "dd-MM-yyyy";
        }

        private void DateTimePickerChanged(object sender, MouseEventArgs e)
        {
            DateTimePicker picker = (DateTimePicker)sender;
            picker.CustomFormat = "dd-MM-yyyy";
        }
    }
}
