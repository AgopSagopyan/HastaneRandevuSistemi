using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuSistemi.Services
{
    public class NavigationService
    {
        private readonly Panel _container;

        public NavigationService(Panel container)
        {
            _container = container;
        }

        public void Navigate(UserControl page)
        {
            _container.Controls.Clear();
            _container.Controls.Add(page);
        }
    }
}
