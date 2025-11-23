using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HesapMakineApp
{

    public partial class Form1 : Form
    {
        int secim = 0;
        double sayi1, sayi2, sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Buttonlar(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0" || txtDisplay.Text == "Gecersiz") // Gecersiz ya da 0 yazıyorsa 0 sayısını kaldır.
                txtDisplay.Text = "";

            txtDisplay.Text = txtDisplay.Text + ((Button)sender).Text;
        }

        private void btnArti_Click(object sender, EventArgs e) // Secim = 1 (Toplama)
        {
            sayi1 = Double.Parse(txtDisplay.Text);
            secim = 1;
            txtDisplay.Text = "0";
        }

        private void btnEksi_Click(object sender, EventArgs e) // Secim = 2 (Çıkarma)
        {
            sayi1 = Double.Parse(txtDisplay.Text);
            secim = 2;
            txtDisplay.Text = "0";
        }

        private void btnCarpi_Click(object sender, EventArgs e) // Secim = 3 (Çarpma)
        {
            sayi1 = Double.Parse(txtDisplay.Text);
            secim = 3;
            txtDisplay.Text = "0";
        }

        private void btnBolu_Click(object sender, EventArgs e) // Secim = 4 (Bölme)
        {
            sayi1 = Double.Parse(txtDisplay.Text);
            secim = 4;
            txtDisplay.Text = "0";
        }

        private void btnEsittir_Click(object sender, EventArgs e) // İşlemleri yaptıktan sonra o işlemleri gerçekleştiren sonuç çıktısını almak için kullanılır.
        {
            sayi2 = Double.Parse(txtDisplay.Text);
            switch(secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    txtDisplay.Text = sonuc.ToString();
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    txtDisplay.Text = sonuc.ToString();
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    txtDisplay.Text = sonuc.ToString();
                    break;
                case 4:
                    if (sayi2 == 0)
                    {
                        txtDisplay.Text = "Gecersiz";
                        return;
                    }

                    sonuc = sayi1 / sayi2;
                    txtDisplay.Text = sonuc.ToString();
                    break;

            }
        }

        private void btnKok_Click(object sender, EventArgs e) // Sayının kökünü almayı sağlar.
        {
            double sayi = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = (Math.Sqrt(sayi)).ToString();
        }

        private void btnVirgul_Click(object sender, EventArgs e) // Virgüllü sayı oluşturmak için virgül koyar.
        {
            txtDisplay.Text += ".";
        }

        private void btnC_Click(object sender, EventArgs e) // Direkt textteki tüm değerleri siler ve 0 olarak ayarlar.
        {
            txtDisplay.Text = "0";
        }

        private void btnBackSpace_Click(object sender, EventArgs e) // Tek tek silmeyi sağlar.
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);

            if (txtDisplay.Text == "")
                txtDisplay.Text = "0";
        }
    }
}
