using Business.Helper;
using System;
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
            CinsiyetAtamalari();
            YasAtamalari();
            UnvanAtamalari();
        }

        private void UnvanAtamalari()
        {
            PersonelSayisiUnvan1Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("TESİS ŞEFİ - KOORDİNATÖR").ToString();
            PersonelSayisiUnvan2Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("İSG SORUMLUSU").ToString();
            PersonelSayisiUnvan3Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("DENEYİMLİ BAKIM – ONARIM İŞLETME MÜHENDİSİ").ToString();
            PersonelSayisiUnvan4Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("ATÖLYE / ÜNİTE SORUMLU MÜHENDİS + LABORATUVAR SORUMLU MÜHENDİS").ToString();
            PersonelSayisiUnvan5Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("SAHA MÜHENDİSİ/BÖLGE SCADA SORUMLUSU").ToString();
            PersonelSayisiUnvan6Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("LABORATUVAR ANALİZ GÖREVLİSİ").ToString();
            PersonelSayisiUnvan7Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("BAKIM ONARIM USTABAŞLARI/FORMEN").ToString();
            PersonelSayisiUnvan8Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("BÖLGE SCADA ve SİSTEM BAKIM ve KALİBRASYON OPERATÖRLERİ / TEKNİK RAPORLAMA SORUMLUSU/ BAKIM ONARIM USTALARI/ÇAMUR/KOJEN İŞL./BAKIM OPERATÖRLERİ").ToString();
            PersonelSayisiUnvan9Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("NUMUNE ALMA ANALİZ KALİBRASYON").ToString();
            PersonelSayisiUnvan10Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("İŞLETME BAKIM ONARIM OPERATÖRLERİ / İŞÇİLERİ/ İDARİ RAPORLAMA SORUMLUSU").ToString();
            PersonelSayisiUnvan11Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("İDARİ İŞLER ve İNSAN KAYNAKLARI").ToString();
            PersonelSayisiUnvan12Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("TERFİ MERKEZİ OPERATÖRLERİ").ToString();
            PersonelSayisiUnvan13Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("ŞOFÖR / ARAÇ OPERATÖRLERİ").ToString();
            PersonelSayisiUnvan14Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("GENEL HİZMETLİ PERSONELİ / DÜZ İŞÇİLER").ToString();
            PersonelSayisiUnvan15Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("KÖY / MAHALLE TESİSLERİ DÖNÜŞTÜRÜCÜ PERSONELİ").ToString();
            PersonelSayisiUnvan16Label.Text = UnvanHesaplamalariHelper.UnvanHesaplama("KÖY / MAHALLE TESİSLERİ İŞLETME OPERATÖRLERİ").ToString();
            PersonelSayisiUnvanToplamLabel.Text = NufusHesaplamalariHelper.ToplamSayi.ToString();
        }

        public void CinsiyetAtamalari()
        {
            KadinSayisiLabel.Text = NufusHesaplamalariHelper.KadinSayisi.ToString()+" Kadın";
            ErkekSayisiLabel.Text = NufusHesaplamalariHelper.ErkekSayisi.ToString()+" Erkek";

            CinsiyetOraniLabel.Text = $"%{NufusHesaplamalariHelper.KadinOrani} - %{NufusHesaplamalariHelper.ErkekOrani}";

            CreateDoughnutChart();
        }

        private void CreateDoughnutChart()
        {
            // Kadın ve erkek sayıları
            int kadinSayisi = NufusHesaplamalariHelper.KadinSayisi;
            int erkekSayisi = NufusHesaplamalariHelper.ErkekSayisi;

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

        public void YasAtamalari() => label20.Text = YasHesaplamalariHelper.YasHesap().ToString();

    }
}
