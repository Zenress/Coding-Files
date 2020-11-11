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
    /// Interaction logic for NyTilmelding.xaml
    /// </summary>
    public partial class NyTilmelding : Window
    {
        //Creating a viewModel field for the NyTilmeldingViewModel class, so i can access it's methods
        private readonly NyTilmeldingViewModel viewModel;
        public NyTilmelding(MainWindow mainWindow)
        {
            InitializeComponent();
            //Assigning the necessary windows for the Viewmodel class
            viewModel = new NyTilmeldingViewModel(this,mainWindow);
            //Using the FillCombobox method
            viewModel.FillCombobox();
        }

        private void RejseTilmeldingCreate_Click(object sender, RoutedEventArgs e)
        {
            //Using the NewEnrollment method in the Event: RejseTilmeldingCreate_Click
            viewModel.NewEnrollment();
        }
    }
}
