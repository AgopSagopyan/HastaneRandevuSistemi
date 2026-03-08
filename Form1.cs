namespace HastaneRandevuSistemi
{
    using System.Text.RegularExpressions;

    using MySql.Data.MySqlClient;

    public partial class Form1 : Form
    {

        private void ConnectToDatabase()
        {
            string connString = "Server=localhost; Database=deneme; Uid=root; Pwd=kerem4567;";

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    string query = "SHOW DATABASES;";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    var result = cmd.ExecuteScalar();

                    MessageBox.Show($"Connection Successful! Total users: {result}");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            ConnectToDatabase();
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
