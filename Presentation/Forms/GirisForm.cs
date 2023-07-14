using Business.Services;
using Data_Acces.Models;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GirisForm : Form
    {
        IKYGenelForm IKYGenelForm = new IKYGenelForm();
        GirisService girisService = new GirisService();

        Giris giris = new Giris();

        public GirisForm()
        {
            InitializeComponent();
        }

        private void GirisButton_Click(object sender, EventArgs e)
        {
            var kullanicilar = girisService.GetAll();

            var result = kullanicilar.Find(k => k.GirisKullaniciAdi == kullaniciAdiTextBox.Text);

            if (result != null)
            {
                if (result.GirisSifre == sifreTextBox.Text)
                {
                    IKYGenelForm.TopLevel = false;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(IKYGenelForm);
                    IKYGenelForm.Show();

                    MessageBox.Show("Giriş Başarılı");
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
    }
}
