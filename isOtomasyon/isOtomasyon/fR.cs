using DAL;
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
    public partial class fR : Form
    {
        Context context = new Context();
        public fR()
        {
            InitializeComponent();
        }

        private void fR_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Meslekler.ToList();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Burada silme işlemimi yaptım.
            var meslek = Convert.ToInt32(textBox1.Text);
            var silinecek = context.Meslekler.Find(meslek);

            context.Remove(silinecek);

            context.SaveChanges();

        
           


            dataGridView1.DataSource = context.Meslekler.ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer tıklanan hücre geçerli bir hücre ise
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Tıklanan hücrenin bulunduğu satırdaki ID sütununu al
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string idValue = row.Cells["Id"].Value.ToString();

                // TextBox'a ID değerini yaz
                textBox1.Text = idValue;
            }
        }
    }
}
