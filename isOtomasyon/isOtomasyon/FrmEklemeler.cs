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
    public partial class FrmEklemeler : Form
    {
        Context context = new Context();
        public FrmEklemeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.Departmanlar.Add(new Departman()
            {
                DepartmanAdi = textBox1.Text
            });

            context.SaveChanges();
            MessageBox.Show($"{textBox1.Text} DEPARTMANI EKLENDİ!");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            context.Meslekler.Add(new Meslek()
            {
                MeslekAdi = textBox2.Text
            });
            context.SaveChanges();

            MessageBox.Show($"{textBox2.Text} MESLEK EKLENDİ!");
        }
    }
}
