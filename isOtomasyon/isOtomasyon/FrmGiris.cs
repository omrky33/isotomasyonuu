using DAL;
using EntityLayer;

namespace isOtomasyon
{
    public partial class FrmGiris : Form
    {

        public FrmGiris()
        {
            InitializeComponent();
        }
        Context context = new Context();
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sisteme hoşgeldiniz. Yönetici iseniz yönetici paneline giriş yapmayı unutmayınız.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (context.Yoneticiler.Where(c => c.AdSoyad == txtYoneticiGir.Text).Any() == true && context.Yoneticiler.Where(c => c.Sifre == txtYoneticiSifre.Text).Any() == true)
            {
                MessageBox.Show("Doğru şifre!");
                FrmYonetici frmYonetici = new FrmYonetici();
                frmYonetici.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!!!");
            }
        }

        public int DepartmentId;
        public int kullaniciId;
        private void button4_Click(object sender, EventArgs e)
        {
            if (context.kullanicilar.Where(c => c.Mail == textBox4.Text).Any() == true && context.kullanicilar.Where(c => c.Sifre == textBox3.Text).Any() == true)
            {
                MessageBox.Show("Doğru şifre!");
                FrmCalisan calisan = new FrmCalisan();


                DepartmentId = context.kullanicilar.Where(c => c.Mail == textBox4.Text).Select(c => c.DepartmanId).FirstOrDefault();
                int KullaniciId = context.kullanicilar.Where(c => c.Mail == textBox4.Text).Select(c => c.Id).FirstOrDefault();
                calisan._departmentId = DepartmentId;
                calisan._kullaniciId = KullaniciId;
                calisan.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!!!");
            }
        }

       
    }
}
