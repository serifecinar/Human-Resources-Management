using Business.Services;
using Presentation.Forms.Pages;
using Presentation.Utils;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Presentation
{
    public partial class IKYGenelForm : Form
    {
        PersonelListelemeForm personelListelemeForm = new PersonelListelemeForm();

        GenelService genelService = new GenelService();
        public IKYGenelForm()
        {
            InitializeComponent();
        }

        private void AnasayfaButton_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new AnaMenuForm());
        }

        private void IKYGenelForm_Load(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new AnaMenuForm());
        }

        private void IKYGenelForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void IKYGenelForm_Shown(object sender, EventArgs e)
        {
            AnasayfaButton.Visible = true;
        }
    }
}
