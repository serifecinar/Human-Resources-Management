using Business.Helper;
using Business.Services;
using Data_Acces.Models;
using Presentation.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PersonelListelemeForm : Form
    {
        DataTable genelData = new DataTable();

        public PersonelListelemeForm()
        {

            InitializeComponent();
        }

        private void PersonelListelemeForm_Load(object sender, EventArgs e)
        {

            //var bgw = new BackgroundWorker();
            //bgw.DoWork += delegate
            //{
            
            genelData = DtToList.ToDataTable(GirisYetkiHelper.VeriFiltrele(Statics.GirisYetki));                  
            PersonelListesiAdvancedDataGridView.DataSource = genelData;
            //PersonelListesiAdvancedDataGridView.Refresh();
            //PersonelListesiAdvancedDataGridView.Columns[0].Visible = false;
            //PersonelListesiAdvancedDataGridView.Columns[1].Visible = false;
            //PersonelListesiAdvancedDataGridView.Columns[6].Visible = false;
            //PersonelListesiAdvancedDataGridView.Columns[7].Visible = false;
            //PersonelListesiAdvancedDataGridView.Columns[8].Visible = false;
            //PersonelListesiAdvancedDataGridView.Columns[9].Visible = false;
            //PersonelListesiAdvancedDataGridView.Columns[12].Visible = false;
            //PersonelListesiAdvancedDataGridView.Columns[13].Visible = false;
            //PersonelListesiAdvancedDataGridView.Columns[14].Visible = false;
            //};
            //bgw.RunWorkerAsync();
        }

        private void PersonelListesiAdvancedDataGridView_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            genelData.DefaultView.RowFilter = PersonelListesiAdvancedDataGridView.FilterString;
        }

        private void PersonelListesiAdvancedDataGridView_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            genelData.DefaultView.Sort = PersonelListesiAdvancedDataGridView.SortString;
        }

        private void TesisSefiKoordinatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'TESİS ŞEFİ - KOORDİNATÖR'";
        }

        private void ISGSorumlusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'İSG SORUMLUSU'";
        }

        private void DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'DENEYİMLİ BAKIM – ONARIM İŞLETME MÜHENDİSİ'";
        }

        private void AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'ATÖLYE / ÜNİTE SORUMLU MÜHENDİS + LABORATUVAR SORUMLU MÜHENDİS'";
        }

        private void SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'SAHA MÜHENDİSİ/BÖLGE SCADA SORUMLUSU'";
        }

        private void LaboratuvarAnalizGorevlisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'LABORATUVAR ANALİZ GÖREVLİSİ'";
        }

        private void BakimOnarimUstabaslariFormenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'BAKIM ONARIM USTABAŞLARI/FORMEN'";
        }

        private void BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'BÖLGE SCADA ve SİSTEM BAKIM ve KALİBRASYON OPERATÖRLERİ / TEKNİK RAPORLAMA SORUMLUSU/ BAKIM ONARIM USTALARI/ÇAMUR/KOJEN İŞL./BAKIM OPERATÖRLERİ'";
        }

        private void NumuneAlmaAnalizKalibrasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'NUMUNE ALMA ANALİZ KALİBRASYON'";
        }

        private void IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'İŞLETME BAKIM ONARIM OPERATÖRLERİ / İŞÇİLERİ/ İDARİ RAPORLAMA SORUMLUSU'";
        }

        private void IdariIslerVeInsanKaynaklariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'İDARİ İŞLER ve İNSAN KAYNAKLARI'";
        }

        private void TerfiMerkeziOperatorleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'TERFİ MERKEZİ OPERATÖRLERİ'";
        }

        private void SoforAracOperatorleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'ŞOFÖR / ARAÇ OPERATÖRLERİ'";
        }

        private void GenelHizmetliPersoneliDuzIscilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'GENEL HİZMETLİ PERSONELİ / DÜZ İŞÇİLER'";
        }

        private void KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'KÖY / MAHALLE TESİSLERİ DÖNÜŞTÜRÜCÜ PERSONELİ'";
        }

        private void KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'KÖY / MAHALLE TESİSLERİ İŞLETME OPERATÖRLERİ'";
        }

        private void engelliPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = "Unvani = 'ENGELLİ PERSONEL'";
        }

        private void Tumu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.RowFilter = string.Empty;
            genelData.DefaultView.Sort = string.Empty;
        }

        private void adanZyeSıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.Sort = "Soyadi ASC";
            genelData.DefaultView.Sort = "Adi ASC";
        }

        private void zdenAyaSıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.Sort = "Soyadi DESC";
            genelData.DefaultView.Sort = "Adi DESC";
        }

        private void Tumu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            genelData.DefaultView.Sort = string.Empty;
            genelData.DefaultView.RowFilter = string.Empty;
        }

        private void PersonelListesiAdvancedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int personelId = Convert.ToInt16(PersonelListesiAdvancedDataGridView.SelectedRows[0].Cells[1].Value);
        }

        private void DetayButton_Click(object sender, EventArgs e)
        {
            if (PersonelListesiAdvancedDataGridView.SelectedRows != null)
            {
                int personelId = Convert.ToInt16(PersonelListesiAdvancedDataGridView.SelectedRows[0].Cells[1].Value);
                PersonelListelemeTableLayoutPanel.Visible = false;
                PageChange.Change(PersonelSicilKartiPanel, this, new PersonelSicilKartiForm(personelId));
            }
            else
            {
                MessageBox.Show("Geçersiz seçim", "Lütfen bir personel seçiniz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void YeniKayitButton_Click(object sender, EventArgs e)
        {
            PageChange.Change(PersonelSicilKartiPanel, this, new PersonelSicilKartiForm());
        }

        private void IletisimButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scada ve Otomasyon Şefliği ile irtibata geçiniz.\n\nDahili:\nŞerife ÇINAR - 6533");
        }
    }
}