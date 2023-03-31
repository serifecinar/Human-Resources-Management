using Business.Services;
using Data_Acces.Models;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GirisForm : Form
    {
        //PersonelListelemeForm form2 = new PersonelListelemeForm();
        IKYGenelForm IKYGenelForm = new IKYGenelForm();

        GenelService genelService = new GenelService();
        public GirisForm()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        private void GirisButton_Click(object sender, EventArgs e)
        {
            //if (kullaniciadi.Text='');
            //{

            ///var genelData = genelService.GetAll();
            //    dataGridView1.DataSource = genelData;
            //    dataGridView1.Refresh();

            Genel yeniGenel = new Genel
            {
                TCKimlikNo = "41641021818"
            };

            genelService.Add(yeniGenel);
            
            IKYGenelForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(IKYGenelForm);
            IKYGenelForm.Show();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
