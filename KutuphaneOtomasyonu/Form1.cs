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
    public partial class Form1 : Form
    {
        kutuphaneotomasyonuEntities1 db = new kutuphaneotomasyonuEntities1();
        public Form1()
        {
            InitializeComponent();
        }

        private void personelGirisbtn_Click(object sender, EventArgs e)
        {
                string gelenAd = adGiristxt.Text.Trim();
                string gelenSifre = sifreGiristxt.Text.Trim();

                var personel = db.personel.Where(x => x.personel_kullaniciAd.Equals(gelenAd) && x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

                if (personel == null)
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }
                else
                {
                    MessageBox.Show("Başarılı");
                    İslemPaneli panel = new İslemPaneli();
                    panel.Show();
                    this.Hide();
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sifreGiristxt.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
