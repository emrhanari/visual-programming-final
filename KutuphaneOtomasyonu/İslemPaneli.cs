using KutuphaneOtomasyonu.kayit;
using KutuphaneOtomasyonu.kaynak;
using KutuphaneOtomasyonu.kullanici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class İslemPaneli : Form
    {
        public İslemPaneli()
        {
            InitializeComponent();
        }
        kutuphaneotomasyonuEntities1 db = new kutuphaneotomasyonuEntities1();
        private void İslemPaneli_Load(object sender, EventArgs e)
        {
            //kullanıcı butonları girişte kapalıdır. (ekle-güncelle-sil)
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false;
            silKullanicibtn.Visible = false;

            //kaynak butonları girişte kapalıdır. (ekle-güncelle-sil)
            ekleKaynakbtn.Visible = false;
            guncelleKaynakbtn.Visible = false;
            silKaynakbtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
            }

            KullaniciListeForm klisteForm = new KullaniciListeForm();
            klisteForm.Show();

        }

        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.Show();
        }

        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm ksil = new KullaniciSilForm();
            ksil.Show();
        }

        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleForm kGuncel = new KullaniciGuncelleForm();
            kGuncel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekleKaynakbtn.Visible == false)
            {
                ekleKaynakbtn.Visible = true;
                guncelleKaynakbtn.Visible = true;
                silKaynakbtn.Visible = true;
            }
            else
            {
                ekleKaynakbtn.Visible = false;
                guncelleKaynakbtn.Visible = false;
                silKaynakbtn.Visible = false;
            }

            KaynakListeForm kliste = new KaynakListeForm();
            kliste.Show();
        }

        private void kullaniciBilgiPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ekleKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakEkleForm kEkle = new KaynakEkleForm();
            kEkle.Show();
        }

        private void silKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakSilForm kSil = new KaynakSilForm();
            kSil.Show();
        }

        private void guncelleKaynakbtn_Click(object sender, EventArgs e)
        {
            KaynakGuncelleForm kGuncel = new KaynakGuncelleForm();
            kGuncel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OduncVerForm odunc = new OduncVerForm();
            odunc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GeriAlForm geri = new GeriAlForm();
            geri.Show();
        }

        private void İslemPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
