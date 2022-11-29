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
            UpdataData();
        }

        private void BtnLog(object sender, RoutedEventArgs e)
        {
            MainWindow.MF.Navigate(new Login());
        }

        private void UpdataData ()
        {
            var AgentAmount = BDEntities.GetContext().agents.ToList();
            foreach (var AA in AgentAmount)
            {
                AA.Logo = "Resources" + AA.Logo;
                var AllAgentAmount = AA.ProductSale.Select(a => a.Amount);
                AA.Amount = (int)AllAgentAmount.Sum();
            }
            ListAgent.ItemsSource = AgentAmount;
        }
    }
}
