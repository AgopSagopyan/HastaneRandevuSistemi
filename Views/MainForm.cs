namespace HastaneRandevuSistemi.Views
{
    using System.Text.RegularExpressions;
    using HastaneRandevuSistemi.Data;
    using HastaneRandevuSistemi.Services;
    using MySql.Data.MySqlClient;

    public partial class MainForm : Form
    {

        public NavigationService Navigator { get; private set; }


        public void ShowPage(UserControl page)
        {
            Navigator = new NavigationService(panel1);

            panel1.Controls.Clear();
            panel1.Controls.Add(page);
        }

        public MainForm()
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
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginPage girisSayfasi = new LoginPage(this);

            panel1.Controls.Clear();

            panel1.Controls.Add(girisSayfasi);




        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // int result = DatabaseHelper.ExecuteQuery("SHOW DATABASES;");


            //MessageBox.Show(result.ToString());
        }

    }
}
