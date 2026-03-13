using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneRandevuSistemi.Models;
using HastaneRandevuSistemi.Views;

namespace HastaneRandevuSistemi.Controllers
{
    public class MainController {
        private readonly DatabaseModel _model;
        private readonly IDatabaseView _view;

        public DatabaseController(IDatabaseView view) {
            _view = view;
            _model = new DatabaseModel();

            _view.ConnectRequested += OnConnectRequested;
        }

        private void OnConnectRequested(object sender, EventArgs e) { 
            _view.IsConnectButtonEnabled = false;
            _view.StatusText = "Bağlanıyor";

            string result = _model.CheckConnection(_view.ConnectionString);

            _view.StatusText = result;
            _view.IsConnectButtonEnabled = true;
        }

    }
}
