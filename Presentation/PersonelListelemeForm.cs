using Business.Services;
using Data_Acces.Models;
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
    public partial class PersonelListelemeForm : Form
    {
        PersonelSicilKartiForm form3 = new PersonelSicilKartiForm();
        GenelService genelService = new GenelService();
        public PersonelListelemeForm()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            /*form3.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form3);
            form3.Show();*/
        }

        private void PersonelListelemeForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı '_DataAcces_ContextDataSet.Genels' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.genelsTableAdapter.Fill(this._DataAcces_ContextDataSet.Genels);
            PersonelListesiListBox.Text = genelService.GetById(Genel 3);
        }

        private void tESİSŞEFİKOORDİNATÖRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bAKIMONARIMUSTABAŞLARIFORMENToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeneyimliBakimOnarimİsletmeMühendisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PersonelListesiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void SicilKartiGosterButton_Click(object sender, EventArgs e)
        {
            form3.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form3);
            form3.Show();


        }
    }
}