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
using Viking_Rejser_Eksamen.ViewModel;

namespace Viking_Rejser_Eksamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creating a viewModel field for the MainWindowViewModel class, so i can access it's methods
        private readonly MainWindowViewModel viewModel;
        private readonly API api;
        public MainWindow()
        {
            InitializeComponent();
            //Assigning the necessary windows for the Viewmodel class
            viewModel = new MainWindowViewModel(this);
            api = new API(this);
            //Using the FillTransportørDataGrid method
            viewModel.FillTransportørDataGrid();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Loading the datagrids with the necessary data
            Model.VikingRejserEksamenDataSet vikingRejserEksamenDataSet = (Model.VikingRejserEksamenDataSet)this.FindResource("vikingRejserEksamenDataSet");
            // Load data into the table Kunder. You can modify this code as needed.
            Model.VikingRejserEksamenDataSetTableAdapters.KunderTableAdapter vikingRejserEksamenDataSetKunderTableAdapter = new Model.VikingRejserEksamenDataSetTableAdapters.KunderTableAdapter();
            vikingRejserEksamenDataSetKunderTableAdapter.Fill(vikingRejserEksamenDataSet.Kunder);
            CollectionViewSource kunderViewSource = (CollectionViewSource)this.FindResource("kunderViewSource");
            kunderViewSource.View.MoveCurrentToFirst();
            // Load data into the table Transportoer. You can modify this code as needed.
            Model.VikingRejserEksamenDataSetTableAdapters.TransportoerTableAdapter vikingRejserEksamenDataSetTransportoerTableAdapter = new Model.VikingRejserEksamenDataSetTableAdapters.TransportoerTableAdapter();
            vikingRejserEksamenDataSetTransportoerTableAdapter.Fill(vikingRejserEksamenDataSet.Transportoer);
            CollectionViewSource transportoerViewSource = (CollectionViewSource)this.FindResource("transportoerViewSource");
            transportoerViewSource.View.MoveCurrentToFirst();
            // Load data into the table Rejsearrangementer. You can modify this code as needed.
            Model.VikingRejserEksamenDataSetTableAdapters.RejsearrangementerTableAdapter vikingRejserEksamenDataSetRejsearrangementerTableAdapter = new Model.VikingRejserEksamenDataSetTableAdapters.RejsearrangementerTableAdapter();
            vikingRejserEksamenDataSetRejsearrangementerTableAdapter.Fill(vikingRejserEksamenDataSet.Rejsearrangementer);
            CollectionViewSource rejsearrangementerViewSource = (CollectionViewSource)this.FindResource("rejsearrangementerViewSource");
            rejsearrangementerViewSource.View.MoveCurrentToFirst();
        }        

        private void newRejseBtn_Click(object sender, RoutedEventArgs e)
        {
            //Using the OpenNewVacationWindow method in the Event: newRejseBtn_Click
            viewModel.OpenNewVacationWindow();
        }

        private void newTilmeldingBtn_Click(object sender, RoutedEventArgs e)
        {
            //Using the OpenNewEnrollmentWindow method in the Event: newTilmeldingBtn_Click
            viewModel.OpenNewEnrollmentWindow();
        }

        private void NewTBtn_Click(object sender, RoutedEventArgs e)
        {
            //Using the OpenNewTransporterWindow method in the Event: NewTbtn_Click
            viewModel.OpenNewTransporterWindow();
        }

        private void NewKundeBtn_Click(object sender, RoutedEventArgs e)
        {
            //Using the OpenNewCustomerWindow method in the Event: NewKundeBtn_Click
            viewModel.OpenNewCustomerWindow();
        }

        private void TilmdeldingerBtn_Click(object sender, RoutedEventArgs e)
        {
            //Using the OpenEnrollmentWindow method in the Event:TilmeldingerBtn_Click
            viewModel.OpenEnrollmentWindow();
        }

        private void GetWeatherBtn_Click(object sender, RoutedEventArgs e)
        {
            api.FillTemperature();
        }
    }
}
