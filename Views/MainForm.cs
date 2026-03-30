namespace HastaneRandevuSistemi.Views
{
    using System.Text.RegularExpressions;
    using HastaneRandevuSistemi.Controllers;
    using HastaneRandevuSistemi.Data;
    using HastaneRandevuSistemi.Repositories;
    using HastaneRandevuSistemi.Services;
    using HastaneRandevuSistemi.Views.Pages;
    using MySql.Data.MySqlClient;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class MainForm : Form
    {
        private readonly NavigationService _navigationService;
        private readonly Controller _controller;
        private readonly MainRepository _mainRepository;

        private readonly MainServices _mainServices;

        public MainForm()
        {
            InitializeComponent();

            _navigationService = new NavigationService(panel1);

            _mainServices = new MainServices();

            _mainRepository = new MainRepository();

            _controller = new Controller(_navigationService, _mainRepository, _mainServices);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //_controller.GoToPage(new SignUp(_mainRepository, _mainServices));

            _controller.GoToLoginPage();

            //_controller.GoToSignUpPage();

        }

    }
}
