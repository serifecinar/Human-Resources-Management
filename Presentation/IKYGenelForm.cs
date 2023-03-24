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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            personelListelemeForm.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(personelListelemeForm);
            personelListelemeForm.Show();
        }
    }
}
