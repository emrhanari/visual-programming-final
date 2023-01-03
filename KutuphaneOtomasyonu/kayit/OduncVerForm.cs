using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.kayit
{
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }

        kutuphaneotomasyonuEntities1 db = new kutuphaneotomasyonuEntities1();

        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            //listeledik(kayıtlar)
            UpdateKayit();

            //listeledik(kaynaklar)
            var kaynakList = db.kaynaklar.ToList();
            dataGridView2.DataSource = kaynakList.ToList();

            //istenmeyen kaynak ve kullanıcı kolonunu gizledik
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //kolon adları düzenledik
            dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            dataGridView1.Columns[2].HeaderText = "Kaynak Ad";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string arananSecilen = textBox1.Text; 
            var kullaniciVarMi = db.kullanicilar.Where(x => x.kullanici_tc == arananSecilen).FirstOrDefault();

            if (kullaniciVarMi != null)
                label2.Text = kullaniciVarMi.kullanici_ad + " " + kullaniciVarMi.kullanici_soyad;
            else
                label2.Text = "Böyle Bir Kullanıcı Henüz Yok";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox2.Text;
            var bulunanKaynaklar = db.kaynaklar.Where(x => x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kişiyi aldık
            string secilenKisiTC = textBox1.Text;
            var secilenKisi = db.kullanicilar.Where(x => x.kullanici_tc == secilenKisiTC).FirstOrDefault();

            //kitabı aldık
            int secilenKitapId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.kaynaklar.Where(x => x.kaynak_id == secilenKitapId).FirstOrDefault();

            kayitlar yeniKayit = new kayitlar {
                kullanici_id = secilenKisi.kullanici_id,
                kitap_id = secilenKitap.kaynak_id,
                alis_tarih = DateTime.Now,
                son_tarih = DateTime.Now.AddDays(15),
                durum = false,
                ceza = ""};
            //yeniKayit.kullanici_id = secilenKisi.kullanici_id;
            //yeniKayit.kitap_id = secilenKitap.kaynak_id;
            //yeniKayit.alis_tarih = DateTime.Now;
            //yeniKayit.son_tarih = DateTime.Now.AddDays(15);
            db.kayitlar.Add(yeniKayit);
            db.SaveChanges();
            UpdateKayit();
        }
        void UpdateKayit()
        {
            var kayitList = db.kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitList.ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateKayitlar_Click(object sender, EventArgs e)
        {
            UpdateKayit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
