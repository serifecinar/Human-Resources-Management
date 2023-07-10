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
        private object convert;

        public PersonelSicilKartiForm(int id)
        {
            InitializeComponent();

            genel = genelService.GetById(id);
            nufus = nufusService.GetById(id);
           // Genel 
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
        }
                

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void SicilKartiTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label76_Click(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PersonelSicilKartiForm_Load(object sender, EventArgs e)
        {
            
        }

        private void PersonelListesiButton_Click(object sender, EventArgs e)
        {

        }
    }
}
