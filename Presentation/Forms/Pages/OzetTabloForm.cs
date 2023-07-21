using Business.Helper;
using System;
using System.Windows.Forms;

namespace Presentation.Forms.Pages
{
    public partial class OzetTabloForm : Form
    {
        public OzetTabloForm()
        {
            InitializeComponent();
        }

        private void OzetTabloForm_Load(object sender, EventArgs e)
        {
            CinsiyetAtamalari();
        }

        public void CinsiyetAtamalari()
        {
            KadinSayisiLabel.Text = NufusHesaplamalariHelper.KadinSayisi.ToString();
            ErkekSayisiLabel.Text = NufusHesaplamalariHelper.ErkekSayisi.ToString();

            CinsiyetOraniLabel.Text = $"%{NufusHesaplamalariHelper.KadinOrani} - %{NufusHesaplamalariHelper.ErkekOrani}";
        }
    }
}
