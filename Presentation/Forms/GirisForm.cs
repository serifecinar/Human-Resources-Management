using Business.Services;
using Data_Acces.Models;
using Presentation.Forms.Pages;
using Presentation.Utils;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GirisForm : Form
    {
        GirisService girisService = new GirisService();
        GenelService genelService=new GenelService();

        public GirisForm()
        {
            InitializeComponent();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            var kullanicilar = girisService.GetAll();
            var genel = new Genel();    

            var result = kullanicilar.Find(k => k.GirisKullaniciAdi == kullaniciAdiTextBox.Text);

            if (result != null)
            {
                if (result.GirisSifre == sifreTextBox.Text)
                {
                    PageChange.Change(PanelContent, this, FormMemory.ozetTabloForm);
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız", "Başarısız!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı kayıtlı değil");
            }

            if (result.GirisYetki=="Tuzla")
            {

            }
        }
        private void GirisForm_load(object sender, EventArgs e)
        {
            // Enter tuşuna basıldığında KeyPress olayını dinlemek için event handler ekliyoruz.
            this.KeyPress += GirisForm_KeyPress;
        }

        private void GirisForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer Enter tuşuna basıldıysa ve eğer hedef buton etkin değilse,
            // butonu etkin hale getiriyoruz.
            if (e.KeyChar == (char)Keys.Enter && !GirisButton.Enabled)
            {
                GirisButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, FormMemory.ozetTabloForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, FormMemory.personelListelemeForm);
        }

        private void SicilKartiButton_Click(object sender, EventArgs e)
        {

        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
