using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalıtımÖrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            İnsan ins = new İnsan();
            ins.ad = "Mehmet";
            ins.soyad = "Kaya";
            ins.mevki = "Genel Müdür";
            ins.sehir = "Gaziantep";
            ins.yas = 32;

            label16.Text = ins.ad.ToString();
            label15.Text = ins.soyad.ToString();
            label14.Text = ins.mevki.ToString();
            label13.Text = ins.sehir.ToString();
            label12.Text = ins.yas.ToString();


            Personel pers = new Personel();
            pers.departman = "Bilgi İşlem";
            pers.calismasekli = "Yüzyüze";
            pers.calismaplani = "Tam Zamanlı";

            label11.Text = pers.departman.ToString();
            label10.Text = pers.calismasekli.ToString();
            label9.Text = pers.calismaplani.ToString();


            pers.departman = "Bilgi İşlem";
            pers.calismasekli = "Yüzyüze";
            pers.calismasekli = "Stajyer";
            pers.ad = "Ayşe";
            pers.soyad = "Yıldız";
            pers.mevki = "Stajyer Mühendis";
            pers.sehir = "Adana";
            pers.yas = 21;

            label19.Text = pers.departman.ToString();
            label18.Text = pers.calismasekli.ToString();
            label17.Text = pers.calismaplani.ToString();
            label24.Text = pers.ad.ToString();
            label23.Text = pers.soyad.ToString();
            label22.Text = pers.mevki.ToString();
            label21.Text = pers.sehir.ToString();
            label20.Text = pers.yas.ToString();
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
