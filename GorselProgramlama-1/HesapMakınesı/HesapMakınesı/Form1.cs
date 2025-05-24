using System;
using System.Windows.Forms;

namespace HesapMakınesı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            IslemiYap('+');
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            IslemiYap('-');
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            IslemiYap('*');
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            IslemiYap('/');
        }



        private void IslemiYap(char islem)
        {
            double sayi1, sayi2, sonuc = 0;
            if (double.TryParse(txtSayi1.Text, out sayi1) && double.TryParse(txtSayi2.Text, out sayi2))
            {
                switch (islem)
                {
                    case '+':
                        sonuc = sayi1 + sayi2;
                        txtIslem.Text = "Toplama";
                        break;
                    case '-':
                        sonuc = sayi1 - sayi2;
                        txtIslem.Text = "Çıkarma";
                        break;
                    case '*':
                        sonuc = sayi1 * sayi2;
                        txtIslem.Text = "Çarpma";
                        break;
                    case '/':
                        if (sayi2 != 0)
                        {
                            sonuc = sayi1 / sayi2;
                            txtIslem.Text = "Bölme";
                        }
                        else
                        {
                            MessageBox.Show("Sıfıra bölme hatası!");
                            return;
                        }
                        break;
                }

                txtSonuc.Text = sonuc.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli sayılar girin.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
