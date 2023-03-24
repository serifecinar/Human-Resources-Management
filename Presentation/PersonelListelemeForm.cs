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

        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(PersonelListesiListBox.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form3.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form3);
            form3.Show();
        }
    }
}