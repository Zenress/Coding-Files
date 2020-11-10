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
        private readonly MainWindowViewModel viewModel;        
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainWindowViewModel(this);            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

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
            viewModel.OpenNewRejseWindow();
        }

        private void newTilmeldingBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.OpenNewEnrollmentWindow();
        }

        private void NewTBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.OpenNewTransporterWindow();
        }

        private void NewKundeBtn_Click(object sender, RoutedEventArgs e)
        {
            viewModel.OpenNewCustomerWindow();
        }
    }
}
