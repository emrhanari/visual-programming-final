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
    public partial class KaynakSilForm : Form
    {
        public KaynakSilForm()
        {
            InitializeComponent();
        }

        kutuphaneotomasyonuEntities1 db = new kutuphaneotomasyonuEntities1();

        private void KaynakSilForm_Load(object sender, EventArgs e)
        {
            var kaynak = db.kaynaklar.ToList();
            dataGridView1.DataSource = kaynak.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int secilenId =Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var silinenKaynak = db.kaynaklar.Where(x => x.kaynak_id == secilenId).FirstOrDefault();
            db.kaynaklar.Remove(silinenKaynak);
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
