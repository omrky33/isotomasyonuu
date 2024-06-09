using DAL;
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

namespace isOtomasyon
{
    public partial class FrmCalisan : Form
    {
        public FrmCalisan()
        {
            InitializeComponent();
        }
        public int _departmentId;
        public int _kullaniciId;



        Context context = new Context();
        private void FrmCalisan_Load(object sender, EventArgs e)
        {


            var meslektaslar = context.kullanicilar.Include(C => C.Departman).Include(C => C.meslek).Where(C => C.DepartmanId == _departmentId).Select(c => new
            {
                c.AdSoyad,
                c.Departman.DepartmanAdi,
                c.Mail,
                c.meslek.MeslekAdi,

            }).ToList();

            dataGridView1.DataSource = meslektaslar;


            string adSoyad = context.kullanicilar.Where(c => c.Id == _kullaniciId).Select(c => c.AdSoyad).FirstOrDefault();
            string mail = context.kullanicilar.Where(c => c.Id == _kullaniciId).Select(c => c.Mail).FirstOrDefault();
            string Meslek = context.kullanicilar.Include(c => c.meslek).Where(c => c.Id == _kullaniciId).Select(c => c.meslek.MeslekAdi).FirstOrDefault();
            string Department = context.kullanicilar.Include(c => c.Departman).Where(c => c.Id == _kullaniciId).Select(c => c.Departman.DepartmanAdi).FirstOrDefault();




            txtDepart.Text = Department;
            txtMeslek.Text = Meslek;
            txtisim.Text = adSoyad;

            label12.Text = mail;

            textBox1.Text = adSoyad;
            textBox2.Text = mail;

        }

        private void button1_Click(object sender, EventArgs e)
        {
             var kullanici =  context.kullanicilar.Find(_kullaniciId);
            if (kullanici != null)
            {
                kullanici.AdSoyad = textBox1.Text;
                kullanici.Mail = textBox2.Text;

                context.kullanicilar.Update(kullanici);
                 context.SaveChangesAsync();

               
            }
            MessageBox.Show("mail güncellendi.");

            label12.Text = kullanici.Mail;


        }
    }
}
