using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.kaynak
{
    public partial class KaynakGuncelleForm : Form
    {
        public KaynakGuncelleForm()
        {
            InitializeComponent();
        }

        kutuphaneotomasyonuEntities1 db = new kutuphaneotomasyonuEntities1();

        private void KaynakGuncelleForm_Load(object sender, EventArgs e)
        {
            var kaynak = db.kaynaklar.ToList();
            dataGridView1.DataSource = kaynak.ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            adKaynaktxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yazarKaynaktxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            yayıncıKaynaktxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Value =Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value);
            dateTimePicker1.Value =Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenKaynak =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var guncellenecekKaynak = db.kaynaklar.Where(x => x.kaynak_id == secilenKaynak).FirstOrDefault();
            guncellenecekKaynak.kaynak_ad = adKaynaktxt.Text;
            guncellenecekKaynak.kaynak_yazar = yazarKaynaktxt.Text;
            guncellenecekKaynak.kaynak_yayinci = yayıncıKaynaktxt.Text;
            guncellenecekKaynak.kaynak_sayfasayisi =Convert.ToInt16(numericUpDown1.Value);
            guncellenecekKaynak.kaynak_basimtarihi = dateTimePicker1.Value;
            db.SaveChanges();

            var kaynak = db.kaynaklar.ToList();
            dataGridView1.DataSource = kaynak.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
