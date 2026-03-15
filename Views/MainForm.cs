namespace HastaneRandevuSistemi.Views
{
    using System.Text.RegularExpressions;
    using HastaneRandevuSistemi.Controllers;
    using HastaneRandevuSistemi.Data;
    using HastaneRandevuSistemi.Repositories;
    using HastaneRandevuSistemi.Services;
    using MySql.Data.MySqlClient;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class MainForm : Form
    {
        private MainRepository _mainRepository;

        private NavigationService _navigationService;

        private Controller _controller;


        public MainForm()
        {

            InitializeComponent();
            _mainRepository = new MainRepository();
            _navigationService = new NavigationService(panel1);
            _controller = new Controller(_navigationService, this, _mainRepository);
        }



        private void Form1_Load(object sender, EventArgs e)
        {


            AdminPaneli adminPanel = new AdminPaneli(this, _mainRepository, _controller);

            //_controller.GoToAdminPage();

            _controller.GoToLoginPage();


            //_controller.GoToPage(adminPanel);

            //_navigationService.Navigate(adminPanel);


        }


















        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // int result = DatabaseHelper.ExecuteQuery("SHOW DATABASES;");


            //MessageBox.Show(result.ToString());
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

    }
}
