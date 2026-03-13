using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Views
{
    public interface IDatabaseView
    {
        string ConnectionString { get; }
        string StatusText { set; }

        bool IsConnectButtonEnabled { set; }


        event EventHandler ConnectRequested;

    }
}
