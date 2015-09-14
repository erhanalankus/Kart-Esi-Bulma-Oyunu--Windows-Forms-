using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTheSame.WithResourcesFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KartlariDiz();          
        }

        #region Degisken Tanimlamalari
        int oyunSuresi = 0;
        List<object> butunKartlar = new List<object>();
        bool tiklamayaMusadeVarMi = true;
        Kart birinciTiklanan;
        Kart ikinciTiklanan;
        #endregion

        private void btnBasla_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            foreach (Kart kart in butunKartlar)
            {
                kart.Kapat();
            }
            MeyveDoldur();
            oyunSuresi = 0;
            oyunSuresiTimer.Start();
            btnBasla.Enabled = false;


        }
        
        void KartlariDiz()
        {
            int x = 50, y = 50;
            for (int i = 1; i < 17; i++)
            {
                Kart kart = new Kart();
                kart.Width = 128;
                kart.Height = 128;
                kart.Left += x;
                kart.Top = y;
                kart.BorderStyle = BorderStyle.FixedSingle;
                x += 148;
                if (i % 4 == 0)
                {
                    y += 148;
                    x = 50;
                }
                kart.Image = Properties.Resources.que;
                this.Controls.Add(kart);
                butunKartlar.Add(kart);
            }
        }

        void MeyveDoldur()
        {
            //Meyve resimlerinin adresleri, her biri ikişer kez meyveler dizi değişkenine eklendi
            string[] meyveler = { "\\Resources\\f1.png", "\\Resources\\f1.png", "\\Resources\\f2.png", "\\Resources\\f2.png", "\\Resources\\f3.png", "\\Resources\\f3.png", "\\Resources\\f4.png", "\\Resources\\f4.png", "\\Resources\\f5.png", "\\Resources\\f5.png", "\\Resources\\f6.png", "\\Resources\\f6.png", "\\Resources\\f7.png", "\\Resources\\f7.png", "\\Resources\\f8.png", "\\Resources\\f8.png" };
            foreach (Kart item in butunKartlar)
            {
                int rasgele = 0;
                Random rnd = new Random();
                do
                {
                    rasgele = rnd.Next(0, 16);
                }
                while(meyveler[rasgele] == "");
                item.ResimAdresi = meyveler[rasgele];
                meyveler[rasgele] = "";
                item.Click += item_Click;
            }
        }

        private void oyunSuresiTimer_Tick(object sender, EventArgs e)
        {
            lblOyunSuresi.Text = oyunSuresi.ToString();
            oyunSuresi++;
        }        

        void item_Click(object sender, EventArgs e)
        {
            Kart tiklananKart = sender as Kart;
            if (tiklananKart.KapaliMi() && tiklamayaMusadeVarMi == true)
            {
                if (birinciTiklanan == null)
                {
                    BirinciTiklama(tiklananKart);
                }
                else
                {
                    IkinciTiklama(tiklananKart);
                }
            }

        }

        private void BirinciTiklama(Kart tiklananKart)
        {
            birinciTiklanan = tiklananKart;
            tiklananKart.Ac();
        }

        private void IkinciTiklama(Kart tiklananKart)
        {
            ikinciTiklanan = tiklananKart;
            ikinciTiklanan.Ac();

            if (ResimlerAyniMi(birinciTiklanan, ikinciTiklanan))
            {                
                birinciTiklanan = null;
                ikinciTiklanan = null;                
                OyunBittiMi();

            }
            else
            {
                tiklamayaMusadeVarMi = false;
                onizlemeTimer.Start();
                

            }
        }

        private bool ResimlerAyniMi(Kart birinciTiklanan, Kart ikinciTiklanan)
        {
            if (birinciTiklanan.ResimAdresi == ikinciTiklanan.ResimAdresi)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void onizlemeTimer_Tick(object sender, EventArgs e)
        {

            FarkliCikanlariKapat();
            onizlemeTimer.Stop();
            tiklamayaMusadeVarMi = true;
        }

        private void FarkliCikanlariKapat()
        {
            birinciTiklanan.Kapat();
            ikinciTiklanan.Kapat();
            birinciTiklanan = null;
            ikinciTiklanan = null;
        }

        private void OyunBittiMi()
        {
            bool kapaliKartBuldunMu = false;
            foreach (Kart item in butunKartlar)
            {
                if (item.KapaliMi())
                {
                    kapaliKartBuldunMu = true;
                    break;
                }
            }
            if (kapaliKartBuldunMu == false)
            {
                OyunuBitir();
            }
        }

        private void OyunuBitir()
        {
            oyunSuresiTimer.Stop();
            MessageBox.Show("Oyun Bitti. Tekrar oynamak için Oyunu Başlat'a bas.");
            btnBasla.Enabled = true;
        }
    }
}

