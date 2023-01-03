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
    public partial class KaynakEkleForm : Form
    {
        public KaynakEkleForm()
        {
            InitializeComponent();
        }

        kutuphaneotomasyonuEntities1 db = new kutuphaneotomasyonuEntities1();

        private void button1_Click(object sender, EventArgs e)
        {
            kaynaklar kaynak = new kaynaklar();
            kaynak.kaynak_ad = adKaynaktxt.Text;
            kaynak.kaynak_yazar = yazarKaynaktxt.Text;
            kaynak.kaynak_yayinci = yayıncıKaynaktxt.Text;
            kaynak.kaynak_sayfasayisi = Convert.ToInt16(numericUpDown1.Value);
            kaynak.kaynak_basimtarihi = dateTimePicker1.Value;
            db.kaynaklar.Add(kaynak);
            db.SaveChanges();

            var kliste = db.kaynaklar.ToList();
            dataGridView1.DataSource = kliste.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
