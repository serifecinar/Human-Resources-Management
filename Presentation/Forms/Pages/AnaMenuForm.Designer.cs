namespace Presentation.Forms.Pages
{
    partial class AnaMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaMenuForm));
            this.PanelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GüncelleButton = new System.Windows.Forms.Button();
            this.PersonelListelemeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NakilButton = new System.Windows.Forms.Button();
            this.YeniKayitButton = new System.Windows.Forms.Button();
            this.PanelContent.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContent
            // 
            this.PanelContent.Controls.Add(this.tableLayoutPanel1);
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1293, 696);
            this.PanelContent.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.GüncelleButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PersonelListelemeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NakilButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.YeniKayitButton, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(250, 50, 250, 50);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1293, 696);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // GüncelleButton
            // 
            this.GüncelleButton.BackColor = System.Drawing.Color.DarkRed;
            this.GüncelleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GüncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GüncelleButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GüncelleButton.Image = ((System.Drawing.Image)(resources.GetObject("GüncelleButton.Image")));
            this.GüncelleButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GüncelleButton.Location = new System.Drawing.Point(253, 456);
            this.GüncelleButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.GüncelleButton.Name = "GüncelleButton";
            this.GüncelleButton.Size = new System.Drawing.Size(258, 187);
            this.GüncelleButton.TabIndex = 8;
            this.GüncelleButton.Tag = "";
            this.GüncelleButton.Text = "GÜNCELLE";
            this.GüncelleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GüncelleButton.UseVisualStyleBackColor = false;
            // 
            // PersonelListelemeButton
            // 
            this.PersonelListelemeButton.BackColor = System.Drawing.Color.DarkRed;
            this.PersonelListelemeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonelListelemeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelListelemeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PersonelListelemeButton.Image = ((System.Drawing.Image)(resources.GetObject("PersonelListelemeButton.Image")));
            this.PersonelListelemeButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PersonelListelemeButton.Location = new System.Drawing.Point(253, 60);
            this.PersonelListelemeButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.PersonelListelemeButton.Name = "PersonelListelemeButton";
            this.PersonelListelemeButton.Size = new System.Drawing.Size(258, 185);
            this.PersonelListelemeButton.TabIndex = 4;
            this.PersonelListelemeButton.Tag = "";
            this.PersonelListelemeButton.Text = "PERSONEL LİSTELEME ";
            this.PersonelListelemeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PersonelListelemeButton.UseVisualStyleBackColor = false;
            this.PersonelListelemeButton.Click += new System.EventHandler(this.PersonelListelemeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(517, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // NakilButton
            // 
            this.NakilButton.BackColor = System.Drawing.Color.DarkRed;
            this.NakilButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NakilButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NakilButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NakilButton.Image = ((System.Drawing.Image)(resources.GetObject("NakilButton.Image")));
            this.NakilButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NakilButton.Location = new System.Drawing.Point(781, 60);
            this.NakilButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.NakilButton.Name = "NakilButton";
            this.NakilButton.Size = new System.Drawing.Size(259, 185);
            this.NakilButton.TabIndex = 6;
            this.NakilButton.Tag = "";
            this.NakilButton.Text = "NAKİL";
            this.NakilButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NakilButton.UseVisualStyleBackColor = false;
            this.NakilButton.Click += new System.EventHandler(this.NakilButton_Click);
            // 
            // YeniKayitButton
            // 
            this.YeniKayitButton.BackColor = System.Drawing.Color.DarkRed;
            this.YeniKayitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YeniKayitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YeniKayitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.YeniKayitButton.Image = ((System.Drawing.Image)(resources.GetObject("YeniKayitButton.Image")));
            this.YeniKayitButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YeniKayitButton.Location = new System.Drawing.Point(781, 456);
            this.YeniKayitButton.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.YeniKayitButton.Name = "YeniKayitButton";
            this.YeniKayitButton.Size = new System.Drawing.Size(259, 187);
            this.YeniKayitButton.TabIndex = 7;
            this.YeniKayitButton.Tag = "";
            this.YeniKayitButton.Text = "YENİ KAYIT";
            this.YeniKayitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.YeniKayitButton.UseVisualStyleBackColor = false;
            // 
            // AnaMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 696);
            this.Controls.Add(this.PanelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaMenuForm";
            this.Text = "AnaMenuForm";
            this.PanelContent.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button GüncelleButton;
        private System.Windows.Forms.Button PersonelListelemeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NakilButton;
        private System.Windows.Forms.Button YeniKayitButton;
    }
}