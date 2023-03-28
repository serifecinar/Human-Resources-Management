using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Presentation
{
    public partial class IKYGenelForm : Form
    {
        PersonelListelemeForm personelListelemeForm = new PersonelListelemeForm();

        public IKYGenelForm()
        {
            InitializeComponent();
        }

        private void AnasayfaButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            personelListelemeForm.TopLevel = false;
            panel1.Controls.Clear();
            AnasayfaButton.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PersonelListelemeButton_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            personelListelemeForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(personelListelemeForm);
            personelListelemeForm.Show();
            AnasayfaButton.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IKYGenelForm_Load(object sender, EventArgs e)
        {

        }
        private void NakilButton_Click(object sender, EventArgs e)
        {
            
        }
        private void YeniKayitButton_Click(object sender, EventArgs e)
        {

        }
        private void GuncelleButton_Click(object sender, EventArgs e)
        {

        }

        private void IKYGenelForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void IKYGenelForm_Shown(object sender, EventArgs e)
        {
            AnasayfaButton.Visible = false;
        }
    }
}
