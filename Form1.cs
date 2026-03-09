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

                    //MessageBox.Show($"Connection Successful! Total users: {result}");

                    // label4.Text = $"Connection Successful! Total users: {result}";


                }
                catch (MySqlException ex)
                {
                    //MessageBox.Show("Error: " + ex.Message);
                    //                  label4.Text = ex.Message;
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
            //string kullaniciAdi = textBox1.Text;
            //string sifre = textBox2.Text;

            AnaSayfa page = new AnaSayfa();

            // panel2.Controls.Clear();
            //panel2.Controls.Add(page); // No error!

            /*

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
            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GirisYap girisSayfasi = new GirisYap();

            panel1.Controls.Clear();

            panel1.Controls.Add(girisSayfasi);




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // int result = DatabaseHelper.ExecuteQuery("SHOW DATABASES;");

            var result = DatabaseHelper.TestConnection();

            MessageBox.Show(result.ToString());
        }

    }
}
