using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Poprigun_DE
{
    /// <summary>
    /// Логика взаимодействия для List.xaml
    /// </summary>
    public partial class List : Page
    {
        public List()
        {
            InitializeComponent();
            var agents = BDEntities.GetContext().agents.ToList();
            foreach(var a in agents)
            {
                a.Logo = "Resources" + a.Logo;
            }
            ListAgent.ItemsSource = agents;
        }

        private void BtnLog(object sender, RoutedEventArgs e)
        {
            MainWindow.MF.Navigate(new Login());
        }
    }
}
