namespace Presentation
{
    partial class PersonelListelemeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.PersonelListesiAdvancedDataGridView = new Zuby.ADGV.AdvancedDataGridView();
            this.SicilKartiGosterButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AlfabetikPersonelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tumu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adanZyeSıralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zdenAyaSıralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnvanBazliPersonelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tumu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TesisSefiKoordinatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ISGSorumlusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LaboratuvarAnalizGorevlisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BakimOnarimUstabaslariFormenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NumuneAlmaAnalizKalibrasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IdariIslerVeInsanKaynaklariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TerfiMerkeziOperatorleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SoforAracOperatorleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GenelHizmetliPersoneliDuzIscilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engelliPersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelListesiAdvancedDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1287, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "PERSONEL LİSTELEME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonelListesiAdvancedDataGridView
            // 
            this.PersonelListesiAdvancedDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PersonelListesiAdvancedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonelListesiAdvancedDataGridView.FilterAndSortEnabled = true;
            this.PersonelListesiAdvancedDataGridView.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            this.PersonelListesiAdvancedDataGridView.Location = new System.Drawing.Point(3, 98);
            this.PersonelListesiAdvancedDataGridView.MultiSelect = false;
            this.PersonelListesiAdvancedDataGridView.Name = "PersonelListesiAdvancedDataGridView";
            this.PersonelListesiAdvancedDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PersonelListesiAdvancedDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonelListesiAdvancedDataGridView.Size = new System.Drawing.Size(1287, 448);
            this.PersonelListesiAdvancedDataGridView.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            this.PersonelListesiAdvancedDataGridView.TabIndex = 18;
            this.PersonelListesiAdvancedDataGridView.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.PersonelListesiAdvancedDataGridView_SortStringChanged);
            this.PersonelListesiAdvancedDataGridView.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.PersonelListesiAdvancedDataGridView_FilterStringChanged);
            // 
            // SicilKartiGosterButton
            // 
            this.SicilKartiGosterButton.BackColor = System.Drawing.Color.DarkRed;
            this.SicilKartiGosterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SicilKartiGosterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SicilKartiGosterButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SicilKartiGosterButton.Location = new System.Drawing.Point(500, 559);
            this.SicilKartiGosterButton.Margin = new System.Windows.Forms.Padding(500, 10, 500, 10);
            this.SicilKartiGosterButton.Name = "SicilKartiGosterButton";
            this.SicilKartiGosterButton.Size = new System.Drawing.Size(293, 50);
            this.SicilKartiGosterButton.TabIndex = 13;
            this.SicilKartiGosterButton.Text = "SİCİL KARTI GÖSTER";
            this.SicilKartiGosterButton.UseVisualStyleBackColor = false;
            this.SicilKartiGosterButton.Click += new System.EventHandler(this.SicilKartiGosterButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlfabetikPersonelListesiToolStripMenuItem,
            this.UnvanBazliPersonelListesiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 68);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AlfabetikPersonelListesiToolStripMenuItem
            // 
            this.AlfabetikPersonelListesiToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AlfabetikPersonelListesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tumu1ToolStripMenuItem,
            this.adanZyeSıralamaToolStripMenuItem,
            this.zdenAyaSıralamaToolStripMenuItem});
            this.AlfabetikPersonelListesiToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AlfabetikPersonelListesiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.AlfabetikPersonelListesiToolStripMenuItem.Name = "AlfabetikPersonelListesiToolStripMenuItem";
            this.AlfabetikPersonelListesiToolStripMenuItem.Size = new System.Drawing.Size(264, 23);
            this.AlfabetikPersonelListesiToolStripMenuItem.Text = "ALFABETİK PERSONEL LİSTESİ";
            // 
            // Tumu1ToolStripMenuItem
            // 
            this.Tumu1ToolStripMenuItem.Name = "Tumu1ToolStripMenuItem";
            this.Tumu1ToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.Tumu1ToolStripMenuItem.Text = "Tümü";
            this.Tumu1ToolStripMenuItem.Click += new System.EventHandler(this.Tumu1ToolStripMenuItem_Click);
            // 
            // adanZyeSıralamaToolStripMenuItem
            // 
            this.adanZyeSıralamaToolStripMenuItem.Name = "adanZyeSıralamaToolStripMenuItem";
            this.adanZyeSıralamaToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.adanZyeSıralamaToolStripMenuItem.Text = "A\'dan Z\'ye Sıralama";
            this.adanZyeSıralamaToolStripMenuItem.Click += new System.EventHandler(this.adanZyeSıralamaToolStripMenuItem_Click);
            // 
            // zdenAyaSıralamaToolStripMenuItem
            // 
            this.zdenAyaSıralamaToolStripMenuItem.Name = "zdenAyaSıralamaToolStripMenuItem";
            this.zdenAyaSıralamaToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.zdenAyaSıralamaToolStripMenuItem.Text = "Z\'den A\'ya Sıralama";
            this.zdenAyaSıralamaToolStripMenuItem.Click += new System.EventHandler(this.zdenAyaSıralamaToolStripMenuItem_Click);
            // 
            // UnvanBazliPersonelListesiToolStripMenuItem
            // 
            this.UnvanBazliPersonelListesiToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnvanBazliPersonelListesiToolStripMenuItem.Checked = true;
            this.UnvanBazliPersonelListesiToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UnvanBazliPersonelListesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tumu2ToolStripMenuItem,
            this.TesisSefiKoordinatorToolStripMenuItem,
            this.ISGSorumlusuToolStripMenuItem,
            this.DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem,
            this.AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem,
            this.SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem,
            this.LaboratuvarAnalizGorevlisiToolStripMenuItem,
            this.BakimOnarimUstabaslariFormenToolStripMenuItem,
            this.BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem,
            this.NumuneAlmaAnalizKalibrasyonToolStripMenuItem,
            this.IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem,
            this.IdariIslerVeInsanKaynaklariToolStripMenuItem,
            this.TerfiMerkeziOperatorleriToolStripMenuItem,
            this.SoforAracOperatorleriToolStripMenuItem,
            this.GenelHizmetliPersoneliDuzIscilerToolStripMenuItem,
            this.KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem,
            this.KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem,
            this.engelliPersonelToolStripMenuItem});
            this.UnvanBazliPersonelListesiToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UnvanBazliPersonelListesiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.UnvanBazliPersonelListesiToolStripMenuItem.Name = "UnvanBazliPersonelListesiToolStripMenuItem";
            this.UnvanBazliPersonelListesiToolStripMenuItem.Size = new System.Drawing.Size(283, 23);
            this.UnvanBazliPersonelListesiToolStripMenuItem.Text = "UNVAN BAZLI PERSONEL LİSTESİ";
            // 
            // Tumu2ToolStripMenuItem
            // 
            this.Tumu2ToolStripMenuItem.Name = "Tumu2ToolStripMenuItem";
            this.Tumu2ToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.Tumu2ToolStripMenuItem.Text = "Tümü";
            this.Tumu2ToolStripMenuItem.Click += new System.EventHandler(this.Tumu2ToolStripMenuItem_Click);
            // 
            // TesisSefiKoordinatorToolStripMenuItem
            // 
            this.TesisSefiKoordinatorToolStripMenuItem.Name = "TesisSefiKoordinatorToolStripMenuItem";
            this.TesisSefiKoordinatorToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.TesisSefiKoordinatorToolStripMenuItem.Text = "Tesis Şefi – Koordinatör";
            this.TesisSefiKoordinatorToolStripMenuItem.Click += new System.EventHandler(this.TesisSefiKoordinatorToolStripMenuItem_Click);
            // 
            // ISGSorumlusuToolStripMenuItem
            // 
            this.ISGSorumlusuToolStripMenuItem.Name = "ISGSorumlusuToolStripMenuItem";
            this.ISGSorumlusuToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.ISGSorumlusuToolStripMenuItem.Text = "İSG Sorumlusu";
            this.ISGSorumlusuToolStripMenuItem.Click += new System.EventHandler(this.ISGSorumlusuToolStripMenuItem_Click);
            // 
            // DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem
            // 
            this.DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem.Name = "DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem";
            this.DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem.Text = "Deneyimli Bakım – Onarım İşletme Mühendisi";
            this.DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem.Click += new System.EventHandler(this.DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem_Click);
            // 
            // AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem
            // 
            this.AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem.Name = "AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem";
            this.AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem.Text = "Atölye / Ünite Sorumlu Mühendis + Laboratuvar Sorumlu Mühendis";
            this.AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem.Click += new System.EventHandler(this.AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem_Click);
            // 
            // SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem
            // 
            this.SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem.Name = "SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem";
            this.SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem.Text = "Saha Mühendisi/Bölge Scada Sorumlusu";
            this.SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem.Click += new System.EventHandler(this.SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem_Click);
            // 
            // LaboratuvarAnalizGorevlisiToolStripMenuItem
            // 
            this.LaboratuvarAnalizGorevlisiToolStripMenuItem.Name = "LaboratuvarAnalizGorevlisiToolStripMenuItem";
            this.LaboratuvarAnalizGorevlisiToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.LaboratuvarAnalizGorevlisiToolStripMenuItem.Text = "Laboratuvar Analiz Görevlisi";
            this.LaboratuvarAnalizGorevlisiToolStripMenuItem.Click += new System.EventHandler(this.LaboratuvarAnalizGorevlisiToolStripMenuItem_Click);
            // 
            // BakimOnarimUstabaslariFormenToolStripMenuItem
            // 
            this.BakimOnarimUstabaslariFormenToolStripMenuItem.Name = "BakimOnarimUstabaslariFormenToolStripMenuItem";
            this.BakimOnarimUstabaslariFormenToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.BakimOnarimUstabaslariFormenToolStripMenuItem.Text = "Bakım Onarım Ustabaşları/Formen";
            this.BakimOnarimUstabaslariFormenToolStripMenuItem.Click += new System.EventHandler(this.BakimOnarimUstabaslariFormenToolStripMenuItem_Click);
            // 
            // BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem
            // 
            this.BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem.Name = "BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnar" +
    "imUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem";
            this.BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem.Text = "Bölge Scada Ve Sistem Bakım Ve Kalibrasyon Operatörleri / Teknik Raporlama Soruml" +
    "usu/ Bakım Onarım Ustaları/Çamur/Kojen İşl./Bakım Operatörleri";
            this.BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem.Click += new System.EventHandler(this.BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem_Click);
            // 
            // NumuneAlmaAnalizKalibrasyonToolStripMenuItem
            // 
            this.NumuneAlmaAnalizKalibrasyonToolStripMenuItem.Name = "NumuneAlmaAnalizKalibrasyonToolStripMenuItem";
            this.NumuneAlmaAnalizKalibrasyonToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.NumuneAlmaAnalizKalibrasyonToolStripMenuItem.Text = "Numune Alma Analiz Kalibrasyon";
            this.NumuneAlmaAnalizKalibrasyonToolStripMenuItem.Click += new System.EventHandler(this.NumuneAlmaAnalizKalibrasyonToolStripMenuItem_Click);
            // 
            // IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem
            // 
            this.IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem.Name = "IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem";
            this.IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem.Text = "İşletme Bakım Onarım Operatörleri / İşçileri/ İdari Raporlama Sorumlusu";
            this.IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem.Click += new System.EventHandler(this.IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem_Click);
            // 
            // IdariIslerVeInsanKaynaklariToolStripMenuItem
            // 
            this.IdariIslerVeInsanKaynaklariToolStripMenuItem.Name = "IdariIslerVeInsanKaynaklariToolStripMenuItem";
            this.IdariIslerVeInsanKaynaklariToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.IdariIslerVeInsanKaynaklariToolStripMenuItem.Text = "İdari İşler Ve İnsan Kaynakları";
            this.IdariIslerVeInsanKaynaklariToolStripMenuItem.Click += new System.EventHandler(this.IdariIslerVeInsanKaynaklariToolStripMenuItem_Click);
            // 
            // TerfiMerkeziOperatorleriToolStripMenuItem
            // 
            this.TerfiMerkeziOperatorleriToolStripMenuItem.Name = "TerfiMerkeziOperatorleriToolStripMenuItem";
            this.TerfiMerkeziOperatorleriToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.TerfiMerkeziOperatorleriToolStripMenuItem.Text = "Terfi Merkezi Operatörleri";
            this.TerfiMerkeziOperatorleriToolStripMenuItem.Click += new System.EventHandler(this.TerfiMerkeziOperatorleriToolStripMenuItem_Click);
            // 
            // SoforAracOperatorleriToolStripMenuItem
            // 
            this.SoforAracOperatorleriToolStripMenuItem.Name = "SoforAracOperatorleriToolStripMenuItem";
            this.SoforAracOperatorleriToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.SoforAracOperatorleriToolStripMenuItem.Text = "Şoför / Araç Operatörleri";
            this.SoforAracOperatorleriToolStripMenuItem.Click += new System.EventHandler(this.SoforAracOperatorleriToolStripMenuItem_Click);
            // 
            // GenelHizmetliPersoneliDuzIscilerToolStripMenuItem
            // 
            this.GenelHizmetliPersoneliDuzIscilerToolStripMenuItem.Name = "GenelHizmetliPersoneliDuzIscilerToolStripMenuItem";
            this.GenelHizmetliPersoneliDuzIscilerToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.GenelHizmetliPersoneliDuzIscilerToolStripMenuItem.Text = "Genel Hizmetli Personeli / Düz İşçiler";
            this.GenelHizmetliPersoneliDuzIscilerToolStripMenuItem.Click += new System.EventHandler(this.GenelHizmetliPersoneliDuzIscilerToolStripMenuItem_Click);
            // 
            // KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem
            // 
            this.KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem.Name = "KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem";
            this.KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem.Text = "Köy / Mahalle Tesisleri Dönüştürücü Personeli";
            this.KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem.Click += new System.EventHandler(this.KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem_Click);
            // 
            // KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem
            // 
            this.KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem.Name = "KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem";
            this.KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem.Text = "Köy / Mahalle Tesisleri İşletme Operatörleri";
            this.KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem.Click += new System.EventHandler(this.KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem_Click);
            // 
            // engelliPersonelToolStripMenuItem
            // 
            this.engelliPersonelToolStripMenuItem.Name = "engelliPersonelToolStripMenuItem";
            this.engelliPersonelToolStripMenuItem.Size = new System.Drawing.Size(1129, 24);
            this.engelliPersonelToolStripMenuItem.Text = "Engelli Personel";
            this.engelliPersonelToolStripMenuItem.Click += new System.EventHandler(this.engelliPersonelToolStripMenuItem_Click);
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.tableLayoutPanel1);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1293, 619);
            this.PanelContent.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SicilKartiGosterButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PersonelListesiAdvancedDataGridView, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.361874F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.3441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1293, 619);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // PersonelListelemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1293, 619);
            this.Controls.Add(this.PanelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelListelemeForm";
            this.Text = "PERSONEL LİSTELEME";
            this.Activated += new System.EventHandler(this.PersonelListelemeForm_Activated);
            this.Load += new System.EventHandler(this.PersonelListelemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonelListesiAdvancedDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelContent.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SicilKartiGosterButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AlfabetikPersonelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnvanBazliPersonelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TesisSefiKoordinatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ISGSorumlusuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AtolyeUniteSorumluMuhendisLaboratuvarSorumluMuhendisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SahaMuhendisiBolgeScadaSorumlusuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LaboratuvarAnalizGorevlisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BakimOnarimUstabaslariFormenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BolgeScadaVeSistemBakimVeKalibrasyonOperatorleriTeknikRaporlamaSorumlusuBakimOnarimUstalariCamurKojenIslBakimOperatorleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NumuneAlmaAnalizKalibrasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IsletmeBakimOnarimOperatorleriIscileriIdariRaporlamaSorumlusuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IdariIslerVeInsanKaynaklariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TerfiMerkeziOperatorleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SoforAracOperatorleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GenelHizmetliPersoneliDuzIscilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KoyMahalleTesisleriDonusturucuPersoneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KoyMahalleTesisleriIsletmeOperatorleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engelliPersonelToolStripMenuItem;
        private Zuby.ADGV.AdvancedDataGridView PersonelListesiAdvancedDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem Tumu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tumu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adanZyeSıralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zdenAyaSıralamaToolStripMenuItem;
    }
}