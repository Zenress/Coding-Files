using EsportDanmark_PEO.ViewModel;
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

namespace EsportDanmark_PEO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainWindowViewModel(this);
        }

        private void PlayerDataBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.OpenPlayerDataBtn();
        }

        private void SponsorDataBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.OpenSponsorDataBtn();
        }

        private void TournamentDataBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.OpenTournamentDataBtn();
        }

        private void EmployeeDataBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.OpenEmployeesDataBtn();
        }
    }
}
