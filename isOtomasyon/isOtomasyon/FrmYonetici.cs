using DAL;
using DAL.Maps;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace isOtomasyon
{
    public partial class FrmYonetici : Form
    {
        public FrmYonetici()
        {
            InitializeComponent();
        }
        Context context = new Context();
        private void FrmYonetici_Load(object sender, EventArgs e)
        {
            var kullanicilar = context.kullanicilar.Include(c => c.Departman).Include(c => c.meslek).Select(c => new
            {
                c.Id,
                c.AdSoyad,
                c.Departman.DepartmanAdi,
                c.meslek.MeslekAdi,

            }).ToList();

            dataGridView1.DataSource = kullanicilar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var departmanlar = context.Departmanlar.ToList();
            dataGridView1.DataSource = departmanlar;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var kullanicilar = context.kullanicilar.Include(c => c.Departman).Include(c => c.meslek).Select(c => new
            {
                c.Id,
                c.AdSoyad,
                c.Departman.DepartmanAdi,
                c.meslek.MeslekAdi,

            }).ToList();

            dataGridView1.DataSource = kullanicilar;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmEklemeler frmEKlemeler = new FrmEklemeler();
            frmEKlemeler.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var meslekler = context.Meslekler.ToList();
            dataGridView1.DataSource = meslekler;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmKayit frmKayit = new FrmKayit();
            frmKayit.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fR fr = new fR();
            fr.Show();
          



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Burada silme işlemimi yaptım.
            var departmanId = Convert.ToInt32(txtDepartmanSil.Text);
            var silinecek = context.Departmanlar.Find(departmanId);

            context.Remove(silinecek);

            context.SaveChanges();

            var departmanlar = context.Departmanlar.ToList();
            dataGridView1.DataSource = departmanlar;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer tıklanan hücre geçerli bir hücre ise
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Tıklanan hücrenin bulunduğu satırdaki ID sütununu al
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string idValue = row.Cells["ID"].Value.ToString();

                // TextBox'a ID değerini yaz
                txtDepartmanSil.Text = idValue;
            }
        }
    }
}
