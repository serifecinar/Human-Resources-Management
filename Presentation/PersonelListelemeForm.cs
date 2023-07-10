using Business.Services;
using Data_Acces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
       public partial class PersonelListelemeForm : Form
    {
        GenelService genelService = new GenelService();
        DataTable genelData= new DataTable();
        public PersonelListelemeForm()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void SicilKartiGosterButton_Click(object sender, EventArgs e)
        {
            if(PersonelListesiAdvancedDataGridView.SelectedRows != null)
            {
                int id = (int) PersonelListesiAdvancedDataGridView.SelectedRows[0].Cells[0].Value;

                PersonelSicilKartiForm personelSicilKartiForm = new PersonelSicilKartiForm(id);

                PersonelListesiGroupBox.Visible = false;

                personelSicilKartiForm.TopLevel = false;
                panel1.Controls.Clear();
                panel1.Controls.Add(personelSicilKartiForm);
                personelSicilKartiForm.Show();
            }
            else
            {
                MessageBox.Show("Geçersiz seçim", "Lütfen bir personel seçiniz.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlfabetikPersonelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var genelData = genelService.GetAll();
            //PersonelListesiDataGridView.DataSource = genelData;
            //PersonelListesiDataGridView.Refresh();

            //for (int i = 1; i < 14; i++)
            //{
            //    PersonelListesiDataGridView.Columns[i].Visible = false;
            //    if (i == 4 && i == 5 && i == 10 && i == 11)
            //    {
            //        MessageBox.Show(i);
            //        PersonelListesiDataGridView.Columns[i].Visible = true;
            //    }
            //}
        }


        private void PersonelListelemeForm_Activated(object sender, EventArgs e)
        {

        }

        private void PersonelListelemeForm_Load(object sender, EventArgs e)
        {
            var genelData = genelService.GetAll();
            PersonelListesiAdvancedDataGridView.DataSource = genelData;
            PersonelListesiAdvancedDataGridView.Refresh();
            PersonelListesiAdvancedDataGridView.Columns[0].Visible = false;
            PersonelListesiAdvancedDataGridView.Columns[1].Visible = false;
        }

        private void PersonelListesiGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PersonelListesiAdvancedDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void advancedDataGridViewSearchToolBar1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PersonelListesiAdvancedDataGridView_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            MessageBox.Show("TAMAM");
            genelData.DefaultView.RowFilter = PersonelListesiAdvancedDataGridView.FilterString;
        }

    }
}