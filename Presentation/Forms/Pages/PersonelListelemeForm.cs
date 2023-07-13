using Business.Services;
using Presentation.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentation
{
    public partial class PersonelListelemeForm : Form
    {
        GenelService genelService = new GenelService();

        DataTable genelData = new DataTable();
        public PersonelListelemeForm()
        {
            InitializeComponent();
        }

        private void SicilKartiGosterButton_Click(object sender, EventArgs e)
        {
            if (PersonelListesiAdvancedDataGridView.SelectedRows != null)
            {
                int personelId = (int)PersonelListesiAdvancedDataGridView.SelectedRows[0].Cells[1].Value;

                PageChange.Change(PanelContent, this, new PersonelSicilKartiForm(personelId));
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
            genelData = DtToList.ToDataTable(genelService.GetAll());
            PersonelListesiAdvancedDataGridView.DataSource = genelData;
            PersonelListesiAdvancedDataGridView.Refresh();
            PersonelListesiAdvancedDataGridView.Columns[0].Visible = false;
            PersonelListesiAdvancedDataGridView.Columns[1].Visible = false;
        }

        private void PersonelListesiAdvancedDataGridView_FilterStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.FilterEventArgs e)
        {
            genelData.DefaultView.RowFilter = PersonelListesiAdvancedDataGridView.FilterString;
        }

        private void PersonelListesiAdvancedDataGridView_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            genelData.DefaultView.Sort = PersonelListesiAdvancedDataGridView.SortString;
        }
    }
}