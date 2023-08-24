using Business.Helper;
using Presentation.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentation.Forms.Pages
{
    public partial class OzetTabloForm : Form
    {
        public OzetTabloForm()
        {
            InitializeComponent();
        }

        private void OzetTabloForm_Load(object sender, EventArgs e)
        {
            //if(Statics.GirisYetki != "")
            //{
                CinsiyetAtamalari();
                YasAtamalari();
                UnvanAtamalari();
                EgitimAtamalari();
            //}
        }

        private void UnvanAtamalari()
        {
            PersonelSayisiUnvan1Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("TESİS ŞEFİ - KOORDİNATÖR", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan2Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("İSG SORUMLUSU", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan3Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("DENEYİMLİ BAKIM – ONARIM İŞLETME MÜHENDİSİ", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan4Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("ATÖLYE / ÜNİTE SORUMLU MÜHENDİS + LABORATUVAR SORUMLU MÜHENDİS", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan5Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("SAHA MÜHENDİSİ/BÖLGE SCADA SORUMLUSU", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan6Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("LABORATUVAR ANALİZ GÖREVLİSİ", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan7Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("BAKIM ONARIM USTABAŞLARI/FORMEN", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan8Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("BÖLGE SCADA ve SİSTEM BAKIM ve KALİBRASYON OPERATÖRLERİ / TEKNİK RAPORLAMA SORUMLUSU/ BAKIM ONARIM USTALARI/ÇAMUR/KOJEN İŞL./BAKIM OPERATÖRLERİ", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan9Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("NUMUNE ALMA ANALİZ KALİBRASYON", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan10Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("İŞLETME BAKIM ONARIM OPERATÖRLERİ / İŞÇİLERİ/ İDARİ RAPORLAMA SORUMLUSU", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan11Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("İDARİ İŞLER ve İNSAN KAYNAKLARI", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan12Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("TERFİ MERKEZİ OPERATÖRLERİ", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan13Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("ŞOFÖR / ARAÇ OPERATÖRLERİ", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan14Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("GENEL HİZMETLİ PERSONELİ / DÜZ İŞÇİLER", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan15Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("KÖY / MAHALLE TESİSLERİ DÖNÜŞTÜRÜCÜ PERSONELİ", Statics.GirisYetki).ToString();
            PersonelSayisiUnvan16Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("KÖY / MAHALLE TESİSLERİ İŞLETME OPERATÖRLERİ", Statics.GirisYetki).ToString();
            PersonelSayisiUnvanToplamLabel.Text = NufusHesaplamalariHelper.ToplamSayi(Statics.GirisYetki).ToString();
        }

        public void CinsiyetAtamalari()
        {
            KadinSayisiLabel.Text = NufusHesaplamalariHelper.KadinSayisi(Statics.GirisYetki).ToString() + " Kadın";
            ErkekSayisiLabel.Text = NufusHesaplamalariHelper.ErkekSayisi(Statics.GirisYetki).ToString() + " Erkek";

            CinsiyetOraniLabel.Text = $"%{NufusHesaplamalariHelper.KadinOrani(Statics.GirisYetki)} - %{NufusHesaplamalariHelper.ErkekOrani(Statics.GirisYetki)}";

            CinsiyetChartOlustur();
        }
        public void YasAtamalari()
        {
            YasChartOlustur();
        }

        private void EgitimAtamalari()
        {
            EgitimChartOlustur();
        }

        private void CinsiyetChartOlustur()
        {
            // Kadın ve erkek sayıları
            int kadinSayisi = NufusHesaplamalariHelper.KadinSayisi(Statics.GirisYetki);
            int erkekSayisi = NufusHesaplamalariHelper.ErkekSayisi(Statics.GirisYetki);

            // Chart kontrolüne veri serisi eklemek için bir dizi oluşturuyoruz
            int[] dataPoints = { kadinSayisi, erkekSayisi };

            // Seriyi oluşturuyoruz ve verileri ekliyoruz
            Series series = new Series("Cinsiyetler");
            series.ChartType = SeriesChartType.Doughnut;
            series.Points.DataBindXY(new string[] { "Kadın", "Erkek" }, dataPoints);

            // Seriyi Chart kontrolüne ekliyoruz
            CinsiyetChart.Series.Clear();
            CinsiyetChart.Series.Add(series);

            // Renkleri belirleyebilirsiniz (isteğe bağlı)
            CinsiyetChart.Series["Cinsiyetler"].Points[0].Color = System.Drawing.Color.Orange;
            CinsiyetChart.Series["Cinsiyetler"].Points[1].Color = System.Drawing.Color.DarkRed;

            // Eğer istenirse pasta dilimi rengini ve açısını değiştirebilirsiniz (isteğe bağlı)
            CinsiyetChart.Series["Cinsiyetler"]["DoughnutRadius"] = "75"; // Pasta dilimi iç yarıçapı (0-100 arasında değer alır)
            CinsiyetChart.Series["Cinsiyetler"]["PieStartAngle"] = "180"; // Başlangıç açısı (0-360 arasında değer alır)            
        }

        //public void YasChartOlustur()
        //{
        //    // Chart kontrolüne veri serisi eklemek için bir dizi oluşturuyoruz
        //    List<int?> yaslar = YasHesaplamalariHelper.YasHesap(Statics.GirisYetki);

        //    Dictionary<int?, int?> frekanslar = YasHesaplamalariHelper.YasCalculateFrequencies(yaslar);
        //    YasChart.Series["Yaslar"].ChartType = SeriesChartType.Column;
        //    YasChart.Series["Yaslar"].Points.DataBindXY(frekanslar.Keys, frekanslar.Values);
        //    YasChart.Series["Yaslar"].IsValueShownAsLabel = true;
        //}

        private void EgitimChartOlustur()
        {
            List<string> egitimler = EgitimHesaplamalariHelper.EgitimHesap(Statics.GirisYetki);

            Dictionary<string, int> frekanslar = EgitimHesaplamalariHelper.EgitimCalculateFrequencies(egitimler);

            // İstenilen sıraya göre kategorileri oluşturun
            List<string> siraliKategoriler = new List<string> { "İLKOKUL","İLKÖĞRETİM","LİSE","ÖNLİSANS","LİSANS ÖĞRENCİSİ","LİSANS","YÜKSEK LİSANS"};

            // Sırayı gözeterek yeni bir sözlük oluşturun
            Dictionary<string, int> siraliFrekanslar = new Dictionary<string, int>();
            foreach (string kategori in siraliKategoriler)
            {
                if (frekanslar.ContainsKey(kategori))
                {
                    siraliFrekanslar.Add(kategori, frekanslar[kategori]);
                }
            }

            EgitimChart.Series["Egitimler"].ChartType = SeriesChartType.Column;
            EgitimChart.Series["Egitimler"].Points.DataBindXY(siraliFrekanslar.Keys, siraliFrekanslar.Values);
            EgitimChart.Series["Egitimler"].IsValueShownAsLabel = true;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void YasChartOlustur()
        {
            List<int?> yaslar = YasHesaplamalariHelper.YasHesap(Statics.GirisYetki);

            // Yaş verilerini belirli yaş aralıklarına gruplayan fonksiyonu kullan
            Dictionary<int, int> grupluVeriler = GrupluYasHesapla(yaslar);

            YasChart.Series["Yaslar"].ChartType = SeriesChartType.Column;
            YasChart.Series["Yaslar"].Points.DataBindXY(grupluVeriler.Keys, grupluVeriler.Values);
            YasChart.Series["Yaslar"].IsValueShownAsLabel = true;
        }

        private Dictionary<int, int> GrupluYasHesapla(List<int?> yaslar)
        {
            // Yaş aralıklarını ve grupların frekanslarını hesaplayan bir kod
            // Örnek olarak, yaşları 10 yaş aralıklarına gruplayalım
            int yasAraligi = 10;

            Dictionary<int, int> frekanslar = new Dictionary<int, int>();

            foreach (int? yas in yaslar)
            {
                if (yas.HasValue)
                {
                    int yasGrubu = (int)(yas / yasAraligi) * yasAraligi;
                    if (frekanslar.ContainsKey(yasGrubu))
                    {
                        frekanslar[yasGrubu]++;
                    }
                    else
                    {
                        frekanslar[yasGrubu] = 1;
                    }
                }
            }

            return frekanslar;
        }

    }
}
