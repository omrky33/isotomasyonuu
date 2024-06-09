using DAL;
using EntityLayer;
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
    public partial class FrmKayit : Form
    {
        Context context = new Context();
        public FrmKayit()
        {
            InitializeComponent();

        }

        public void FrmKayit_Load(object sender, EventArgs e)
        {
            var departments = context.Departmanlar.ToList();
            var meslekler = context.Meslekler.ToList();

            cbxDepartmen.DataSource = departments;
            cbxDepartmen.DisplayMember = "DepartmanAdi";
            cbxDepartmen.ValueMember = "Id";

            cbxMeslek.DataSource = meslekler;
            cbxMeslek.DisplayMember = "MeslekAdi";
            cbxMeslek.ValueMember = "Id";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var departments = context.Departmanlar.ToList();
            var meslekler = context.Meslekler.ToList();

            


            int departmentId = (int)cbxDepartmen.SelectedValue;
            int meslekId = (int)cbxMeslek.SelectedValue;


            context.kullanicilar.Add(new Kullanici()
            {
                AdSoyad = txtAd.Text,
                DepartmanId = departmentId,
                MeslekId = meslekId,
                Sifre = txtSif.Text,
                Mail = txtMail.Text,

            }); 

            context.SaveChanges();


            MessageBox.Show("KULLANICI KAYDEDİLDİ.");
        }
    }
}
