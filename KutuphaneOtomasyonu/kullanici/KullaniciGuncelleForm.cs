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
    public partial class KullaniciGuncelleForm : Form
    {
        public KullaniciGuncelleForm()
        {
            InitializeComponent();
        }

        kutuphaneotomasyonuEntities1 db = new kutuphaneotomasyonuEntities1();

        public void Listele()
        {
            var kullanicilar = db.kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciGuncelleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var _kullanici = db.kullanicilar.Where(x => x.kullanici_id == secilenId).FirstOrDefault();
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

            db.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            {
                kullaniciAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                kullaniciSoyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                kullaniciTCtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                kullaniciMailtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                kullaniciTeltxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                kullaniciCezatxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("E"))
                    radioE.Checked = true;
                else
                    radioK.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
