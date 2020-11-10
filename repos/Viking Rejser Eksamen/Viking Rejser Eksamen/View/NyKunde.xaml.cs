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
using System.Windows.Shapes;
using Viking_Rejser_Eksamen.ViewModel;

namespace Viking_Rejser_Eksamen.View
{
    /// <summary>
    /// Interaction logic for NyKunde.xaml
    /// </summary>
    public partial class NyKunde : Window
    {
        private readonly NyKundeViewModel viewModel;
        public NyKunde(MainWindow mainWindow)
        {
            InitializeComponent();
            viewModel = new NyKundeViewModel(this, mainWindow);
        }

        private void KundeCreate_Click(object sender, RoutedEventArgs e)
        {
            viewModel.NewCustomer();
        }
    }
}
