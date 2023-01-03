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
    public partial class GeriAlForm : Form
    {
        public GeriAlForm()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            var kullanicilar = db.kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }

        kutuphaneotomasyonuEntities1 db = new kutuphaneotomasyonuEntities1();
        private void GeriAlForm_Load(object sender, EventArgs e)
        {
            var kayitlar = db.kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();

            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKayitId =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.kayitlar.Where(x => x.kayit_id == secilenKayitId).FirstOrDefault();
            kayit.durum = true;
            db.SaveChanges();
            //liste tazele
            var kayitlar = db.kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilen_kisi = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var _secilen = db.kayitlar.Where(x => x.kayit_id == secilen_kisi).FirstOrDefault();
            _secilen.ceza = textBox1.Text;

            db.SaveChanges();
            Listele();





        }
        private void KullaniciGuncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


        }
    }
}
