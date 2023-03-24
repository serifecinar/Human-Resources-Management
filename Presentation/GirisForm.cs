using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GirisForm : Form
    {
        //PersonelListelemeForm form2 = new PersonelListelemeForm();
        IKYGenelForm IKYGenelForm = new IKYGenelForm();
        public GirisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (kullaniciadi.Text='');
            //{
            //form2.TopLevel = false;
            //panel1.Controls.Clear();
            //panel1.Controls.Add(form2);
            //form2.Show();
            //}

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
