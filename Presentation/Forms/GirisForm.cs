using Business.Helper;
using Business.Services;
using Data_Acces.Models;
using Presentation.Forms.Pages;
using Presentation.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GirisForm : Form
    {
        GirisService girisService = new GirisService();

        public GirisForm()
        {
            InitializeComponent();
            AnasayfaButton.Visible = false;
            PersonelListelemeButton.Visible = false;
            CikisButton.Visible = false;
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            var kullanicilar = girisService.GetAll();
            var genel = new Genel();

            var result = kullanicilar.Find(k => k.GirisKullaniciAdi == kullaniciAdiTextBox.Text);

            if (result != null)
            {
                if (result.GirisSifre == sifreTextBox.Text)
                {

                    GirisYetkiHelper.VeriFiltrele(result.GirisYetki);

                    Statics.GirisYetki = result.GirisYetki;

                    AnasayfaButton.Visible = true;
                    PersonelListelemeButton.Visible = true;
                    CikisButton.Visible = true;

                    PageChange.Change(PanelContent, this, new OzetTabloForm());

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
        }

        private void sifreTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                GirisYap();
            }
        }

        private void PersonelListelemeButton_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new PersonelListelemeForm());
        }

        private void AnasayfaButton_Click(object sender, EventArgs e)
        {
            PageChange.Change(PanelContent, this, new OzetTabloForm());
        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            PageChange.Close(PanelContent, this, GirisTableLayoutPanel);
            Statics.GirisYetki = "";
            kullaniciAdiTextBox.Text = "";
            sifreTextBox.Text = "";
            AnasayfaButton.Visible = false;
            PersonelListelemeButton.Visible = false;
            CikisButton.Visible = false;
        }
    }
}
