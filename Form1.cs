namespace HastaneRandevuSistemi
{
    using System.Text.RegularExpressions;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            // Kullanıcı adında rakam kontrolü
            if (Regex.IsMatch(kullaniciAdi, "[0-9]"))
            {
                MessageBox.Show("Kullanıcı adında rakam kullanılamaz!");
                return;
            }

            // Şifrede büyük harf kontrolü
            if (!Regex.IsMatch(sifre, "[A-Z]"))
            {
                MessageBox.Show("Şifre en az 1 büyük harf içermelidir!");
                return;
            }

            // Şifrede özel karakter kontrolü
            if (!Regex.IsMatch(sifre, "[!@#$%^&*]"))
            {
                MessageBox.Show("Şifre en az 1 özel karakter içermelidir!");
                return;
            }

            MessageBox.Show("Giriş başarılı");

        }
    }
}
