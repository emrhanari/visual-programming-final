using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.kullanici
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        kutuphaneotomasyonuEntities1 db = new kutuphaneotomasyonuEntities1();
        public void Listele()
        {
            var kullanicilar = db.kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanicilar _kullanici = new kullanicilar();
            _kullanici.kullanici_ad = kullaniciAdtxt.Text;
            _kullanici.kullanici_soyad = kullaniciSoyadtxt.Text;
            _kullanici.kullanici_tc = kullaniciTCtxt.Text;
            _kullanici.kullanici_tel = kullaniciTeltxt.Text;
            _kullanici.kullanici_mail = kullaniciMailtxt.Text;
            _kullanici.kullanici_ceza = (float)Convert.ToDouble(kullaniciCezatxt.Text);
            if (radioE.Checked == true)
            {
                _kullanici.kullanici_cinsiyet = "E";
            }
            else if (radioK.Checked == true)
            {
                _kullanici.kullanici_cinsiyet = "K";
            }
            //else
            //{
            //    MessageBox.Show("Lütfen Cinsiyet Seçiniz");
            //}
            db.kullanicilar.Add(_kullanici);
            db.SaveChanges();
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
